using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Cobranza.Core.Application.Dto.PanelParametros
{
    public class ParametroDto
    {
        [Display(Name = "Identificador Parametro")]
        public int IdParametro { get; set; }

        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Identificador Elemento UI")]
        public string IdElementoUI { get; set; }

        [Display(Name = "Url Index")]
        public string UrlIndex { get; set; }
    }
}
