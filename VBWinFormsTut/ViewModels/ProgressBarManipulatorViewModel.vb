﻿Imports System.Windows.Forms
Public Class ProgressBarManipulatorViewModel
    ' properties
    Private _increment As Integer
    Public Property Increment() As Integer
        Get
            Return _increment
        End Get
        Set(ByVal value As Integer)
            If value < 0 Then
                Throw New Exception("Enter a number bigger than 0")
            Else
                _increment = value
            End If

        End Set
    End Property

    Private _interval As Integer
    Public Property Interval() As Integer
        Get
            Return _interval
        End Get
        Set(ByVal value As Integer)
            If value < 0 Then
                Throw New Exception("Please select a value bigger than 0!")
            Else
                _interval = value
            End If

        End Set
    End Property


    Private _timer As Timer
    Private _progressBar As ProgressBar


    ' constructor
    Public Sub New()

    End Sub

    Public Sub New(increment As Integer, interval As Integer, timer As Timer)
        Me.Increment = increment
        Me.Interval = interval
        Me._timer = timer
    End Sub
    Public Sub New(ByRef timer As Timer, ByRef progressBar As ProgressBar)
        _timer = timer
        _progressBar = progressBar
    End Sub



    ' public methods
    Public Sub Start()
        _timer.Start()
    End Sub

    Public Sub Pause()
        _timer.Stop()
    End Sub

    Public Sub clear()
        _timer.Stop()
        _progressBar.Value = 0
    End Sub


    Public Sub Tick()
        _timer.Interval = (Interval)
        _progressBar.Increment(Increment)
    End Sub
End Class
