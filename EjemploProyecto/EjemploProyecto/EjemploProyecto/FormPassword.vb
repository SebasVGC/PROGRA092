Public Class FormPassword
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        FormInicio.Visible = True
        Me.Visible = False
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Visible = True
        Me.Visible = False
    End Sub
End Class