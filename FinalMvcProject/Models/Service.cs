using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace FinalMvcProject.Models
{
    public class Service
    {
       
        public int Id { get; set; }
        public string Title { get; set; }
        public string MiniBody { get; set; }
        [Required, Column(TypeName = "ntext"),AllowHtml]
        public string Body { get; set; }
        public bool Status { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        public Department Departments { get; set; }
        public int DepartmentsId { get; set; }
    }
}