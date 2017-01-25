using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Domain.Personas.Aggregates.PersonaAgg
{
    public partial class PersonaJuridica
    {
        public long NumeroPersona { get; set; }

        public string RazonSocial { get; set; }

        public string NombreFantasia { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
