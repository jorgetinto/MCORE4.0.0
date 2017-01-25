using Cobranza.Core.Domain.Seedwork;
using System.Data;
using System.Data.Entity;

namespace Cobranza.Core.Infrastructure.Data.Seedwork
{
    public interface IQueryableUnitOfWork
        : IUnitOfWork, ISql
    {
        IDbConnection Connection { get; }

        IDbSet<TEntity> CreateSet<TEntity>() where TEntity : class;

        void Attach<TEntity>(TEntity item) where TEntity : class;

        void SetModified<TEntity>(TEntity item) where TEntity : class;

        void ApplyCurrentValues<TEntity>(TEntity original, TEntity current) where TEntity : class;

        bool IsModified<TEntity>(TEntity original) where TEntity : class;
    }
}