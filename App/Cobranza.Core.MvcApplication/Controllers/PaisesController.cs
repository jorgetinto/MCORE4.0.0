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
    public class PaisesController : Controller
    {
         private readonly IPaisAppService paisAppService;

        public PaisesController(IPaisAppService paisAppService)
        {
            this.paisAppService = paisAppService;
        }

        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create(PaisDto paisDto)
        {
            if (paisDto == null)
            {
                throw new ArgumentNullException("paisDto");
            }

            return ControllerHelper
                .ExecuteMaintainerLogic<PaisDto>(this, "Paises/_Create", paisDto, this.paisAppService.Create);
        }

        public ActionResult Edit(string codigoPais)
        {
            PaisDto paisDto = new PaisDto() { CodigoPais = codigoPais };

            ViewBag.Pais = this.paisAppService.GetById(paisDto);

            return this.View();
        }

        [HttpPost]
        public ActionResult Edit(PaisDto paisDto)
        {
            if (paisDto == null)
            {
                throw new ArgumentNullException("paisDto");
            }

            return ControllerHelper
                .ExecuteMaintainerLogic<PaisDto>(this, "Paises/_Edit", paisDto, this.paisAppService.Edit);
        }

        public ActionResult Delete(string codigoPais)
        {
            PaisDto paisDto = new PaisDto() { CodigoPais = codigoPais };

            ViewBag.Pais = this.paisAppService.GetById(paisDto);

            return RedirectToAction("Edit", "Paises");
        }

        [HttpPost]
        public ActionResult Delete(PaisDto paisDto)
        {
            if (paisDto == null)
            {
                throw new ArgumentNullException("paisDto");
            }

            return ControllerHelper
            .ExecuteMaintainerLogic<PaisDto>(this, "Paises/_Edit", paisDto, this.paisAppService.Delete);
        }

        public ActionResult List()
        {
            return this.PartialView("Paises/_List", this.paisAppService.All);
        }
    }
}
