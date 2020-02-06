namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationToBlog : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Blogs", "AuthorId");
            AddForeignKey("dbo.Blogs", "AuthorId", "dbo.Authors", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blogs", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Blogs", new[] { "AuthorId" });
        }
    }
}
