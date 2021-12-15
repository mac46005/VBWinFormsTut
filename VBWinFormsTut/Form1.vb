Imports VbTut.ClassLibrary

Public Class Form1
    Private _range As Integer
    Private Sub btnMustSubmitRange_Click(sender As Object, e As EventArgs) Handles btnMustSubmitRange.Click
        Try
            _range = CInt(tbxRange.Text)
            btnMustSubmitRange.Enabled = False
            btnSubmit.Enabled = True
        Catch ex As InvalidCastException
            MessageBox.Show("Please input an integer")
            tbxRange.Text = String.Empty
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim input As Integer = CInt(tbxGuess.Text)
            Dim guessNumGame As New GuessTheNumber(_range, input)
            Dim result As Integer = guessNumGame.Execute()
            lblMyInput.Text = tbxGuess.Text
            lblResult.Text = result.ToString()
            DisplayIfWon(guessNumGame)
        Catch ex As InvalidCastException
            MessageBox.Show("Please input an integer only!")
            tbxGuess.Text = String.Empty
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            tbxGuess.Text = String.Empty
        End Try
    End Sub
    Private Sub DisplayIfWon(gm As GuessTheNumber)
        If gm.CheckForWin() Then
            MessageBox.Show("You guessed the right number! Congratulations!!!")
            Reset()
        Else
            MessageBox.Show($"You guess the wrong number! Congratulations!!!")
            Reset()
        End If
    End Sub

    Private Sub Reset()
        tbxRange.Text = String.Empty
        tbxGuess.Text = String.Empty
        tbxRange.Enabled = True
        tbxGuess.Enabled = False
    End Sub
End Class
