using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FinalMvcProject.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Desc { get; set; }
        public DateTime Date { get; set; }


    }
}