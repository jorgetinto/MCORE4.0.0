using System;

namespace Cobranza.Core.Domain.Seedwork.ValidationSpecifications
{
    public interface IValueBoundSpecification<TEntity, TValue> : ISpecification<TEntity>
        where TEntity : class
        where TValue : IComparable<TValue>, IEquatable<TValue>
    {

        string PropertyName { get; }

        TValue Value { get; }

    }
}
