using Cobranza.Core.Domain.ProcesoCargaModule.Aggregates.MetaArchivoAgg;
using Cobranza.Core.Domain.ProcesoCargaModule.Aggregates.MetaArchivoAgg.QuerySpecifications;
using Cobranza.Core.Infrastructure.Data.Seedwork;
using Cobranza.Core.Infrastructure.Data.UnitOfWork;
using System.Collections.Generic;
using System.Linq;

namespace Cobranza.Core.Infrastructure.Data.ProcesoCargaModule.Repositories
{
    public class MetaArchivoRepository : Repository<MetaArchivo>, IMetaArchivoRepository
    {
        private readonly CoreUnitOfWork importeExporteUnitOfWork;

        public MetaArchivoRepository(CoreUnitOfWork importeExporteUnitOfWork)
            : base(importeExporteUnitOfWork)
        {
            this.importeExporteUnitOfWork = importeExporteUnitOfWork;
        }

        public override IEnumerable<MetaArchivo> All
        {
            get
            {
                return Set.OrderBy(ma => ma.FechaTermino)
                    .ThenBy(ma => ma.Nombre)
                    .ThenByDescending(ma => ma.NumeroVersion);
            }
        }

        public MetaArchivo GetLastByCustomerAndName(MetaArchivo metaArchivoToQuery)
        {
            return Set.Where((new CustomerSpecification(metaArchivoToQuery) &
                                new NameSpecification(metaArchivoToQuery)).SatisfiedBy())
                                .OrderByDescending(ma => ma.IdMetaArchivo)
                                .FirstOrDefault();
        }

        public IEnumerable<MetaArchivo> GetAllActiveByCustomer(MetaArchivo metaArchivoToQuery)
        {
            return Set.Where((new CustomerSpecification(metaArchivoToQuery) &
                                new ActiveSpecification()).SatisfiedBy());
        }
    }
}