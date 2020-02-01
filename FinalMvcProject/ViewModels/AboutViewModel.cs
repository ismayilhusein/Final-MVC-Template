using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalMvcProject.Models;

namespace FinalMvcProject.ViewModels
{
    public class AboutViewModel
    {
        public Setting Settings { get; set; }
        public List<Doctors> Doctors { get; set; }
        public List<Missions> Missions { get; set; }
        public Service Service { get; set; }
        public List<Department> Departments { get; set; }
        public List<CustomerSlider> CustomerSliders { get; set; }

    }
}