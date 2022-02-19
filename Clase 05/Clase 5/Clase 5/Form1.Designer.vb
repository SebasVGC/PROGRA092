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
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        Me.TabControl1.Location = New System.Drawing.Point(19, 79)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(757, 249)
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
End Class
