using Cobranza.Core.Domain.Seedwork;
using Cobranza.Core.Domain.Seedwork.QuerySpecifications;
using Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Configuration;
using Cobranza.Core.Infrastructure.Crosscutting.Seedwork.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Cobranza.Core.Infrastructure.Data.Seedwork
{

    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {

        private readonly IQueryableUnitOfWork _unitOfWork;

        protected Repository(IQueryableUnitOfWork unitOfWork)
        {
            if (unitOfWork == (IUnitOfWork)null)
            {
                throw new ArgumentNullException("unitOfWork");
            }

            this._unitOfWork = unitOfWork;
        }

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return this._unitOfWork;
            }
        }

        public virtual IEnumerable<TEntity> All
        {
            get
            {
                return this.Set;
            }
        }

        protected IDbSet<TEntity> Set
        {
            get { return this._unitOfWork.CreateSet<TEntity>(); }
        }

        public virtual TEntity GetSingleOrDefaultByKey(ISpecification<TEntity> keySpecification)
        {
            if (keySpecification == null)
            {
                throw new ArgumentNullException("keySpecification");
            }

            return this.Set.Where(keySpecification.SatisfiedBy()).SingleOrDefault();
        }

        public virtual void Add(TEntity item)
        {

            if (item != (TEntity)null)
            {
                this.Set.Add(item); // add new item in this set
            }
            else
            {
                LoggerFactory.CreateLog()
                          .Info("No se puede agregar una entidad null. Tipo: {0}", typeof(TEntity).ToString());

            }
        }

        public virtual void Remove(TEntity item)
        {
            if (item != (TEntity)null)
            {
                // attach item if not exist
                this._unitOfWork.Attach(item);

                // set as "removed"
                this.Set.Remove(item);
            }
            else
            {
                LoggerFactory.CreateLog()
                          .Info("No se puede eliminar una entidad null. Tipo: {0}", typeof(TEntity).ToString());
            }
        }

        public virtual void TrackItem(TEntity item)
        {
            if (item != (TEntity)null)
            {
                this._unitOfWork.Attach<TEntity>(item);
            }
            else
            {
                LoggerFactory.CreateLog()
                          .Info("No se puede attach una entidad null. Tipo: {0}", typeof(TEntity).ToString());
            }
        }

        public virtual void Modify(TEntity item)
        {
            if (item != (TEntity)null)
            {
                this._unitOfWork.SetModified(item);
            }
            else
            {
                LoggerFactory.CreateLog()
                          .Info("No se puede modificar una entidad null. Tipo: {0}", typeof(TEntity).ToString());
            }
        }

        public virtual IEnumerable<TEntity> AllMatching(ISpecification<TEntity> specification)
        {
            if (specification == null)
            {
                throw new ArgumentNullException("specification");
            }

            return this.Set.Where(specification.SatisfiedBy());
        }

        public virtual IEnumerable<TEntity> GetPaged<KProperty>(
            int pageIndex,
            int pageCount,
            Expression<Func<TEntity, KProperty>> orderByExpression,
            bool ascending)
        {
            var set = this.Set;

            IOrderedQueryable<TEntity> orderedQueryable;

            if (ascending)
            {
                orderedQueryable = set.OrderBy(orderByExpression);
            }
            else
            {
                orderedQueryable = set.OrderByDescending(orderByExpression);
            }

            return orderedQueryable
                          .Skip(pageCount * pageIndex)
                          .Take(pageCount);
        }

        public virtual IEnumerable<TEntity> GetFiltered(Expression<Func<TEntity, bool>> filter)
        {
            return this.Set.Where(filter);
        }

        public virtual void Merge(TEntity persisted, TEntity current)
        {
            this._unitOfWork.ApplyCurrentValues(persisted, current);
        }

        public virtual bool IsModified(TEntity persisted)
        {
            return this._unitOfWork.IsModified(persisted);
        }

        public void Dispose()
        {
            if (this._unitOfWork != null)
            {
                this._unitOfWork.Dispose();
            }
        }

        public TEntity Create()
        {
            return this.Set.Create();
        }

        public void BulkInsert(IEnumerable<TEntity> entities, string destinationTableName, string[] includedProperties)
        {
            this.BulkInsert<TEntity>(entities, destinationTableName, includedProperties);
        }

        public void BulkInsert<T>(IEnumerable<T> entities, string destinationTableName, string[] includedProperties)
            where T : class
        {
            Type typeOfEntity = typeof(T);

            PropertyInfo[] propertiesOfEntity = typeOfEntity.GetProperties()
                .Where(p => includedProperties.Any(e => e == p.Name)).ToArray();

            using (DataTable table = new DataTable())
            {

                for (int i = 0; i < propertiesOfEntity.Length; i++)
                {
                    table.Columns.Add(new DataColumn(propertiesOfEntity[i].Name));
                }

                foreach (var entity in entities)
                {
                    DataRow row = table.NewRow();

                    for (int i = 0; i < propertiesOfEntity.Length; i++)
                    {
                        row.SetField<object>(i, propertiesOfEntity[i].GetValue(entity, null));
                    }

                    table.Rows.Add(row);
                }

                this.BulkInsert(table, destinationTableName);
            }
        }

        protected void BulkInsert(DataTable table, string destinationTableName)
        {
            try
            {
                this._unitOfWork.Connection.Open();

                using (var bulkInsert = new SqlBulkCopy((SqlConnection)this._unitOfWork.Connection))
                {
                    bulkInsert.BatchSize = AppSettingsHelper.BulkInsertBatchSize;

                    bulkInsert.BulkCopyTimeout = AppSettingsHelper.BulkInsertBulkCopyTimeout;

                    bulkInsert.DestinationTableName = destinationTableName;

                    foreach (DataColumn column in table.Columns)
                    {
                        bulkInsert.ColumnMappings.Add(column.ColumnName, column.ColumnName);
                    }

                    bulkInsert.WriteToServer(table);
                }
            }
            finally
            {
                this._unitOfWork.Connection.Close();
            }
        }

        protected EntityType GetTypeStorageMetadata<T>()
            where T : class
        {
            var storageMetadata = ((EntityConnection)((IObjectContextAdapter)this._unitOfWork)
                                        .ObjectContext.Connection)
                .GetMetadataWorkspace().GetItems(DataSpace.SSpace);

            var entityProps = (from s in storageMetadata
                               where s.BuiltInTypeKind == BuiltInTypeKind.EntityType
                               select s as EntityType);

            var typeStorageMetadata = (from m in entityProps
                                       where m.Name == typeof(T).Name
                                       select m).Single();

            return typeStorageMetadata;
        }

        protected void AddEntitiesAsRowsToTable<T>(
            IEnumerable<T> entities,
            EntityType cuotaStorageMetadata,
            DataTable table,
            string[] excludedProperties)
            where T : class
        {
            PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var entity in entities)
            {
                DataRow dataRow = table.NewRow();

                var metaDataProperties = cuotaStorageMetadata.Properties
                    .Where(item => !excludedProperties.Any(e => e == item.Name))
                    .ToList();

                for (int i = 0; i < metaDataProperties.Count; i++)
                {
                    var item = metaDataProperties[i];

                    var pi = properties.Single(p => p.Name ==
                                                item.MetadataProperties["PreferredName"].Value.ToString());

                    object value = pi.GetValue(entity, null);

                    Type type = Nullable.GetUnderlyingType(pi.PropertyType) ?? pi.PropertyType;

                    dataRow.SetField<object>(item.Name, (value == null) ? null : Convert.ChangeType(value, type));
                }

                table.Rows.Add(dataRow);
            }
        }

    }

}