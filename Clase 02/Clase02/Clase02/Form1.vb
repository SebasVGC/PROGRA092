Public Class Form1
    'AQUI VARIABLES GLOBALES
    Dim publica As String = "abc"
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim localV As String = "privada"
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre As String
        nombre = txtNombre.Text

        MsgBox("Hola " + nombre)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim check1 As Boolean = CheckBox1.Checked
        Dim check2 As Boolean = CheckBox2.Checked

        MsgBox(check1)
        MsgBox(check2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim check1 As Boolean = radio1.Checked
        Dim check2 As Boolean = radio2.Checked

        MsgBox(check1)
        MsgBox(check2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim elemento As String
        elemento = ComboBox1.SelectedItem
        MsgBox(elemento)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PictureBox1.Visible = True
        PictureBox2.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PictureBox1.Visible = False
        PictureBox2.Visible = False
    End Sub

    Private Sub btnFecha1_Click(sender As Object, e As EventArgs) Handles btnFecha1.Click
        Dim fecha1 As Date
        fecha1 = DateTimePicker1.Value
        MsgBox(fecha1)
    End Sub

    Private Sub btnFecha2_Click(sender As Object, e As EventArgs) Handles btnFecha2.Click
        Dim fecha2a As Date
        Dim fecha2b As Date

        fecha2a = MonthCalendar1.SelectionStart
        fecha2b = fecha2a.AddDays(10)
        MsgBox(fecha2b)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim a1 As String = “Hola”
        Dim a2 As Byte = 10
        Dim a3 As Boolean = True
        Dim a4 As String = “Hola” + “ mundo”
        Dim a5 As String = 10.ToString
        Dim a6 As String = “Hola” + ”!”
        Dim a7 As Boolean = True And False
        Dim a8 As String = "TextBox1.Text"
        Dim a9 As Single = 2.5
        Dim a10 As String = a1 + a6
        Dim a11 As String = “Piplo”
        Dim a12 As Boolean = True Or a7
        Dim a13 As Byte = “7”
        Dim a14 As String = “ es un wen amigo”
        Dim a15 As Integer = Convert.ToInt32(a13) * 10
        'Dim a16 As Date = MonthCalendar1.SelectionStart
        Dim a17 As String = a11 + a5 + a14
        Dim a18 As Boolean = True Or (False And True)
        Dim a19 As String = a18.ToString + ” falso”
        Dim a20 As Date = DateValue(Now)

        MsgBox(a17)

    End Sub
End Class
