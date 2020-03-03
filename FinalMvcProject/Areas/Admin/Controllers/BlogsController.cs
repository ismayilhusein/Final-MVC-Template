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
    public class BlogsController : Controller
    {
        private FinalDoctorsDb db = new FinalDoctorsDb();

        // GET: Admin/Blogs
        public ActionResult Index()
        {
            return View(db.Blogs.Include("Author").ToList());
        }

       
        // GET: Admin/Blogs/Create
        public ActionResult Create()
        {
            ViewBag.Authors = db.Authors.ToList();
            return View();
        }

        // POST: Admin/Blogs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create( Blog blog)
        {
            try
            {
                blog.imagePng = FileManager.Upload(blog.PhotoUploadPng);
                blog.Image = FileManager.Upload(blog.PhotoUpload);

            }
            catch (Exception e)
            {
                ModelState.AddModelError("PhotoUpload", e.Message);
            }
            if (ModelState.IsValid)
            {
                db.Blogs.Add(blog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blog);
        }

        // GET: Admin/Blogs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = db.Blogs.Find(id);
            if (blog == null)
            {
                return HttpNotFound();

            }
            ViewBag.Authors = db.Authors.ToList();
            return View(blog);
        }

        // POST: Admin/Blogs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Image,ImagePng,PhotoUpload,Title,CreatedAt,AuthorId,Body")] Blog blog)
        {
            if (blog.PhotoUpload != null)
            {
                try
                {
                    FileManager.Delete(blog.Image);
                    blog.Image = FileManager.Upload(blog.PhotoUpload);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("PhotoUpload", e.Message);
                }
            }

            if (ModelState.IsValid)
            {
                db.Entry(blog).State = EntityState.Modified;

                db.Entry(blog).Property(s => s.Status == true).IsModified = false;

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blog);
        }

        // GET: Admin/Blogs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = db.Blogs.Find(id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            db.Blogs.Remove(blog);
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
