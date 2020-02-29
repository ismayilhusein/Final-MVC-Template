namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHTMLAllow : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Blogs", "Body", c => c.String(nullable: false, storeType: "ntext"));
            AlterColumn("dbo.Doctors", "Body", c => c.String(nullable: false, storeType: "ntext"));
            AlterColumn("dbo.Services", "Body", c => c.String(nullable: false, storeType: "ntext"));
            AlterColumn("dbo.Faqs", "Body", c => c.String(nullable: false, storeType: "ntext"));
            AlterColumn("dbo.HeaderSliders", "Body", c => c.String(nullable: false, storeType: "ntext"));
            AlterColumn("dbo.Missions", "Text", c => c.String(nullable: false, storeType: "ntext"));
            AlterColumn("dbo.Settings", "AboutBody", c => c.String(nullable: false, storeType: "ntext"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Settings", "AboutBody", c => c.String());
            AlterColumn("dbo.Missions", "Text", c => c.String());
            AlterColumn("dbo.HeaderSliders", "Body", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Faqs", "Body", c => c.String());
            AlterColumn("dbo.Services", "Body", c => c.String());
            AlterColumn("dbo.Doctors", "Body", c => c.String());
            AlterColumn("dbo.Blogs", "Body", c => c.String());
        }
    }
}
