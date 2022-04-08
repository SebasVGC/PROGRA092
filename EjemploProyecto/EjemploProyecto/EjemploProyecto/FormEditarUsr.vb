Imports System.Data.SqlClient
Public Class FormEditarUsr
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormInicio.Show()
        Me.Hide()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim nuevoNombre As String = TextBox1.Text
        Dim nuevaPass1 As String = TextBox2.Text
        Dim nuevaPass2 As String = TextBox3.Text

        If ((nuevoNombre = "") Or (nuevaPass1 = "") Or (nuevaPass2 = "")) Then
            'Aqui ambos estas vacios
            MsgBox("Ingrese todos los campos")
        Else
            'Aqui si tenemos todos los datos
            If (nuevaPass1 = nuevaPass2) Then
                If (LongitudPassword(nuevaPass1) And ContieneNumero(nuevaPass1)) Then
                    'Aqui las contraseñas son iguales y cumplen las condiciones

                    Dim nuevoUsr_PassEncrip As String = Encriptar(nuevaPass1)
                    conexion.Open()
                    Try
                        Dim consulta As String = "
                        UPDATE usuario 
	                        SET nombre='" + nuevoNombre + "', password='" + nuevoUsr_PassEncrip + "'
	                        WHERE username='" + usr_username + "';
                        "
                        Dim comando As SqlCommand
                        comando = New SqlCommand(consulta, conexion)
                        comando.ExecuteNonQuery()
                        MessageBox.Show("Los datos se actualizaron correctamente")
                    Catch ex As Exception
                        MsgBox("Error al ingresar datos a la DB")
                    End Try
                    conexion.Close()
                Else
                    MsgBox("Contraseña rechazada")
                End If
            Else
                MsgBox("Las contraseñas no coinciden")
            End If

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