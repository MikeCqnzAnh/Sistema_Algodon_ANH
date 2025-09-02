<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaLotes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbconsultarcomprador = New System.Windows.Forms.Button()
        Me.rbporpaca = New System.Windows.Forms.RadioButton()
        Me.rbporlote = New System.Windows.Forms.RadioButton()
        Me.btbuscar = New System.Windows.Forms.Button()
        Me.tbcomprador = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbconsultarcomprador
        '
        Me.tbconsultarcomprador.Location = New System.Drawing.Point(483, 51)
        Me.tbconsultarcomprador.Name = "tbconsultarcomprador"
        Me.tbconsultarcomprador.Size = New System.Drawing.Size(30, 23)
        Me.tbconsultarcomprador.TabIndex = 11
        Me.tbconsultarcomprador.UseVisualStyleBackColor = True
        '
        'rbporpaca
        '
        Me.rbporpaca.AutoSize = True
        Me.rbporpaca.Location = New System.Drawing.Point(153, 165)
        Me.rbporpaca.Name = "rbporpaca"
        Me.rbporpaca.Size = New System.Drawing.Size(68, 17)
        Me.rbporpaca.TabIndex = 10
        Me.rbporpaca.TabStop = True
        Me.rbporpaca.Text = "Por paca"
        Me.rbporpaca.UseVisualStyleBackColor = True
        '
        'rbporlote
        '
        Me.rbporlote.AutoSize = True
        Me.rbporlote.Location = New System.Drawing.Point(34, 165)
        Me.rbporlote.Name = "rbporlote"
        Me.rbporlote.Size = New System.Drawing.Size(100, 17)
        Me.rbporlote.TabIndex = 9
        Me.rbporlote.TabStop = True
        Me.rbporlote.Text = "Agrupar por lote"
        Me.rbporlote.UseVisualStyleBackColor = True
        '
        'btbuscar
        '
        Me.btbuscar.Location = New System.Drawing.Point(402, 162)
        Me.btbuscar.Name = "btbuscar"
        Me.btbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btbuscar.TabIndex = 8
        Me.btbuscar.Text = "Buscar"
        Me.btbuscar.UseVisualStyleBackColor = True
        '
        'tbcomprador
        '
        Me.tbcomprador.Location = New System.Drawing.Point(95, 53)
        Me.tbcomprador.Name = "tbcomprador"
        Me.tbcomprador.Size = New System.Drawing.Size(382, 20)
        Me.tbcomprador.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Comprador"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbconsultarcomprador)
        Me.GroupBox1.Controls.Add(Me.tbcomprador)
        Me.GroupBox1.Controls.Add(Me.rbporpaca)
        Me.GroupBox1.Controls.Add(Me.btbuscar)
        Me.GroupBox1.Controls.Add(Me.rbporlote)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1296, 206)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'ConsultaLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1296, 664)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ConsultaLotes"
        Me.Text = "Consulta Lotes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbconsultarcomprador As Button
    Friend WithEvents rbporpaca As RadioButton
    Friend WithEvents rbporlote As RadioButton
    Friend WithEvents btbuscar As Button
    Friend WithEvents tbcomprador As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
