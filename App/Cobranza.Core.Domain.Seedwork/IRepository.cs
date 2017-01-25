using Cobranza.Core.Domain.Seedwork.QuerySpecifications;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Cobranza.Core.Domain.Seedwork
{
    public interface IRepository<TEntity> : IDisposable
        where TEntity : class
    {
        IUnitOfWork UnitOfWork { get; }

        IEnumerable<TEntity> All { get; }

        TEntity GetSingleOrDefaultByKey(ISpecification<TEntity> keySpecification);

        void Add(TEntity item);

        void Remove(TEntity item);

        void Modify(TEntity item);

        void TrackItem(TEntity item);

        void Merge(TEntity persisted, TEntity current);

        bool IsModified(TEntity persisted);

        IEnumerable<TEntity> AllMatching(ISpecification<TEntity> specification);

        IEnumerable<TEntity> GetPaged<KProperty>(
            int pageIndex,
            int pageCount,
            Expression<Func<TEntity, KProperty>> orderByExpression,
            bool ascending);

        IEnumerable<TEntity> GetFiltered(Expression<Func<TEntity, bool>> filter);

        TEntity Create();

        void BulkInsert(IEnumerable<TEntity> entities, string destinationTableName, string[] includedProperties);

        void BulkInsert<T>(IEnumerable<T> entities, string destinationTableName, string[] includedProperties)
            where T : class;
    }
}