using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalMvcProject.Models
{
    public class DoctorSlider
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public string Icon { get; set; }
        public HttpPostedFileBase PhotoUpload { get; set; }
        public string FullName { get; set; }
        public string Work { get; set; }
        public bool Status { get; set; }
    }
}