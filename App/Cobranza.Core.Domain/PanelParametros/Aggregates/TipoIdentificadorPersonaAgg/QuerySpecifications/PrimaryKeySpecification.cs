using System;
using System.Linq.Expressions;
using Cobranza.Core.Domain.Seedwork.QuerySpecifications;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Domain.PanelParametros.Aggregates.TipoIdentificadorPersonaAgg.QuerySpecifications
{
    public class PrimaryKeySpecification : SpecificationBase<TipoIdentificadorPersona>
    {
        private readonly TipoIdentificadorPersona tipoIdentificadorPersonaToQuery;

        public PrimaryKeySpecification(TipoIdentificadorPersona tipoIdentificadorPersonaToQuery)
        {
            this.tipoIdentificadorPersonaToQuery = tipoIdentificadorPersonaToQuery;
        }
        public override Expression<Func<TipoIdentificadorPersona, bool>> SatisfiedBy()
        {
            return p => p.IdTipoIdentificadorPersona == this.tipoIdentificadorPersonaToQuery.IdTipoIdentificadorPersona;
        }

        public override TipoIdentificadorPersona EntityToQuery
        {
            get { return this.tipoIdentificadorPersonaToQuery; }
        }
    }
}
