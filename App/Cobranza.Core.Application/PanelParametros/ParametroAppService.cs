using System;
using System.Linq;
using Cobranza.Core.Domain.PanelParametros.Aggregates.ParametroAgg;
using Cobranza.Core.Application.Dto.PanelParametros;
using Cobranza.Core.Infrastructure.Data.Models;
using Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter;
using System.Collections.Generic;

namespace Cobranza.Core.Application.PanelParametros
{
    public class ParametroAppService : IParametroAppService
    {
        private readonly IParametroRepository parametroRepository;

        public ParametroAppService(IParametroRepository parametroRepository)
        {
            this.parametroRepository = parametroRepository;
        }

        public IEnumerable<ParametroDto> All
        {
            get
            {
                return this.parametroRepository.All.ProjectedAsCollection<Parametro, ParametroDto>();
            }
        }

        public void Dispose()
        {
            this.parametroRepository.Dispose();
        }
    }
}
