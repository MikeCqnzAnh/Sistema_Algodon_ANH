<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosEmpresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatosEmpresa))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbRazonSocial = New System.Windows.Forms.TextBox()
        Me.TbRfc = New System.Windows.Forms.TextBox()
        Me.TbCalle = New System.Windows.Forms.TextBox()
        Me.TbNumExt = New System.Windows.Forms.TextBox()
        Me.TbNumInt = New System.Windows.Forms.TextBox()
        Me.TbColonia = New System.Windows.Forms.TextBox()
        Me.TbReferencia = New System.Windows.Forms.TextBox()
        Me.TbPoblacion = New System.Windows.Forms.TextBox()
        Me.TbCodigoPostal = New System.Windows.Forms.TextBox()
        Me.TbMunicipio = New System.Windows.Forms.TextBox()
        Me.TbEstado = New System.Windows.Forms.TextBox()
        Me.TbPais = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TbEntreCalle1 = New System.Windows.Forms.TextBox()
        Me.TbEntreCalle2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TbLugarExpedicion = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GbNombreEmpresa = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TbRepresentante = New System.Windows.Forms.TextBox()
        Me.TbID = New System.Windows.Forms.TextBox()
        Me.TbRFCRepresentante = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GbDatosEmpresa = New System.Windows.Forms.GroupBox()
        Me.pblogo = New System.Windows.Forms.PictureBox()
        Me.btcargalogo = New Bunifu.Framework.UI.BunifuImageButton()
        Me.ofdlogo = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.GbNombreEmpresa.SuspendLayout()
        Me.GbDatosEmpresa.SuspendLayout()
        CType(Me.pblogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btcargalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(936, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'TbRazonSocial
        '
        Me.TbRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbRazonSocial.Location = New System.Drawing.Point(124, 158)
        Me.TbRazonSocial.Name = "TbRazonSocial"
        Me.TbRazonSocial.Size = New System.Drawing.Size(418, 20)
        Me.TbRazonSocial.TabIndex = 0
        '
        'TbRfc
        '
        Me.TbRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbRfc.Location = New System.Drawing.Point(124, 184)
        Me.TbRfc.Name = "TbRfc"
        Me.TbRfc.Size = New System.Drawing.Size(133, 20)
        Me.TbRfc.TabIndex = 1
        '
        'TbCalle
        '
        Me.TbCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbCalle.Location = New System.Drawing.Point(124, 43)
        Me.TbCalle.Name = "TbCalle"
        Me.TbCalle.Size = New System.Drawing.Size(359, 20)
        Me.TbCalle.TabIndex = 0
        '
        'TbNumExt
        '
        Me.TbNumExt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNumExt.Location = New System.Drawing.Point(124, 78)
        Me.TbNumExt.Name = "TbNumExt"
        Me.TbNumExt.Size = New System.Drawing.Size(100, 20)
        Me.TbNumExt.TabIndex = 1
        '
        'TbNumInt
        '
        Me.TbNumInt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNumInt.Location = New System.Drawing.Point(282, 78)
        Me.TbNumInt.Name = "TbNumInt"
        Me.TbNumInt.Size = New System.Drawing.Size(100, 20)
        Me.TbNumInt.TabIndex = 2
        '
        'TbColonia
        '
        Me.TbColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbColonia.Location = New System.Drawing.Point(124, 130)
        Me.TbColonia.Name = "TbColonia"
        Me.TbColonia.Size = New System.Drawing.Size(258, 20)
        Me.TbColonia.TabIndex = 5
        '
        'TbReferencia
        '
        Me.TbReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbReferencia.Location = New System.Drawing.Point(124, 182)
        Me.TbReferencia.Name = "TbReferencia"
        Me.TbReferencia.Size = New System.Drawing.Size(359, 20)
        Me.TbReferencia.TabIndex = 6
        '
        'TbPoblacion
        '
        Me.TbPoblacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbPoblacion.Location = New System.Drawing.Point(124, 218)
        Me.TbPoblacion.Name = "TbPoblacion"
        Me.TbPoblacion.Size = New System.Drawing.Size(258, 20)
        Me.TbPoblacion.TabIndex = 7
        '
        'TbCodigoPostal
        '
        Me.TbCodigoPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbCodigoPostal.Location = New System.Drawing.Point(124, 261)
        Me.TbCodigoPostal.Name = "TbCodigoPostal"
        Me.TbCodigoPostal.Size = New System.Drawing.Size(100, 20)
        Me.TbCodigoPostal.TabIndex = 8
        '
        'TbMunicipio
        '
        Me.TbMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbMunicipio.Location = New System.Drawing.Point(124, 313)
        Me.TbMunicipio.Name = "TbMunicipio"
        Me.TbMunicipio.Size = New System.Drawing.Size(152, 20)
        Me.TbMunicipio.TabIndex = 11
        '
        'TbEstado
        '
        Me.TbEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbEstado.Location = New System.Drawing.Point(124, 287)
        Me.TbEstado.Name = "TbEstado"
        Me.TbEstado.Size = New System.Drawing.Size(152, 20)
        Me.TbEstado.TabIndex = 9
        '
        'TbPais
        '
        Me.TbPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbPais.Location = New System.Drawing.Point(320, 287)
        Me.TbPais.Name = "TbPais"
        Me.TbPais.Size = New System.Drawing.Size(163, 20)
        Me.TbPais.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Razón Social:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "R.F.C:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Calle:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Num. ext:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Colonia:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Referencia:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(230, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Núm int:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Poblacion:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "C.P:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 316)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Municipio:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(282, 290)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "País:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 290)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Estado:"
        '
        'TbEntreCalle1
        '
        Me.TbEntreCalle1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbEntreCalle1.Location = New System.Drawing.Point(124, 104)
        Me.TbEntreCalle1.Name = "TbEntreCalle1"
        Me.TbEntreCalle1.Size = New System.Drawing.Size(100, 20)
        Me.TbEntreCalle1.TabIndex = 3
        '
        'TbEntreCalle2
        '
        Me.TbEntreCalle2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbEntreCalle2.Location = New System.Drawing.Point(282, 104)
        Me.TbEntreCalle2.Name = "TbEntreCalle2"
        Me.TbEntreCalle2.Size = New System.Drawing.Size(100, 20)
        Me.TbEntreCalle2.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 107)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Entre calle:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(230, 107)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Y calle:"
        '
        'TbLugarExpedicion
        '
        Me.TbLugarExpedicion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbLugarExpedicion.Location = New System.Drawing.Point(124, 354)
        Me.TbLugarExpedicion.Name = "TbLugarExpedicion"
        Me.TbLugarExpedicion.Size = New System.Drawing.Size(359, 20)
        Me.TbLugarExpedicion.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 357)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Lugar de expedicion:"
        '
        'GbNombreEmpresa
        '
        Me.GbNombreEmpresa.Controls.Add(Me.btcargalogo)
        Me.GbNombreEmpresa.Controls.Add(Me.pblogo)
        Me.GbNombreEmpresa.Controls.Add(Me.Label18)
        Me.GbNombreEmpresa.Controls.Add(Me.Label17)
        Me.GbNombreEmpresa.Controls.Add(Me.Label2)
        Me.GbNombreEmpresa.Controls.Add(Me.TbRepresentante)
        Me.GbNombreEmpresa.Controls.Add(Me.TbID)
        Me.GbNombreEmpresa.Controls.Add(Me.TbRFCRepresentante)
        Me.GbNombreEmpresa.Controls.Add(Me.TbRazonSocial)
        Me.GbNombreEmpresa.Controls.Add(Me.Label16)
        Me.GbNombreEmpresa.Controls.Add(Me.TbRfc)
        Me.GbNombreEmpresa.Controls.Add(Me.Label1)
        Me.GbNombreEmpresa.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbNombreEmpresa.Location = New System.Drawing.Point(0, 24)
        Me.GbNombreEmpresa.Name = "GbNombreEmpresa"
        Me.GbNombreEmpresa.Size = New System.Drawing.Size(936, 271)
        Me.GbNombreEmpresa.TabIndex = 0
        Me.GbNombreEmpresa.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(21, 13)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "ID:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 239)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "R.F.C:"
        '
        'TbRepresentante
        '
        Me.TbRepresentante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbRepresentante.Location = New System.Drawing.Point(124, 210)
        Me.TbRepresentante.Name = "TbRepresentante"
        Me.TbRepresentante.Size = New System.Drawing.Size(418, 20)
        Me.TbRepresentante.TabIndex = 2
        '
        'TbID
        '
        Me.TbID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbID.Enabled = False
        Me.TbID.Location = New System.Drawing.Point(124, 17)
        Me.TbID.Name = "TbID"
        Me.TbID.Size = New System.Drawing.Size(133, 20)
        Me.TbID.TabIndex = 3
        '
        'TbRFCRepresentante
        '
        Me.TbRFCRepresentante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbRFCRepresentante.Location = New System.Drawing.Point(124, 236)
        Me.TbRFCRepresentante.Name = "TbRFCRepresentante"
        Me.TbRFCRepresentante.Size = New System.Drawing.Size(133, 20)
        Me.TbRFCRepresentante.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 213)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(105, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Representante legal:"
        '
        'GbDatosEmpresa
        '
        Me.GbDatosEmpresa.Controls.Add(Me.Label3)
        Me.GbDatosEmpresa.Controls.Add(Me.TbCalle)
        Me.GbDatosEmpresa.Controls.Add(Me.Label12)
        Me.GbDatosEmpresa.Controls.Add(Me.TbNumInt)
        Me.GbDatosEmpresa.Controls.Add(Me.Label11)
        Me.GbDatosEmpresa.Controls.Add(Me.TbPoblacion)
        Me.GbDatosEmpresa.Controls.Add(Me.Label15)
        Me.GbDatosEmpresa.Controls.Add(Me.TbColonia)
        Me.GbDatosEmpresa.Controls.Add(Me.Label10)
        Me.GbDatosEmpresa.Controls.Add(Me.TbEntreCalle1)
        Me.GbDatosEmpresa.Controls.Add(Me.Label9)
        Me.GbDatosEmpresa.Controls.Add(Me.TbReferencia)
        Me.GbDatosEmpresa.Controls.Add(Me.Label8)
        Me.GbDatosEmpresa.Controls.Add(Me.TbEntreCalle2)
        Me.GbDatosEmpresa.Controls.Add(Me.Label14)
        Me.GbDatosEmpresa.Controls.Add(Me.TbCodigoPostal)
        Me.GbDatosEmpresa.Controls.Add(Me.Label6)
        Me.GbDatosEmpresa.Controls.Add(Me.TbMunicipio)
        Me.GbDatosEmpresa.Controls.Add(Me.Label7)
        Me.GbDatosEmpresa.Controls.Add(Me.TbLugarExpedicion)
        Me.GbDatosEmpresa.Controls.Add(Me.Label13)
        Me.GbDatosEmpresa.Controls.Add(Me.TbPais)
        Me.GbDatosEmpresa.Controls.Add(Me.Label5)
        Me.GbDatosEmpresa.Controls.Add(Me.TbNumExt)
        Me.GbDatosEmpresa.Controls.Add(Me.Label4)
        Me.GbDatosEmpresa.Controls.Add(Me.TbEstado)
        Me.GbDatosEmpresa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbDatosEmpresa.Location = New System.Drawing.Point(0, 295)
        Me.GbDatosEmpresa.Name = "GbDatosEmpresa"
        Me.GbDatosEmpresa.Size = New System.Drawing.Size(936, 472)
        Me.GbDatosEmpresa.TabIndex = 1
        Me.GbDatosEmpresa.TabStop = False
        Me.GbDatosEmpresa.Text = "Datos de la empresa"
        '
        'pblogo
        '
        Me.pblogo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pblogo.Location = New System.Drawing.Point(124, 43)
        Me.pblogo.Name = "pblogo"
        Me.pblogo.Size = New System.Drawing.Size(100, 100)
        Me.pblogo.TabIndex = 5
        Me.pblogo.TabStop = False
        '
        'btcargalogo
        '
        Me.btcargalogo.BackColor = System.Drawing.Color.Transparent
        Me.btcargalogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btcargalogo.Image = Global.Capa_Presentacion.My.Resources.Resources.ICONO_CALCULA_COTTON_31_32px
        Me.btcargalogo.ImageActive = Nothing
        Me.btcargalogo.Location = New System.Drawing.Point(230, 118)
        Me.btcargalogo.Name = "btcargalogo"
        Me.btcargalogo.Size = New System.Drawing.Size(25, 25)
        Me.btcargalogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btcargalogo.TabIndex = 126
        Me.btcargalogo.TabStop = False
        Me.btcargalogo.Zoom = 15
        '
        'ofdlogo
        '
        Me.ofdlogo.Filter = "JPEGs|*.jpg|GIFs|*.gif|Bitmaps|*.bmp|AllFiles|*.*"
        '
        'DatosEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(936, 767)
        Me.Controls.Add(Me.GbDatosEmpresa)
        Me.Controls.Add(Me.GbNombreEmpresa)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DatosEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Datos de la empresa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GbNombreEmpresa.ResumeLayout(False)
        Me.GbNombreEmpresa.PerformLayout()
        Me.GbDatosEmpresa.ResumeLayout(False)
        Me.GbDatosEmpresa.PerformLayout()
        CType(Me.pblogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btcargalogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TbRazonSocial As TextBox
    Friend WithEvents TbRfc As TextBox
    Friend WithEvents TbCalle As TextBox
    Friend WithEvents TbNumExt As TextBox
    Friend WithEvents TbNumInt As TextBox
    Friend WithEvents TbColonia As TextBox
    Friend WithEvents TbReferencia As TextBox
    Friend WithEvents TbPoblacion As TextBox
    Friend WithEvents TbCodigoPostal As TextBox
    Friend WithEvents TbMunicipio As TextBox
    Friend WithEvents TbEstado As TextBox
    Friend WithEvents TbPais As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TbEntreCalle1 As TextBox
    Friend WithEvents TbEntreCalle2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TbLugarExpedicion As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents GbNombreEmpresa As GroupBox
    Friend WithEvents GbDatosEmpresa As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TbRepresentante As TextBox
    Friend WithEvents TbRFCRepresentante As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label18 As Label
    Friend WithEvents TbID As TextBox
    Friend WithEvents pblogo As PictureBox
    Private WithEvents btcargalogo As Bunifu.Framework.UI.BunifuImageButton
    Private WithEvents ofdlogo As OpenFileDialog
End Class
