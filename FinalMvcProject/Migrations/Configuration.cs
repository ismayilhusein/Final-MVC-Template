namespace FinalMvcProject.Migrations
{
    using FinalMvcProject.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FinalMvcProject.DAL.FinalDoctorsDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FinalMvcProject.DAL.FinalDoctorsDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //context.HeaderSliders.AddOrUpdate(x => x.Id,
            //    new HeaderSlider()
            //    {
            //        Image = "homeslider1.jpg",
            //        Title = "Let us protect your health",
            //        Body = " Vestibulum tortor quam,feugiat vitae, ultricies eget,tempor sit amet,ant.isi ",
            //        CreatedAt = 2020 - 01 - 10,
            //        UpdatedAt = 2020/03/02,
            //        Status = true,
            //        BtnText = "Servisler",
            //        BtnUrl = "/about"

            //    });
                
            
        }
    }
}
