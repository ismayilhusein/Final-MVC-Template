using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using FinalMvcProject.DAL;
using FinalMvcProject.Filters;
using FinalMvcProject.Helpers;
using FinalMvcProject.Models;
using FinalMvcProject.Areas.Admin.Models;

namespace FinalMvcProject.Areas.Admin.Controllers
{
    public class AuthController : Controller
    {
        private readonly FinalDoctorsDb _context;

        public AuthController()
        {
            _context = new FinalDoctorsDb();
        }
        [HttpGet]
        public ActionResult Logout()
        {
            HttpCookie cookie = Request.Cookies.Get("token");

            if (cookie == null)
            {
                return RedirectToAction("index","login");
            }

            FinalMvcProject.Models.Admin admin = _context.Admins.FirstOrDefault(a => a.Token == cookie.Value);

            if (admin == null)
            {
                return RedirectToAction("index", "login");
            }

            admin.Token = null;
            admin.ConfirmPassword = admin.Password;
            _context.SaveChanges();

            Response.Cookies["token"].Expires = DateTime.Now.AddDays(-1);


            return RedirectToAction("index", "login");
        }
    }
}
