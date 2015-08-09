namespace QDAR.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        Comment = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DailyProgresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Task = c.String(),
                        WorkAssigned = c.String(),
                        WorkAssignedStatusId = c.Int(nullable: false),
                        Conceptually = c.String(),
                        ConceptuallyStatusId = c.Int(nullable: false),
                        Technically = c.String(),
                        TechnicallyStatusId = c.Int(nullable: false),
                        Achievements = c.String(),
                        CollabarationWorkEnvironment = c.String(),
                        CollabarationWorkEnvironmentId = c.Int(nullable: false),
                        StandardsOfCoding = c.String(),
                        StandardsOfCodingStatusId = c.Int(nullable: false),
                        WorkFlow = c.String(),
                        ProjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        NewsContent = c.String(),
                        Date = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                        DeletedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        NotificationContext = c.String(),
                        Date = c.DateTime(nullable: false),
                        DeletedBy = c.String(),
                        UpdatedBy = c.String(),
                        CreatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        PhoneNumber = c.String(),
                        UserName = c.String(),
                        SkypeAccount = c.String(),
                        DOB = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DailyProgresses", "ProjectId", "dbo.Projects");
            DropIndex("dbo.DailyProgresses", new[] { "ProjectId" });
            DropTable("dbo.Users");
            DropTable("dbo.UserRoles");
            DropTable("dbo.Status");
            DropTable("dbo.Roles");
            DropTable("dbo.Notifications");
            DropTable("dbo.News");
            DropTable("dbo.Projects");
            DropTable("dbo.DailyProgresses");
            DropTable("dbo.Comments");
        }
    }
}
