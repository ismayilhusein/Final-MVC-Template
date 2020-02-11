namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnsToDepartment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "Content", c => c.String());
            AddColumn("dbo.Departments", "Image", c => c.String());
            AddColumn("dbo.Departments", "MyProperty", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departments", "MyProperty");
            DropColumn("dbo.Departments", "Image");
            DropColumn("dbo.Departments", "Content");
        }
    }
}
