Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Hola PROGRA 2" + " segunda etiqueta: " + 4444.ToString())
    End Sub

    Private Sub botonMsj_Click(sender As Object, e As EventArgs) Handles botonMsj.Click
        Dim a1 As Boolean
        a1 = True And False Or True
        MsgBox("Mensaje: " + a1.ToString())
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        MsgBox("ABRIR")
    End Sub
End Class
