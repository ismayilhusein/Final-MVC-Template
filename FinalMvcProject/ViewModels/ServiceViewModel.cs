using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalMvcProject.Models;

namespace FinalMvcProject.ViewModels
{
    public class ServiceViewModel
    {
        public IEnumerable<Service> Services { get; set; }
        public List<Department> Departments { get; set; }
        public List<CustomerSlider> CustomerSliders { get; set; }


    }
}