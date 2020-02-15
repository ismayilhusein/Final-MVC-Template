namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBlog : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Blogs", "Image", c => c.String());
            AlterColumn("dbo.Blogs", "imagePng", c => c.String());
            AlterColumn("dbo.Blogs", "Title", c => c.String());
            AlterColumn("dbo.Blogs", "CreatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Blogs", "UpdateMounth", c => c.String());
            AlterColumn("dbo.Blogs", "ShortBody", c => c.String());
            AlterColumn("dbo.Blogs", "Body", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Blogs", "Body", c => c.String(nullable: false, storeType: "ntext"));
            AlterColumn("dbo.Blogs", "ShortBody", c => c.String(nullable: false, storeType: "ntext"));
            AlterColumn("dbo.Blogs", "UpdateMounth", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Blogs", "CreatedAt", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Blogs", "Title", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Blogs", "imagePng", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Blogs", "Image", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
