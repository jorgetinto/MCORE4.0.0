using System;
using System.Collections.Generic;
using Cobranza.Core.Application.Dto.PanelParametros;

namespace Cobranza.Core.Application.PanelParametros
{
    public interface ICondicionPagoAppService
        : IDisposable
    {
        IEnumerable<CondicionPagoDto> All { get; }

        void Create(CondicionPagoDto condicionPagoDto);

        void Edit(CondicionPagoDto condicionPagoDto);

        void Delete(CondicionPagoDto condicionPagoDto);

        CondicionPagoDto GetById(CondicionPagoDto condicionPagoDto);
    }
}
