﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalMvcProject.Models
{
    public class ContactUs
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public bool Status { get; set; }
    }
}