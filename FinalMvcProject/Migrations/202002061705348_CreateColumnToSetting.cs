namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateColumnToSetting : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Settings", "Country", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Settings", "Country");
        }
    }
}
