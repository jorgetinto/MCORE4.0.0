using System;
using System.Linq.Expressions;
using Cobranza.Core.Domain.Seedwork.QuerySpecifications;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Domain.PanelParametros.Aggregates.RegionAgg.QuerySpecifications
{
    public class IsDefaultSpecification : SpecificationBase<Region>
    {
        public override Expression<Func<Region, bool>> SatisfiedBy()
        {
            return p => p.EsDefault;
        }
    }
}
