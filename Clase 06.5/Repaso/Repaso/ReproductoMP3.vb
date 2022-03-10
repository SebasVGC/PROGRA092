Public Class ReproductoMP3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        reproductorMP3.URL = "C:\Users\SebasVGC\Music\Progra2\Mario bros.mp3"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        reproductorMP3.URL = "C:\Users\SebasVGC\Music\Progra2\Jurassic park.mp3"
    End Sub
End Class