Public Interface IDataAccess
    Sub Save(Of T)(storedProcedure As String, obj As T)
    Function Load(Of T, U)(storedProcedure As String, parameters As U) As List(Of T)

End Interface
