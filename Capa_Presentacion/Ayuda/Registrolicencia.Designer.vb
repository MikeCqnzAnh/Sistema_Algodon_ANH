<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrolicencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrolicencia))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.cbestatus = New System.Windows.Forms.ComboBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.btlimpiar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btpegar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.label4 = New System.Windows.Forms.Label()
        Me.tbcantidad = New System.Windows.Forms.TextBox()
        Me.cbperiodo = New System.Windows.Forms.ComboBox()
        Me.dtfechavencimiento = New System.Windows.Forms.DateTimePicker()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbestatuslicencia = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btcancelar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btaceptar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.tbtelefono = New System.Windows.Forms.MaskedTextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tbnombrecontacto = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tblicencia = New System.Windows.Forms.MaskedTextBox()
        Me.label21 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.tbemail = New System.Windows.Forms.TextBox()
        Me.tbnombre = New System.Windows.Forms.TextBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.cbestatus)
        Me.panel1.Controls.Add(Me.label8)
        Me.panel1.Controls.Add(Me.btlimpiar)
        Me.panel1.Controls.Add(Me.btpegar)
        Me.panel1.Controls.Add(Me.label4)
        Me.panel1.Controls.Add(Me.tbcantidad)
        Me.panel1.Controls.Add(Me.cbperiodo)
        Me.panel1.Controls.Add(Me.dtfechavencimiento)
        Me.panel1.Controls.Add(Me.label6)
        Me.panel1.Controls.Add(Me.label5)
        Me.panel1.Controls.Add(Me.groupBox1)
        Me.panel1.Controls.Add(Me.tblicencia)
        Me.panel1.Controls.Add(Me.label21)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.label7)
        Me.panel1.Controls.Add(Me.tbemail)
        Me.panel1.Controls.Add(Me.tbnombre)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(352, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(574, 440)
        Me.panel1.TabIndex = 122
        '
        'cbestatus
        '
        Me.cbestatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbestatus.Enabled = False
        Me.cbestatus.FormattingEnabled = True
        Me.cbestatus.Location = New System.Drawing.Point(147, 187)
        Me.cbestatus.Name = "cbestatus"
        Me.cbestatus.Size = New System.Drawing.Size(121, 21)
        Me.cbestatus.TabIndex = 129
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(12, 190)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(42, 13)
        Me.label8.TabIndex = 128
        Me.label8.Text = "Estatus"
        '
        'btlimpiar
        '
        Me.btlimpiar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btlimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btlimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btlimpiar.BorderRadius = 7
        Me.btlimpiar.ButtonText = "Limpiar"
        Me.btlimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btlimpiar.DisabledColor = System.Drawing.Color.Gray
        Me.btlimpiar.Iconcolor = System.Drawing.Color.Transparent
        Me.btlimpiar.Iconimage = Nothing
        Me.btlimpiar.Iconimage_right = Nothing
        Me.btlimpiar.Iconimage_right_Selected = Nothing
        Me.btlimpiar.Iconimage_Selected = Nothing
        Me.btlimpiar.IconMarginLeft = 0
        Me.btlimpiar.IconMarginRight = 0
        Me.btlimpiar.IconRightVisible = True
        Me.btlimpiar.IconRightZoom = 0R
        Me.btlimpiar.IconVisible = True
        Me.btlimpiar.IconZoom = 90.0R
        Me.btlimpiar.IsTab = False
        Me.btlimpiar.Location = New System.Drawing.Point(480, 107)
        Me.btlimpiar.Name = "btlimpiar"
        Me.btlimpiar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btlimpiar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btlimpiar.OnHoverTextColor = System.Drawing.Color.White
        Me.btlimpiar.selected = False
        Me.btlimpiar.Size = New System.Drawing.Size(80, 25)
        Me.btlimpiar.TabIndex = 118
        Me.btlimpiar.Text = "Limpiar"
        Me.btlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btlimpiar.Textcolor = System.Drawing.Color.Black
        Me.btlimpiar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btpegar
        '
        Me.btpegar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btpegar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btpegar.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btpegar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btpegar.BorderRadius = 7
        Me.btpegar.ButtonText = "Pegar"
        Me.btpegar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btpegar.DisabledColor = System.Drawing.Color.Gray
        Me.btpegar.Iconcolor = System.Drawing.Color.Transparent
        Me.btpegar.Iconimage = Nothing
        Me.btpegar.Iconimage_right = Nothing
        Me.btpegar.Iconimage_right_Selected = Nothing
        Me.btpegar.Iconimage_Selected = Nothing
        Me.btpegar.IconMarginLeft = 0
        Me.btpegar.IconMarginRight = 0
        Me.btpegar.IconRightVisible = True
        Me.btpegar.IconRightZoom = 0R
        Me.btpegar.IconVisible = True
        Me.btpegar.IconZoom = 90.0R
        Me.btpegar.IsTab = False
        Me.btpegar.Location = New System.Drawing.Point(311, 107)
        Me.btpegar.Name = "btpegar"
        Me.btpegar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btpegar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btpegar.OnHoverTextColor = System.Drawing.Color.White
        Me.btpegar.selected = False
        Me.btpegar.Size = New System.Drawing.Size(80, 25)
        Me.btpegar.TabIndex = 118
        Me.btpegar.Text = "Pegar"
        Me.btpegar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btpegar.Textcolor = System.Drawing.Color.Black
        Me.btpegar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(324, 112)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(0, 13)
        Me.label4.TabIndex = 127
        '
        'tbcantidad
        '
        Me.tbcantidad.Enabled = False
        Me.tbcantidad.Location = New System.Drawing.Point(147, 135)
        Me.tbcantidad.Name = "tbcantidad"
        Me.tbcantidad.Size = New System.Drawing.Size(59, 20)
        Me.tbcantidad.TabIndex = 3
        '
        'cbperiodo
        '
        Me.cbperiodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbperiodo.Enabled = False
        Me.cbperiodo.FormattingEnabled = True
        Me.cbperiodo.Location = New System.Drawing.Point(212, 134)
        Me.cbperiodo.Name = "cbperiodo"
        Me.cbperiodo.Size = New System.Drawing.Size(147, 21)
        Me.cbperiodo.TabIndex = 4
        '
        'dtfechavencimiento
        '
        Me.dtfechavencimiento.CustomFormat = "dd/MM/yyyy"
        Me.dtfechavencimiento.Enabled = False
        Me.dtfechavencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfechavencimiento.Location = New System.Drawing.Point(147, 161)
        Me.dtfechavencimiento.Name = "dtfechavencimiento"
        Me.dtfechavencimiento.Size = New System.Drawing.Size(111, 20)
        Me.dtfechavencimiento.TabIndex = 5
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(12, 163)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(48, 13)
        Me.label6.TabIndex = 122
        Me.label6.Text = "Vigencia"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(12, 138)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(100, 13)
        Me.label5.TabIndex = 121
        Me.label5.Text = "Tiempo de Licencia"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.lbestatuslicencia)
        Me.groupBox1.Controls.Add(Me.btcancelar)
        Me.groupBox1.Controls.Add(Me.btaceptar)
        Me.groupBox1.Controls.Add(Me.tbtelefono)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.tbnombrecontacto)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.groupBox1.Location = New System.Drawing.Point(0, 239)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(574, 201)
        Me.groupBox1.TabIndex = 116
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Contacto"
        '
        'lbestatuslicencia
        '
        Me.lbestatuslicencia.AutoSize = True
        Me.lbestatuslicencia.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbestatuslicencia.Location = New System.Drawing.Point(233, 78)
        Me.lbestatuslicencia.Name = "lbestatuslicencia"
        Me.lbestatuslicencia.Size = New System.Drawing.Size(109, 24)
        Me.lbestatuslicencia.TabIndex = 118
        Me.lbestatuslicencia.Text = "Lbestatus"
        Me.lbestatuslicencia.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btcancelar
        '
        Me.btcancelar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btcancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btcancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btcancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btcancelar.BorderRadius = 7
        Me.btcancelar.ButtonText = "CANCELAR"
        Me.btcancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btcancelar.DisabledColor = System.Drawing.Color.Gray
        Me.btcancelar.Iconcolor = System.Drawing.Color.Transparent
        Me.btcancelar.Iconimage = Nothing
        Me.btcancelar.Iconimage_right = Nothing
        Me.btcancelar.Iconimage_right_Selected = Nothing
        Me.btcancelar.Iconimage_Selected = Nothing
        Me.btcancelar.IconMarginLeft = 0
        Me.btcancelar.IconMarginRight = 0
        Me.btcancelar.IconRightVisible = True
        Me.btcancelar.IconRightZoom = 0R
        Me.btcancelar.IconVisible = True
        Me.btcancelar.IconZoom = 90.0R
        Me.btcancelar.IsTab = False
        Me.btcancelar.Location = New System.Drawing.Point(349, 152)
        Me.btcancelar.Name = "btcancelar"
        Me.btcancelar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btcancelar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btcancelar.OnHoverTextColor = System.Drawing.Color.White
        Me.btcancelar.selected = False
        Me.btcancelar.Size = New System.Drawing.Size(128, 37)
        Me.btcancelar.TabIndex = 117
        Me.btcancelar.Text = "CANCELAR"
        Me.btcancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btcancelar.Textcolor = System.Drawing.Color.Black
        Me.btcancelar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btaceptar
        '
        Me.btaceptar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btaceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btaceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btaceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btaceptar.BorderRadius = 7
        Me.btaceptar.ButtonText = "ACEPTAR"
        Me.btaceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btaceptar.DisabledColor = System.Drawing.Color.Gray
        Me.btaceptar.Iconcolor = System.Drawing.Color.Transparent
        Me.btaceptar.Iconimage = Nothing
        Me.btaceptar.Iconimage_right = Nothing
        Me.btaceptar.Iconimage_right_Selected = Nothing
        Me.btaceptar.Iconimage_Selected = Nothing
        Me.btaceptar.IconMarginLeft = 0
        Me.btaceptar.IconMarginRight = 0
        Me.btaceptar.IconRightVisible = True
        Me.btaceptar.IconRightZoom = 0R
        Me.btaceptar.IconVisible = True
        Me.btaceptar.IconZoom = 90.0R
        Me.btaceptar.IsTab = False
        Me.btaceptar.Location = New System.Drawing.Point(147, 152)
        Me.btaceptar.Name = "btaceptar"
        Me.btaceptar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btaceptar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btaceptar.OnHoverTextColor = System.Drawing.Color.White
        Me.btaceptar.selected = False
        Me.btaceptar.Size = New System.Drawing.Size(128, 37)
        Me.btaceptar.TabIndex = 116
        Me.btaceptar.Text = "ACEPTAR"
        Me.btaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btaceptar.Textcolor = System.Drawing.Color.Black
        Me.btaceptar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tbtelefono
        '
        Me.tbtelefono.Location = New System.Drawing.Point(150, 45)
        Me.tbtelefono.Mask = "000-000-0000"
        Me.tbtelefono.Name = "tbtelefono"
        Me.tbtelefono.Size = New System.Drawing.Size(84, 20)
        Me.tbtelefono.TabIndex = 1
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(15, 48)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(56, 13)
        Me.label2.TabIndex = 115
        Me.label2.Text = "* Telefono"
        '
        'tbnombrecontacto
        '
        Me.tbnombrecontacto.Location = New System.Drawing.Point(150, 19)
        Me.tbnombrecontacto.MaxLength = 100
        Me.tbnombrecontacto.Name = "tbnombrecontacto"
        Me.tbnombrecontacto.Size = New System.Drawing.Size(413, 20)
        Me.tbnombrecontacto.TabIndex = 0
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(15, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(51, 13)
        Me.label1.TabIndex = 113
        Me.label1.Text = "* Nombre"
        '
        'tblicencia
        '
        Me.tblicencia.Location = New System.Drawing.Point(147, 109)
        Me.tblicencia.Mask = "AAAA-AAAA-AAAA-AAAA"
        Me.tblicencia.Name = "tblicencia"
        Me.tblicencia.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.tblicencia.ReadOnly = True
        Me.tblicencia.Size = New System.Drawing.Size(158, 20)
        Me.tblicencia.SkipLiterals = False
        Me.tblicencia.TabIndex = 2
        Me.tblicencia.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'label21
        '
        Me.label21.AutoSize = True
        Me.label21.Location = New System.Drawing.Point(12, 60)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(129, 13)
        Me.label21.TabIndex = 109
        Me.label21.Text = "* Nombre o Razon Social:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(12, 112)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(54, 13)
        Me.label3.TabIndex = 117
        Me.label3.Text = "* Licencia"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(12, 86)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(39, 13)
        Me.label7.TabIndex = 106
        Me.label7.Text = "* Email"
        '
        'tbemail
        '
        Me.tbemail.Location = New System.Drawing.Point(147, 83)
        Me.tbemail.MaxLength = 80
        Me.tbemail.Name = "tbemail"
        Me.tbemail.Size = New System.Drawing.Size(325, 20)
        Me.tbemail.TabIndex = 1
        '
        'tbnombre
        '
        Me.tbnombre.Location = New System.Drawing.Point(147, 57)
        Me.tbnombre.MaxLength = 100
        Me.tbnombre.Name = "tbnombre"
        Me.tbnombre.Size = New System.Drawing.Size(413, 20)
        Me.tbnombre.TabIndex = 0
        '
        'pictureBox1
        '
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(352, 440)
        Me.pictureBox1.TabIndex = 123
        Me.pictureBox1.TabStop = False
        '
        'Registrolicencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 440)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.pictureBox1)
        Me.MaximumSize = New System.Drawing.Size(942, 479)
        Me.MinimumSize = New System.Drawing.Size(942, 479)
        Me.Name = "Registrolicencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registro de Licencia"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents cbestatus As ComboBox
    Private WithEvents label8 As Label
    Private WithEvents btlimpiar As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btpegar As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents label4 As Label
    Private WithEvents tbcantidad As TextBox
    Private WithEvents cbperiodo As ComboBox
    Private WithEvents dtfechavencimiento As DateTimePicker
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents lbestatuslicencia As Bunifu.Framework.UI.BunifuCustomLabel
    Private WithEvents btcancelar As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btaceptar As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents tbtelefono As MaskedTextBox
    Private WithEvents label2 As Label
    Private WithEvents tbnombrecontacto As TextBox
    Private WithEvents label1 As Label
    Private WithEvents tblicencia As MaskedTextBox
    Private WithEvents label21 As Label
    Private WithEvents label3 As Label
    Private WithEvents label7 As Label
    Private WithEvents tbemail As TextBox
    Private WithEvents tbnombre As TextBox
    Private WithEvents pictureBox1 As PictureBox
End Class
