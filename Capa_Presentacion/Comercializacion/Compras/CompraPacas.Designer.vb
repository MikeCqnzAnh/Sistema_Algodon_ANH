<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompraPacas
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
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.BtCastigosLargoFibra = New System.Windows.Forms.Button()
        Me.BtDiferenciasPorClases = New System.Windows.Forms.Button()
        Me.BtCastigoResistenciaFibra = New System.Windows.Forms.Button()
        Me.BtCastigosPorMicros = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbPrecioFactura = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbPrecioQuintal = New System.Windows.Forms.TextBox()
        Me.TbSemilla = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TbPlumas = New System.Windows.Forms.TextBox()
        Me.TbDolar = New System.Windows.Forms.TextBox()
        Me.TbNoPacas = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbSub = New System.Windows.Forms.TextBox()
        Me.CbProductor = New System.Windows.Forms.ComboBox()
        Me.TbHastaPaca = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbDesdePaca = New System.Windows.Forms.TextBox()
        Me.TbPredio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbHueso = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbPlanta = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbIdCompraPaca = New System.Windows.Forms.TextBox()
        Me.GbCompras = New System.Windows.Forms.GroupBox()
        Me.TcCompras = New System.Windows.Forms.TabControl()
        Me.TP1LiquidacionesCompras = New System.Windows.Forms.TabPage()
        Me.DgvCompraPacas = New System.Windows.Forms.DataGridView()
        Me.TP2LiquidacionesCompradas = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TP3CompraPacasIndividual = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TP4IndividualCompraPaca = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.TP5PacasSinClasificar = New System.Windows.Forms.TabPage()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.TP6Observaciones = New System.Windows.Forms.TabPage()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.MSMenu.SuspendLayout()
        Me.GbDatosGenerales.SuspendLayout()
        Me.GbCompras.SuspendLayout()
        Me.TcCompras.SuspendLayout()
        Me.TP1LiquidacionesCompras.SuspendLayout()
        CType(Me.DgvCompraPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP2LiquidacionesCompradas.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP3CompraPacasIndividual.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP4IndividualCompraPaca.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP5PacasSinClasificar.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP6Observaciones.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(1109, 24)
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
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.Controls.Add(Me.BtCastigosLargoFibra)
        Me.GbDatosGenerales.Controls.Add(Me.BtDiferenciasPorClases)
        Me.GbDatosGenerales.Controls.Add(Me.BtCastigoResistenciaFibra)
        Me.GbDatosGenerales.Controls.Add(Me.BtCastigosPorMicros)
        Me.GbDatosGenerales.Controls.Add(Me.Label15)
        Me.GbDatosGenerales.Controls.Add(Me.Label8)
        Me.GbDatosGenerales.Controls.Add(Me.Label14)
        Me.GbDatosGenerales.Controls.Add(Me.Label7)
        Me.GbDatosGenerales.Controls.Add(Me.TbPrecioFactura)
        Me.GbDatosGenerales.Controls.Add(Me.Label6)
        Me.GbDatosGenerales.Controls.Add(Me.TbPrecioQuintal)
        Me.GbDatosGenerales.Controls.Add(Me.TbSemilla)
        Me.GbDatosGenerales.Controls.Add(Me.Label13)
        Me.GbDatosGenerales.Controls.Add(Me.TbPlumas)
        Me.GbDatosGenerales.Controls.Add(Me.TbDolar)
        Me.GbDatosGenerales.Controls.Add(Me.TbNoPacas)
        Me.GbDatosGenerales.Controls.Add(Me.Label12)
        Me.GbDatosGenerales.Controls.Add(Me.Label5)
        Me.GbDatosGenerales.Controls.Add(Me.TbSub)
        Me.GbDatosGenerales.Controls.Add(Me.CbProductor)
        Me.GbDatosGenerales.Controls.Add(Me.TbHastaPaca)
        Me.GbDatosGenerales.Controls.Add(Me.Label4)
        Me.GbDatosGenerales.Controls.Add(Me.Label11)
        Me.GbDatosGenerales.Controls.Add(Me.DtFecha)
        Me.GbDatosGenerales.Controls.Add(Me.Label10)
        Me.GbDatosGenerales.Controls.Add(Me.Label3)
        Me.GbDatosGenerales.Controls.Add(Me.TbDesdePaca)
        Me.GbDatosGenerales.Controls.Add(Me.TbPredio)
        Me.GbDatosGenerales.Controls.Add(Me.Label9)
        Me.GbDatosGenerales.Controls.Add(Me.TbHueso)
        Me.GbDatosGenerales.Controls.Add(Me.Label2)
        Me.GbDatosGenerales.Controls.Add(Me.CbPlanta)
        Me.GbDatosGenerales.Controls.Add(Me.Label1)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdCompraPaca)
        Me.GbDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatosGenerales.Location = New System.Drawing.Point(0, 24)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(1109, 229)
        Me.GbDatosGenerales.TabIndex = 1
        Me.GbDatosGenerales.TabStop = False
        Me.GbDatosGenerales.Text = "Datos Generales"
        '
        'BtCastigosLargoFibra
        '
        Me.BtCastigosLargoFibra.Location = New System.Drawing.Point(1028, 13)
        Me.BtCastigosLargoFibra.Name = "BtCastigosLargoFibra"
        Me.BtCastigosLargoFibra.Size = New System.Drawing.Size(75, 62)
        Me.BtCastigosLargoFibra.TabIndex = 16
        Me.BtCastigosLargoFibra.Text = "Castigos de Largo Fibra"
        Me.BtCastigosLargoFibra.UseVisualStyleBackColor = True
        '
        'BtDiferenciasPorClases
        '
        Me.BtDiferenciasPorClases.Location = New System.Drawing.Point(947, 13)
        Me.BtDiferenciasPorClases.Name = "BtDiferenciasPorClases"
        Me.BtDiferenciasPorClases.Size = New System.Drawing.Size(75, 62)
        Me.BtDiferenciasPorClases.TabIndex = 16
        Me.BtDiferenciasPorClases.Text = "Diferencias Por Clases"
        Me.BtDiferenciasPorClases.UseVisualStyleBackColor = True
        '
        'BtCastigoResistenciaFibra
        '
        Me.BtCastigoResistenciaFibra.Location = New System.Drawing.Point(866, 13)
        Me.BtCastigoResistenciaFibra.Name = "BtCastigoResistenciaFibra"
        Me.BtCastigoResistenciaFibra.Size = New System.Drawing.Size(75, 62)
        Me.BtCastigoResistenciaFibra.TabIndex = 16
        Me.BtCastigoResistenciaFibra.Text = "Castigos Por Resistencia de Fibra"
        Me.BtCastigoResistenciaFibra.UseVisualStyleBackColor = True
        '
        'BtCastigosPorMicros
        '
        Me.BtCastigosPorMicros.Location = New System.Drawing.Point(785, 13)
        Me.BtCastigosPorMicros.Name = "BtCastigosPorMicros"
        Me.BtCastigosPorMicros.Size = New System.Drawing.Size(75, 62)
        Me.BtCastigosPorMicros.TabIndex = 16
        Me.BtCastigosPorMicros.Text = "Castigos Por Micros"
        Me.BtCastigosPorMicros.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(333, 146)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Precio Factura"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Semilla"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(333, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Precio Quintal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Pluma"
        '
        'TbPrecioFactura
        '
        Me.TbPrecioFactura.Location = New System.Drawing.Point(452, 143)
        Me.TbPrecioFactura.Name = "TbPrecioFactura"
        Me.TbPrecioFactura.Size = New System.Drawing.Size(100, 20)
        Me.TbPrecioFactura.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "No. Pacas"
        '
        'TbPrecioQuintal
        '
        Me.TbPrecioQuintal.Location = New System.Drawing.Point(452, 117)
        Me.TbPrecioQuintal.Name = "TbPrecioQuintal"
        Me.TbPrecioQuintal.Size = New System.Drawing.Size(100, 20)
        Me.TbPrecioQuintal.TabIndex = 12
        '
        'TbSemilla
        '
        Me.TbSemilla.Location = New System.Drawing.Point(116, 203)
        Me.TbSemilla.Name = "TbSemilla"
        Me.TbSemilla.Size = New System.Drawing.Size(173, 20)
        Me.TbSemilla.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(333, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Dolar"
        '
        'TbPlumas
        '
        Me.TbPlumas.Location = New System.Drawing.Point(116, 177)
        Me.TbPlumas.Name = "TbPlumas"
        Me.TbPlumas.Size = New System.Drawing.Size(173, 20)
        Me.TbPlumas.TabIndex = 11
        '
        'TbDolar
        '
        Me.TbDolar.Location = New System.Drawing.Point(452, 91)
        Me.TbDolar.Name = "TbDolar"
        Me.TbDolar.Size = New System.Drawing.Size(100, 20)
        Me.TbDolar.TabIndex = 10
        '
        'TbNoPacas
        '
        Me.TbNoPacas.Location = New System.Drawing.Point(116, 151)
        Me.TbNoPacas.Name = "TbNoPacas"
        Me.TbNoPacas.Size = New System.Drawing.Size(173, 20)
        Me.TbNoPacas.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(333, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Sub"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Productor"
        '
        'TbSub
        '
        Me.TbSub.Location = New System.Drawing.Point(452, 65)
        Me.TbSub.Name = "TbSub"
        Me.TbSub.Size = New System.Drawing.Size(100, 20)
        Me.TbSub.TabIndex = 8
        '
        'CbProductor
        '
        Me.CbProductor.FormattingEnabled = True
        Me.CbProductor.Location = New System.Drawing.Point(116, 124)
        Me.CbProductor.Name = "CbProductor"
        Me.CbProductor.Size = New System.Drawing.Size(173, 21)
        Me.CbProductor.TabIndex = 8
        '
        'TbHastaPaca
        '
        Me.TbHastaPaca.Location = New System.Drawing.Point(601, 39)
        Me.TbHastaPaca.Name = "TbHastaPaca"
        Me.TbHastaPaca.Size = New System.Drawing.Size(100, 20)
        Me.TbHastaPaca.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(558, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "a la"
        '
        'DtFecha
        '
        Me.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecha.Location = New System.Drawing.Point(116, 98)
        Me.DtFecha.Name = "DtFecha"
        Me.DtFecha.Size = New System.Drawing.Size(173, 20)
        Me.DtFecha.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(333, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "De la paca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Predio"
        '
        'TbDesdePaca
        '
        Me.TbDesdePaca.Location = New System.Drawing.Point(452, 39)
        Me.TbDesdePaca.Name = "TbDesdePaca"
        Me.TbDesdePaca.Size = New System.Drawing.Size(100, 20)
        Me.TbDesdePaca.TabIndex = 4
        '
        'TbPredio
        '
        Me.TbPredio.Location = New System.Drawing.Point(116, 72)
        Me.TbPredio.Name = "TbPredio"
        Me.TbPredio.Size = New System.Drawing.Size(173, 20)
        Me.TbPredio.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(333, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Hueso"
        '
        'TbHueso
        '
        Me.TbHueso.Location = New System.Drawing.Point(452, 13)
        Me.TbHueso.Name = "TbHueso"
        Me.TbHueso.Size = New System.Drawing.Size(100, 20)
        Me.TbHueso.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Planta"
        '
        'CbPlanta
        '
        Me.CbPlanta.FormattingEnabled = True
        Me.CbPlanta.Location = New System.Drawing.Point(116, 45)
        Me.CbPlanta.Name = "CbPlanta"
        Me.CbPlanta.Size = New System.Drawing.Size(173, 21)
        Me.CbPlanta.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'TbIdCompraPaca
        '
        Me.TbIdCompraPaca.Enabled = False
        Me.TbIdCompraPaca.Location = New System.Drawing.Point(116, 19)
        Me.TbIdCompraPaca.Name = "TbIdCompraPaca"
        Me.TbIdCompraPaca.Size = New System.Drawing.Size(100, 20)
        Me.TbIdCompraPaca.TabIndex = 0
        '
        'GbCompras
        '
        Me.GbCompras.Controls.Add(Me.TcCompras)
        Me.GbCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbCompras.Location = New System.Drawing.Point(0, 253)
        Me.GbCompras.Name = "GbCompras"
        Me.GbCompras.Size = New System.Drawing.Size(1109, 485)
        Me.GbCompras.TabIndex = 2
        Me.GbCompras.TabStop = False
        '
        'TcCompras
        '
        Me.TcCompras.Controls.Add(Me.TP1LiquidacionesCompras)
        Me.TcCompras.Controls.Add(Me.TP2LiquidacionesCompradas)
        Me.TcCompras.Controls.Add(Me.TP3CompraPacasIndividual)
        Me.TcCompras.Controls.Add(Me.TP4IndividualCompraPaca)
        Me.TcCompras.Controls.Add(Me.TP5PacasSinClasificar)
        Me.TcCompras.Controls.Add(Me.TP6Observaciones)
        Me.TcCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TcCompras.Location = New System.Drawing.Point(3, 16)
        Me.TcCompras.Name = "TcCompras"
        Me.TcCompras.SelectedIndex = 0
        Me.TcCompras.Size = New System.Drawing.Size(1103, 466)
        Me.TcCompras.TabIndex = 0
        '
        'TP1LiquidacionesCompras
        '
        Me.TP1LiquidacionesCompras.BackColor = System.Drawing.Color.Transparent
        Me.TP1LiquidacionesCompras.Controls.Add(Me.DgvCompraPacas)
        Me.TP1LiquidacionesCompras.Location = New System.Drawing.Point(4, 22)
        Me.TP1LiquidacionesCompras.Name = "TP1LiquidacionesCompras"
        Me.TP1LiquidacionesCompras.Padding = New System.Windows.Forms.Padding(3)
        Me.TP1LiquidacionesCompras.Size = New System.Drawing.Size(1095, 440)
        Me.TP1LiquidacionesCompras.TabIndex = 0
        Me.TP1LiquidacionesCompras.Text = "Liquidaciones a Comprar"
        '
        'DgvCompraPacas
        '
        Me.DgvCompraPacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCompraPacas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCompraPacas.Location = New System.Drawing.Point(3, 3)
        Me.DgvCompraPacas.Name = "DgvCompraPacas"
        Me.DgvCompraPacas.Size = New System.Drawing.Size(1089, 434)
        Me.DgvCompraPacas.TabIndex = 3
        '
        'TP2LiquidacionesCompradas
        '
        Me.TP2LiquidacionesCompradas.Controls.Add(Me.DataGridView1)
        Me.TP2LiquidacionesCompradas.Location = New System.Drawing.Point(4, 22)
        Me.TP2LiquidacionesCompradas.Name = "TP2LiquidacionesCompradas"
        Me.TP2LiquidacionesCompradas.Padding = New System.Windows.Forms.Padding(3)
        Me.TP2LiquidacionesCompradas.Size = New System.Drawing.Size(1095, 440)
        Me.TP2LiquidacionesCompradas.TabIndex = 1
        Me.TP2LiquidacionesCompradas.Text = "Liquidaciones Compradas"
        Me.TP2LiquidacionesCompradas.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1089, 434)
        Me.DataGridView1.TabIndex = 0
        '
        'TP3CompraPacasIndividual
        '
        Me.TP3CompraPacasIndividual.Controls.Add(Me.DataGridView2)
        Me.TP3CompraPacasIndividual.Location = New System.Drawing.Point(4, 22)
        Me.TP3CompraPacasIndividual.Name = "TP3CompraPacasIndividual"
        Me.TP3CompraPacasIndividual.Padding = New System.Windows.Forms.Padding(3)
        Me.TP3CompraPacasIndividual.Size = New System.Drawing.Size(1095, 440)
        Me.TP3CompraPacasIndividual.TabIndex = 2
        Me.TP3CompraPacasIndividual.Text = "Pacas a Comprar (Individual)"
        Me.TP3CompraPacasIndividual.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1089, 434)
        Me.DataGridView2.TabIndex = 0
        '
        'TP4IndividualCompraPaca
        '
        Me.TP4IndividualCompraPaca.Controls.Add(Me.DataGridView3)
        Me.TP4IndividualCompraPaca.Location = New System.Drawing.Point(4, 22)
        Me.TP4IndividualCompraPaca.Name = "TP4IndividualCompraPaca"
        Me.TP4IndividualCompraPaca.Padding = New System.Windows.Forms.Padding(3)
        Me.TP4IndividualCompraPaca.Size = New System.Drawing.Size(1095, 440)
        Me.TP4IndividualCompraPaca.TabIndex = 3
        Me.TP4IndividualCompraPaca.Text = "Compra Individual por Paca"
        Me.TP4IndividualCompraPaca.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView3.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(1089, 434)
        Me.DataGridView3.TabIndex = 1
        '
        'TP5PacasSinClasificar
        '
        Me.TP5PacasSinClasificar.Controls.Add(Me.DataGridView4)
        Me.TP5PacasSinClasificar.Location = New System.Drawing.Point(4, 22)
        Me.TP5PacasSinClasificar.Name = "TP5PacasSinClasificar"
        Me.TP5PacasSinClasificar.Padding = New System.Windows.Forms.Padding(3)
        Me.TP5PacasSinClasificar.Size = New System.Drawing.Size(1095, 440)
        Me.TP5PacasSinClasificar.TabIndex = 4
        Me.TP5PacasSinClasificar.Text = "Pacas Sin Clasificar"
        Me.TP5PacasSinClasificar.UseVisualStyleBackColor = True
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView4.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(1089, 434)
        Me.DataGridView4.TabIndex = 1
        '
        'TP6Observaciones
        '
        Me.TP6Observaciones.Controls.Add(Me.DataGridView5)
        Me.TP6Observaciones.Location = New System.Drawing.Point(4, 22)
        Me.TP6Observaciones.Name = "TP6Observaciones"
        Me.TP6Observaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.TP6Observaciones.Size = New System.Drawing.Size(1095, 440)
        Me.TP6Observaciones.TabIndex = 5
        Me.TP6Observaciones.Text = "Observaciones"
        Me.TP6Observaciones.UseVisualStyleBackColor = True
        '
        'DataGridView5
        '
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView5.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(1089, 434)
        Me.DataGridView5.TabIndex = 1
        '
        'CompraPacas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 738)
        Me.Controls.Add(Me.GbCompras)
        Me.Controls.Add(Me.GbDatosGenerales)
        Me.Controls.Add(Me.MSMenu)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "CompraPacas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compra de Pacas"
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        Me.GbCompras.ResumeLayout(False)
        Me.TcCompras.ResumeLayout(False)
        Me.TP1LiquidacionesCompras.ResumeLayout(False)
        CType(Me.DgvCompraPacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP2LiquidacionesCompradas.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP3CompraPacasIndividual.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP4IndividualCompraPaca.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP5PacasSinClasificar.ResumeLayout(False)
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP6Observaciones.ResumeLayout(False)
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GbDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CbProductor As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TbPredio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbPlanta As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbIdCompraPaca As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TbSemilla As System.Windows.Forms.TextBox
    Friend WithEvents TbPlumas As System.Windows.Forms.TextBox
    Friend WithEvents TbNoPacas As System.Windows.Forms.TextBox
    Friend WithEvents TbHueso As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TbDesdePaca As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TbHastaPaca As System.Windows.Forms.TextBox
    Friend WithEvents TbSub As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TbDolar As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TbPrecioQuintal As System.Windows.Forms.TextBox
    Friend WithEvents TbPrecioFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GbCompras As GroupBox
    Friend WithEvents DgvCompraPacas As DataGridView
    Friend WithEvents TcCompras As TabControl
    Friend WithEvents TP1LiquidacionesCompras As TabPage
    Friend WithEvents TP2LiquidacionesCompradas As TabPage
    Friend WithEvents TP3CompraPacasIndividual As TabPage
    Friend WithEvents TP4IndividualCompraPaca As TabPage
    Friend WithEvents TP5PacasSinClasificar As TabPage
    Friend WithEvents TP6Observaciones As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents BtCastigosLargoFibra As Button
    Friend WithEvents BtDiferenciasPorClases As Button
    Friend WithEvents BtCastigoResistenciaFibra As Button
    Friend WithEvents BtCastigosPorMicros As Button
End Class
