Public Class MenuAdmin
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        usr_id = ""
        usr_nombre = ""
        usr_username = ""
        usr_password = ""
        usr_tipo = ""
        usr_foto = ""


        Form1.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormDeleteUser.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormCanciones.Show()
        Me.Hide()
    End Sub
End Class