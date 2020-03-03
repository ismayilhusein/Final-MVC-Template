using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalMvcProject.DAL;

namespace FinalMvcProject.Filters
{
    public class Auth : ActionFilterAttribute
    {
        private readonly FinalDoctorsDb _context;

        public Auth()
        {
            _context = new FinalDoctorsDb();
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies.Get("token");

            if (cookie == null)
            {
                filterContext.Result = new RedirectResult("~/admin/login/");
                return;
            }

            var admin = _context.Admins.FirstOrDefault(a => a.Token == cookie.Value);

            if (admin == null)
            {
                filterContext.Result = new RedirectResult("~/admin/login/");
                return;
            }

            filterContext.Controller.ViewBag.Admin = admin;

            base.OnActionExecuting(filterContext);
        }
    }
}