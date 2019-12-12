using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalMvcProject.Models
{
    public class HeaderSlider
    {
        public int Id { get; set; }
        [Required]

        public string Title { get; set; }
        public string Desc { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        public bool Status { get; set; }
    }
}