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
            DepartmentViewModel model= new DepartmentViewModel
            {
                Setting = _context.Settings.FirstOrDefault(),
                Treatments =_context.Treatments.Take(7).OrderByDescending(t=>t.Id).ToList(),
                Department = _context.Departments.FirstOrDefault(),
                Doctors = _context.Doctors.OrderByDescending(d=>d.Id).Take(3).ToList(),
                DoctorLinks = _context.DoctorLinks.Take(4).ToList()
                
                

            };
            return View(model);
        }
    }
}