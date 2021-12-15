﻿Imports VbTut.ClassLibrary

Public Class Form1
    Dim barManipulator As ProgressBarManipulatorViewModel

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        barManipulator = New ProgressBarManipulatorViewModel(ProgressBarTimer, ProgressBar1)
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        barManipulator.Start()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        barManipulator.Pause()
    End Sub

    Private Sub btnStopTimer_Click(sender As Object, e As EventArgs) Handles btnStopTimer.Click
        barManipulator.clear()
    End Sub
End Class
