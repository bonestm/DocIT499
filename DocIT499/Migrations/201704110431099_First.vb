Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class First
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Customers",
                Function(c) New With
                    {
                        .CustomerID = c.Int(nullable := False, identity := True),
                        .Salutation = c.String(),
                        .FirstName = c.String(),
                        .MiddleName = c.String(),
                        .LastName = c.String(),
                        .Suffix = c.String(),
                        .CustomerNotesID = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.CustomerID)
            
            CreateTable(
                "dbo.Addresses",
                Function(c) New With
                    {
                        .AddressID = c.Int(nullable := False, identity := True),
                        .AddressLine1 = c.String(),
                        .AddressLine2 = c.String(),
                        .AddressLine3 = c.String(),
                        .AddressLine4 = c.String(),
                        .City = c.String(),
                        .State = c.String(),
                        .PostalCode = c.String(),
                        .Customer_CustomerID = c.Int()
                    }) _
                .PrimaryKey(Function(t) t.AddressID) _
                .ForeignKey("dbo.Customers", Function(t) t.Customer_CustomerID) _
                .Index(Function(t) t.Customer_CustomerID)
            
            CreateTable(
                "dbo.CustomerNotes",
                Function(c) New With
                    {
                        .CustomerNotesID = c.Int(nullable := False, identity := True),
                        .CustomerID = c.Int(nullable := False),
                        .Content = c.String(),
                        .NoteAuthor = c.String()
                    }) _
                .PrimaryKey(Function(t) t.CustomerNotesID) _
                .ForeignKey("dbo.Customers", Function(t) t.CustomerID, cascadeDelete := True) _
                .Index(Function(t) t.CustomerID)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.CustomerNotes", "CustomerID", "dbo.Customers")
            DropForeignKey("dbo.Addresses", "Customer_CustomerID", "dbo.Customers")
            DropIndex("dbo.CustomerNotes", New String() { "CustomerID" })
            DropIndex("dbo.Addresses", New String() { "Customer_CustomerID" })
            DropTable("dbo.CustomerNotes")
            DropTable("dbo.Addresses")
            DropTable("dbo.Customers")
        End Sub
    End Class
End Namespace
