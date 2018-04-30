using System.Web;
using System.Web.Mvc;

namespace SunsetHotelSystem.Core
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
