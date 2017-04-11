Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class _201704110239110_InitialCreate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Customers", "CustomerNotesID", Function(c) c.Int(nullable := False))
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Customers", "CustomerNotesID")
        End Sub
    End Class
End Namespace
