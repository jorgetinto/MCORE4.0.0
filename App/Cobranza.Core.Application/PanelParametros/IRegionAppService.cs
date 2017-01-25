using System;
using System.Collections.Generic;
using Cobranza.Core.Application.Dto.PanelParametros;

namespace Cobranza.Core.Application.PanelParametros
{
    public interface IRegionAppService
        : IDisposable
    {
        IEnumerable<RegionDto> All { get; }

        void Create(RegionDto regionDto);

        void Edit(RegionDto regionDto);

        void Delete(RegionDto regionDto);

        RegionDto GetById(RegionDto regionDto);

        IEnumerable<RegionDto> GetAllByPais(PaisDto paisDto);
    }
}
