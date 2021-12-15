Public Class GuessTheNumber
    Private _guessRange As Integer
    Public Property GuessRange() As Integer
        Get
            Return _guessRange
        End Get
        Set(ByVal value As Integer)
            _guessRange = value
        End Set
    End Property
    Private _guessInput As Integer
    Public Property GuessInput() As Integer
        Get
            Return _guessInput
        End Get
        Set(ByVal value As Integer)
            _guessInput = value
        End Set
    End Property

    Private answer As Integer

    ' constructor
    Public Sub New(range As Integer, input As Integer)
        GuessRange = range
        GuessInput = input
        Dim random As New Random()
        answer = random.Next(GuessRange)

    End Sub

    Public Function Result() As Integer
        Dim intResult As Integer = 0
        Return intResult
    End Function

End Class
