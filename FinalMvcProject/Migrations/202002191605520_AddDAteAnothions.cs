namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDAteAnothions : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Doctors", "CreateDate", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Doctors", "EndedDate", c => c.DateTime(storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Doctors", "EndedDate", c => c.DateTime());
            AlterColumn("dbo.Doctors", "CreateDate", c => c.DateTime(nullable: false));
        }
    }
}
