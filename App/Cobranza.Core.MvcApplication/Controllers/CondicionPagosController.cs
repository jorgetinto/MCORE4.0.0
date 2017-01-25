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
    public class CondicionPagosController : Controller
    {
        private readonly ICondicionPagoAppService condicionPagoAppService;

        public CondicionPagosController(ICondicionPagoAppService condicionPagoAppService)
        {
            this.condicionPagoAppService = condicionPagoAppService;
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
        public ActionResult Create(CondicionPagoDto condicionPagoDto)
        {
            if (condicionPagoDto == null)
            {
                throw new ArgumentNullException("condicionPagoDto");
            }

            return ControllerHelper.ExecuteMaintainerLogic<CondicionPagoDto>
                    (
                        this,
                        "CondicionPagos/_Create",
                        condicionPagoDto,
                        this.condicionPagoAppService.Create
                    );
        }

        public ActionResult Edit(short idCondicionPago)
        {
            CondicionPagoDto condicionPagoDto = new CondicionPagoDto() { IdCondicionPago = idCondicionPago };

            ViewBag.CondicionPago = this.condicionPagoAppService.GetById(condicionPagoDto);

            return this.View();
        }

        [HttpPost]
        public ActionResult Edit(CondicionPagoDto condicionPagoDto)
        {
            return ControllerHelper
                .ExecuteMaintainerLogic<CondicionPagoDto>(this, "CondicionPagos/_Edit", condicionPagoDto, this.condicionPagoAppService.Edit);
        }

        public ActionResult Delete(short idCondicionPago)
        {
            CondicionPagoDto condicionPagoDto = new CondicionPagoDto() { IdCondicionPago = idCondicionPago };

            ViewBag.CondicionPago = this.condicionPagoAppService.GetById(condicionPagoDto);

            return RedirectToAction("Edit", "CondicionPagos");
        }

        [HttpPost]
        public ActionResult Delete(CondicionPagoDto condicionPagoDto)
        {
            if (condicionPagoDto == null)
            {
                throw new ArgumentNullException("condicionPagoDto");
            }

            return ControllerHelper
            .ExecuteMaintainerLogic<CondicionPagoDto>(this, "CondicionPagos/_Edit", condicionPagoDto, this.condicionPagoAppService.Delete);
        }

        public ActionResult List()
        {
            return this.PartialView("CondicionPagos/_List", this.condicionPagoAppService.All);
        }
    }
}
