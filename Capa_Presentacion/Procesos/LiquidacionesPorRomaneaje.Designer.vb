<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LiquidacionesPorRomaneaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LiquidacionesPorRomaneaje))
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbPorCuenta = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbNombreCliente = New System.Windows.Forms.ComboBox()
        Me.DtFechaLiquidacion = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbTipo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbIdLiquidacion = New System.Windows.Forms.TextBox()
        Me.TbIdOrden = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbPlanta = New System.Windows.Forms.ComboBox()
        Me.GbResumen = New System.Windows.Forms.GroupBox()
        Me.TbCantPacas = New System.Windows.Forms.TextBox()
        Me.TbcantModulos = New System.Windows.Forms.TextBox()
        Me.TbTotalBoletas = New System.Windows.Forms.TextBox()
        Me.LbTotalBoletas = New System.Windows.Forms.Label()
        Me.ChClaseMicros = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TbPorcentajeTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TbTotalHueso = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TbNumPacas = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TbNumBorregos = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbPorcentajeMerma = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbPorcentajeSemilla = New System.Windows.Forms.TextBox()
        Me.TbBorregosPluma = New System.Windows.Forms.TextBox()
        Me.TbPorcentajePluma = New System.Windows.Forms.TextBox()
        Me.TbTotalMerma = New System.Windows.Forms.TextBox()
        Me.TbTotalPluma = New System.Windows.Forms.TextBox()
        Me.TbTotalSemilla = New System.Windows.Forms.TextBox()
        Me.TbComentarios = New System.Windows.Forms.TextBox()
        Me.GbComentarios = New System.Windows.Forms.GroupBox()
        Me.GbModulos = New System.Windows.Forms.GroupBox()
        Me.DgvModulos = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DgvPacas = New System.Windows.Forms.DataGridView()
        Me.GbPacas = New System.Windows.Forms.GroupBox()
        Me.PDgvs = New System.Windows.Forms.Panel()
        Me.btexcelpacas = New System.Windows.Forms.Button()
        Me.btexcelmodulos = New System.Windows.Forms.Button()
        Me.MSMenu.SuspendLayout()
        Me.GbDatosGenerales.SuspendLayout()
        Me.GbResumen.SuspendLayout()
        Me.GbComentarios.SuspendLayout()
        Me.GbModulos.SuspendLayout()
        CType(Me.DgvModulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbPacas.SuspendLayout()
        Me.PDgvs.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.ToolStripMenuItem1, Me.ImprimirToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(1581, 24)
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
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.GuardarToolStripMenuItem.Text = "Generar liquidacion"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(184, 20)
        Me.ConsultarToolStripMenuItem.Text = "Consultar Ordenes Por Liquidar"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(146, 20)
        Me.ToolStripMenuItem1.Text = "Consultar Liquidaciones"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.Controls.Add(Me.Label7)
        Me.GbDatosGenerales.Controls.Add(Me.CbPorCuenta)
        Me.GbDatosGenerales.Controls.Add(Me.Label6)
        Me.GbDatosGenerales.Controls.Add(Me.Label5)
        Me.GbDatosGenerales.Controls.Add(Me.CbNombreCliente)
        Me.GbDatosGenerales.Controls.Add(Me.DtFechaLiquidacion)
        Me.GbDatosGenerales.Controls.Add(Me.Label4)
        Me.GbDatosGenerales.Controls.Add(Me.CbTipo)
        Me.GbDatosGenerales.Controls.Add(Me.Label3)
        Me.GbDatosGenerales.Controls.Add(Me.Label2)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdLiquidacion)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdOrden)
        Me.GbDatosGenerales.Controls.Add(Me.Label1)
        Me.GbDatosGenerales.Controls.Add(Me.CbPlanta)
        Me.GbDatosGenerales.Dock = System.Windows.Forms.DockStyle.Left
        Me.GbDatosGenerales.Location = New System.Drawing.Point(0, 0)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(534, 504)
        Me.GbDatosGenerales.TabIndex = 1
        Me.GbDatosGenerales.TabStop = False
        Me.GbDatosGenerales.Text = "Datos Generales"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Por cuenta de"
        '
        'CbPorCuenta
        '
        Me.CbPorCuenta.Enabled = False
        Me.CbPorCuenta.FormattingEnabled = True
        Me.CbPorCuenta.Location = New System.Drawing.Point(116, 179)
        Me.CbPorCuenta.Name = "CbPorCuenta"
        Me.CbPorCuenta.Size = New System.Drawing.Size(303, 21)
        Me.CbPorCuenta.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Fecha"
        '
        'CbNombreCliente
        '
        Me.CbNombreCliente.Enabled = False
        Me.CbNombreCliente.FormattingEnabled = True
        Me.CbNombreCliente.Location = New System.Drawing.Point(116, 152)
        Me.CbNombreCliente.Name = "CbNombreCliente"
        Me.CbNombreCliente.Size = New System.Drawing.Size(303, 21)
        Me.CbNombreCliente.TabIndex = 9
        '
        'DtFechaLiquidacion
        '
        Me.DtFechaLiquidacion.Enabled = False
        Me.DtFechaLiquidacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaLiquidacion.Location = New System.Drawing.Point(116, 125)
        Me.DtFechaLiquidacion.Name = "DtFechaLiquidacion"
        Me.DtFechaLiquidacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DtFechaLiquidacion.Size = New System.Drawing.Size(200, 20)
        Me.DtFechaLiquidacion.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tipo"
        '
        'CbTipo
        '
        Me.CbTipo.Enabled = False
        Me.CbTipo.FormattingEnabled = True
        Me.CbTipo.Location = New System.Drawing.Point(116, 98)
        Me.CbTipo.Name = "CbTipo"
        Me.CbTipo.Size = New System.Drawing.Size(121, 21)
        Me.CbTipo.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Liquidacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ord. Trab."
        '
        'TbIdLiquidacion
        '
        Me.TbIdLiquidacion.Enabled = False
        Me.TbIdLiquidacion.Location = New System.Drawing.Point(116, 72)
        Me.TbIdLiquidacion.Name = "TbIdLiquidacion"
        Me.TbIdLiquidacion.Size = New System.Drawing.Size(100, 20)
        Me.TbIdLiquidacion.TabIndex = 3
        '
        'TbIdOrden
        '
        Me.TbIdOrden.Location = New System.Drawing.Point(116, 46)
        Me.TbIdOrden.Name = "TbIdOrden"
        Me.TbIdOrden.Size = New System.Drawing.Size(100, 20)
        Me.TbIdOrden.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Plantas"
        '
        'CbPlanta
        '
        Me.CbPlanta.Enabled = False
        Me.CbPlanta.FormattingEnabled = True
        Me.CbPlanta.Location = New System.Drawing.Point(116, 19)
        Me.CbPlanta.Name = "CbPlanta"
        Me.CbPlanta.Size = New System.Drawing.Size(121, 21)
        Me.CbPlanta.TabIndex = 0
        '
        'GbResumen
        '
        Me.GbResumen.Controls.Add(Me.TbCantPacas)
        Me.GbResumen.Controls.Add(Me.TbcantModulos)
        Me.GbResumen.Controls.Add(Me.TbTotalBoletas)
        Me.GbResumen.Controls.Add(Me.LbTotalBoletas)
        Me.GbResumen.Controls.Add(Me.ChClaseMicros)
        Me.GbResumen.Controls.Add(Me.Label16)
        Me.GbResumen.Controls.Add(Me.Label20)
        Me.GbResumen.Controls.Add(Me.Label19)
        Me.GbResumen.Controls.Add(Me.TbPorcentajeTotal)
        Me.GbResumen.Controls.Add(Me.Label12)
        Me.GbResumen.Controls.Add(Me.Label18)
        Me.GbResumen.Controls.Add(Me.TbTotalHueso)
        Me.GbResumen.Controls.Add(Me.Label17)
        Me.GbResumen.Controls.Add(Me.TbNumPacas)
        Me.GbResumen.Controls.Add(Me.Label15)
        Me.GbResumen.Controls.Add(Me.Label10)
        Me.GbResumen.Controls.Add(Me.Label14)
        Me.GbResumen.Controls.Add(Me.TbNumBorregos)
        Me.GbResumen.Controls.Add(Me.Label13)
        Me.GbResumen.Controls.Add(Me.Label21)
        Me.GbResumen.Controls.Add(Me.Label11)
        Me.GbResumen.Controls.Add(Me.Label9)
        Me.GbResumen.Controls.Add(Me.TbPorcentajeMerma)
        Me.GbResumen.Controls.Add(Me.Label8)
        Me.GbResumen.Controls.Add(Me.TbPorcentajeSemilla)
        Me.GbResumen.Controls.Add(Me.TbBorregosPluma)
        Me.GbResumen.Controls.Add(Me.TbPorcentajePluma)
        Me.GbResumen.Controls.Add(Me.TbTotalMerma)
        Me.GbResumen.Controls.Add(Me.TbTotalPluma)
        Me.GbResumen.Controls.Add(Me.TbTotalSemilla)
        Me.GbResumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbResumen.Location = New System.Drawing.Point(534, 0)
        Me.GbResumen.Name = "GbResumen"
        Me.GbResumen.Size = New System.Drawing.Size(474, 504)
        Me.GbResumen.TabIndex = 2
        Me.GbResumen.TabStop = False
        Me.GbResumen.Text = "Resumen"
        '
        'TbCantPacas
        '
        Me.TbCantPacas.Enabled = False
        Me.TbCantPacas.Location = New System.Drawing.Point(116, 237)
        Me.TbCantPacas.Name = "TbCantPacas"
        Me.TbCantPacas.Size = New System.Drawing.Size(100, 20)
        Me.TbCantPacas.TabIndex = 21
        '
        'TbcantModulos
        '
        Me.TbcantModulos.Enabled = False
        Me.TbcantModulos.Location = New System.Drawing.Point(116, 211)
        Me.TbcantModulos.Name = "TbcantModulos"
        Me.TbcantModulos.Size = New System.Drawing.Size(100, 20)
        Me.TbcantModulos.TabIndex = 20
        '
        'TbTotalBoletas
        '
        Me.TbTotalBoletas.Enabled = False
        Me.TbTotalBoletas.Location = New System.Drawing.Point(116, 98)
        Me.TbTotalBoletas.Name = "TbTotalBoletas"
        Me.TbTotalBoletas.Size = New System.Drawing.Size(100, 20)
        Me.TbTotalBoletas.TabIndex = 19
        Me.TbTotalBoletas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LbTotalBoletas
        '
        Me.LbTotalBoletas.AutoSize = True
        Me.LbTotalBoletas.Location = New System.Drawing.Point(8, 101)
        Me.LbTotalBoletas.Name = "LbTotalBoletas"
        Me.LbTotalBoletas.Size = New System.Drawing.Size(69, 13)
        Me.LbTotalBoletas.TabIndex = 18
        Me.LbTotalBoletas.Text = "Total Boletas"
        '
        'ChClaseMicros
        '
        Me.ChClaseMicros.AutoSize = True
        Me.ChClaseMicros.Location = New System.Drawing.Point(6, 178)
        Me.ChClaseMicros.Name = "ChClaseMicros"
        Me.ChClaseMicros.Size = New System.Drawing.Size(186, 17)
        Me.ChClaseMicros.TabIndex = 17
        Me.ChClaseMicros.Text = "Incluir Clases y Micros en Reporte"
        Me.ChClaseMicros.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(338, 130)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Total"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(424, 130)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 13)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "%"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(424, 104)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(15, 13)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "%"
        '
        'TbPorcentajeTotal
        '
        Me.TbPorcentajeTotal.Enabled = False
        Me.TbPorcentajeTotal.Location = New System.Drawing.Point(375, 127)
        Me.TbPorcentajeTotal.Name = "TbPorcentajeTotal"
        Me.TbPorcentajeTotal.Size = New System.Drawing.Size(43, 20)
        Me.TbPorcentajeTotal.TabIndex = 9
        Me.TbPorcentajeTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Pluma (Borregos)"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(424, 78)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(15, 13)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "%"
        '
        'TbTotalHueso
        '
        Me.TbTotalHueso.Enabled = False
        Me.TbTotalHueso.Location = New System.Drawing.Point(280, 23)
        Me.TbTotalHueso.Name = "TbTotalHueso"
        Me.TbTotalHueso.Size = New System.Drawing.Size(89, 20)
        Me.TbTotalHueso.TabIndex = 3
        Me.TbTotalHueso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(424, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(15, 13)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "%"
        '
        'TbNumPacas
        '
        Me.TbNumPacas.Enabled = False
        Me.TbNumPacas.Location = New System.Drawing.Point(116, 20)
        Me.TbNumPacas.Name = "TbNumPacas"
        Me.TbNumPacas.Size = New System.Drawing.Size(100, 20)
        Me.TbNumPacas.TabIndex = 4
        Me.TbNumPacas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(235, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 13)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Merma"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Borregos"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(235, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Semilla"
        '
        'TbNumBorregos
        '
        Me.TbNumBorregos.Enabled = False
        Me.TbNumBorregos.Location = New System.Drawing.Point(116, 46)
        Me.TbNumBorregos.Name = "TbNumBorregos"
        Me.TbNumBorregos.Size = New System.Drawing.Size(100, 20)
        Me.TbNumBorregos.TabIndex = 5
        Me.TbNumBorregos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(235, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Pluma"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(3, 214)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(107, 13)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "Modulos sin Revision"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 240)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Pacas sin Clasificar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Pacas"
        '
        'TbPorcentajeMerma
        '
        Me.TbPorcentajeMerma.Enabled = False
        Me.TbPorcentajeMerma.Location = New System.Drawing.Point(375, 101)
        Me.TbPorcentajeMerma.Name = "TbPorcentajeMerma"
        Me.TbPorcentajeMerma.Size = New System.Drawing.Size(43, 20)
        Me.TbPorcentajeMerma.TabIndex = 8
        Me.TbPorcentajeMerma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(235, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Hueso"
        '
        'TbPorcentajeSemilla
        '
        Me.TbPorcentajeSemilla.Enabled = False
        Me.TbPorcentajeSemilla.Location = New System.Drawing.Point(375, 75)
        Me.TbPorcentajeSemilla.Name = "TbPorcentajeSemilla"
        Me.TbPorcentajeSemilla.Size = New System.Drawing.Size(43, 20)
        Me.TbPorcentajeSemilla.TabIndex = 7
        Me.TbPorcentajeSemilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbBorregosPluma
        '
        Me.TbBorregosPluma.Enabled = False
        Me.TbBorregosPluma.Location = New System.Drawing.Point(116, 72)
        Me.TbBorregosPluma.Name = "TbBorregosPluma"
        Me.TbBorregosPluma.Size = New System.Drawing.Size(100, 20)
        Me.TbBorregosPluma.TabIndex = 7
        Me.TbBorregosPluma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbPorcentajePluma
        '
        Me.TbPorcentajePluma.Enabled = False
        Me.TbPorcentajePluma.Location = New System.Drawing.Point(375, 49)
        Me.TbPorcentajePluma.Name = "TbPorcentajePluma"
        Me.TbPorcentajePluma.Size = New System.Drawing.Size(43, 20)
        Me.TbPorcentajePluma.TabIndex = 6
        Me.TbPorcentajePluma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbTotalMerma
        '
        Me.TbTotalMerma.Enabled = False
        Me.TbTotalMerma.Location = New System.Drawing.Point(280, 101)
        Me.TbTotalMerma.Name = "TbTotalMerma"
        Me.TbTotalMerma.Size = New System.Drawing.Size(89, 20)
        Me.TbTotalMerma.TabIndex = 5
        Me.TbTotalMerma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbTotalPluma
        '
        Me.TbTotalPluma.Enabled = False
        Me.TbTotalPluma.Location = New System.Drawing.Point(280, 49)
        Me.TbTotalPluma.Name = "TbTotalPluma"
        Me.TbTotalPluma.Size = New System.Drawing.Size(89, 20)
        Me.TbTotalPluma.TabIndex = 3
        Me.TbTotalPluma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbTotalSemilla
        '
        Me.TbTotalSemilla.Enabled = False
        Me.TbTotalSemilla.Location = New System.Drawing.Point(280, 75)
        Me.TbTotalSemilla.Name = "TbTotalSemilla"
        Me.TbTotalSemilla.Size = New System.Drawing.Size(89, 20)
        Me.TbTotalSemilla.TabIndex = 4
        Me.TbTotalSemilla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbComentarios
        '
        Me.TbComentarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TbComentarios.Location = New System.Drawing.Point(3, 16)
        Me.TbComentarios.Multiline = True
        Me.TbComentarios.Name = "TbComentarios"
        Me.TbComentarios.Size = New System.Drawing.Size(1002, 165)
        Me.TbComentarios.TabIndex = 3
        '
        'GbComentarios
        '
        Me.GbComentarios.Controls.Add(Me.TbComentarios)
        Me.GbComentarios.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GbComentarios.Location = New System.Drawing.Point(0, 504)
        Me.GbComentarios.Name = "GbComentarios"
        Me.GbComentarios.Size = New System.Drawing.Size(1008, 184)
        Me.GbComentarios.TabIndex = 4
        Me.GbComentarios.TabStop = False
        Me.GbComentarios.Text = "Comentarios"
        '
        'GbModulos
        '
        Me.GbModulos.Controls.Add(Me.DgvModulos)
        Me.GbModulos.Controls.Add(Me.btexcelmodulos)
        Me.GbModulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbModulos.Location = New System.Drawing.Point(0, 0)
        Me.GbModulos.Name = "GbModulos"
        Me.GbModulos.Size = New System.Drawing.Size(573, 362)
        Me.GbModulos.TabIndex = 5
        Me.GbModulos.TabStop = False
        Me.GbModulos.Text = "Modulos"
        '
        'DgvModulos
        '
        Me.DgvModulos.AllowUserToAddRows = False
        Me.DgvModulos.AllowUserToDeleteRows = False
        Me.DgvModulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvModulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvModulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvModulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvModulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvModulos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvModulos.Location = New System.Drawing.Point(3, 16)
        Me.DgvModulos.MultiSelect = False
        Me.DgvModulos.Name = "DgvModulos"
        Me.DgvModulos.ReadOnly = True
        Me.DgvModulos.RowHeadersVisible = False
        Me.DgvModulos.RowHeadersWidth = 40
        Me.DgvModulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvModulos.Size = New System.Drawing.Size(535, 343)
        Me.DgvModulos.TabIndex = 30
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GbResumen)
        Me.Panel1.Controls.Add(Me.GbDatosGenerales)
        Me.Panel1.Controls.Add(Me.GbComentarios)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 688)
        Me.Panel1.TabIndex = 6
        '
        'DgvPacas
        '
        Me.DgvPacas.AllowUserToAddRows = False
        Me.DgvPacas.AllowUserToDeleteRows = False
        Me.DgvPacas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvPacas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvPacas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvPacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacas.Location = New System.Drawing.Point(3, 16)
        Me.DgvPacas.MultiSelect = False
        Me.DgvPacas.Name = "DgvPacas"
        Me.DgvPacas.ReadOnly = True
        Me.DgvPacas.RowHeadersVisible = False
        Me.DgvPacas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvPacas.Size = New System.Drawing.Size(535, 307)
        Me.DgvPacas.TabIndex = 31
        '
        'GbPacas
        '
        Me.GbPacas.Controls.Add(Me.DgvPacas)
        Me.GbPacas.Controls.Add(Me.btexcelpacas)
        Me.GbPacas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GbPacas.Location = New System.Drawing.Point(0, 362)
        Me.GbPacas.Name = "GbPacas"
        Me.GbPacas.Size = New System.Drawing.Size(573, 326)
        Me.GbPacas.TabIndex = 32
        Me.GbPacas.TabStop = False
        Me.GbPacas.Text = "Pacas"
        '
        'PDgvs
        '
        Me.PDgvs.Controls.Add(Me.GbModulos)
        Me.PDgvs.Controls.Add(Me.GbPacas)
        Me.PDgvs.Dock = System.Windows.Forms.DockStyle.Right
        Me.PDgvs.Location = New System.Drawing.Point(1008, 24)
        Me.PDgvs.Name = "PDgvs"
        Me.PDgvs.Size = New System.Drawing.Size(573, 688)
        Me.PDgvs.TabIndex = 31
        '
        'btexcelpacas
        '
        Me.btexcelpacas.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.excel
        Me.btexcelpacas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btexcelpacas.Dock = System.Windows.Forms.DockStyle.Right
        Me.btexcelpacas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btexcelpacas.Location = New System.Drawing.Point(538, 16)
        Me.btexcelpacas.MaximumSize = New System.Drawing.Size(32, 32)
        Me.btexcelpacas.MinimumSize = New System.Drawing.Size(32, 32)
        Me.btexcelpacas.Name = "btexcelpacas"
        Me.btexcelpacas.Size = New System.Drawing.Size(32, 32)
        Me.btexcelpacas.TabIndex = 22
        Me.btexcelpacas.UseVisualStyleBackColor = True
        '
        'btexcelmodulos
        '
        Me.btexcelmodulos.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.excel
        Me.btexcelmodulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btexcelmodulos.Dock = System.Windows.Forms.DockStyle.Right
        Me.btexcelmodulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btexcelmodulos.Location = New System.Drawing.Point(538, 16)
        Me.btexcelmodulos.MaximumSize = New System.Drawing.Size(32, 32)
        Me.btexcelmodulos.MinimumSize = New System.Drawing.Size(32, 32)
        Me.btexcelmodulos.Name = "btexcelmodulos"
        Me.btexcelmodulos.Size = New System.Drawing.Size(32, 32)
        Me.btexcelmodulos.TabIndex = 23
        Me.btexcelmodulos.UseVisualStyleBackColor = True
        '
        'LiquidacionesPorRomaneaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1581, 712)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PDgvs)
        Me.Controls.Add(Me.MSMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "LiquidacionesPorRomaneaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liquidaciones Por Romaneaje"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        Me.GbResumen.ResumeLayout(False)
        Me.GbResumen.PerformLayout()
        Me.GbComentarios.ResumeLayout(False)
        Me.GbComentarios.PerformLayout()
        Me.GbModulos.ResumeLayout(False)
        CType(Me.DgvModulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbPacas.ResumeLayout(False)
        Me.PDgvs.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GbDatosGenerales As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CbNombreCliente As ComboBox
    Friend WithEvents DtFechaLiquidacion As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents CbTipo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbIdLiquidacion As TextBox
    Friend WithEvents TbIdOrden As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CbPlanta As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CbPorCuenta As ComboBox
    Friend WithEvents GbResumen As GroupBox
    Friend WithEvents TbTotalHueso As TextBox
    Friend WithEvents TbNumPacas As TextBox
    Friend WithEvents TbNumBorregos As TextBox
    Friend WithEvents TbBorregosPluma As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TbPorcentajeTotal As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TbPorcentajeMerma As TextBox
    Friend WithEvents TbPorcentajeSemilla As TextBox
    Friend WithEvents TbPorcentajePluma As TextBox
    Friend WithEvents TbTotalMerma As TextBox
    Friend WithEvents TbTotalPluma As TextBox
    Friend WithEvents TbTotalSemilla As TextBox
    Friend WithEvents TbComentarios As TextBox
    Friend WithEvents GbComentarios As GroupBox
    Friend WithEvents GbModulos As GroupBox
    Friend WithEvents DgvModulos As DataGridView
    Friend WithEvents Label20 As Label
    Friend WithEvents ChClaseMicros As CheckBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TbTotalBoletas As TextBox
    Friend WithEvents LbTotalBoletas As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DgvPacas As DataGridView
    Friend WithEvents GbPacas As GroupBox
    Friend WithEvents PDgvs As Panel
    Friend WithEvents TbCantPacas As TextBox
    Friend WithEvents TbcantModulos As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btexcelmodulos As Button
    Friend WithEvents btexcelpacas As Button
End Class
