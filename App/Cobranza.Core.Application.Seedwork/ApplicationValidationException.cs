using System;
using System.Collections.Generic;

namespace Cobranza.Core.Application.Seedwork
{
    // TODO: Evaluar cohesión en cross-cutting
    public class ApplicationValidationException
        : Exception
    {
        private readonly IDictionary<string, string> invalidationMessages;

        public ApplicationValidationException(IDictionary<string, string> validationErrors)
            : base("Validation exception, check InvalidationMessages for more information.")
        {
            this.invalidationMessages = validationErrors;
        }

        public IDictionary<string, string> InvalidationMessages
        {
            get
            {
                return this.invalidationMessages;
            }
        }
    }
}