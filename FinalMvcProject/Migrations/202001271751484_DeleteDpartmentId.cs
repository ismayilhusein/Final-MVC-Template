namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteDpartmentId : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Departments", "ServiceId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "ServiceId", c => c.Int(nullable: false));
        }
    }
}
