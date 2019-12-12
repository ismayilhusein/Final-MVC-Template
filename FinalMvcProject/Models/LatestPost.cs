using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalMvcProject.Models
{
    public class LatestPost
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public HttpPostedFileBase PhotoUpload { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Role { get; set; }
        public int Comment { get; set; }
        public string Text { get; set; }
        public bool Status { get; set; }


    }
}