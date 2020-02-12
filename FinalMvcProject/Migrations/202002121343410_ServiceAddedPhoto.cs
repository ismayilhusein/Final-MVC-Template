namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ServiceAddedPhoto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "Photo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Services", "Photo");
        }
    }
}
