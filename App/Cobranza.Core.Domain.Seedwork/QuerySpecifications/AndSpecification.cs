using System;
using System.Linq.Expressions;

namespace Cobranza.Core.Domain.Seedwork.QuerySpecifications
{
    public sealed class AndSpecification<TEntity>
       : CompositeSpecificationBase<TEntity>
       where TEntity : class
    {
        private readonly ISpecification<TEntity> rightSideSpecification;

        private readonly ISpecification<TEntity> leftSideSpecification;

        public AndSpecification(ISpecification<TEntity> leftSide, ISpecification<TEntity> rightSide)
        {
            if (leftSide == (ISpecification<TEntity>)null)
            {
                throw new ArgumentNullException("leftSide");
            }

            if (rightSide == (ISpecification<TEntity>)null)
            {
                throw new ArgumentNullException("rightSide");
            }

            this.leftSideSpecification = leftSide;

            this.rightSideSpecification = rightSide;
        }

        public override ISpecification<TEntity> LeftSideSpecification
        {
            get { return this.leftSideSpecification; }
        }

        public override ISpecification<TEntity> RightSideSpecification
        {
            get { return this.rightSideSpecification; }
        }

        public override Expression<Func<TEntity, bool>> SatisfiedBy()
        {
            Expression<Func<TEntity, bool>> left = this.leftSideSpecification.SatisfiedBy();

            Expression<Func<TEntity, bool>> right = this.rightSideSpecification.SatisfiedBy();

            return left.And(right);
        }
    }
}
