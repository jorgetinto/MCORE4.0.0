using System.ComponentModel.DataAnnotations;

namespace Cobranza.Core.Application.Dto.PanelParametros
{
    public class RegionDto
    {
        [Display(Name = "País")]
        [Required(ErrorMessage = "Debe seleccionar un país.")]
        public string CodigoPais { get; set; }

        public string NombrePais { get; set; }

        [Display(Name = "Identificador de región")]
        [Required(ErrorMessage = "Debe indicar un identificador de región.")]
        public int IdRegion { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Debe indicar un nombre.")]
        [StringLength(100, ErrorMessage = "Nombre ha excedido el máximo de caracteres.")]
        public string Nombre { get; set; }

        [Display(Name = "Marcar como predeterminado")]
        public bool EsDefault { get; set; }
    }
}
