using System;
using System.Collections.Generic;
using Cobranza.Core.Application.Dto.PanelParametros;

namespace Cobranza.Core.Application.PanelParametros
{
    public interface IRolPersonaAppService
        : IDisposable
    {
        IEnumerable<RolPersonaDto> All { get; }

        void Create(RolPersonaDto rolPersonaDto);

        void Edit(RolPersonaDto rolPersonaDto);

        void Delete(RolPersonaDto rolPersonaDto);

        RolPersonaDto GetById(RolPersonaDto rolPersonaDto);
    }
}
