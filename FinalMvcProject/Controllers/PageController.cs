using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalMvcProject.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Doctor()
        {
            return View();
        }
        public ActionResult DoctorDetails()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
    }
}