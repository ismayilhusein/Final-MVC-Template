namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnsToDepartments : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Departments", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "MyProperty", c => c.Int(nullable: false));
        }
    }
}
