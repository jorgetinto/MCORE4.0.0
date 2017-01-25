using System.Collections.Generic;

namespace Cobranza.Core.Infrastructure.Data.Models
{
    public partial class TipoIdentificadorPersona
    {
        public TipoIdentificadorPersona()
        {
            this.IdentificadorPersonas = new List<IdentificadorPersona>();
        }

        public string CodigoPais { get; set; }

        public int IdTipoIdentificadorPersona { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public virtual ICollection<IdentificadorPersona> IdentificadorPersonas { get; set; }

        public virtual Pais Pais { get; set; }
    }
}
