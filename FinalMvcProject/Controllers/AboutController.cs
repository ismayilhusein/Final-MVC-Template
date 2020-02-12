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
                Settings =_context.Settings.FirstOrDefault(),
                Missions = _context.Missions.OrderByDescending(m=>m.Id).Take(6).ToList(),
                Service = _context.Services.FirstOrDefault(),
                Services = _context.Services.Include("Departments").OrderByDescending(sl => sl.DepartmentsId).Take(6).ToList(),
                Departments = _context.Departments.OrderByDescending(d=>d.Id).Take(6).ToList(),
                CustomerSliders = _context.CustomerSliders.OrderByDescending(t=>t.Id).ToList()
            };

            return View(model);
        }
    }
}