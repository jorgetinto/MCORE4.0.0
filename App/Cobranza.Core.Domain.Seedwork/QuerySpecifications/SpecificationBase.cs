using System;
using System.Linq.Expressions;

namespace Cobranza.Core.Domain.Seedwork.QuerySpecifications
{
    public abstract class SpecificationBase<TEntity>
         : ISpecification<TEntity>
         where TEntity : class
    {
        public virtual TEntity EntityToQuery
        {
            get
            {
                return null;
            }
        }

        public abstract Expression<Func<TEntity, bool>> SatisfiedBy();

        public static SpecificationBase<TEntity> operator &(
                                                            SpecificationBase<TEntity> leftSideSpecification,
                                                            SpecificationBase<TEntity> rightSideSpecification)
        {
            return new AndSpecification<TEntity>(leftSideSpecification, rightSideSpecification);
        }

        public static SpecificationBase<TEntity> operator |(
                                                            SpecificationBase<TEntity> leftSideSpecification,
                                                            SpecificationBase<TEntity> rightSideSpecification)
        {
            return new OrSpecification<TEntity>(leftSideSpecification, rightSideSpecification);
        }

        public static SpecificationBase<TEntity> operator !(SpecificationBase<TEntity> specification)
        {
            return new NotSpecification<TEntity>(specification);
        }

        public static bool operator false(SpecificationBase<TEntity> specification)
        {
            return false;
        }

        public static bool operator true(SpecificationBase<TEntity> specification)
        {
            return false;
        }
    }
}