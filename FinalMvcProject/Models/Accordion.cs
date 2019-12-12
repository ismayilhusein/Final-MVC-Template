using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalMvcProject.Models
{
    public class Accordion
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public bool Status { get; set; }

    }
}