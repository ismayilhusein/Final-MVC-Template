using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FinalMvcProject.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required,MaxLength(20)]
        public string Name { get; set; }
        public List<Blog> Blogs { get; set; }


    }
}