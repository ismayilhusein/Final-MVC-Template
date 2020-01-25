using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalMvcProject.Models
{
    public class HeaderSlider
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [Required,MaxLength(200)]
        public string Title { get; set; }
        [Required, MaxLength(500)]
        public string Body { get; set; }
        [Required, MaxLength(20)]
        public string BtnText { get; set; }
        [Required, MaxLength(200)]
        public string BtnUrl { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }
        public bool Status { get; set; }
        
    }
}