using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cobranza.Core.Application.Dto.PanelParametros;

namespace Cobranza.Core.Application.PanelParametros
{
    public interface IParametroAppService
        : IDisposable
    {
        IEnumerable<ParametroDto> All { get; }
    }
}
