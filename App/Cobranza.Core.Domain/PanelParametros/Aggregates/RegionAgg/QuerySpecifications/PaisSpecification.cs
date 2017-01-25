using System;
using System.Linq.Expressions;
using Cobranza.Core.Domain.PanelParametros.Aggregates.PaisAgg;
using Cobranza.Core.Domain.Seedwork.QuerySpecifications;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Domain.PanelParametros.Aggregates.RegionAgg.QuerySpecifications
{
    public class PaisSpecification : SpecificationBase<Region>
    {
        private readonly Pais paisToQuery;

        public PaisSpecification(Pais paisToQuery)
        {
            this.paisToQuery = paisToQuery;
        }

        public override Expression<Func<Region, bool>> SatisfiedBy()
        {
            return r => r.CodigoPais == paisToQuery.CodigoPais;
        }
    }
}
