using System.ComponentModel.DataAnnotations;

namespace Cobranza.Core.Application.Dto.PanelParametros
{
    public class ComunaDto
    {
        [Display(Name = "País")]
        [Required(ErrorMessage = "Debe seleccionar un país.")]
        public string CodigoPais { get; set; }

        public string NombrePais { get; set; }

        [Display(Name = "Región")]
        [Required(ErrorMessage = "Debe seleccionar una región")]
        public int IdRegion { get; set; }

        public string NombreRegion { get; set; }

        [Display(Name = "Identificador Comuna")]
        [Required(ErrorMessage = "Debe seleccionar un identificar de comuna.")]
        public int IdComuna { get; set; }        

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Debe indicar un nombre.")]
        [StringLength(100, ErrorMessage = "Nombre ha excedido el máximo de caracteres.")]
        public string Nombre { get; set; }

        [Display(Name = "Marcar como predeterminado")]
        public bool EsDefault { get; set; }
    }
}
