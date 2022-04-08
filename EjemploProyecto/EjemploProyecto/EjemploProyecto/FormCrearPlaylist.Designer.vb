<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCrearPlaylist
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbRuta = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.listaCancion1 = New System.Windows.Forms.ListBox()
        Me.listaCancion2 = New System.Windows.Forms.ListBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 18)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(106, 84)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(376, 24)
        Me.txtNombre.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(106, 133)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 32)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Explorar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lbRuta
        '
        Me.lbRuta.AutoSize = True
        Me.lbRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRuta.Location = New System.Drawing.Point(242, 140)
        Me.lbRuta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbRuta.Name = "lbRuta"
        Me.lbRuta.Size = New System.Drawing.Size(33, 18)
        Me.lbRuta.TabIndex = 4
        Me.lbRuta.Text = "ruta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 140)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Imagen"
        '
        'listaCancion1
        '
        Me.listaCancion1.FormattingEnabled = True
        Me.listaCancion1.ItemHeight = 18
        Me.listaCancion1.Location = New System.Drawing.Point(20, 211)
        Me.listaCancion1.Name = "listaCancion1"
        Me.listaCancion1.Size = New System.Drawing.Size(328, 166)
        Me.listaCancion1.TabIndex = 7
        '
        'listaCancion2
        '
        Me.listaCancion2.FormattingEnabled = True
        Me.listaCancion2.ItemHeight = 18
        Me.listaCancion2.Location = New System.Drawing.Point(456, 211)
        Me.listaCancion2.Name = "listaCancion2"
        Me.listaCancion2.Size = New System.Drawing.Size(328, 166)
        Me.listaCancion2.TabIndex = 8
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(379, 234)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(51, 46)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = ">>"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(379, 300)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(51, 46)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "<<"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(583, 399)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(106, 31)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Crear"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormCrearPlaylist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 440)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.listaCancion2)
        Me.Controls.Add(Me.listaCancion1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbRuta)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormCrearPlaylist"
        Me.Text = "FormCrearPlaylist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents lbRuta As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents listaCancion1 As ListBox
    Friend WithEvents listaCancion2 As ListBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
