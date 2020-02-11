﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalMvcProject.Models
{
    public class Department
    {
       
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Desc { get; set; }
        public string Content { get; set; }
        public string Body { get; set; }
        public bool Status { get; set; }
        public string Image { get; set; }

        public ICollection<Doctors> Doctors { get; set; }
        public ICollection<Gallery> Galleries { get; set; }
        public ICollection<Service> Services { get; set; }



    }

}