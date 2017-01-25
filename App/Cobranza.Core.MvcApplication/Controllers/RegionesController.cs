using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cobranza.Core.Application.PanelParametros;
using Cobranza.Core.Application.Dto.PanelParametros;
using Cobranza.Core.MvcApplication.Helpers;

namespace Cobranza.Core.MvcApplication.Controllers
{
    public class RegionesController : Controller
    {
        private readonly IRegionAppService regionAppService;

        private readonly IPaisAppService paisAppService;

        public RegionesController(
                                IRegionAppService regionAppService,
                                IPaisAppService paisAppService)
        {
            this.regionAppService = regionAppService;

            this.paisAppService = paisAppService;
        }

        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Create()
        {
            ViewBag.Paises = this.paisAppService.All;

            return this.View();
        }

        [HttpPost]
        public ActionResult Create(RegionDto regionDto)
        {
            ViewBag.Paises = this.paisAppService.All;

            return ControllerHelper
                .ExecuteMaintainerLogic<RegionDto>(this, "Regiones/_Create", regionDto, this.regionAppService.Create);
        }

        public ActionResult Edit(int idRegion)
        {
            ViewBag.Paises = this.paisAppService.All;

            RegionDto regionDto = new RegionDto() { IdRegion = idRegion };

            ViewBag.Region = this.regionAppService.GetById(regionDto);

            return this.View();
        }

        [HttpPost]
        public ActionResult Edit(RegionDto regionDto)
        {
            ViewBag.Paises = this.paisAppService.All;

            return ControllerHelper
                .ExecuteMaintainerLogic<RegionDto>(this, "Regiones/_Edit", regionDto, this.regionAppService.Edit);
        }

        public ActionResult List()
        {
            return this.PartialView("Regiones/_List", this.regionAppService.All);
        }

        [HttpPost]
        public JsonResult GetAllByPais(PaisDto paisDto)
        {
            return new JsonResult
            {
                Data = new { Regiones = this.regionAppService.GetAllByPais(paisDto) }
            };
        }

        public ActionResult Delete(int idRegion)
        {
            ViewBag.Paises = this.paisAppService.All;

            RegionDto regionDto = new RegionDto() { IdRegion = idRegion };

            ViewBag.Region = this.regionAppService.GetById(regionDto);

            return RedirectToAction("Edit", "Regiones");
        }

        [HttpPost]
        public ActionResult Delete(RegionDto regionDto)
        {
            ViewBag.Paises = this.paisAppService.All;

            if (regionDto == null)
            {
                throw new ArgumentNullException("regionDto");
            }

            return ControllerHelper
            .ExecuteMaintainerLogic<RegionDto>(this, "Regiones/_Edit", regionDto, this.regionAppService.Delete);
        }

    }
}
