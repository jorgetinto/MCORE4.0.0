using System.Linq;
using Cobranza.Core.Domain.PanelParametros.Aggregates.PaisAgg;
using Cobranza.Core.Domain.PanelParametros.Aggregates.PaisAgg.QuerySpecifications;
using Cobranza.Core.Infrastructure.Data.Seedwork;
using Cobranza.Core.Infrastructure.Data.UnitOfWork;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Infrastructure.Data.PanelParametros.Repositories
{
    public class PaisRepository : Repository<Pais>, IPaisRepository
    {
        private readonly CoreUnitOfWork coreUnitOfWork;

        public PaisRepository(CoreUnitOfWork CoreUnitOfWork)
            : base(CoreUnitOfWork)
        {
            this.coreUnitOfWork = CoreUnitOfWork;
        }

        public bool Exists(Pais pais)
        {
            return Set.Where(new PrimaryKeySpecification(pais).SatisfiedBy()).Any();
        }

        public Pais Default
        {
            get
            {
                IsDefaultSpecification isDefaultSpecification = new IsDefaultSpecification();

                return Set.SingleOrDefault(isDefaultSpecification.SatisfiedBy());
            }
        }

        public Pais GetById(Pais pais)
        {
            PrimaryKeySpecification primaryKeySpecification = new PrimaryKeySpecification(pais);

            return Set.SingleOrDefault(primaryKeySpecification.SatisfiedBy());
        }
    }
}
