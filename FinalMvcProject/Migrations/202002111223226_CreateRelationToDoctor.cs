namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationToDoctor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DoctorLinks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Icon = c.String(nullable: false, maxLength: 50),
                        Url = c.String(nullable: false, maxLength: 200),
                        OrderBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DoctorLinks");
        }
    }
}
