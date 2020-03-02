using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalMvcProject.DAL;
using FinalMvcProject.Filters;
using FinalMvcProject.Models;

namespace FinalMvcProject.Areas.Admin.Controllers
{
    [Auth]
    public class DoctorLinksController : Controller
    {
        private FinalDoctorsDb db = new FinalDoctorsDb();

        // GET: Admin/DoctorLinks
        public ActionResult Index()
        {
            return View(db.DoctorLinks.ToList());
        }

       

        // GET: Admin/DoctorLinks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/DoctorLinks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Icon,Url,OrderBy,DoctorsId")] DoctorLink doctorLink)
        {
            if (ModelState.IsValid)
            {
                db.DoctorLinks.Add(doctorLink);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(doctorLink);
        }

        // GET: Admin/DoctorLinks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorLink doctorLink = db.DoctorLinks.Find(id);
            if (doctorLink == null)
            {
                return HttpNotFound();
            }
            return View(doctorLink);
        }

        // POST: Admin/DoctorLinks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Icon,Url,OrderBy,DoctorsId")] DoctorLink doctorLink)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctorLink).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(doctorLink);
        }

        // GET: Admin/DoctorLinks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorLink doctorLink = db.DoctorLinks.Find(id);
            if (doctorLink == null)
            {
                return HttpNotFound();
            }
            db.DoctorLinks.Remove(doctorLink);
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
