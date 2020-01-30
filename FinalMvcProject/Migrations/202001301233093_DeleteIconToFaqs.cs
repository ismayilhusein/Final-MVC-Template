namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteIconToFaqs : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Faqs", "Icon");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Faqs", "Icon", c => c.String());
        }
    }
}
