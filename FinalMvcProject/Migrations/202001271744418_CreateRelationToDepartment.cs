namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationToDepartment : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Departments", "Service_Id", "dbo.Services");
            DropIndex("dbo.Departments", new[] { "Service_Id" });
            CreateTable(
                "dbo.ServiceDepartments",
                c => new
                    {
                        Service_Id = c.Int(nullable: false),
                        Department_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Service_Id, t.Department_Id })
                .ForeignKey("dbo.Services", t => t.Service_Id, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.Department_Id, cascadeDelete: true)
                .Index(t => t.Service_Id)
                .Index(t => t.Department_Id);
            
            AddColumn("dbo.Departments", "ServiceId", c => c.Int(nullable: false));
            DropColumn("dbo.Departments", "Service_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "Service_Id", c => c.Int());
            DropForeignKey("dbo.ServiceDepartments", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.ServiceDepartments", "Service_Id", "dbo.Services");
            DropIndex("dbo.ServiceDepartments", new[] { "Department_Id" });
            DropIndex("dbo.ServiceDepartments", new[] { "Service_Id" });
            DropColumn("dbo.Departments", "ServiceId");
            DropTable("dbo.ServiceDepartments");
            CreateIndex("dbo.Departments", "Service_Id");
            AddForeignKey("dbo.Departments", "Service_Id", "dbo.Services", "Id");
        }
    }
}
