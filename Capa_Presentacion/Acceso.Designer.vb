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
        Me.LkCambiarClave = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CkRecuerda = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Contraseña"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(85, 329)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Base De Datos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CbBaseDeDatos
        '
        Me.CbBaseDeDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbBaseDeDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbBaseDeDatos.FormattingEnabled = True
        Me.CbBaseDeDatos.Location = New System.Drawing.Point(89, 352)
        Me.CbBaseDeDatos.Name = "CbBaseDeDatos"
        Me.CbBaseDeDatos.Size = New System.Drawing.Size(209, 28)
        Me.CbBaseDeDatos.TabIndex = 2
        '
        'TbUsuario
        '
        Me.TbUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbUsuario.Location = New System.Drawing.Point(89, 235)
        Me.TbUsuario.Name = "TbUsuario"
        Me.TbUsuario.Size = New System.Drawing.Size(209, 26)
        Me.TbUsuario.TabIndex = 0
        '
        'TbClave
        '
        Me.TbClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbClave.Location = New System.Drawing.Point(89, 293)
        Me.TbClave.MaxLength = 10
        Me.TbClave.Name = "TbClave"
        Me.TbClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbClave.Size = New System.Drawing.Size(209, 26)
        Me.TbClave.TabIndex = 1
        '
        'BtAccesar
        '
        Me.BtAccesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtAccesar.Location = New System.Drawing.Point(93, 436)
        Me.BtAccesar.Name = "BtAccesar"
        Me.BtAccesar.Size = New System.Drawing.Size(100, 32)
        Me.BtAccesar.TabIndex = 4
        Me.BtAccesar.Text = "Accesar"
        Me.BtAccesar.UseVisualStyleBackColor = True
        '
        'BtCancelar
        '
        Me.BtCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCancelar.Location = New System.Drawing.Point(202, 436)
        Me.BtCancelar.Name = "BtCancelar"
        Me.BtCancelar.Size = New System.Drawing.Size(100, 32)
        Me.BtCancelar.TabIndex = 5
        Me.BtCancelar.Text = "Cancelar"
        Me.BtCancelar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(89, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(209, 206)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'LkCambiarClave
        '
        Me.LkCambiarClave.AutoSize = True
        Me.LkCambiarClave.BackColor = System.Drawing.SystemColors.Control
        Me.LkCambiarClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LkCambiarClave.Location = New System.Drawing.Point(119, 484)
        Me.LkCambiarClave.Name = "LkCambiarClave"
        Me.LkCambiarClave.Size = New System.Drawing.Size(152, 20)
        Me.LkCambiarClave.TabIndex = 6
        Me.LkCambiarClave.TabStop = True
        Me.LkCambiarClave.Text = "Cambiar contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 525)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "0.0.0.0"
        '
        'CkRecuerda
        '
        Me.CkRecuerda.AutoSize = True
        Me.CkRecuerda.BackColor = System.Drawing.SystemColors.Control
        Me.CkRecuerda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkRecuerda.Location = New System.Drawing.Point(93, 393)
        Me.CkRecuerda.Name = "CkRecuerda"
        Me.CkRecuerda.Size = New System.Drawing.Size(197, 24)
        Me.CkRecuerda.TabIndex = 3
        Me.CkRecuerda.Text = "Recordar contraseña"
        Me.CkRecuerda.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CkRecuerda)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.LkCambiarClave)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CbBaseDeDatos)
        Me.Panel1.Controls.Add(Me.BtCancelar)
        Me.Panel1.Controls.Add(Me.TbUsuario)
        Me.Panel1.Controls.Add(Me.BtAccesar)
        Me.Panel1.Controls.Add(Me.TbClave)
        Me.Panel1.Location = New System.Drawing.Point(0, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(387, 545)
        Me.Panel1.TabIndex = 8
        '
        'Acceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(387, 587)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Acceso"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents LkCambiarClave As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents CkRecuerda As CheckBox
    Friend WithEvents Panel1 As Panel
End Class
