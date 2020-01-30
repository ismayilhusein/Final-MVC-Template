namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRElationToService : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "DoctorId", c => c.Int(nullable: false));
            AddColumn("dbo.Departments", "GaleryId", c => c.Int(nullable: false));
            AddColumn("dbo.Departments", "Service_Id", c => c.Int());
            AddColumn("dbo.Services", "DepartId", c => c.Int(nullable: false));
            CreateIndex("dbo.Departments", "Service_Id");
            AddForeignKey("dbo.Departments", "Service_Id", "dbo.Services", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departments", "Service_Id", "dbo.Services");
            DropIndex("dbo.Departments", new[] { "Service_Id" });
            DropColumn("dbo.Services", "DepartId");
            DropColumn("dbo.Departments", "Service_Id");
            DropColumn("dbo.Departments", "GaleryId");
            DropColumn("dbo.Departments", "DoctorId");
        }
    }
}
