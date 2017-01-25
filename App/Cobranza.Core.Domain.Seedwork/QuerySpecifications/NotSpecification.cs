using System;
using System.Linq;
using System.Linq.Expressions;

namespace Cobranza.Core.Domain.Seedwork.QuerySpecifications
{
    public sealed class NotSpecification<TEntity>
        : SpecificationBase<TEntity>
        where TEntity : class
    {
        private readonly Expression<Func<TEntity, bool>> originalCriteria;

        public NotSpecification(ISpecification<TEntity> originalSpecification)
        {
            if (originalSpecification == (ISpecification<TEntity>)null)
            {
                throw new ArgumentNullException("originalSpecification");
            }

            this.originalCriteria = originalSpecification.SatisfiedBy();
        }

        public NotSpecification(Expression<Func<TEntity, bool>> originalSpecification)
        {
            if (originalSpecification == (Expression<Func<TEntity, bool>>)null)
            {
                throw new ArgumentNullException("originalSpecification");
            }

            this.originalCriteria = originalSpecification;
        }

        public override Expression<Func<TEntity, bool>> SatisfiedBy()
        {
            return Expression.Lambda<Func<TEntity, bool>>(
                                                        Expression.Not(this.originalCriteria.Body),
                                                        this.originalCriteria.Parameters.Single());
        }
    }
}
