using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WMS.Controllers
{
    public class MyAuthAttribute:AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //if (filterContext.HttpContext.Session["Login"] == null)
            //{
            //    var context = new ContentResult();
            //    context.Content = "<script>location.href='../fmb01/Login.html';</script>";
            //    filterContext.Result = context;
            //}
            //var cookie = HttpContext.Current.Request.Cookies["Login"];
            //if (cookie == null || cookie.Value != "Already Login")
            //{
            //    filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(new { Controller = "fmb01", Action = "Login.html" }));
            //}
        }
    }
}