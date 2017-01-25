using System;
using System.Collections.Generic;
using Cobranza.Core.Application.Dto.PanelParametros;

namespace Cobranza.Core.Application.PanelParametros
{
    public interface IRubroAppService
        : IDisposable
    {
        IEnumerable<RubroDto> All { get; }

        void Create(RubroDto rubroDto);

        void Edit(RubroDto rubroDto);

        void Delete(RubroDto rubroDto);

        RubroDto GetById(RubroDto rubroDto);
    }
}
