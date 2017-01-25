using System.ComponentModel.DataAnnotations;

namespace Cobranza.Core.Application.Dto.PanelParametros
{
    public class RolPersonaDto
    {
        [Display(Name = "Identificador Rol Persona")]
        [Required(ErrorMessage = "Debe indicar un identificador.")]
        public int IdRolPersona { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Debe indicar un nombre.")]
        [StringLength(100, ErrorMessage = "Nombre ha excedido el máximo de caracteres.")]
        public string Nombre { get; set; }
    }
}
