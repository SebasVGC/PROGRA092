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
End Class
