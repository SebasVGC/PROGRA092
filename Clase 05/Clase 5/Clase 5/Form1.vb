Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        Dim cadenaLimpiar As String = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nombreEntrada As String = ""

        Do
            nombreEntrada = InputBox("Ingrese su nombre: ", "Mensaje", "", 2)
        Loop While (nombreEntrada = "")

        lbNombre.Text = nombreEntrada



    End Sub

    Private Sub btnOp1_Click(sender As Object, e As EventArgs) Handles btnOp1.Click
        Dim a As Integer = Int32.Parse(txtNumA1.Text)
        Dim b As Integer = Int32.Parse(txtNumB1.Text)


        If (a > b) Then
            Dim indice = b
            Dim resultado1 As String = ""
            Dim cantidadPares As Integer = 0

            While (indice <= a)
                If (indice Mod 2 = 0) Then
                    resultado1 = resultado1 + indice.ToString + ","
                    cantidadPares = cantidadPares + 1
                End If
                indice = indice + 1
            End While
            lbResultado.Text = "Cantidad de pares: " + cantidadPares.ToString
            txtResultado.Text = resultado1
        ElseIf (b > a) Then
            Dim indice = a 'empieza en a porque aqui a es menos
            Dim resultado1 As String = ""
            Dim cantidadImpares As Integer = 0

            While (indice <= b) 'aqui es b porque b es mayor y el ciclo va desde a aumentando hasta b
                If Not (indice Mod 2 = 0) Then
                    resultado1 = resultado1 + indice.ToString + ","
                    cantidadImpares = cantidadImpares + 1
                End If
                indice = indice + 1
            End While
            lbResultado.Text = "Cantidad de impares: " + cantidadImpares.ToString
            txtResultado.Text = resultado1
        Else
            MsgBox("los numeros son iguales")
        End If


    End Sub

    Private Sub btnOp2_Click(sender As Object, e As EventArgs) Handles btnOp2.Click
        Dim a As Integer = Int32.Parse(txtA2.Text)
        Dim b As Integer = Int32.Parse(txtB2.Text)
        Dim textResultado As String = ""

        Dim numSaltar As Integer = Int32.Parse(txtSaltar.Text)
        Dim numSalir As Integer = Int32.Parse(txtSalir.Text)

        If (b > a) Then
            Dim indice As Integer = a
            While (indice <= b)
                If (indice = numSaltar) Then 'Saltarse el numero
                    indice = indice + 1 'actualizar el indice
                    Continue While
                End If

                If (indice = numSalir) Then
                    Exit While
                End If

                textResultado = textResultado + indice.ToString + "," 'agregando numeros a la cadena
                indice = indice + 1 'actualizar el indice
            End While
            txtRes2.Text = textResultado
        Else
            MsgBox("B debe ser mayor que A")
        End If

    End Sub
End Class
