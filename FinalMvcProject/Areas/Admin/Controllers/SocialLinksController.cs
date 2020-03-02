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
    public class SocialLinksController : Controller
    {
        private FinalDoctorsDb db = new FinalDoctorsDb();

        // GET: Admin/SocialLinks
        public ActionResult Index()
        {
            return View(db.SocialLinks.ToList());
        }

        // GET: Admin/SocialLinks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/SocialLinks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Icon,Url,OrderBy")] SocialLink socialLink)
        {
            if (ModelState.IsValid)
            {
                db.SocialLinks.Add(socialLink);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(socialLink);
        }

        // GET: Admin/SocialLinks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SocialLink socialLink = db.SocialLinks.Find(id);
            if (socialLink == null)
            {
                return HttpNotFound();
            }
            return View(socialLink);
        }

        // POST: Admin/SocialLinks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Icon,Url,OrderBy")] SocialLink socialLink)
        {
            if (ModelState.IsValid)
            {
                db.Entry(socialLink).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(socialLink);
        }

        // GET: Admin/SocialLinks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SocialLink socialLink = db.SocialLinks.Find(id);
            if (socialLink == null)
            {
                return HttpNotFound();
            }
            db.SocialLinks.Remove(socialLink);
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
