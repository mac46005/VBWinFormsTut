Public Class Form1
    Dim _bArithVM As BasicArithmeticViewModel

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxInequalityOperators.Items().AddRange(BasicArithmeticViewModel.listofops)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        _bArithVM = New BasicArithmeticViewModel(CInt(tbxValueOne.Text), CInt(tbxValueTwo.Text), cbxInequalityOperators.SelectedItem)
        Dim result As Integer = _bArithVM.Execute()
        lblResult.Text = result.ToString()
    End Sub
End Class
