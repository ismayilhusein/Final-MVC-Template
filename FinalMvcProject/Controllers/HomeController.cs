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
                
                Departments = _context.Departments.Include("Doctors").OrderByDescending(d => d.Id).Take(6).ToList(),
                Doctors = _context.Doctors.Include("Department").OrderByDescending(d => d.Id).Take(5).ToList(),
                Services = _context.Services.Include("Departments").OrderByDescending(sl => sl.DepartmentsId).Take(6).ToList(),
                CustomerSliders = _context.CustomerSliders.OrderByDescending(c => c.Id).Take(5).ToList(),
                Faqs = _context.Faqs.OrderByDescending(f => f.Id).Take(6).ToList(),
                Blogs = _context.Blogs.OrderByDescending(l => l.Id).Take(4).ToList(),

            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Appointment(BookAppoitment model)
        {
            try
            {
            BookAppoitment appoitment = new BookAppoitment();
            appoitment.Name = model.Name;
            appoitment.Number = model.Number;
            appoitment.Email = model.Email;
            appoitment.Date = model.Date;
            appoitment.Note = model.Note;

            _context.BookAppoitments.Add(appoitment);
            _context.SaveChanges();

            int LatestAppointmentId = appoitment.Id;

            }
            catch (Exception )
            {

                throw ;
            }

            

            return RedirectToAction("index");
        }
    }
}