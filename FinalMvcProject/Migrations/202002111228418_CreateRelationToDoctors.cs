namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationToDoctors : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Doctors", "DoctorLink_Id", "dbo.DoctorLinks");
            DropIndex("dbo.Doctors", new[] { "DoctorLink_Id" });
            AddColumn("dbo.DoctorLinks", "DoctorsId", c => c.Int(nullable: false));
            DropColumn("dbo.Doctors", "DoctorLink_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Doctors", "DoctorLink_Id", c => c.Int());
            DropColumn("dbo.DoctorLinks", "DoctorsId");
            CreateIndex("dbo.Doctors", "DoctorLink_Id");
            AddForeignKey("dbo.Doctors", "DoctorLink_Id", "dbo.DoctorLinks", "Id");
        }
    }
}
