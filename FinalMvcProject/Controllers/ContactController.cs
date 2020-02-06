using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalMvcProject.ViewModels;

namespace FinalMvcProject.Controllers
{
    public class ContactController : BaseController
    {
        // GET: Contact
        public ActionResult Index()
        {
            ContactUsViewModel model = new ContactUsViewModel
            {
                Setting = _context.Settings.FirstOrDefault()
            };
            return View(model);
        }
    }
}