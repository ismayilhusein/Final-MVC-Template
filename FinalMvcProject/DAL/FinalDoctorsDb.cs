using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FinalMvcProject.DAL
{
    public class FinalDoctorsDb :DbContext
    {
        public FinalDoctorsDb() :base("FinalDoctorsDb")
        {
        }

    }
}