namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteIconToDoctors : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Doctors", "Icon");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Doctors", "Icon", c => c.String());
        }
    }
}
