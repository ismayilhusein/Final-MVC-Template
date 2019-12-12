using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalMvcProject.Models
{
    public class HomeService
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public bool Status { get; set; }
    }
}