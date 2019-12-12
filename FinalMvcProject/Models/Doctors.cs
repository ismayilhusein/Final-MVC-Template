using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalMvcProject.Models
{
    public class Doctors
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public HttpPostedFileBase PhotoUpload { get; set; }
        public string Icon { get; set; }
        public string FullName { get; set; }
        public string Work { get; set; }
        public string Degrees { get; set; }
        public string MonFri { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }
        public string Icons { get; set; }
        public bool Status { get; set; }
    }
}