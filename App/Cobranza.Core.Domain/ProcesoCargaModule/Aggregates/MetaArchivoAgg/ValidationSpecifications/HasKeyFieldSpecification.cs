using Cobranza.Core.Domain.Seedwork.ValidationSpecifications;
using System;
using System.Collections.Generic;

namespace Cobranza.Core.Domain.ProcesoCargaModule.Aggregates.MetaArchivoAgg.ValidationSpecifications
{
    public class HasKeyFieldSpecification : SpecificationBase<MetaArchivo>
    {
        public override bool IsSatisfiedBy(MetaArchivo candidate)
        {
            if (candidate == null)
            {
                throw new ArgumentNullException("candidate");
            }

            return false;
        }

        public override bool IsGeneralizationOf(ISpecification<MetaArchivo> specification)
        {
            throw new NotImplementedException();
        }

        public override bool IsSpecialCaseOf(ISpecification<MetaArchivo> specification)
        {
            throw new NotImplementedException();
        }

        public override IDictionary<string, string> GetInvalidationMessages(MetaArchivo candidate)
        {
            return new Dictionary<string, string>
            {
                { "HasKeyFieldSpecification", "Debe seleccionar al menos un campo como identificador." }
            };
        }
    }
}
