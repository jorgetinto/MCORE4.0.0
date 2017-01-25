using System.Web.Mvc;
using Cobranza.Core.Application.Dto.PanelParametros;
using Cobranza.Core.Application.PanelParametros;
using Cobranza.Core.MvcApplication.Helpers;
using System;

namespace Cobranza.Core.MvcApplication.Controllers
{
    public class RubrosController : Controller
    {
        private readonly IRubroAppService rubroAppService;

        public RubrosController(IRubroAppService rubroAppService)
        {
            this.rubroAppService = rubroAppService;
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
        public ActionResult Create(RubroDto rubroDto)
        {
            if (rubroDto == null)
            {
                throw new ArgumentNullException("rubroDto");
            }

            return ControllerHelper
                .ExecuteMaintainerLogic<RubroDto>(this, "Rubros/_Create", rubroDto, this.rubroAppService.Create);
        }

        public ActionResult Edit(short idRubro)
        {
            RubroDto rubroDto = new RubroDto() { IdRubro = idRubro };

            ViewBag.Rubro = this.rubroAppService.GetById(rubroDto);

            return this.View();
        }

        [HttpPost]
        public ActionResult Edit(RubroDto rubroDto)
        {
            if (rubroDto == null)
            {
                throw new ArgumentNullException("rubroDto");
            }

            return ControllerHelper
                .ExecuteMaintainerLogic<RubroDto>(this, "Rubros/_Edit", rubroDto, this.rubroAppService.Edit);
        }

        public ActionResult Delete(short idRubro)
        {
            RubroDto rubroDto = new RubroDto() { IdRubro = idRubro };

            ViewBag.Rubro = this.rubroAppService.GetById(rubroDto);

            return RedirectToAction("Edit", "Rubros");
        }

        [HttpPost]
        public ActionResult Delete(RubroDto rubroDto)
        {
            if (rubroDto == null)
            {
                throw new ArgumentNullException("rubroDto");
            }

            return ControllerHelper
            .ExecuteMaintainerLogic<RubroDto>(this, "Rubros/_Edit", rubroDto, this.rubroAppService.Delete);
        }

        public ActionResult List()
        {
            return this.PartialView("Rubros/_List", this.rubroAppService.All);
        }
    }
}
