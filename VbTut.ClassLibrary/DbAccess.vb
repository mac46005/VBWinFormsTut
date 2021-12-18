Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Dapper
Public Class DbAccess : Implements IDisposable

    Private Function GetConnectionString(connectionName As String) As String
        Return ConfigurationManager.ConnectionStrings(connectionName).ConnectionString
    End Function

    Public Sub Save(Of T)(connectionName As String, storedProcedure As String)
        Dim connectionString As String = GetConnectionString(connectionName)

        Using conn As New SqlConnection(connectionString)

        End Using
    End Sub

    Public Function LoadData(Of T, U)(connectionName As String, storedProcedure As String, parameters As U) As List(Of T)

    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        Throw New NotImplementedException()
    End Sub
End Class
