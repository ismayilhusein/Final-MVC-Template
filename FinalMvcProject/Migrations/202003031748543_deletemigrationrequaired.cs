namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletemigrationrequaired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerSliders", "Photo", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerSliders", "Photo", c => c.String(maxLength: 50));
        }
    }
}
