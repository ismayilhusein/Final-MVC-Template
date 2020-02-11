using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalMvcProject.Models
{
    public class DoctorLink
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Icon { get; set; }
        [Required, MaxLength(200)]
        public string Url { get; set; }
        [Required]
        public int OrderBy { get; set; }
        public int DoctorsId { get; set; }
    }
}