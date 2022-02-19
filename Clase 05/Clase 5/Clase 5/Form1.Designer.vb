<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtNumA1 = New System.Windows.Forms.TextBox()
        Me.txtNumB1 = New System.Windows.Forms.TextBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOp1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbResultado = New System.Windows.Forms.Label()
        Me.txtA2 = New System.Windows.Forms.TextBox()
        Me.txtB2 = New System.Windows.Forms.TextBox()
        Me.btnOp2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSaltar = New System.Windows.Forms.TextBox()
        Me.txtSalir = New System.Windows.Forms.TextBox()
        Me.txtRes2 = New System.Windows.Forms.TextBox()
        Me.lbResultadoOp2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtNota1 = New System.Windows.Forms.TextBox()
        Me.txtNota2 = New System.Windows.Forms.TextBox()
        Me.txtNota3 = New System.Windows.Forms.TextBox()
        Me.txtNota4 = New System.Windows.Forms.TextBox()
        Me.txtNota5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.lbAR1 = New System.Windows.Forms.Label()
        Me.lbAR2 = New System.Windows.Forms.Label()
        Me.lbAR3 = New System.Windows.Forms.Label()
        Me.lbAR4 = New System.Windows.Forms.Label()
        Me.lbAR5 = New System.Windows.Forms.Label()
        Me.btnCalcularNotas = New System.Windows.Forms.Button()
        Me.lbPromedio = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EditarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.Location = New System.Drawing.Point(12, 24)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(138, 37)
        Me.lbNombre.TabIndex = 1
        Me.lbNombre.Text = "Nombre"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(19, 79)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(757, 359)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lbResultado)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.btnOp1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtResultado)
        Me.TabPage1.Controls.Add(Me.txtNumB1)
        Me.TabPage1.Controls.Add(Me.txtNumA1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(749, 223)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lbResultadoOp2)
        Me.TabPage2.Controls.Add(Me.txtRes2)
        Me.TabPage2.Controls.Add(Me.txtSalir)
        Me.TabPage2.Controls.Add(Me.txtSaltar)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.btnOp2)
        Me.TabPage2.Controls.Add(Me.txtB2)
        Me.TabPage2.Controls.Add(Me.txtA2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(749, 223)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtNumA1
        '
        Me.txtNumA1.Location = New System.Drawing.Point(140, 22)
        Me.txtNumA1.Name = "txtNumA1"
        Me.txtNumA1.Size = New System.Drawing.Size(100, 20)
        Me.txtNumA1.TabIndex = 0
        '
        'txtNumB1
        '
        Me.txtNumB1.Location = New System.Drawing.Point(140, 61)
        Me.txtNumB1.Name = "txtNumB1"
        Me.txtNumB1.Size = New System.Drawing.Size(100, 20)
        Me.txtNumB1.TabIndex = 1
        '
        'txtResultado
        '
        Me.txtResultado.Enabled = False
        Me.txtResultado.Location = New System.Drawing.Point(24, 164)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(703, 20)
        Me.txtResultado.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Numero a"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Numero b"
        '
        'btnOp1
        '
        Me.btnOp1.Location = New System.Drawing.Point(291, 59)
        Me.btnOp1.Name = "btnOp1"
        Me.btnOp1.Size = New System.Drawing.Size(75, 23)
        Me.btnOp1.TabIndex = 5
        Me.btnOp1.Text = "Calcular"
        Me.btnOp1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(327, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Resultado"
        '
        'lbResultado
        '
        Me.lbResultado.AutoSize = True
        Me.lbResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbResultado.Location = New System.Drawing.Point(417, 139)
        Me.lbResultado.Name = "lbResultado"
        Me.lbResultado.Size = New System.Drawing.Size(56, 13)
        Me.lbResultado.TabIndex = 7
        Me.lbResultado.Text = "cantidad"
        '
        'txtA2
        '
        Me.txtA2.Location = New System.Drawing.Point(82, 19)
        Me.txtA2.Name = "txtA2"
        Me.txtA2.Size = New System.Drawing.Size(100, 20)
        Me.txtA2.TabIndex = 0
        '
        'txtB2
        '
        Me.txtB2.Location = New System.Drawing.Point(82, 61)
        Me.txtB2.Name = "txtB2"
        Me.txtB2.Size = New System.Drawing.Size(100, 20)
        Me.txtB2.TabIndex = 1
        '
        'btnOp2
        '
        Me.btnOp2.Location = New System.Drawing.Point(252, 61)
        Me.btnOp2.Name = "btnOp2"
        Me.btnOp2.Size = New System.Drawing.Size(75, 23)
        Me.btnOp2.TabIndex = 2
        Me.btnOp2.Text = "Calcular"
        Me.btnOp2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Numero A"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Numero B"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(411, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Saltarse "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(403, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Detenerse"
        '
        'txtSaltar
        '
        Me.txtSaltar.Location = New System.Drawing.Point(492, 18)
        Me.txtSaltar.Name = "txtSaltar"
        Me.txtSaltar.Size = New System.Drawing.Size(100, 20)
        Me.txtSaltar.TabIndex = 7
        '
        'txtSalir
        '
        Me.txtSalir.Location = New System.Drawing.Point(492, 61)
        Me.txtSalir.Name = "txtSalir"
        Me.txtSalir.Size = New System.Drawing.Size(100, 20)
        Me.txtSalir.TabIndex = 8
        '
        'txtRes2
        '
        Me.txtRes2.Enabled = False
        Me.txtRes2.Location = New System.Drawing.Point(27, 162)
        Me.txtRes2.Name = "txtRes2"
        Me.txtRes2.Size = New System.Drawing.Size(680, 20)
        Me.txtRes2.TabIndex = 9
        '
        'lbResultadoOp2
        '
        Me.lbResultadoOp2.AutoSize = True
        Me.lbResultadoOp2.Location = New System.Drawing.Point(331, 135)
        Me.lbResultadoOp2.Name = "lbResultadoOp2"
        Me.lbResultadoOp2.Size = New System.Drawing.Size(55, 13)
        Me.lbResultadoOp2.TabIndex = 10
        Me.lbResultadoOp2.Text = "Resultado"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lbPromedio)
        Me.TabPage3.Controls.Add(Me.btnCalcularNotas)
        Me.TabPage3.Controls.Add(Me.lbAR5)
        Me.TabPage3.Controls.Add(Me.lbAR4)
        Me.TabPage3.Controls.Add(Me.lbAR3)
        Me.TabPage3.Controls.Add(Me.lbAR2)
        Me.TabPage3.Controls.Add(Me.lbAR1)
        Me.TabPage3.Controls.Add(Me.CheckBox5)
        Me.TabPage3.Controls.Add(Me.CheckBox4)
        Me.TabPage3.Controls.Add(Me.CheckBox3)
        Me.TabPage3.Controls.Add(Me.CheckBox2)
        Me.TabPage3.Controls.Add(Me.CheckBox1)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.txtNota5)
        Me.TabPage3.Controls.Add(Me.txtNota4)
        Me.TabPage3.Controls.Add(Me.txtNota3)
        Me.TabPage3.Controls.Add(Me.txtNota2)
        Me.TabPage3.Controls.Add(Me.txtNota1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(749, 333)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtNota1
        '
        Me.txtNota1.Location = New System.Drawing.Point(123, 22)
        Me.txtNota1.Name = "txtNota1"
        Me.txtNota1.Size = New System.Drawing.Size(100, 20)
        Me.txtNota1.TabIndex = 0
        '
        'txtNota2
        '
        Me.txtNota2.Location = New System.Drawing.Point(123, 58)
        Me.txtNota2.Name = "txtNota2"
        Me.txtNota2.Size = New System.Drawing.Size(100, 20)
        Me.txtNota2.TabIndex = 1
        '
        'txtNota3
        '
        Me.txtNota3.Location = New System.Drawing.Point(123, 98)
        Me.txtNota3.Name = "txtNota3"
        Me.txtNota3.Size = New System.Drawing.Size(100, 20)
        Me.txtNota3.TabIndex = 2
        '
        'txtNota4
        '
        Me.txtNota4.Location = New System.Drawing.Point(123, 143)
        Me.txtNota4.Name = "txtNota4"
        Me.txtNota4.Size = New System.Drawing.Size(100, 20)
        Me.txtNota4.TabIndex = 3
        '
        'txtNota5
        '
        Me.txtNota5.Location = New System.Drawing.Point(123, 188)
        Me.txtNota5.Name = "txtNota5"
        Me.txtNota5.Size = New System.Drawing.Size(100, 20)
        Me.txtNota5.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(60, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Mate"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(59, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Quimica"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(59, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Progra"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(57, 143)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Fisica"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(57, 188)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Social 1"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(16, 21)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(16, 60)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 11
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(16, 93)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox3.TabIndex = 12
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(16, 138)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox4.TabIndex = 13
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(16, 183)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox5.TabIndex = 14
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'lbAR1
        '
        Me.lbAR1.AutoSize = True
        Me.lbAR1.Location = New System.Drawing.Point(261, 28)
        Me.lbAR1.Name = "lbAR1"
        Me.lbAR1.Size = New System.Drawing.Size(27, 13)
        Me.lbAR1.TabIndex = 15
        Me.lbAR1.Text = "A/R"
        '
        'lbAR2
        '
        Me.lbAR2.AutoSize = True
        Me.lbAR2.Location = New System.Drawing.Point(261, 65)
        Me.lbAR2.Name = "lbAR2"
        Me.lbAR2.Size = New System.Drawing.Size(27, 13)
        Me.lbAR2.TabIndex = 16
        Me.lbAR2.Text = "A/R"
        '
        'lbAR3
        '
        Me.lbAR3.AutoSize = True
        Me.lbAR3.Location = New System.Drawing.Point(261, 101)
        Me.lbAR3.Name = "lbAR3"
        Me.lbAR3.Size = New System.Drawing.Size(27, 13)
        Me.lbAR3.TabIndex = 17
        Me.lbAR3.Text = "A/R"
        '
        'lbAR4
        '
        Me.lbAR4.AutoSize = True
        Me.lbAR4.Location = New System.Drawing.Point(261, 150)
        Me.lbAR4.Name = "lbAR4"
        Me.lbAR4.Size = New System.Drawing.Size(27, 13)
        Me.lbAR4.TabIndex = 18
        Me.lbAR4.Text = "A/R"
        '
        'lbAR5
        '
        Me.lbAR5.AutoSize = True
        Me.lbAR5.Location = New System.Drawing.Point(261, 191)
        Me.lbAR5.Name = "lbAR5"
        Me.lbAR5.Size = New System.Drawing.Size(27, 13)
        Me.lbAR5.TabIndex = 19
        Me.lbAR5.Text = "A/R"
        '
        'btnCalcularNotas
        '
        Me.btnCalcularNotas.Location = New System.Drawing.Point(409, 83)
        Me.btnCalcularNotas.Name = "btnCalcularNotas"
        Me.btnCalcularNotas.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcularNotas.TabIndex = 20
        Me.btnCalcularNotas.Text = "Calcular"
        Me.btnCalcularNotas.UseVisualStyleBackColor = True
        '
        'lbPromedio
        '
        Me.lbPromedio.AutoSize = True
        Me.lbPromedio.Location = New System.Drawing.Point(416, 146)
        Me.lbPromedio.Name = "lbPromedio"
        Me.lbPromedio.Size = New System.Drawing.Size(51, 13)
        Me.lbPromedio.TabIndex = 21
        Me.lbPromedio.Text = "Promedio"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbNombre As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents btnOp1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents txtNumB1 As TextBox
    Friend WithEvents txtNumA1 As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lbResultado As Label
    Friend WithEvents txtRes2 As TextBox
    Friend WithEvents txtSalir As TextBox
    Friend WithEvents txtSaltar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnOp2 As Button
    Friend WithEvents txtB2 As TextBox
    Friend WithEvents txtA2 As TextBox
    Friend WithEvents lbResultadoOp2 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lbPromedio As Label
    Friend WithEvents btnCalcularNotas As Button
    Friend WithEvents lbAR5 As Label
    Friend WithEvents lbAR4 As Label
    Friend WithEvents lbAR3 As Label
    Friend WithEvents lbAR2 As Label
    Friend WithEvents lbAR1 As Label
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNota5 As TextBox
    Friend WithEvents txtNota4 As TextBox
    Friend WithEvents txtNota3 As TextBox
    Friend WithEvents txtNota2 As TextBox
    Friend WithEvents txtNota1 As TextBox
End Class
