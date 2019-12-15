using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalMvcProject.Models
{
    public class BlogLIst
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public HttpPostedFileBase PhotoUpload { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public string Role { get; set; }
        public int  Comments { get; set; }
        public int Year { get; set; }
        public int Day { get; set; }
        public string Mounth { get; set; }
        public string Video { get; set; }
        public string Comment { get; set; }
        public string By { get; set; }
        public bool Status { get; set; }
    }

}