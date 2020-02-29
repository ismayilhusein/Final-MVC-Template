using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace FinalMvcProject.Models
{
    public class Missions
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        [Required, Column(TypeName = "ntext"),AllowHtml]
        public string Text { get; set; }
        public bool Status { get; set; }

    }
}