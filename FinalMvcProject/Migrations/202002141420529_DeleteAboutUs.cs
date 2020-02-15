namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteAboutUs : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.AboutUs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.AboutUs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(nullable: false, maxLength: 50),
                        Title = c.String(nullable: false, maxLength: 50),
                        Text = c.String(nullable: false, maxLength: 500),
                        Body = c.String(nullable: false, storeType: "ntext"),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
