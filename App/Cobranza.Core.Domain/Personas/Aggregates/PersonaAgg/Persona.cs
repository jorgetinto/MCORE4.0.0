using Cobranza.Core.Domain.Personas.Aggregates.PersonaAgg;
using System;
using System.Collections.Generic;

namespace Cobranza.Core.Infrastructure.Data.Models
{
    public partial class Persona
    {
        public Persona()
        {
            this.IdentificadorPersonas = new List<IdentificadorPersona>();

            this.RolPersonaEmpresaCobranzas = new List<RolPersonaEmpresaCobranza>();

            this.RolPersonaEmpresaCobranzas1 = new List<RolPersonaEmpresaCobranza>();

            this.RolPersonaEmpresaCobranzas2 = new List<RolPersonaEmpresaCobranza>();

        }

        public long NumeroPersona { get; set; }

        public string Giro { get; set; }

        public string Observaciones { get; set; }

        public short? IdCondicionPago { get; set; }

        public short? IdRubro { get; set; }

        public string CodigoPaisResidencia { get; set; }

        public byte IdTipoPersona { get; set; }

        public virtual CondicionPago CondicionPago { get; set; }

        public virtual ICollection<IdentificadorPersona> IdentificadorPersonas { get; set; }

        public virtual Pais Pais { get; set; }

        public virtual Rubro Rubro { get; set; }

        public virtual TipoPersona TipoPersona { get; set; }

        public virtual PersonaJuridica PersonaJuridica { get; set; }

        public virtual PersonaNatural PersonaNatural { get; set; }

        public virtual ICollection<RolPersonaEmpresaCobranza> RolPersonaEmpresaCobranzas { get; set; }

        public virtual ICollection<RolPersonaEmpresaCobranza> RolPersonaEmpresaCobranzas1 { get; set; }

        public virtual ICollection<RolPersonaEmpresaCobranza> RolPersonaEmpresaCobranzas2 { get; set; }
    }
}
