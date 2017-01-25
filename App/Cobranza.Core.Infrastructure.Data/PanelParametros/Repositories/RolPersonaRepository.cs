using System.Linq;
using Cobranza.Core.Domain.PanelParametros.Aggregates.RolPersonaAgg;
using Cobranza.Core.Domain.PanelParametros.Aggregates.RolPersonaAgg.QuerySpecifications;
using Cobranza.Core.Infrastructure.Data.Seedwork;
using Cobranza.Core.Infrastructure.Data.UnitOfWork;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Infrastructure.Data.PanelParametros.Repositories
{
    public class RolPersonaRepository : Repository<RolPersona>, IRolPersonaRepository
    {
        private readonly CoreUnitOfWork coreUnitOfWork;

        public RolPersonaRepository(CoreUnitOfWork CoreUnitOfWork)
            : base(CoreUnitOfWork)
        {
            this.coreUnitOfWork = CoreUnitOfWork;
        }

        public bool Exists(RolPersona rolPersona)
        {
            return Set.Where(new PrimaryKeySpecification(rolPersona).SatisfiedBy()).Any();
        }

        public RolPersona GetById(RolPersona rolPersona)
        {
            PrimaryKeySpecification primaryKeySpecification = new PrimaryKeySpecification(rolPersona);

            return Set.SingleOrDefault(primaryKeySpecification.SatisfiedBy());
        }
    }
}
