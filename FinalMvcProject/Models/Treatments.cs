using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FinalMvcProject.Models
{
    public class Treatments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int Type  { get; set; }
        public bool Status { get; set; }
    }
}