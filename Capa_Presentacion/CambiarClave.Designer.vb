<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambiarClave
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
        Me.TbUsuario = New System.Windows.Forms.TextBox()
        Me.TbClaveActual = New System.Windows.Forms.TextBox()
        Me.TbClaveNueva = New System.Windows.Forms.TextBox()
        Me.TbClaveConfirma = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtAceptar = New System.Windows.Forms.Button()
        Me.BtCancelar = New System.Windows.Forms.Button()
        Me.LbConfirmaClave = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TbUsuario
        '
        Me.TbUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbUsuario.Location = New System.Drawing.Point(161, 28)
        Me.TbUsuario.MaxLength = 15
        Me.TbUsuario.Name = "TbUsuario"
        Me.TbUsuario.Size = New System.Drawing.Size(174, 20)
        Me.TbUsuario.TabIndex = 0
        '
        'TbClaveActual
        '
        Me.TbClaveActual.Location = New System.Drawing.Point(161, 73)
        Me.TbClaveActual.MaxLength = 10
        Me.TbClaveActual.Name = "TbClaveActual"
        Me.TbClaveActual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbClaveActual.Size = New System.Drawing.Size(174, 20)
        Me.TbClaveActual.TabIndex = 1
        '
        'TbClaveNueva
        '
        Me.TbClaveNueva.Location = New System.Drawing.Point(161, 119)
        Me.TbClaveNueva.MaxLength = 10
        Me.TbClaveNueva.Name = "TbClaveNueva"
        Me.TbClaveNueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbClaveNueva.Size = New System.Drawing.Size(174, 20)
        Me.TbClaveNueva.TabIndex = 2
        '
        'TbClaveConfirma
        '
        Me.TbClaveConfirma.Location = New System.Drawing.Point(161, 165)
        Me.TbClaveConfirma.MaxLength = 10
        Me.TbClaveConfirma.Name = "TbClaveConfirma"
        Me.TbClaveConfirma.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbClaveConfirma.Size = New System.Drawing.Size(174, 20)
        Me.TbClaveConfirma.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nueva Contraseña:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Confirma Contraseña:"
        '
        'BtAceptar
        '
        Me.BtAceptar.Location = New System.Drawing.Point(139, 221)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtAceptar.TabIndex = 4
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'BtCancelar
        '
        Me.BtCancelar.Location = New System.Drawing.Point(263, 221)
        Me.BtCancelar.Name = "BtCancelar"
        Me.BtCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtCancelar.TabIndex = 5
        Me.BtCancelar.Text = "Cancelar"
        Me.BtCancelar.UseVisualStyleBackColor = True
        '
        'LbConfirmaClave
        '
        Me.LbConfirmaClave.AutoSize = True
        Me.LbConfirmaClave.Location = New System.Drawing.Point(12, 193)
        Me.LbConfirmaClave.Name = "LbConfirmaClave"
        Me.LbConfirmaClave.Size = New System.Drawing.Size(0, 13)
        Me.LbConfirmaClave.TabIndex = 3
        Me.LbConfirmaClave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CambiarClave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 256)
        Me.Controls.Add(Me.LbConfirmaClave)
        Me.Controls.Add(Me.BtCancelar)
        Me.Controls.Add(Me.BtAceptar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbClaveConfirma)
        Me.Controls.Add(Me.TbClaveNueva)
        Me.Controls.Add(Me.TbClaveActual)
        Me.Controls.Add(Me.TbUsuario)
        Me.Name = "CambiarClave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cambiar Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbUsuario As TextBox
    Friend WithEvents TbClaveActual As TextBox
    Friend WithEvents TbClaveNueva As TextBox
    Friend WithEvents TbClaveConfirma As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtAceptar As Button
    Friend WithEvents BtCancelar As Button
    Friend WithEvents LbConfirmaClave As Label
End Class
