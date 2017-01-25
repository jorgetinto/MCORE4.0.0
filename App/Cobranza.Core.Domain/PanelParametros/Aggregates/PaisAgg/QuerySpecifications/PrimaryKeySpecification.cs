using System;
using System.Linq.Expressions;
using Cobranza.Core.Domain.PanelParametros.Aggregates.PaisAgg;
using Cobranza.Core.Domain.Seedwork.QuerySpecifications;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Domain.PanelParametros.Aggregates.PaisAgg.QuerySpecifications
{
    public class PrimaryKeySpecification : SpecificationBase<Pais>
    {
        private readonly Pais paisToQuery;

        public PrimaryKeySpecification(Pais paisToQuery)
        {
            this.paisToQuery = paisToQuery;
        }
        public override Expression<Func<Pais, bool>> SatisfiedBy()
        {
            return p => p.CodigoPais == this.paisToQuery.CodigoPais;
        }

        public override Pais EntityToQuery
        {
            get { return this.paisToQuery; }
        }
    }
}
