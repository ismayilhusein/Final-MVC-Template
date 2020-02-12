namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testing : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BookAppoitments", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.BookAppoitments", "Number", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.BookAppoitments", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.BookAppoitments", "Date", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.BookAppoitments", "Note", c => c.String(nullable: false, storeType: "ntext"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BookAppoitments", "Note", c => c.String());
            AlterColumn("dbo.BookAppoitments", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.BookAppoitments", "Email", c => c.String());
            AlterColumn("dbo.BookAppoitments", "Number", c => c.String());
            AlterColumn("dbo.BookAppoitments", "Name", c => c.String());
        }
    }
}
