using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalMvcProject.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Image { get; set; }
        [Required, MaxLength(50)]
        public string imagePng { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }
        [Required, MaxLength(150)]
        public string Title { get; set; }
        [Required, Column(TypeName = "date")]
        public DateTime CreatedAt { get; set; }
        [Required,MaxLength(20)]
        public string UpdateYear { get; set; }
        [Required, MaxLength(20)]
        public string UpdateMounth { get; set; }
        [Required, MaxLength(20)]
        public string UpdateDay { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        [Required, Column(TypeName ="ntext")]
        public string ShortBody { get; set; }
        [Required, Column(TypeName = "ntext")]
        public string Body { get; set; }
    }
}