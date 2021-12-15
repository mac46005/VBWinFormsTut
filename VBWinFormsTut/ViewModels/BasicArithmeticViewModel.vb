Imports VbTut.ClassLibrary

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
            Return IntArithmetic.Addition(_ValueOne, _ValueTwo)
        ElseIf _arithmeticSymVal = listofops(1) Then
            Return IntArithmetic.Subtraction(_ValueOne, _ValueTwo)
        ElseIf _arithmeticSymVal = listofops(2) Then
            Return IntArithmetic.Multiplication(_ValueOne, _ValueTwo)
        ElseIf _arithmeticSymVal = listofops(3) Then
            Return IntArithmetic.Division(_ValueOne, _ValueTwo)
        ElseIf _arithmeticSymVal = listofops(4) Then

        End If
    End Function


End Class
