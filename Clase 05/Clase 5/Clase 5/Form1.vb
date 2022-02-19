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

    Private Sub btnCalcularNotas_Click(sender As Object, e As EventArgs) Handles btnCalcularNotas.Click
        Dim textoNota1 As String = txtNota1.Text
        Dim textoNota2 As String = txtNota2.Text
        Dim textoNota3 As String = txtNota3.Text
        Dim textoNota4 As String = txtNota4.Text
        Dim textoNota5 As String = txtNota5.Text

        If (textoNota1 = "" Or textoNota2 = "" Or textoNota3 = "" Or textoNota4 = "" Or textoNota5 = "") Then
            MsgBox("Ingrese todos los campos")
        Else
            Dim numNota1 As Integer = Int32.Parse(textoNota1)
            Dim numNota2 As Integer = Int32.Parse(textoNota2)
            Dim numNota3 As Integer = Int32.Parse(textoNota3)
            Dim numNota4 As Integer = Int32.Parse(textoNota4)
            Dim numNota5 As Integer = Int32.Parse(textoNota5)

            If (numNota1 < 0 Or numNota2 < 0 Or numNota3 < 0 Or numNota4 < 0 Or numNota5 < 0) Then
                MsgBox("No se admiten numeros negativos")
            Else
                If (numNota1 < 61) Then
                    lbAR1.Text = "REPROBADO"
                Else
                    lbAR1.Text = "APROBADO"
                End If

                If (numNota2 < 61) Then
                    lbAR2.Text = "REPROBADO"
                Else
                    lbAR2.Text = "APROBADO"
                End If

                If (numNota3 < 61) Then
                    lbAR3.Text = "REPROBADO"
                Else
                    lbAR3.Text = "APROBADO"
                End If
                If (numNota4 < 61) Then
                    lbAR4.Text = "REPROBADO"
                Else
                    lbAR4.Text = "APROBADO"
                End If

                If (numNota5 < 61) Then
                    lbAR5.Text = "REPROBADO"
                Else
                    lbAR5.Text = "APROBADO"
                End If


                'aqui ira nuestro programa
                Dim check1 As Boolean = CheckBox1.Checked
                Dim check2 As Boolean = CheckBox2.Checked
                Dim check3 As Boolean = CheckBox3.Checked
                Dim check4 As Boolean = CheckBox4.Checked
                Dim check5 As Boolean = CheckBox5.Checked

                Dim cantidadCursos As Integer = 0
                Dim SumaPromerio As Integer = 0


                If (check1) Then
                    SumaPromerio = SumaPromerio + numNota1
                    cantidadCursos = cantidadCursos + 1
                End If
                If (check2) Then
                    SumaPromerio = SumaPromerio + numNota2
                    cantidadCursos = cantidadCursos + 1
                End If
                If (check3) Then
                    SumaPromerio = SumaPromerio + numNota3
                    cantidadCursos = cantidadCursos + 1
                End If
                If (check4) Then
                    SumaPromerio = SumaPromerio + numNota4
                    cantidadCursos = cantidadCursos + 1
                End If
                If (check5) Then
                    SumaPromerio = SumaPromerio + numNota5
                    cantidadCursos = cantidadCursos + 1
                End If

                Dim promedio As Double = SumaPromerio / cantidadCursos

                lbPromedio.Text = "Su promedio: " + promedio.ToString

                If (promedio >= 0 And promedio < 61) Then
                    lbPromedio.Text = "Su promedio: " + promedio.ToString + " reporbado"
                ElseIf (promedio >= 61 And promedio < 70) Then
                    lbPromedio.Text = "Su promedio: " + promedio.ToString + " regular"
                ElseIf (promedio >= 70 And promedio <= 85) Then
                    lbPromedio.Text = "Su promedio: " + promedio.ToString + " buen estudiante"
                ElseIf (promedio >= 85) Then
                    lbPromedio.Text = "Su promedio: " + promedio.ToString + " excelente"
                End If

            End If
        End If
    End Sub
End Class
