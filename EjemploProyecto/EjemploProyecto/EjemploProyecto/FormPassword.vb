Public Class FormPassword
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim passwordIngresada = txtPass.Text
        Dim passEncriptada = Encriptar(passwordIngresada)
        'abcd12334
        If (passEncriptada = usr_password) Then
            MsgBox("Login exitoso")
            If (usr_tipo = "Administrador") Then
                MenuAdmin.Visible = True
                Me.Visible = False
            Else
                FormInicio.lbNombre.Text = usr_nombre
                FormInicio.Visible = True
                Me.Visible = False
            End If

        Else
            MsgBox("Contrasena incorrecta")
        End If

        'FormInicio.Visible = True
        'Me.Visible = False
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        usr_id = ""
        usr_nombre = ""
        usr_username = ""
        usr_password = ""
        usr_tipo = ""
        usr_foto = ""

        Form1.Visible = True
        Me.Visible = False
    End Sub
End Class