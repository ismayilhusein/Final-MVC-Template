using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalMvcProject.Models;
using FinalMvcProject.ViewModels;

namespace FinalMvcProject.Controllers
{
    public class HomeController : BaseController
    {
        public List<CustomerSlider> CustomerSlider { get; private set; }

        // GET: Home
        public ActionResult Index()
        {
           HomeViewModel model = new HomeViewModel
            {
                HeaderSliders = _context.HeaderSliders.OrderByDescending(s => s.Id).ToList(),
                BookAppoitments = _context.BookAppoitments.ToList(),
                Departments = _context.Departments.OrderByDescending(d => d.Id).Take(6).ToList(),
                Doctors = _context.Doctors.Include("Department").OrderByDescending(d => d.Id).Take(5).ToList(),
                Services = _context.Services.OrderByDescending(sl => sl.DepartId).Take(6).ToList(),
                CustomerSliders = _context.CustomerSliders.OrderByDescending(c => c.Id).Take(5).ToList(),
                Faqs = _context.Faqs.OrderByDescending(f=>f.Id).Take(6).ToList(),
                LatestPosts =_context.LatestPosts.OrderByDescending(l=>l.Id).Take(4).ToList(),

            };
            return View(model);
        }
    }
}