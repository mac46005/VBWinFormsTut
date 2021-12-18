Public Class ProgressBarManipulatorViewModel
    Private _progressBar As ProgressBar
    Private _timer As Timer
    Private _interval As Integer
    Private _increment As Integer

    Public Property Increment() As Integer
        Get
            Return _increment
        End Get
        Set(value As Integer)
            _increment = value
        End Set
    End Property

    Public Property Interval() As Integer
        Get
            Return _interval
        End Get
        Set(value As Integer)
            _interval = value
        End Set
    End Property





    ' constructor
    Public Sub New(ByRef progressBar As ProgressBar, ByRef timer As Timer)
        _progressBar = progressBar
        _timer = timer
    End Sub



    Public Sub Start()
        _timer.Start()
    End Sub


    Public Sub [Stop]()
        _timer.Stop()
    End Sub

    Public Sub Clear()
        _timer.Stop()
        _progressBar.Value = 0
    End Sub
End Class
