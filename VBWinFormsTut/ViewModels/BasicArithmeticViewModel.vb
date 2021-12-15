Public Class BasicArithmeticViewModel
    Private _ValueOne As Integer
    Private _ValueTwo As Integer
    Private _arithmeticSymVal As Integer
    Private ReadOnly listofops() As String = {"+", "-", "*", "/"}






    ' constructor
    Public Sub New(valOne As Integer, valTwo As Integer, arithmeticSymVal As String)
        _ValueOne = valOne
        _ValueTwo = valTwo
        _arithmeticSymVal = arithmeticSymVal
    End Sub
    Private Function Execute() As Integer
        If _arithmeticSymVal = listofops(0) Then
        ElseIf _arithmeticSymVal = listofops(1) Then

        ElseIf _arithmeticSymVal = listofops(2) Then
        ElseIf _arithmeticSymVal = listofops(3) Then
        ElseIf _arithmeticSymVal = listofops(4) Then

        End If
    End Function


End Class
