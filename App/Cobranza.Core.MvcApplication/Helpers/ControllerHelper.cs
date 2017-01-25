using Cobranza.Core.Application.Seedwork;
using System;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace Cobranza.Core.MvcApplication.Helpers
{
    public static class ControllerHelper
    {
        public static JsonResult JsonView(
            Controller controller,
            bool success,
            string viewName,
            object model,
            string[] validationMessages)
        {
            return new JsonResult { Data = new { Success = success, View = RenderPartialView(viewName, model, controller), ValidationMessages = validationMessages } };
        }

        public static string RenderPartialView(string partialViewName, object model, Controller controller)
        {
            if (controller.ControllerContext == null)
                return string.Empty;

            if (string.IsNullOrEmpty(partialViewName))
            {
                throw new ArgumentNullException("partialViewName");
            }

            if (model == null)
            {
                controller.ModelState.Clear();
            }

            controller.ViewData.Model = model;

            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(controller.ControllerContext, partialViewName);

                var viewContext = new ViewContext(controller.ControllerContext, viewResult.View, controller.ViewData, controller.TempData, sw);

                viewResult.View.Render(viewContext, sw);

                return sw.GetStringBuilder().ToString();
            }
        }

        public static JsonResult ExecuteMaintainerLogic<TDto>(
            Controller controller,
            string viewToRender,
            TDto dto,
            Action<TDto> methodToInvoke)
            where TDto : class, new()
        {
            string[] validationMessages = new string[0];

            bool success = false;

            if (controller.ModelState.IsValid)
            {
                try
                {
                    methodToInvoke(dto);

                    dto = null;

                    success = true;
                }
                catch (ApplicationValidationException ave)
                {
                    foreach (var message in ave.InvalidationMessages)
                    {
                        controller.ModelState.AddModelError(message.Key, message.Value);
                    }

                    validationMessages = ave.InvalidationMessages.Select(i => i.Value).ToArray();
                }
            }
            else
            {
                validationMessages = new string[] { "Se encontraron errores en las validaciones." };
            }

            return ControllerHelper.JsonView(controller, success, viewToRender, dto, validationMessages);
        }
    }
}