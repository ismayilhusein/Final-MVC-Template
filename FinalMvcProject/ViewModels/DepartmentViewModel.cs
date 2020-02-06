using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalMvcProject.Models;

namespace FinalMvcProject.ViewModels
{
    public class DepartmentViewModel
    {
        public List<Department> Departments { get; set; }
        public Setting Setting { get; set; }
        public List<Treatments> Treatments { get; set; }
        
    }
}