<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Produccion
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Produccion))
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbIdProduccion = New System.Windows.Forms.TextBox()
        Me.CbPlantaOrigen = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBPlantaDestino = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpFechaProduccion = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbTipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.TbIdOrdenTrabajo = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TbNombreProductor = New System.Windows.Forms.TextBox()
        Me.TbPorCuentaDe = New System.Windows.Forms.TextBox()
        Me.TbIdProductor = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.BtAbrirProduccion = New System.Windows.Forms.Button()
        Me.BtCerrarProduccion = New System.Windows.Forms.Button()
        Me.TbFolioCIA = New System.Windows.Forms.TextBox()
        Me.TbKilos = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.BtActualizarFolio = New System.Windows.Forms.Button()
        Me.GbDatosProduccion = New System.Windows.Forms.GroupBox()
        Me.TbFolioInicial = New System.Windows.Forms.TextBox()
        Me.CbTipoProducto = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CbOperador = New System.Windows.Forms.ComboBox()
        Me.CbTurno = New System.Windows.Forms.ComboBox()
        Me.GbModulos = New System.Windows.Forms.GroupBox()
        Me.TbTotalKilos = New System.Windows.Forms.TextBox()
        Me.TbTotalPacas = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TbTotalModulos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TbModulos = New System.Windows.Forms.TextBox()
        Me.BtActivarPrensa = New System.Windows.Forms.Button()
        Me.BtAgregarExcel = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.BtImprimir = New System.Windows.Forms.Button()
        Me.BtIncidencias = New System.Windows.Forms.Button()
        Me.GbCapturaAutomatica = New System.Windows.Forms.GroupBox()
        Me.BtEliminarPacas = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CbPuertosSeriales = New System.Windows.Forms.ComboBox()
        Me.GbLotes = New System.Windows.Forms.GroupBox()
        Me.BtFin = New System.Windows.Forms.Button()
        Me.BtInicio = New System.Windows.Forms.Button()
        Me.BtSiguiente = New System.Windows.Forms.Button()
        Me.BtAnterior = New System.Windows.Forms.Button()
        Me.LbStatus = New System.Windows.Forms.Label()
        Me.DgvPacas = New System.Windows.Forms.DataGridView()
        Me.CkPaca = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GbTipoCaptura = New System.Windows.Forms.GroupBox()
        Me.CkLeersaco = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TiActualizaDgvPacas = New System.Windows.Forms.Timer(Me.components)
        Me.SpCapturaAutomatica = New System.IO.Ports.SerialPort(Me.components)
        Me.MSMenu.SuspendLayout()
        Me.GbDatosGenerales.SuspendLayout()
        Me.GbDatosProduccion.SuspendLayout()
        Me.GbModulos.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbCapturaAutomatica.SuspendLayout()
        Me.GbLotes.SuspendLayout()
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbTipoCaptura.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(1146, 24)
        Me.MSMenu.TabIndex = 0
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'TbIdProduccion
        '
        Me.TbIdProduccion.Enabled = False
        Me.TbIdProduccion.Location = New System.Drawing.Point(130, 19)
        Me.TbIdProduccion.Name = "TbIdProduccion"
        Me.TbIdProduccion.Size = New System.Drawing.Size(71, 20)
        Me.TbIdProduccion.TabIndex = 2
        '
        'CbPlantaOrigen
        '
        Me.CbPlantaOrigen.Enabled = False
        Me.CbPlantaOrigen.FormattingEnabled = True
        Me.CbPlantaOrigen.Location = New System.Drawing.Point(130, 45)
        Me.CbPlantaOrigen.Name = "CbPlantaOrigen"
        Me.CbPlantaOrigen.Size = New System.Drawing.Size(200, 21)
        Me.CbPlantaOrigen.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Planta Origen"
        '
        'CBPlantaDestino
        '
        Me.CBPlantaDestino.Enabled = False
        Me.CBPlantaDestino.FormattingEnabled = True
        Me.CBPlantaDestino.Location = New System.Drawing.Point(130, 72)
        Me.CBPlantaDestino.Name = "CBPlantaDestino"
        Me.CBPlantaDestino.Size = New System.Drawing.Size(200, 21)
        Me.CBPlantaDestino.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Planta Destino"
        '
        'DtpFechaProduccion
        '
        Me.DtpFechaProduccion.Location = New System.Drawing.Point(130, 99)
        Me.DtpFechaProduccion.Name = "DtpFechaProduccion"
        Me.DtpFechaProduccion.Size = New System.Drawing.Size(200, 20)
        Me.DtpFechaProduccion.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha"
        '
        'CbTipo
        '
        Me.CbTipo.Enabled = False
        Me.CbTipo.FormattingEnabled = True
        Me.CbTipo.Location = New System.Drawing.Point(130, 125)
        Me.CbTipo.Name = "CbTipo"
        Me.CbTipo.Size = New System.Drawing.Size(121, 21)
        Me.CbTipo.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tipo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Productor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Por Cuenta de"
        '
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.Controls.Add(Me.TbIdOrdenTrabajo)
        Me.GbDatosGenerales.Controls.Add(Me.Label26)
        Me.GbDatosGenerales.Controls.Add(Me.TbNombreProductor)
        Me.GbDatosGenerales.Controls.Add(Me.TbPorCuentaDe)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdProductor)
        Me.GbDatosGenerales.Controls.Add(Me.CbPlantaOrigen)
        Me.GbDatosGenerales.Controls.Add(Me.Label7)
        Me.GbDatosGenerales.Controls.Add(Me.Label1)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdProduccion)
        Me.GbDatosGenerales.Controls.Add(Me.Label6)
        Me.GbDatosGenerales.Controls.Add(Me.Label2)
        Me.GbDatosGenerales.Controls.Add(Me.CBPlantaDestino)
        Me.GbDatosGenerales.Controls.Add(Me.Label5)
        Me.GbDatosGenerales.Controls.Add(Me.Label3)
        Me.GbDatosGenerales.Controls.Add(Me.CbTipo)
        Me.GbDatosGenerales.Controls.Add(Me.DtpFechaProduccion)
        Me.GbDatosGenerales.Controls.Add(Me.Label4)
        Me.GbDatosGenerales.Dock = System.Windows.Forms.DockStyle.Left
        Me.GbDatosGenerales.Location = New System.Drawing.Point(3, 16)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(462, 211)
        Me.GbDatosGenerales.TabIndex = 15
        Me.GbDatosGenerales.TabStop = False
        Me.GbDatosGenerales.Text = "Datos Generales"
        '
        'TbIdOrdenTrabajo
        '
        Me.TbIdOrdenTrabajo.Location = New System.Drawing.Point(263, 19)
        Me.TbIdOrdenTrabajo.Name = "TbIdOrdenTrabajo"
        Me.TbIdOrdenTrabajo.Size = New System.Drawing.Size(143, 20)
        Me.TbIdOrdenTrabajo.TabIndex = 60
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(207, 24)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(50, 13)
        Me.Label26.TabIndex = 59
        Me.Label26.Text = "ID Orden"
        '
        'TbNombreProductor
        '
        Me.TbNombreProductor.Enabled = False
        Me.TbNombreProductor.Location = New System.Drawing.Point(192, 152)
        Me.TbNombreProductor.Name = "TbNombreProductor"
        Me.TbNombreProductor.Size = New System.Drawing.Size(226, 20)
        Me.TbNombreProductor.TabIndex = 58
        '
        'TbPorCuentaDe
        '
        Me.TbPorCuentaDe.Enabled = False
        Me.TbPorCuentaDe.Location = New System.Drawing.Point(130, 178)
        Me.TbPorCuentaDe.Name = "TbPorCuentaDe"
        Me.TbPorCuentaDe.Size = New System.Drawing.Size(288, 20)
        Me.TbPorCuentaDe.TabIndex = 57
        Me.TbPorCuentaDe.Text = "ALGODONERA NUEVA HOLANDA"
        '
        'TbIdProductor
        '
        Me.TbIdProductor.Enabled = False
        Me.TbIdProductor.Location = New System.Drawing.Point(130, 152)
        Me.TbIdProductor.Name = "TbIdProductor"
        Me.TbIdProductor.Size = New System.Drawing.Size(56, 20)
        Me.TbIdProductor.TabIndex = 15
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 13)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Turno"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(28, 13)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "Tipo"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(9, 74)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(51, 13)
        Me.Label21.TabIndex = 44
        Me.Label21.Text = "Operador"
        Me.Label21.Visible = False
        '
        'BtAbrirProduccion
        '
        Me.BtAbrirProduccion.Location = New System.Drawing.Point(12, 169)
        Me.BtAbrirProduccion.Name = "BtAbrirProduccion"
        Me.BtAbrirProduccion.Size = New System.Drawing.Size(95, 23)
        Me.BtAbrirProduccion.TabIndex = 45
        Me.BtAbrirProduccion.Text = "Abrir Produccion"
        Me.BtAbrirProduccion.UseVisualStyleBackColor = True
        '
        'BtCerrarProduccion
        '
        Me.BtCerrarProduccion.Location = New System.Drawing.Point(115, 169)
        Me.BtCerrarProduccion.Name = "BtCerrarProduccion"
        Me.BtCerrarProduccion.Size = New System.Drawing.Size(100, 23)
        Me.BtCerrarProduccion.TabIndex = 46
        Me.BtCerrarProduccion.Text = "Cerrar Produccion"
        Me.BtCerrarProduccion.UseVisualStyleBackColor = True
        '
        'TbFolioCIA
        '
        Me.TbFolioCIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbFolioCIA.Location = New System.Drawing.Point(6, 46)
        Me.TbFolioCIA.MaxLength = 10
        Me.TbFolioCIA.Name = "TbFolioCIA"
        Me.TbFolioCIA.Size = New System.Drawing.Size(302, 62)
        Me.TbFolioCIA.TabIndex = 47
        '
        'TbKilos
        '
        Me.TbKilos.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbKilos.Location = New System.Drawing.Point(6, 143)
        Me.TbKilos.MaxLength = 10
        Me.TbKilos.Name = "TbKilos"
        Me.TbKilos.Size = New System.Drawing.Size(302, 62)
        Me.TbKilos.TabIndex = 49
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 12)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(121, 29)
        Me.Label22.TabIndex = 50
        Me.Label22.Text = "Folio CIA"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(1, 111)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 29)
        Me.Label24.TabIndex = 52
        Me.Label24.Text = "Kilos"
        '
        'BtActualizarFolio
        '
        Me.BtActualizarFolio.Location = New System.Drawing.Point(186, 128)
        Me.BtActualizarFolio.Name = "BtActualizarFolio"
        Me.BtActualizarFolio.Size = New System.Drawing.Size(64, 23)
        Me.BtActualizarFolio.TabIndex = 53
        Me.BtActualizarFolio.Text = "Actualizar"
        Me.BtActualizarFolio.UseVisualStyleBackColor = True
        '
        'GbDatosProduccion
        '
        Me.GbDatosProduccion.Controls.Add(Me.TbFolioInicial)
        Me.GbDatosProduccion.Controls.Add(Me.CbTipoProducto)
        Me.GbDatosProduccion.Controls.Add(Me.Label8)
        Me.GbDatosProduccion.Controls.Add(Me.CbOperador)
        Me.GbDatosProduccion.Controls.Add(Me.CbTurno)
        Me.GbDatosProduccion.Controls.Add(Me.BtActualizarFolio)
        Me.GbDatosProduccion.Controls.Add(Me.Label19)
        Me.GbDatosProduccion.Controls.Add(Me.Label20)
        Me.GbDatosProduccion.Controls.Add(Me.Label21)
        Me.GbDatosProduccion.Controls.Add(Me.BtAbrirProduccion)
        Me.GbDatosProduccion.Controls.Add(Me.BtCerrarProduccion)
        Me.GbDatosProduccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbDatosProduccion.Location = New System.Drawing.Point(465, 16)
        Me.GbDatosProduccion.Name = "GbDatosProduccion"
        Me.GbDatosProduccion.Size = New System.Drawing.Size(256, 211)
        Me.GbDatosProduccion.TabIndex = 54
        Me.GbDatosProduccion.TabStop = False
        Me.GbDatosProduccion.Text = "Datos de Produccion"
        '
        'TbFolioInicial
        '
        Me.TbFolioInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbFolioInicial.Location = New System.Drawing.Point(6, 125)
        Me.TbFolioInicial.MaxLength = 10
        Me.TbFolioInicial.Name = "TbFolioInicial"
        Me.TbFolioInicial.Size = New System.Drawing.Size(174, 29)
        Me.TbFolioInicial.TabIndex = 57
        '
        'CbTipoProducto
        '
        Me.CbTipoProducto.FormattingEnabled = True
        Me.CbTipoProducto.Items.AddRange(New Object() {"PACA"})
        Me.CbTipoProducto.Location = New System.Drawing.Point(115, 45)
        Me.CbTipoProducto.Name = "CbTipoProducto"
        Me.CbTipoProducto.Size = New System.Drawing.Size(121, 21)
        Me.CbTipoProducto.TabIndex = 56
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 24)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Folio Inicial"
        '
        'CbOperador
        '
        Me.CbOperador.FormattingEnabled = True
        Me.CbOperador.Location = New System.Drawing.Point(115, 71)
        Me.CbOperador.Name = "CbOperador"
        Me.CbOperador.Size = New System.Drawing.Size(121, 21)
        Me.CbOperador.TabIndex = 55
        Me.CbOperador.Visible = False
        '
        'CbTurno
        '
        Me.CbTurno.FormattingEnabled = True
        Me.CbTurno.Location = New System.Drawing.Point(115, 18)
        Me.CbTurno.Name = "CbTurno"
        Me.CbTurno.Size = New System.Drawing.Size(121, 21)
        Me.CbTurno.TabIndex = 54
        '
        'GbModulos
        '
        Me.GbModulos.Controls.Add(Me.TbTotalKilos)
        Me.GbModulos.Controls.Add(Me.TbTotalPacas)
        Me.GbModulos.Controls.Add(Me.Label11)
        Me.GbModulos.Controls.Add(Me.TbTotalModulos)
        Me.GbModulos.Controls.Add(Me.Label9)
        Me.GbModulos.Controls.Add(Me.Label25)
        Me.GbModulos.Controls.Add(Me.TbModulos)
        Me.GbModulos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GbModulos.Location = New System.Drawing.Point(3, 227)
        Me.GbModulos.Name = "GbModulos"
        Me.GbModulos.Size = New System.Drawing.Size(1140, 109)
        Me.GbModulos.TabIndex = 55
        Me.GbModulos.TabStop = False
        Me.GbModulos.Text = "Modulos"
        '
        'TbTotalKilos
        '
        Me.TbTotalKilos.Enabled = False
        Me.TbTotalKilos.Location = New System.Drawing.Point(481, 80)
        Me.TbTotalKilos.Name = "TbTotalKilos"
        Me.TbTotalKilos.Size = New System.Drawing.Size(100, 20)
        Me.TbTotalKilos.TabIndex = 56
        '
        'TbTotalPacas
        '
        Me.TbTotalPacas.Enabled = False
        Me.TbTotalPacas.Location = New System.Drawing.Point(291, 80)
        Me.TbTotalPacas.Name = "TbTotalPacas"
        Me.TbTotalPacas.Size = New System.Drawing.Size(100, 20)
        Me.TbTotalPacas.TabIndex = 56
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(397, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Total de Kilos"
        '
        'TbTotalModulos
        '
        Me.TbTotalModulos.Enabled = False
        Me.TbTotalModulos.Location = New System.Drawing.Point(98, 80)
        Me.TbTotalModulos.Name = "TbTotalModulos"
        Me.TbTotalModulos.Size = New System.Drawing.Size(100, 20)
        Me.TbTotalModulos.TabIndex = 56
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(207, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Total de pacas"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(3, 83)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(89, 13)
        Me.Label25.TabIndex = 56
        Me.Label25.Text = "Total de Modulos"
        '
        'TbModulos
        '
        Me.TbModulos.Dock = System.Windows.Forms.DockStyle.Top
        Me.TbModulos.Enabled = False
        Me.TbModulos.Location = New System.Drawing.Point(3, 16)
        Me.TbModulos.Multiline = True
        Me.TbModulos.Name = "TbModulos"
        Me.TbModulos.Size = New System.Drawing.Size(1134, 58)
        Me.TbModulos.TabIndex = 0
        '
        'BtActivarPrensa
        '
        Me.BtActivarPrensa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtActivarPrensa.Location = New System.Drawing.Point(12, 76)
        Me.BtActivarPrensa.Name = "BtActivarPrensa"
        Me.BtActivarPrensa.Size = New System.Drawing.Size(305, 29)
        Me.BtActivarPrensa.TabIndex = 57
        Me.BtActivarPrensa.Text = "Activar Lectura de Prensa"
        Me.BtActivarPrensa.UseVisualStyleBackColor = True
        '
        'BtAgregarExcel
        '
        Me.BtAgregarExcel.Location = New System.Drawing.Point(11, 111)
        Me.BtAgregarExcel.Name = "BtAgregarExcel"
        Me.BtAgregarExcel.Size = New System.Drawing.Size(305, 29)
        Me.BtAgregarExcel.TabIndex = 58
        Me.BtAgregarExcel.Text = "Agregar Pacas desde Archivo de Excel"
        Me.BtAgregarExcel.UseVisualStyleBackColor = True
        Me.BtAgregarExcel.Visible = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(11, 146)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 59
        Me.NumericUpDown1.Visible = False
        '
        'BtImprimir
        '
        Me.BtImprimir.Location = New System.Drawing.Point(132, 143)
        Me.BtImprimir.Name = "BtImprimir"
        Me.BtImprimir.Size = New System.Drawing.Size(184, 23)
        Me.BtImprimir.TabIndex = 60
        Me.BtImprimir.Text = "Imprimir"
        Me.BtImprimir.UseVisualStyleBackColor = True
        Me.BtImprimir.Visible = False
        '
        'BtIncidencias
        '
        Me.BtIncidencias.Location = New System.Drawing.Point(11, 172)
        Me.BtIncidencias.Name = "BtIncidencias"
        Me.BtIncidencias.Size = New System.Drawing.Size(305, 29)
        Me.BtIncidencias.TabIndex = 61
        Me.BtIncidencias.Text = "Incidencias"
        Me.BtIncidencias.UseVisualStyleBackColor = True
        Me.BtIncidencias.Visible = False
        '
        'GbCapturaAutomatica
        '
        Me.GbCapturaAutomatica.Controls.Add(Me.BtEliminarPacas)
        Me.GbCapturaAutomatica.Controls.Add(Me.Label10)
        Me.GbCapturaAutomatica.Controls.Add(Me.CbPuertosSeriales)
        Me.GbCapturaAutomatica.Controls.Add(Me.BtActivarPrensa)
        Me.GbCapturaAutomatica.Controls.Add(Me.BtIncidencias)
        Me.GbCapturaAutomatica.Controls.Add(Me.GbLotes)
        Me.GbCapturaAutomatica.Controls.Add(Me.BtAgregarExcel)
        Me.GbCapturaAutomatica.Controls.Add(Me.BtImprimir)
        Me.GbCapturaAutomatica.Controls.Add(Me.NumericUpDown1)
        Me.GbCapturaAutomatica.Dock = System.Windows.Forms.DockStyle.Right
        Me.GbCapturaAutomatica.Enabled = False
        Me.GbCapturaAutomatica.Location = New System.Drawing.Point(807, 16)
        Me.GbCapturaAutomatica.Name = "GbCapturaAutomatica"
        Me.GbCapturaAutomatica.Size = New System.Drawing.Size(336, 410)
        Me.GbCapturaAutomatica.TabIndex = 62
        Me.GbCapturaAutomatica.TabStop = False
        Me.GbCapturaAutomatica.Text = "Captura de Lotes Automatico"
        '
        'BtEliminarPacas
        '
        Me.BtEliminarPacas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtEliminarPacas.Location = New System.Drawing.Point(3, 384)
        Me.BtEliminarPacas.MaximumSize = New System.Drawing.Size(173, 23)
        Me.BtEliminarPacas.MinimumSize = New System.Drawing.Size(173, 23)
        Me.BtEliminarPacas.Name = "BtEliminarPacas"
        Me.BtEliminarPacas.Size = New System.Drawing.Size(173, 23)
        Me.BtEliminarPacas.TabIndex = 71
        Me.BtEliminarPacas.Text = "Eliminar Pacas Seleccionadas"
        Me.BtEliminarPacas.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 50)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Puerto " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Serial"
        '
        'CbPuertosSeriales
        '
        Me.CbPuertosSeriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbPuertosSeriales.FormattingEnabled = True
        Me.CbPuertosSeriales.Location = New System.Drawing.Point(105, 37)
        Me.CbPuertosSeriales.Name = "CbPuertosSeriales"
        Me.CbPuertosSeriales.Size = New System.Drawing.Size(212, 33)
        Me.CbPuertosSeriales.TabIndex = 58
        '
        'GbLotes
        '
        Me.GbLotes.Controls.Add(Me.BtFin)
        Me.GbLotes.Controls.Add(Me.BtInicio)
        Me.GbLotes.Controls.Add(Me.BtSiguiente)
        Me.GbLotes.Controls.Add(Me.BtAnterior)
        Me.GbLotes.Location = New System.Drawing.Point(7, 235)
        Me.GbLotes.Name = "GbLotes"
        Me.GbLotes.Size = New System.Drawing.Size(310, 83)
        Me.GbLotes.TabIndex = 63
        Me.GbLotes.TabStop = False
        Me.GbLotes.Text = "Lotes"
        Me.GbLotes.Visible = False
        '
        'BtFin
        '
        Me.BtFin.Location = New System.Drawing.Point(185, 48)
        Me.BtFin.Name = "BtFin"
        Me.BtFin.Size = New System.Drawing.Size(131, 23)
        Me.BtFin.TabIndex = 3
        Me.BtFin.Text = "Final"
        Me.BtFin.UseVisualStyleBackColor = True
        '
        'BtInicio
        '
        Me.BtInicio.Location = New System.Drawing.Point(6, 48)
        Me.BtInicio.Name = "BtInicio"
        Me.BtInicio.Size = New System.Drawing.Size(131, 23)
        Me.BtInicio.TabIndex = 2
        Me.BtInicio.Text = "Inicio"
        Me.BtInicio.UseVisualStyleBackColor = True
        '
        'BtSiguiente
        '
        Me.BtSiguiente.Location = New System.Drawing.Point(184, 19)
        Me.BtSiguiente.Name = "BtSiguiente"
        Me.BtSiguiente.Size = New System.Drawing.Size(131, 23)
        Me.BtSiguiente.TabIndex = 1
        Me.BtSiguiente.Text = "Siguiente"
        Me.BtSiguiente.UseVisualStyleBackColor = True
        '
        'BtAnterior
        '
        Me.BtAnterior.Location = New System.Drawing.Point(6, 19)
        Me.BtAnterior.Name = "BtAnterior"
        Me.BtAnterior.Size = New System.Drawing.Size(131, 23)
        Me.BtAnterior.TabIndex = 0
        Me.BtAnterior.Text = "Anterior"
        Me.BtAnterior.UseVisualStyleBackColor = True
        '
        'LbStatus
        '
        Me.LbStatus.AutoEllipsis = True
        Me.LbStatus.AutoSize = True
        Me.LbStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.LbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LbStatus.Location = New System.Drawing.Point(3, 16)
        Me.LbStatus.Name = "LbStatus"
        Me.LbStatus.Size = New System.Drawing.Size(561, 31)
        Me.LbStatus.TabIndex = 69
        Me.LbStatus.Text = "CAPTURA AUTOMATICA DESACTIVADA"
        Me.LbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DgvPacas
        '
        Me.DgvPacas.AllowUserToAddRows = False
        Me.DgvPacas.AllowUserToDeleteRows = False
        Me.DgvPacas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvPacas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvPacas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvPacas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvPacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CkPaca})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvPacas.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvPacas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvPacas.Location = New System.Drawing.Point(3, 47)
        Me.DgvPacas.MultiSelect = False
        Me.DgvPacas.Name = "DgvPacas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvPacas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvPacas.RowHeadersVisible = False
        Me.DgvPacas.RowHeadersWidth = 40
        Me.DgvPacas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPacas.Size = New System.Drawing.Size(798, 360)
        Me.DgvPacas.TabIndex = 64
        '
        'CkPaca
        '
        Me.CkPaca.FalseValue = "False"
        Me.CkPaca.FillWeight = 50.0!
        Me.CkPaca.HeaderText = "Sel"
        Me.CkPaca.Name = "CkPaca"
        Me.CkPaca.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CkPaca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CkPaca.TrueValue = "True"
        '
        'GbTipoCaptura
        '
        Me.GbTipoCaptura.Controls.Add(Me.CkLeersaco)
        Me.GbTipoCaptura.Controls.Add(Me.Label24)
        Me.GbTipoCaptura.Controls.Add(Me.TbFolioCIA)
        Me.GbTipoCaptura.Controls.Add(Me.TbKilos)
        Me.GbTipoCaptura.Controls.Add(Me.Label22)
        Me.GbTipoCaptura.Dock = System.Windows.Forms.DockStyle.Right
        Me.GbTipoCaptura.Enabled = False
        Me.GbTipoCaptura.Location = New System.Drawing.Point(721, 16)
        Me.GbTipoCaptura.Name = "GbTipoCaptura"
        Me.GbTipoCaptura.Size = New System.Drawing.Size(422, 211)
        Me.GbTipoCaptura.TabIndex = 65
        Me.GbTipoCaptura.TabStop = False
        Me.GbTipoCaptura.Text = "Captura Peso"
        '
        'CkLeersaco
        '
        Me.CkLeersaco.AutoSize = True
        Me.CkLeersaco.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkLeersaco.Location = New System.Drawing.Point(295, 12)
        Me.CkLeersaco.Name = "CkLeersaco"
        Me.CkLeersaco.Size = New System.Drawing.Size(121, 28)
        Me.CkLeersaco.TabIndex = 53
        Me.CkLeersaco.Text = "Leer saco"
        Me.CkLeersaco.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvPacas)
        Me.GroupBox1.Controls.Add(Me.LbStatus)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(804, 410)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.GbCapturaAutomatica)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 363)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1146, 429)
        Me.GroupBox2.TabIndex = 67
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GbDatosProduccion)
        Me.GroupBox3.Controls.Add(Me.GbTipoCaptura)
        Me.GroupBox3.Controls.Add(Me.GbDatosGenerales)
        Me.GroupBox3.Controls.Add(Me.GbModulos)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1146, 339)
        Me.GroupBox3.TabIndex = 68
        Me.GroupBox3.TabStop = False
        '
        'TiActualizaDgvPacas
        '
        Me.TiActualizaDgvPacas.Interval = 1000
        '
        'SpCapturaAutomatica
        '
        '
        'Produccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1146, 792)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.MSMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "Produccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produccion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        Me.GbDatosProduccion.ResumeLayout(False)
        Me.GbDatosProduccion.PerformLayout()
        Me.GbModulos.ResumeLayout(False)
        Me.GbModulos.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbCapturaAutomatica.ResumeLayout(False)
        Me.GbCapturaAutomatica.PerformLayout()
        Me.GbLotes.ResumeLayout(False)
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbTipoCaptura.ResumeLayout(False)
        Me.GbTipoCaptura.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TbIdProduccion As TextBox
    Friend WithEvents CbPlantaOrigen As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CBPlantaDestino As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DtpFechaProduccion As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents CbTipo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GbDatosGenerales As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents BtAbrirProduccion As Button
    Friend WithEvents BtCerrarProduccion As Button
    Friend WithEvents TbFolioCIA As TextBox
    Friend WithEvents TbKilos As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents BtActualizarFolio As Button
    Friend WithEvents GbDatosProduccion As GroupBox
    Friend WithEvents GbModulos As GroupBox
    Friend WithEvents TbTotalModulos As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TbModulos As TextBox
    Friend WithEvents BtActivarPrensa As Button
    Friend WithEvents BtAgregarExcel As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents BtImprimir As Button
    Friend WithEvents BtIncidencias As Button
    Friend WithEvents GbCapturaAutomatica As GroupBox
    Friend WithEvents GbLotes As GroupBox
    Friend WithEvents BtFin As Button
    Friend WithEvents BtInicio As Button
    Friend WithEvents BtSiguiente As Button
    Friend WithEvents BtAnterior As Button
    Friend WithEvents TbNombreProductor As TextBox
    Friend WithEvents TbPorCuentaDe As TextBox
    Friend WithEvents TbIdProductor As TextBox
    Friend WithEvents CbTurno As ComboBox
    Friend WithEvents CbOperador As ComboBox
    Friend WithEvents TbIdOrdenTrabajo As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents DgvPacas As DataGridView
    Friend WithEvents CbTipoProducto As ComboBox
    Friend WithEvents GbTipoCaptura As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TbFolioInicial As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TbTotalPacas As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LbStatus As Label
    Friend WithEvents TiActualizaDgvPacas As Timer
    Friend WithEvents SpCapturaAutomatica As IO.Ports.SerialPort
    Friend WithEvents CbPuertosSeriales As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CkLeersaco As CheckBox
    Friend WithEvents CkPaca As DataGridViewCheckBoxColumn
    Friend WithEvents BtEliminarPacas As Button
    Friend WithEvents TbTotalKilos As TextBox
    Friend WithEvents Label11 As Label
End Class
