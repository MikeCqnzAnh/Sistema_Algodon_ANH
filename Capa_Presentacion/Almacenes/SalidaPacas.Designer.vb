<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalidaPacas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalidaPacas))
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.TbDestino = New System.Windows.Forms.TextBox()
        Me.TbNoFactura = New System.Windows.Forms.TextBox()
        Me.DtFechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TbObservaciones = New System.Windows.Forms.TextBox()
        Me.TbTelefono = New System.Windows.Forms.TextBox()
        Me.TbNombreChofer = New System.Windows.Forms.TextBox()
        Me.TbNoLicencia = New System.Windows.Forms.TextBox()
        Me.CbNoLote = New System.Windows.Forms.ComboBox()
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpFechaEntrada = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbIdComprador = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GbPesos = New System.Windows.Forms.GroupBox()
        Me.TbNeto = New System.Windows.Forms.TextBox()
        Me.TbBruto = New System.Windows.Forms.TextBox()
        Me.TbTara = New System.Windows.Forms.TextBox()
        Me.GbPacas = New System.Windows.Forms.GroupBox()
        Me.DgvPacas = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnBuscarEmbarque = New System.Windows.Forms.Button()
        Me.MSMenu.SuspendLayout()
        Me.GbDatosGenerales.SuspendLayout()
        Me.GbPesos.SuspendLayout()
        Me.GbPacas.SuspendLayout()
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(1483, 24)
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
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.Controls.Add(Me.Panel1)
        Me.GbDatosGenerales.Controls.Add(Me.TbDestino)
        Me.GbDatosGenerales.Controls.Add(Me.TbNoFactura)
        Me.GbDatosGenerales.Controls.Add(Me.Label15)
        Me.GbDatosGenerales.Controls.Add(Me.Label10)
        Me.GbDatosGenerales.Controls.Add(Me.TbObservaciones)
        Me.GbDatosGenerales.Controls.Add(Me.TbTelefono)
        Me.GbDatosGenerales.Controls.Add(Me.TbNombreChofer)
        Me.GbDatosGenerales.Controls.Add(Me.TbNoLicencia)
        Me.GbDatosGenerales.Controls.Add(Me.CbNoLote)
        Me.GbDatosGenerales.Controls.Add(Me.TbPlacaTractoCamion)
        Me.GbDatosGenerales.Controls.Add(Me.TbNoContenedor)
        Me.GbDatosGenerales.Controls.Add(Me.TbPlacaCaja)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdEmbarque)
        Me.GbDatosGenerales.Controls.Add(Me.Label14)
        Me.GbDatosGenerales.Controls.Add(Me.Label13)
        Me.GbDatosGenerales.Controls.Add(Me.Label12)
        Me.GbDatosGenerales.Controls.Add(Me.Label11)
        Me.GbDatosGenerales.Controls.Add(Me.Label9)
        Me.GbDatosGenerales.Controls.Add(Me.Label8)
        Me.GbDatosGenerales.Controls.Add(Me.Label7)
        Me.GbDatosGenerales.Controls.Add(Me.Label3)
        Me.GbDatosGenerales.Controls.Add(Me.Label2)
        Me.GbDatosGenerales.Controls.Add(Me.Label1)
        Me.GbDatosGenerales.Controls.Add(Me.TbNombreComprador)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdSalida)
        Me.GbDatosGenerales.Controls.Add(Me.TbNoPacas)
        Me.GbDatosGenerales.Controls.Add(Me.BtnBuscarEmbarque)
        Me.GbDatosGenerales.Controls.Add(Me.Label6)
        Me.GbDatosGenerales.Controls.Add(Me.Label5)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdComprador)
        Me.GbDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatosGenerales.Location = New System.Drawing.Point(0, 24)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(1483, 213)
        Me.GbDatosGenerales.TabIndex = 1
        Me.GbDatosGenerales.TabStop = False
        Me.GbDatosGenerales.Text = "Datos Generales"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(71, 65)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 13)
        Me.Label20.TabIndex = 83
        Me.Label20.Text = "Estatus"
        '
        'CbEstatus
        '
        Me.CbEstatus.Enabled = False
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(119, 62)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.CbEstatus.TabIndex = 82
        '
        'TbDestino
        '
        Me.TbDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbDestino.Location = New System.Drawing.Point(300, 97)
        Me.TbDestino.Name = "TbDestino"
        Me.TbDestino.Size = New System.Drawing.Size(390, 20)
        Me.TbDestino.TabIndex = 9
        '
        'TbNoFactura
        '
        Me.TbNoFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNoFactura.Location = New System.Drawing.Point(823, 97)
        Me.TbNoFactura.Name = "TbNoFactura"
        Me.TbNoFactura.Size = New System.Drawing.Size(115, 20)
        Me.TbNoFactura.TabIndex = 10
        '
        'DtFechaSalida
        '
        Me.DtFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaSalida.Location = New System.Drawing.Point(140, 29)
        Me.DtFechaSalida.Name = "DtFechaSalida"
        Me.DtFechaSalida.Size = New System.Drawing.Size(100, 20)
        Me.DtFechaSalida.TabIndex = 81
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
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(696, 100)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 13)
        Me.Label15.TabIndex = 76
        Me.Label15.Text = "No Factura"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(251, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Destino"
        '
        'TbObservaciones
        '
        Me.TbObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbObservaciones.Location = New System.Drawing.Point(120, 150)
        Me.TbObservaciones.Multiline = True
        Me.TbObservaciones.Name = "TbObservaciones"
        Me.TbObservaciones.Size = New System.Drawing.Size(397, 56)
        Me.TbObservaciones.TabIndex = 15
        '
        'TbTelefono
        '
        Me.TbTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbTelefono.Location = New System.Drawing.Point(590, 71)
        Me.TbTelefono.Name = "TbTelefono"
        Me.TbTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TbTelefono.TabIndex = 6
        '
        'TbNombreChofer
        '
        Me.TbNombreChofer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNombreChofer.Location = New System.Drawing.Point(120, 71)
        Me.TbNombreChofer.Name = "TbNombreChofer"
        Me.TbNombreChofer.Size = New System.Drawing.Size(397, 20)
        Me.TbNombreChofer.TabIndex = 5
        '
        'TbNoLicencia
        '
        Me.TbNoLicencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNoLicencia.Location = New System.Drawing.Point(120, 97)
        Me.TbNoLicencia.Name = "TbNoLicencia"
        Me.TbNoLicencia.Size = New System.Drawing.Size(121, 20)
        Me.TbNoLicencia.TabIndex = 8
        '
        'CbNoLote
        '
        Me.CbNoLote.FormattingEnabled = True
        Me.CbNoLote.Location = New System.Drawing.Point(120, 123)
        Me.CbNoLote.Name = "CbNoLote"
        Me.CbNoLote.Size = New System.Drawing.Size(138, 21)
        Me.CbNoLote.TabIndex = 11
        '
        'TbPlacaTractoCamion
        '
        Me.TbPlacaTractoCamion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbPlacaTractoCamion.Location = New System.Drawing.Point(823, 70)
        Me.TbPlacaTractoCamion.Name = "TbPlacaTractoCamion"
        Me.TbPlacaTractoCamion.Size = New System.Drawing.Size(115, 20)
        Me.TbPlacaTractoCamion.TabIndex = 7
        '
        'TbNoContenedor
        '
        Me.TbNoContenedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNoContenedor.Location = New System.Drawing.Point(523, 124)
        Me.TbNoContenedor.Name = "TbNoContenedor"
        Me.TbNoContenedor.Size = New System.Drawing.Size(100, 20)
        Me.TbNoContenedor.TabIndex = 13
        '
        'TbPlacaCaja
        '
        Me.TbPlacaCaja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbPlacaCaja.Location = New System.Drawing.Point(714, 123)
        Me.TbPlacaCaja.Name = "TbPlacaCaja"
        Me.TbPlacaCaja.Size = New System.Drawing.Size(100, 20)
        Me.TbPlacaCaja.TabIndex = 14
        '
        'TbIdEmbarque
        '
        Me.TbIdEmbarque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbIdEmbarque.Location = New System.Drawing.Point(120, 45)
        Me.TbIdEmbarque.Name = "TbIdEmbarque"
        Me.TbIdEmbarque.Size = New System.Drawing.Size(100, 20)
        Me.TbIdEmbarque.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 153)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 13)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "Observaciones"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(520, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "Telefono"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "Nombre Chofer"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "No Licencia"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(696, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 13)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Placa de Tracto Camion"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(629, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Placa de Caja"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(428, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "No Contenedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "No Lote"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "ID Embarque"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "ID Salida"
        Me.Label1.UseWaitCursor = True
        '
        'TbNombreComprador
        '
        Me.TbNombreComprador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNombreComprador.Enabled = False
        Me.TbNombreComprador.Location = New System.Drawing.Point(523, 44)
        Me.TbNombreComprador.Name = "TbNombreComprador"
        Me.TbNombreComprador.Size = New System.Drawing.Size(415, 20)
        Me.TbNombreComprador.TabIndex = 4
        '
        'TbIdSalida
        '
        Me.TbIdSalida.Enabled = False
        Me.TbIdSalida.Location = New System.Drawing.Point(120, 19)
        Me.TbIdSalida.Name = "TbIdSalida"
        Me.TbIdSalida.Size = New System.Drawing.Size(99, 20)
        Me.TbIdSalida.TabIndex = 0
        Me.TbIdSalida.UseWaitCursor = True
        '
        'TbNoPacas
        '
        Me.TbNoPacas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNoPacas.Enabled = False
        Me.TbNoPacas.Location = New System.Drawing.Point(327, 123)
        Me.TbNoPacas.Name = "TbNoPacas"
        Me.TbNoPacas.Size = New System.Drawing.Size(95, 20)
        Me.TbNoPacas.TabIndex = 12
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(264, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "No. Pacas"
        '
        'DtpFechaEntrada
        '
        Me.DtpFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaEntrada.Location = New System.Drawing.Point(140, 3)
        Me.DtpFechaEntrada.Name = "DtpFechaEntrada"
        Me.DtpFechaEntrada.Size = New System.Drawing.Size(100, 20)
        Me.DtpFechaEntrada.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(359, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Comprador"
        '
        'TbIdComprador
        '
        Me.TbIdComprador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbIdComprador.Enabled = False
        Me.TbIdComprador.Location = New System.Drawing.Point(442, 44)
        Me.TbIdComprador.Name = "TbIdComprador"
        Me.TbIdComprador.Size = New System.Drawing.Size(75, 20)
        Me.TbIdComprador.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(189, 180)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 33)
        Me.Label18.TabIndex = 79
        Me.Label18.Text = "Neto"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(189, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 33)
        Me.Label17.TabIndex = 78
        Me.Label17.Text = "Tara"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(189, 134)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 33)
        Me.Label16.TabIndex = 77
        Me.Label16.Text = "Bruto"
        '
        'GbPesos
        '
        Me.GbPesos.Controls.Add(Me.TbNeto)
        Me.GbPesos.Controls.Add(Me.TbBruto)
        Me.GbPesos.Controls.Add(Me.TbTara)
        Me.GbPesos.Controls.Add(Me.Label16)
        Me.GbPesos.Controls.Add(Me.Label17)
        Me.GbPesos.Controls.Add(Me.Label18)
        Me.GbPesos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbPesos.Location = New System.Drawing.Point(0, 237)
        Me.GbPesos.Name = "GbPesos"
        Me.GbPesos.Size = New System.Drawing.Size(844, 406)
        Me.GbPesos.TabIndex = 2
        Me.GbPesos.TabStop = False
        Me.GbPesos.Text = "Captura Peso"
        '
        'TbNeto
        '
        Me.TbNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNeto.Location = New System.Drawing.Point(300, 177)
        Me.TbNeto.Name = "TbNeto"
        Me.TbNeto.ReadOnly = True
        Me.TbNeto.Size = New System.Drawing.Size(181, 40)
        Me.TbNeto.TabIndex = 2
        Me.TbNeto.Text = "0"
        Me.TbNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbBruto
        '
        Me.TbBruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbBruto.Location = New System.Drawing.Point(300, 131)
        Me.TbBruto.Name = "TbBruto"
        Me.TbBruto.Size = New System.Drawing.Size(181, 40)
        Me.TbBruto.TabIndex = 1
        Me.TbBruto.Text = "0"
        Me.TbBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbTara
        '
        Me.TbTara.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTara.Location = New System.Drawing.Point(300, 85)
        Me.TbTara.Name = "TbTara"
        Me.TbTara.Size = New System.Drawing.Size(181, 40)
        Me.TbTara.TabIndex = 0
        Me.TbTara.Text = "0"
        Me.TbTara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GbPacas
        '
        Me.GbPacas.Controls.Add(Me.DgvPacas)
        Me.GbPacas.Dock = System.Windows.Forms.DockStyle.Right
        Me.GbPacas.Location = New System.Drawing.Point(844, 237)
        Me.GbPacas.Name = "GbPacas"
        Me.GbPacas.Size = New System.Drawing.Size(639, 406)
        Me.GbPacas.TabIndex = 80
        Me.GbPacas.TabStop = False
        Me.GbPacas.Text = "Pacas de lote"
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
        Me.DgvPacas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvPacas.Location = New System.Drawing.Point(3, 16)
        Me.DgvPacas.MultiSelect = False
        Me.DgvPacas.Name = "DgvPacas"
        Me.DgvPacas.RowHeadersVisible = False
        Me.DgvPacas.RowHeadersWidth = 40
        Me.DgvPacas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPacas.Size = New System.Drawing.Size(633, 387)
        Me.DgvPacas.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DtpFechaEntrada)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.CbEstatus)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.DtFechaSalida)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1233, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(247, 194)
        Me.Panel1.TabIndex = 84
        '
        'BtnBuscarEmbarque
        '
        Me.BtnBuscarEmbarque.BackgroundImage = CType(resources.GetObject("BtnBuscarEmbarque.BackgroundImage"), System.Drawing.Image)
        Me.BtnBuscarEmbarque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnBuscarEmbarque.Location = New System.Drawing.Point(226, 42)
        Me.BtnBuscarEmbarque.Name = "BtnBuscarEmbarque"
        Me.BtnBuscarEmbarque.Size = New System.Drawing.Size(32, 25)
        Me.BtnBuscarEmbarque.TabIndex = 2
        Me.BtnBuscarEmbarque.UseVisualStyleBackColor = True
        '
        'SalidaPacas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1483, 643)
        Me.Controls.Add(Me.GbPesos)
        Me.Controls.Add(Me.GbPacas)
        Me.Controls.Add(Me.GbDatosGenerales)
        Me.Controls.Add(Me.MSMenu)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "SalidaPacas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Salida de Pacas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        Me.GbPesos.ResumeLayout(False)
        Me.GbPesos.PerformLayout()
        Me.GbPacas.ResumeLayout(False)
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GbDatosGenerales As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TbIdSalida As TextBox
    Friend WithEvents BtnBuscarEmbarque As Button
    Friend WithEvents TbIdComprador As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbNoPacas As TextBox
    Friend WithEvents DtpFechaEntrada As DateTimePicker
    Friend WithEvents TbNombreComprador As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TbIdEmbarque As TextBox
    Friend WithEvents TbPlacaCaja As TextBox
    Friend WithEvents TbNoContenedor As TextBox
    Friend WithEvents TbPlacaTractoCamion As TextBox
    Friend WithEvents CbNoLote As ComboBox
    Friend WithEvents TbNoLicencia As TextBox
    Friend WithEvents TbNombreChofer As TextBox
    Friend WithEvents TbTelefono As TextBox
    Friend WithEvents TbObservaciones As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents DtFechaSalida As DateTimePicker
    Friend WithEvents TbDestino As TextBox
    Friend WithEvents TbNoFactura As TextBox
    Friend WithEvents GbPesos As GroupBox
    Friend WithEvents TbNeto As TextBox
    Friend WithEvents TbBruto As TextBox
    Friend WithEvents TbTara As TextBox
    Friend WithEvents GbPacas As GroupBox
    Friend WithEvents DgvPacas As DataGridView
    Friend WithEvents Label20 As Label
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents Panel1 As Panel
End Class
