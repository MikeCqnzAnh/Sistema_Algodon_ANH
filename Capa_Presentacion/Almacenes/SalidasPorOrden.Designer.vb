<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalidasPorOrden
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalidasPorOrden))
        Me.GbGeneral = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.CbAcuenta = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TbNeto = New System.Windows.Forms.TextBox()
        Me.TbBruto = New System.Windows.Forms.TextBox()
        Me.TbTara = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TbNoLote = New System.Windows.Forms.TextBox()
        Me.TbFolioSalida = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DtpFechaEntrada = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DtFechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.TbDestino = New System.Windows.Forms.TextBox()
        Me.TbNoFactura = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TbObservaciones = New System.Windows.Forms.TextBox()
        Me.TbTelefono = New System.Windows.Forms.TextBox()
        Me.TbNombreChofer = New System.Windows.Forms.TextBox()
        Me.TbNoLicencia = New System.Windows.Forms.TextBox()
        Me.TbPlacaTractoCamion = New System.Windows.Forms.TextBox()
        Me.TbNoContenedor = New System.Windows.Forms.TextBox()
        Me.TbPlacaCaja = New System.Windows.Forms.TextBox()
        Me.TbIdEmbarque = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbNombreComprador = New System.Windows.Forms.TextBox()
        Me.TbIdSalida = New System.Windows.Forms.TextBox()
        Me.TbNoPacas = New System.Windows.Forms.TextBox()
        Me.BtnBuscarEmbarque = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbIdComprador = New System.Windows.Forms.TextBox()
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TbSalidas = New System.Windows.Forms.TabControl()
        Me.Pagina3 = New System.Windows.Forms.TabPage()
        Me.DgvSalidas = New System.Windows.Forms.DataGridView()
        Me.Paginas4 = New System.Windows.Forms.TabPage()
        Me.DgvSalidaPacas = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TbPacasMarcadasLotes = New System.Windows.Forms.TextBox()
        Me.TbPacasLoteadas = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtExcel = New System.Windows.Forms.Button()
        Me.BtQuitarPacas = New System.Windows.Forms.Button()
        Me.BtAgregarPacas = New System.Windows.Forms.Button()
        Me.PanelOrdenes = New System.Windows.Forms.Panel()
        Me.TbEmbarques = New System.Windows.Forms.TabControl()
        Me.Pagina1 = New System.Windows.Forms.TabPage()
        Me.DgvOrdenes = New System.Windows.Forms.DataGridView()
        Me.Pagina2 = New System.Windows.Forms.TabPage()
        Me.DgvOrdenesDetalle = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TbPacasMarcadas = New System.Windows.Forms.TextBox()
        Me.TbPacasDisponibles = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtFiltroSeleccion = New System.Windows.Forms.Button()
        Me.BtFiltroDisponible = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.CbLotesSeleccionadas = New System.Windows.Forms.ComboBox()
        Me.CbLotesDisponible = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarNuevaSalidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbGeneral.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GbDatos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TbSalidas.SuspendLayout()
        Me.Pagina3.SuspendLayout()
        CType(Me.DgvSalidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Paginas4.SuspendLayout()
        CType(Me.DgvSalidaPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelOrdenes.SuspendLayout()
        Me.TbEmbarques.SuspendLayout()
        Me.Pagina1.SuspendLayout()
        CType(Me.DgvOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pagina2.SuspendLayout()
        CType(Me.DgvOrdenesDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbGeneral
        '
        Me.GbGeneral.Controls.Add(Me.Label26)
        Me.GbGeneral.Controls.Add(Me.CbAcuenta)
        Me.GbGeneral.Controls.Add(Me.GroupBox1)
        Me.GbGeneral.Controls.Add(Me.TbNoLote)
        Me.GbGeneral.Controls.Add(Me.TbFolioSalida)
        Me.GbGeneral.Controls.Add(Me.Label21)
        Me.GbGeneral.Controls.Add(Me.Panel3)
        Me.GbGeneral.Controls.Add(Me.TbDestino)
        Me.GbGeneral.Controls.Add(Me.TbNoFactura)
        Me.GbGeneral.Controls.Add(Me.Label15)
        Me.GbGeneral.Controls.Add(Me.Label10)
        Me.GbGeneral.Controls.Add(Me.TbObservaciones)
        Me.GbGeneral.Controls.Add(Me.TbTelefono)
        Me.GbGeneral.Controls.Add(Me.TbNombreChofer)
        Me.GbGeneral.Controls.Add(Me.TbNoLicencia)
        Me.GbGeneral.Controls.Add(Me.TbPlacaTractoCamion)
        Me.GbGeneral.Controls.Add(Me.TbNoContenedor)
        Me.GbGeneral.Controls.Add(Me.TbPlacaCaja)
        Me.GbGeneral.Controls.Add(Me.TbIdEmbarque)
        Me.GbGeneral.Controls.Add(Me.Label14)
        Me.GbGeneral.Controls.Add(Me.Label13)
        Me.GbGeneral.Controls.Add(Me.Label12)
        Me.GbGeneral.Controls.Add(Me.Label11)
        Me.GbGeneral.Controls.Add(Me.Label9)
        Me.GbGeneral.Controls.Add(Me.Label8)
        Me.GbGeneral.Controls.Add(Me.Label7)
        Me.GbGeneral.Controls.Add(Me.Label3)
        Me.GbGeneral.Controls.Add(Me.Label2)
        Me.GbGeneral.Controls.Add(Me.Label1)
        Me.GbGeneral.Controls.Add(Me.TbNombreComprador)
        Me.GbGeneral.Controls.Add(Me.TbIdSalida)
        Me.GbGeneral.Controls.Add(Me.TbNoPacas)
        Me.GbGeneral.Controls.Add(Me.BtnBuscarEmbarque)
        Me.GbGeneral.Controls.Add(Me.Label6)
        Me.GbGeneral.Controls.Add(Me.Label5)
        Me.GbGeneral.Controls.Add(Me.TbIdComprador)
        Me.GbGeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbGeneral.Location = New System.Drawing.Point(0, 24)
        Me.GbGeneral.Name = "GbGeneral"
        Me.GbGeneral.Size = New System.Drawing.Size(1261, 287)
        Me.GbGeneral.TabIndex = 0
        Me.GbGeneral.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(603, 173)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(74, 13)
        Me.Label26.TabIndex = 122
        Me.Label26.Text = "Por cuenta de"
        '
        'CbAcuenta
        '
        Me.CbAcuenta.FormattingEnabled = True
        Me.CbAcuenta.Location = New System.Drawing.Point(683, 170)
        Me.CbAcuenta.Name = "CbAcuenta"
        Me.CbAcuenta.Size = New System.Drawing.Size(188, 21)
        Me.CbAcuenta.TabIndex = 121
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TbNeto)
        Me.GroupBox1.Controls.Add(Me.TbBruto)
        Me.GroupBox1.Controls.Add(Me.TbTara)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(877, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 168)
        Me.GroupBox1.TabIndex = 120
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Captura Peso"
        '
        'TbNeto
        '
        Me.TbNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNeto.Location = New System.Drawing.Point(100, 112)
        Me.TbNeto.MaxLength = 10
        Me.TbNeto.Name = "TbNeto"
        Me.TbNeto.ReadOnly = True
        Me.TbNeto.Size = New System.Drawing.Size(267, 40)
        Me.TbNeto.TabIndex = 82
        Me.TbNeto.Text = "0"
        Me.TbNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbBruto
        '
        Me.TbBruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbBruto.Location = New System.Drawing.Point(100, 66)
        Me.TbBruto.MaxLength = 10
        Me.TbBruto.Name = "TbBruto"
        Me.TbBruto.Size = New System.Drawing.Size(267, 40)
        Me.TbBruto.TabIndex = 81
        Me.TbBruto.Text = "0"
        Me.TbBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbTara
        '
        Me.TbTara.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTara.Location = New System.Drawing.Point(100, 20)
        Me.TbTara.MaxLength = 10
        Me.TbTara.Name = "TbTara"
        Me.TbTara.Size = New System.Drawing.Size(267, 40)
        Me.TbTara.TabIndex = 80
        Me.TbTara.Text = "0"
        Me.TbTara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 33)
        Me.Label16.TabIndex = 83
        Me.Label16.Text = "Bruto"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(15, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 33)
        Me.Label17.TabIndex = 84
        Me.Label17.Text = "Tara"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(15, 115)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 33)
        Me.Label18.TabIndex = 85
        Me.Label18.Text = "Neto"
        '
        'TbNoLote
        '
        Me.TbNoLote.Enabled = False
        Me.TbNoLote.Location = New System.Drawing.Point(569, 199)
        Me.TbNoLote.Name = "TbNoLote"
        Me.TbNoLote.Size = New System.Drawing.Size(138, 20)
        Me.TbNoLote.TabIndex = 119
        Me.TbNoLote.Visible = False
        '
        'TbFolioSalida
        '
        Me.TbFolioSalida.Location = New System.Drawing.Point(112, 91)
        Me.TbFolioSalida.Name = "TbFolioSalida"
        Me.TbFolioSalida.Size = New System.Drawing.Size(100, 20)
        Me.TbFolioSalida.TabIndex = 95
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(4, 94)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(61, 13)
        Me.Label21.TabIndex = 118
        Me.Label21.Text = "Folio Salida"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.DtpFechaEntrada)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.CbEstatus)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.DtFechaSalida)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(877, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(381, 97)
        Me.Panel3.TabIndex = 117
        '
        'DtpFechaEntrada
        '
        Me.DtpFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaEntrada.Location = New System.Drawing.Point(140, 3)
        Me.DtpFechaEntrada.Name = "DtpFechaEntrada"
        Me.DtpFechaEntrada.Size = New System.Drawing.Size(100, 20)
        Me.DtpFechaEntrada.TabIndex = 29
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(57, 65)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 13)
        Me.Label20.TabIndex = 83
        Me.Label20.Text = "Estatus"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Fecha Entrada"
        '
        'CbEstatus
        '
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(119, 62)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.CbEstatus.TabIndex = 82
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(57, 35)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 13)
        Me.Label19.TabIndex = 80
        Me.Label19.Text = "Fecha Salida"
        '
        'DtFechaSalida
        '
        Me.DtFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaSalida.Location = New System.Drawing.Point(140, 31)
        Me.DtFechaSalida.Name = "DtFechaSalida"
        Me.DtFechaSalida.Size = New System.Drawing.Size(100, 20)
        Me.DtFechaSalida.TabIndex = 81
        '
        'TbDestino
        '
        Me.TbDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbDestino.Location = New System.Drawing.Point(112, 117)
        Me.TbDestino.Name = "TbDestino"
        Me.TbDestino.Size = New System.Drawing.Size(570, 20)
        Me.TbDestino.TabIndex = 98
        '
        'TbNoFactura
        '
        Me.TbNoFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNoFactura.Location = New System.Drawing.Point(332, 91)
        Me.TbNoFactura.Name = "TbNoFactura"
        Me.TbNoFactura.Size = New System.Drawing.Size(115, 20)
        Me.TbNoFactura.TabIndex = 96
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(253, 94)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 13)
        Me.Label15.TabIndex = 116
        Me.Label15.Text = "No Factura"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 115
        Me.Label10.Text = "Destino"
        '
        'TbObservaciones
        '
        Me.TbObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbObservaciones.Location = New System.Drawing.Point(112, 170)
        Me.TbObservaciones.Multiline = True
        Me.TbObservaciones.Name = "TbObservaciones"
        Me.TbObservaciones.Size = New System.Drawing.Size(397, 56)
        Me.TbObservaciones.TabIndex = 102
        '
        'TbTelefono
        '
        Me.TbTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbTelefono.Location = New System.Drawing.Point(523, 65)
        Me.TbTelefono.Name = "TbTelefono"
        Me.TbTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TbTelefono.TabIndex = 93
        '
        'TbNombreChofer
        '
        Me.TbNombreChofer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNombreChofer.Location = New System.Drawing.Point(112, 65)
        Me.TbNombreChofer.Name = "TbNombreChofer"
        Me.TbNombreChofer.Size = New System.Drawing.Size(335, 20)
        Me.TbNombreChofer.TabIndex = 92
        '
        'TbNoLicencia
        '
        Me.TbNoLicencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNoLicencia.Location = New System.Drawing.Point(523, 91)
        Me.TbNoLicencia.Name = "TbNoLicencia"
        Me.TbNoLicencia.Size = New System.Drawing.Size(121, 20)
        Me.TbNoLicencia.TabIndex = 97
        '
        'TbPlacaTractoCamion
        '
        Me.TbPlacaTractoCamion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbPlacaTractoCamion.Location = New System.Drawing.Point(756, 64)
        Me.TbPlacaTractoCamion.Name = "TbPlacaTractoCamion"
        Me.TbPlacaTractoCamion.Size = New System.Drawing.Size(115, 20)
        Me.TbPlacaTractoCamion.TabIndex = 94
        '
        'TbNoContenedor
        '
        Me.TbNoContenedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNoContenedor.Location = New System.Drawing.Point(112, 143)
        Me.TbNoContenedor.Name = "TbNoContenedor"
        Me.TbNoContenedor.Size = New System.Drawing.Size(100, 20)
        Me.TbNoContenedor.TabIndex = 100
        '
        'TbPlacaCaja
        '
        Me.TbPlacaCaja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbPlacaCaja.Location = New System.Drawing.Point(332, 143)
        Me.TbPlacaCaja.Name = "TbPlacaCaja"
        Me.TbPlacaCaja.Size = New System.Drawing.Size(115, 20)
        Me.TbPlacaCaja.TabIndex = 101
        '
        'TbIdEmbarque
        '
        Me.TbIdEmbarque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbIdEmbarque.Enabled = False
        Me.TbIdEmbarque.Location = New System.Drawing.Point(112, 39)
        Me.TbIdEmbarque.Name = "TbIdEmbarque"
        Me.TbIdEmbarque.Size = New System.Drawing.Size(100, 20)
        Me.TbIdEmbarque.TabIndex = 88
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 173)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 13)
        Me.Label14.TabIndex = 114
        Me.Label14.Text = "Observaciones"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(453, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 113
        Me.Label13.Text = "Telefono"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 112
        Me.Label12.Text = "Nombre Chofer"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(453, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 111
        Me.Label11.Text = "No Licencia"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(629, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 13)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "Placa de Tracto Camion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(253, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "Placa de Caja"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 108
        Me.Label7.Text = "No Contenedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(518, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "No Lote"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "ID Embarque"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "ID Salida"
        Me.Label1.UseWaitCursor = True
        '
        'TbNombreComprador
        '
        Me.TbNombreComprador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNombreComprador.Enabled = False
        Me.TbNombreComprador.Location = New System.Drawing.Point(450, 38)
        Me.TbNombreComprador.Name = "TbNombreComprador"
        Me.TbNombreComprador.Size = New System.Drawing.Size(421, 20)
        Me.TbNombreComprador.TabIndex = 91
        '
        'TbIdSalida
        '
        Me.TbIdSalida.Enabled = False
        Me.TbIdSalida.Location = New System.Drawing.Point(112, 13)
        Me.TbIdSalida.Name = "TbIdSalida"
        Me.TbIdSalida.Size = New System.Drawing.Size(99, 20)
        Me.TbIdSalida.TabIndex = 87
        Me.TbIdSalida.UseWaitCursor = True
        '
        'TbNoPacas
        '
        Me.TbNoPacas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNoPacas.Enabled = False
        Me.TbNoPacas.Location = New System.Drawing.Point(776, 199)
        Me.TbNoPacas.Name = "TbNoPacas"
        Me.TbNoPacas.Size = New System.Drawing.Size(95, 20)
        Me.TbNoPacas.TabIndex = 99
        Me.TbNoPacas.Visible = False
        '
        'BtnBuscarEmbarque
        '
        Me.BtnBuscarEmbarque.BackgroundImage = CType(resources.GetObject("BtnBuscarEmbarque.BackgroundImage"), System.Drawing.Image)
        Me.BtnBuscarEmbarque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnBuscarEmbarque.Location = New System.Drawing.Point(218, 36)
        Me.BtnBuscarEmbarque.Name = "BtnBuscarEmbarque"
        Me.BtnBuscarEmbarque.Size = New System.Drawing.Size(32, 25)
        Me.BtnBuscarEmbarque.TabIndex = 89
        Me.BtnBuscarEmbarque.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(710, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "No. Pacas"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(253, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Comprador"
        '
        'TbIdComprador
        '
        Me.TbIdComprador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbIdComprador.Enabled = False
        Me.TbIdComprador.Location = New System.Drawing.Point(332, 38)
        Me.TbIdComprador.Name = "TbIdComprador"
        Me.TbIdComprador.Size = New System.Drawing.Size(115, 20)
        Me.TbIdComprador.TabIndex = 90
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.Panel1)
        Me.GbDatos.Controls.Add(Me.Panel2)
        Me.GbDatos.Controls.Add(Me.PanelOrdenes)
        Me.GbDatos.Controls.Add(Me.Panel4)
        Me.GbDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbDatos.Enabled = False
        Me.GbDatos.Location = New System.Drawing.Point(0, 311)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(1261, 409)
        Me.GbDatos.TabIndex = 1
        Me.GbDatos.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TbSalidas)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(836, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(422, 357)
        Me.Panel1.TabIndex = 1
        '
        'TbSalidas
        '
        Me.TbSalidas.Controls.Add(Me.Pagina3)
        Me.TbSalidas.Controls.Add(Me.Paginas4)
        Me.TbSalidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TbSalidas.Location = New System.Drawing.Point(0, 0)
        Me.TbSalidas.Name = "TbSalidas"
        Me.TbSalidas.SelectedIndex = 0
        Me.TbSalidas.Size = New System.Drawing.Size(422, 305)
        Me.TbSalidas.TabIndex = 0
        '
        'Pagina3
        '
        Me.Pagina3.Controls.Add(Me.DgvSalidas)
        Me.Pagina3.Location = New System.Drawing.Point(4, 22)
        Me.Pagina3.Name = "Pagina3"
        Me.Pagina3.Padding = New System.Windows.Forms.Padding(3)
        Me.Pagina3.Size = New System.Drawing.Size(414, 279)
        Me.Pagina3.TabIndex = 0
        Me.Pagina3.Text = "Salidas"
        Me.Pagina3.UseVisualStyleBackColor = True
        '
        'DgvSalidas
        '
        Me.DgvSalidas.AllowUserToAddRows = False
        Me.DgvSalidas.AllowUserToDeleteRows = False
        Me.DgvSalidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvSalidas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvSalidas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvSalidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSalidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvSalidas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvSalidas.Location = New System.Drawing.Point(3, 3)
        Me.DgvSalidas.MultiSelect = False
        Me.DgvSalidas.Name = "DgvSalidas"
        Me.DgvSalidas.RowHeadersVisible = False
        Me.DgvSalidas.RowHeadersWidth = 40
        Me.DgvSalidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSalidas.Size = New System.Drawing.Size(408, 273)
        Me.DgvSalidas.TabIndex = 20
        '
        'Paginas4
        '
        Me.Paginas4.Controls.Add(Me.DgvSalidaPacas)
        Me.Paginas4.Location = New System.Drawing.Point(4, 22)
        Me.Paginas4.Name = "Paginas4"
        Me.Paginas4.Padding = New System.Windows.Forms.Padding(3)
        Me.Paginas4.Size = New System.Drawing.Size(414, 279)
        Me.Paginas4.TabIndex = 1
        Me.Paginas4.Text = "Pacas de Salidas"
        Me.Paginas4.UseVisualStyleBackColor = True
        '
        'DgvSalidaPacas
        '
        Me.DgvSalidaPacas.AllowUserToAddRows = False
        Me.DgvSalidaPacas.AllowUserToDeleteRows = False
        Me.DgvSalidaPacas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvSalidaPacas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvSalidaPacas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvSalidaPacas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvSalidaPacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSalidaPacas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvSalidaPacas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvSalidaPacas.Location = New System.Drawing.Point(3, 3)
        Me.DgvSalidaPacas.MultiSelect = False
        Me.DgvSalidaPacas.Name = "DgvSalidaPacas"
        Me.DgvSalidaPacas.RowHeadersVisible = False
        Me.DgvSalidaPacas.RowHeadersWidth = 40
        Me.DgvSalidaPacas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSalidaPacas.Size = New System.Drawing.Size(408, 273)
        Me.DgvSalidaPacas.TabIndex = 21
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TbPacasMarcadasLotes)
        Me.GroupBox3.Controls.Add(Me.TbPacasLoteadas)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(0, 305)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(422, 52)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        '
        'TbPacasMarcadasLotes
        '
        Me.TbPacasMarcadasLotes.Enabled = False
        Me.TbPacasMarcadasLotes.Location = New System.Drawing.Point(308, 13)
        Me.TbPacasMarcadasLotes.Name = "TbPacasMarcadasLotes"
        Me.TbPacasMarcadasLotes.Size = New System.Drawing.Size(100, 20)
        Me.TbPacasMarcadasLotes.TabIndex = 3
        '
        'TbPacasLoteadas
        '
        Me.TbPacasLoteadas.Enabled = False
        Me.TbPacasLoteadas.Location = New System.Drawing.Point(91, 13)
        Me.TbPacasLoteadas.Name = "TbPacasLoteadas"
        Me.TbPacasLoteadas.Size = New System.Drawing.Size(100, 20)
        Me.TbPacasLoteadas.TabIndex = 2
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(215, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(87, 13)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "Pacas Marcadas"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(79, 13)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Total de Pacas"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtExcel)
        Me.Panel2.Controls.Add(Me.BtQuitarPacas)
        Me.Panel2.Controls.Add(Me.BtAgregarPacas)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(796, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(40, 357)
        Me.Panel2.TabIndex = 0
        '
        'BtExcel
        '
        Me.BtExcel.BackgroundImage = CType(resources.GetObject("BtExcel.BackgroundImage"), System.Drawing.Image)
        Me.BtExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtExcel.Location = New System.Drawing.Point(6, 95)
        Me.BtExcel.Name = "BtExcel"
        Me.BtExcel.Size = New System.Drawing.Size(28, 29)
        Me.BtExcel.TabIndex = 3
        Me.BtExcel.Text = "..."
        Me.BtExcel.UseVisualStyleBackColor = True
        '
        'BtQuitarPacas
        '
        Me.BtQuitarPacas.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.back_button
        Me.BtQuitarPacas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtQuitarPacas.Location = New System.Drawing.Point(6, 60)
        Me.BtQuitarPacas.Name = "BtQuitarPacas"
        Me.BtQuitarPacas.Size = New System.Drawing.Size(28, 29)
        Me.BtQuitarPacas.TabIndex = 0
        Me.BtQuitarPacas.UseVisualStyleBackColor = True
        '
        'BtAgregarPacas
        '
        Me.BtAgregarPacas.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.play_button
        Me.BtAgregarPacas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtAgregarPacas.Location = New System.Drawing.Point(6, 25)
        Me.BtAgregarPacas.Name = "BtAgregarPacas"
        Me.BtAgregarPacas.Size = New System.Drawing.Size(28, 29)
        Me.BtAgregarPacas.TabIndex = 0
        Me.BtAgregarPacas.UseVisualStyleBackColor = True
        '
        'PanelOrdenes
        '
        Me.PanelOrdenes.Controls.Add(Me.TbEmbarques)
        Me.PanelOrdenes.Controls.Add(Me.GroupBox2)
        Me.PanelOrdenes.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelOrdenes.Location = New System.Drawing.Point(3, 49)
        Me.PanelOrdenes.Name = "PanelOrdenes"
        Me.PanelOrdenes.Size = New System.Drawing.Size(793, 357)
        Me.PanelOrdenes.TabIndex = 0
        '
        'TbEmbarques
        '
        Me.TbEmbarques.Controls.Add(Me.Pagina1)
        Me.TbEmbarques.Controls.Add(Me.Pagina2)
        Me.TbEmbarques.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TbEmbarques.Location = New System.Drawing.Point(0, 0)
        Me.TbEmbarques.Name = "TbEmbarques"
        Me.TbEmbarques.SelectedIndex = 0
        Me.TbEmbarques.Size = New System.Drawing.Size(793, 305)
        Me.TbEmbarques.TabIndex = 0
        '
        'Pagina1
        '
        Me.Pagina1.Controls.Add(Me.DgvOrdenes)
        Me.Pagina1.Location = New System.Drawing.Point(4, 22)
        Me.Pagina1.Name = "Pagina1"
        Me.Pagina1.Padding = New System.Windows.Forms.Padding(3)
        Me.Pagina1.Size = New System.Drawing.Size(785, 279)
        Me.Pagina1.TabIndex = 0
        Me.Pagina1.Text = "Ordenes de Embarque"
        Me.Pagina1.UseVisualStyleBackColor = True
        '
        'DgvOrdenes
        '
        Me.DgvOrdenes.AllowUserToAddRows = False
        Me.DgvOrdenes.AllowUserToDeleteRows = False
        Me.DgvOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvOrdenes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvOrdenes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvOrdenes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOrdenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvOrdenes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvOrdenes.Location = New System.Drawing.Point(3, 3)
        Me.DgvOrdenes.MultiSelect = False
        Me.DgvOrdenes.Name = "DgvOrdenes"
        Me.DgvOrdenes.RowHeadersVisible = False
        Me.DgvOrdenes.RowHeadersWidth = 40
        Me.DgvOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvOrdenes.Size = New System.Drawing.Size(779, 273)
        Me.DgvOrdenes.TabIndex = 19
        '
        'Pagina2
        '
        Me.Pagina2.Controls.Add(Me.DgvOrdenesDetalle)
        Me.Pagina2.Location = New System.Drawing.Point(4, 22)
        Me.Pagina2.Name = "Pagina2"
        Me.Pagina2.Padding = New System.Windows.Forms.Padding(3)
        Me.Pagina2.Size = New System.Drawing.Size(785, 279)
        Me.Pagina2.TabIndex = 1
        Me.Pagina2.Text = "Pacas de Embarque"
        Me.Pagina2.UseVisualStyleBackColor = True
        '
        'DgvOrdenesDetalle
        '
        Me.DgvOrdenesDetalle.AllowUserToAddRows = False
        Me.DgvOrdenesDetalle.AllowUserToDeleteRows = False
        Me.DgvOrdenesDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvOrdenesDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvOrdenesDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvOrdenesDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvOrdenesDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOrdenesDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvOrdenesDetalle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvOrdenesDetalle.Location = New System.Drawing.Point(3, 3)
        Me.DgvOrdenesDetalle.MultiSelect = False
        Me.DgvOrdenesDetalle.Name = "DgvOrdenesDetalle"
        Me.DgvOrdenesDetalle.RowHeadersVisible = False
        Me.DgvOrdenesDetalle.RowHeadersWidth = 40
        Me.DgvOrdenesDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvOrdenesDetalle.Size = New System.Drawing.Size(779, 273)
        Me.DgvOrdenesDetalle.TabIndex = 20
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.TbPacasMarcadas)
        Me.GroupBox2.Controls.Add(Me.TbPacasDisponibles)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 305)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(793, 52)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(244, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(87, 13)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "Pacas Marcadas"
        '
        'TbPacasMarcadas
        '
        Me.TbPacasMarcadas.Enabled = False
        Me.TbPacasMarcadas.Location = New System.Drawing.Point(337, 13)
        Me.TbPacasMarcadas.Name = "TbPacasMarcadas"
        Me.TbPacasMarcadas.Size = New System.Drawing.Size(100, 20)
        Me.TbPacasMarcadas.TabIndex = 2
        '
        'TbPacasDisponibles
        '
        Me.TbPacasDisponibles.Enabled = False
        Me.TbPacasDisponibles.Location = New System.Drawing.Point(106, 13)
        Me.TbPacasDisponibles.Name = "TbPacasDisponibles"
        Me.TbPacasDisponibles.Size = New System.Drawing.Size(100, 20)
        Me.TbPacasDisponibles.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(94, 13)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Pacas Disponibles"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BtFiltroSeleccion)
        Me.Panel4.Controls.Add(Me.BtFiltroDisponible)
        Me.Panel4.Controls.Add(Me.Label28)
        Me.Panel4.Controls.Add(Me.Label27)
        Me.Panel4.Controls.Add(Me.CbLotesSeleccionadas)
        Me.Panel4.Controls.Add(Me.CbLotesDisponible)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 16)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1255, 33)
        Me.Panel4.TabIndex = 20
        '
        'BtFiltroSeleccion
        '
        Me.BtFiltroSeleccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtFiltroSeleccion.Location = New System.Drawing.Point(1166, 4)
        Me.BtFiltroSeleccion.Name = "BtFiltroSeleccion"
        Me.BtFiltroSeleccion.Size = New System.Drawing.Size(75, 23)
        Me.BtFiltroSeleccion.TabIndex = 5
        Me.BtFiltroSeleccion.Text = "Filtrar"
        Me.BtFiltroSeleccion.UseVisualStyleBackColor = True
        '
        'BtFiltroDisponible
        '
        Me.BtFiltroDisponible.Location = New System.Drawing.Point(698, 4)
        Me.BtFiltroDisponible.Name = "BtFiltroDisponible"
        Me.BtFiltroDisponible.Size = New System.Drawing.Size(75, 23)
        Me.BtFiltroDisponible.TabIndex = 4
        Me.BtFiltroDisponible.Text = "Filtrar"
        Me.BtFiltroDisponible.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 9)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(58, 13)
        Me.Label28.TabIndex = 3
        Me.Label28.Text = "Filtro Lotes"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(830, 9)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(33, 13)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Lotes"
        '
        'CbLotesSeleccionadas
        '
        Me.CbLotesSeleccionadas.FormattingEnabled = True
        Me.CbLotesSeleccionadas.Location = New System.Drawing.Point(881, 6)
        Me.CbLotesSeleccionadas.Name = "CbLotesSeleccionadas"
        Me.CbLotesSeleccionadas.Size = New System.Drawing.Size(121, 21)
        Me.CbLotesSeleccionadas.TabIndex = 1
        '
        'CbLotesDisponible
        '
        Me.CbLotesDisponible.FormattingEnabled = True
        Me.CbLotesDisponible.Location = New System.Drawing.Point(70, 6)
        Me.CbLotesDisponible.Name = "CbLotesDisponible"
        Me.CbLotesDisponible.Size = New System.Drawing.Size(121, 21)
        Me.CbLotesDisponible.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarToolStripMenuItem, Me.GenerarNuevaSalidaToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1261, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
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
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ConsultarToolStripMenuItem.Text = "Consultar "
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GenerarNuevaSalidaToolStripMenuItem
        '
        Me.GenerarNuevaSalidaToolStripMenuItem.Name = "GenerarNuevaSalidaToolStripMenuItem"
        Me.GenerarNuevaSalidaToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.GenerarNuevaSalidaToolStripMenuItem.Text = "Genera Salida"
        '
        'SalidasPorOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1261, 720)
        Me.Controls.Add(Me.GbDatos)
        Me.Controls.Add(Me.GbGeneral)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1277, 759)
        Me.Name = "SalidasPorOrden"
        Me.Text = "Salidas por Orden de Embarque"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbGeneral.ResumeLayout(False)
        Me.GbGeneral.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GbDatos.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TbSalidas.ResumeLayout(False)
        Me.Pagina3.ResumeLayout(False)
        CType(Me.DgvSalidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Paginas4.ResumeLayout(False)
        CType(Me.DgvSalidaPacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.PanelOrdenes.ResumeLayout(False)
        Me.TbEmbarques.ResumeLayout(False)
        Me.Pagina1.ResumeLayout(False)
        CType(Me.DgvOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pagina2.ResumeLayout(False)
        CType(Me.DgvOrdenesDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbGeneral As GroupBox
    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelOrdenes As Panel
    Friend WithEvents TbSalidas As TabControl
    Friend WithEvents Pagina3 As TabPage
    Friend WithEvents Paginas4 As TabPage
    Friend WithEvents TbEmbarques As TabControl
    Friend WithEvents Pagina1 As TabPage
    Friend WithEvents Pagina2 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtQuitarPacas As Button
    Friend WithEvents BtAgregarPacas As Button
    Friend WithEvents TbNoLote As TextBox
    Friend WithEvents TbFolioSalida As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DtpFechaEntrada As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents DtFechaSalida As DateTimePicker
    Friend WithEvents TbDestino As TextBox
    Friend WithEvents TbNoFactura As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TbObservaciones As TextBox
    Friend WithEvents TbTelefono As TextBox
    Friend WithEvents TbNombreChofer As TextBox
    Friend WithEvents TbNoLicencia As TextBox
    Friend WithEvents TbPlacaTractoCamion As TextBox
    Friend WithEvents TbNoContenedor As TextBox
    Friend WithEvents TbPlacaCaja As TextBox
    Friend WithEvents TbIdEmbarque As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TbNombreComprador As TextBox
    Friend WithEvents TbIdSalida As TextBox
    Friend WithEvents TbNoPacas As TextBox
    Friend WithEvents BtnBuscarEmbarque As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TbIdComprador As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TbNeto As TextBox
    Friend WithEvents TbBruto As TextBox
    Friend WithEvents TbTara As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TbPacasMarcadas As TextBox
    Friend WithEvents TbPacasDisponibles As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TbPacasMarcadasLotes As TextBox
    Friend WithEvents TbPacasLoteadas As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents DgvOrdenes As DataGridView
    Friend WithEvents BtExcel As Button
    Friend WithEvents DgvOrdenesDetalle As DataGridView
    Friend WithEvents DgvSalidas As DataGridView
    Friend WithEvents DgvSalidaPacas As DataGridView
    Friend WithEvents Label26 As Label
    Friend WithEvents CbAcuenta As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents CbLotesSeleccionadas As ComboBox
    Friend WithEvents CbLotesDisponible As ComboBox
    Friend WithEvents BtFiltroSeleccion As Button
    Friend WithEvents BtFiltroDisponible As Button
    Friend WithEvents GenerarNuevaSalidaToolStripMenuItem As ToolStripMenuItem
End Class
