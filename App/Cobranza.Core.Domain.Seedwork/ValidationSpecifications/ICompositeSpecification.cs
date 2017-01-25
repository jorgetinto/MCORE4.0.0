namespace Cobranza.Core.Domain.Seedwork.ValidationSpecifications
{

    public interface ICompositeSpecification<TEntity> : ISpecification<TEntity>
         where TEntity : class
    {

        void Add(ISpecification<TEntity> specification);

    }

}