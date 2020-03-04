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
    public class BookAppoitmentsController : Controller
    {
        private FinalDoctorsDb db = new FinalDoctorsDb();

        // GET: Admin/BookAppoitments
        public ActionResult Index()
        {
            return View(db.BookAppoitments.ToList());
        }

        

        
       

       

        // GET: Admin/BookAppoitments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookAppoitment bookAppoitment = db.BookAppoitments.Find(id);
            if (bookAppoitment == null)
            {
                return HttpNotFound();
            }
            db.BookAppoitments.Remove(bookAppoitment);
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
