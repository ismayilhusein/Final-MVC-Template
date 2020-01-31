namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSettingRows : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Settings", "AboutImage", c => c.String());
            AddColumn("dbo.Settings", "AboutBody", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Settings", "AboutBody");
            DropColumn("dbo.Settings", "AboutImage");
        }
    }
}
