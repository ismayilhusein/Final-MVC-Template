using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalMvcProject.Models
{
    public class SocialLink
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Icon { get; set; }
        [Required,MaxLength(200)]
        public string Url { get; set; }
        [Required]
        public int OrderBy { get; set; }
    }
}