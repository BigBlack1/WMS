using System.Web;
using System.Web.Mvc;
using WMS.Controllers;
namespace WMS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new MyAuthAttribute());
        }
    }
}
