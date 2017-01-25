using System;
using System.Linq.Expressions;
using Cobranza.Core.Domain.Seedwork.QuerySpecifications;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Domain.PanelParametros.Aggregates.RolPersonaAgg.QuerySpecifications
{
    public class PrimaryKeySpecification : SpecificationBase<RolPersona>
    {
        private readonly RolPersona rolPersonaToQuery;

        public PrimaryKeySpecification(RolPersona rolPersonaToQuery)
        {
            this.rolPersonaToQuery = rolPersonaToQuery;
        }

        public override Expression<Func<RolPersona, bool>> SatisfiedBy()
        {
            return p => p.IdRolPersona == this.rolPersonaToQuery.IdRolPersona;
        }

        public override RolPersona EntityToQuery
        {
            get { return this.rolPersonaToQuery; }
        }
    }
}