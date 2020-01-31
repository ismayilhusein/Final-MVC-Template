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

    }
}