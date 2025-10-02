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
        Me.nucantidad = New System.Windows.Forms.NumericUpDown()
        Me.cbestatuslicencia = New System.Windows.Forms.ComboBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.btlimpiar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btpegar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.label4 = New System.Windows.Forms.Label()
        Me.cbperiodo = New System.Windows.Forms.ComboBox()
        Me.dtfechavencimiento = New System.Windows.Forms.DateTimePicker()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btcancelar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btactivar = New Bunifu.Framework.UI.BunifuFlatButton()
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
        CType(Me.nucantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.nucantidad)
        Me.panel1.Controls.Add(Me.cbestatuslicencia)
        Me.panel1.Controls.Add(Me.label8)
        Me.panel1.Controls.Add(Me.btlimpiar)
        Me.panel1.Controls.Add(Me.btpegar)
        Me.panel1.Controls.Add(Me.label4)
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
        'nucantidad
        '
        Me.nucantidad.Enabled = False
        Me.nucantidad.Location = New System.Drawing.Point(147, 107)
        Me.nucantidad.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nucantidad.Name = "nucantidad"
        Me.nucantidad.ReadOnly = True
        Me.nucantidad.Size = New System.Drawing.Size(75, 20)
        Me.nucantidad.TabIndex = 147
        Me.nucantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nucantidad.ThousandsSeparator = True
        Me.nucantidad.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'cbestatuslicencia
        '
        Me.cbestatuslicencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbestatuslicencia.Enabled = False
        Me.cbestatuslicencia.FormattingEnabled = True
        Me.cbestatuslicencia.Location = New System.Drawing.Point(147, 159)
        Me.cbestatuslicencia.Name = "cbestatuslicencia"
        Me.cbestatuslicencia.Size = New System.Drawing.Size(121, 21)
        Me.cbestatuslicencia.TabIndex = 146
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(12, 162)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(42, 13)
        Me.label8.TabIndex = 145
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
        Me.btlimpiar.Location = New System.Drawing.Point(480, 79)
        Me.btlimpiar.Name = "btlimpiar"
        Me.btlimpiar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btlimpiar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btlimpiar.OnHoverTextColor = System.Drawing.Color.White
        Me.btlimpiar.selected = False
        Me.btlimpiar.Size = New System.Drawing.Size(80, 25)
        Me.btlimpiar.TabIndex = 140
        Me.btlimpiar.Text = "Limpiar"
        Me.btlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btlimpiar.Textcolor = System.Drawing.Color.Black
        Me.btlimpiar.TextFont = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btpegar.Location = New System.Drawing.Point(311, 79)
        Me.btpegar.Name = "btpegar"
        Me.btpegar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btpegar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btpegar.OnHoverTextColor = System.Drawing.Color.White
        Me.btpegar.selected = False
        Me.btpegar.Size = New System.Drawing.Size(80, 25)
        Me.btpegar.TabIndex = 141
        Me.btpegar.Text = "Pegar"
        Me.btpegar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btpegar.Textcolor = System.Drawing.Color.Black
        Me.btpegar.TextFont = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(324, 84)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(0, 13)
        Me.label4.TabIndex = 144
        '
        'cbperiodo
        '
        Me.cbperiodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbperiodo.Enabled = False
        Me.cbperiodo.FormattingEnabled = True
        Me.cbperiodo.Location = New System.Drawing.Point(228, 107)
        Me.cbperiodo.Name = "cbperiodo"
        Me.cbperiodo.Size = New System.Drawing.Size(147, 21)
        Me.cbperiodo.TabIndex = 134
        '
        'dtfechavencimiento
        '
        Me.dtfechavencimiento.CustomFormat = "dd/MM/yyyy"
        Me.dtfechavencimiento.Enabled = False
        Me.dtfechavencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfechavencimiento.Location = New System.Drawing.Point(147, 133)
        Me.dtfechavencimiento.Name = "dtfechavencimiento"
        Me.dtfechavencimiento.Size = New System.Drawing.Size(111, 20)
        Me.dtfechavencimiento.TabIndex = 135
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(12, 135)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(48, 13)
        Me.label6.TabIndex = 143
        Me.label6.Text = "Vigencia"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(12, 110)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(100, 13)
        Me.label5.TabIndex = 142
        Me.label5.Text = "Tiempo de Licencia"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btcancelar)
        Me.groupBox1.Controls.Add(Me.btactivar)
        Me.groupBox1.Controls.Add(Me.tbtelefono)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.tbnombrecontacto)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.groupBox1.Location = New System.Drawing.Point(0, 239)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(574, 201)
        Me.groupBox1.TabIndex = 138
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Contacto"
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
        Me.btcancelar.Location = New System.Drawing.Point(434, 152)
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
        Me.btcancelar.TextFont = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btactivar
        '
        Me.btactivar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btactivar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btactivar.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btactivar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btactivar.BorderRadius = 7
        Me.btactivar.ButtonText = "ACTIVAR LICENCIA"
        Me.btactivar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btactivar.DisabledColor = System.Drawing.Color.Gray
        Me.btactivar.Iconcolor = System.Drawing.Color.Transparent
        Me.btactivar.Iconimage = Nothing
        Me.btactivar.Iconimage_right = Nothing
        Me.btactivar.Iconimage_right_Selected = Nothing
        Me.btactivar.Iconimage_Selected = Nothing
        Me.btactivar.IconMarginLeft = 0
        Me.btactivar.IconMarginRight = 0
        Me.btactivar.IconRightVisible = True
        Me.btactivar.IconRightZoom = 0R
        Me.btactivar.IconVisible = True
        Me.btactivar.IconZoom = 90.0R
        Me.btactivar.IsTab = False
        Me.btactivar.Location = New System.Drawing.Point(147, 152)
        Me.btactivar.Name = "btactivar"
        Me.btactivar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btactivar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.btactivar.OnHoverTextColor = System.Drawing.Color.White
        Me.btactivar.selected = False
        Me.btactivar.Size = New System.Drawing.Size(177, 37)
        Me.btactivar.TabIndex = 116
        Me.btactivar.Text = "ACTIVAR LICENCIA"
        Me.btactivar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btactivar.Textcolor = System.Drawing.Color.Black
        Me.btactivar.TextFont = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.label2.Size = New System.Drawing.Size(49, 13)
        Me.label2.TabIndex = 115
        Me.label2.Text = "Telefono"
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
        Me.label1.Size = New System.Drawing.Size(44, 13)
        Me.label1.TabIndex = 113
        Me.label1.Text = "Nombre"
        '
        'tblicencia
        '
        Me.tblicencia.Location = New System.Drawing.Point(147, 81)
        Me.tblicencia.Mask = "AAAA-AAAA-AAAA-AAAA"
        Me.tblicencia.Name = "tblicencia"
        Me.tblicencia.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.tblicencia.ReadOnly = True
        Me.tblicencia.Size = New System.Drawing.Size(158, 20)
        Me.tblicencia.SkipLiterals = False
        Me.tblicencia.TabIndex = 133
        Me.tblicencia.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'label21
        '
        Me.label21.AutoSize = True
        Me.label21.Location = New System.Drawing.Point(12, 32)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(129, 13)
        Me.label21.TabIndex = 137
        Me.label21.Text = "* Nombre o Razon Social:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(12, 84)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(54, 13)
        Me.label3.TabIndex = 139
        Me.label3.Text = "* Licencia"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(12, 58)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(39, 13)
        Me.label7.TabIndex = 136
        Me.label7.Text = "* Email"
        '
        'tbemail
        '
        Me.tbemail.Location = New System.Drawing.Point(147, 55)
        Me.tbemail.MaxLength = 80
        Me.tbemail.Name = "tbemail"
        Me.tbemail.Size = New System.Drawing.Size(325, 20)
        Me.tbemail.TabIndex = 132
        '
        'tbnombre
        '
        Me.tbnombre.Location = New System.Drawing.Point(147, 29)
        Me.tbnombre.MaxLength = 100
        Me.tbnombre.Name = "tbnombre"
        Me.tbnombre.Size = New System.Drawing.Size(413, 20)
        Me.tbnombre.TabIndex = 131
        '
        'pictureBox1
        '
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(352, 440)
        Me.pictureBox1.TabIndex = 148
        Me.pictureBox1.TabStop = False
        '
        'Registrolicencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 440)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(942, 479)
        Me.MinimumSize = New System.Drawing.Size(942, 479)
        Me.Name = "Registrolicencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registro de Licencia"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.nucantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents nucantidad As NumericUpDown
    Private WithEvents cbestatuslicencia As ComboBox
    Private WithEvents label8 As Label
    Private WithEvents btlimpiar As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btpegar As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents label4 As Label
    Private WithEvents cbperiodo As ComboBox
    Private WithEvents dtfechavencimiento As DateTimePicker
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btcancelar As Bunifu.Framework.UI.BunifuFlatButton
    Private WithEvents btactivar As Bunifu.Framework.UI.BunifuFlatButton
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
