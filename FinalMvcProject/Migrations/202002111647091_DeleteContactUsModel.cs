namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteContactUsModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AboutUs", "Photo", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.AboutUs", "Title", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.AboutUs", "Text", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.AboutUs", "Body", c => c.String(nullable: false, storeType: "ntext"));
            AlterColumn("dbo.Authors", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Blogs", "Image", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Blogs", "imagePng", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Blogs", "Title", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Blogs", "CreatedAt", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Blogs", "UpdateYear", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Blogs", "UpdateMounth", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Blogs", "UpdateDay", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Blogs", "ShortBody", c => c.String(nullable: false, storeType: "ntext"));
            AlterColumn("dbo.Blogs", "Body", c => c.String(nullable: false, storeType: "ntext"));
            DropTable("dbo.ContactUs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ContactUs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        Email = c.String(),
                        Location = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Blogs", "Body", c => c.String());
            AlterColumn("dbo.Blogs", "ShortBody", c => c.String());
            AlterColumn("dbo.Blogs", "UpdateDay", c => c.String());
            AlterColumn("dbo.Blogs", "UpdateMounth", c => c.String());
            AlterColumn("dbo.Blogs", "UpdateYear", c => c.String());
            AlterColumn("dbo.Blogs", "CreatedAt", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Blogs", "Title", c => c.String());
            AlterColumn("dbo.Blogs", "imagePng", c => c.String());
            AlterColumn("dbo.Blogs", "Image", c => c.String());
            AlterColumn("dbo.Authors", "Name", c => c.String());
            AlterColumn("dbo.AboutUs", "Body", c => c.String());
            AlterColumn("dbo.AboutUs", "Text", c => c.String());
            AlterColumn("dbo.AboutUs", "Title", c => c.String());
            AlterColumn("dbo.AboutUs", "Photo", c => c.String());
        }
    }
}
