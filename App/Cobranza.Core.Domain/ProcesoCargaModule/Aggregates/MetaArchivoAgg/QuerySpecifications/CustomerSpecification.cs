using Cobranza.Core.Domain.Seedwork.QuerySpecifications;
using System;
using System.Linq.Expressions;

namespace Cobranza.Core.Domain.ProcesoCargaModule.Aggregates.MetaArchivoAgg.QuerySpecifications
{
    public class CustomerSpecification : SpecificationBase<MetaArchivo>
    {
        private readonly MetaArchivo metaArchivoToQuery;

        public CustomerSpecification(MetaArchivo metaArchivoToQuery)
        {
            this.metaArchivoToQuery = metaArchivoToQuery;
        }

        public override Expression<Func<MetaArchivo, bool>> SatisfiedBy()
        {
            return p => p.CodigoCliente == this.metaArchivoToQuery.CodigoCliente;
        }
    }
}
