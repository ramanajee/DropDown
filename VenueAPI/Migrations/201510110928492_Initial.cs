namespace VenueAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StartTime = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Events_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.Events_Id)
                .Index(t => t.Events_Id);
            
            CreateTable(
                "dbo.Speakers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Company = c.String(),
                        Descrption = c.String(),
                        Photo = c.String(),
                        Events_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.Events_Id)
                .Index(t => t.Events_Id);
            
            CreateTable(
                "dbo.Venues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Street = c.String(),
                        Date = c.DateTime(nullable: false),
                        Events_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.Events_Id)
                .Index(t => t.Events_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Venues", "Events_Id", "dbo.Events");
            DropForeignKey("dbo.Speakers", "Events_Id", "dbo.Events");
            DropForeignKey("dbo.Sessions", "Events_Id", "dbo.Events");
            DropIndex("dbo.Venues", new[] { "Events_Id" });
            DropIndex("dbo.Speakers", new[] { "Events_Id" });
            DropIndex("dbo.Sessions", new[] { "Events_Id" });
            DropTable("dbo.Venues");
            DropTable("dbo.Speakers");
            DropTable("dbo.Sessions");
            DropTable("dbo.Events");
        }
    }
}
