namespace DariaHornikLab4Zadanie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Bookstore : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id_Address = c.Int(nullable: false),
                        street = c.String(nullable: false, maxLength: 30),
                        ZipCode = c.Int(nullable: false),
                        city = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id_Address)
                .ForeignKey("dbo.Clients", t => t.Id_Address)
                .Index(t => t.Id_Address);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id_Client = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 30),
                        surname = c.String(nullable: false, maxLength: 30),
                        birthData = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Client);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id_Book = c.Int(nullable: false, identity: true),
                        title = c.String(nullable: false, maxLength: 30),
                        author = c.String(nullable: false, maxLength: 30),
                        releaseData = c.DateTime(nullable: false),
                        language = c.String(nullable: false),
                        Client_Id_Client = c.Int(),
                    })
                .PrimaryKey(t => t.Id_Book)
                .ForeignKey("dbo.Clients", t => t.Client_Id_Client)
                .Index(t => t.Client_Id_Client);
            
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        Id_Ware = c.Int(nullable: false),
                        numberOfItems = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_Ware)
                .ForeignKey("dbo.Books", t => t.Id_Ware)
                .Index(t => t.Id_Ware);
            
            CreateTable(
                "dbo.Bookstores",
                c => new
                    {
                        Id_Bookstore = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 50),
                        address = c.String(nullable: false, maxLength: 50),
                        owner = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id_Bookstore);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "Id_Address", "dbo.Clients");
            DropForeignKey("dbo.Books", "Client_Id_Client", "dbo.Clients");
            DropForeignKey("dbo.Warehouses", "Id_Ware", "dbo.Books");
            DropIndex("dbo.Warehouses", new[] { "Id_Ware" });
            DropIndex("dbo.Books", new[] { "Client_Id_Client" });
            DropIndex("dbo.Addresses", new[] { "Id_Address" });
            DropTable("dbo.Bookstores");
            DropTable("dbo.Warehouses");
            DropTable("dbo.Books");
            DropTable("dbo.Clients");
            DropTable("dbo.Addresses");
        }
    }
}
