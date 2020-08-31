<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgramarRespaldos
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
        Me.GbInfo = New System.Windows.Forms.GroupBox()
        Me.BtSelectDir = New System.Windows.Forms.Button()
        Me.btBackup = New System.Windows.Forms.Button()
        Me.TbBackupName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TbPath = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblUnallocatedSize = New System.Windows.Forms.Label()
        Me.lblDBSize = New System.Windows.Forms.Label()
        Me.lblDBName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GbOrigen = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbNombreRespaldo = New System.Windows.Forms.TextBox()
        Me.DtFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.CbFrecuencia = New System.Windows.Forms.ComboBox()
        Me.lblConnStatus = New System.Windows.Forms.Label()
        Me.pbConnStatus = New System.Windows.Forms.PictureBox()
        Me.TbPassword = New System.Windows.Forms.TextBox()
        Me.TbUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbServidor = New System.Windows.Forms.TextBox()
        Me.BtPruebaConexion = New System.Windows.Forms.Button()
        Me.TbBDD = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbpruebahora = New System.Windows.Forms.TextBox()
        Me.TbFechaPrueba = New System.Windows.Forms.TextBox()
        Me.GbInfo.SuspendLayout()
        Me.GbOrigen.SuspendLayout()
        CType(Me.pbConnStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbInfo
        '
        Me.GbInfo.Controls.Add(Me.BtSelectDir)
        Me.GbInfo.Controls.Add(Me.btBackup)
        Me.GbInfo.Controls.Add(Me.TbBackupName)
        Me.GbInfo.Controls.Add(Me.Label17)
        Me.GbInfo.Controls.Add(Me.TbPath)
        Me.GbInfo.Controls.Add(Me.Label16)
        Me.GbInfo.Controls.Add(Me.lblUnallocatedSize)
        Me.GbInfo.Controls.Add(Me.lblDBSize)
        Me.GbInfo.Controls.Add(Me.lblDBName)
        Me.GbInfo.Controls.Add(Me.Label6)
        Me.GbInfo.Controls.Add(Me.Label8)
        Me.GbInfo.Controls.Add(Me.Label9)
        Me.GbInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbInfo.Location = New System.Drawing.Point(484, 0)
        Me.GbInfo.Name = "GbInfo"
        Me.GbInfo.Size = New System.Drawing.Size(438, 513)
        Me.GbInfo.TabIndex = 3
        Me.GbInfo.TabStop = False
        Me.GbInfo.Text = "Información de la base de datos y configuración del respaldo"
        '
        'BtSelectDir
        '
        Me.BtSelectDir.Enabled = False
        Me.BtSelectDir.Location = New System.Drawing.Point(308, 131)
        Me.BtSelectDir.Name = "BtSelectDir"
        Me.BtSelectDir.Size = New System.Drawing.Size(29, 20)
        Me.BtSelectDir.TabIndex = 29
        Me.BtSelectDir.Text = "..."
        Me.BtSelectDir.UseVisualStyleBackColor = True
        '
        'btBackup
        '
        Me.btBackup.Enabled = False
        Me.btBackup.Location = New System.Drawing.Point(6, 200)
        Me.btBackup.Name = "btBackup"
        Me.btBackup.Size = New System.Drawing.Size(296, 51)
        Me.btBackup.TabIndex = 28
        Me.btBackup.Text = "&Respaldar"
        Me.btBackup.UseVisualStyleBackColor = True
        '
        'TbBackupName
        '
        Me.TbBackupName.Enabled = False
        Me.TbBackupName.Location = New System.Drawing.Point(125, 160)
        Me.TbBackupName.Name = "TbBackupName"
        Me.TbBackupName.Size = New System.Drawing.Size(177, 20)
        Me.TbBackupName.TabIndex = 27
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 163)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 13)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Nombre del archivo:"
        '
        'TbPath
        '
        Me.TbPath.Location = New System.Drawing.Point(125, 132)
        Me.TbPath.Name = "TbPath"
        Me.TbPath.ReadOnly = True
        Me.TbPath.Size = New System.Drawing.Size(177, 20)
        Me.TbPath.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 135)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 13)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Respaldar en:"
        '
        'lblUnallocatedSize
        '
        Me.lblUnallocatedSize.AutoSize = True
        Me.lblUnallocatedSize.ForeColor = System.Drawing.Color.Teal
        Me.lblUnallocatedSize.Location = New System.Drawing.Point(122, 97)
        Me.lblUnallocatedSize.Name = "lblUnallocatedSize"
        Me.lblUnallocatedSize.Size = New System.Drawing.Size(16, 13)
        Me.lblUnallocatedSize.TabIndex = 24
        Me.lblUnallocatedSize.Text = "..."
        '
        'lblDBSize
        '
        Me.lblDBSize.AutoSize = True
        Me.lblDBSize.ForeColor = System.Drawing.Color.Teal
        Me.lblDBSize.Location = New System.Drawing.Point(122, 78)
        Me.lblDBSize.Name = "lblDBSize"
        Me.lblDBSize.Size = New System.Drawing.Size(16, 13)
        Me.lblDBSize.TabIndex = 22
        Me.lblDBSize.Text = "..."
        '
        'lblDBName
        '
        Me.lblDBName.AutoSize = True
        Me.lblDBName.ForeColor = System.Drawing.Color.Teal
        Me.lblDBName.Location = New System.Drawing.Point(122, 59)
        Me.lblDBName.Name = "lblDBName"
        Me.lblDBName.Size = New System.Drawing.Size(16, 13)
        Me.lblDBName.TabIndex = 21
        Me.lblDBName.Text = "..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Espacio no asignado:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Tamaño total:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Nombre:"
        '
        'GbOrigen
        '
        Me.GbOrigen.Controls.Add(Me.TbFechaPrueba)
        Me.GbOrigen.Controls.Add(Me.tbpruebahora)
        Me.GbOrigen.Controls.Add(Me.Label10)
        Me.GbOrigen.Controls.Add(Me.Label2)
        Me.GbOrigen.Controls.Add(Me.Label1)
        Me.GbOrigen.Controls.Add(Me.TbNombreRespaldo)
        Me.GbOrigen.Controls.Add(Me.DtFechaInicio)
        Me.GbOrigen.Controls.Add(Me.CbFrecuencia)
        Me.GbOrigen.Controls.Add(Me.lblConnStatus)
        Me.GbOrigen.Controls.Add(Me.pbConnStatus)
        Me.GbOrigen.Controls.Add(Me.TbPassword)
        Me.GbOrigen.Controls.Add(Me.TbUsuario)
        Me.GbOrigen.Controls.Add(Me.Label5)
        Me.GbOrigen.Controls.Add(Me.Label4)
        Me.GbOrigen.Controls.Add(Me.Label3)
        Me.GbOrigen.Controls.Add(Me.TbServidor)
        Me.GbOrigen.Controls.Add(Me.BtPruebaConexion)
        Me.GbOrigen.Controls.Add(Me.TbBDD)
        Me.GbOrigen.Controls.Add(Me.Label7)
        Me.GbOrigen.Dock = System.Windows.Forms.DockStyle.Left
        Me.GbOrigen.Location = New System.Drawing.Point(0, 0)
        Me.GbOrigen.Name = "GbOrigen"
        Me.GbOrigen.Size = New System.Drawing.Size(484, 513)
        Me.GbOrigen.TabIndex = 2
        Me.GbOrigen.TabStop = False
        Me.GbOrigen.Text = "Configuracion de la conexion"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 342)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Sucede una vez a la(s):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Sucede:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nombre:"
        '
        'TbNombreRespaldo
        '
        Me.TbNombreRespaldo.Location = New System.Drawing.Point(137, 283)
        Me.TbNombreRespaldo.Name = "TbNombreRespaldo"
        Me.TbNombreRespaldo.Size = New System.Drawing.Size(312, 20)
        Me.TbNombreRespaldo.TabIndex = 16
        '
        'DtFechaInicio
        '
        Me.DtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DtFechaInicio.Location = New System.Drawing.Point(137, 336)
        Me.DtFechaInicio.Name = "DtFechaInicio"
        Me.DtFechaInicio.Size = New System.Drawing.Size(113, 20)
        Me.DtFechaInicio.TabIndex = 15
        Me.DtFechaInicio.Value = New Date(2020, 8, 28, 0, 0, 0, 0)
        '
        'CbFrecuencia
        '
        Me.CbFrecuencia.FormattingEnabled = True
        Me.CbFrecuencia.Location = New System.Drawing.Point(137, 309)
        Me.CbFrecuencia.Name = "CbFrecuencia"
        Me.CbFrecuencia.Size = New System.Drawing.Size(166, 21)
        Me.CbFrecuencia.TabIndex = 14
        '
        'lblConnStatus
        '
        Me.lblConnStatus.Location = New System.Drawing.Point(15, 225)
        Me.lblConnStatus.Name = "lblConnStatus"
        Me.lblConnStatus.Size = New System.Drawing.Size(235, 37)
        Me.lblConnStatus.TabIndex = 13
        Me.lblConnStatus.Text = "Conexión no comprobada"
        Me.lblConnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbConnStatus
        '
        Me.pbConnStatus.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.light_yellow
        Me.pbConnStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbConnStatus.Location = New System.Drawing.Point(202, 174)
        Me.pbConnStatus.Name = "pbConnStatus"
        Me.pbConnStatus.Size = New System.Drawing.Size(48, 48)
        Me.pbConnStatus.TabIndex = 12
        Me.pbConnStatus.TabStop = False
        '
        'TbPassword
        '
        Me.TbPassword.Location = New System.Drawing.Point(96, 134)
        Me.TbPassword.Name = "TbPassword"
        Me.TbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbPassword.Size = New System.Drawing.Size(154, 20)
        Me.TbPassword.TabIndex = 11
        '
        'TbUsuario
        '
        Me.TbUsuario.Location = New System.Drawing.Point(96, 108)
        Me.TbUsuario.Name = "TbUsuario"
        Me.TbUsuario.Size = New System.Drawing.Size(154, 20)
        Me.TbUsuario.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Contraseña:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Servidor:"
        '
        'TbServidor
        '
        Me.TbServidor.Location = New System.Drawing.Point(96, 56)
        Me.TbServidor.Name = "TbServidor"
        Me.TbServidor.Size = New System.Drawing.Size(154, 20)
        Me.TbServidor.TabIndex = 6
        '
        'BtPruebaConexion
        '
        Me.BtPruebaConexion.Location = New System.Drawing.Point(15, 174)
        Me.BtPruebaConexion.Name = "BtPruebaConexion"
        Me.BtPruebaConexion.Size = New System.Drawing.Size(181, 48)
        Me.BtPruebaConexion.TabIndex = 5
        Me.BtPruebaConexion.Text = "Probar Conexion"
        Me.BtPruebaConexion.UseVisualStyleBackColor = True
        '
        'TbBDD
        '
        Me.TbBDD.Location = New System.Drawing.Point(96, 82)
        Me.TbBDD.Name = "TbBDD"
        Me.TbBDD.Size = New System.Drawing.Size(154, 20)
        Me.TbBDD.TabIndex = 2
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
        'tbpruebahora
        '
        Me.tbpruebahora.Location = New System.Drawing.Point(15, 399)
        Me.tbpruebahora.Name = "tbpruebahora"
        Me.tbpruebahora.Size = New System.Drawing.Size(166, 20)
        Me.tbpruebahora.TabIndex = 20
        '
        'TbFechaPrueba
        '
        Me.TbFechaPrueba.Location = New System.Drawing.Point(15, 434)
        Me.TbFechaPrueba.Name = "TbFechaPrueba"
        Me.TbFechaPrueba.Size = New System.Drawing.Size(166, 20)
        Me.TbFechaPrueba.TabIndex = 21
        '
        'ProgramarRespaldos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 513)
        Me.Controls.Add(Me.GbInfo)
        Me.Controls.Add(Me.GbOrigen)
        Me.Name = "ProgramarRespaldos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Programar Respaldos Automaticos"
        Me.GbInfo.ResumeLayout(False)
        Me.GbInfo.PerformLayout()
        Me.GbOrigen.ResumeLayout(False)
        Me.GbOrigen.PerformLayout()
        CType(Me.pbConnStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbInfo As GroupBox
    Friend WithEvents BtSelectDir As Button
    Friend WithEvents btBackup As Button
    Friend WithEvents TbBackupName As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TbPath As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents lblUnallocatedSize As Label
    Friend WithEvents lblDBSize As Label
    Friend WithEvents lblDBName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GbOrigen As GroupBox
    Protected WithEvents lblConnStatus As Label
    Friend WithEvents pbConnStatus As PictureBox
    Friend WithEvents TbPassword As TextBox
    Friend WithEvents TbUsuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TbServidor As TextBox
    Friend WithEvents BtPruebaConexion As Button
    Friend WithEvents TbBDD As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DtFechaInicio As DateTimePicker
    Friend WithEvents CbFrecuencia As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TbNombreRespaldo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TbFechaPrueba As TextBox
    Friend WithEvents tbpruebahora As TextBox
End Class
