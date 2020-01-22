namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedRelation : DbMigration
    {
        public override void Up()
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.DoctorsId, cascadeDelete: true)
                .Index(t => t.DoctorsId);
            
            AddColumn("dbo.Doctors", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Doctors", "EndedDate", c => c.DateTime());
            CreateIndex("dbo.Doctors", "DepartmentId");
            CreateIndex("dbo.Galleries", "DepartmentId");
            AddForeignKey("dbo.Doctors", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Galleries", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
            DropColumn("dbo.Doctors", "Icon");
            DropColumn("dbo.Doctors", "Work");
            DropColumn("dbo.Doctors", "MonFri");
            DropColumn("dbo.Doctors", "Saturday");
            DropColumn("dbo.Doctors", "Sunday");
            DropColumn("dbo.Doctors", "Icons");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Doctors", "Icons", c => c.String());
            AddColumn("dbo.Doctors", "Sunday", c => c.String());
            AddColumn("dbo.Doctors", "Saturday", c => c.String());
            AddColumn("dbo.Doctors", "MonFri", c => c.String());
            AddColumn("dbo.Doctors", "Work", c => c.String());
            AddColumn("dbo.Doctors", "Icon", c => c.String());
            DropForeignKey("dbo.Galleries", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.WorkTimes", "DoctorsId", "dbo.Doctors");
            DropForeignKey("dbo.Doctors", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Galleries", new[] { "DepartmentId" });
            DropIndex("dbo.WorkTimes", new[] { "DoctorsId" });
            DropIndex("dbo.Doctors", new[] { "DepartmentId" });
            DropColumn("dbo.Doctors", "EndedDate");
            DropColumn("dbo.Doctors", "CreateDate");
            DropTable("dbo.WorkTimes");
        }
    }
}
