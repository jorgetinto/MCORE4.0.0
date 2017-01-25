using System.Collections.Generic;

namespace Cobranza.Core.Infrastructure.Data.Models
{
    public partial class Pais
    {
        public Pais()
        {
            this.Personas = new List<Persona>();

            this.Regions = new List<Region>();

            this.TipoIdentificadorPersonas = new List<TipoIdentificadorPersona>();
        }

        public string CodigoPais { get; set; }

        public string Nombre { get; set; }

        public string Nacionalidad { get; set; }

        public bool EsDefault { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }

        public virtual ICollection<Region> Regions { get; set; }

        public virtual ICollection<TipoIdentificadorPersona> TipoIdentificadorPersonas { get; set; }

        public void SetAsNonDefault()
        {
            this.EsDefault = false;
        }
    }
}
