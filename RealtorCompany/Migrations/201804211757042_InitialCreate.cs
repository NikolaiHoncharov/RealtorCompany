namespace RealtorCompany.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Apartments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Area = c.Int(nullable: false),
                        CountRoom = c.Int(nullable: false),
                        Floor = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        ApartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Apartments", t => t.ApartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.ApartmentId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        SecondName = c.String(),
                        Phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        ApartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Apartments", t => t.ApartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.ApartmentId);
            
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Path = c.String(),
                        ApartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Apartments", t => t.ApartmentId, cascadeDelete: true)
                .Index(t => t.ApartmentId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        SecondName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Position = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pictures", "ApartmentId", "dbo.Apartments");
            DropForeignKey("dbo.Purchases", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Purchases", "ApartmentId", "dbo.Apartments");
            DropForeignKey("dbo.Bookings", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Bookings", "ApartmentId", "dbo.Apartments");
            DropIndex("dbo.Pictures", new[] { "ApartmentId" });
            DropIndex("dbo.Purchases", new[] { "ApartmentId" });
            DropIndex("dbo.Purchases", new[] { "ClientId" });
            DropIndex("dbo.Bookings", new[] { "ApartmentId" });
            DropIndex("dbo.Bookings", new[] { "ClientId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Pictures");
            DropTable("dbo.Purchases");
            DropTable("dbo.Clients");
            DropTable("dbo.Bookings");
            DropTable("dbo.Apartments");
        }
    }
}
