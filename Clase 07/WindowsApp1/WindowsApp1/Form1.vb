Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Formulario2.Visible = True
        MsgBox("A")
        Formulario2.TextBox1.Visible = False
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormLogin.PictureBox1.Image = Image.FromFile("C:\Users\SebasVGC\Pictures\Progra2\car.png")
        FormLogin.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormLogin.PictureBox1.Image = Image.FromFile("C:\Users\SebasVGC\Pictures\Progra2\cat.png")
        FormLogin.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim SourceFile As String
        OpenFileDialog1.ShowDialog()
        SourceFile = OpenFileDialog1.FileName
        Label1.Text = SourceFile

        PictureBox1.Image = Image.FromFile(SourceFile)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        player1.URL = "C:\Users\SebasVGC\Music\Mision imposible.mp3"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        player1.URL = "C:\Users\SebasVGC\Music\Progra2\Mario bros.mp3"
    End Sub
End Class
