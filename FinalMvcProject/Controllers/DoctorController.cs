using FinalMvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalMvcProject.Controllers
{
    public class DoctorController : BaseController
    {
        // GET: Doctor
        public ActionResult Index()
        {
            List<Department> departments = _context.Departments.Include("Doctors").OrderByDescending(x=>x.Id).Take(6).ToList();
            return View(departments);
        }
    }
}