using Cobranza.Core.Domain.Seedwork.QuerySpecifications;
using System;
using System.Linq.Expressions;

namespace Cobranza.Core.Domain.ProcesoCargaModule.Aggregates.MetaArchivoAgg.QuerySpecifications
{
    public class ActiveSpecification : SpecificationBase<MetaArchivo>
    {
        public override Expression<Func<MetaArchivo, bool>> SatisfiedBy()
        {
            return m => m.FechaTermino == null;
        }
    }
}