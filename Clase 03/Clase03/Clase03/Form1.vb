Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim texto = txtInicio.Text

        If Not (texto = "") Then
            Dim opcionInt = Int32.Parse(texto)
            Select Case (opcionInt)
                Case 1
                    TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
                Case 2
                    TabControl1.SelectedTab = TabControl1.TabPages.Item(2)
                Case Else
                    MsgBox("Ninguna opcion")
            End Select
        Else
            MsgBox("Cadena vacia")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim texto As String = TextBox1.Text
        Dim numero As Decimal = Convert.ToDecimal(texto)
        Dim interes As Decimal = 0

        If (numero >= 0 And numero <= 1000) Then
            interes = numero * 0.015
        ElseIf (numero > 1000 And numero <= 5000) Then
            interes = numero * 0.025
        ElseIf (numero > 5000) Then
            interes = numero * 0.03
        Else
            MsgBox("No puede ingresar numeros negativos")
        End If

        Label3.Text = interes.ToString

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim texto As String = TextBox2.Text
        Dim numero As Decimal = Convert.ToDecimal(texto)
        Dim interes As Decimal = 0

        If (numero >= 0 And numero <= 10000) Then
            interes = numero * 0.01
        ElseIf (numero > 10000 And numero <= 50000) Then
            interes = numero * 0.02
        ElseIf (numero > 50000) Then
            interes = numero * 0.03
        Else
            MsgBox("No puede ingresar numeros negativos")
        End If
        Label5.Text = interes.ToString
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        txtInicio.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
