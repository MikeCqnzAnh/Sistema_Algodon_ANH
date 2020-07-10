<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CargaPacasExternas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CargaPacasExternas))
        Me.BtProductor = New System.Windows.Forms.Button()
        Me.TbIdProductor = New System.Windows.Forms.TextBox()
        Me.TbNombreProductor = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcelParaImportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbPlantaOrigen = New System.Windows.Forms.ComboBox()
        Me.BtCargaExcel = New System.Windows.Forms.Button()
        Me.GbEncabezado = New System.Windows.Forms.GroupBox()
        Me.TbNoModulos = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TbRangoFin = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TbRangoInicio = New System.Windows.Forms.TextBox()
        Me.TbLotID = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TbIdPaqueteHVI = New System.Windows.Forms.TextBox()
        Me.CbTipo = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TbIdLiquidacion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbTipoPaca = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbIdProduccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbIdOrdenTrabajo = New System.Windows.Forms.TextBox()
        Me.CBPlantaDestino = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbPredio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbVariedad = New System.Windows.Forms.ComboBox()
        Me.GbCentro = New System.Windows.Forms.GroupBox()
        Me.DgvPacas = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtCargaAccess = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbTotalKilos = New System.Windows.Forms.TextBox()
        Me.TbTotalPacas = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.GbEncabezado.SuspendLayout()
        Me.GbCentro.SuspendLayout()
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtProductor
        '
        Me.BtProductor.Location = New System.Drawing.Point(15, 19)
        Me.BtProductor.Name = "BtProductor"
        Me.BtProductor.Size = New System.Drawing.Size(68, 23)
        Me.BtProductor.TabIndex = 0
        Me.BtProductor.Text = "Productor"
        Me.BtProductor.UseVisualStyleBackColor = True
        '
        'TbIdProductor
        '
        Me.TbIdProductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbIdProductor.Location = New System.Drawing.Point(89, 21)
        Me.TbIdProductor.Name = "TbIdProductor"
        Me.TbIdProductor.ReadOnly = True
        Me.TbIdProductor.Size = New System.Drawing.Size(66, 20)
        Me.TbIdProductor.TabIndex = 1
        '
        'TbNombreProductor
        '
        Me.TbNombreProductor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNombreProductor.Location = New System.Drawing.Point(161, 21)
        Me.TbNombreProductor.Name = "TbNombreProductor"
        Me.TbNombreProductor.ReadOnly = True
        Me.TbNombreProductor.Size = New System.Drawing.Size(421, 20)
        Me.TbNombreProductor.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ExcelParaImportarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1380, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevaToolStripMenuItem
        '
        Me.NuevaToolStripMenuItem.Name = "NuevaToolStripMenuItem"
        Me.NuevaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.NuevaToolStripMenuItem.Text = "Nueva"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'ExcelParaImportarToolStripMenuItem
        '
        Me.ExcelParaImportarToolStripMenuItem.Name = "ExcelParaImportarToolStripMenuItem"
        Me.ExcelParaImportarToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.ExcelParaImportarToolStripMenuItem.Text = "Excel para importar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Planta Origen"
        '
        'CbPlantaOrigen
        '
        Me.CbPlantaOrigen.FormattingEnabled = True
        Me.CbPlantaOrigen.Location = New System.Drawing.Point(89, 47)
        Me.CbPlantaOrigen.Name = "CbPlantaOrigen"
        Me.CbPlantaOrigen.Size = New System.Drawing.Size(229, 21)
        Me.CbPlantaOrigen.TabIndex = 5
        '
        'BtCargaExcel
        '
        Me.BtCargaExcel.BackgroundImage = CType(resources.GetObject("BtCargaExcel.BackgroundImage"), System.Drawing.Image)
        Me.BtCargaExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtCargaExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtCargaExcel.Location = New System.Drawing.Point(3, 3)
        Me.BtCargaExcel.Name = "BtCargaExcel"
        Me.BtCargaExcel.Size = New System.Drawing.Size(37, 35)
        Me.BtCargaExcel.TabIndex = 6
        Me.BtCargaExcel.UseVisualStyleBackColor = True
        '
        'GbEncabezado
        '
        Me.GbEncabezado.Controls.Add(Me.TbNoModulos)
        Me.GbEncabezado.Controls.Add(Me.Label16)
        Me.GbEncabezado.Controls.Add(Me.Label15)
        Me.GbEncabezado.Controls.Add(Me.TbRangoFin)
        Me.GbEncabezado.Controls.Add(Me.Label14)
        Me.GbEncabezado.Controls.Add(Me.TbRangoInicio)
        Me.GbEncabezado.Controls.Add(Me.TbLotID)
        Me.GbEncabezado.Controls.Add(Me.Label13)
        Me.GbEncabezado.Controls.Add(Me.Label12)
        Me.GbEncabezado.Controls.Add(Me.TbIdPaqueteHVI)
        Me.GbEncabezado.Controls.Add(Me.CbTipo)
        Me.GbEncabezado.Controls.Add(Me.Label11)
        Me.GbEncabezado.Controls.Add(Me.Label10)
        Me.GbEncabezado.Controls.Add(Me.TbIdLiquidacion)
        Me.GbEncabezado.Controls.Add(Me.Label7)
        Me.GbEncabezado.Controls.Add(Me.CbTipoPaca)
        Me.GbEncabezado.Controls.Add(Me.Label6)
        Me.GbEncabezado.Controls.Add(Me.TbIdProduccion)
        Me.GbEncabezado.Controls.Add(Me.Label5)
        Me.GbEncabezado.Controls.Add(Me.TbIdOrdenTrabajo)
        Me.GbEncabezado.Controls.Add(Me.CBPlantaDestino)
        Me.GbEncabezado.Controls.Add(Me.Label4)
        Me.GbEncabezado.Controls.Add(Me.TbPredio)
        Me.GbEncabezado.Controls.Add(Me.Label3)
        Me.GbEncabezado.Controls.Add(Me.Label2)
        Me.GbEncabezado.Controls.Add(Me.CbVariedad)
        Me.GbEncabezado.Controls.Add(Me.BtProductor)
        Me.GbEncabezado.Controls.Add(Me.TbIdProductor)
        Me.GbEncabezado.Controls.Add(Me.TbNombreProductor)
        Me.GbEncabezado.Controls.Add(Me.CbPlantaOrigen)
        Me.GbEncabezado.Controls.Add(Me.Label1)
        Me.GbEncabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbEncabezado.Location = New System.Drawing.Point(0, 24)
        Me.GbEncabezado.Name = "GbEncabezado"
        Me.GbEncabezado.Size = New System.Drawing.Size(1380, 165)
        Me.GbEncabezado.TabIndex = 8
        Me.GbEncabezado.TabStop = False
        '
        'TbNoModulos
        '
        Me.TbNoModulos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNoModulos.Enabled = False
        Me.TbNoModulos.Location = New System.Drawing.Point(1054, 47)
        Me.TbNoModulos.Name = "TbNoModulos"
        Me.TbNoModulos.ReadOnly = True
        Me.TbNoModulos.Size = New System.Drawing.Size(73, 20)
        Me.TbNoModulos.TabIndex = 31
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(1001, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Modulos"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(844, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Modulo Final"
        '
        'TbRangoFin
        '
        Me.TbRangoFin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbRangoFin.Location = New System.Drawing.Point(917, 47)
        Me.TbRangoFin.Name = "TbRangoFin"
        Me.TbRangoFin.ReadOnly = True
        Me.TbRangoFin.Size = New System.Drawing.Size(78, 20)
        Me.TbRangoFin.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(612, 50)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Modulo Inicio"
        '
        'TbRangoInicio
        '
        Me.TbRangoInicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbRangoInicio.Location = New System.Drawing.Point(724, 47)
        Me.TbRangoInicio.Name = "TbRangoInicio"
        Me.TbRangoInicio.ReadOnly = True
        Me.TbRangoInicio.Size = New System.Drawing.Size(73, 20)
        Me.TbRangoInicio.TabIndex = 26
        '
        'TbLotID
        '
        Me.TbLotID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbLotID.Location = New System.Drawing.Point(89, 101)
        Me.TbLotID.Name = "TbLotID"
        Me.TbLotID.Size = New System.Drawing.Size(101, 20)
        Me.TbLotID.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Lot ID"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1180, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "ID Paquete HVI"
        '
        'TbIdPaqueteHVI
        '
        Me.TbIdPaqueteHVI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbIdPaqueteHVI.Location = New System.Drawing.Point(1268, 99)
        Me.TbIdPaqueteHVI.Name = "TbIdPaqueteHVI"
        Me.TbIdPaqueteHVI.ReadOnly = True
        Me.TbIdPaqueteHVI.Size = New System.Drawing.Size(100, 20)
        Me.TbIdPaqueteHVI.TabIndex = 22
        '
        'CbTipo
        '
        Me.CbTipo.FormattingEnabled = True
        Me.CbTipo.Location = New System.Drawing.Point(724, 127)
        Me.CbTipo.Name = "CbTipo"
        Me.CbTipo.Size = New System.Drawing.Size(121, 21)
        Me.CbTipo.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(612, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Tipo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1180, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "ID Liquidacion"
        '
        'TbIdLiquidacion
        '
        Me.TbIdLiquidacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbIdLiquidacion.Location = New System.Drawing.Point(1268, 73)
        Me.TbIdLiquidacion.Name = "TbIdLiquidacion"
        Me.TbIdLiquidacion.ReadOnly = True
        Me.TbIdLiquidacion.Size = New System.Drawing.Size(100, 20)
        Me.TbIdLiquidacion.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(612, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Tipo Paca"
        '
        'CbTipoPaca
        '
        Me.CbTipoPaca.FormattingEnabled = True
        Me.CbTipoPaca.Location = New System.Drawing.Point(724, 100)
        Me.CbTipoPaca.Name = "CbTipoPaca"
        Me.CbTipoPaca.Size = New System.Drawing.Size(121, 21)
        Me.CbTipoPaca.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1180, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "ID Produccion"
        '
        'TbIdProduccion
        '
        Me.TbIdProduccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbIdProduccion.Location = New System.Drawing.Point(1268, 47)
        Me.TbIdProduccion.Name = "TbIdProduccion"
        Me.TbIdProduccion.ReadOnly = True
        Me.TbIdProduccion.Size = New System.Drawing.Size(100, 20)
        Me.TbIdProduccion.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1180, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "ID Orden Trab"
        '
        'TbIdOrdenTrabajo
        '
        Me.TbIdOrdenTrabajo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbIdOrdenTrabajo.Location = New System.Drawing.Point(1268, 21)
        Me.TbIdOrdenTrabajo.Name = "TbIdOrdenTrabajo"
        Me.TbIdOrdenTrabajo.ReadOnly = True
        Me.TbIdOrdenTrabajo.Size = New System.Drawing.Size(100, 20)
        Me.TbIdOrdenTrabajo.TabIndex = 12
        '
        'CBPlantaDestino
        '
        Me.CBPlantaDestino.FormattingEnabled = True
        Me.CBPlantaDestino.Location = New System.Drawing.Point(89, 74)
        Me.CBPlantaDestino.Name = "CBPlantaDestino"
        Me.CBPlantaDestino.Size = New System.Drawing.Size(229, 21)
        Me.CBPlantaDestino.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Plada Destino"
        '
        'TbPredio
        '
        Me.TbPredio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbPredio.Location = New System.Drawing.Point(724, 74)
        Me.TbPredio.Name = "TbPredio"
        Me.TbPredio.Size = New System.Drawing.Size(121, 20)
        Me.TbPredio.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(612, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Predio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(612, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Variedad de Algodon"
        '
        'CbVariedad
        '
        Me.CbVariedad.FormattingEnabled = True
        Me.CbVariedad.Location = New System.Drawing.Point(724, 21)
        Me.CbVariedad.Name = "CbVariedad"
        Me.CbVariedad.Size = New System.Drawing.Size(121, 21)
        Me.CbVariedad.TabIndex = 6
        '
        'GbCentro
        '
        Me.GbCentro.Controls.Add(Me.DgvPacas)
        Me.GbCentro.Controls.Add(Me.Panel1)
        Me.GbCentro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbCentro.Location = New System.Drawing.Point(0, 189)
        Me.GbCentro.Name = "GbCentro"
        Me.GbCentro.Size = New System.Drawing.Size(1380, 514)
        Me.GbCentro.TabIndex = 9
        Me.GbCentro.TabStop = False
        '
        'DgvPacas
        '
        Me.DgvPacas.AllowUserToAddRows = False
        Me.DgvPacas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvPacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacas.Location = New System.Drawing.Point(3, 66)
        Me.DgvPacas.Name = "DgvPacas"
        Me.DgvPacas.ReadOnly = True
        Me.DgvPacas.Size = New System.Drawing.Size(1374, 445)
        Me.DgvPacas.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtCargaAccess)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TbTotalKilos)
        Me.Panel1.Controls.Add(Me.TbTotalPacas)
        Me.Panel1.Controls.Add(Me.BtCargaExcel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1374, 50)
        Me.Panel1.TabIndex = 0
        '
        'BtCargaAccess
        '
        Me.BtCargaAccess.BackgroundImage = CType(resources.GetObject("BtCargaAccess.BackgroundImage"), System.Drawing.Image)
        Me.BtCargaAccess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtCargaAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtCargaAccess.Location = New System.Drawing.Point(46, 3)
        Me.BtCargaAccess.Name = "BtCargaAccess"
        Me.BtCargaAccess.Size = New System.Drawing.Size(37, 35)
        Me.BtCargaAccess.TabIndex = 11
        Me.BtCargaAccess.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(315, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Total Kilos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(105, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Cantidad Pacas"
        '
        'TbTotalKilos
        '
        Me.TbTotalKilos.Location = New System.Drawing.Point(377, 18)
        Me.TbTotalKilos.Name = "TbTotalKilos"
        Me.TbTotalKilos.ReadOnly = True
        Me.TbTotalKilos.Size = New System.Drawing.Size(100, 20)
        Me.TbTotalKilos.TabIndex = 8
        '
        'TbTotalPacas
        '
        Me.TbTotalPacas.Location = New System.Drawing.Point(193, 18)
        Me.TbTotalPacas.Name = "TbTotalPacas"
        Me.TbTotalPacas.ReadOnly = True
        Me.TbTotalPacas.Size = New System.Drawing.Size(100, 20)
        Me.TbTotalPacas.TabIndex = 7
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CargaPacasExternas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1380, 703)
        Me.Controls.Add(Me.GbCentro)
        Me.Controls.Add(Me.GbEncabezado)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CargaPacasExternas"
        Me.Text = "Carga Pacas Externas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GbEncabezado.ResumeLayout(False)
        Me.GbEncabezado.PerformLayout()
        Me.GbCentro.ResumeLayout(False)
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtProductor As Button
    Friend WithEvents TbIdProductor As TextBox
    Friend WithEvents TbNombreProductor As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents CbPlantaOrigen As ComboBox
    Friend WithEvents BtCargaExcel As Button
    Friend WithEvents GbEncabezado As GroupBox
    Friend WithEvents GbCentro As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ExcelParaImportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DgvPacas As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents CbVariedad As ComboBox
    Friend WithEvents TbPredio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CBPlantaDestino As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbIdOrdenTrabajo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TbIdProduccion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CbTipoPaca As ComboBox
    Friend WithEvents TbTotalKilos As TextBox
    Friend WithEvents TbTotalPacas As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TbIdLiquidacion As TextBox
    Friend WithEvents CbTipo As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TbIdPaqueteHVI As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TbLotID As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TbRangoInicio As TextBox
    Friend WithEvents TbRangoFin As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TbNoModulos As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents BtCargaAccess As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
