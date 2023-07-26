using System.Web;
using System.Web.Mvc;

namespace WebAp_L50_MVC_JQuery_EF_DDN_26523
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
