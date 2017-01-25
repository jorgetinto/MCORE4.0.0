using Cobranza.Core.Domain.PanelParametros.Aggregates.RubroAgg;
using Cobranza.Core.Domain.PanelParametros.Aggregates.RubroAgg.QuerySpecifications;
using Cobranza.Core.Infrastructure.Data.Models;
using Cobranza.Core.Infrastructure.Data.Seedwork;
using Cobranza.Core.Infrastructure.Data.UnitOfWork;
using System.Linq;

namespace Cobranza.Core.Infrastructure.Data.PanelParametros.Repositories
{
    public class RubroRepository : Repository<Rubro>, IRubroRepository
    {
        private readonly CoreUnitOfWork coreUnitOfWork;

        public RubroRepository(CoreUnitOfWork CoreUnitOfWork)
            : base(CoreUnitOfWork)
        {
            this.coreUnitOfWork = CoreUnitOfWork;
        }

        public bool Exists(Rubro rubro)
        {
            return Set.Where(new PrimaryKeySpecification(rubro).SatisfiedBy()).Any();
        }

        public Rubro GetById(Rubro rubro)
        {
            PrimaryKeySpecification primaryKeySpecification = new PrimaryKeySpecification(rubro);

            return Set.SingleOrDefault(primaryKeySpecification.SatisfiedBy());
        }

    }
}
