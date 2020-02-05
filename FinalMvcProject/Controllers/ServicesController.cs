using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalMvcProject.ViewModels;

namespace FinalMvcProject.Controllers
{
    public class ServicesController : BaseController
    {
        // GET: Services
        public ActionResult Index()
        {
            ServiceViewModel model = new ServiceViewModel
            {
                Services = _context.Services.Include("Departments").OrderByDescending(sl => sl.DepartmentsId).Take(6).ToList(),
                Departments = _context.Departments.OrderByDescending(d => d.Id).Take(6).ToList(),
                CustomerSliders = _context.CustomerSliders.OrderByDescending(t => t.Id).ToList()
            };
            return View(model);
        }
    }
}