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
    public class HeaderSlidersController : Controller
    {
        private FinalDoctorsDb db = new FinalDoctorsDb();

        // GET: Admin/HeaderSliders
        public ActionResult Index()
        {
            return View(db.HeaderSliders.ToList());
        }

       

        // GET: Admin/HeaderSliders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/HeaderSliders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Image,Title,Body,BtnText,BtnUrl,CreatedAt,UpdatedAt,Status")] HeaderSlider headerSlider)
        {
            if (ModelState.IsValid)
            {
                db.HeaderSliders.Add(headerSlider);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(headerSlider);
        }

        // GET: Admin/HeaderSliders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HeaderSlider headerSlider = db.HeaderSliders.Find(id);
            if (headerSlider == null)
            {
                return HttpNotFound();
            }
            return View(headerSlider);
        }

        // POST: Admin/HeaderSliders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Image,Title,Body,BtnText,BtnUrl,CreatedAt,UpdatedAt,Status")] HeaderSlider headerSlider)
        {
            if (ModelState.IsValid)
            {
                db.Entry(headerSlider).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(headerSlider);
        }

        // GET: Admin/HeaderSliders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HeaderSlider headerSlider = db.HeaderSliders.Find(id);
            if (headerSlider == null)
            {
                return HttpNotFound();
            }
            db.HeaderSliders.Remove(headerSlider);
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
