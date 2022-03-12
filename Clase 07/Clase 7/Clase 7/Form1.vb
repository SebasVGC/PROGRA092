Public Class Form1

    Dim tablero(10, 10) As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '-----Llenar matriz-----
        For fila As Integer = 0 To 9 Step 1
            For columna As Integer = 0 To 9 Step 1
                tablero(fila, columna) = 0
            Next
        Next

        '---Crear cadena de texto------
        Dim cadena As String = ""
        For fila As Integer = 0 To 9 Step 1
            For columna As Integer = 0 To 9 Step 1
                cadena = cadena + tablero(fila, columna).ToString + " " + vbTab
            Next
            cadena = cadena + vbCr
        Next

        '---Mostrarlos------
        'Console.WriteLine(cadena)
        RichTextBox1.Text = cadena

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fil = Int32.Parse(TextBox1.Text)
        Dim col = Int32.Parse(TextBox2.Text)

        If (fil > 9 Or fil < 0) Then
            MsgBox("Ingrese una fila valida")
        Else
            If (col > 9 Or col < 0) Then
                MsgBox("Ingrese una columna valida")
            Else
                'Aqui cuando las filas y columnas son correctas
                tablero(fil, col) = 1

                '---Crear cadena de texto------
                Dim cadena As String = ""
                For fila As Integer = 0 To 9 Step 1
                    For columna As Integer = 0 To 9 Step 1
                        cadena = cadena + tablero(fila, columna).ToString + " " + vbTab
                    Next
                    cadena = cadena + vbCr
                Next

                '---Mostrarlos------
                RichTextBox1.Text = cadena
            End If
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Visible = True
        Me.Hide()
    End Sub
End Class
