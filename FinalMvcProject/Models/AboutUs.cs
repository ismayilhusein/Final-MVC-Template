using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalMvcProject.Models
{
    public class AboutUs
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        [Required, MaxLength(50)]
        public string Title { get; set; }
        [Required,MaxLength(500)]
        public string Text { get; set; }
        [Required, Column(TypeName = "ntext")]
        public string Body { get; set; }
        public bool Status { get; set; }

    }
}