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
        Me.pbProgreso = New System.Windows.Forms.ProgressBar()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.btnProbar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnCancelar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.tbbddperfiles = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIpServidor = New System.Windows.Forms.MaskedTextBox()
        Me.txtBaseDatos = New System.Windows.Forms.TextBox()
        Me.RbEstacion = New System.Windows.Forms.RadioButton()
        Me.rbServidor = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnGuardar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.cbInstancia = New System.Windows.Forms.ComboBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.pbProgreso)
        Me.Panel1.Controls.Add(Me.lblMensaje)
        Me.Panel1.Controls.Add(Me.btnProbar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.tbbddperfiles)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtIpServidor)
        Me.Panel1.Controls.Add(Me.txtBaseDatos)
        Me.Panel1.Controls.Add(Me.RbEstacion)
        Me.Panel1.Controls.Add(Me.rbServidor)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Controls.Add(Me.cbInstancia)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(285, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 439)
        Me.Panel1.TabIndex = 0
        '
        'pbProgreso
        '
        Me.pbProgreso.Location = New System.Drawing.Point(9, 361)
        Me.pbProgreso.Name = "pbProgreso"
        Me.pbProgreso.Size = New System.Drawing.Size(489, 23)
        Me.pbProgreso.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pbProgreso.TabIndex = 24
        Me.pbProgreso.Visible = False
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Location = New System.Drawing.Point(20, 296)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(0, 13)
        Me.lblMensaje.TabIndex = 23
        '
        'btnProbar
        '
        Me.btnProbar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnProbar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnProbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProbar.BorderRadius = 7
        Me.btnProbar.ButtonText = "Probar"
        Me.btnProbar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProbar.DisabledColor = System.Drawing.Color.Gray
        Me.btnProbar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnProbar.Iconimage = Nothing
        Me.btnProbar.Iconimage_right = Nothing
        Me.btnProbar.Iconimage_right_Selected = Nothing
        Me.btnProbar.Iconimage_Selected = Nothing
        Me.btnProbar.IconMarginLeft = 0
        Me.btnProbar.IconMarginRight = 0
        Me.btnProbar.IconRightVisible = True
        Me.btnProbar.IconRightZoom = 0R
        Me.btnProbar.IconVisible = True
        Me.btnProbar.IconZoom = 90.0R
        Me.btnProbar.IsTab = False
        Me.btnProbar.Location = New System.Drawing.Point(167, 390)
        Me.btnProbar.Name = "btnProbar"
        Me.btnProbar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnProbar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnProbar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnProbar.selected = False
        Me.btnProbar.Size = New System.Drawing.Size(128, 37)
        Me.btnProbar.TabIndex = 9
        Me.btnProbar.Text = "Probar"
        Me.btnProbar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnProbar.Textcolor = System.Drawing.Color.Black
        Me.btnProbar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        '
        'btnCancelar
        '
        Me.btnCancelar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelar.BorderRadius = 7
        Me.btnCancelar.ButtonText = "Cancelar"
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.DisabledColor = System.Drawing.Color.Gray
        Me.btnCancelar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCancelar.Iconimage = Nothing
        Me.btnCancelar.Iconimage_right = Nothing
        Me.btnCancelar.Iconimage_right_Selected = Nothing
        Me.btnCancelar.Iconimage_Selected = Nothing
        Me.btnCancelar.IconMarginLeft = 0
        Me.btnCancelar.IconMarginRight = 0
        Me.btnCancelar.IconRightVisible = True
        Me.btnCancelar.IconRightZoom = 0R
        Me.btnCancelar.IconVisible = True
        Me.btnCancelar.IconZoom = 90.0R
        Me.btnCancelar.IsTab = False
        Me.btnCancelar.Location = New System.Drawing.Point(9, 390)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnCancelar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnCancelar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCancelar.selected = False
        Me.btnCancelar.Size = New System.Drawing.Size(128, 37)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCancelar.Textcolor = System.Drawing.Color.Black
        Me.btnCancelar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
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
        'txtIpServidor
        '
        Me.txtIpServidor.Enabled = False
        Me.txtIpServidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtIpServidor.Location = New System.Drawing.Point(245, 256)
        Me.txtIpServidor.Mask = "000.000.000.000"
        Me.txtIpServidor.Name = "txtIpServidor"
        Me.txtIpServidor.Size = New System.Drawing.Size(113, 22)
        Me.txtIpServidor.TabIndex = 7
        Me.txtIpServidor.Visible = False
        '
        'txtBaseDatos
        '
        Me.txtBaseDatos.BackColor = System.Drawing.Color.White
        Me.txtBaseDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBaseDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaseDatos.Location = New System.Drawing.Point(245, 130)
        Me.txtBaseDatos.Name = "txtBaseDatos"
        Me.txtBaseDatos.Size = New System.Drawing.Size(185, 22)
        Me.txtBaseDatos.TabIndex = 2
        '
        'RbEstacion
        '
        Me.RbEstacion.AutoSize = True
        Me.RbEstacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.RbEstacion.Location = New System.Drawing.Point(9, 256)
        Me.RbEstacion.Name = "RbEstacion"
        Me.RbEstacion.Size = New System.Drawing.Size(109, 22)
        Me.RbEstacion.TabIndex = 6
        Me.RbEstacion.Text = "ESTACION"
        Me.RbEstacion.UseVisualStyleBackColor = True
        '
        'rbServidor
        '
        Me.rbServidor.AutoSize = True
        Me.rbServidor.Checked = True
        Me.rbServidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.rbServidor.Location = New System.Drawing.Point(9, 224)
        Me.rbServidor.Name = "rbServidor"
        Me.rbServidor.Size = New System.Drawing.Size(111, 22)
        Me.rbServidor.TabIndex = 5
        Me.rbServidor.TabStop = True
        Me.rbServidor.Text = "SERVIDOR"
        Me.rbServidor.UseVisualStyleBackColor = True
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
        'btnGuardar
        '
        Me.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.BorderRadius = 7
        Me.btnGuardar.ButtonText = "Guardar"
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.DisabledColor = System.Drawing.Color.Gray
        Me.btnGuardar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnGuardar.Iconimage = Nothing
        Me.btnGuardar.Iconimage_right = Nothing
        Me.btnGuardar.Iconimage_right_Selected = Nothing
        Me.btnGuardar.Iconimage_Selected = Nothing
        Me.btnGuardar.IconMarginLeft = 0
        Me.btnGuardar.IconMarginRight = 0
        Me.btnGuardar.IconRightVisible = True
        Me.btnGuardar.IconRightZoom = 0R
        Me.btnGuardar.IconVisible = True
        Me.btnGuardar.IconZoom = 90.0R
        Me.btnGuardar.IsTab = False
        Me.btnGuardar.Location = New System.Drawing.Point(325, 390)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btnGuardar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnGuardar.selected = False
        Me.btnGuardar.Size = New System.Drawing.Size(173, 37)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGuardar.Textcolor = System.Drawing.Color.Black
        Me.btnGuardar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(245, 184)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(185, 20)
        Me.txtPassword.TabIndex = 4
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(245, 158)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(185, 20)
        Me.txtUsuario.TabIndex = 3
        '
        'cbInstancia
        '
        Me.cbInstancia.FormattingEnabled = True
        Me.cbInstancia.Location = New System.Drawing.Point(143, 70)
        Me.cbInstancia.Name = "cbInstancia"
        Me.cbInstancia.Size = New System.Drawing.Size(287, 21)
        Me.cbInstancia.TabIndex = 0
        '
        'pictureBox1
        '
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(285, 439)
        Me.pictureBox1.TabIndex = 7
        Me.pictureBox1.TabStop = False
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
    Friend WithEvents cbInstancia As ComboBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtPassword As TextBox
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents btnGuardar As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents txtIpServidor As MaskedTextBox
    Private WithEvents txtBaseDatos As TextBox
    Private WithEvents RbEstacion As RadioButton
    Private WithEvents rbServidor As RadioButton
    Private WithEvents Label10 As Label
    Private WithEvents Label11 As Label
    Private WithEvents Label12 As Label
    Private WithEvents Label13 As Label
    Friend WithEvents tbbddperfiles As TextBox
    Private WithEvents Label1 As Label
    Friend WithEvents btnCancelar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnProbar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblMensaje As Label
    Friend WithEvents pbProgreso As ProgressBar
End Class
