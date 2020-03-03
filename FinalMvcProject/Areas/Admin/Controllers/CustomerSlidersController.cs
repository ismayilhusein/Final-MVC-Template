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
   
    public class CustomerSlidersController : Controller
    {
        private FinalDoctorsDb db = new FinalDoctorsDb();

        // GET: Admin/CustomerSliders
        public ActionResult Index()
        {
            return View(db.CustomerSliders.ToList());
        }
        // GET: Admin/CustomerSliders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/CustomerSliders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create( CustomerSlider customerSlider)
        {
            try
            {
                customerSlider.Photo = FileManager.Upload(customerSlider.PhotoUpload);
  
            }
            catch (Exception e)
            {
                ModelState.AddModelError("PhotoUpload", e.Message);
            }


            if (ModelState.IsValid)
            {
                db.CustomerSliders.Add(customerSlider);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customerSlider);
        }

        // GET: Admin/CustomerSliders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerSlider customerSlider = db.CustomerSliders.Find(id);
            if (customerSlider == null)
            {
                return HttpNotFound();
            }
            return View(customerSlider);
        }

        // POST: Admin/CustomerSliders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "Id,Photo,FullName,WhatProblems,Text,Status,PhotoUpload")] CustomerSlider customerSlider)
        {
           
            
                try
                {
                  
                    customerSlider.Photo = FileManager.Upload(customerSlider.PhotoUpload);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("PhotoUpload", e.Message);
                }
            

            if (ModelState.IsValid)
            {
                db.Entry(customerSlider).State = EntityState.Modified;
               

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customerSlider);
        }

        // GET: Admin/CustomerSliders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerSlider customerSlider = db.CustomerSliders.Find(id);
            if (customerSlider == null)
            {
                return HttpNotFound();
            }
            db.CustomerSliders.Remove(customerSlider);
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
