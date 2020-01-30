namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ServiceDepartments", "Service_Id", "dbo.Services");
            DropForeignKey("dbo.ServiceDepartments", "Department_Id", "dbo.Departments");
            DropIndex("dbo.ServiceDepartments", new[] { "Service_Id" });
            DropIndex("dbo.ServiceDepartments", new[] { "Department_Id" });
            AddColumn("dbo.Services", "Departments_Id", c => c.Int());
            CreateIndex("dbo.Services", "Departments_Id");
            AddForeignKey("dbo.Services", "Departments_Id", "dbo.Departments", "Id");
            DropTable("dbo.ServiceDepartments");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ServiceDepartments",
                c => new
                    {
                        Service_Id = c.Int(nullable: false),
                        Department_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Service_Id, t.Department_Id });
            
            DropForeignKey("dbo.Services", "Departments_Id", "dbo.Departments");
            DropIndex("dbo.Services", new[] { "Departments_Id" });
            DropColumn("dbo.Services", "Departments_Id");
            CreateIndex("dbo.ServiceDepartments", "Department_Id");
            CreateIndex("dbo.ServiceDepartments", "Service_Id");
            AddForeignKey("dbo.ServiceDepartments", "Department_Id", "dbo.Departments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ServiceDepartments", "Service_Id", "dbo.Services", "Id", cascadeDelete: true);
        }
    }
}
