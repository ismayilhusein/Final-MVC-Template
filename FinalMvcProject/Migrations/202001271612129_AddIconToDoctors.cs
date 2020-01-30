namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIconToDoctors : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doctors", "Icon", c => c.String());
            AddColumn("dbo.Doctors", "Body", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Doctors", "Body");
            DropColumn("dbo.Doctors", "Icon");
        }
    }
}
