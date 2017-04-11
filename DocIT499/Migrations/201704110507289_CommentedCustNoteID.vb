Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class CommentedCustNoteID
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropColumn("dbo.Customers", "CustomerNotesID")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Customers", "CustomerNotesID", Function(c) c.Int(nullable := False))
        End Sub
    End Class
End Namespace
