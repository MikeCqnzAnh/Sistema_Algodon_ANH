<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaveAutorizacion
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
        Me.TbClave = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtActualizarClave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TbClave
        '
        Me.TbClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbClave.Location = New System.Drawing.Point(212, 99)
        Me.TbClave.MaxLength = 4
        Me.TbClave.Name = "TbClave"
        Me.TbClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbClave.Size = New System.Drawing.Size(219, 49)
        Me.TbClave.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 42)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Clave:"
        '
        'BtActualizarClave
        '
        Me.BtActualizarClave.Location = New System.Drawing.Point(437, 118)
        Me.BtActualizarClave.Name = "BtActualizarClave"
        Me.BtActualizarClave.Size = New System.Drawing.Size(35, 30)
        Me.BtActualizarClave.TabIndex = 6
        Me.BtActualizarClave.Text = "..."
        Me.BtActualizarClave.UseVisualStyleBackColor = True
        '
        'ClaveAutorizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 296)
        Me.Controls.Add(Me.BtActualizarClave)
        Me.Controls.Add(Me.TbClave)
        Me.Controls.Add(Me.Label2)
        Me.MaximumSize = New System.Drawing.Size(551, 335)
        Me.MinimumSize = New System.Drawing.Size(551, 335)
        Me.Name = "ClaveAutorizacion"
        Me.Text = "ClaveAutorizacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbClave As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtActualizarClave As Button
End Class
