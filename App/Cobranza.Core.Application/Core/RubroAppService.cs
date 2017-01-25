using System.Collections.Generic;
using Cobranza.Core.Application.Dto.Core;
using Cobranza.Core.Domain.PanelParametros.Aggregates.RubroAgg;
using Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter;

namespace Cobranza.Core.Application.Core
{
    public class RubroAppService : IRubroAppService
    {
        private readonly IRubroRepository rubroRepository;

        public RubroAppService(IRubroRepository rubroRepository)
        {
            this.rubroRepository = rubroRepository;
        }

        public IEnumerable<RubroDto> All
        {
            get
            {
                return this.rubroRepository.All.ProjectedAsCollection<Rubro, RubroDto>();
            }
        }

        public void Create(RubroDto rubroDto)
        {
            this.rubroRepository.Add(rubroDto.ProjectedAs<RubroDto, Rubro>());

            this.rubroRepository.UnitOfWork.Commit();
        }

        public void Dispose()
        {
            this.rubroRepository.Dispose();
        }
    }
}
