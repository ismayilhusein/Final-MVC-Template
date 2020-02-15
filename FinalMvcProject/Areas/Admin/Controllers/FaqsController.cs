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
    public class FaqsController : Controller
    {
        private FinalDoctorsDb db = new FinalDoctorsDb();

        // GET: Admin/Faqs
        public ActionResult Index()
        {
            return View(db.Faqs.ToList());
        }

        // GET: Admin/Faqs/Details/5
       

        // GET: Admin/Faqs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Faqs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Body,Status")] Faqs faqs)
        {
            if (ModelState.IsValid)
            {
                db.Faqs.Add(faqs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(faqs);
        }

        // GET: Admin/Faqs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Faqs faqs = db.Faqs.Find(id);
            if (faqs == null)
            {
                return HttpNotFound();
            }
            return View(faqs);
        }

        // POST: Admin/Faqs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Body,Status")] Faqs faqs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(faqs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(faqs);
        }

        // GET: Admin/Faqs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Faqs faqs = db.Faqs.Find(id);
            if (faqs == null)
            {
                return HttpNotFound();
            }
            db.Faqs.Remove(faqs);
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
