Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Formulario2.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Formulario2.Visible = True
        Me.Visible = False

        Formulario2.PictureBox1.Image = Image.FromFile("C:\Users\SebasVGC\Pictures\Progra2\usac.png")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ReproductoMP3.Visible = True
        Me.Visible = False
    End Sub
End Class
