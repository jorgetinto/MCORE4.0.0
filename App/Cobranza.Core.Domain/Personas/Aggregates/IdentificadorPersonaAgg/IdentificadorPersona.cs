using System;

namespace Cobranza.Core.Infrastructure.Data.Models
{
    public partial class IdentificadorPersona
    {
        public long NumeroPersona { get; set; }

        public string CodigoPais { get; set; }

        public int IdTipoIdentificadorPersona { get; set; }

        public string Valor { get; set; }

        public DateTime Fecha { get; set; }

        public virtual Persona Persona { get; set; }

        public virtual TipoIdentificadorPersona TipoIdentificadorPersona { get; set; }
    }
}
