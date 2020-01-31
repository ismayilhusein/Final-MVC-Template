namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteId : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Departments", "DoctorId");
            DropColumn("dbo.Departments", "GaleryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "GaleryId", c => c.Int(nullable: false));
            AddColumn("dbo.Departments", "DoctorId", c => c.Int(nullable: false));
        }
    }
}
