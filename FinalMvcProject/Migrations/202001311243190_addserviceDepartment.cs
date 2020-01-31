namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addserviceDepartment : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Services", "Departments_Id", "dbo.Departments");
            DropIndex("dbo.Services", new[] { "Departments_Id" });
            RenameColumn(table: "dbo.Services", name: "Departments_Id", newName: "DepartmentsId");
            AlterColumn("dbo.Services", "DepartmentsId", c => c.Int(nullable: true));
            CreateIndex("dbo.Services", "DepartmentsId");
            AddForeignKey("dbo.Services", "DepartmentsId", "dbo.Departments", "Id", cascadeDelete: true);
            DropColumn("dbo.Services", "DepartId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Services", "DepartId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Services", "DepartmentsId", "dbo.Departments");
            DropIndex("dbo.Services", new[] { "DepartmentsId" });
            AlterColumn("dbo.Services", "DepartmentsId", c => c.Int());
            RenameColumn(table: "dbo.Services", name: "DepartmentsId", newName: "Departments_Id");
            CreateIndex("dbo.Services", "Departments_Id");
            AddForeignKey("dbo.Services", "Departments_Id", "dbo.Departments", "Id");
        }
    }
}
