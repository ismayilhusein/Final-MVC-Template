using FinalMvcProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using FinalMvcProject.DAL;
using FinalMvcProject.Controllers;
using FinalMvcProject.Filters;

namespace FinalMvcProject.Areas.Admin.Controllers
{
    [Auth]
    public class RegisterController : BaseController 
    {
        // GET: Admin/Register
       
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(FinalMvcProject.Models.Admin admin)
        {
            try
            {
                admin.Photo = FileManager.Upload(admin.PhotoUpload);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("PhotoUpload", ex.Message);
            }

            if (_context.Admins.FirstOrDefault(a => a.Email == admin.Email) != null)
            {
                ModelState.AddModelError("", "The entered information is wrong");
            }

            if (ModelState.IsValid)
            {
                admin.Password = Crypto.HashPassword(admin.Password);
                admin.Token = Guid.NewGuid().ToString();
                admin.ConfirmPassword = admin.Password;

                admin.CreatedAt = DateTime.Now;
                admin.LastLoginDate = DateTime.Now;

                admin.Status = true;

                _context.Admins.Add(admin);
                _context.SaveChanges();

                HttpCookie cookie = new HttpCookie("token", admin.Token);
                cookie.Expires = DateTime.Now.AddYears(1);
                cookie.HttpOnly = true;
                Response.SetCookie(cookie);

                return RedirectToAction("index");
            }

            return View(admin);
        }

    }
}