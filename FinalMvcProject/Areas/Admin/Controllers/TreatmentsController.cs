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
    public class TreatmentsController : Controller
    {
        private FinalDoctorsDb db = new FinalDoctorsDb();

        // GET: Admin/Treatments
        public ActionResult Index()
        {
            return View(db.Treatments.ToList());
        }

        // GET: Admin/Treatments/Details/5
       

        // GET: Admin/Treatments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Treatments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Price,Type,Status")] Treatments treatments)
        {
            if (ModelState.IsValid)
            {
                db.Treatments.Add(treatments);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(treatments);
        }

        // GET: Admin/Treatments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treatments treatments = db.Treatments.Find(id);
            if (treatments == null)
            {
                return HttpNotFound();
            }
            return View(treatments);
        }

        // POST: Admin/Treatments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Price,Type,Status")] Treatments treatments)
        {
            if (ModelState.IsValid)
            {
                db.Entry(treatments).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(treatments);
        }

        // GET: Admin/Treatments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treatments treatments = db.Treatments.Find(id);
            if (treatments == null)
            {
                return HttpNotFound();
            }
            db.Treatments.Remove(treatments);
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
