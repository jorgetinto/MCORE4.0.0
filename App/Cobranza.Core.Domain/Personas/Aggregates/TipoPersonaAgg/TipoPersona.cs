using System.Collections.Generic;

namespace Cobranza.Core.Infrastructure.Data.Models
{
    public partial class TipoPersona
    {
        public TipoPersona()
        {
            this.Personas = new List<Persona>();
        }

        public byte IdTipoPersona { get; set; }

        public string Nombre { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
