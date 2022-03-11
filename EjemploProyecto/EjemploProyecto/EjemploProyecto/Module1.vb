Imports System.Data.SqlClient
Module Module1
    Public datosConexion As String = "Data Source=DESKTOP-7V29N2G\SQLEXPRESS;Initial Catalog=DB_PROYECTO;Integrated Security=True"
    Public conexion As New SqlConnection(datosConexion)

    Public usr_id As String = ""
    Public usr_nombre As String = ""
    Public usr_username As String = ""
    Public usr_password As String = ""
    Public usr_tipo As String = ""
    Public usr_foto As String = ""


End Module
