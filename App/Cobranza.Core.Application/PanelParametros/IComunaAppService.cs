using Cobranza.Core.Application.Dto.PanelParametros;
using System;
using System.Collections.Generic;

namespace Cobranza.Core.Application.PanelParametros
{
    public interface IComunaAppService
         : IDisposable
    {
        IEnumerable<ComunaDto> All { get; }

        void Create(ComunaDto comunaDto);

        void Edit(ComunaDto comunaDto);

        void Delete(ComunaDto rubroDto);

        ComunaDto GetById(ComunaDto comunaDto);
    }
}
