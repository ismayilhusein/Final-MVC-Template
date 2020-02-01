namespace FinalMvcProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteTestimonialsModel : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Testimoials");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Testimoials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                        FullName = c.String(),
                        WhatProblems = c.String(),
                        Body = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
