using System.Collections.Generic;
using Cobranza.Core.Application.Dto.PanelParametros;
using Cobranza.Core.Application.Seedwork;
using Cobranza.Core.Domain.PanelParametros.Aggregates.PaisAgg;
using Cobranza.Core.Domain.PanelParametros.Aggregates.RegionAgg;
using Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Application.PanelParametros
{
    public class RegionAppService : IRegionAppService
    {
        private readonly IRegionRepository regionRepository;

        public RegionAppService(IRegionRepository regionRepository)
        {
            this.regionRepository = regionRepository;
        }

        public IEnumerable<RegionDto> All
        {
            get
            {
                List<RegionDto> listaRegion = new List<RegionDto>();

                foreach (var item in this.regionRepository.All)
                {
                    RegionDto regionDto = new RegionDto();

                    regionDto.InjectFrom(item);

                    regionDto.NombrePais = item.Pais.Nombre;

                    listaRegion.Add(regionDto);
                }

                return listaRegion;
            }
        }

        public void Create(RegionDto regionDto)
        {
            Region region = regionDto.ProjectedAs<RegionDto, Region>();

            if (this.regionRepository.Exists(region))
            {
                throw new ApplicationValidationException(
                    new Dictionary<string, string> 
                    {
                        { 
                            "IdRegion", 
                            "El identificador de región está duplicado." 
                        } 
                    });
            }

            if (region.EsDefault)
            {
                Region regionDefault = this.regionRepository.Default;

                if (regionDefault != null)
                {
                    regionDefault.SetAsNonDefault();
                }
            }

            this.regionRepository.Add(region);

            this.regionRepository.UnitOfWork.Commit();
        }

        public void Edit(RegionDto regionDto)
        {
            Region region = regionDto.ProjectedAs<RegionDto, Region>();

            if (!this.regionRepository.Exists(region))
            {
                throw new ApplicationValidationException(
                    new Dictionary<string, string> 
                    { 
                        { 
                            "IdRegion", 
                            "La región que intenta modificar ya no existe." 
                        } 
                    });
            }

            if (region.EsDefault)
            {
                Region regionDefault = this.regionRepository.Default;

                if (regionDefault != null)
                {
                    regionDefault.SetAsNonDefault();
                }
            }

            this.regionRepository.Modify(region);

            this.regionRepository.UnitOfWork.Commit();
        }

        public void Delete(RegionDto regionDto)
        {
            Region region = regionDto.ProjectedAs<RegionDto, Region>();

            if (!this.regionRepository.Exists(region))
            {
                throw new ApplicationValidationException(
                    new Dictionary<string, string> 
                    {
                        { 
                            "IdRegion", 
                            "la región que intenta eliminar ya no existe."
                        } 
                    });
            }

            this.regionRepository.Remove(region);

            this.regionRepository.UnitOfWork.Commit();
        }

        public RegionDto GetById(RegionDto regionDto)
        {
            Region region = regionDto.ProjectedAs<RegionDto, Region>();

            Region regionExistente = this.regionRepository.GetById(region);

            return regionExistente.ProjectedAs<Region, RegionDto>();
        }

        public void Dispose()
        {
            this.regionRepository.Dispose();
        }


        public IEnumerable<RegionDto> GetAllByPais(PaisDto paisDto)
        {
            Pais pais = paisDto.ProjectedAs<PaisDto, Pais>();

            IEnumerable<Region> regionesExistentes = this.regionRepository.GetAllByPais(pais);

            return regionesExistentes.ProjectedAsCollection<Region, RegionDto>();
        }
    }
}
