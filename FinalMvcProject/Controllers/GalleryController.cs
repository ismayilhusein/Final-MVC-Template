using FinalMvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalMvcProject.Controllers
{
    public class GalleryController : BaseController
    {
        // GET: Gallery
        public ActionResult Index()
        {
            List<Department> departments = _context.Departments.Include("Galleries").OrderByDescending(x => x.Id).Take(9).ToList();
            return View(departments);
        }
    }
}