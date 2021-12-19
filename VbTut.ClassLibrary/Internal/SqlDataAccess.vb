Imports System.Data
Imports System.Data.SqlClient

Namespace My.Internal
    Public Class SqlDataAccess
        Inherits DbAccessBase(Of SqlConnection)

        Public Sub New(connectionName As String, dbType As SqlConnection)
            MyBase.New(connectionName, dbType)
        End Sub








    End Class
End Namespace

