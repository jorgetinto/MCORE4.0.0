using Cobranza.Core.Application.Dto.PanelParametros;
using Cobranza.Core.Application.Seedwork;
using Cobranza.Core.Domain.PanelParametros.Aggregates.RubroAgg;
using Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter;
using Cobranza.Core.Infrastructure.Data.Models;
using System.Collections.Generic;

namespace Cobranza.Core.Application.PanelParametros
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
            Rubro rubro = rubroDto.ProjectedAs<RubroDto, Rubro>();

            if (this.rubroRepository.Exists(rubro))
            {
                throw new ApplicationValidationException(
                         new Dictionary<string, string> 
                    {
                        { 
                            "IdRubro", 
                            "El identificador del rubro está duplicado."
                        } 
                    });
            }

            this.rubroRepository.Add(rubro);

            this.rubroRepository.UnitOfWork.Commit();
        }

        public void Edit(RubroDto rubroDto)
        {
            Rubro rubro = rubroDto.ProjectedAs<RubroDto, Rubro>();

            if (!this.rubroRepository.Exists(rubro))
            {
                throw new ApplicationValidationException(
                    new Dictionary<string, string> 
                    {
                        { 
                            "IdRubro", 
                            "El rubro que intenta modificar ya no existe."
                        } 
                    });
            }

            this.rubroRepository.Modify(rubro);

            this.rubroRepository.UnitOfWork.Commit();
        }

        public void Delete(RubroDto rubroDto)
        {
            Rubro rubro = rubroDto.ProjectedAs<RubroDto, Rubro>();

            if (!this.rubroRepository.Exists(rubro))
            {
                throw new ApplicationValidationException(
                    new Dictionary<string, string> 
                    {
                        { 
                            "IdRubro", 
                            "El rubro que intenta eliminar ya no existe."
                        } 
                    });
            }

            this.rubroRepository.Remove(rubro);

            this.rubroRepository.UnitOfWork.Commit();
        }

        public RubroDto GetById(RubroDto rubroDto)
        {
            Rubro rubro = rubroDto.ProjectedAs<RubroDto, Rubro>();

            Rubro rubroExistente = this.rubroRepository.GetById(rubro);

            return rubroExistente.ProjectedAs<Rubro, RubroDto>();
        }

        public void Dispose()
        {
            this.rubroRepository.Dispose();
        }
    }
}
