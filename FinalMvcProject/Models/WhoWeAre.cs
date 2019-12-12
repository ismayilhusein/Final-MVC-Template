using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalMvcProject.Models
{
    public class WhoWeAre
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public HttpPostedFileBase PhotoUpload { get; set; }
        public string Text { get; set; }
        public string Items { get; set; }
        public bool Status { get; set; }
    }
}