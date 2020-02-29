using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace FinalMvcProject.Models
{
    public class Department
    {
       
        public int Id { get; set; }
        [Required,MaxLength(300)]
        public string Title { get; set; }
        [Required, MaxLength(30)]
        public string Icon { get; set; }
        [Required, MaxLength(300)]
        public string Desc { get; set; }
        [Required, MaxLength(300)]
        public string Content { get; set; }
        [Required,Column(TypeName ="ntext"),AllowHtml]
        public string Body { get; set; }
        public bool Status { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }

        public List<Doctors> Doctors { get; set; }
        public List<Gallery> Galleries { get; set; }
        public ICollection<Service> Services { get; set; }



    }

}