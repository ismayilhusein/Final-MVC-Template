namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletePhotoToService : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Services", "Photo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Services", "Photo", c => c.String());
        }
    }
}
