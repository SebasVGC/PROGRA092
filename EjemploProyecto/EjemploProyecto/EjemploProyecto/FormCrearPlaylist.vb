Public Class FormCrearPlaylist
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormInicio.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox2.Items.Add("a")

    End Sub
End Class