namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteLatestPost : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.LatestPosts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.LatestPosts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                        Title = c.String(),
                        Date = c.DateTime(nullable: false),
                        Role = c.String(),
                        Text = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
