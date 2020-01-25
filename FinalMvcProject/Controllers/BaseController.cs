using FinalMvcProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalMvcProject.Controllers
{
    public class BaseController : Controller
    {
        protected readonly FinalDoctorsDb _context;

        public BaseController()
        {
            _context = new FinalDoctorsDb();
            ViewBag.SocialLink = _context.SocialLinks.OrderBy(o => o.OrderBy).ToList();
            ViewBag.Setting = _context.Settings.FirstOrDefault();
        }
    }
}