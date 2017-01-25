using System;
using System.Linq.Expressions;

namespace Cobranza.Core.Domain.Seedwork.QuerySpecifications
{
    public sealed class DirectSpecification<TEntity>
        : SpecificationBase<TEntity>
        where TEntity : class
    {
        private readonly Expression<Func<TEntity, bool>> matchingCriteria;

        public DirectSpecification(Expression<Func<TEntity, bool>> matchingCriteria)
        {
            if (matchingCriteria == (Expression<Func<TEntity, bool>>)null)
            {
                throw new ArgumentNullException("matchingCriteria");
            }

            this.matchingCriteria = matchingCriteria;
        }

        public override Expression<Func<TEntity, bool>> SatisfiedBy()
        {
            return this.matchingCriteria;
        }
    }
}
