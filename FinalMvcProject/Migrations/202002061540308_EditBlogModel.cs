namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditBlogModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "UpdateYear", c => c.String());
            AddColumn("dbo.Blogs", "UpdateMounth", c => c.String());
            AddColumn("dbo.Blogs", "UpdateDay", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "UpdateDay");
            DropColumn("dbo.Blogs", "UpdateMounth");
            DropColumn("dbo.Blogs", "UpdateYear");
        }
    }
}
