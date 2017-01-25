using System;
using System.Collections.Generic;
using Cobranza.Core.Application.Dto.Core;

namespace Cobranza.Core.Application.Core
{
    public interface IRubroAppService
        : IDisposable
    {
        IEnumerable<RubroDto> All { get; }

        void Create(RubroDto rubroDto);
    }
}
