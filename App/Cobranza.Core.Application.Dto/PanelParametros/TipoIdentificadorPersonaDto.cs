
using System.ComponentModel.DataAnnotations;
namespace Cobranza.Core.Application.Dto.PanelParametros
{
    public class TipoIdentificadorPersonaDto
    {
        [Display(Name = "Código país")]
        [Required(ErrorMessage = "Debe indicar un código de país.")]
        [StringLength(10, ErrorMessage = "El código de país ha excedido el máximo de caracteres.")]
        public string CodigoPais { get; set; }

        public string NombrePais { get; set; }
        [Display(Name = "Tipo Identificador Persona")]
        [Required(ErrorMessage = "Debe indicar un identificador de tipo identificador persona.")]

        public int IdTipoIdentificadorPersona { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Debe indicar un nombre.")]
        [StringLength(100, ErrorMessage = "Nombre ha excedido el máximo de caracteres.")]
        public string Nombre { get; set; }

        [Display(Name = "Descripción")]
        [StringLength(300, ErrorMessage = "La descripción ha excedido el máximo de caracteres.")]
        public string Descripcion { get; set; }
    }
}
