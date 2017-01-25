using System.ComponentModel.DataAnnotations;

namespace Cobranza.Core.Application.Dto.PanelParametros
{
    public class PaisDto
    {
        [Display(Name = "Código país")]
        [Required(ErrorMessage = "Debe indicar un código de país.")]
        [StringLength(10, ErrorMessage = "El código de país ha excedido el máximo de caracteres.")]
        public string CodigoPais { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Debe indicar un nombre.")]
        [StringLength(100, ErrorMessage = "Nombre ha excedido el máximo de caracteres.")]
        public string Nombre { get; set; }

        [Display(Name = "Nacionalidad")]
        [Required(ErrorMessage = "Debe indicar una nacionalidad.")]
        [StringLength(100, ErrorMessage = "Nacionalidad ha excedido el máximo de caracteres.")]
        public string Nacionalidad { get; set; }

        [Display(Name = "Marcar como predeterminado")]
        public bool EsDefault { get; set; }
    }
}
