using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalMvcProject.Models
{
    public class Service
    {
       
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool Status { get; set; }
        public Department Departments { get; set; }
        public int DepartmentsId { get; set; }

    }
}