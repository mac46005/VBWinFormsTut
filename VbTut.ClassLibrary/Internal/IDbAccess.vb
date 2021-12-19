Imports System.Data

Namespace My.Internal
    Public Interface IDbAccess(Of X As IDbConnection)
        Inherits IDisposable

        Sub ModifyData(Of T)(storedProcedure As String, obj As T)
        Function LoadData(Of T, U)(storedProcedure As String, parameters As U) As List(Of T)
    End Interface
End Namespace
