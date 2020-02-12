using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FinalMvcProject.Models
{
    public class WorkTime
    {

        public int Id { get; set; }
        public Week Week { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int DoctorsId { get; set; }
        public Doctors Doctors { get; set; }
    }
}