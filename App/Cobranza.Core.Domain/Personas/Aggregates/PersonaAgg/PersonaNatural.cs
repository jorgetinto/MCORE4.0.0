using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Domain.Personas.Aggregates.PersonaAgg
{
    public partial class PersonaNatural
    {
        public long NumeroPersona { get; set; }

        public string PrimerNombre { get; set; }

        public string SegundoNombre { get; set; }

        public string ApellidoPaterno { get; set; }

        public string ApellidoMaterno { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
