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
    public class TipoIdentificadorPersonasController : Controller
    {
        private readonly ITipoIdentificadorPersonaAppService tipoIdentificadorPersonaAppService;

        private readonly IPaisAppService paisAppService;

        public TipoIdentificadorPersonasController(
                                ITipoIdentificadorPersonaAppService tipoIdentificadorPersonaAppService,
                                IPaisAppService paisAppService)
        {
            this.tipoIdentificadorPersonaAppService = tipoIdentificadorPersonaAppService;

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
        public ActionResult Create(TipoIdentificadorPersonaDto tipoIdentificadorPersonaDto)
        {
            ViewBag.Paises = this.paisAppService.All;

            return ControllerHelper
                .ExecuteMaintainerLogic<TipoIdentificadorPersonaDto>(this, "TipoIdentificadorPersonas/_Create", tipoIdentificadorPersonaDto, this.tipoIdentificadorPersonaAppService.Create);
        }

        public ActionResult Edit(int idTipoIdentificadorPersona)
        {
            ViewBag.Paises = this.paisAppService.All;

            TipoIdentificadorPersonaDto tipoIdentificadorDto = new TipoIdentificadorPersonaDto() { IdTipoIdentificadorPersona = idTipoIdentificadorPersona };

            ViewBag.TipoIdentificadorPersona = this.tipoIdentificadorPersonaAppService.GetById(tipoIdentificadorDto);

            return this.View();
        }

        [HttpPost]
        public ActionResult Edit(TipoIdentificadorPersonaDto tipoIdentificadorPersonaDto)
        {
            ViewBag.Paises = this.paisAppService.All;

            if (tipoIdentificadorPersonaDto == null)
            {
                throw new ArgumentNullException("tipoIdentificadorPersonaDto");
            }

            return ControllerHelper
                .ExecuteMaintainerLogic<TipoIdentificadorPersonaDto>(this, "TipoIdentificadorPersonas/_Edit", tipoIdentificadorPersonaDto, this.tipoIdentificadorPersonaAppService.Edit);
        }

        public ActionResult Delete(int idTipoIdentificadorPersona)
        {
            ViewBag.Paises = this.paisAppService.All;

            TipoIdentificadorPersonaDto tipoIdentificadorDto = new TipoIdentificadorPersonaDto() { IdTipoIdentificadorPersona = idTipoIdentificadorPersona };

            ViewBag.TipoIdentificadorPersona = this.tipoIdentificadorPersonaAppService.GetById(tipoIdentificadorDto);

            return RedirectToAction("Edit", "TipoIdentificadorPersonas");
        }

        [HttpPost]
        public ActionResult Delete(TipoIdentificadorPersonaDto tipoIdentificadorPersonaDto)
        {
            ViewBag.Paises = this.paisAppService.All;

            if (tipoIdentificadorPersonaDto == null)
            {
                throw new ArgumentNullException("tipoIdentificadorPersonaDto");
            }

            return ControllerHelper
                .ExecuteMaintainerLogic<TipoIdentificadorPersonaDto>(this, 
                                                    "TipoIdentificadorPersonas/_Edit", 
                                                    tipoIdentificadorPersonaDto, 
                                                    this.tipoIdentificadorPersonaAppService.Delete);
        }

        public ActionResult List()
        {
            return this.PartialView("TipoIdentificadorPersonas/_List", this.tipoIdentificadorPersonaAppService.All);
        }

    }
}
