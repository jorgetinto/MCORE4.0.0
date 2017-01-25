using System.Linq;
using Cobranza.Core.Domain.PanelParametros.Aggregates.ComunaAgg;
using Cobranza.Core.Domain.PanelParametros.Aggregates.ComunaAgg.QuerySpecifications;
using Cobranza.Core.Infrastructure.Data.Seedwork;
using Cobranza.Core.Infrastructure.Data.UnitOfWork;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Infrastructure.Data.PanelParametros.Repositories
{
    public class ComunaRepository : Repository<Comuna>, IComunaRepository
    {
        private readonly CoreUnitOfWork coreUnitOfWork;

        public ComunaRepository(CoreUnitOfWork CoreUnitOfWork)
            : base(CoreUnitOfWork)
        {
            this.coreUnitOfWork = CoreUnitOfWork;
        }

        public bool Exists(Comuna comuna)
        {
            return Set.Where(new PrimaryKeySpecification(comuna).SatisfiedBy()).Any();
        }

        public Comuna Default
        {
            get
            {
                IsDefaultSpecification isDefaultSpecification = new IsDefaultSpecification();

                return Set.SingleOrDefault(isDefaultSpecification.SatisfiedBy());
            }
        }

        public Comuna GetById(Comuna comuna)
        {
            PrimaryKeySpecification primaryKeySpecification = new PrimaryKeySpecification(comuna);

            return Set.SingleOrDefault(primaryKeySpecification.SatisfiedBy());
        }
    }
}