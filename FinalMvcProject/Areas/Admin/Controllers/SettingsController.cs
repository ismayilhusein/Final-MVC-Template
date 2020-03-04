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
using FinalMvcProject.Helpers;
using FinalMvcProject.Models;

namespace FinalMvcProject.Areas.Admin.Controllers
{
    [Auth]
    public class SettingsController : Controller
    {
        private FinalDoctorsDb db = new FinalDoctorsDb();

        // GET: Admin/Settings
        public ActionResult Index()
        {
            return View(db.Settings.ToList());
        }

        // GET: Admin/Settings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Settings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create( Setting setting)
        {
            try
            {
                setting.AboutImage = FileManager.Upload(setting.ImageUpload);
                setting.HeaderLogo = FileManager.Upload(setting.HeaderUpload);
                setting.FooterLogo = FileManager.Upload(setting.FooterUpload);

            }
            catch (Exception e)
            {
                ModelState.AddModelError("PhotoUpload", e.Message);
            }
            if (ModelState.IsValid)
            {
                db.Settings.Add(setting);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(setting);
        }

        // GET: Admin/Settings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Setting setting = db.Settings.Find(id);
            if (setting == null)
            {
                return HttpNotFound();
            }
            return View(setting);
        }

        // POST: Admin/Settings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "Id,HeaderLogo,HeaderUpload,FooterUpload,FooterLogo,Text,Location,Country,Number,Email,AboutImage,ImageUpload,AboutBody")] Setting setting)
        {
            try
            {
                setting.AboutImage = FileManager.Upload(setting.ImageUpload);
                setting.HeaderLogo = FileManager.Upload(setting.HeaderUpload);
                setting.FooterLogo = FileManager.Upload(setting.FooterUpload);

            }
            catch (Exception e)
            {
                ModelState.AddModelError("PhotoUpload", e.Message);
            }
            if (ModelState.IsValid)
            {
                db.Entry(setting).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(setting);
        }

        // GET: Admin/Settings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Setting setting = db.Settings.Find(id);
            if (setting == null)
            {
                return HttpNotFound();
            }
            db.Settings.Remove(setting);
            db.SaveChanges();


            return RedirectToAction("index");
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
