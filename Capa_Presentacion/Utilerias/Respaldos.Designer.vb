<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Respaldos
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
        Me.GbOrigen = New System.Windows.Forms.GroupBox()
        Me.TbRutaRespaldo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbOrigenDB = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtAceptar = New System.Windows.Forms.Button()
        Me.BtCancelar = New System.Windows.Forms.Button()
        Me.GbOrigen.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbOrigen
        '
        Me.GbOrigen.Controls.Add(Me.BtCancelar)
        Me.GbOrigen.Controls.Add(Me.BtAceptar)
        Me.GbOrigen.Controls.Add(Me.TextBox1)
        Me.GbOrigen.Controls.Add(Me.Label2)
        Me.GbOrigen.Controls.Add(Me.TbRutaRespaldo)
        Me.GbOrigen.Controls.Add(Me.Label1)
        Me.GbOrigen.Controls.Add(Me.Label7)
        Me.GbOrigen.Controls.Add(Me.CbOrigenDB)
        Me.GbOrigen.Dock = System.Windows.Forms.DockStyle.Left
        Me.GbOrigen.Location = New System.Drawing.Point(0, 0)
        Me.GbOrigen.Name = "GbOrigen"
        Me.GbOrigen.Size = New System.Drawing.Size(455, 515)
        Me.GbOrigen.TabIndex = 0
        Me.GbOrigen.TabStop = False
        '
        'TbRutaRespaldo
        '
        Me.TbRutaRespaldo.Location = New System.Drawing.Point(15, 141)
        Me.TbRutaRespaldo.Name = "TbRutaRespaldo"
        Me.TbRutaRespaldo.Size = New System.Drawing.Size(426, 20)
        Me.TbRutaRespaldo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ruta de respaldo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Base de datos:"
        '
        'CbOrigenDB
        '
        Me.CbOrigenDB.FormattingEnabled = True
        Me.CbOrigenDB.Location = New System.Drawing.Point(15, 101)
        Me.CbOrigenDB.Name = "CbOrigenDB"
        Me.CbOrigenDB.Size = New System.Drawing.Size(185, 21)
        Me.CbOrigenDB.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre de respaldo:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 217)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(241, 20)
        Me.TextBox1.TabIndex = 2
        '
        'BtAceptar
        '
        Me.BtAceptar.Location = New System.Drawing.Point(253, 480)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtAceptar.TabIndex = 3
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'BtCancelar
        '
        Me.BtCancelar.Location = New System.Drawing.Point(366, 480)
        Me.BtCancelar.Name = "BtCancelar"
        Me.BtCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtCancelar.TabIndex = 4
        Me.BtCancelar.Text = "Cancelar"
        Me.BtCancelar.UseVisualStyleBackColor = True
        '
        'Respaldos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 515)
        Me.Controls.Add(Me.GbOrigen)
        Me.Name = "Respaldos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Respaldos"
        Me.GbOrigen.ResumeLayout(False)
        Me.GbOrigen.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbOrigen As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CbOrigenDB As ComboBox
    Friend WithEvents TbRutaRespaldo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtCancelar As Button
    Friend WithEvents BtAceptar As Button
End Class
