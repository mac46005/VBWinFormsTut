Imports System.Configuration
Imports System.Data
Imports Dapper

Namespace My.Internal
    Public MustInherit Class DbAccessBase(Of X As IDbConnection)
        Implements IDbAccess(Of X)
        ' Private Members
        Private _connectionString As String
        Private _dbType As X

        ' Constructors
        Public Sub New(connectionName As String, dbType As X)
            _connectionString = GetConnectionString(connectionName)
            _dbType = dbType

            _dbType.ConnectionString = _connectionString
        End Sub

        ' Private Methods
        Private Function GetConnectionString(connectionName As String) As String
            Return ConfigurationManager.ConnectionStrings(connectionName).ConnectionString
        End Function
        ' End Private Methods




        ' Public Methods
        Public Overridable Sub ModifyData(Of T)(storedProcedure As String, obj As T) Implements IDbAccess(Of X).ModifyData
            Using conn As IDbConnection = _dbType
                conn.Query(Of T)(storedProcedure, obj, commandType:=CommandType.StoredProcedure)
            End Using
        End Sub


        Public Overridable Function LoadData(Of T, U)(storedProcedure As String, parameters As U) As List(Of T) Implements IDbAccess(Of X).LoadData
            Using conn As IDbConnection = _dbType
                Return conn.Query(Of T)(storedProcedure, parameters, commandType:=CommandType.StoredProcedure)
            End Using
        End Function
        ' Public Methods




        ' IDisposable
        Public Sub Dispose() Implements IDisposable.Dispose
            _connectionString = Nothing
            _dbType = Nothing
        End Sub
    End Class
End Namespace

