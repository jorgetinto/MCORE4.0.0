using Cobranza.Core.Domain.Seedwork.QuerySpecifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cobranza.Core.Infrastructure.Data.Models;
using System.Linq.Expressions;

namespace Cobranza.Core.Domain.PanelParametros.Aggregates.ComunaAgg.QuerySpecifications
{
    public class IsDefaultSpecification : SpecificationBase<Comuna>
    {
        public override Expression<Func<Comuna, bool>> SatisfiedBy()
        {
            return p => p.EsDefault;
        }
    }
}
