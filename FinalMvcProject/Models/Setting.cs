using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalMvcProject.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string HeaderLogo { get; set; }
        [MaxLength(50)]
        public string  FooterLogo { get; set; }
        [MaxLength(500)]
        public string Text { get; set; }
        [MaxLength(100)]
        public string Location { get; set; }
        [MaxLength(50),Required]
        public string Country { get; set; }
        [MaxLength(50)]
        public string Number { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }
        public string AboutImage { get; set; }
        public string AboutBody { get; set; }

    }
}