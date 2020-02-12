namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDb : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerSliders", "Text", c => c.String(nullable: false, storeType: "ntext"));
            AlterColumn("dbo.Departments", "Title", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Departments", "Icon", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Departments", "Desc", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Departments", "Content", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Departments", "Body", c => c.String(nullable: false, storeType: "ntext"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Departments", "Body", c => c.String());
            AlterColumn("dbo.Departments", "Content", c => c.String());
            AlterColumn("dbo.Departments", "Desc", c => c.String());
            AlterColumn("dbo.Departments", "Icon", c => c.String());
            AlterColumn("dbo.Departments", "Title", c => c.String());
            AlterColumn("dbo.CustomerSliders", "Text", c => c.String(nullable: false, maxLength: 500));
        }
    }
}
