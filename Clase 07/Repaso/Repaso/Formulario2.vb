Public Class Formulario2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = variableGlobal2

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim rutaImagen As String = "C:\Users\SebasVGC\Pictures\Progra2\car.png"
        PictureBox1.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim rutaImagen As String = "C:\Users\SebasVGC\Pictures\Progra2\cat.png"
        PictureBox1.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim rutaImagen As String = "C:\Users\SebasVGC\Pictures\Progra2\dino.png"
        PictureBox1.Image = Image.FromFile(rutaImagen)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        OpenFileDialog1.ShowDialog()
        Dim rutaArchivo As String = OpenFileDialog1.FileName
        'MsgBox(rutaArchivo)

        PictureBox1.Image = Image.FromFile(rutaArchivo)
    End Sub
End Class