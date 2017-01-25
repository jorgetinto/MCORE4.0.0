using System.Collections.Generic;

namespace Cobranza.Core.Domain.Seedwork.ValidationSpecifications
{
    public abstract class SpecificationBase<TEntity> : ISpecification<TEntity>
        where TEntity : class
    {
        public abstract bool IsSatisfiedBy(TEntity candidate);

        public abstract bool IsSpecialCaseOf(ISpecification<TEntity> specification);

        public abstract bool IsGeneralizationOf(ISpecification<TEntity> specification);

        public abstract IDictionary<string, string> GetInvalidationMessages(TEntity candidate);

        public virtual ISpecification<TEntity> RemainderUnsatisfiedBy(TEntity candidate)
        {
            if (!this.IsSatisfiedBy(candidate))
            {
                return this;
            }
            else
            {
                return new NullSpecification<TEntity>();
            }
        }

        public virtual ISpecification<TEntity> And(ISpecification<TEntity> specification)
        {
            var andSpecification = new AndSpecification<TEntity>();

            andSpecification.Add(this);

            andSpecification.Add(specification);

            return andSpecification;
        }

        public virtual ISpecification<TEntity> Or(ISpecification<TEntity> specification)
        {
            var orSpecification = new OrSpecification<TEntity>();

            orSpecification.Add(this);

            orSpecification.Add(specification);

            return orSpecification;
        }

        public virtual ISpecification<TEntity> Not()
        {
            return new NotSpecification<TEntity>(this);
        }
    }
}
