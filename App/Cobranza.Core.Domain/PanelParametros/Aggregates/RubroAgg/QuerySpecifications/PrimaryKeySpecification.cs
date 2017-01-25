using Cobranza.Core.Domain.Seedwork.QuerySpecifications;
using Cobranza.Core.Infrastructure.Data.Models;
using System;
using System.Linq.Expressions;

namespace Cobranza.Core.Domain.PanelParametros.Aggregates.RubroAgg.QuerySpecifications
{
    public class PrimaryKeySpecification : SpecificationBase<Rubro>
    {
        private readonly Rubro rubroToQuery;

        public PrimaryKeySpecification(Rubro rubroToQuery)
        {
            this.rubroToQuery = rubroToQuery;
        }

        public override Expression<Func<Rubro, bool>> SatisfiedBy()
        {
            return p => p.IdRubro == this.rubroToQuery.IdRubro;
        }

        public override Rubro EntityToQuery
        {
            get
            {
                return this.rubroToQuery;
            }
        }
    }
}
