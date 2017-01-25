using System.Collections.Generic;

namespace Cobranza.Core.Domain.Seedwork.Validator
{

    public interface IEntityValidator<TEntity>
            where TEntity : class
    {
        IDictionary<string, string> LastInvalidationMessages { get; }
    }

}