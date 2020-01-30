﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalMvcProject.Models
{
    public class Department
    {
        public Department()
        {
            Doctors = new HashSet<Doctors>();
            Galleries = new HashSet<Gallery>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Desc { get; set; }
        public string Body { get; set; }
        public bool Status { get; set; }

        public ICollection<Doctors> Doctors { get; set; }
        public int DoctorId { get; set; }
        public ICollection<Gallery> Galleries { get; set; }
        public int GaleryId { get; set; }
     


    }

}