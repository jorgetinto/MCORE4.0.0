using System;
using System.Collections.Generic;

namespace Cobranza.Core.Domain.Seedwork.ValidationSpecifications
{
    public class NotSpecification<TEntity> : SpecificationBase<TEntity>
        where TEntity : class
    {
        private readonly ISpecification<TEntity> originalSpecification;

        public NotSpecification(ISpecification<TEntity> originalSpecification)
        {
            this.originalSpecification = originalSpecification;
        }

        public override bool IsSatisfiedBy(TEntity candidate)
        {
            return !this.originalSpecification.IsSatisfiedBy(candidate);
        }

        public override bool IsSpecialCaseOf(ISpecification<TEntity> specification)
        {
            throw new NotSupportedException();
        }

        public override bool IsGeneralizationOf(ISpecification<TEntity> specification)
        {
            throw new NotSupportedException();
        }

        public override IDictionary<string, string> GetInvalidationMessages(TEntity candidate)
        {
            throw new NotSupportedException();
        }
    }
}
