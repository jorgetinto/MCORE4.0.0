using Cobranza.Core.Domain.Seedwork.QuerySpecifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cobranza.Core.Infrastructure.Data.Models;
using System.Linq.Expressions;

namespace Cobranza.Core.Domain.PanelParametros.Aggregates.ComunaAgg.QuerySpecifications
{
    public class PrimaryKeySpecification : SpecificationBase<Comuna>
    {
        private readonly Comuna comunaToQuery;

        public PrimaryKeySpecification(Comuna comunaToQuery)
        {
            this.comunaToQuery = comunaToQuery;
        }

        public override Expression<Func<Comuna, bool>> SatisfiedBy()
        {
            return p => p.IdComuna == this.comunaToQuery.IdComuna;
        }

        public override Comuna EntityToQuery
        {
            get
            {
                return this.comunaToQuery;
            }
        }
    }
}
