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
    public class GalleriesController : Controller
    {
        private FinalDoctorsDb db = new FinalDoctorsDb();

        // GET: Admin/Galleries
        public ActionResult Index()
        {
            var galleries = db.Galleries.Include(g => g.Department);
            return View(galleries.ToList());
        }

       

        // GET: Admin/Galleries/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Title");
            return View();
        }

        // POST: Admin/Galleries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Photo,DepartmentId,Status")] Gallery gallery)
        {
            if (ModelState.IsValid)
            {
                db.Galleries.Add(gallery);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Title", gallery.DepartmentId);
            return View(gallery);
        }

        // GET: Admin/Galleries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gallery gallery = db.Galleries.Find(id);
            if (gallery == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Title", gallery.DepartmentId);
            return View(gallery);
        }

        // POST: Admin/Galleries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Photo,DepartmentId,Status")] Gallery gallery)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gallery).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Title", gallery.DepartmentId);
            return View(gallery);
        }

        // GET: Admin/Galleries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Gallery gallery = db.Galleries.Find(id);
            if (gallery == null)
            {
                return HttpNotFound();
            }
            db.Galleries.Remove(gallery);
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
