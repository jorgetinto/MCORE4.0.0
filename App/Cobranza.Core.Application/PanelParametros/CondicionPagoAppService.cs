using System.Collections.Generic;
using Cobranza.Core.Application.Dto.PanelParametros;
using Cobranza.Core.Application.Seedwork;
using Cobranza.Core.Domain.PanelParametros.Aggregates.CondicionPagoAgg;
using Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter;
using Cobranza.Core.Infrastructure.Data.Models;
using System;

namespace Cobranza.Core.Application.PanelParametros
{
    public class CondicionPagoAppService : ICondicionPagoAppService
    {
        private readonly ICondicionPagoRepository condicionPagoRepository;

        public CondicionPagoAppService(ICondicionPagoRepository condicionPagoRepository)
        {
            this.condicionPagoRepository = condicionPagoRepository;
        }

        public IEnumerable<CondicionPagoDto> All
        {
            get
            {
                return this.condicionPagoRepository.All.ProjectedAsCollection<CondicionPago, CondicionPagoDto>();
            }
        }

        public void Create(CondicionPagoDto condicionPagoDto)
        {
            if (condicionPagoDto == null)
            {
                throw new ArgumentNullException("condicionPagoDto");
            }

            CondicionPago condicionPago = condicionPagoDto.ProjectedAs<CondicionPagoDto, CondicionPago>();

            if (this.condicionPagoRepository.Exists(condicionPago))
            {
                throw new ApplicationValidationException(
                    new Dictionary<string, string> 
                    {
                        { 
                            "IdCondicionPago",
                            "El identificador de la condición de pago está duplicado." 
                        } 
                    });
            }

            this.condicionPagoRepository.Add(condicionPago);

            this.condicionPagoRepository.UnitOfWork.Commit();
        }

        public void Edit(CondicionPagoDto condicionPagoDto)
        {
            if (condicionPagoDto == null)
            {
                throw new ArgumentNullException("condicionPagoDto");
            }

            CondicionPago condicionPago = condicionPagoDto.ProjectedAs<CondicionPagoDto, CondicionPago>();

            if (!this.condicionPagoRepository.Exists(condicionPago))
            {
                throw new ApplicationValidationException(
                    new Dictionary<string, string> 
                    {
                        { 
                            "IdCondicionPago",
                            "La condición de pago que intenta modificar ya no existe."
                        } 
                    });
            }

            this.condicionPagoRepository.Modify(condicionPago);

            this.condicionPagoRepository.UnitOfWork.Commit();
        }

        public void Delete(CondicionPagoDto condicionPagoDto)
        {
            if (condicionPagoDto == null)
            {
                throw new ArgumentNullException("condicionPagoDto");
            }

            CondicionPago condicionPago = condicionPagoDto.ProjectedAs<CondicionPagoDto, CondicionPago>();

            if (!this.condicionPagoRepository.Exists(condicionPago))
            {
                throw new ApplicationValidationException(
                    new Dictionary<string, string> 
                    {
                        { 
                            "IdCondicionPago", 
                            "La condicio que intenta eliminar ya no existe."
                        } 
                    });
            }

            this.condicionPagoRepository.Remove(condicionPago);

            this.condicionPagoRepository.UnitOfWork.Commit();
        }

        public CondicionPagoDto GetById(CondicionPagoDto condicionPagoDto)
        {
            if (condicionPagoDto == null)
            {
                throw new ArgumentNullException("condicionPagoDto");
            }

            CondicionPago condicionPago = condicionPagoDto.ProjectedAs<CondicionPagoDto, CondicionPago>();

            CondicionPago condicionPagoExistente = this.condicionPagoRepository.GetById(condicionPago);

            return condicionPagoExistente.ProjectedAs<CondicionPago, CondicionPagoDto>();
        }

        public void Dispose()
        {
            this.condicionPagoRepository.Dispose();
        }
    }
}
