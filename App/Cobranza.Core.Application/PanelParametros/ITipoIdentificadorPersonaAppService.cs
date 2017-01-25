using System;
using System.Collections.Generic;
using Cobranza.Core.Application.Dto.PanelParametros;

namespace Cobranza.Core.Application.PanelParametros
{
    public interface ITipoIdentificadorPersonaAppService
        : IDisposable
    {
        IEnumerable<TipoIdentificadorPersonaDto> All { get; }

        void Create(TipoIdentificadorPersonaDto tipoIdentificadorPersonaDto);

        void Edit(TipoIdentificadorPersonaDto tipoIdentificadorPersonaDto);

        void Delete(TipoIdentificadorPersonaDto tipoIdentificadorPersonaDto);

        TipoIdentificadorPersonaDto GetById(TipoIdentificadorPersonaDto tipoIdentificadorPersonaDto);
    }
}
