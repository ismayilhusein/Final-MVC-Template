using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalMvcProject.Models
{
    public class BookAppoitment
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }
        [Required,MaxLength(50)]
        public string Number { get; set; }
        [Required,MaxLength(50)]
        public string Email { get; set; }
        [Required, Column(TypeName = "date")]
        public DateTime Date { get; set; }
        [Required, Column(TypeName = "ntext")]
        public string Note { get; set; }

    }
}