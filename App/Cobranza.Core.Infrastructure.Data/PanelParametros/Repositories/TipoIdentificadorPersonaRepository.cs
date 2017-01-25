using System.Linq;
using Cobranza.Core.Domain.PanelParametros.Aggregates.TipoIdentificadorPersonaAgg;
using Cobranza.Core.Domain.PanelParametros.Aggregates.TipoIdentificadorPersonaAgg.QuerySpecifications;
using Cobranza.Core.Infrastructure.Data.Seedwork;
using Cobranza.Core.Infrastructure.Data.UnitOfWork;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Infrastructure.Data.PanelParametros.Repositories
{
    public class TipoIdentificadorPersonaRepository :
                                                Repository<TipoIdentificadorPersona>,
                                                ITipoIdentificadorPersonaRepository
    {
        private readonly CoreUnitOfWork coreUnitOfWork;

        public TipoIdentificadorPersonaRepository(CoreUnitOfWork CoreUnitOfWork)
            : base(CoreUnitOfWork)
        {
            this.coreUnitOfWork = CoreUnitOfWork;
        }

        public bool Exists(TipoIdentificadorPersona tipoIdentificadorPersona)
        {
            return Set.Where(new PrimaryKeySpecification(tipoIdentificadorPersona).SatisfiedBy()).Any();
        }

        public TipoIdentificadorPersona GetById(TipoIdentificadorPersona tipoIdentificadorPersona)
        {
            PrimaryKeySpecification primaryKeySpecification = new PrimaryKeySpecification(tipoIdentificadorPersona);

            return Set.SingleOrDefault(primaryKeySpecification.SatisfiedBy());
        }
    }
}
