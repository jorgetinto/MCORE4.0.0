using System;
using System.Collections.Generic;

namespace Cobranza.Core.Domain.Seedwork.ValidationSpecifications
{
    public class EqualsSpecification<TEntity, TValue> : ValueBoundSpecificationBase<TEntity, TValue>
        where TEntity : class
        where TValue : IComparable<TValue>, IEquatable<TValue>
    {

        public EqualsSpecification(string propertyName, TValue value)
            : base(propertyName, value)
        {

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

        protected override bool IsSatisfyingValue(TValue candidateValue)
        {
            return object.Equals(candidateValue, this.Value);
        }

    }
}
