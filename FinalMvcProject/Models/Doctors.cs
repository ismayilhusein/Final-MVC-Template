using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalMvcProject.Models
{
    public class Doctors
    {
        
        public int Id { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        public string FullName { get; set; }
        public string Degrees { get; set; }
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        public DateTime CreateDate { get; set; }
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        public DateTime? EndedDate { get; set; }
        public bool Status { get; set; }
        [Required, Column(TypeName = "ntext"),AllowHtml]
        public string Body { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
       
       

    }
}