using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalMvcProject.Models;

namespace FinalMvcProject.ViewModels
{
    public class BlogViewModel
    {
        public List<Blog> Blogs { get; set; }
        public Blog SingleBlog { get; set; }

    }
}