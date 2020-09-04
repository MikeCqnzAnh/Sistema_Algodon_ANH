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
        Me.OfArchivoRestaurar = New System.Windows.Forms.OpenFileDialog()
        Me.BtRestaurar = New System.Windows.Forms.Button()
        Me.TbBDD = New System.Windows.Forms.TextBox()
        Me.BtSelectDir = New System.Windows.Forms.Button()
        Me.TbPath = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TbPassword = New System.Windows.Forms.TextBox()
        Me.TbUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbServidor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtRestaurar
        '
        Me.BtRestaurar.Location = New System.Drawing.Point(368, 230)
        Me.BtRestaurar.Name = "BtRestaurar"
        Me.BtRestaurar.Size = New System.Drawing.Size(105, 35)
        Me.BtRestaurar.TabIndex = 6
        Me.BtRestaurar.Text = "Restaurar Base de Datos"
        Me.BtRestaurar.UseVisualStyleBackColor = True
        '
        'TbBDD
        '
        Me.TbBDD.Location = New System.Drawing.Point(96, 48)
        Me.TbBDD.Name = "TbBDD"
        Me.TbBDD.Size = New System.Drawing.Size(154, 20)
        Me.TbBDD.TabIndex = 7
        '
        'BtSelectDir
        '
        Me.BtSelectDir.Location = New System.Drawing.Point(444, 169)
        Me.BtSelectDir.Name = "BtSelectDir"
        Me.BtSelectDir.Size = New System.Drawing.Size(29, 20)
        Me.BtSelectDir.TabIndex = 34
        Me.BtSelectDir.Text = "..."
        Me.BtSelectDir.UseVisualStyleBackColor = True
        '
        'TbPath
        '
        Me.TbPath.Location = New System.Drawing.Point(96, 169)
        Me.TbPath.Name = "TbPath"
        Me.TbPath.ReadOnly = True
        Me.TbPath.Size = New System.Drawing.Size(342, 20)
        Me.TbPath.TabIndex = 31
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 172)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 13)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Respaldar en:"
        '
        'TbPassword
        '
        Me.TbPassword.Location = New System.Drawing.Point(96, 100)
        Me.TbPassword.Name = "TbPassword"
        Me.TbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbPassword.Size = New System.Drawing.Size(154, 20)
        Me.TbPassword.TabIndex = 42
        '
        'TbUsuario
        '
        Me.TbUsuario.Location = New System.Drawing.Point(96, 74)
        Me.TbUsuario.Name = "TbUsuario"
        Me.TbUsuario.Size = New System.Drawing.Size(154, 20)
        Me.TbUsuario.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Contraseña:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Servidor:"
        '
        'TbServidor
        '
        Me.TbServidor.Location = New System.Drawing.Point(96, 22)
        Me.TbServidor.Name = "TbServidor"
        Me.TbServidor.Size = New System.Drawing.Size(154, 20)
        Me.TbServidor.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Base de datos:"
        '
        'RestaurarRespaldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 277)
        Me.Controls.Add(Me.TbPassword)
        Me.Controls.Add(Me.TbUsuario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbServidor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtSelectDir)
        Me.Controls.Add(Me.TbPath)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TbBDD)
        Me.Controls.Add(Me.BtRestaurar)
        Me.Name = "RestaurarRespaldo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "0,0"
        Me.Text = "Restaurar Respaldo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OfArchivoRestaurar As OpenFileDialog
    Friend WithEvents BtRestaurar As Button
    Friend WithEvents TbBDD As TextBox
    Friend WithEvents BtSelectDir As Button
    Friend WithEvents TbPath As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TbPassword As TextBox
    Friend WithEvents TbUsuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TbServidor As TextBox
    Friend WithEvents Label2 As Label
End Class
