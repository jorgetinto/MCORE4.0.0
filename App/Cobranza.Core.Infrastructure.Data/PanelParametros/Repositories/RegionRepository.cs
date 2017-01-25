using System.Collections.Generic;
using System.Linq;
using Cobranza.Core.Domain.PanelParametros.Aggregates.PaisAgg;
using Cobranza.Core.Domain.PanelParametros.Aggregates.RegionAgg;
using Cobranza.Core.Domain.PanelParametros.Aggregates.RegionAgg.QuerySpecifications;
using Cobranza.Core.Infrastructure.Data.Seedwork;
using Cobranza.Core.Infrastructure.Data.UnitOfWork;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Infrastructure.Data.PanelParametros.Repositories
{
    public class RegionRepository : Repository<Region>, IRegionRepository
    {
        private readonly CoreUnitOfWork coreUnitOfWork;

        public RegionRepository(CoreUnitOfWork CoreUnitOfWork)
            : base(CoreUnitOfWork)
        {
            this.coreUnitOfWork = CoreUnitOfWork;
        }

        public bool Exists(Region region)
        {
            return Set.Where(new PrimaryKeySpecification(region).SatisfiedBy()).Any();
        }

        public Region Default
        {
            get
            {
                IsDefaultSpecification isDefaultSpecification = new IsDefaultSpecification();

                return Set.SingleOrDefault(isDefaultSpecification.SatisfiedBy());
            }
        }

        public Region GetById(Region region)
        {
            PrimaryKeySpecification primaryKeySpecification = new PrimaryKeySpecification(region);

            return Set.SingleOrDefault(primaryKeySpecification.SatisfiedBy());
        }

        public IEnumerable<Region> GetAllByPais(Pais paisToQuery)
        {
            return Set.Where(new PaisSpecification(paisToQuery).SatisfiedBy());
        }
    }
}