using System;
using System.Linq.Expressions;
using Cobranza.Core.Domain.Seedwork.QuerySpecifications;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Domain.PanelParametros.Aggregates.CondicionPagoAgg.QuerySpecifications
{
    public class PrimaryKeySpecification : SpecificationBase<CondicionPago>
    {
        private readonly CondicionPago condicionPagoToQuery;

        public PrimaryKeySpecification(CondicionPago condicionPagoToQuery)
        {
            this.condicionPagoToQuery = condicionPagoToQuery;
        }
        public override Expression<Func<CondicionPago, bool>> SatisfiedBy()
        {
            return p => p.IdCondicionPago == this.condicionPagoToQuery.IdCondicionPago;
        }

        public override CondicionPago EntityToQuery
        {
            get { return this.condicionPagoToQuery; }
        }
    }
}
