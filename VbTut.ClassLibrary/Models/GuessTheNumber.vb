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
    Private _isWinner As Boolean

    Public Property IsWinner() As Boolean
        Private Set(value As Boolean)
            _isWinner = value
        End Set
        Get
            Return _isWinner
        End Get
    End Property

    Private _answer As Integer
    Public Property Answer() As Integer
        Get
            Return _answer
        End Get
        Private Set(ByVal value As Integer)
            _answer = value
        End Set
    End Property
    ' constructor
    Public Sub New(range As Integer, input As Integer)
        GuessRange = range
        GuessInput = input
        Dim random As New Random()
        Answer = random.Next(GuessRange)

    End Sub

    Public Function Execute() As Integer
        Dim basicIniq As New BasicIntInequality()

        If basicIniq.GreaterThan(GuessInput, GuessRange) = True Then
            Throw New Exception("Input was out of range!" + ControlChars.Lf + "Input value within range specified by you the client :)")
        End If
        CheckForWin()
        Return Answer
    End Function

    Public Function CheckForWin() As Boolean
        Dim basicInequal As New BasicIntInequality()
        Return basicInequal.EqualToo(_guessInput, Answer)
    End Function

End Class
