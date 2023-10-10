Public Class Exercise1
    Private Sub Exercise1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl.Text = "This is just a label that is loaded in Exercise1_Load."
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        lbl.Text = inputTxt.Text

    End Sub
End Class
