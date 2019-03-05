<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportarCatalogos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbOrigen = New System.Windows.Forms.ComboBox()
        Me.CbDestino = New System.Windows.Forms.ComboBox()
        Me.BtIniciar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Origen:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(520, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Destino:"
        '
        'CbOrigen
        '
        Me.CbOrigen.FormattingEnabled = True
        Me.CbOrigen.Location = New System.Drawing.Point(192, 252)
        Me.CbOrigen.Name = "CbOrigen"
        Me.CbOrigen.Size = New System.Drawing.Size(121, 21)
        Me.CbOrigen.TabIndex = 1
        '
        'CbDestino
        '
        Me.CbDestino.FormattingEnabled = True
        Me.CbDestino.Location = New System.Drawing.Point(572, 252)
        Me.CbDestino.Name = "CbDestino"
        Me.CbDestino.Size = New System.Drawing.Size(121, 21)
        Me.CbDestino.TabIndex = 1
        '
        'BtIniciar
        '
        Me.BtIniciar.Location = New System.Drawing.Point(572, 442)
        Me.BtIniciar.Name = "BtIniciar"
        Me.BtIniciar.Size = New System.Drawing.Size(121, 21)
        Me.BtIniciar.TabIndex = 2
        Me.BtIniciar.Text = "Iniciar Importacion"
        Me.BtIniciar.UseVisualStyleBackColor = True
        '
        'ImportarCatalogos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 586)
        Me.Controls.Add(Me.BtIniciar)
        Me.Controls.Add(Me.CbDestino)
        Me.Controls.Add(Me.CbOrigen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ImportarCatalogos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar Catalogos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CbOrigen As ComboBox
    Friend WithEvents CbDestino As ComboBox
    Friend WithEvents BtIniciar As Button
End Class
