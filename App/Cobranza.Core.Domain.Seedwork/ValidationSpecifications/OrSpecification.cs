using System.Linq;

namespace Cobranza.Core.Domain.Seedwork.ValidationSpecifications
{
    public class OrSpecification<TEntity> : CompositeSpecificationBase<TEntity>
       where TEntity : class
    {

        public override bool IsSatisfiedBy(TEntity candidate)
        {
            return this.specifications.Any(s => s.IsSatisfiedBy(candidate));
        }
    }
}
