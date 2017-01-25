using System.Collections.Generic;

namespace Cobranza.Core.Domain.Seedwork.ValidationSpecifications
{
    public class NullSpecification<TEntity> : SpecificationBase<TEntity>, ISpecification<TEntity>
        where TEntity : class
    {

        public override bool IsSatisfiedBy(TEntity candidate)
        {
            return false;
        }

        public override bool IsSpecialCaseOf(ISpecification<TEntity> specification)
        {
            return false;
        }

        public override bool IsGeneralizationOf(ISpecification<TEntity> specification)
        {
            return false;
        }

        public override ISpecification<TEntity> RemainderUnsatisfiedBy(TEntity candidate)
        {
            return this;
        }

        public override IDictionary<string, string> GetInvalidationMessages(TEntity candidate)
        {
            return new Dictionary<string, string>();
        }

        public override ISpecification<TEntity> And(ISpecification<TEntity> specification)
        {
            return this;
        }

        public override ISpecification<TEntity> Or(ISpecification<TEntity> specification)
        {
            return this;
        }

    }
}
