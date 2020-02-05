<CompilerServices.DesignerGenerated()>
Partial Class VentaPacasContrato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentaPacasContrato))
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DgvContratos = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CbModalidadVenta = New System.Windows.Forms.ComboBox()
        Me.TbValorConversion = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.CbUnidadPeso = New System.Windows.Forms.ComboBox()
        Me.TbKdAd = New System.Windows.Forms.TextBox()
        Me.CkKgAdd = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbIdVentaPaca = New System.Windows.Forms.TextBox()
        Me.BtnBuscarProd = New System.Windows.Forms.Button()
        Me.TbIdComprador = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbNoPacas = New System.Windows.Forms.TextBox()
        Me.CbPlanta = New System.Windows.Forms.ComboBox()
        Me.TbIdContrato = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.TbPrecioQuintal = New System.Windows.Forms.TextBox()
        Me.TbNombreComprador = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtModalidadVenta = New System.Windows.Forms.Button()
        Me.BtCastigoResFibra = New System.Windows.Forms.Button()
        Me.BtCastigoMicros = New System.Windows.Forms.Button()
        Me.BtCastLarFib = New System.Windows.Forms.Button()
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComparacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteHVIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbCompras = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DgvAgrupadasClases = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TbKilosVendidasGral = New System.Windows.Forms.TextBox()
        Me.TbPacasVendidasGral = New System.Windows.Forms.TextBox()
        Me.TbPacasDisp = New System.Windows.Forms.TextBox()
        Me.TbPacasContratadas = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvAgrupadasCliente = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TcCompras = New System.Windows.Forms.TabControl()
        Me.TP1LiquidacionesAVender = New System.Windows.Forms.TabPage()
        Me.DgvDatosLiquidacion = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TP3PacasAVender = New System.Windows.Forms.TabPage()
        Me.DgvPacasVender = New System.Windows.Forms.DataGridView()
        Me.GbFiltrado = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.BtDesmarcaTodo = New System.Windows.Forms.Button()
        Me.CbPlantaVender = New System.Windows.Forms.ComboBox()
        Me.BtMarcarTodo = New System.Windows.Forms.Button()
        Me.TbIdPaqVtaVender = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtFiltro = New System.Windows.Forms.Button()
        Me.BtReiniciaFiltro = New System.Windows.Forms.Button()
        Me.CbClasesPacasAVender = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbHastaPaca = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TbDesdePaca = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtSeleccionar2 = New System.Windows.Forms.Button()
        Me.BtSeleccionar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TP2LiquidacionesVendidas = New System.Windows.Forms.TabPage()
        Me.DgvLiqVendidas = New System.Windows.Forms.DataGridView()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TP4IndividualVendidas = New System.Windows.Forms.TabPage()
        Me.DgvPacasIndVendidas = New System.Windows.Forms.DataGridView()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.CbPlantaVendidas = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbIdPaqVtaVendida = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.BtFiltroCompra = New System.Windows.Forms.Button()
        Me.BtReiniciaFiltroCompra = New System.Windows.Forms.Button()
        Me.CbClasesVendidas = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TbDesdePacaCompra = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TbHastaPacaCompra = New System.Windows.Forms.TextBox()
        Me.GbCompraActual = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbPacasVendidasContrato = New System.Windows.Forms.TextBox()
        Me.TbPacasMarc = New System.Windows.Forms.TextBox()
        Me.TbKilosVendidos = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.BtRecalcular = New System.Windows.Forms.Button()
        Me.GbDatosGenerales.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DgvContratos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MSMenu.SuspendLayout()
        Me.GbCompras.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DgvAgrupadasClases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvAgrupadasCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TcCompras.SuspendLayout()
        Me.TP1LiquidacionesAVender.SuspendLayout()
        CType(Me.DgvDatosLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP3PacasAVender.SuspendLayout()
        CType(Me.DgvPacasVender, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbFiltrado.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TP2LiquidacionesVendidas.SuspendLayout()
        CType(Me.DgvLiqVendidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.TP4IndividualVendidas.SuspendLayout()
        CType(Me.DgvPacasIndVendidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GbCompraActual.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.Controls.Add(Me.GroupBox6)
        Me.GbDatosGenerales.Controls.Add(Me.GroupBox5)
        Me.GbDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatosGenerales.Location = New System.Drawing.Point(0, 24)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(1728, 178)
        Me.GbDatosGenerales.TabIndex = 4
        Me.GbDatosGenerales.TabStop = False
        Me.GbDatosGenerales.Text = "Datos Generales"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DgvContratos)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Location = New System.Drawing.Point(979, 16)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(746, 159)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Contratos"
        '
        'DgvContratos
        '
        Me.DgvContratos.AllowUserToAddRows = False
        Me.DgvContratos.AllowUserToDeleteRows = False
        Me.DgvContratos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvContratos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvContratos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvContratos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvContratos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvContratos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvContratos.Location = New System.Drawing.Point(3, 16)
        Me.DgvContratos.MultiSelect = False
        Me.DgvContratos.Name = "DgvContratos"
        Me.DgvContratos.RowHeadersVisible = False
        Me.DgvContratos.RowHeadersWidth = 40
        Me.DgvContratos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvContratos.Size = New System.Drawing.Size(740, 140)
        Me.DgvContratos.TabIndex = 12
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Panel3)
        Me.GroupBox5.Controls.Add(Me.Panel2)
        Me.GroupBox5.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox5.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(976, 159)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.CbModalidadVenta)
        Me.Panel3.Controls.Add(Me.TbValorConversion)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.CbUnidadPeso)
        Me.Panel3.Controls.Add(Me.TbKdAd)
        Me.Panel3.Controls.Add(Me.CkKgAdd)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.TbIdVentaPaca)
        Me.Panel3.Controls.Add(Me.BtnBuscarProd)
        Me.Panel3.Controls.Add(Me.TbIdComprador)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.Label27)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.TbNoPacas)
        Me.Panel3.Controls.Add(Me.CbPlanta)
        Me.Panel3.Controls.Add(Me.TbIdContrato)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.DtpFecha)
        Me.Panel3.Controls.Add(Me.TbPrecioQuintal)
        Me.Panel3.Controls.Add(Me.TbNombreComprador)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(835, 140)
        Me.Panel3.TabIndex = 57
        '
        'CbModalidadVenta
        '
        Me.CbModalidadVenta.Enabled = False
        Me.CbModalidadVenta.FormattingEnabled = True
        Me.CbModalidadVenta.Location = New System.Drawing.Point(528, 28)
        Me.CbModalidadVenta.Name = "CbModalidadVenta"
        Me.CbModalidadVenta.Size = New System.Drawing.Size(146, 21)
        Me.CbModalidadVenta.TabIndex = 60
        '
        'TbValorConversion
        '
        Me.TbValorConversion.Enabled = False
        Me.TbValorConversion.Location = New System.Drawing.Point(655, 54)
        Me.TbValorConversion.Name = "TbValorConversion"
        Me.TbValorConversion.Size = New System.Drawing.Size(75, 20)
        Me.TbValorConversion.TabIndex = 59
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(493, 108)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(34, 12)
        Me.Label26.TabIndex = 60
        Me.Label26.Text = "Planta:"
        '
        'CbUnidadPeso
        '
        Me.CbUnidadPeso.Enabled = False
        Me.CbUnidadPeso.FormattingEnabled = True
        Me.CbUnidadPeso.Location = New System.Drawing.Point(528, 53)
        Me.CbUnidadPeso.Name = "CbUnidadPeso"
        Me.CbUnidadPeso.Size = New System.Drawing.Size(121, 21)
        Me.CbUnidadPeso.TabIndex = 58
        '
        'TbKdAd
        '
        Me.TbKdAd.Location = New System.Drawing.Point(319, 54)
        Me.TbKdAd.Name = "TbKdAd"
        Me.TbKdAd.Size = New System.Drawing.Size(72, 20)
        Me.TbKdAd.TabIndex = 57
        Me.TbKdAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TbKdAd.Visible = False
        '
        'CkKgAdd
        '
        Me.CkKgAdd.AutoSize = True
        Me.CkKgAdd.Location = New System.Drawing.Point(319, 30)
        Me.CkKgAdd.Name = "CkKgAdd"
        Me.CkKgAdd.Size = New System.Drawing.Size(55, 17)
        Me.CkKgAdd.TabIndex = 56
        Me.CkKgAdd.Text = "Kg Ad"
        Me.CkKgAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "ID Venta"
        Me.Label1.UseWaitCursor = True
        '
        'TbIdVentaPaca
        '
        Me.TbIdVentaPaca.Enabled = False
        Me.TbIdVentaPaca.Location = New System.Drawing.Point(111, 4)
        Me.TbIdVentaPaca.Name = "TbIdVentaPaca"
        Me.TbIdVentaPaca.Size = New System.Drawing.Size(99, 20)
        Me.TbIdVentaPaca.TabIndex = 17
        Me.TbIdVentaPaca.UseWaitCursor = True
        '
        'BtnBuscarProd
        '
        Me.BtnBuscarProd.Location = New System.Drawing.Point(680, 2)
        Me.BtnBuscarProd.Name = "BtnBuscarProd"
        Me.BtnBuscarProd.Size = New System.Drawing.Size(41, 23)
        Me.BtnBuscarProd.TabIndex = 55
        Me.BtnBuscarProd.Text = "..."
        Me.BtnBuscarProd.UseVisualStyleBackColor = True
        '
        'TbIdComprador
        '
        Me.TbIdComprador.Enabled = False
        Me.TbIdComprador.Location = New System.Drawing.Point(288, 4)
        Me.TbIdComprador.Name = "TbIdComprador"
        Me.TbIdComprador.Size = New System.Drawing.Size(75, 20)
        Me.TbIdComprador.TabIndex = 18
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(420, 57)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(83, 13)
        Me.Label21.TabIndex = 46
        Me.Label21.Text = "Unidad de Peso"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(420, 31)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(102, 13)
        Me.Label27.TabIndex = 46
        Me.Label27.Text = "Modalidad de Venta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "No. Pacas"
        '
        'TbNoPacas
        '
        Me.TbNoPacas.Enabled = False
        Me.TbNoPacas.Location = New System.Drawing.Point(111, 78)
        Me.TbNoPacas.Name = "TbNoPacas"
        Me.TbNoPacas.Size = New System.Drawing.Size(202, 20)
        Me.TbNoPacas.TabIndex = 39
        '
        'CbPlanta
        '
        Me.CbPlanta.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbPlanta.FormattingEnabled = True
        Me.CbPlanta.Location = New System.Drawing.Point(528, 104)
        Me.CbPlanta.Name = "CbPlanta"
        Me.CbPlanta.Size = New System.Drawing.Size(86, 20)
        Me.CbPlanta.TabIndex = 20
        '
        'TbIdContrato
        '
        Me.TbIdContrato.Enabled = False
        Me.TbIdContrato.Location = New System.Drawing.Point(111, 28)
        Me.TbIdContrato.Name = "TbIdContrato"
        Me.TbIdContrato.Size = New System.Drawing.Size(202, 20)
        Me.TbIdContrato.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Id Contrato"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 13)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Precio Quintal"
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(528, 78)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(139, 20)
        Me.DtpFecha.TabIndex = 29
        '
        'TbPrecioQuintal
        '
        Me.TbPrecioQuintal.Enabled = False
        Me.TbPrecioQuintal.Location = New System.Drawing.Point(111, 54)
        Me.TbPrecioQuintal.Name = "TbPrecioQuintal"
        Me.TbPrecioQuintal.Size = New System.Drawing.Size(202, 20)
        Me.TbPrecioQuintal.TabIndex = 44
        '
        'TbNombreComprador
        '
        Me.TbNombreComprador.Enabled = False
        Me.TbNombreComprador.Location = New System.Drawing.Point(369, 4)
        Me.TbNombreComprador.Name = "TbNombreComprador"
        Me.TbNombreComprador.Size = New System.Drawing.Size(305, 20)
        Me.TbNombreComprador.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(420, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(223, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Comprador"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtModalidadVenta)
        Me.Panel2.Controls.Add(Me.BtCastigoResFibra)
        Me.Panel2.Controls.Add(Me.BtCastigoMicros)
        Me.Panel2.Controls.Add(Me.BtCastLarFib)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(838, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(135, 140)
        Me.Panel2.TabIndex = 56
        '
        'BtModalidadVenta
        '
        Me.BtModalidadVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtModalidadVenta.Location = New System.Drawing.Point(3, 3)
        Me.BtModalidadVenta.MaximumSize = New System.Drawing.Size(60, 60)
        Me.BtModalidadVenta.MinimumSize = New System.Drawing.Size(60, 60)
        Me.BtModalidadVenta.Name = "BtModalidadVenta"
        Me.BtModalidadVenta.Size = New System.Drawing.Size(60, 60)
        Me.BtModalidadVenta.TabIndex = 51
        Me.BtModalidadVenta.Text = "Modalidad de Venta"
        Me.BtModalidadVenta.UseVisualStyleBackColor = True
        '
        'BtCastigoResFibra
        '
        Me.BtCastigoResFibra.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCastigoResFibra.Location = New System.Drawing.Point(69, 3)
        Me.BtCastigoResFibra.MaximumSize = New System.Drawing.Size(60, 60)
        Me.BtCastigoResFibra.MinimumSize = New System.Drawing.Size(60, 60)
        Me.BtCastigoResFibra.Name = "BtCastigoResFibra"
        Me.BtCastigoResFibra.Size = New System.Drawing.Size(60, 60)
        Me.BtCastigoResFibra.TabIndex = 52
        Me.BtCastigoResFibra.Text = "Castigos por resistencia de fibra"
        Me.BtCastigoResFibra.UseVisualStyleBackColor = True
        '
        'BtCastigoMicros
        '
        Me.BtCastigoMicros.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCastigoMicros.Location = New System.Drawing.Point(3, 69)
        Me.BtCastigoMicros.MaximumSize = New System.Drawing.Size(60, 60)
        Me.BtCastigoMicros.MinimumSize = New System.Drawing.Size(60, 60)
        Me.BtCastigoMicros.Name = "BtCastigoMicros"
        Me.BtCastigoMicros.Size = New System.Drawing.Size(60, 60)
        Me.BtCastigoMicros.TabIndex = 53
        Me.BtCastigoMicros.Text = "Castigo por micros"
        Me.BtCastigoMicros.UseVisualStyleBackColor = True
        '
        'BtCastLarFib
        '
        Me.BtCastLarFib.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCastLarFib.Location = New System.Drawing.Point(69, 69)
        Me.BtCastLarFib.MaximumSize = New System.Drawing.Size(60, 60)
        Me.BtCastLarFib.MinimumSize = New System.Drawing.Size(60, 60)
        Me.BtCastLarFib.Name = "BtCastLarFib"
        Me.BtCastLarFib.Size = New System.Drawing.Size(60, 60)
        Me.BtCastLarFib.TabIndex = 54
        Me.BtCastLarFib.Text = "Castigos por largo de fibra"
        Me.BtCastLarFib.UseVisualStyleBackColor = True
        '
        'MSMenu
        '
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.ComparacionToolStripMenuItem, Me.ReporteHVIToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(1728, 24)
        Me.MSMenu.TabIndex = 3
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = CType(resources.GetObject("NuevoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Image = CType(resources.GetObject("GuardarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Image = CType(resources.GetObject("ConsultarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.ConsultarToolStripMenuItem.Text = "Consultar Venta"
        '
        'ComparacionToolStripMenuItem
        '
        Me.ComparacionToolStripMenuItem.Name = "ComparacionToolStripMenuItem"
        Me.ComparacionToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.ComparacionToolStripMenuItem.Text = "Comparacion"
        '
        'ReporteHVIToolStripMenuItem
        '
        Me.ReporteHVIToolStripMenuItem.Image = CType(resources.GetObject("ReporteHVIToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReporteHVIToolStripMenuItem.Name = "ReporteHVIToolStripMenuItem"
        Me.ReporteHVIToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.ReporteHVIToolStripMenuItem.Text = "Reporte HVI"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GbCompras
        '
        Me.GbCompras.Controls.Add(Me.GroupBox4)
        Me.GbCompras.Controls.Add(Me.GroupBox2)
        Me.GbCompras.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GbCompras.Location = New System.Drawing.Point(0, 557)
        Me.GbCompras.Name = "GbCompras"
        Me.GbCompras.Size = New System.Drawing.Size(1728, 186)
        Me.GbCompras.TabIndex = 5
        Me.GbCompras.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DgvAgrupadasClases)
        Me.GroupBox4.Controls.Add(Me.Panel1)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(378, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1347, 167)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        '
        'DgvAgrupadasClases
        '
        Me.DgvAgrupadasClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAgrupadasClases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvAgrupadasClases.Location = New System.Drawing.Point(3, 16)
        Me.DgvAgrupadasClases.Name = "DgvAgrupadasClases"
        Me.DgvAgrupadasClases.Size = New System.Drawing.Size(585, 148)
        Me.DgvAgrupadasClases.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.TbKilosVendidasGral)
        Me.Panel1.Controls.Add(Me.TbPacasVendidasGral)
        Me.Panel1.Controls.Add(Me.TbPacasDisp)
        Me.Panel1.Controls.Add(Me.TbPacasContratadas)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(588, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(756, 148)
        Me.Panel1.TabIndex = 4
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.Control
        Me.Label23.Location = New System.Drawing.Point(268, 37)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(90, 13)
        Me.Label23.TabIndex = 28
        Me.Label23.Text = "Kilos Vendidos"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.Control
        Me.Label22.Location = New System.Drawing.Point(268, 11)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(98, 13)
        Me.Label22.TabIndex = 27
        Me.Label22.Text = "Pacas Vendidas"
        '
        'TbKilosVendidasGral
        '
        Me.TbKilosVendidasGral.Enabled = False
        Me.TbKilosVendidasGral.Location = New System.Drawing.Point(388, 34)
        Me.TbKilosVendidasGral.Name = "TbKilosVendidasGral"
        Me.TbKilosVendidasGral.Size = New System.Drawing.Size(100, 20)
        Me.TbKilosVendidasGral.TabIndex = 26
        Me.TbKilosVendidasGral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbPacasVendidasGral
        '
        Me.TbPacasVendidasGral.Enabled = False
        Me.TbPacasVendidasGral.Location = New System.Drawing.Point(388, 8)
        Me.TbPacasVendidasGral.Name = "TbPacasVendidasGral"
        Me.TbPacasVendidasGral.Size = New System.Drawing.Size(100, 20)
        Me.TbPacasVendidasGral.TabIndex = 25
        Me.TbPacasVendidasGral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbPacasDisp
        '
        Me.TbPacasDisp.Enabled = False
        Me.TbPacasDisp.Location = New System.Drawing.Point(162, 34)
        Me.TbPacasDisp.Name = "TbPacasDisp"
        Me.TbPacasDisp.Size = New System.Drawing.Size(100, 20)
        Me.TbPacasDisp.TabIndex = 20
        Me.TbPacasDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbPacasContratadas
        '
        Me.TbPacasContratadas.Enabled = False
        Me.TbPacasContratadas.Location = New System.Drawing.Point(162, 8)
        Me.TbPacasContratadas.Name = "TbPacasContratadas"
        Me.TbPacasContratadas.Size = New System.Drawing.Size(100, 20)
        Me.TbPacasContratadas.TabIndex = 19
        Me.TbPacasContratadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.Control
        Me.Label19.Location = New System.Drawing.Point(6, 37)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(109, 13)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Pacas disponibles"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Control
        Me.Label18.Location = New System.Drawing.Point(6, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(113, 13)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Pacas contratadas"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.LightPink
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(123, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Agrupadas por clase"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvAgrupadasCliente)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 167)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'DgvAgrupadasCliente
        '
        Me.DgvAgrupadasCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAgrupadasCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvAgrupadasCliente.Location = New System.Drawing.Point(3, 16)
        Me.DgvAgrupadasCliente.Name = "DgvAgrupadasCliente"
        Me.DgvAgrupadasCliente.Size = New System.Drawing.Size(369, 148)
        Me.DgvAgrupadasCliente.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightPink
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Agrupadas por cliente"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 202)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1728, 355)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.TcCompras)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.TabControl1)
        Me.Panel4.Controls.Add(Me.GbCompraActual)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 16)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1722, 336)
        Me.Panel4.TabIndex = 7
        '
        'TcCompras
        '
        Me.TcCompras.Controls.Add(Me.TP1LiquidacionesAVender)
        Me.TcCompras.Controls.Add(Me.TP3PacasAVender)
        Me.TcCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TcCompras.Location = New System.Drawing.Point(0, 0)
        Me.TcCompras.Name = "TcCompras"
        Me.TcCompras.SelectedIndex = 0
        Me.TcCompras.Size = New System.Drawing.Size(855, 281)
        Me.TcCompras.TabIndex = 1
        '
        'TP1LiquidacionesAVender
        '
        Me.TP1LiquidacionesAVender.BackColor = System.Drawing.Color.Transparent
        Me.TP1LiquidacionesAVender.Controls.Add(Me.DgvDatosLiquidacion)
        Me.TP1LiquidacionesAVender.Controls.Add(Me.GroupBox3)
        Me.TP1LiquidacionesAVender.Location = New System.Drawing.Point(4, 22)
        Me.TP1LiquidacionesAVender.Name = "TP1LiquidacionesAVender"
        Me.TP1LiquidacionesAVender.Padding = New System.Windows.Forms.Padding(3)
        Me.TP1LiquidacionesAVender.Size = New System.Drawing.Size(847, 255)
        Me.TP1LiquidacionesAVender.TabIndex = 0
        Me.TP1LiquidacionesAVender.Text = "Liquidaciones a Vender"
        '
        'DgvDatosLiquidacion
        '
        Me.DgvDatosLiquidacion.AllowUserToAddRows = False
        Me.DgvDatosLiquidacion.AllowUserToDeleteRows = False
        Me.DgvDatosLiquidacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvDatosLiquidacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvDatosLiquidacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvDatosLiquidacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvDatosLiquidacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDatosLiquidacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvDatosLiquidacion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvDatosLiquidacion.Location = New System.Drawing.Point(3, 48)
        Me.DgvDatosLiquidacion.MultiSelect = False
        Me.DgvDatosLiquidacion.Name = "DgvDatosLiquidacion"
        Me.DgvDatosLiquidacion.RowHeadersVisible = False
        Me.DgvDatosLiquidacion.RowHeadersWidth = 40
        Me.DgvDatosLiquidacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDatosLiquidacion.Size = New System.Drawing.Size(841, 204)
        Me.DgvDatosLiquidacion.TabIndex = 13
        '
        'GroupBox3
        '
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(841, 45)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        '
        'TP3PacasAVender
        '
        Me.TP3PacasAVender.Controls.Add(Me.DgvPacasVender)
        Me.TP3PacasAVender.Controls.Add(Me.GbFiltrado)
        Me.TP3PacasAVender.Location = New System.Drawing.Point(4, 22)
        Me.TP3PacasAVender.Name = "TP3PacasAVender"
        Me.TP3PacasAVender.Padding = New System.Windows.Forms.Padding(3)
        Me.TP3PacasAVender.Size = New System.Drawing.Size(847, 255)
        Me.TP3PacasAVender.TabIndex = 2
        Me.TP3PacasAVender.Text = "Pacas a Vender"
        Me.TP3PacasAVender.UseVisualStyleBackColor = True
        '
        'DgvPacasVender
        '
        Me.DgvPacasVender.AllowUserToAddRows = False
        Me.DgvPacasVender.AllowUserToDeleteRows = False
        Me.DgvPacasVender.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacasVender.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvPacasVender.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvPacasVender.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvPacasVender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacasVender.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacasVender.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvPacasVender.Location = New System.Drawing.Point(3, 48)
        Me.DgvPacasVender.MultiSelect = False
        Me.DgvPacasVender.Name = "DgvPacasVender"
        Me.DgvPacasVender.RowHeadersVisible = False
        Me.DgvPacasVender.RowHeadersWidth = 40
        Me.DgvPacasVender.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPacasVender.Size = New System.Drawing.Size(841, 204)
        Me.DgvPacasVender.TabIndex = 15
        '
        'GbFiltrado
        '
        Me.GbFiltrado.Controls.Add(Me.Label28)
        Me.GbFiltrado.Controls.Add(Me.BtDesmarcaTodo)
        Me.GbFiltrado.Controls.Add(Me.CbPlantaVender)
        Me.GbFiltrado.Controls.Add(Me.BtMarcarTodo)
        Me.GbFiltrado.Controls.Add(Me.TbIdPaqVtaVender)
        Me.GbFiltrado.Controls.Add(Me.Label8)
        Me.GbFiltrado.Controls.Add(Me.BtFiltro)
        Me.GbFiltrado.Controls.Add(Me.BtReiniciaFiltro)
        Me.GbFiltrado.Controls.Add(Me.CbClasesPacasAVender)
        Me.GbFiltrado.Controls.Add(Me.Label9)
        Me.GbFiltrado.Controls.Add(Me.TbHastaPaca)
        Me.GbFiltrado.Controls.Add(Me.Label11)
        Me.GbFiltrado.Controls.Add(Me.Label10)
        Me.GbFiltrado.Controls.Add(Me.TbDesdePaca)
        Me.GbFiltrado.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbFiltrado.Location = New System.Drawing.Point(3, 3)
        Me.GbFiltrado.Name = "GbFiltrado"
        Me.GbFiltrado.Size = New System.Drawing.Size(841, 45)
        Me.GbFiltrado.TabIndex = 3
        Me.GbFiltrado.TabStop = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(387, 21)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(34, 12)
        Me.Label28.TabIndex = 62
        Me.Label28.Text = "Planta:"
        '
        'BtDesmarcaTodo
        '
        Me.BtDesmarcaTodo.BackgroundImage = CType(resources.GetObject("BtDesmarcaTodo.BackgroundImage"), System.Drawing.Image)
        Me.BtDesmarcaTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtDesmarcaTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtDesmarcaTodo.Location = New System.Drawing.Point(569, 16)
        Me.BtDesmarcaTodo.MaximumSize = New System.Drawing.Size(25, 23)
        Me.BtDesmarcaTodo.MinimumSize = New System.Drawing.Size(25, 23)
        Me.BtDesmarcaTodo.Name = "BtDesmarcaTodo"
        Me.BtDesmarcaTodo.Size = New System.Drawing.Size(25, 23)
        Me.BtDesmarcaTodo.TabIndex = 62
        Me.BtDesmarcaTodo.Tag = "Deseleccionar todo"
        Me.BtDesmarcaTodo.UseVisualStyleBackColor = True
        '
        'CbPlantaVender
        '
        Me.CbPlantaVender.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbPlantaVender.FormattingEnabled = True
        Me.CbPlantaVender.Location = New System.Drawing.Point(422, 17)
        Me.CbPlantaVender.Name = "CbPlantaVender"
        Me.CbPlantaVender.Size = New System.Drawing.Size(110, 20)
        Me.CbPlantaVender.TabIndex = 61
        '
        'BtMarcarTodo
        '
        Me.BtMarcarTodo.BackgroundImage = CType(resources.GetObject("BtMarcarTodo.BackgroundImage"), System.Drawing.Image)
        Me.BtMarcarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtMarcarTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtMarcarTodo.Location = New System.Drawing.Point(538, 16)
        Me.BtMarcarTodo.MaximumSize = New System.Drawing.Size(25, 23)
        Me.BtMarcarTodo.MinimumSize = New System.Drawing.Size(25, 23)
        Me.BtMarcarTodo.Name = "BtMarcarTodo"
        Me.BtMarcarTodo.Size = New System.Drawing.Size(25, 23)
        Me.BtMarcarTodo.TabIndex = 61
        Me.BtMarcarTodo.Tag = "Seleccionar todo"
        Me.BtMarcarTodo.UseVisualStyleBackColor = True
        '
        'TbIdPaqVtaVender
        '
        Me.TbIdPaqVtaVender.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbIdPaqVtaVender.Location = New System.Drawing.Point(315, 18)
        Me.TbIdPaqVtaVender.Name = "TbIdPaqVtaVender"
        Me.TbIdPaqVtaVender.Size = New System.Drawing.Size(66, 18)
        Me.TbIdPaqVtaVender.TabIndex = 59
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(275, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 24)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Paquete " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vta:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtFiltro
        '
        Me.BtFiltro.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtFiltro.Location = New System.Drawing.Point(703, 16)
        Me.BtFiltro.MaximumSize = New System.Drawing.Size(65, 23)
        Me.BtFiltro.MinimumSize = New System.Drawing.Size(65, 23)
        Me.BtFiltro.Name = "BtFiltro"
        Me.BtFiltro.Size = New System.Drawing.Size(65, 23)
        Me.BtFiltro.TabIndex = 57
        Me.BtFiltro.Text = "Aplicar Filtro"
        Me.BtFiltro.UseVisualStyleBackColor = True
        '
        'BtReiniciaFiltro
        '
        Me.BtReiniciaFiltro.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtReiniciaFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtReiniciaFiltro.Location = New System.Drawing.Point(768, 16)
        Me.BtReiniciaFiltro.MaximumSize = New System.Drawing.Size(70, 23)
        Me.BtReiniciaFiltro.MinimumSize = New System.Drawing.Size(70, 23)
        Me.BtReiniciaFiltro.Name = "BtReiniciaFiltro"
        Me.BtReiniciaFiltro.Size = New System.Drawing.Size(70, 23)
        Me.BtReiniciaFiltro.TabIndex = 57
        Me.BtReiniciaFiltro.Text = "Reinicia Filtro"
        Me.BtReiniciaFiltro.UseVisualStyleBackColor = True
        '
        'CbClasesPacasAVender
        '
        Me.CbClasesPacasAVender.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbClasesPacasAVender.FormattingEnabled = True
        Me.CbClasesPacasAVender.Location = New System.Drawing.Point(206, 17)
        Me.CbClasesPacasAVender.Name = "CbClasesPacasAVender"
        Me.CbClasesPacasAVender.Size = New System.Drawing.Size(66, 20)
        Me.CbClasesPacasAVender.TabIndex = 56
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(175, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 24)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Filtro " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Clase:"
        '
        'TbHastaPaca
        '
        Me.TbHastaPaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbHastaPaca.Location = New System.Drawing.Point(117, 18)
        Me.TbHastaPaca.Name = "TbHastaPaca"
        Me.TbHastaPaca.Size = New System.Drawing.Size(56, 18)
        Me.TbHastaPaca.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(90, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 12)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "A la"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 24)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "De la " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "paca:"
        '
        'TbDesdePaca
        '
        Me.TbDesdePaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbDesdePaca.Location = New System.Drawing.Point(31, 18)
        Me.TbDesdePaca.Name = "TbDesdePaca"
        Me.TbDesdePaca.Size = New System.Drawing.Size(56, 18)
        Me.TbDesdePaca.TabIndex = 25
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.BtSeleccionar2)
        Me.Panel5.Controls.Add(Me.BtSeleccionar)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(855, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(44, 281)
        Me.Panel5.TabIndex = 3
        '
        'BtSeleccionar2
        '
        Me.BtSeleccionar2.BackgroundImage = CType(resources.GetObject("BtSeleccionar2.BackgroundImage"), System.Drawing.Image)
        Me.BtSeleccionar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtSeleccionar2.Location = New System.Drawing.Point(5, 139)
        Me.BtSeleccionar2.Name = "BtSeleccionar2"
        Me.BtSeleccionar2.Size = New System.Drawing.Size(33, 34)
        Me.BtSeleccionar2.TabIndex = 0
        Me.BtSeleccionar2.UseVisualStyleBackColor = True
        '
        'BtSeleccionar
        '
        Me.BtSeleccionar.BackgroundImage = CType(resources.GetObject("BtSeleccionar.BackgroundImage"), System.Drawing.Image)
        Me.BtSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtSeleccionar.Location = New System.Drawing.Point(5, 99)
        Me.BtSeleccionar.Name = "BtSeleccionar"
        Me.BtSeleccionar.Size = New System.Drawing.Size(33, 34)
        Me.BtSeleccionar.TabIndex = 0
        Me.BtSeleccionar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TP2LiquidacionesVendidas)
        Me.TabControl1.Controls.Add(Me.TP4IndividualVendidas)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TabControl1.Location = New System.Drawing.Point(899, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(823, 281)
        Me.TabControl1.TabIndex = 4
        '
        'TP2LiquidacionesVendidas
        '
        Me.TP2LiquidacionesVendidas.Controls.Add(Me.DgvLiqVendidas)
        Me.TP2LiquidacionesVendidas.Controls.Add(Me.GroupBox7)
        Me.TP2LiquidacionesVendidas.Location = New System.Drawing.Point(4, 22)
        Me.TP2LiquidacionesVendidas.Name = "TP2LiquidacionesVendidas"
        Me.TP2LiquidacionesVendidas.Padding = New System.Windows.Forms.Padding(3)
        Me.TP2LiquidacionesVendidas.Size = New System.Drawing.Size(815, 255)
        Me.TP2LiquidacionesVendidas.TabIndex = 1
        Me.TP2LiquidacionesVendidas.Text = "Liquidaciones Vendidas"
        Me.TP2LiquidacionesVendidas.UseVisualStyleBackColor = True
        '
        'DgvLiqVendidas
        '
        Me.DgvLiqVendidas.AllowUserToAddRows = False
        Me.DgvLiqVendidas.AllowUserToDeleteRows = False
        Me.DgvLiqVendidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvLiqVendidas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvLiqVendidas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvLiqVendidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvLiqVendidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLiqVendidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvLiqVendidas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvLiqVendidas.Location = New System.Drawing.Point(3, 48)
        Me.DgvLiqVendidas.MultiSelect = False
        Me.DgvLiqVendidas.Name = "DgvLiqVendidas"
        Me.DgvLiqVendidas.RowHeadersVisible = False
        Me.DgvLiqVendidas.RowHeadersWidth = 40
        Me.DgvLiqVendidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvLiqVendidas.Size = New System.Drawing.Size(809, 204)
        Me.DgvLiqVendidas.TabIndex = 14
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.BtRecalcular)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox7.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(809, 45)
        Me.GroupBox7.TabIndex = 15
        Me.GroupBox7.TabStop = False
        '
        'TP4IndividualVendidas
        '
        Me.TP4IndividualVendidas.Controls.Add(Me.DgvPacasIndVendidas)
        Me.TP4IndividualVendidas.Controls.Add(Me.GroupBox8)
        Me.TP4IndividualVendidas.Location = New System.Drawing.Point(4, 22)
        Me.TP4IndividualVendidas.Name = "TP4IndividualVendidas"
        Me.TP4IndividualVendidas.Padding = New System.Windows.Forms.Padding(3)
        Me.TP4IndividualVendidas.Size = New System.Drawing.Size(815, 255)
        Me.TP4IndividualVendidas.TabIndex = 3
        Me.TP4IndividualVendidas.Text = "Individual Vendidas (por paca)"
        Me.TP4IndividualVendidas.UseVisualStyleBackColor = True
        '
        'DgvPacasIndVendidas
        '
        Me.DgvPacasIndVendidas.AllowUserToAddRows = False
        Me.DgvPacasIndVendidas.AllowUserToDeleteRows = False
        Me.DgvPacasIndVendidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacasIndVendidas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvPacasIndVendidas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvPacasIndVendidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvPacasIndVendidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacasIndVendidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacasIndVendidas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvPacasIndVendidas.Location = New System.Drawing.Point(3, 48)
        Me.DgvPacasIndVendidas.MultiSelect = False
        Me.DgvPacasIndVendidas.Name = "DgvPacasIndVendidas"
        Me.DgvPacasIndVendidas.RowHeadersVisible = False
        Me.DgvPacasIndVendidas.RowHeadersWidth = 40
        Me.DgvPacasIndVendidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPacasIndVendidas.Size = New System.Drawing.Size(809, 204)
        Me.DgvPacasIndVendidas.TabIndex = 14
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.CbPlantaVendidas)
        Me.GroupBox8.Controls.Add(Me.Label2)
        Me.GroupBox8.Controls.Add(Me.TbIdPaqVtaVendida)
        Me.GroupBox8.Controls.Add(Me.Label20)
        Me.GroupBox8.Controls.Add(Me.BtFiltroCompra)
        Me.GroupBox8.Controls.Add(Me.BtReiniciaFiltroCompra)
        Me.GroupBox8.Controls.Add(Me.CbClasesVendidas)
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.TbDesdePacaCompra)
        Me.GroupBox8.Controls.Add(Me.Label15)
        Me.GroupBox8.Controls.Add(Me.Label17)
        Me.GroupBox8.Controls.Add(Me.TbHastaPacaCompra)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox8.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(809, 45)
        Me.GroupBox8.TabIndex = 15
        Me.GroupBox8.TabStop = False
        '
        'CbPlantaVendidas
        '
        Me.CbPlantaVendidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbPlantaVendidas.FormattingEnabled = True
        Me.CbPlantaVendidas.Location = New System.Drawing.Point(432, 18)
        Me.CbPlantaVendidas.Name = "CbPlantaVendidas"
        Me.CbPlantaVendidas.Size = New System.Drawing.Size(113, 20)
        Me.CbPlantaVendidas.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(396, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 12)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Planta:"
        '
        'TbIdPaqVtaVendida
        '
        Me.TbIdPaqVtaVendida.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbIdPaqVtaVendida.Location = New System.Drawing.Point(324, 18)
        Me.TbIdPaqVtaVendida.Name = "TbIdPaqVtaVendida"
        Me.TbIdPaqVtaVendida.Size = New System.Drawing.Size(66, 18)
        Me.TbIdPaqVtaVendida.TabIndex = 60
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(280, 15)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(41, 24)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Paquete " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vta:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtFiltroCompra
        '
        Me.BtFiltroCompra.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtFiltroCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtFiltroCompra.Location = New System.Drawing.Point(661, 16)
        Me.BtFiltroCompra.MaximumSize = New System.Drawing.Size(75, 23)
        Me.BtFiltroCompra.MinimumSize = New System.Drawing.Size(75, 23)
        Me.BtFiltroCompra.Name = "BtFiltroCompra"
        Me.BtFiltroCompra.Size = New System.Drawing.Size(75, 23)
        Me.BtFiltroCompra.TabIndex = 57
        Me.BtFiltroCompra.Text = "Aplicar Filtro"
        Me.BtFiltroCompra.UseVisualStyleBackColor = True
        '
        'BtReiniciaFiltroCompra
        '
        Me.BtReiniciaFiltroCompra.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtReiniciaFiltroCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtReiniciaFiltroCompra.Location = New System.Drawing.Point(736, 16)
        Me.BtReiniciaFiltroCompra.MaximumSize = New System.Drawing.Size(70, 23)
        Me.BtReiniciaFiltroCompra.MinimumSize = New System.Drawing.Size(70, 23)
        Me.BtReiniciaFiltroCompra.Name = "BtReiniciaFiltroCompra"
        Me.BtReiniciaFiltroCompra.Size = New System.Drawing.Size(70, 23)
        Me.BtReiniciaFiltroCompra.TabIndex = 57
        Me.BtReiniciaFiltroCompra.Text = "Reinicia Filtro"
        Me.BtReiniciaFiltroCompra.UseVisualStyleBackColor = True
        '
        'CbClasesVendidas
        '
        Me.CbClasesVendidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbClasesVendidas.FormattingEnabled = True
        Me.CbClasesVendidas.Location = New System.Drawing.Point(208, 17)
        Me.CbClasesVendidas.Name = "CbClasesVendidas"
        Me.CbClasesVendidas.Size = New System.Drawing.Size(66, 20)
        Me.CbClasesVendidas.TabIndex = 56
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 24)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "De la " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "paca:"
        '
        'TbDesdePacaCompra
        '
        Me.TbDesdePacaCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbDesdePacaCompra.Location = New System.Drawing.Point(31, 18)
        Me.TbDesdePacaCompra.Name = "TbDesdePacaCompra"
        Me.TbDesdePacaCompra.Size = New System.Drawing.Size(56, 18)
        Me.TbDesdePacaCompra.TabIndex = 25
        Me.TbDesdePacaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(90, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 12)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "A la"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(175, 15)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 24)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Filtro " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Clase:"
        '
        'TbHastaPacaCompra
        '
        Me.TbHastaPacaCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbHastaPacaCompra.Location = New System.Drawing.Point(115, 18)
        Me.TbHastaPacaCompra.Name = "TbHastaPacaCompra"
        Me.TbHastaPacaCompra.Size = New System.Drawing.Size(56, 18)
        Me.TbHastaPacaCompra.TabIndex = 31
        Me.TbHastaPacaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GbCompraActual
        '
        Me.GbCompraActual.BackColor = System.Drawing.SystemColors.Control
        Me.GbCompraActual.Controls.Add(Me.Label7)
        Me.GbCompraActual.Controls.Add(Me.TbPacasVendidasContrato)
        Me.GbCompraActual.Controls.Add(Me.TbPacasMarc)
        Me.GbCompraActual.Controls.Add(Me.TbKilosVendidos)
        Me.GbCompraActual.Controls.Add(Me.Label24)
        Me.GbCompraActual.Controls.Add(Me.Label25)
        Me.GbCompraActual.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GbCompraActual.Location = New System.Drawing.Point(0, 281)
        Me.GbCompraActual.Name = "GbCompraActual"
        Me.GbCompraActual.Size = New System.Drawing.Size(1722, 55)
        Me.GbCompraActual.TabIndex = 2
        Me.GbCompraActual.TabStop = False
        Me.GbCompraActual.Text = "Detalles De Venta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1182, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Pacas Vendidas"
        '
        'TbPacasVendidasContrato
        '
        Me.TbPacasVendidasContrato.Enabled = False
        Me.TbPacasVendidasContrato.Location = New System.Drawing.Point(1272, 25)
        Me.TbPacasVendidasContrato.Name = "TbPacasVendidasContrato"
        Me.TbPacasVendidasContrato.Size = New System.Drawing.Size(118, 20)
        Me.TbPacasVendidasContrato.TabIndex = 26
        '
        'TbPacasMarc
        '
        Me.TbPacasMarc.Enabled = False
        Me.TbPacasMarc.Location = New System.Drawing.Point(539, 25)
        Me.TbPacasMarc.Name = "TbPacasMarc"
        Me.TbPacasMarc.Size = New System.Drawing.Size(100, 20)
        Me.TbPacasMarc.TabIndex = 25
        Me.TbPacasMarc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbKilosVendidos
        '
        Me.TbKilosVendidos.Enabled = False
        Me.TbKilosVendidos.Location = New System.Drawing.Point(1448, 25)
        Me.TbKilosVendidos.Name = "TbKilosVendidos"
        Me.TbKilosVendidos.Size = New System.Drawing.Size(100, 20)
        Me.TbKilosVendidos.TabIndex = 24
        Me.TbKilosVendidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(1412, 28)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(32, 13)
        Me.Label24.TabIndex = 23
        Me.Label24.Text = "Kilos "
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.Control
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(447, 28)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(86, 13)
        Me.Label25.TabIndex = 23
        Me.Label25.Text = "Pacas marcadas"
        '
        'BtRecalcular
        '
        Me.BtRecalcular.Location = New System.Drawing.Point(728, 16)
        Me.BtRecalcular.Name = "BtRecalcular"
        Me.BtRecalcular.Size = New System.Drawing.Size(75, 23)
        Me.BtRecalcular.TabIndex = 0
        Me.BtRecalcular.Text = "Recalcular"
        Me.BtRecalcular.UseVisualStyleBackColor = True
        '
        'VentaPacasContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1728, 743)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GbCompras)
        Me.Controls.Add(Me.GbDatosGenerales)
        Me.Controls.Add(Me.MSMenu)
        Me.MinimumSize = New System.Drawing.Size(1415, 651)
        Me.Name = "VentaPacasContrato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Venta de Pacas Por Contrato"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DgvContratos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GbCompras.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DgvAgrupadasClases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvAgrupadasCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.TcCompras.ResumeLayout(False)
        Me.TP1LiquidacionesAVender.ResumeLayout(False)
        CType(Me.DgvDatosLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP3PacasAVender.ResumeLayout(False)
        CType(Me.DgvPacasVender, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbFiltrado.ResumeLayout(False)
        Me.GbFiltrado.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TP2LiquidacionesVendidas.ResumeLayout(False)
        CType(Me.DgvLiqVendidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.TP4IndividualVendidas.ResumeLayout(False)
        CType(Me.DgvPacasIndVendidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GbCompraActual.ResumeLayout(False)
        Me.GbCompraActual.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GbDatosGenerales As GroupBox
    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GbCompras As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents BtCastLarFib As Button
    Friend WithEvents BtCastigoMicros As Button
    Friend WithEvents BtCastigoResFibra As Button
    Friend WithEvents BtModalidadVenta As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TbPrecioQuintal As TextBox
    Friend WithEvents TbNoPacas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents CbPlanta As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TbIdComprador As TextBox
    Friend WithEvents TbIdVentaPaca As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TbNombreComprador As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TbIdContrato As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DgvAgrupadasCliente As DataGridView
    Friend WithEvents DgvAgrupadasClases As DataGridView
    Friend WithEvents BtnBuscarProd As Button
    Friend WithEvents DgvContratos As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents TbKilosVendidasGral As TextBox
    Friend WithEvents TbPacasVendidasGral As TextBox
    Friend WithEvents TbPacasDisp As TextBox
    Friend WithEvents TbPacasContratadas As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TcCompras As TabControl
    Friend WithEvents TP1LiquidacionesAVender As TabPage
    Friend WithEvents DgvDatosLiquidacion As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TP3PacasAVender As TabPage
    Friend WithEvents DgvPacasVender As DataGridView
    Friend WithEvents GbFiltrado As GroupBox
    Friend WithEvents BtReiniciaFiltro As Button
    Friend WithEvents BtFiltro As Button
    Friend WithEvents CbClasesPacasAVender As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtSeleccionar2 As Button
    Friend WithEvents BtSeleccionar As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TP2LiquidacionesVendidas As TabPage
    Friend WithEvents DgvLiqVendidas As DataGridView
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents TP4IndividualVendidas As TabPage
    Friend WithEvents DgvPacasIndVendidas As DataGridView
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents BtReiniciaFiltroCompra As Button
    Friend WithEvents BtFiltroCompra As Button
    Friend WithEvents CbClasesVendidas As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TbDesdePacaCompra As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TbHastaPacaCompra As TextBox
    Friend WithEvents GbCompraActual As GroupBox
    Friend WithEvents TbKilosVendidos As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents TbPacasMarc As TextBox
    Friend WithEvents TbKdAd As TextBox
    Friend WithEvents CkKgAdd As CheckBox
    Friend WithEvents TbValorConversion As TextBox
    Friend WithEvents CbUnidadPeso As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents CbModalidadVenta As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents TbHastaPaca As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TbDesdePaca As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TbPacasVendidasContrato As TextBox
    Friend WithEvents ReporteHVIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TbIdPaqVtaVender As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TbIdPaqVtaVendida As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents CbPlantaVendidas As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtDesmarcaTodo As Button
    Friend WithEvents BtMarcarTodo As Button
    Friend WithEvents Label28 As Label
    Friend WithEvents CbPlantaVender As ComboBox
    Friend WithEvents ComparacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtRecalcular As Button
End Class
