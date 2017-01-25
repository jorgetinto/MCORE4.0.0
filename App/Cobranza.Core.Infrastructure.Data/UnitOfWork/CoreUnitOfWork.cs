using Cobranza.Core.Domain.Personas.Aggregates.PersonaAgg;
using Cobranza.Core.Infrastructure.Data.Models;
using Cobranza.Core.Infrastructure.Data.Models.Mapping;
using Cobranza.Core.Infrastructure.Data.Seedwork;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace Cobranza.Core.Infrastructure.Data.UnitOfWork
{
    public partial class CoreUnitOfWork : DbContextBase<CoreUnitOfWork>, IQueryableUnitOfWork
    {
        public IDbSet<Comuna> Comunas { get; set; }
        public IDbSet<CondicionPago> CondicionPagoes { get; set; }
        public IDbSet<IdentificadorPersona> IdentificadorPersonas { get; set; }
        public IDbSet<Pais> Pais { get; set; }
        public IDbSet<Parametro> Parametroes { get; set; }
        public IDbSet<Persona> Personas { get; set; }
        public IDbSet<PersonaJuridica> PersonaJuridicas { get; set; }
        public IDbSet<PersonaNatural> PersonaNaturals { get; set; }
        public IDbSet<Region> Regions { get; set; }
        public IDbSet<RolPersona> RolPersonas { get; set; }
        public IDbSet<RolPersonaEmpresaCobranza> RolPersonaEmpresaCobranzas { get; set; }
        public IDbSet<Rubro> Rubroes { get; set; }
        public IDbSet<TipoIdentificadorPersona> TipoIdentificadorPersonas { get; set; }
        public IDbSet<TipoPersona> TipoPersonas { get; set; }


        public IDbConnection Connection
        {
            get { return this.Database.Connection; }
        }

        public IDbSet<TEntity> CreateSet<TEntity>()
             where TEntity : class
        {
            return this.Set<TEntity>();
        }

        public void Attach<TEntity>(TEntity item)
            where TEntity : class
        {
            // attach and set as unchanged
            this.Entry<TEntity>(item).State = EntityState.Unchanged;
        }

        public void SetModified<TEntity>(TEntity item)
            where TEntity : class
        {
            // this operation also attach item in object state manager
            this.Entry<TEntity>(item).State = EntityState.Modified;
        }

        public void ApplyCurrentValues<TEntity>(TEntity original, TEntity current)
            where TEntity : class
        {
            // if it is not attached, attach original and set current values
            this.Entry<TEntity>(original).CurrentValues.SetValues(current);
        }

        public bool IsModified<TEntity>(TEntity original)
            where TEntity : class
        {
            return this.Entry<TEntity>(original).State == EntityState.Modified;
        }

        public void Commit()
        {
            this.SaveChanges();
        }

        public void CommitAndRefreshChanges()
        {
            bool saveFailed = false;

            do
            {
                try
                {
                    this.SaveChanges();

                    saveFailed = false;
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    saveFailed = true;

                    ex.Entries.ToList()
                              .ForEach(entry =>
                              {
                                  entry.OriginalValues.SetValues(entry.GetDatabaseValues());
                              });
                }
            } while (saveFailed);
        }

        public void RollbackChanges()
        {
            // set all entities in change tracker 
            // as 'unchanged state'
            this.ChangeTracker.Entries()
                              .ToList()
                              .ForEach(entry => entry.State = EntityState.Unchanged);
        }

        public IEnumerable<TEntity> ExecuteQuery<TEntity>(string sqlQuery, params object[] parameters)
        {
            return this.Database.SqlQuery<TEntity>(sqlQuery, parameters);
        }

        public int ExecuteCommand(string sqlCommand, params object[] parameters)
        {
            return this.Database.ExecuteSqlCommand(sqlCommand, parameters);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                throw new ArgumentNullException("modelBuilder");
            }

            modelBuilder.Configurations.Add(new ComunaMap());
            modelBuilder.Configurations.Add(new CondicionPagoMap());
            modelBuilder.Configurations.Add(new IdentificadorPersonaMap());
            modelBuilder.Configurations.Add(new PaisMap());
            modelBuilder.Configurations.Add(new ParametroMap());
            modelBuilder.Configurations.Add(new PersonaMap());
            modelBuilder.Configurations.Add(new PersonaJuridicaMap());
            modelBuilder.Configurations.Add(new PersonaNaturalMap());
            modelBuilder.Configurations.Add(new RegionMap());
            modelBuilder.Configurations.Add(new RolPersonaMap());
            modelBuilder.Configurations.Add(new RolPersonaEmpresaCobranzaMap());
            modelBuilder.Configurations.Add(new RubroMap());
            modelBuilder.Configurations.Add(new TipoIdentificadorPersonaMap());
            modelBuilder.Configurations.Add(new TipoPersonaMap());
        }
    }
}