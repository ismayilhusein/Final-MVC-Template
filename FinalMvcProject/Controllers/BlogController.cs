using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalMvcProject.Controllers
{
    public class BlogController : BaseController
    {
        // GET: Blog
        public ActionResult List()
        {
            return View();
        }
      
        public ActionResult Single()
        {
            return View();
        }
    }
}