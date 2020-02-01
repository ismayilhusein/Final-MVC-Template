using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using FinalMvcProject.Models;

namespace FinalMvcProject.DAL
{
    public class FinalDoctorsDb :DbContext
    {
        public FinalDoctorsDb() :base("FinalDoctorsDb")
        {}
        public DbSet<Admin> Admins { get; set; }
        public DbSet<HeaderSlider> HeaderSliders { get; set; }
        public DbSet<BookAppoitment> BookAppoitments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public Department Department { get; set; }
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<CustomerSlider> CustomerSliders { get; set; }
        public DbSet<Faqs> Faqs { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Missions> Missions { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<Treatments> Treatments { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<SocialLink> SocialLinks { get; set; }
        public DbSet<WorkTime> WorkTimes { get; set; }

    }
}