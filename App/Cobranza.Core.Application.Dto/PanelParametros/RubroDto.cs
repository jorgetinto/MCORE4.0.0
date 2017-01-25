using System.ComponentModel.DataAnnotations;

namespace Cobranza.Core.Application.Dto.PanelParametros
{
    public class RubroDto
    {
        [Display(Name = "Identificador del rubro")]
        [Required(ErrorMessage = "Debe indicar un identificador.")]
        public short IdRubro { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Debe indicar un nombre.")]
        [StringLength(100, ErrorMessage = "Nombre ha excedido el máximo de caracteres.")]
        public string Nombre { get; set; }
    }
}
