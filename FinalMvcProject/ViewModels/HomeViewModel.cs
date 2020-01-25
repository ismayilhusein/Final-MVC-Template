using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalMvcProject.Models;

namespace FinalMvcProject.ViewModels
{
    public class HomeViewModel
    {
        public List<HeaderSlider> HeaderSliders { get; set; }
        public List<BookAppoitment> BookAppoitments { get; set; }
        public List<Department> Departments { get; set; }
        public List<Doctors> Doctors { get; set; }
        public List<Service> Services { get; set; }
        public List<CustomerSlider> CustomerSliders { get; set; }
        public List<Faqs> Faqs { get; set; }
        public List<LatestPost> LatestPosts { get; set; }
    }
}