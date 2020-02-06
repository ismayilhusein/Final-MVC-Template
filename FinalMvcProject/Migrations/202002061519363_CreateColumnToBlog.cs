namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateColumnToBlog : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "imagePng", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "imagePng");
        }
    }
}
