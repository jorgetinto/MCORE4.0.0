using System;
using System.Web.Mvc;

namespace Cobranza.Core.MvcApplication
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            if (filters == null)
            {
                throw new ArgumentNullException("filters");
            }

            filters.Add(new HandleErrorAttribute());
        }
    }
}