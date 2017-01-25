using System.Collections.Generic;
using Cobranza.Core.Application.Dto.PanelParametros;
using Cobranza.Core.Application.Seedwork;
using Cobranza.Core.Domain.PanelParametros.Aggregates.TipoIdentificadorPersonaAgg;
using Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Application.PanelParametros
{
    public class TipoIdentificadorPersonaAppService : ITipoIdentificadorPersonaAppService
    {
        private readonly ITipoIdentificadorPersonaRepository tipoIdentificadorPersonaRepository;

        public TipoIdentificadorPersonaAppService(
            ITipoIdentificadorPersonaRepository tipoIdentificadorPersonaRepository)
        {
            this.tipoIdentificadorPersonaRepository = tipoIdentificadorPersonaRepository;
        }

        public IEnumerable<TipoIdentificadorPersonaDto> All
        {
            get
            {
                List<TipoIdentificadorPersonaDto> listaTipoIdentificadorPersona = new List<TipoIdentificadorPersonaDto>();

                foreach (var item in this.tipoIdentificadorPersonaRepository.All)
                {
                    TipoIdentificadorPersonaDto tipoIdentificadorPersonaDto = new TipoIdentificadorPersonaDto();

                    tipoIdentificadorPersonaDto.InjectFrom(item);

                    tipoIdentificadorPersonaDto.NombrePais = item.Pais.Nombre;

                    listaTipoIdentificadorPersona.Add(tipoIdentificadorPersonaDto);
                }

                return listaTipoIdentificadorPersona;
            }
        }

        public void Create(TipoIdentificadorPersonaDto tipoIdentificadorPersonaDto)
        {
            TipoIdentificadorPersona tipoIdentificadorPersona =
                                            tipoIdentificadorPersonaDto
                                            .ProjectedAs<TipoIdentificadorPersonaDto, TipoIdentificadorPersona>();

            if (this.tipoIdentificadorPersonaRepository.Exists(tipoIdentificadorPersona))
            {
                throw new ApplicationValidationException(
                    new Dictionary<string, string> 
                    {
                        { 
                            "IdTipoIdentificadorPersona", 
                            "El identificador de tipo identificador persona está duplicado." 
                        } 
                    });
            }

            this.tipoIdentificadorPersonaRepository.Add(tipoIdentificadorPersona);

            this.tipoIdentificadorPersonaRepository.UnitOfWork.Commit();
        }

        public void Edit(TipoIdentificadorPersonaDto tipoIdentificadorPersonaDto)
        {
            TipoIdentificadorPersona tipoIdentificadorPersona = tipoIdentificadorPersonaDto
                                                                .ProjectedAs<TipoIdentificadorPersonaDto,
                                                                TipoIdentificadorPersona>();

            if (!this.tipoIdentificadorPersonaRepository.Exists(tipoIdentificadorPersona))
            {
                throw new ApplicationValidationException(
                    new Dictionary<string, string> 
                    {
                        { 
                            "IdTipoIdentificadorPersona", 
                            "El tipo de identificador que intenta modificar ya no existe." 
                        } 
                    });
            }

            this.tipoIdentificadorPersonaRepository.Modify(tipoIdentificadorPersona);

            this.tipoIdentificadorPersonaRepository.UnitOfWork.Commit();
        }

        public void Delete(TipoIdentificadorPersonaDto tipoIdentificadorPersonaDto)
        {
            TipoIdentificadorPersona tipoIdentificadorPersona = tipoIdentificadorPersonaDto
                                                                          .ProjectedAs<TipoIdentificadorPersonaDto,
                                                                          TipoIdentificadorPersona>();

            if (!this.tipoIdentificadorPersonaRepository.Exists(tipoIdentificadorPersona))
            {
                throw new ApplicationValidationException(
                    new Dictionary<string, string> 
                    {
                        { 
                            "IdTipoIdentificadorPersona", 
                            "El tipo de identificador que intenta eliminar ya no existe."
                        } 
                    });
            }

            this.tipoIdentificadorPersonaRepository.Remove(tipoIdentificadorPersona);

            this.tipoIdentificadorPersonaRepository.UnitOfWork.Commit();
        }

        public TipoIdentificadorPersonaDto GetById(TipoIdentificadorPersonaDto tipoIdentificadorPersonaDto)
        {
            TipoIdentificadorPersona tipoIdentificadorPersona = tipoIdentificadorPersonaDto
                                                                .ProjectedAs<TipoIdentificadorPersonaDto,
                                                                TipoIdentificadorPersona>();

            TipoIdentificadorPersona tipoIdentificadorPersonaExistente = this.tipoIdentificadorPersonaRepository
                                                                            .GetById(tipoIdentificadorPersona);

            return tipoIdentificadorPersonaExistente
                .ProjectedAs<TipoIdentificadorPersona,
                TipoIdentificadorPersonaDto>();
        }

        public void Dispose()
        {
            this.tipoIdentificadorPersonaRepository.Dispose();
        }
    }
}
