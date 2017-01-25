using System.Collections.Generic;
using Cobranza.Core.Application.Dto.PanelParametros;
using Cobranza.Core.Application.Seedwork;
using Cobranza.Core.Domain.PanelParametros.Aggregates.RolPersonaAgg;
using Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Application.PanelParametros
{
    public class RolPersonaAppService : IRolPersonaAppService
    {
        private readonly IRolPersonaRepository rolPersonaRepository;

        public RolPersonaAppService(IRolPersonaRepository rolPersonaRepository)
        {
            this.rolPersonaRepository = rolPersonaRepository;
        }

        public IEnumerable<RolPersonaDto> All
        {
            get
            {
                return this.rolPersonaRepository.All.ProjectedAsCollection<RolPersona, RolPersonaDto>();
            }
        }

        public void Create(RolPersonaDto rolPersonaDto)
        {
            RolPersona rolPersona = rolPersonaDto.ProjectedAs<RolPersonaDto, RolPersona>();

            if (this.rolPersonaRepository.Exists(rolPersona))
            {
                throw new ApplicationValidationException(
                    new Dictionary<string, string> 
                    {
                        { 
                            "IdRolPersona", 
                            "El identificador de rol persona está duplicado."
                        } 
                    });
            }

            this.rolPersonaRepository.Add(rolPersona);

            this.rolPersonaRepository.UnitOfWork.Commit();
        }

        public void Edit(RolPersonaDto rolPersonaDto)
        {
            RolPersona rolPersona = rolPersonaDto.ProjectedAs<RolPersonaDto, RolPersona>();

            if (!this.rolPersonaRepository.Exists(rolPersona))
            {
                throw new ApplicationValidationException(
                    new Dictionary<string, string> 
                    { 
                        { 
                            "IdRolPersona", 
                            "El rol de persona que intenta modificar ya no existe." 
                        } 
                    });
            }

            this.rolPersonaRepository.Modify(rolPersona);

            this.rolPersonaRepository.UnitOfWork.Commit();
        }

        public void Delete(RolPersonaDto rolPersonaDto)
        {
            RolPersona rolPersona = rolPersonaDto.ProjectedAs<RolPersonaDto, RolPersona>();

            if (!this.rolPersonaRepository.Exists(rolPersona))
            {
                throw new ApplicationValidationException(
                    new Dictionary<string, string> 
                    {
                        { 
                            "IdRolPersona", 
                            "El rol de persona que intenta eliminar ya no existe."
                        } 
                    });
            }

            this.rolPersonaRepository.Remove(rolPersona);

            this.rolPersonaRepository.UnitOfWork.Commit();
        }


        public RolPersonaDto GetById(RolPersonaDto rolPersonaDto)
        {
            RolPersona rolPersona = rolPersonaDto.ProjectedAs<RolPersonaDto, RolPersona>();

            RolPersona rolPersonaExistente = this.rolPersonaRepository.GetById(rolPersona);

            return rolPersonaExistente.ProjectedAs<RolPersona, RolPersonaDto>();
        }

        public void Dispose()
        {
            this.rolPersonaRepository.Dispose();
        }
    }
}
