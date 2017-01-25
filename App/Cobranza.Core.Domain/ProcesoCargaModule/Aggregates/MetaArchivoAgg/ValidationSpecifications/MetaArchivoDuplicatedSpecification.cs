using Cobranza.Core.Domain.Seedwork.ValidationSpecifications;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Cobranza.Core.Domain.ProcesoCargaModule.Aggregates.MetaArchivoAgg.ValidationSpecifications
{
    public class MetaArchivoDuplicatedSpecification : SpecificationBase<MetaArchivo>
    {
        public override bool IsSatisfiedBy(MetaArchivo candidate)
        {
            return candidate != null;
        }

        public override bool IsSpecialCaseOf(ISpecification<MetaArchivo> specification)
        {
            throw new System.NotImplementedException();
        }

        public override bool IsGeneralizationOf(ISpecification<MetaArchivo> specification)
        {
            throw new System.NotImplementedException();
        }

        public override IDictionary<string, string> GetInvalidationMessages(MetaArchivo candidate)
        {
            if (candidate == null)
            {
                throw new ArgumentNullException("candidate");
            }

            return new Dictionary<string, string>
            {
                { "MetaArchivoDuplicatedSpecification",
                    string.Format(
                        CultureInfo.CurrentCulture, 
                        "Ya existe un archivo con el nombre \"{0}\" para el cliente {1}.", 
                        candidate.Nombre)
                }
            };
        }
    }
}
