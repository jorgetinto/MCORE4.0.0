using System.Linq;
using Cobranza.Core.Domain.PanelParametros.Aggregates.CondicionPagoAgg;
using Cobranza.Core.Domain.PanelParametros.Aggregates.CondicionPagoAgg.QuerySpecifications;
using Cobranza.Core.Infrastructure.Data.Seedwork;
using Cobranza.Core.Infrastructure.Data.UnitOfWork;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Infrastructure.Data.PanelParametros.Repositories
{
    public class CondicionPagoRepository : Repository<CondicionPago>, ICondicionPagoRepository
    {
        private readonly CoreUnitOfWork coreUnitOfWork;

        public CondicionPagoRepository(CoreUnitOfWork CoreUnitOfWork)
            : base(CoreUnitOfWork)
        {
            this.coreUnitOfWork = CoreUnitOfWork;
        }

        public bool Exists(CondicionPago condicionPago)
        {
            return Set.Where(new PrimaryKeySpecification(condicionPago).SatisfiedBy()).Any();
        }

        public CondicionPago GetById(CondicionPago condicionPago)
        {
            PrimaryKeySpecification primaryKeySpecification = new PrimaryKeySpecification(condicionPago);

            return Set.SingleOrDefault(primaryKeySpecification.SatisfiedBy());
        }
    }
}
