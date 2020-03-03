using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace FinalMvcProject.Models
{
    public class CustomerSlider
    {
        public int Id { get; set; }
        [ MaxLength(200)]
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        [Required, MaxLength(50)]
        public string FullName { get; set; }
        [Required, MaxLength(50)]
        public string WhatProblems { get; set; }
        [Required, Column(TypeName ="ntext"),AllowHtml]
        public string Text { get; set; }
        public bool Status { get; set; }
    }
}