<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tierras
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
        Dim Label20 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DtFechaTitulo = New System.Windows.Forms.DateTimePicker()
        Me.TbLibroRpp = New System.Windows.Forms.TextBox()
        Me.CbRegimenHidrico = New System.Windows.Forms.ComboBox()
        Me.TbNumeroRpp = New System.Windows.Forms.TextBox()
        Me.TbTituloAgua = New System.Windows.Forms.TextBox()
        Me.TbFolioRpp = New System.Windows.Forms.TextBox()
        Me.DtFechaRegistro = New System.Windows.Forms.DateTimePicker()
        Me.GbCoordenadas = New System.Windows.Forms.GroupBox()
        Me.TbLongitudGrados = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TbLatitudGrados = New System.Windows.Forms.TextBox()
        Me.TbLatitudHoras = New System.Windows.Forms.TextBox()
        Me.TbLatitudMinutos = New System.Windows.Forms.TextBox()
        Me.TbLongitudHoras = New System.Windows.Forms.TextBox()
        Me.TbLongitudMinutos = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.NuSuperficieCultivable = New System.Windows.Forms.NumericUpDown()
        Me.NuSuperficieTotal = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbRegistroAlterno = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbCurp = New System.Windows.Forms.TextBox()
        Me.TbRfc = New System.Windows.Forms.TextBox()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.CbCliente = New System.Windows.Forms.ComboBox()
        Me.CbColonia = New System.Windows.Forms.ComboBox()
        Me.TbIdTierra = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbLote = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label19 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Me.MSMenu.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GbCoordenadas.SuspendLayout()
        Me.GbDatos.SuspendLayout()
        CType(Me.NuSuperficieCultivable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuSuperficieTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Location = New System.Drawing.Point(339, 83)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(37, 13)
        Label20.TabIndex = 42
        Label20.Text = "Fecha"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(7, 25)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(59, 13)
        Label14.TabIndex = 32
        Label14.Text = "Bajo el No."
        '
        'Label19
        '
        Label19.AutoSize = True
        Label19.Location = New System.Drawing.Point(339, 52)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(85, 13)
        Label19.TabIndex = 41
        Label19.Text = "Regimen Hidrico"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Location = New System.Drawing.Point(339, 25)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(76, 13)
        Label18.TabIndex = 40
        Label18.Text = "Titulo de Agua"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(7, 100)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(79, 13)
        Label17.TabIndex = 39
        Label17.Text = "Fecha Registro"
        '
        'MSMenu
        '
        Me.MSMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(671, 24)
        Me.MSMenu.TabIndex = 0
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Label20)
        Me.GroupBox2.Controls.Add(Label14)
        Me.GroupBox2.Controls.Add(Label19)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Label18)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Label17)
        Me.GroupBox2.Controls.Add(Me.DtFechaTitulo)
        Me.GroupBox2.Controls.Add(Me.TbLibroRpp)
        Me.GroupBox2.Controls.Add(Me.CbRegimenHidrico)
        Me.GroupBox2.Controls.Add(Me.TbNumeroRpp)
        Me.GroupBox2.Controls.Add(Me.TbTituloAgua)
        Me.GroupBox2.Controls.Add(Me.TbFolioRpp)
        Me.GroupBox2.Controls.Add(Me.DtFechaRegistro)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 299)
        Me.GroupBox2.MinimumSize = New System.Drawing.Size(671, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(671, 184)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Escritura del Regimen Publico de la Propiedad"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 51)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 13)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "A folio"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 77)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Del Libro"
        '
        'DtFechaTitulo
        '
        Me.DtFechaTitulo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaTitulo.Location = New System.Drawing.Point(438, 77)
        Me.DtFechaTitulo.Name = "DtFechaTitulo"
        Me.DtFechaTitulo.Size = New System.Drawing.Size(100, 20)
        Me.DtFechaTitulo.TabIndex = 6
        '
        'TbLibroRpp
        '
        Me.TbLibroRpp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbLibroRpp.Location = New System.Drawing.Point(106, 74)
        Me.TbLibroRpp.Name = "TbLibroRpp"
        Me.TbLibroRpp.Size = New System.Drawing.Size(86, 20)
        Me.TbLibroRpp.TabIndex = 2
        '
        'CbRegimenHidrico
        '
        Me.CbRegimenHidrico.FormattingEnabled = True
        Me.CbRegimenHidrico.Location = New System.Drawing.Point(438, 49)
        Me.CbRegimenHidrico.Name = "CbRegimenHidrico"
        Me.CbRegimenHidrico.Size = New System.Drawing.Size(121, 21)
        Me.CbRegimenHidrico.TabIndex = 5
        '
        'TbNumeroRpp
        '
        Me.TbNumeroRpp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNumeroRpp.Location = New System.Drawing.Point(106, 22)
        Me.TbNumeroRpp.Name = "TbNumeroRpp"
        Me.TbNumeroRpp.Size = New System.Drawing.Size(86, 20)
        Me.TbNumeroRpp.TabIndex = 0
        '
        'TbTituloAgua
        '
        Me.TbTituloAgua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbTituloAgua.Location = New System.Drawing.Point(438, 22)
        Me.TbTituloAgua.Name = "TbTituloAgua"
        Me.TbTituloAgua.Size = New System.Drawing.Size(100, 20)
        Me.TbTituloAgua.TabIndex = 4
        '
        'TbFolioRpp
        '
        Me.TbFolioRpp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbFolioRpp.Location = New System.Drawing.Point(106, 48)
        Me.TbFolioRpp.Name = "TbFolioRpp"
        Me.TbFolioRpp.Size = New System.Drawing.Size(86, 20)
        Me.TbFolioRpp.TabIndex = 1
        '
        'DtFechaRegistro
        '
        Me.DtFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaRegistro.Location = New System.Drawing.Point(106, 100)
        Me.DtFechaRegistro.Name = "DtFechaRegistro"
        Me.DtFechaRegistro.Size = New System.Drawing.Size(100, 20)
        Me.DtFechaRegistro.TabIndex = 3
        '
        'GbCoordenadas
        '
        Me.GbCoordenadas.Controls.Add(Me.TbLongitudGrados)
        Me.GbCoordenadas.Controls.Add(Me.Label11)
        Me.GbCoordenadas.Controls.Add(Me.TbLatitudGrados)
        Me.GbCoordenadas.Controls.Add(Me.TbLatitudHoras)
        Me.GbCoordenadas.Controls.Add(Me.TbLatitudMinutos)
        Me.GbCoordenadas.Controls.Add(Me.TbLongitudHoras)
        Me.GbCoordenadas.Controls.Add(Me.TbLongitudMinutos)
        Me.GbCoordenadas.Controls.Add(Me.Label12)
        Me.GbCoordenadas.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbCoordenadas.Location = New System.Drawing.Point(0, 235)
        Me.GbCoordenadas.Name = "GbCoordenadas"
        Me.GbCoordenadas.Size = New System.Drawing.Size(671, 64)
        Me.GbCoordenadas.TabIndex = 1
        Me.GbCoordenadas.TabStop = False
        Me.GbCoordenadas.Text = "Coordenadas de Lote"
        '
        'TbLongitudGrados
        '
        Me.TbLongitudGrados.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbLongitudGrados.Location = New System.Drawing.Point(438, 23)
        Me.TbLongitudGrados.Name = "TbLongitudGrados"
        Me.TbLongitudGrados.Size = New System.Drawing.Size(61, 20)
        Me.TbLongitudGrados.TabIndex = 3
        Me.TbLongitudGrados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Latitud"
        '
        'TbLatitudGrados
        '
        Me.TbLatitudGrados.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbLatitudGrados.Location = New System.Drawing.Point(106, 23)
        Me.TbLatitudGrados.Name = "TbLatitudGrados"
        Me.TbLatitudGrados.Size = New System.Drawing.Size(61, 20)
        Me.TbLatitudGrados.TabIndex = 0
        Me.TbLatitudGrados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbLatitudHoras
        '
        Me.TbLatitudHoras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbLatitudHoras.Location = New System.Drawing.Point(173, 23)
        Me.TbLatitudHoras.Name = "TbLatitudHoras"
        Me.TbLatitudHoras.Size = New System.Drawing.Size(61, 20)
        Me.TbLatitudHoras.TabIndex = 1
        Me.TbLatitudHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbLatitudMinutos
        '
        Me.TbLatitudMinutos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbLatitudMinutos.Location = New System.Drawing.Point(240, 23)
        Me.TbLatitudMinutos.Name = "TbLatitudMinutos"
        Me.TbLatitudMinutos.Size = New System.Drawing.Size(61, 20)
        Me.TbLatitudMinutos.TabIndex = 2
        Me.TbLatitudMinutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbLongitudHoras
        '
        Me.TbLongitudHoras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbLongitudHoras.Location = New System.Drawing.Point(505, 23)
        Me.TbLongitudHoras.Name = "TbLongitudHoras"
        Me.TbLongitudHoras.Size = New System.Drawing.Size(61, 20)
        Me.TbLongitudHoras.TabIndex = 4
        Me.TbLongitudHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbLongitudMinutos
        '
        Me.TbLongitudMinutos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbLongitudMinutos.Location = New System.Drawing.Point(572, 23)
        Me.TbLongitudMinutos.Name = "TbLongitudMinutos"
        Me.TbLongitudMinutos.Size = New System.Drawing.Size(61, 20)
        Me.TbLongitudMinutos.TabIndex = 5
        Me.TbLongitudMinutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(347, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Longitud"
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.NuSuperficieCultivable)
        Me.GbDatos.Controls.Add(Me.NuSuperficieTotal)
        Me.GbDatos.Controls.Add(Me.Label7)
        Me.GbDatos.Controls.Add(Me.Label10)
        Me.GbDatos.Controls.Add(Me.Label9)
        Me.GbDatos.Controls.Add(Me.TbRegistroAlterno)
        Me.GbDatos.Controls.Add(Me.Label8)
        Me.GbDatos.Controls.Add(Me.Label5)
        Me.GbDatos.Controls.Add(Me.Label4)
        Me.GbDatos.Controls.Add(Me.Label3)
        Me.GbDatos.Controls.Add(Me.Label2)
        Me.GbDatos.Controls.Add(Me.TbCurp)
        Me.GbDatos.Controls.Add(Me.TbRfc)
        Me.GbDatos.Controls.Add(Me.CbEstatus)
        Me.GbDatos.Controls.Add(Me.CbCliente)
        Me.GbDatos.Controls.Add(Me.CbColonia)
        Me.GbDatos.Controls.Add(Me.TbIdTierra)
        Me.GbDatos.Controls.Add(Me.Label6)
        Me.GbDatos.Controls.Add(Me.TbLote)
        Me.GbDatos.Controls.Add(Me.Label1)
        Me.GbDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatos.Location = New System.Drawing.Point(0, 24)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(671, 211)
        Me.GbDatos.TabIndex = 0
        Me.GbDatos.TabStop = False
        Me.GbDatos.Text = "Datos Generales"
        '
        'NuSuperficieCultivable
        '
        Me.NuSuperficieCultivable.DecimalPlaces = 2
        Me.NuSuperficieCultivable.Location = New System.Drawing.Point(494, 71)
        Me.NuSuperficieCultivable.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NuSuperficieCultivable.Name = "NuSuperficieCultivable"
        Me.NuSuperficieCultivable.Size = New System.Drawing.Size(100, 20)
        Me.NuSuperficieCultivable.TabIndex = 8
        Me.NuSuperficieCultivable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuSuperficieCultivable.ThousandsSeparator = True
        '
        'NuSuperficieTotal
        '
        Me.NuSuperficieTotal.DecimalPlaces = 2
        Me.NuSuperficieTotal.Location = New System.Drawing.Point(494, 46)
        Me.NuSuperficieTotal.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NuSuperficieTotal.Name = "NuSuperficieTotal"
        Me.NuSuperficieTotal.Size = New System.Drawing.Size(100, 20)
        Me.NuSuperficieTotal.TabIndex = 7
        Me.NuSuperficieTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuSuperficieTotal.ThousandsSeparator = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(384, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Estatus"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(384, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Superficie Cultivable"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(384, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Superficie Total"
        '
        'TbRegistroAlterno
        '
        Me.TbRegistroAlterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbRegistroAlterno.Location = New System.Drawing.Point(494, 19)
        Me.TbRegistroAlterno.Name = "TbRegistroAlterno"
        Me.TbRegistroAlterno.Size = New System.Drawing.Size(100, 20)
        Me.TbRegistroAlterno.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(384, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Registro Alterno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "CURP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "RFC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Propietario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Colonia"
        '
        'TbCurp
        '
        Me.TbCurp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbCurp.Enabled = False
        Me.TbCurp.Location = New System.Drawing.Point(106, 155)
        Me.TbCurp.Name = "TbCurp"
        Me.TbCurp.Size = New System.Drawing.Size(191, 20)
        Me.TbCurp.TabIndex = 5
        '
        'TbRfc
        '
        Me.TbRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbRfc.Enabled = False
        Me.TbRfc.Location = New System.Drawing.Point(106, 128)
        Me.TbRfc.Name = "TbRfc"
        Me.TbRfc.Size = New System.Drawing.Size(191, 20)
        Me.TbRfc.TabIndex = 4
        '
        'CbEstatus
        '
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(494, 100)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(100, 21)
        Me.CbEstatus.TabIndex = 9
        '
        'CbCliente
        '
        Me.CbCliente.FormattingEnabled = True
        Me.CbCliente.Location = New System.Drawing.Point(106, 100)
        Me.CbCliente.Name = "CbCliente"
        Me.CbCliente.Size = New System.Drawing.Size(220, 21)
        Me.CbCliente.TabIndex = 3
        '
        'CbColonia
        '
        Me.CbColonia.FormattingEnabled = True
        Me.CbColonia.Location = New System.Drawing.Point(106, 72)
        Me.CbColonia.Name = "CbColonia"
        Me.CbColonia.Size = New System.Drawing.Size(220, 21)
        Me.CbColonia.TabIndex = 2
        '
        'TbIdTierra
        '
        Me.TbIdTierra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbIdTierra.Enabled = False
        Me.TbIdTierra.Location = New System.Drawing.Point(106, 19)
        Me.TbIdTierra.Name = "TbIdTierra"
        Me.TbIdTierra.Size = New System.Drawing.Size(100, 20)
        Me.TbIdTierra.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ID"
        '
        'TbLote
        '
        Me.TbLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbLote.Location = New System.Drawing.Point(106, 45)
        Me.TbLote.Name = "TbLote"
        Me.TbLote.Size = New System.Drawing.Size(100, 20)
        Me.TbLote.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lote"
        '
        'Tierras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 483)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GbCoordenadas)
        Me.Controls.Add(Me.GbDatos)
        Me.Controls.Add(Me.MSMenu)
        Me.MainMenuStrip = Me.MSMenu
        Me.MinimumSize = New System.Drawing.Size(687, 522)
        Me.Name = "Tierras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tierras"
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GbCoordenadas.ResumeLayout(False)
        Me.GbCoordenadas.PerformLayout()
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        CType(Me.NuSuperficieCultivable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuSuperficieTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents DtFechaTitulo As DateTimePicker
    Friend WithEvents TbLibroRpp As TextBox
    Friend WithEvents CbRegimenHidrico As ComboBox
    Friend WithEvents TbNumeroRpp As TextBox
    Friend WithEvents TbTituloAgua As TextBox
    Friend WithEvents TbFolioRpp As TextBox
    Friend WithEvents DtFechaRegistro As DateTimePicker
    Friend WithEvents GbCoordenadas As GroupBox
    Friend WithEvents TbLongitudGrados As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TbLatitudGrados As TextBox
    Friend WithEvents TbLatitudHoras As TextBox
    Friend WithEvents TbLatitudMinutos As TextBox
    Friend WithEvents TbLongitudHoras As TextBox
    Friend WithEvents TbLongitudMinutos As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TbRegistroAlterno As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbCurp As TextBox
    Friend WithEvents TbRfc As TextBox
    Friend WithEvents CbCliente As ComboBox
    Friend WithEvents CbColonia As ComboBox
    Friend WithEvents TbLote As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuSuperficieCultivable As NumericUpDown
    Friend WithEvents NuSuperficieTotal As NumericUpDown
    Friend WithEvents TbIdTierra As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CbEstatus As ComboBox
End Class
