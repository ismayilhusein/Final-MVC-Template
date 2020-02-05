using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalMvcProject.ViewModels;

namespace FinalMvcProject.Controllers
{
    public class DepartmentsController : BaseController
    {
        // GET: Departments
        public ActionResult Index()
        {
            DepartmentViewModel model = new DepartmentViewModel
            {
                Departments = _context.Departments.Include("Doctors").OrderByDescending(d => d.Id).Take(6).ToList(),
            };
           
            return View(model);
        }
        public ActionResult Single()
        {
            return View();
        }
    }
}