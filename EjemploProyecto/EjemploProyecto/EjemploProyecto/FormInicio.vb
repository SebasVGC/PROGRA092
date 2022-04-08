Public Class FormInicio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        usr_id = ""
        usr_nombre = ""
        usr_username = ""
        usr_password = ""
        usr_tipo = ""
        usr_foto = ""


        Form1.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormMisPlaylist.ActualizarPlaylists()
        FormMisPlaylist.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormCrearPlaylist.ActualizarCanciones()
        FormCrearPlaylist.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormEditarUsr.Show()
        Me.Hide()
    End Sub
End Class