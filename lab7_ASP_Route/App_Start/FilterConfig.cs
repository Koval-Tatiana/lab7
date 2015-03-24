using System.Web;
using System.Web.Mvc;

namespace lab7_ASP_Route
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
