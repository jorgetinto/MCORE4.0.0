using Munq.MVC3;
using System;

namespace Cobranza.Core.DistributedServices
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            System.Web.Mvc.DependencyResolver.SetResolver(new MunqDependencyResolver());

            Cobranza.Core.DependencyResolution.DependencyResolver.RegisterDependencyResolver();
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            // Nothing to do.
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            // Nothing to do.
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            // Nothing to do.
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            // Nothing to do.
        }

        protected void Session_End(object sender, EventArgs e)
        {
            // Nothing to do.
        }

        protected void Application_End(object sender, EventArgs e)
        {
            // Nothing to do.
        }
    }
}