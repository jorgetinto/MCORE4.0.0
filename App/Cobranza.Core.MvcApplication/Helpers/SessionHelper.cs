using System.Web;

namespace Cobranza.Core.MvcApplication.Helpers
{
    public static class SessionHelper
    {
        public static int IdUsuario
        {
            get
            {
                int idUsuario = 0;

                int.TryParse(HttpContext.Current.Session["session_idusuario"] as string ?? string.Empty, out idUsuario);

                return idUsuario;
            }
        }
    }
}