namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteIconToService : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Services", "Icon");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Services", "Icon", c => c.String());
        }
    }
}
