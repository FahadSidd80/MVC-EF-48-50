using System.Web;
using System.Web.Mvc;

namespace WebAp_MVC_EF_L48_52323
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
