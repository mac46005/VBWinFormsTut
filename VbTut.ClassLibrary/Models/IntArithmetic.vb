''' <summary>
''' Basic integer data type arithmetic
''' </summary>
Public Class IntArithmetic

    ''' <summary>
    ''' Add two int values
    ''' </summary>
    ''' <param name="x">first value</param>
    ''' <param name="y">second value</param>
    ''' <returns></returns>
    Public Shared Function Addition(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x + y
    End Function

    ''' <summary>
    ''' Subtract two int types
    ''' </summary>
    ''' <param name="x">first value</param>
    ''' <param name="y">second value</param>
    ''' <returns></returns>
    Public Shared Function Subtraction(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x - y
    End Function


    ''' <summary>
    ''' Multiply two integer types
    ''' </summary>
    ''' <param name="x">first value</param>
    ''' <param name="y">second value</param>
    ''' <returns></returns>
    Public Shared Function Multiplication(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x * y
    End Function

    ''' <summary>
    ''' Divide two integer numbers
    ''' </summary>
    ''' <param name="x">first value</param>
    ''' <param name="y">second value</param>
    ''' <returns></returns>
    Public Shared Function Division(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x / y
    End Function

    ''' <summary>
    ''' returns remainder of two integer types
    ''' </summary>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    ''' <returns></returns>
    Public Shared Function Modulus(x As Integer, y As Integer)
        Return x Mod y
    End Function
End Class
