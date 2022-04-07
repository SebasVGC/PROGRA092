Public Class FormMisPlaylist
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormInicio.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ComboBox1.Items.Add("A")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox1.Items.Clear()
    End Sub
End Class