Imports VbTut.ClassLibrary
Public Class BasicIntInequality
    Implements IBasicInequalities(Of Integer)

    Public Function GreaterThan(x As Integer, y As Integer) As Integer Implements IBasicInequalities(Of Integer).GreaterThan
        If x > y Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function GreaterThanEqualToo(x As Integer, y As Integer) As Integer Implements IBasicInequalities(Of Integer).GreaterThanEqualToo
        If x >= y Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function LessThan(x As Integer, y As Integer) As Integer Implements IBasicInequalities(Of Integer).LessThan
        If x < y Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function LessThanEqualToo(x As Integer, y As Integer) As Integer Implements IBasicInequalities(Of Integer).LessThanEqualToo
        If x <= y Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function EqualToo(x As Integer, y As Integer) As Integer Implements IBasicInequalities(Of Integer).EqualToo
        If x = y Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function NotEqualToo(x As Integer, y As Integer) As Integer Implements IBasicInequalities(Of Integer).NotEqualToo
        If Not (x.Equals(y)) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
