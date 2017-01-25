using Cobranza.Core.Domain.Seedwork.ValidationSpecifications;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Cobranza.Core.Domain.ProcesoCargaModule.Aggregates.MetaArchivoAgg.ValidationSpecifications
{
    public class InitDateGreaterThanSpecification : GreaterThanSpecification<MetaArchivo, DateTime>
    {
        public InitDateGreaterThanSpecification(string propertyName, DateTime value)
            : base(propertyName, value)
        {
        }

        public override IDictionary<string, string> GetInvalidationMessages(MetaArchivo candidate)
        {
            if (candidate == null)
            {
                throw new ArgumentNullException("candidate");
            }

            return new Dictionary<string, string>
            {
                { "InitDateGreaterThanSpecification",
                    string.Format(
                        CultureInfo.CurrentCulture, 
                        "La fecha de inicio del archivo ({0}) debe ser mayor a la fecha de inicio del último archivo" + 
                        " ({1}).", 
                        candidate.FechaInicio.ToString("dd-MM-yyyy", CultureInfo.CurrentCulture), 
                        this.Value.ToString("dd-MM-yyyy", CultureInfo.CurrentCulture)) }
            };
        }
    }
}
