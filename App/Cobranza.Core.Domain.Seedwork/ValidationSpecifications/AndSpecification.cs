using System.Linq;

namespace Cobranza.Core.Domain.Seedwork.ValidationSpecifications
{
    public class AndSpecification<TEntity> : CompositeSpecificationBase<TEntity>
       where TEntity : class
    {
        public override bool IsSatisfiedBy(TEntity candidate)
        {
            return this.specifications.All(s => s.IsSatisfiedBy(candidate));
        }
    }
}
