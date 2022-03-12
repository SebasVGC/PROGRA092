Public Class Form2
    'Dim tablero()() As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cantFilas = Int32.Parse(TextBox1.Text) '14
        Dim cantColumnas = Int32.Parse(TextBox2.Text) '7
        MsgBox("Matriz de " + cantFilas.ToString + " x " + cantColumnas.ToString)

        Dim tablero(cantFilas, cantColumnas) As Integer

        '-----Llenar matriz-----
        For fila As Integer = 0 To (cantFilas - 1) Step 1 '0-13
            For columna As Integer = 0 To (cantColumnas - 1) Step 1 '0-6
                tablero(fila, columna) = 0
            Next
        Next

        '---Crear cadena de texto------
        Dim cadena As String = ""
        For fila As Integer = 0 To (cantFilas - 1) Step 1
            For columna As Integer = 0 To (cantColumnas - 1) Step 1
                cadena = cadena + tablero(fila, columna).ToString + " "
            Next
            cadena = cadena + vbCr
        Next

        '---Mostrarlos------
        Console.WriteLine(cadena)
        RichTextBox1.Text = cadena

    End Sub
End Class