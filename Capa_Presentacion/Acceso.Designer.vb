<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Acceso
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Acceso))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbBaseDeDatos = New System.Windows.Forms.ComboBox()
        Me.TbUsuario = New System.Windows.Forms.TextBox()
        Me.TbClave = New System.Windows.Forms.TextBox()
        Me.BtAccesar = New System.Windows.Forms.Button()
        Me.BtCancelar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(187, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(187, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(187, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Base De Datos:"
        '
        'CbBaseDeDatos
        '
        Me.CbBaseDeDatos.FormattingEnabled = True
        Me.CbBaseDeDatos.Location = New System.Drawing.Point(269, 159)
        Me.CbBaseDeDatos.Name = "CbBaseDeDatos"
        Me.CbBaseDeDatos.Size = New System.Drawing.Size(168, 21)
        Me.CbBaseDeDatos.TabIndex = 2
        '
        'TbUsuario
        '
        Me.TbUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbUsuario.Location = New System.Drawing.Point(269, 94)
        Me.TbUsuario.Name = "TbUsuario"
        Me.TbUsuario.Size = New System.Drawing.Size(168, 20)
        Me.TbUsuario.TabIndex = 0
        '
        'TbClave
        '
        Me.TbClave.Location = New System.Drawing.Point(269, 126)
        Me.TbClave.Name = "TbClave"
        Me.TbClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbClave.Size = New System.Drawing.Size(168, 20)
        Me.TbClave.TabIndex = 1
        '
        'BtAccesar
        '
        Me.BtAccesar.Location = New System.Drawing.Point(269, 206)
        Me.BtAccesar.Name = "BtAccesar"
        Me.BtAccesar.Size = New System.Drawing.Size(75, 23)
        Me.BtAccesar.TabIndex = 3
        Me.BtAccesar.Text = "Accesar"
        Me.BtAccesar.UseVisualStyleBackColor = True
        '
        'BtCancelar
        '
        Me.BtCancelar.Location = New System.Drawing.Point(362, 206)
        Me.BtCancelar.Name = "BtCancelar"
        Me.BtCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtCancelar.TabIndex = 4
        Me.BtCancelar.Text = "Cancelar"
        Me.BtCancelar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(169, 166)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Acceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 274)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtCancelar)
        Me.Controls.Add(Me.BtAccesar)
        Me.Controls.Add(Me.TbClave)
        Me.Controls.Add(Me.TbUsuario)
        Me.Controls.Add(Me.CbBaseDeDatos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Acceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CbBaseDeDatos As ComboBox
    Friend WithEvents TbUsuario As TextBox
    Friend WithEvents TbClave As TextBox
    Friend WithEvents BtAccesar As Button
    Friend WithEvents BtCancelar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
