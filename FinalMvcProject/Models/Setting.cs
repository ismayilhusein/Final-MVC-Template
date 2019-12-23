using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalMvcProject.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public string HeaderLogo { get; set; }
        public string  FooterLogo { get; set; }
        public string Text { get; set; }
        public string Location { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public string Icon { get; set; }

    }
}