using System;
using System.Linq.Expressions;
using Cobranza.Core.Domain.PanelParametros.Aggregates.RegionAgg;
using Cobranza.Core.Domain.Seedwork.QuerySpecifications;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Domain.PanelParametros.Aggregates.RegionAgg.QuerySpecifications
{
    public class PrimaryKeySpecification : SpecificationBase<Region>
    {
        private readonly Region regionToQuery;

        public PrimaryKeySpecification(Region regionToQuery)
        {
            this.regionToQuery = regionToQuery;
        }

        public override Expression<Func<Region, bool>> SatisfiedBy()
        {
            return p => p.IdRegion == this.regionToQuery.IdRegion;
        }

        public override Region EntityToQuery
        {
            get { return this.regionToQuery; }
        }
    }
}
