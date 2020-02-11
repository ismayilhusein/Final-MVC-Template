using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalMvcProject.Models;

namespace FinalMvcProject.ViewModels
{
    public class DepartmentViewModel
    {
        public Department Department { get; set; }
        public List<Doctors> Doctors { get; set; }
        public List<Department> Departments { get; set; }
        public Setting Setting { get; set; }
        public List<Treatments> Treatments { get; set; }
        public List<DoctorLink> DoctorLinks { get; set; }

    }
}