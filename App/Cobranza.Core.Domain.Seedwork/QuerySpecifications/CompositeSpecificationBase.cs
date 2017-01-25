namespace Cobranza.Core.Domain.Seedwork.QuerySpecifications
{
    public abstract class CompositeSpecificationBase<TEntity>
         : SpecificationBase<TEntity>
         where TEntity : class
    {
        public abstract ISpecification<TEntity> LeftSideSpecification { get; }

        public abstract ISpecification<TEntity> RightSideSpecification { get; }
    }
}