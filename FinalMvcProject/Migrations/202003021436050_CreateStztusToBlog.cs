namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateStztusToBlog : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "Status");
        }
    }
}
