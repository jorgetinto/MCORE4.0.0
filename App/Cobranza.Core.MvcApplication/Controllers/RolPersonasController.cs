using Cobranza.Core.Application.PanelParametros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cobranza.Core.Application.Dto.PanelParametros;
using Cobranza.Core.MvcApplication.Helpers;

namespace Cobranza.Core.MvcApplication.Controllers
{
    public class RolPersonasController : Controller
    {
        private readonly IRolPersonaAppService rolPersonaAppService;

        public RolPersonasController(IRolPersonaAppService rolPersonaAppService)
        {
            this.rolPersonaAppService = rolPersonaAppService;
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
        public ActionResult Create(RolPersonaDto rolPersonaDto)
        {
            if (rolPersonaDto == null)
            {
                throw new ArgumentNullException("rolPersonaDto");
            }

            return ControllerHelper
                .ExecuteMaintainerLogic<RolPersonaDto>
                (
                    this,
                    "RolPersonas/_Create",
                    rolPersonaDto,
                    this.rolPersonaAppService.Create
                );
        }

        public ActionResult Edit(int idRolPersona)
        {
            RolPersonaDto rolPersonaDto = new RolPersonaDto() { IdRolPersona = idRolPersona };

            ViewBag.RolPersona = this.rolPersonaAppService.GetById(rolPersonaDto);

            return this.View();
        }

        [HttpPost]
        public ActionResult Edit(RolPersonaDto rolPersonaDto)
        {
            if (rolPersonaDto == null)
            {
                throw new ArgumentNullException("rolPersonaDto");
            }

            return ControllerHelper
                .ExecuteMaintainerLogic<RolPersonaDto>
                (
                    this,
                    "RolPersonas/_Edit",
                    rolPersonaDto,
                    this.rolPersonaAppService.Edit
                );
        }

        public ActionResult Delete(int idRolPersona)
        {
            RolPersonaDto rolPersonaDto = new RolPersonaDto() { IdRolPersona = idRolPersona };

            ViewBag.RolPersona = this.rolPersonaAppService.GetById(rolPersonaDto);

            return RedirectToAction("Edit", "RolPersonas");
        }

        [HttpPost]
        public ActionResult Delete(RolPersonaDto rolPersonaDto)
        {
            if (rolPersonaDto == null)
            {
                throw new ArgumentNullException("rolPersonaDto");
            }

            return ControllerHelper
            .ExecuteMaintainerLogic<RolPersonaDto>(this, "RolPersonas/_Edit", rolPersonaDto, this.rolPersonaAppService.Delete);
        }

        public ActionResult List()
        {
            return this.PartialView("RolPersonas/_List", this.rolPersonaAppService.All);
        }

    }
}
