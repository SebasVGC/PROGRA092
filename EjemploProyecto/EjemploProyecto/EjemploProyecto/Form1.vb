Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        FormPassword.Visible = True
        Me.Visible = False
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        FormRegistro.Visible = True
        Me.Visible = False
    End Sub
End Class
