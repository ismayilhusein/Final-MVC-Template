namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletePostModel : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Posts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Desc = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
