﻿Imports System.Data.SqlClient
Public Class FormCrearPlaylist

    Dim playlist_foto As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormInicio.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Mover las canciones al lado derecho
        Try
            Dim cancionSeleccionada As String = listaCancion1.SelectedItem().ToString()
            listaCancion2.Items.Add(cancionSeleccionada)
        Catch ex As Exception
            MsgBox("Error al agregar cancion")
        End Try

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim playlist_nombre As String = txtNombre.Text
        If (playlist_foto = "" Or playlist_nombre = "") Then
            MsgBox("Introduzca todos los campos")
        Else
            'Abrir la conexion
            conexion.Open()

            '---CREAR LA PLAYLIST
            Try
                Dim consulta As String = "INSERT INTO playlist(nombre,fechacreacion,foto,usuario_id) VALUES ('" + playlist_nombre + "',GETDATE(),'" + playlist_foto + "'," + usr_id + ")"
                Dim comando As SqlCommand
                comando = New SqlCommand(consulta, conexion)
                comando.ExecuteNonQuery()
                MessageBox.Show("Los datos de la playlist guardaron correctamente")
            Catch ex As Exception
                MsgBox("Error al ingresar datos a la DB")
            End Try
            conexion.Close()


            '---DETALLE DE PLAYLIST (LISTADO)
            Dim idPlaylist As String = ObtenerIdPlaylist(playlist_nombre)

            For Each cancionActual As String In listaCancion2.Items
                Dim idCancion As String = ObtenerIdCancion(cancionActual)
                conexion.Open()
                Try
                    Dim consulta As String = "INSERT INTO detalle_playlist(playlist_id,cancion_id) VALUES (" + idPlaylist + "," + idCancion + ")"
                    Dim comando As SqlCommand
                    comando = New SqlCommand(consulta, conexion)
                    comando.ExecuteNonQuery()
                    Console.WriteLine("Los datos del detalle se insertaron")
                Catch ex As Exception
                    MsgBox("Error al ingresar datos a la DB")
                End Try
                conexion.Close()
            Next

            'Cerrar la conexion

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
        playlist_foto = OpenFileDialog1.FileName()
        If Not (playlist_foto = "") Then
            lbRuta.Text = playlist_foto
        End If
    End Sub

    Sub ActualizarCanciones()
        listaCancion1.Items.Clear()
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
                listaCancion1.Items.Add(nombreArtista)
            Loop

        Catch ex As Exception
            MsgBox("Error al consultar canciones")
        End Try

        conexion.Close()
    End Sub

    Function ObtenerIdPlaylist(nombrePlaylist As String) As String
        Dim resultadoID = ""

        Dim MiCmd As SqlCommand
        Dim MiLector As SqlDataReader
        conexion.Open()

        Try
            MiCmd = conexion.CreateCommand
            Dim consulta As String = "SELECT * FROM playlist WHERE nombre='" + nombrePlaylist + "' AND usuario_id=" + usr_id + ""
            MiCmd.CommandText = consulta
            MiLector = MiCmd.ExecuteReader()

            Do While MiLector.Read()
                '0-id;  1= nombre;  2=fecha; 3=foto; 4=usuario id
                resultadoID = MiLector.GetInt32(0).ToString()
            Loop

        Catch ex As Exception
            MsgBox("Error al consultar playlist")
        End Try

        conexion.Close()

        Return resultadoID
    End Function

    Function ObtenerIdCancion(nombreCancion As String) As String
        Dim resultadoID = ""

        Dim MiCmd As SqlCommand
        Dim MiLector As SqlDataReader
        conexion.Open()

        Try
            MiCmd = conexion.CreateCommand
            Dim consulta As String = "SELECT * FROM cancion WHERE nombre='" + nombreCancion + "'"
            MiCmd.CommandText = consulta
            MiLector = MiCmd.ExecuteReader()

            Do While MiLector.Read()
                '0-id;  1= nombre;  2=genero; 3=ubicacion; 4=artstta id
                resultadoID = MiLector.GetInt32(0).ToString()
            Loop

        Catch ex As Exception
            MsgBox("Error al consultar cancion")
        End Try

        conexion.Close()

        Return resultadoID
    End Function


End Class