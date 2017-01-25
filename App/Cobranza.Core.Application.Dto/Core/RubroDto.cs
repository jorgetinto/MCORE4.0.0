using System.ComponentModel.DataAnnotations;

namespace Cobranza.Core.Application.Dto.Core
{
    public class RubroDto
    {
        [Display(Name = "Identificador del rubro")]
        [Required(ErrorMessage = "Debe indicar un identificador.")]
        public short IdRubro { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Debe indicar un nombre.")]
        public string Nombre { get; set; }
    }
}
