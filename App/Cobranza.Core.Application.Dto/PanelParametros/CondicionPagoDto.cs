using System.ComponentModel.DataAnnotations;

namespace Cobranza.Core.Application.Dto.PanelParametros
{
    public class CondicionPagoDto
    {
        [Display(Name = "Identificador de condición de pago")]
        [Required(ErrorMessage = "Debe indicar un identificador.")]
        public short IdCondicionPago { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Debe indicar un nombre.")]
        [StringLength(100, ErrorMessage = "Nombre ha excedido el máximo de caracteres.")]
        public string Nombre { get; set; }

        [Display(Name = "Días")]
        [Required(ErrorMessage = "Debe indicar la cantidad de días.")]
        public short? Dias { get; set; }
    }
}
