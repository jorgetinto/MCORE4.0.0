using System;
using System.Reflection;

namespace Cobranza.Core.Domain.Seedwork.ValidationSpecifications
{
    public abstract class ValueBoundSpecificationBase<TEntity, TValue>
        : SpecificationBase<TEntity>, IValueBoundSpecification<TEntity, TValue>
        where TEntity : class
        where TValue : IComparable<TValue>, IEquatable<TValue>
    {
        private readonly string propertyName;

        private readonly TValue value;

        public ValueBoundSpecificationBase(string propertyName, TValue value)
        {
            this.propertyName = propertyName;

            this.value = value;
        }

        public string PropertyName
        {
            get { return this.propertyName; }
        }

        public TValue Value
        {
            get { return this.value; }
        }

        public override bool IsSatisfiedBy(TEntity candidate)
        {
            object propertyValue = this.GetPropertyValue(candidate);

            return this.IsSatisfyingValue((TValue)propertyValue);
        }

        protected object GetPropertyValue(TEntity candidate)
        {
            PropertyInfo propertyInfo = candidate.GetType().GetProperty(this.propertyName);

            if (propertyInfo == null)
            {
                throw new PropertyNotFoundException(this.propertyName);
            }

            return propertyInfo.GetValue(candidate, null);
        }

        protected abstract bool IsSatisfyingValue(TValue candidateValue);
    }
}