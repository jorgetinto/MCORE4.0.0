using Munq.MVC3;

namespace Cobranza.Core.MvcApplication
{
    public static class MunqMvc3Startup
    {
        public static void PreStart()
        {
            System.Web.Mvc.DependencyResolver.SetResolver(new MunqDependencyResolver());

            Cobranza.Core.DependencyResolution.DependencyResolver.RegisterDependencyResolver();
        }
    }
}