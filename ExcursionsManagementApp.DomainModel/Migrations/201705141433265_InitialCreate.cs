namespace ExcursionsManagementApp.DomainModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        Schedule_ScheduleEntryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID)
                .ForeignKey("dbo.Schedule", t => t.Schedule_ScheduleEntryID, cascadeDelete: true)
                .Index(t => t.Schedule_ScheduleEntryID);
            
            CreateTable(
                "dbo.Schedule",
                c => new
                    {
                        ScheduleEntryID = c.Int(nullable: false, identity: true),
                        TourName = c.String(nullable: false, maxLength: 50),
                        StartTime = c.DateTime(nullable: false),
                        TourID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ScheduleEntryID)
                .ForeignKey("dbo.Tours", t => t.TourID, cascadeDelete: true)
                .Index(t => t.TourID);
            
            CreateTable(
                "dbo.Tours",
                c => new
                    {
                        TourID = c.Int(nullable: false, identity: true),
                        TourName = c.String(nullable: false, maxLength: 50),
                        Price = c.Decimal(storeType: "money"),
                        GuideID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TourID)
                .ForeignKey("dbo.Guides", t => t.GuideID, cascadeDelete: true)
                .Index(t => t.GuideID);
            
            CreateTable(
                "dbo.Guides",
                c => new
                    {
                        GuideID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.GuideID);
            
            CreateTable(
                "dbo.Places",
                c => new
                    {
                        PlaceID = c.Int(nullable: false, identity: true),
                        PlaceName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.PlaceID);
            
            CreateTable(
                "dbo.PlaceTours",
                c => new
                    {
                        Place_PlaceID = c.Int(nullable: false),
                        Tour_TourID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Place_PlaceID, t.Tour_TourID })
                .ForeignKey("dbo.Places", t => t.Place_PlaceID, cascadeDelete: true)
                .ForeignKey("dbo.Tours", t => t.Tour_TourID, cascadeDelete: true)
                .Index(t => t.Place_PlaceID)
                .Index(t => t.Tour_TourID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "Schedule_ScheduleEntryID", "dbo.Schedule");
            DropForeignKey("dbo.Schedule", "TourID", "dbo.Tours");
            DropForeignKey("dbo.PlaceTours", "Tour_TourID", "dbo.Tours");
            DropForeignKey("dbo.PlaceTours", "Place_PlaceID", "dbo.Places");
            DropForeignKey("dbo.Tours", "GuideID", "dbo.Guides");
            DropIndex("dbo.Customers", new[] { "Schedule_ScheduleEntryID" });
            DropIndex("dbo.Schedule", new[] { "TourID" });
            DropIndex("dbo.PlaceTours", new[] { "Tour_TourID" });
            DropIndex("dbo.PlaceTours", new[] { "Place_PlaceID" });
            DropIndex("dbo.Tours", new[] { "GuideID" });
            DropTable("dbo.PlaceTours");
            DropTable("dbo.Places");
            DropTable("dbo.Guides");
            DropTable("dbo.Tours");
            DropTable("dbo.Schedule");
            DropTable("dbo.Customers");
        }
    }
}
