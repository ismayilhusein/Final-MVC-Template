using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalMvcProject.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public int AuthorId { get; set; }
        public string Body { get; set; }
    }
}