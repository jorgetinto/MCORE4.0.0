using Cobranza.Core.Domain.Seedwork.QuerySpecifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cobranza.Core.Infrastructure.Data.Models;
using System.Linq.Expressions;

namespace Cobranza.Core.Domain.PanelParametros.Aggregates.ParametroAgg.QuerySpecifications
{
    public class PrimaryKeySpecification : SpecificationBase<Parametro>
    {
        private readonly Parametro parametroToQuery;

        public PrimaryKeySpecification(Parametro parametroToQuery)
        {
            this.parametroToQuery = parametroToQuery;
        }

        public override Expression<Func<Parametro, bool>> SatisfiedBy()
        {
            return p => p.IdParametro == this.parametroToQuery.IdParametro;
        }

        public override Parametro EntityToQuery
        {
            get
            {
                return this.parametroToQuery;
            }
        }
    }
}
