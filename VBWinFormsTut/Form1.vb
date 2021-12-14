Public Class Form1


    Dim Message As String = "This is a message string."
    Dim integerValue As Integer = Message.Length

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show($"{Message}\n There are {integerValue} characters in the message string.")
    End Sub
End Class
