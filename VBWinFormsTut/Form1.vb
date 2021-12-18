Imports VbTut.ClassLibrary

Public Class Form1
    Private _pbMinuplator As ProgressBarManipulatorViewModel
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ProgressBarTimer.Start()
        btnStart.Enabled = False
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        ProgressBarTimer.Stop()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ProgressBar1.Value = 0
        btnStart.Enabled = True
        btnStop.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _pbMinuplator = New ProgressBarManipulatorViewModel(ProgressBar1, ProgressBarTimer)
    End Sub

    Private Sub ProgressBarTimer_Tick(sender As Object, e As EventArgs) Handles ProgressBarTimer.Tick
        ProgressBar1.Increment(tbxInrement.Text)
        ProgressBarTimer.Interval = tbxInterval.Text
    End Sub
End Class
