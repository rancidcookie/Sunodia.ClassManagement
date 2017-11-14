using System.Web;
using System.Web.Mvc;

namespace Sunodia.ClassManagement
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
#if !DEBUG
            filters.Add(new HandleErrorAttribute());
#endif
        }
    }
}
