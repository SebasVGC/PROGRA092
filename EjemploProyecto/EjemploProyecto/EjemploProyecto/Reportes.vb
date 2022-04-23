Imports System.Data.SqlClient
Public Class Reportes

    Dim MiCmd As SqlCommand
    Dim adaptador As SqlDataAdapter
    Dim setDatos As DataSet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim consulta1 As String = "SELECT * FROM usuario"
        MostrarReporte(consulta1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim consulta1 As String = "SELECT * FROM cancion"
        MostrarReporte(consulta1)
    End Sub


    Sub MostrarReporte(entrada As String)
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()

        conexion.Open()

        Try
            MiCmd = conexion.CreateCommand
            Dim consulta As String = entrada

            MiCmd.CommandText = consulta
            MiCmd.CommandType = CommandType.Text
            MiCmd.Connection = conexion
            adaptador = New SqlDataAdapter(MiCmd)
            setDatos = New DataSet()
            adaptador.Fill(setDatos)

            DataGridView1.DataSource = setDatos.Tables(0).DefaultView

        Catch ex As Exception
            MsgBox("Error al realizar consulta")
        End Try

        conexion.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim consulta1 As String = "SELECT * FROM artista"
        MostrarReporte(consulta1)
    End Sub
End Class