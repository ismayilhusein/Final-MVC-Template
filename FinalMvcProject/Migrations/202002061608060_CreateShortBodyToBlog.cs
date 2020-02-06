namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateShortBodyToBlog : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "ShortBody", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "ShortBody");
        }
    }
}
