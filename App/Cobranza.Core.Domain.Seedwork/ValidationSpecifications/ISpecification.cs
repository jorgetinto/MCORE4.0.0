using System.Collections.Generic;

namespace Cobranza.Core.Domain.Seedwork.ValidationSpecifications
{
    public interface ISpecification<TEntity>
        where TEntity : class
    {
        bool IsSatisfiedBy(TEntity candidate);

        bool IsSpecialCaseOf(ISpecification<TEntity> specification);

        bool IsGeneralizationOf(ISpecification<TEntity> specification);

        ISpecification<TEntity> RemainderUnsatisfiedBy(TEntity candidate);

        IDictionary<string, string> GetInvalidationMessages(TEntity candidate);

        ISpecification<TEntity> And(ISpecification<TEntity> specification);

        ISpecification<TEntity> Or(ISpecification<TEntity> specification);

        ISpecification<TEntity> Not();
    }
}
