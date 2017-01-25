using System.Collections.Generic;
using Cobranza.Core.Domain.Seedwork;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Domain.PanelParametros.Aggregates.RegionAgg
{
    public interface IRegionRepository : IRepository<Region>
    {
        Region Default { get; }

        bool Exists(Region region);

        Region GetById(Region region);

        IEnumerable<Region> GetAllByPais(Pais paisToQuery);
    }
}
