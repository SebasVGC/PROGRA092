Imports System.Data.SqlClient
Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim MiCmd As SqlCommand
        Dim MiLector As SqlDataReader
        Dim nombreUsuario As String = txtUsername.Text

        Try
            MiCmd = conexion.CreateCommand
            Dim consulta As String = "SELECT * FROM usuario WHERE username= '" + nombreUsuario + "'"
            MiCmd.CommandText = consulta

            conexion.Open()
            MiLector = MiCmd.ExecuteReader()

            Do While MiLector.Read()
                '0-id;  1= nombre;  2= username;  3=password; 4=tipo; 5=foto
                usr_id = MiLector.GetInt32(0).ToString()
                usr_nombre = MiLector.GetString(1)
                usr_username = MiLector.GetString(2)
                usr_password = MiLector.GetString(3)
                usr_tipo = MiLector.GetString(4)
                usr_foto = MiLector.GetString(5)
            Loop

            If Not (usr_username = "") Then
                FormPassword.PictureBox1.Image = Image.FromFile(usr_foto)
                FormPassword.lbUsername.Text = usr_username
                FormPassword.Visible = True
                Me.Visible = False
            Else
                MsgBox("Usuario no encontrado")
            End If

            conexion.Close()

        Catch ex As Exception

        End Try

        'FormPassword.Visible = True
        'Me.Visible = False
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        FormRegistro.Visible = True
        Me.Visible = False
    End Sub

    Private Sub btnConect_Click(sender As Object, e As EventArgs) Handles btnConect.Click
        Try
            'Codigo que queremos ejecutar
            conexion.Open()
            MsgBox("Conexion con la BD exitosa")
            btnLogin.Enabled = True
            btnRegister.Enabled = True
            Label2.Text = "Conectado"
            conexion.Close()
        Catch ex As Exception
            'Codigo que se ejecuta si falla
            MsgBox("Error al conectar con la BD")
        End Try
    End Sub
End Class
