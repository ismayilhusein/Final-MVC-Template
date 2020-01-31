using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalMvcProject.ViewModels;

namespace FinalMvcProject.Controllers
{
    public class AboutController : BaseController
    {
        // GET: About
        public ActionResult Index()
        {
            AboutViewModel model = new AboutViewModel
            {
                Doctors = _context.Doctors.Include("Department").OrderByDescending(d => d.Id).Take(5).ToList(),
                Settings =_context.Settings.FirstOrDefault()
            };

            return View(model);
        }
    }
}