using System;
using System.Linq.Expressions;
using Cobranza.Core.Domain.Seedwork.QuerySpecifications;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Domain.PanelParametros.Aggregates.PaisAgg.QuerySpecifications
{
    public class IsDefaultSpecification : SpecificationBase<Pais>
    {
        public override Expression<Func<Pais, bool>> SatisfiedBy()
        {
            return p => p.EsDefault;
        }
    }
}
