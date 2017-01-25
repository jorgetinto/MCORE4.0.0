using Cobranza.Core.Domain.Seedwork.QuerySpecifications;
using System;
using System.Linq.Expressions;

namespace Cobranza.Core.Domain.ProcesoCargaModule.Aggregates.MetaArchivoAgg.QuerySpecifications
{
    public class PrimaryKeySpecification : SpecificationBase<MetaArchivo>
    {
        private readonly MetaArchivo metaArchivoToQuery;

        public PrimaryKeySpecification(MetaArchivo metaArchivoToQuery)
        {
            this.metaArchivoToQuery = metaArchivoToQuery;
        }

        public override Expression<Func<MetaArchivo, bool>> SatisfiedBy()
        {
            return p => p.IdMetaArchivo == this.metaArchivoToQuery.IdMetaArchivo;
        }

        public override MetaArchivo EntityToQuery
        {
            get { return this.metaArchivoToQuery; }
        }
    }
}