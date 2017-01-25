using Munq.MVC3;
using System.Web.Mvc;

[assembly: WebActivator.PreApplicationStartMethod(
    typeof(Cobranza.Core.DistributedServices.App_Start.MunqMvc3Startup), "PreStart")]

namespace Cobranza.Core.DistributedServices.App_Start
{
    public static class MunqMvc3Startup
    {
        public static void PreStart()
        {
            DependencyResolver.SetResolver(new MunqDependencyResolver());
        }
    }
}