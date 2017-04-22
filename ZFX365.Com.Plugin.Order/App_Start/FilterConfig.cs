using System.Web;
using System.Web.Mvc;

namespace ZFX365.Com.Plugin.Order
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
