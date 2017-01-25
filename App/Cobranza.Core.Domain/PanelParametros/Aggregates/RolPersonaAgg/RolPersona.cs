using System.Collections.Generic;

namespace Cobranza.Core.Infrastructure.Data.Models
{
    public partial class RolPersona
    {
        public RolPersona()
        {
            this.RolPersonaEmpresaCobranzas = new List<RolPersonaEmpresaCobranza>();
        }

        public int IdRolPersona { get; set; }

        public string Nombre { get; set; }

        public virtual ICollection<RolPersonaEmpresaCobranza> RolPersonaEmpresaCobranzas { get; set; }
    }
}
