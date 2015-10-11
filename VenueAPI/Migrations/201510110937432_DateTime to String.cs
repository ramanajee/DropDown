namespace VenueAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateTimetoString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "StartTime", c => c.String());
            AlterColumn("dbo.Venues", "Date", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Venues", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Events", "StartTime", c => c.DateTime(nullable: false));
        }
    }
}
