using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalMvcProject.Models
{
    public class CustomerSlider
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        public string FullName { get; set; }
        public string WhatProblems { get; set; }
        public string Text { get; set; }
        public bool Status { get; set; }
    }
}