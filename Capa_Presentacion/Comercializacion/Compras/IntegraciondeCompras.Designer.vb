<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IntegraciondeCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IntegraciondeCompras))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarIntegracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarIntegracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtSeleccionaXML = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.TbRfcEmisor = New System.Windows.Forms.TextBox()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.TbIdIntegracion = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TbTotalKilos = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TbImporteDls = New System.Windows.Forms.TextBox()
        Me.TbCastigoDls = New System.Windows.Forms.TextBox()
        Me.TbSubTotalDls = New System.Windows.Forms.TextBox()
        Me.DtFechaActualizacion = New System.Windows.Forms.DateTimePicker()
        Me.DtFechaCreacion = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbPacasCompra = New System.Windows.Forms.TextBox()
        Me.TbPrecioCompra = New System.Windows.Forms.TextBox()
        Me.TbIdContratoCompra = New System.Windows.Forms.TextBox()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.TbIDCliente = New System.Windows.Forms.TextBox()
        Me.TbIdCompra = New System.Windows.Forms.TextBox()
        Me.PanelCenter = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GbDetalleFactura = New System.Windows.Forms.GroupBox()
        Me.DgvData = New System.Windows.Forms.DataGridView()
        Me.GbDetalleFondo = New System.Windows.Forms.GroupBox()
        Me.GbFacturas = New System.Windows.Forms.GroupBox()
        Me.DgvFacturas = New System.Windows.Forms.DataGridView()
        Me.GbFacturasFondo = New System.Windows.Forms.GroupBox()
        Me.TbCantidadFacturas = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtQuitar = New System.Windows.Forms.Button()
        Me.BtQuitarXML = New System.Windows.Forms.Button()
        Me.BtSeleccionar = New System.Windows.Forms.Button()
        Me.Gb1 = New System.Windows.Forms.GroupBox()
        Me.TbTotalToneladasFacturas = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TbTotalPacasFacturas = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TbImporteTotalFacturas = New System.Windows.Forms.TextBox()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.PanelCenter.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GbDetalleFactura.SuspendLayout()
        CType(Me.DgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbFacturas.SuspendLayout()
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbFacturasFondo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Gb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.ConsultarIntegracionToolStripMenuItem, Me.GuardarIntegracionToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1415, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.BuscarToolStripMenuItem.Text = "Consultar Compra"
        '
        'GuardarIntegracionToolStripMenuItem
        '
        Me.GuardarIntegracionToolStripMenuItem.Name = "GuardarIntegracionToolStripMenuItem"
        Me.GuardarIntegracionToolStripMenuItem.Size = New System.Drawing.Size(124, 20)
        Me.GuardarIntegracionToolStripMenuItem.Text = "Guardar Integracion"
        '
        'ConsultarIntegracionToolStripMenuItem
        '
        Me.ConsultarIntegracionToolStripMenuItem.Name = "ConsultarIntegracionToolStripMenuItem"
        Me.ConsultarIntegracionToolStripMenuItem.Size = New System.Drawing.Size(133, 20)
        Me.ConsultarIntegracionToolStripMenuItem.Text = "Consultar Integracion"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'BtSeleccionaXML
        '
        Me.BtSeleccionaXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSeleccionaXML.Enabled = False
        Me.BtSeleccionaXML.Location = New System.Drawing.Point(1328, 131)
        Me.BtSeleccionaXML.Name = "BtSeleccionaXML"
        Me.BtSeleccionaXML.Size = New System.Drawing.Size(75, 23)
        Me.BtSeleccionaXML.TabIndex = 4
        Me.BtSeleccionaXML.Text = "Busca XML"
        Me.BtSeleccionaXML.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'TbRfcEmisor
        '
        Me.TbRfcEmisor.Location = New System.Drawing.Point(510, 55)
        Me.TbRfcEmisor.Name = "TbRfcEmisor"
        Me.TbRfcEmisor.ReadOnly = True
        Me.TbRfcEmisor.Size = New System.Drawing.Size(134, 20)
        Me.TbRfcEmisor.TabIndex = 7
        '
        'PanelTop
        '
        Me.PanelTop.Controls.Add(Me.TbIdIntegracion)
        Me.PanelTop.Controls.Add(Me.Label17)
        Me.PanelTop.Controls.Add(Me.TbTotalKilos)
        Me.PanelTop.Controls.Add(Me.Label15)
        Me.PanelTop.Controls.Add(Me.TbImporteDls)
        Me.PanelTop.Controls.Add(Me.TbCastigoDls)
        Me.PanelTop.Controls.Add(Me.TbSubTotalDls)
        Me.PanelTop.Controls.Add(Me.DtFechaActualizacion)
        Me.PanelTop.Controls.Add(Me.DtFechaCreacion)
        Me.PanelTop.Controls.Add(Me.Label7)
        Me.PanelTop.Controls.Add(Me.Label6)
        Me.PanelTop.Controls.Add(Me.Label10)
        Me.PanelTop.Controls.Add(Me.Label9)
        Me.PanelTop.Controls.Add(Me.Label5)
        Me.PanelTop.Controls.Add(Me.Label8)
        Me.PanelTop.Controls.Add(Me.Label12)
        Me.PanelTop.Controls.Add(Me.Label4)
        Me.PanelTop.Controls.Add(Me.Label3)
        Me.PanelTop.Controls.Add(Me.Label2)
        Me.PanelTop.Controls.Add(Me.Label1)
        Me.PanelTop.Controls.Add(Me.TbPacasCompra)
        Me.PanelTop.Controls.Add(Me.TbPrecioCompra)
        Me.PanelTop.Controls.Add(Me.TbIdContratoCompra)
        Me.PanelTop.Controls.Add(Me.TbNombre)
        Me.PanelTop.Controls.Add(Me.TbIDCliente)
        Me.PanelTop.Controls.Add(Me.TbIdCompra)
        Me.PanelTop.Controls.Add(Me.TbRfcEmisor)
        Me.PanelTop.Controls.Add(Me.BtSeleccionaXML)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 24)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1415, 164)
        Me.PanelTop.TabIndex = 8
        '
        'TbIdIntegracion
        '
        Me.TbIdIntegracion.Location = New System.Drawing.Point(343, 29)
        Me.TbIdIntegracion.Name = "TbIdIntegracion"
        Me.TbIdIntegracion.ReadOnly = True
        Me.TbIdIntegracion.Size = New System.Drawing.Size(100, 20)
        Me.TbIdIntegracion.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(260, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 13)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "ID Integracion "
        '
        'TbTotalKilos
        '
        Me.TbTotalKilos.Location = New System.Drawing.Point(75, 133)
        Me.TbTotalKilos.Name = "TbTotalKilos"
        Me.TbTotalKilos.ReadOnly = True
        Me.TbTotalKilos.Size = New System.Drawing.Size(100, 20)
        Me.TbTotalKilos.TabIndex = 21
        Me.TbTotalKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Toneladas"
        '
        'TbImporteDls
        '
        Me.TbImporteDls.Location = New System.Drawing.Point(327, 133)
        Me.TbImporteDls.Name = "TbImporteDls"
        Me.TbImporteDls.ReadOnly = True
        Me.TbImporteDls.Size = New System.Drawing.Size(134, 20)
        Me.TbImporteDls.TabIndex = 19
        Me.TbImporteDls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbCastigoDls
        '
        Me.TbCastigoDls.Location = New System.Drawing.Point(327, 107)
        Me.TbCastigoDls.Name = "TbCastigoDls"
        Me.TbCastigoDls.ReadOnly = True
        Me.TbCastigoDls.Size = New System.Drawing.Size(134, 20)
        Me.TbCastigoDls.TabIndex = 18
        Me.TbCastigoDls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbSubTotalDls
        '
        Me.TbSubTotalDls.Location = New System.Drawing.Point(327, 81)
        Me.TbSubTotalDls.Name = "TbSubTotalDls"
        Me.TbSubTotalDls.ReadOnly = True
        Me.TbSubTotalDls.Size = New System.Drawing.Size(134, 20)
        Me.TbSubTotalDls.TabIndex = 17
        Me.TbSubTotalDls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DtFechaActualizacion
        '
        Me.DtFechaActualizacion.Enabled = False
        Me.DtFechaActualizacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaActualizacion.Location = New System.Drawing.Point(579, 137)
        Me.DtFechaActualizacion.Name = "DtFechaActualizacion"
        Me.DtFechaActualizacion.Size = New System.Drawing.Size(159, 20)
        Me.DtFechaActualizacion.TabIndex = 16
        '
        'DtFechaCreacion
        '
        Me.DtFechaCreacion.Enabled = False
        Me.DtFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaCreacion.Location = New System.Drawing.Point(579, 108)
        Me.DtFechaCreacion.Name = "DtFechaCreacion"
        Me.DtFechaCreacion.Size = New System.Drawing.Size(159, 20)
        Me.DtFechaCreacion.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(476, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Actualizacion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(476, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Fecha de Creacion"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(260, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Subtotal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(260, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Castigo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "No. Pacas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(260, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Importe"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(476, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "RFC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Precio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "ID Contrato"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Productor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "ID Compra"
        '
        'TbPacasCompra
        '
        Me.TbPacasCompra.Location = New System.Drawing.Point(75, 107)
        Me.TbPacasCompra.Name = "TbPacasCompra"
        Me.TbPacasCompra.ReadOnly = True
        Me.TbPacasCompra.Size = New System.Drawing.Size(100, 20)
        Me.TbPacasCompra.TabIndex = 13
        Me.TbPacasCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbPrecioCompra
        '
        Me.TbPrecioCompra.Location = New System.Drawing.Point(75, 81)
        Me.TbPrecioCompra.Name = "TbPrecioCompra"
        Me.TbPrecioCompra.ReadOnly = True
        Me.TbPrecioCompra.Size = New System.Drawing.Size(100, 20)
        Me.TbPrecioCompra.TabIndex = 12
        Me.TbPrecioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbIdContratoCompra
        '
        Me.TbIdContratoCompra.Location = New System.Drawing.Point(75, 29)
        Me.TbIdContratoCompra.Name = "TbIdContratoCompra"
        Me.TbIdContratoCompra.ReadOnly = True
        Me.TbIdContratoCompra.Size = New System.Drawing.Size(100, 20)
        Me.TbIdContratoCompra.TabIndex = 11
        '
        'TbNombre
        '
        Me.TbNombre.Location = New System.Drawing.Point(181, 55)
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.ReadOnly = True
        Me.TbNombre.Size = New System.Drawing.Size(280, 20)
        Me.TbNombre.TabIndex = 10
        '
        'TbIDCliente
        '
        Me.TbIDCliente.Location = New System.Drawing.Point(75, 55)
        Me.TbIDCliente.Name = "TbIDCliente"
        Me.TbIDCliente.ReadOnly = True
        Me.TbIDCliente.Size = New System.Drawing.Size(100, 20)
        Me.TbIDCliente.TabIndex = 9
        '
        'TbIdCompra
        '
        Me.TbIdCompra.Location = New System.Drawing.Point(75, 3)
        Me.TbIdCompra.Name = "TbIdCompra"
        Me.TbIdCompra.ReadOnly = True
        Me.TbIdCompra.Size = New System.Drawing.Size(100, 20)
        Me.TbIdCompra.TabIndex = 8
        '
        'PanelCenter
        '
        Me.PanelCenter.Controls.Add(Me.Panel3)
        Me.PanelCenter.Controls.Add(Me.Gb1)
        Me.PanelCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCenter.Location = New System.Drawing.Point(0, 188)
        Me.PanelCenter.Name = "PanelCenter"
        Me.PanelCenter.Size = New System.Drawing.Size(1415, 353)
        Me.PanelCenter.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GbDetalleFactura)
        Me.Panel3.Controls.Add(Me.GbFacturas)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 97)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1415, 256)
        Me.Panel3.TabIndex = 0
        '
        'GbDetalleFactura
        '
        Me.GbDetalleFactura.Controls.Add(Me.DgvData)
        Me.GbDetalleFactura.Controls.Add(Me.GbDetalleFondo)
        Me.GbDetalleFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbDetalleFactura.Location = New System.Drawing.Point(867, 0)
        Me.GbDetalleFactura.Name = "GbDetalleFactura"
        Me.GbDetalleFactura.Size = New System.Drawing.Size(548, 256)
        Me.GbDetalleFactura.TabIndex = 1
        Me.GbDetalleFactura.TabStop = False
        Me.GbDetalleFactura.Text = "Detalles de facturas"
        '
        'DgvData
        '
        Me.DgvData.AllowUserToAddRows = False
        Me.DgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvData.Location = New System.Drawing.Point(3, 16)
        Me.DgvData.Name = "DgvData"
        Me.DgvData.ReadOnly = True
        Me.DgvData.Size = New System.Drawing.Size(542, 205)
        Me.DgvData.TabIndex = 7
        '
        'GbDetalleFondo
        '
        Me.GbDetalleFondo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GbDetalleFondo.Location = New System.Drawing.Point(3, 221)
        Me.GbDetalleFondo.Name = "GbDetalleFondo"
        Me.GbDetalleFondo.Size = New System.Drawing.Size(542, 32)
        Me.GbDetalleFondo.TabIndex = 8
        Me.GbDetalleFondo.TabStop = False
        '
        'GbFacturas
        '
        Me.GbFacturas.Controls.Add(Me.DgvFacturas)
        Me.GbFacturas.Controls.Add(Me.GbFacturasFondo)
        Me.GbFacturas.Controls.Add(Me.Panel1)
        Me.GbFacturas.Dock = System.Windows.Forms.DockStyle.Left
        Me.GbFacturas.Location = New System.Drawing.Point(0, 0)
        Me.GbFacturas.Name = "GbFacturas"
        Me.GbFacturas.Size = New System.Drawing.Size(867, 256)
        Me.GbFacturas.TabIndex = 0
        Me.GbFacturas.TabStop = False
        Me.GbFacturas.Text = "Facturas"
        '
        'DgvFacturas
        '
        Me.DgvFacturas.AllowUserToAddRows = False
        Me.DgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvFacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvFacturas.Location = New System.Drawing.Point(3, 16)
        Me.DgvFacturas.MultiSelect = False
        Me.DgvFacturas.Name = "DgvFacturas"
        Me.DgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvFacturas.Size = New System.Drawing.Size(824, 205)
        Me.DgvFacturas.TabIndex = 3
        '
        'GbFacturasFondo
        '
        Me.GbFacturasFondo.Controls.Add(Me.TbCantidadFacturas)
        Me.GbFacturasFondo.Controls.Add(Me.Label16)
        Me.GbFacturasFondo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GbFacturasFondo.Location = New System.Drawing.Point(3, 221)
        Me.GbFacturasFondo.Name = "GbFacturasFondo"
        Me.GbFacturasFondo.Size = New System.Drawing.Size(824, 32)
        Me.GbFacturasFondo.TabIndex = 4
        Me.GbFacturasFondo.TabStop = False
        '
        'TbCantidadFacturas
        '
        Me.TbCantidadFacturas.Location = New System.Drawing.Point(97, 9)
        Me.TbCantidadFacturas.Name = "TbCantidadFacturas"
        Me.TbCantidadFacturas.ReadOnly = True
        Me.TbCantidadFacturas.Size = New System.Drawing.Size(75, 20)
        Me.TbCantidadFacturas.TabIndex = 1
        Me.TbCantidadFacturas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "No de Facturas:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtQuitar)
        Me.Panel1.Controls.Add(Me.BtQuitarXML)
        Me.Panel1.Controls.Add(Me.BtSeleccionar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(827, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(37, 237)
        Me.Panel1.TabIndex = 2
        '
        'BtQuitar
        '
        Me.BtQuitar.BackgroundImage = CType(resources.GetObject("BtQuitar.BackgroundImage"), System.Drawing.Image)
        Me.BtQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtQuitar.Location = New System.Drawing.Point(3, 36)
        Me.BtQuitar.Name = "BtQuitar"
        Me.BtQuitar.Size = New System.Drawing.Size(32, 33)
        Me.BtQuitar.TabIndex = 23
        Me.BtQuitar.UseVisualStyleBackColor = True
        '
        'BtQuitarXML
        '
        Me.BtQuitarXML.Image = Global.Capa_Presentacion.My.Resources.Resources.quit
        Me.BtQuitarXML.Location = New System.Drawing.Point(3, 108)
        Me.BtQuitarXML.Name = "BtQuitarXML"
        Me.BtQuitarXML.Size = New System.Drawing.Size(32, 33)
        Me.BtQuitarXML.TabIndex = 2
        Me.BtQuitarXML.UseVisualStyleBackColor = True
        '
        'BtSeleccionar
        '
        Me.BtSeleccionar.BackgroundImage = CType(resources.GetObject("BtSeleccionar.BackgroundImage"), System.Drawing.Image)
        Me.BtSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtSeleccionar.Location = New System.Drawing.Point(3, 3)
        Me.BtSeleccionar.Name = "BtSeleccionar"
        Me.BtSeleccionar.Size = New System.Drawing.Size(32, 33)
        Me.BtSeleccionar.TabIndex = 22
        Me.BtSeleccionar.UseVisualStyleBackColor = True
        '
        'Gb1
        '
        Me.Gb1.Controls.Add(Me.TbTotalToneladasFacturas)
        Me.Gb1.Controls.Add(Me.Label14)
        Me.Gb1.Controls.Add(Me.Label13)
        Me.Gb1.Controls.Add(Me.TbTotalPacasFacturas)
        Me.Gb1.Controls.Add(Me.Label11)
        Me.Gb1.Controls.Add(Me.TbImporteTotalFacturas)
        Me.Gb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Gb1.Location = New System.Drawing.Point(0, 0)
        Me.Gb1.Name = "Gb1"
        Me.Gb1.Size = New System.Drawing.Size(1415, 97)
        Me.Gb1.TabIndex = 1
        Me.Gb1.TabStop = False
        '
        'TbTotalToneladasFacturas
        '
        Me.TbTotalToneladasFacturas.Location = New System.Drawing.Point(154, 39)
        Me.TbTotalToneladasFacturas.Name = "TbTotalToneladasFacturas"
        Me.TbTotalToneladasFacturas.ReadOnly = True
        Me.TbTotalToneladasFacturas.Size = New System.Drawing.Size(155, 20)
        Me.TbTotalToneladasFacturas.TabIndex = 5
        Me.TbTotalToneladasFacturas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Total Toneladas de facturas"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Total Pacas de facturas"
        '
        'TbTotalPacasFacturas
        '
        Me.TbTotalPacasFacturas.Location = New System.Drawing.Point(154, 65)
        Me.TbTotalPacasFacturas.Name = "TbTotalPacasFacturas"
        Me.TbTotalPacasFacturas.ReadOnly = True
        Me.TbTotalPacasFacturas.Size = New System.Drawing.Size(155, 20)
        Me.TbTotalPacasFacturas.TabIndex = 2
        Me.TbTotalPacasFacturas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Importe total de facturas"
        '
        'TbImporteTotalFacturas
        '
        Me.TbImporteTotalFacturas.Location = New System.Drawing.Point(154, 13)
        Me.TbImporteTotalFacturas.Name = "TbImporteTotalFacturas"
        Me.TbImporteTotalFacturas.ReadOnly = True
        Me.TbImporteTotalFacturas.Size = New System.Drawing.Size(155, 20)
        Me.TbImporteTotalFacturas.TabIndex = 0
        Me.TbImporteTotalFacturas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PanelBottom
        '
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 541)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(1415, 155)
        Me.PanelBottom.TabIndex = 0
        '
        'IntegraciondeCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1415, 696)
        Me.Controls.Add(Me.PanelCenter)
        Me.Controls.Add(Me.PanelBottom)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "IntegraciondeCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Integracion de Compras"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.PanelCenter.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GbDetalleFactura.ResumeLayout(False)
        CType(Me.DgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbFacturas.ResumeLayout(False)
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbFacturasFondo.ResumeLayout(False)
        Me.GbFacturasFondo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Gb1.ResumeLayout(False)
        Me.Gb1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtSeleccionaXML As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents TbRfcEmisor As TextBox
    Friend WithEvents PanelTop As Panel
    Friend WithEvents PanelCenter As Panel
    Friend WithEvents Gb1 As GroupBox
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GbDetalleFactura As GroupBox
    Friend WithEvents GbFacturas As GroupBox
    Friend WithEvents DgvData As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TbPacasCompra As TextBox
    Friend WithEvents TbPrecioCompra As TextBox
    Friend WithEvents TbIdContratoCompra As TextBox
    Friend WithEvents TbNombre As TextBox
    Friend WithEvents TbIDCliente As TextBox
    Friend WithEvents TbIdCompra As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DtFechaActualizacion As DateTimePicker
    Friend WithEvents DtFechaCreacion As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TbImporteDls As TextBox
    Friend WithEvents TbCastigoDls As TextBox
    Friend WithEvents TbSubTotalDls As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DgvFacturas As DataGridView
    Friend WithEvents TbImporteTotalFacturas As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents BtQuitarXML As Button
    Friend WithEvents GuardarIntegracionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label12 As Label
    Friend WithEvents TbTotalPacasFacturas As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TbTotalToneladasFacturas As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TbTotalKilos As TextBox
    Friend WithEvents ConsultarIntegracionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtQuitar As Button
    Friend WithEvents BtSeleccionar As Button
    Friend WithEvents GbFacturasFondo As GroupBox
    Friend WithEvents GbDetalleFondo As GroupBox
    Friend WithEvents TbCantidadFacturas As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TbIdIntegracion As TextBox
    Friend WithEvents Label17 As Label
End Class
