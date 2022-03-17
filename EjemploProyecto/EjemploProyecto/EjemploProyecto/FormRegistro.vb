Imports System.Data.SqlClient
Public Class FormRegistro
    Dim rutaFoto As String = ""

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Visible = True
        Me.Visible = False
    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        Dim nuevoUsr_nombre As String = txtNombre.Text
        Dim nuevoUsr_username As String = txtUsername.Text
        Dim nuevoUsr_pass1 As String = txtPass1.Text
        Dim nuevoUsr_pass2 As String = txtPass2.Text
        If (Not (nuevoUsr_nombre = "") And Not (nuevoUsr_username = "") And Not (nuevoUsr_pass1 = "") And Not (nuevoUsr_pass2 = "")) Then
            If (nuevoUsr_pass1 = nuevoUsr_pass2) Then
                'Validar que contenga 8 caracteres, nuemro, Mayus,simbolo
                If (LongitudPassword(nuevoUsr_pass1) And ContieneNumero(nuevoUsr_pass1)) Then
                    'MsgBox("Password Aceptado")
                    If Not (rutaFoto = "") Then
                        'Aqui en donde se registra el usuario
                        MsgBox("Datos aceptados")
                        Dim nuevoUsr_PassEncrip As String = Encriptar(nuevoUsr_pass1)

                        conexion.Open()
                        Try
                            Dim consulta As String = "INSERT INTO usuario(nombre,username,password,tipo,foto) VALUES ('" + nuevoUsr_nombre + "','" + nuevoUsr_username + "','" + nuevoUsr_PassEncrip + "','Cliente','" + rutaFoto + "')"
                            Dim comando As SqlCommand
                            comando = New SqlCommand(consulta, conexion)
                            comando.ExecuteNonQuery()
                            MessageBox.Show("Los datos se guardaron correctamente")
                        Catch ex As Exception
                            MsgBox("Error al ingresar datos a la DB")
                        End Try
                        conexion.Close()
                    Else
                        MsgBox("Seleccione una foto")
                    End If

                Else
                    MsgBox("Password Rechazada")
                End If
            Else
                MsgBox("Contrasena no coincide")
            End If


        Else
            MsgBox("Ingrese todos los campos")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.ShowDialog()
        rutaFoto = OpenFileDialog1.FileName()
        If Not (rutaFoto = "") Then
            lbRuta.Text = rutaFoto
        End If
    End Sub

    Function LongitudPassword(texto As String) As Boolean
        Dim resultado As Boolean = False
        If (texto.Length >= 8) Then
            resultado = True
        End If
        Return resultado
    End Function

    Function ContieneNumero(texto As String) As Boolean
        Dim resultado As Boolean = False
        If (texto.Contains("0") Or texto.Contains("1") Or texto.Contains("2") Or texto.Contains("3") Or texto.Contains("4") Or texto.Contains("5") Or texto.Contains("6") Or texto.Contains("7") Or texto.Contains("8") Or texto.Contains("9")) Then
            resultado = True
        End If

        Return resultado
    End Function

End Class