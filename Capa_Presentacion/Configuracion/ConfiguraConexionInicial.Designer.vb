<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConfiguraConexionInicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfiguraConexionInicial))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbbddperfiles = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbipservidor = New System.Windows.Forms.MaskedTextBox()
        Me.tbbdd = New System.Windows.Forms.TextBox()
        Me.rbestacion = New System.Windows.Forms.RadioButton()
        Me.rbserver = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TbOrigenPassword = New System.Windows.Forms.TextBox()
        Me.TbOrigenUsuario = New System.Windows.Forms.TextBox()
        Me.CbOrigenInstancia = New System.Windows.Forms.ComboBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbhostserver = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.tbhostserver)
        Me.Panel1.Controls.Add(Me.tbbddperfiles)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tbipservidor)
        Me.Panel1.Controls.Add(Me.tbbdd)
        Me.Panel1.Controls.Add(Me.rbestacion)
        Me.Panel1.Controls.Add(Me.rbserver)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel1.Controls.Add(Me.TbOrigenPassword)
        Me.Panel1.Controls.Add(Me.TbOrigenUsuario)
        Me.Panel1.Controls.Add(Me.CbOrigenInstancia)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(352, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(443, 439)
        Me.Panel1.TabIndex = 0
        '
        'tbbddperfiles
        '
        Me.tbbddperfiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.tbbddperfiles.Location = New System.Drawing.Point(245, 102)
        Me.tbbddperfiles.Name = "tbbddperfiles"
        Me.tbbddperfiles.Size = New System.Drawing.Size(185, 22)
        Me.tbbddperfiles.TabIndex = 1
        Me.tbbddperfiles.Text = "Perfiles"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 18)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "BASE DE DATOS PERFILES:"
        '
        'tbipservidor
        '
        Me.tbipservidor.Enabled = False
        Me.tbipservidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.tbipservidor.Location = New System.Drawing.Point(317, 255)
        Me.tbipservidor.Mask = "000.000.000.000"
        Me.tbipservidor.Name = "tbipservidor"
        Me.tbipservidor.Size = New System.Drawing.Size(113, 22)
        Me.tbipservidor.TabIndex = 7
        Me.tbipservidor.Visible = False
        '
        'tbbdd
        '
        Me.tbbdd.BackColor = System.Drawing.Color.White
        Me.tbbdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbbdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbbdd.Location = New System.Drawing.Point(245, 130)
        Me.tbbdd.Name = "tbbdd"
        Me.tbbdd.Size = New System.Drawing.Size(185, 22)
        Me.tbbdd.TabIndex = 2
        '
        'rbestacion
        '
        Me.rbestacion.AutoSize = True
        Me.rbestacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rbestacion.Location = New System.Drawing.Point(21, 286)
        Me.rbestacion.Name = "rbestacion"
        Me.rbestacion.Size = New System.Drawing.Size(109, 22)
        Me.rbestacion.TabIndex = 6
        Me.rbestacion.Text = "ESTACION"
        Me.rbestacion.UseVisualStyleBackColor = True
        '
        'rbserver
        '
        Me.rbserver.AutoSize = True
        Me.rbserver.Checked = True
        Me.rbserver.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rbserver.Location = New System.Drawing.Point(21, 254)
        Me.rbserver.Name = "rbserver"
        Me.rbserver.Size = New System.Drawing.Size(111, 22)
        Me.rbserver.TabIndex = 5
        Me.rbserver.TabStop = True
        Me.rbserver.Text = "SERVIDOR"
        Me.rbserver.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 183)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 18)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "CONTRASEÑA:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 18)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "USUARIO:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(145, 18)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "BASE DE DATOS:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 36)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "INSTANCIA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PARA DATOS:"
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.BunifuFlatButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 7
        Me.BunifuFlatButton1.ButtonText = "CREAR CONEXION"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(258, 390)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(173, 37)
        Me.BunifuFlatButton1.TabIndex = 8
        Me.BunifuFlatButton1.Text = "CREAR CONEXION"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TbOrigenPassword
        '
        Me.TbOrigenPassword.Location = New System.Drawing.Point(245, 184)
        Me.TbOrigenPassword.Name = "TbOrigenPassword"
        Me.TbOrigenPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbOrigenPassword.Size = New System.Drawing.Size(185, 20)
        Me.TbOrigenPassword.TabIndex = 4
        '
        'TbOrigenUsuario
        '
        Me.TbOrigenUsuario.Location = New System.Drawing.Point(245, 158)
        Me.TbOrigenUsuario.Name = "TbOrigenUsuario"
        Me.TbOrigenUsuario.Size = New System.Drawing.Size(185, 20)
        Me.TbOrigenUsuario.TabIndex = 3
        '
        'CbOrigenInstancia
        '
        Me.CbOrigenInstancia.FormattingEnabled = True
        Me.CbOrigenInstancia.Location = New System.Drawing.Point(143, 70)
        Me.CbOrigenInstancia.Name = "CbOrigenInstancia"
        Me.CbOrigenInstancia.Size = New System.Drawing.Size(287, 21)
        Me.CbOrigenInstancia.TabIndex = 1
        '
        'pictureBox1
        '
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(352, 439)
        Me.pictureBox1.TabIndex = 7
        Me.pictureBox1.TabStop = False
        '
        'tbhostserver
        '
        Me.tbhostserver.Enabled = False
        Me.tbhostserver.Location = New System.Drawing.Point(245, 289)
        Me.tbhostserver.Name = "tbhostserver"
        Me.tbhostserver.Size = New System.Drawing.Size(186, 20)
        Me.tbhostserver.TabIndex = 20
        '
        'ConfiguraConexionInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(795, 439)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConfiguraConexionInicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configura la conexion inicial"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CbOrigenInstancia As ComboBox
    Friend WithEvents TbOrigenUsuario As TextBox
    Friend WithEvents TbOrigenPassword As TextBox
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents tbipservidor As MaskedTextBox
    Private WithEvents tbbdd As TextBox
    Private WithEvents rbestacion As RadioButton
    Private WithEvents rbserver As RadioButton
    Private WithEvents Label10 As Label
    Private WithEvents Label11 As Label
    Private WithEvents Label12 As Label
    Private WithEvents Label13 As Label
    Friend WithEvents tbbddperfiles As TextBox
    Private WithEvents Label1 As Label
    Friend WithEvents tbhostserver As TextBox
End Class
