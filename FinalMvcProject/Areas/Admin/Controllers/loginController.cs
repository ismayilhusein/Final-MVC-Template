using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;
using FinalMvcProject.DAL;
using FinalMvcProject.Areas.Admin.Models;
using FinalMvcProject.Models;
using FinalMvcProject.Filters;

namespace FinalMvcProject.Areas.Admin.Controllers
{
    public class loginController : Controller
    {
        // GET: Admin/login
        private readonly FinalDoctorsDb db;

        public loginController()
        {
            db = new FinalDoctorsDb();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Login login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            FinalMvcProject.Models.Admin admin = db.Admins.FirstOrDefault(a => a.Email == login.Email);

            if (admin != null && Crypto.VerifyHashedPassword(admin.Password, login.Password))
            {
                admin.Token = Guid.NewGuid().ToString();
                admin.Token = Guid.NewGuid().ToString();
                admin.LastLoginDate = DateTime.Now;
                admin.ConfirmPassword = admin.Password;

                db.SaveChanges();

                HttpCookie cookie = new HttpCookie("token", admin.Token)
                {
                    HttpOnly = true,
                    Expires = login.RememberMe ? DateTime.Now.AddYears(1) : DateTime.MinValue
                };

                Response.Cookies.Add(cookie);

                return RedirectToAction("index", "Home");
            }

            ModelState.AddModelError("", "E-poçt və ya şifrə yalnışdır");

            return View(login);
        }
    }
}