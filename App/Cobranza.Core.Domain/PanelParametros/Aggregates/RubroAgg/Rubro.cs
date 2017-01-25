using System.Collections.Generic;

namespace Cobranza.Core.Infrastructure.Data.Models
{
    public partial class Rubro
    {
        public Rubro()
        {
            this.Personas = new List<Persona>();
        }

        public short IdRubro { get; set; }

        public string Nombre { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
