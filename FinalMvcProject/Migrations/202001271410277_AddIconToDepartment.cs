namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIconToDepartment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "Icon", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departments", "Icon");
        }
    }
}
