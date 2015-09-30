using SimpleMVC.Filters;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ActionProfilerAttribute());
        }
    }
}
