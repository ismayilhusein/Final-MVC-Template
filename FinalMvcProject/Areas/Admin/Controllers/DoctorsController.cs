using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalMvcProject.DAL;
using FinalMvcProject.Models;

namespace FinalMvcProject.Areas.Admin.Controllers
{
    public class DoctorsController : Controller
    {
        private FinalDoctorsDb db = new FinalDoctorsDb();

        // GET: Admin/Doctors
        public ActionResult Index()
        {
            var doctors = db.Doctors.Include(d => d.Department);
            return View(doctors.ToList());
        }

        // GET: Admin/Doctors/Details/5
       

        // GET: Admin/Doctors/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Title");
            return View();
        }

        // POST: Admin/Doctors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Photo,FullName,Degrees,CreateDate,EndedDate,Status,Body,DepartmentId")] Doctors doctors)
        {
            if (ModelState.IsValid)
            {
                db.Doctors.Add(doctors);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Title", doctors.DepartmentId);
            return View(doctors);
        }

        // GET: Admin/Doctors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctors doctors = db.Doctors.Find(id);
            if (doctors == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Title", doctors.DepartmentId);
            return View(doctors);
        }

        // POST: Admin/Doctors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Photo,FullName,Degrees,CreateDate,EndedDate,Status,Body,DepartmentId")] Doctors doctors)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctors).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Title", doctors.DepartmentId);
            return View(doctors);
        }

        // GET: Admin/Doctors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctors doctors = db.Doctors.Find(id);
            if (doctors == null)
            {
                return HttpNotFound();
            }
            db.Doctors.Remove(doctors);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
