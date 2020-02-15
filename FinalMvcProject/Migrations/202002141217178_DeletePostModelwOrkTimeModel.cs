namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletePostModelwOrkTimeModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.WorkTimes", "DoctorsId", "dbo.Doctors");
            DropIndex("dbo.WorkTimes", new[] { "DoctorsId" });
            DropTable("dbo.WorkTimes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.WorkTimes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Week = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                        DoctorsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.WorkTimes", "DoctorsId");
            AddForeignKey("dbo.WorkTimes", "DoctorsId", "dbo.Doctors", "Id", cascadeDelete: true);
        }
    }
}
