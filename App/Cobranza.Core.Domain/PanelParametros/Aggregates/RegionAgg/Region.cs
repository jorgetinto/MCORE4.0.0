using System.Collections.Generic;

namespace Cobranza.Core.Infrastructure.Data.Models
{
    public partial class Region
    {
        public Region()
        {
            this.Comunas = new List<Comuna>();
        }

        public string CodigoPais { get; set; }

        public int IdRegion { get; set; }

        public string Nombre { get; set; }

        public bool EsDefault { get; set; }

        public virtual ICollection<Comuna> Comunas { get; set; }

        public virtual Pais Pais { get; set; }

        public void SetAsNonDefault()
        {
            this.EsDefault = false;
        }
    }
}
