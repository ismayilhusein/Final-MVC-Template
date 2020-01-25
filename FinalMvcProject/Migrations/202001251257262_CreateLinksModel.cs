namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateLinksModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SocialLinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Icon = c.String(nullable: false, maxLength: 50),
                        Url = c.String(nullable: false, maxLength: 200),
                        OrderBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.HeaderSliders", "BtnText", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.HeaderSliders", "BtnUrl", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.CustomerSliders", "Photo", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.CustomerSliders", "FullName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.CustomerSliders", "WhatProblems", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.CustomerSliders", "Text", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.HeaderSliders", "Title", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.HeaderSliders", "Body", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Settings", "HeaderLogo", c => c.String(maxLength: 50));
            AlterColumn("dbo.Settings", "FooterLogo", c => c.String(maxLength: 50));
            AlterColumn("dbo.Settings", "Text", c => c.String(maxLength: 500));
            AlterColumn("dbo.Settings", "Location", c => c.String(maxLength: 100));
            AlterColumn("dbo.Settings", "Number", c => c.String(maxLength: 50));
            AlterColumn("dbo.Settings", "Email", c => c.String(maxLength: 50));
            DropColumn("dbo.HeaderSliders", "Excerpt");
            DropColumn("dbo.Settings", "Icon");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Settings", "Icon", c => c.String());
            AddColumn("dbo.HeaderSliders", "Excerpt", c => c.String());
            AlterColumn("dbo.Settings", "Email", c => c.String());
            AlterColumn("dbo.Settings", "Number", c => c.String());
            AlterColumn("dbo.Settings", "Location", c => c.String());
            AlterColumn("dbo.Settings", "Text", c => c.String());
            AlterColumn("dbo.Settings", "FooterLogo", c => c.String());
            AlterColumn("dbo.Settings", "HeaderLogo", c => c.String());
            AlterColumn("dbo.HeaderSliders", "Body", c => c.String());
            AlterColumn("dbo.HeaderSliders", "Title", c => c.String());
            AlterColumn("dbo.CustomerSliders", "Text", c => c.String());
            AlterColumn("dbo.CustomerSliders", "WhatProblems", c => c.String());
            AlterColumn("dbo.CustomerSliders", "FullName", c => c.String());
            AlterColumn("dbo.CustomerSliders", "Photo", c => c.String());
            DropColumn("dbo.HeaderSliders", "BtnUrl");
            DropColumn("dbo.HeaderSliders", "BtnText");
            DropTable("dbo.SocialLinks");
        }
    }
}
