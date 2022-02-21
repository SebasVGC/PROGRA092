Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim nombre As String

        nombre = txtNombre.Text
        If (nombre = "") Then
            MsgBox("No se admiten cadenas vacias")
        Else
            listaEmpleado.Items.Add(nombre)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim cantidadTotal As Integer = 0

        For Each empleado In listaEmpleado.Items

            cantidadTotal = cantidadTotal + 1
        Next

        MsgBox("Cantidad total: " + cantidadTotal.ToString)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim cantidadTotalA As Integer = 0

        For Each empleado In listaEmpleado.Items
            Dim primeraLetra As String = Mid(empleado, 1, 1)

            If (primeraLetra = "A") Then
                cantidadTotalA = cantidadTotalA + 1
            End If
        Next
        MsgBox("Cantidad A: " + cantidadTotalA.ToString)
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim moneda As String
        Dim cantidadOp As Integer
        Dim texto As String
        Dim total1 As Double = 0
        Dim total2 As Double = 0

        If (RadioButton1.Checked) Then
            moneda = "dolar"
        ElseIf (RadioButton2.Checked) Then
            moneda = "peso"
        ElseIf (RadioButton3.Checked) Then
            moneda = "euro"
        End If

        texto = txtCantidad.Text
        If (texto = "") Then
            MsgBox("no se adminten textos vacios")
        Else
            cantidadOp = Int32.Parse(texto)
            If (cantidadOp > 0) Then
                If (moneda = "dolar") Then
                    total1 = 7.69 * cantidadOp
                ElseIf (moneda = "peso") Then
                    total1 = 0.38 * cantidadOp
                ElseIf (moneda = "euro") Then
                    total1 = 8.79 * cantidadOp
                End If
            Else
                MsgBox("Ingrese numero valido")
            End If

            MsgBox(total1)

        End If




    End Sub

    'Este es el boton donde se efecuta la funcionalidad de varias operaciones
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim moneda As String
        Dim cantidadOp As Integer
        Dim texto As String
        Dim total1 As Double = 0 'Este guarda el total de 1 sola operacion
        Dim total2 As Double = 0 'Este guarda el total de todas las operaciones sumadas

        If (RadioButton1.Checked) Then
            moneda = "dolar"
        ElseIf (RadioButton2.Checked) Then
            moneda = "peso"
        ElseIf (RadioButton3.Checked) Then
            moneda = "euro"
        End If

        texto = TextBox2.Text
        If (texto = "") Then
            MsgBox("no se adminten textos vacios")
        Else
            cantidadOp = Int32.Parse(texto)

            'Este siclo for vamos a repetirlo para la cantidad de operaciones
            'Va a repetir desde 1 hasta el numero que ingresamos
            For index As Integer = 1 To cantidadOp
                Dim dinero As String
                dinero = InputBox("Ingrese monto", "Saludo", "", 2)
                Dim dineroInt = Int32.Parse(dinero)

                If (moneda = "dolar") Then
                    total1 = 7.69 * dineroInt 'Calculamos el total de la operacion actual
                    MsgBox(total1)
                    total2 = total2 + total1 'Sumamos el resultado a total2

                ElseIf (moneda = "peso") Then
                    total1 = 0.38 * dineroInt 'Calculamos el total de la operacion actual
                    MsgBox(total1)
                    total2 = total2 + total1 'Sumamos el resultado a total2

                ElseIf (moneda = "euro") Then
                    total1 = 8.79 * dineroInt 'Calculamos el total de la operacion actual
                    MsgBox(total1)
                    total2 = total2 + total1 'Sumamos el resultado a total2

                End If
            Next
        End If

        Label3.Text = total2.ToString

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
