using System.Collections.Generic;
using Cobranza.Core.Application.Dto.PanelParametros;
using Cobranza.Core.Application.Seedwork;
using Cobranza.Core.Domain.PanelParametros.Aggregates.PaisAgg;
using Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Application.PanelParametros
{
    public class PaisAppService : IPaisAppService
    {
        private readonly IPaisRepository paisRepository;

        public PaisAppService(IPaisRepository paisReposotory)
        {
            this.paisRepository = paisReposotory;
        }

        public IEnumerable<PaisDto> All
        {
            get
            {
                return this.paisRepository.All.ProjectedAsCollection<Pais, PaisDto>();
            }
        }

        public void Create(PaisDto paisDto)
        {
            Pais pais = paisDto.ProjectedAs<PaisDto, Pais>();

            if (this.paisRepository.Exists(pais))
            {
                throw new ApplicationValidationException(
                    new Dictionary<string, string> 
                    { 
                        { 
                            "CodigoPais",
                            "El código de país está duplicado." 
                        } 
                    });
            }

            if (pais.EsDefault)
            {
                Pais paisDefault = this.paisRepository.Default;

                if (paisDefault != null)
                {
                    paisDefault.SetAsNonDefault();
                }
            }

            this.paisRepository.Add(pais);

            this.paisRepository.UnitOfWork.Commit();
        }

        public void Edit(PaisDto paisDto)
        {
            Pais pais = paisDto.ProjectedAs<PaisDto, Pais>();

            if (!this.paisRepository.Exists(pais))
            {
                throw new ApplicationValidationException(
                    new Dictionary<string, string> 
                    { 
                        { 
                            "CodigoPais", 
                            "El país que intenta modificar ya no existe." 
                        } 
                    });
            }

            if (pais.EsDefault)
            {
                Pais paisDefault = this.paisRepository.Default;

                if (paisDefault != null)
                {
                    paisDefault.SetAsNonDefault();
                }
            }

            this.paisRepository.Modify(pais);

            this.paisRepository.UnitOfWork.Commit();
        }

        public void Delete(PaisDto paisDto)
        {
            Pais pais = paisDto.ProjectedAs<PaisDto, Pais>();

            if (!this.paisRepository.Exists(pais))
            {
                throw new ApplicationValidationException(
                    new Dictionary<string, string> 
                    {
                        { 
                            "IdPais", 
                            "El rubro que intenta eliminar ya no existe."
                        } 
                    });
            }

            this.paisRepository.Remove(pais);

            this.paisRepository.UnitOfWork.Commit();
        }

        public PaisDto GetById(PaisDto paisDto)
        {
            Pais pais = paisDto.ProjectedAs<PaisDto, Pais>();

            Pais paisExistente = this.paisRepository.GetById(pais);

            return paisExistente.ProjectedAs<Pais, PaisDto>();
        }

        public void Dispose()
        {
            this.paisRepository.Dispose();
        }
    }
}
