using System;
using System.Collections.Generic;
using Cobranza.Core.Application.Dto.PanelParametros;

namespace Cobranza.Core.Application.PanelParametros
{
    public interface IPaisAppService
        : IDisposable
    {
        IEnumerable<PaisDto> All { get; }

        void Create(PaisDto paisDto);

        void Edit(PaisDto paisDto);

        void Delete(PaisDto paisDto);

        PaisDto GetById(PaisDto paisDto);
    }
}
