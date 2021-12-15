Public Class Form1
    Private input As Integer
    Private Sub btnMustSubmitRange_Click(sender As Object, e As EventArgs) Handles btnMustSubmitRange.Click
        Try
            input = CInt(tbxRange.Text)
            btnMustSubmitRange.Enabled = False
            btnSubmit.Enabled = True
        Catch ex As InvalidCastException
            MessageBox.Show("Please input an integer")
        End Try
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class
