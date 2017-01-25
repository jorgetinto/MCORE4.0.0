using Cobranza.Core.Domain.Seedwork;
using System.Collections.Generic;

namespace Cobranza.Core.Domain.ProcesoCargaModule.Aggregates.MetaArchivoAgg
{
    public interface IMetaArchivoRepository : IRepository<MetaArchivo>
    {
        MetaArchivo GetLastByCustomerAndName(MetaArchivo metaArchivoToQuery);

        IEnumerable<MetaArchivo> GetAllActiveByCustomer(MetaArchivo metaArchivoToQuery);
    }
}
