Imports System.Data.SqlClient
Public Class Form1
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'ESTE BOTON VA A CONECTAR CON LA DB Y A TRAER DATOS
        myConn = New SqlConnection("Data Source=DESKTOP-7V29N2G\SQLEXPRESS;Initial Catalog=ejemploDB;Integrated Security=True")

        Try
            myConn.Open()
            MsgBox("Cnexion exitosa")
            'En este punto ya sabemos que tenemos conexion
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT * FROM usuario"
            myReader = myCmd.ExecuteReader()

            Do While myReader.Read()
                Dim id_ As String = myReader.GetInt32(0).ToString()
                Dim nombre_ As String = myReader.GetString(1)
                Dim edad_ As String = myReader.GetInt32(2).ToString()
                Dim cadena As String = id_ + "-" + nombre_ + "-" + edad_ + ";"

                ListBox1.Items.Add(cadena)
            Loop

            myConn.Close()

        Catch ex As Exception
            MsgBox("Error en conexion")
        End Try



    End Sub
End Class
