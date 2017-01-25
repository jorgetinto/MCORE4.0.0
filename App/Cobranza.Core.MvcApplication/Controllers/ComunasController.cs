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
    public class ComunasController : Controller
    {
       private readonly IComunaAppService comunaAppService;

        private readonly IRegionAppService regionAppService;

        private readonly IPaisAppService paisAppService;

        public ComunasController(
                                IComunaAppService comunaAppService,
                                IRegionAppService regionAppService,
                                IPaisAppService paisAppService)
        {
            this.comunaAppService = comunaAppService;

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

            ViewBag.Regiones = this.regionAppService.All;

            return this.View();
        }

        [HttpPost]
        public ActionResult Create(ComunaDto comunaDto)
        {
            ViewBag.Paises = this.paisAppService.All;

            ViewBag.Regiones = this.regionAppService.All;

            return ControllerHelper
                .ExecuteMaintainerLogic<ComunaDto>(this, "Comunas/_Create", comunaDto, this.comunaAppService.Create);
        }

        public ActionResult Edit(int idComuna)
        {
            ViewBag.Paises = this.paisAppService.All;

            ViewBag.Regiones = this.regionAppService.All;

            ComunaDto comunaDto = new ComunaDto() { IdComuna = idComuna };

            ViewBag.Comuna = this.comunaAppService.GetById(comunaDto);

            return this.View();
        }

        [HttpPost]
        public ActionResult Edit(ComunaDto comunaDto)
        {
            ViewBag.Paises = this.paisAppService.All;

            ViewBag.Regiones = this.regionAppService.All;

            return ControllerHelper
                .ExecuteMaintainerLogic<ComunaDto>(this, "Comunas/_Edit", comunaDto, this.comunaAppService.Edit);
        }

        public ActionResult List()
        {
            return this.PartialView("Comunas/_List", this.comunaAppService.All);
        }

        public ActionResult Delete(int idComuna)
        {
            ViewBag.Paises = this.paisAppService.All;

            ViewBag.Regiones = this.regionAppService.All;

            ComunaDto comunaDto = new ComunaDto() { IdComuna = idComuna };

            ViewBag.Comuna = this.comunaAppService.GetById(comunaDto);

            return RedirectToAction("Edit", "Comunas");
        }

        [HttpPost]
        public ActionResult Delete(ComunaDto comunaDto)
        {
            ViewBag.Paises = this.paisAppService.All;

            ViewBag.Regiones = this.regionAppService.All;

            if (comunaDto == null)
            {
                throw new ArgumentNullException("comunaDto");
            }

            return ControllerHelper
            .ExecuteMaintainerLogic<ComunaDto>(this, "Comunas/_Edit", comunaDto, this.comunaAppService.Delete);
        }

    }
}
