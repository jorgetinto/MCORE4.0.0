using System.Collections.Generic;
using Cobranza.Core.Application.Dto.PanelParametros;
using Cobranza.Core.Application.Seedwork;
using Cobranza.Core.Domain.PanelParametros.Aggregates.ComunaAgg;
using Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter;
using Cobranza.Core.Infrastructure.Data.Models;
using System;

namespace Cobranza.Core.Application.PanelParametros
{
    public class ComunaAppService : IComunaAppService
    {
        private readonly IComunaRepository comunaRepository;

        public ComunaAppService(IComunaRepository comunaRepository)
        {
            this.comunaRepository = comunaRepository;
        }

        public IEnumerable<ComunaDto> All
        {
            get
            {
                List<ComunaDto> listaComuna = new List<ComunaDto>();

                foreach (var item in this.comunaRepository.All)
                {
                    ComunaDto comunaDto = new ComunaDto();

                    comunaDto.InjectFrom(item);

                    comunaDto.NombreRegion = item.Region.Nombre;

                    comunaDto.NombrePais = item.Region.Pais.Nombre;

                    listaComuna.Add(comunaDto);
                }

                return listaComuna;
            }
        }

        public void Create(ComunaDto comunaDto)
        {
            if (comunaDto == null)
            {
                throw new ArgumentNullException("comunaDto");
            }

            Comuna comuna = comunaDto.ProjectedAs<ComunaDto, Comuna>();

            if (this.comunaRepository.Exists(comuna))
            {
                throw new ApplicationValidationException(
                    new Dictionary<string, string> 
                    {
                        { 
                            "IdComuna", 
                            "El identificador de comuna está duplicado." 
                        } 
                    });
            }

            if (comuna.EsDefault)
            {
                Comuna comunaDefault = this.comunaRepository.Default;

                if (comunaDefault != null)
                {
                    comunaDefault.SetAsNonDefault();
                }
            }

            this.comunaRepository.Add(comuna);

            this.comunaRepository.UnitOfWork.Commit();
        }

        public void Edit(ComunaDto comunaDto)
        {
            if (comunaDto == null)
            {
                throw new ArgumentNullException("comunaDto");
            }

            Comuna comuna = comunaDto.ProjectedAs<ComunaDto, Comuna>();

            if (!this.comunaRepository.Exists(comuna))
            {
                throw new ApplicationValidationException(
                    new Dictionary<string, string> 
                    { 
                        { 
                            "IdComuna", 
                            "La comuna que intenta modificar ya no existe." 
                        } 
                    });
            }

            if (comuna.EsDefault)
            {
                Comuna comunaDefault = this.comunaRepository.Default;

                if (comunaDefault != null)
                {
                    comunaDefault.SetAsNonDefault();
                }
            }

            this.comunaRepository.Modify(comuna);

            this.comunaRepository.UnitOfWork.Commit();
        }

        public void Delete(ComunaDto comunaDto)
        {
            if (comunaDto == null)
            {
                throw new ArgumentNullException("comunaDto");
            }

            Comuna comuna = comunaDto.ProjectedAs<ComunaDto, Comuna>();

            if (!this.comunaRepository.Exists(comuna))
            {
                throw new ApplicationValidationException(
                    new Dictionary<string, string> 
                    {
                        { 
                            "IdComuna", 
                            "La comuna que intenta eliminar ya no existe." 
                        } 
                    });
            }

            this.comunaRepository.Remove(comuna);

            this.comunaRepository.UnitOfWork.Commit();
        }

        public ComunaDto GetById(ComunaDto comunaDto)
        {
            if (comunaDto == null)
            {
                throw new ArgumentNullException("comunaDto");
            }

            Comuna comuna = comunaDto.ProjectedAs<ComunaDto, Comuna>();

            Comuna comunaExistente = this.comunaRepository.GetById(comuna);

            return comunaExistente.ProjectedAs<Comuna, ComunaDto>();
        }

        public void Dispose()
        {
            this.comunaRepository.Dispose();
        }
    }
}
