Imports System.Data.SqlClient
Public Class FormCanciones
    Dim rutaCancion As String = ""
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MenuAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub btnPath_Click(sender As Object, e As EventArgs) Handles btnPath.Click
        OpenFileDialog1.ShowDialog()
        rutaCancion = OpenFileDialog1.FileName()
        If Not (rutaCancion = "") Then
            lbRuta.Text = rutaCancion
        End If
    End Sub

    Sub ActualizarArtistas()
        listaArtistas.Items.Clear()
        Dim MiCmd As SqlCommand
        Dim MiLector As SqlDataReader

        conexion.Open()

        Try
            MiCmd = conexion.CreateCommand
            Dim consulta As String = "SELECT * FROM artista"
            MiCmd.CommandText = consulta
            MiLector = MiCmd.ExecuteReader()

            Do While MiLector.Read()
                '0-id;  1= nombre;  2= nacionalidad
                Dim nombreArtista As String = MiLector.GetString(1)
                listaArtistas.Items.Add(nombreArtista)
            Loop

        Catch ex As Exception
            MsgBox("Error al consultar artistas")
        End Try

        conexion.Close()
    End Sub

    Sub ActualizarCanciones()
        listaCanciones.Items.Clear()
        Dim MiCmd As SqlCommand
        Dim MiLector As SqlDataReader

        conexion.Open()

        Try
            MiCmd = conexion.CreateCommand
            Dim consulta As String = "SELECT * FROM cancion"
            MiCmd.CommandText = consulta
            MiLector = MiCmd.ExecuteReader()

            Do While MiLector.Read()
                '0-id;  1= nombre;  2=genero; 3=ubicacion; 4=artista
                Dim nombreArtista As String = MiLector.GetString(1)
                listaCanciones.Items.Add(nombreArtista)
            Loop

        Catch ex As Exception
            MsgBox("Error al consultar artistas")
        End Try

        conexion.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim nombreCancion As String = txtNombre.Text
        Dim generoCancion As String = txtGenero.Text
        Dim artistaSeleccionado As String = listaArtistas.SelectedItem().ToString()
        Dim idArtista As String = ObtenerIdArtista(artistaSeleccionado)

        If (nombreCancion = "" Or generoCancion = "" Or rutaCancion = "") Then
            MsgBox("Introduzca todos los campos")
        Else
            'Abrir la conexion
            conexion.Open()

            Try
                Dim consulta As String = "INSERT INTO cancion(nombre,genero,ubicacion,artista_id) VALUES ('" + nombreCancion + "','" + generoCancion + "','" + rutaCancion + "'," + idArtista + ")"
                Dim comando As SqlCommand
                comando = New SqlCommand(consulta, conexion)
                comando.ExecuteNonQuery()
                MessageBox.Show("Los datos de la cancion guardaron correctamente")
            Catch ex As Exception
                MsgBox("Error al ingresar datos a la DB")
            End Try

            'Cerrar la conexion
            conexion.Close()
        End If

        ActualizarCanciones()

    End Sub

    Function ObtenerIdArtista(nombreArtista As String) As String
        Dim resultadoID = ""

        Dim MiCmd As SqlCommand
        Dim MiLector As SqlDataReader
        conexion.Open()

        Try
            MiCmd = conexion.CreateCommand
            Dim consulta As String = "SELECT * FROM artista WHERE nombre='" + nombreArtista + "'"
            MiCmd.CommandText = consulta
            MiLector = MiCmd.ExecuteReader()

            Do While MiLector.Read()
                '0-id;  1= nombre;  2=nacionalidad
                resultadoID = MiLector.GetInt32(0).ToString()
            Loop

        Catch ex As Exception
            MsgBox("Error al consultar artistas")
        End Try

        conexion.Close()

        Return resultadoID
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim nombreCancion As String = listaCanciones.SelectedItem.ToString()

        conexion.Open()
        Try
            Dim consulta As String = "DELETE FROM cancion WHERE nombre='" + nombreCancion + "'"
            Dim comando As SqlCommand
            comando = New SqlCommand(consulta, conexion)
            comando.ExecuteNonQuery()
            MessageBox.Show("Los datos se borraron correctamente")
        Catch ex As Exception
            MsgBox("Error borrar datos de la DB")
        End Try
        conexion.Close()

        'Actualizar la lista
        ActualizarCanciones()
    End Sub
End Class