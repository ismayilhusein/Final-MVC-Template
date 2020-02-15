using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalMvcProject.ViewModels;

namespace FinalMvcProject.Controllers
{
    public class BlogController : BaseController
    {
        // GET: Blog
        public ActionResult List()
        {
            BlogViewModel model = new BlogViewModel
            {
                Blogs = _context.Blogs.Include("Author").OrderByDescending(b=>b.Id).Take(6).ToList()
            };
            return View(model);
        }
      
        public ActionResult Single(int? id)
        {
            BlogViewModel model = new BlogViewModel
            {
               SingleBlog = _context.Blogs.Include("Author").OrderByDescending(o=>o.Id).FirstOrDefault(x => x.Id == id)
            };
            return View(model);
        }
    }
}