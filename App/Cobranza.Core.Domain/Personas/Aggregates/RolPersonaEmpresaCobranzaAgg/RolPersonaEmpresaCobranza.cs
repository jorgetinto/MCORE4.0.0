using System;

namespace Cobranza.Core.Infrastructure.Data.Models
{
    public partial class RolPersonaEmpresaCobranza
    {
        public long NumeroPersonaEmpresaCobranza { get; set; }

        public long NumeroPersonaDesempena { get; set; }

        public long NumeroPersonaMotivo { get; set; }

        public int IdRolPersonaDesempena { get; set; }

        public DateTime FechaAsignacion { get; set; }

        public bool EstaEliminado { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual Persona Persona1 { get; set; }

        public virtual Persona Persona2 { get; set; }

        public virtual RolPersona RolPersona { get; set; }
    }
}
