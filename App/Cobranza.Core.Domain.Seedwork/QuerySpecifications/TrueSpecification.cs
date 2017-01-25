using System;
using System.Linq.Expressions;

namespace Cobranza.Core.Domain.Seedwork.QuerySpecifications
{
    public sealed class TrueSpecification<TEntity>
        : SpecificationBase<TEntity>
        where TEntity : class
    {
        public override Expression<Func<TEntity, bool>> SatisfiedBy()
        {
            bool result = true;

            Expression<Func<TEntity, bool>> trueExpression = t => result;

            return trueExpression;
        }
    }
}
