Public Class Form1
    Dim nombrePersona As String = ""
    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        Dim numeroEntrante As String = lbNumero.Text
        numeroEntrante = Restar(numeroEntrante)
        lbNumero.Text = numeroEntrante
    End Sub

    Function Restar(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevoTexto As String
        numero = numero - 1
        nuevoTexto = numero.ToString()
        Return nuevoTexto
    End Function

    Function Aumentar(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevoTexto As String
        numero = numero + 1
        nuevoTexto = numero.ToString()
        Return nuevoTexto
    End Function

    Private Sub btnMas_Click(sender As Object, e As EventArgs) Handles btnMas.Click
        Dim numeroEntrante As String = lbNumero.Text
        numeroEntrante = Aumentar(numeroEntrante)
        lbNumero.Text = numeroEntrante
    End Sub


    Sub opcion1()
        'MsgBox("op 1")
        If (nombrePersona = "") Then
            MsgBox("Nombre vacio")
        Else
            MsgBox("Hola " + nombrePersona)
        End If

    End Sub
    Sub opcion2()
        'MsgBox("op 2")
        Dim nuevoNombre = InputBox("Nombre", "Ingrese nombre")
        nombrePersona = nuevoNombre
        MsgBox("Nombre actualizado")
    End Sub
    Sub opcion3()
        'MsgBox("op 3")
        If (nombrePersona = "") Then
            MsgBox("Nombre vacio")
        Else
            lbImpresion.Text = "Su nombre es " + nombrePersona
        End If

    End Sub
    Sub opcion4()
        'MsgBox("op 4")
        nombrePersona = ""
        lbImpresion.Text = "Su nombre aqui"
        lbNumero.Text = "0"
    End Sub
    Sub opcion5()
        'MsgBox("op 5")
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim opcionTexto As String = lbNumero.Text
        Dim opcionNumero As Integer = Int32.Parse(opcionTexto)

        Select Case opcionNumero
            Case 1
                opcion1()
            Case 2
                opcion2()
            Case 3
                opcion3()
            Case 4
                opcion4()
            Case 5
                opcion5()
            Case Else
                MsgBox("Opcion incorrecta")

        End Select
    End Sub
End Class
