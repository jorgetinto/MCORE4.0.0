using System;
using System.Collections.Generic;

namespace Cobranza.Core.Infrastructure.Data.Models
{
    public partial class CondicionPago
    {
        public CondicionPago()
        {
            this.Personas = new List<Persona>();
        }

        public short IdCondicionPago { get; set; }

        public string Nombre { get; set; }

        public short? Dias { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
