using System.Web;
using System.Web.Mvc;

namespace WebAp_L49_MVC_JQuery_EF_26523
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
