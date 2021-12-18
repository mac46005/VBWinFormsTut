Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Dapper
Public Class DbAccess : Implements IDisposable

    Private Function GetConnectionString(connectionName As String) As String
        Return ConfigurationManager.ConnectionStrings(connectionName).ConnectionString
    End Function
    ' Need to rewrite this method and name it something other than SaveData
    Public Sub SaveData(Of T)(connectionName As String, storedProcedure As String, obj As T)
        Dim connectionString As String = GetConnectionString(connectionName)

        Using conn As New SqlConnection(connectionString)
            Dim connection As IDbConnection = conn
            conn.Query(storedProcedure, obj, commandType:=CommandType.StoredProcedure)
        End Using

    End Sub
    ' Need to rewrite this method as well
    Public Function LoadData(Of T, U)(connectionName As String, storedProcedure As String, parameters As U) As List(Of T)
        Dim connectionString As String = GetConnectionString(connectionName)
        Using conn As New SqlConnection(connectionString)
            Dim connection As IDbConnection = conn
            Return connection.Query(Of T)(storedProcedure, parameters, commandType:=CommandType.StoredProcedure).AsList()
        End Using
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        Throw New NotImplementedException()
    End Sub
End Class
