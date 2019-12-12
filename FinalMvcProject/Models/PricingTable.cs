using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalMvcProject.Models
{
    public class PricingTable
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Money { get; set; }
        public string Care { get; set; }
        public int Hours { get; set; }
        public int Appointments { get; set; }
        public string Appoint { get; set; }
        public string Choose { get; set; }
        public bool Status { get; set; }
    }
}