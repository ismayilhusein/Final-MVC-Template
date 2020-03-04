namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditSettingModelsColumn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Settings", "HeaderLogo", c => c.String(maxLength: 200));
            AlterColumn("dbo.Settings", "FooterLogo", c => c.String(maxLength: 200));
            AlterColumn("dbo.Settings", "Text", c => c.String(maxLength: 900));
            AlterColumn("dbo.Settings", "Country", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Settings", "Number", c => c.String(maxLength: 500));
            AlterColumn("dbo.Settings", "Email", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Settings", "Email", c => c.String(maxLength: 50));
            AlterColumn("dbo.Settings", "Number", c => c.String(maxLength: 50));
            AlterColumn("dbo.Settings", "Country", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Settings", "Text", c => c.String(maxLength: 500));
            AlterColumn("dbo.Settings", "FooterLogo", c => c.String(maxLength: 50));
            AlterColumn("dbo.Settings", "HeaderLogo", c => c.String(maxLength: 50));
        }
    }
}
