using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalMvcProject.Models
{
    public class Doctors
    {
        public Doctors()
        {
            Department = new Department();
        }
        public int Id { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        public string FullName { get; set; }
        public string Degrees { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EndedDate { get; set; }
        public bool Status { get; set; }
        public string Body { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
       
    }
}