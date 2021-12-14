Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim valueOne As Integer = CInt(tbxValue01.Text)
        Dim valueTwo As Integer = CInt(tbxValue02.Text)
        If BasicComparisons.GreaterThan(valueOne, valueTwo) = True Then
            lblAnswer.Text = "True"
        Else
            lblAnswer.Text = "False"
        End If
    End Sub
End Class
