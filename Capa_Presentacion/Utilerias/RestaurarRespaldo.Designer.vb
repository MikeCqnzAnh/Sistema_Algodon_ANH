<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestaurarRespaldo
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbRutaArchivoRespaldo = New System.Windows.Forms.TextBox()
        Me.BtSeleccionaRuta = New System.Windows.Forms.Button()
        Me.OfArchivoRestaurar = New System.Windows.Forms.OpenFileDialog()
        Me.BtRestaurar = New System.Windows.Forms.Button()
        Me.TbBDD = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Base de datos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ruta de archivo de respaldo:"
        '
        'TbRutaArchivoRespaldo
        '
        Me.TbRutaArchivoRespaldo.Location = New System.Drawing.Point(34, 113)
        Me.TbRutaArchivoRespaldo.Name = "TbRutaArchivoRespaldo"
        Me.TbRutaArchivoRespaldo.Size = New System.Drawing.Size(404, 20)
        Me.TbRutaArchivoRespaldo.TabIndex = 1
        '
        'BtSeleccionaRuta
        '
        Me.BtSeleccionaRuta.Location = New System.Drawing.Point(444, 113)
        Me.BtSeleccionaRuta.Name = "BtSeleccionaRuta"
        Me.BtSeleccionaRuta.Size = New System.Drawing.Size(24, 20)
        Me.BtSeleccionaRuta.TabIndex = 5
        Me.BtSeleccionaRuta.Text = "..."
        Me.BtSeleccionaRuta.UseVisualStyleBackColor = True
        '
        'BtRestaurar
        '
        Me.BtRestaurar.Location = New System.Drawing.Point(357, 337)
        Me.BtRestaurar.Name = "BtRestaurar"
        Me.BtRestaurar.Size = New System.Drawing.Size(105, 35)
        Me.BtRestaurar.TabIndex = 6
        Me.BtRestaurar.Text = "Restaurar Base de Datos"
        Me.BtRestaurar.UseVisualStyleBackColor = True
        '
        'TbBDD
        '
        Me.TbBDD.Enabled = False
        Me.TbBDD.Location = New System.Drawing.Point(34, 73)
        Me.TbBDD.Name = "TbBDD"
        Me.TbBDD.Size = New System.Drawing.Size(165, 20)
        Me.TbBDD.TabIndex = 7
        '
        'RestaurarRespaldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 471)
        Me.Controls.Add(Me.TbBDD)
        Me.Controls.Add(Me.BtRestaurar)
        Me.Controls.Add(Me.BtSeleccionaRuta)
        Me.Controls.Add(Me.TbRutaArchivoRespaldo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RestaurarRespaldo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RestaurarRespaldo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TbRutaArchivoRespaldo As TextBox
    Friend WithEvents BtSeleccionaRuta As Button
    Friend WithEvents OfArchivoRestaurar As OpenFileDialog
    Friend WithEvents BtRestaurar As Button
    Friend WithEvents TbBDD As TextBox
End Class
