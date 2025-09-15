<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clasificacion_para_Venta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.mnustrip = New System.Windows.Forms.MenuStrip()
        Me.nuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.guardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.consultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.reportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.calculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.hviToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.plantillasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.excelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.accessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.eliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Paneltop = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbestatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nuNoPacas = New System.Windows.Forms.NumericUpDown()
        Me.btconsultaclientes = New Bunifu.Framework.UI.BunifuImageButton()
        Me.DtFechaActualizacion = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbIdVentaPaca = New System.Windows.Forms.TextBox()
        Me.TbIdProductor = New System.Windows.Forms.TextBox()
        Me.CbPlanta = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtFechaVenta = New System.Windows.Forms.DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbNombreProductor = New System.Windows.Forms.TextBox()
        Me.panel6 = New System.Windows.Forms.Panel()
        Me.btenviaseleccion = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btfiltroreiniciar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btfiltros = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btdesmarcarpacas = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btmarcarpacas = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tbcantidadsel1 = New System.Windows.Forms.TextBox()
        Me.dataGridViewOrigen = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbpaquete = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CbClases = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mnustrip.SuspendLayout()
        Me.Paneltop.SuspendLayout()
        CType(Me.nuNoPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btconsultaclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel6.SuspendLayout()
        CType(Me.btenviaseleccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btfiltroreiniciar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btfiltros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btdesmarcarpacas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btmarcarpacas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridViewOrigen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnustrip
        '
        Me.mnustrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.mnustrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nuevoToolStripMenuItem, Me.guardarToolStripMenuItem, Me.cancelarToolStripMenuItem, Me.consultarToolStripMenuItem, Me.reportesToolStripMenuItem, Me.plantillasToolStripMenuItem, Me.eliminarToolStripMenuItem})
        Me.mnustrip.Location = New System.Drawing.Point(0, 0)
        Me.mnustrip.Name = "mnustrip"
        Me.mnustrip.Size = New System.Drawing.Size(1450, 24)
        Me.mnustrip.TabIndex = 75
        Me.mnustrip.Text = "menuStrip1"
        '
        'nuevoToolStripMenuItem
        '
        Me.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem"
        Me.nuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.nuevoToolStripMenuItem.Text = "Nuevo"
        '
        'guardarToolStripMenuItem
        '
        Me.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem"
        Me.guardarToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.guardarToolStripMenuItem.Text = "Guardar"
        '
        'cancelarToolStripMenuItem
        '
        Me.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem"
        Me.cancelarToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.cancelarToolStripMenuItem.Text = "Cancelar"
        '
        'consultarToolStripMenuItem
        '
        Me.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem"
        Me.consultarToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.consultarToolStripMenuItem.Text = "Consultar"
        '
        'reportesToolStripMenuItem
        '
        Me.reportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.calculoToolStripMenuItem, Me.hviToolStripMenuItem})
        Me.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem"
        Me.reportesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.reportesToolStripMenuItem.Text = "Reportes"
        '
        'calculoToolStripMenuItem
        '
        Me.calculoToolStripMenuItem.Name = "calculoToolStripMenuItem"
        Me.calculoToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.calculoToolStripMenuItem.Text = "Calculo"
        '
        'hviToolStripMenuItem
        '
        Me.hviToolStripMenuItem.Name = "hviToolStripMenuItem"
        Me.hviToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.hviToolStripMenuItem.Text = "Hvi"
        Me.hviToolStripMenuItem.Visible = False
        '
        'plantillasToolStripMenuItem
        '
        Me.plantillasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.excelToolStripMenuItem, Me.accessToolStripMenuItem})
        Me.plantillasToolStripMenuItem.Name = "plantillasToolStripMenuItem"
        Me.plantillasToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.plantillasToolStripMenuItem.Text = "Plantillas"
        Me.plantillasToolStripMenuItem.Visible = False
        '
        'excelToolStripMenuItem
        '
        Me.excelToolStripMenuItem.Name = "excelToolStripMenuItem"
        Me.excelToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.excelToolStripMenuItem.Text = "Excel"
        '
        'accessToolStripMenuItem
        '
        Me.accessToolStripMenuItem.Name = "accessToolStripMenuItem"
        Me.accessToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.accessToolStripMenuItem.Text = "Access"
        Me.accessToolStripMenuItem.Visible = False
        '
        'eliminarToolStripMenuItem
        '
        Me.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem"
        Me.eliminarToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.eliminarToolStripMenuItem.Text = "Eliminar "
        Me.eliminarToolStripMenuItem.Visible = False
        '
        'Paneltop
        '
        Me.Paneltop.Controls.Add(Me.CbClases)
        Me.Paneltop.Controls.Add(Me.Label3)
        Me.Paneltop.Controls.Add(Me.Label13)
        Me.Paneltop.Controls.Add(Me.TextBox1)
        Me.Paneltop.Controls.Add(Me.tbpaquete)
        Me.Paneltop.Controls.Add(Me.Label8)
        Me.Paneltop.Controls.Add(Me.Label1)
        Me.Paneltop.Controls.Add(Me.TbNombreProductor)
        Me.Paneltop.Controls.Add(Me.Label5)
        Me.Paneltop.Controls.Add(Me.Label4)
        Me.Paneltop.Controls.Add(Me.Label25)
        Me.Paneltop.Controls.Add(Me.DtFechaVenta)
        Me.Paneltop.Controls.Add(Me.Label7)
        Me.Paneltop.Controls.Add(Me.cbestatus)
        Me.Paneltop.Controls.Add(Me.Label2)
        Me.Paneltop.Controls.Add(Me.nuNoPacas)
        Me.Paneltop.Controls.Add(Me.CbPlanta)
        Me.Paneltop.Controls.Add(Me.TbIdProductor)
        Me.Paneltop.Controls.Add(Me.TbIdVentaPaca)
        Me.Paneltop.Controls.Add(Me.btconsultaclientes)
        Me.Paneltop.Controls.Add(Me.Label6)
        Me.Paneltop.Controls.Add(Me.DtFechaActualizacion)
        Me.Paneltop.Dock = System.Windows.Forms.DockStyle.Top
        Me.Paneltop.Location = New System.Drawing.Point(0, 24)
        Me.Paneltop.Name = "Paneltop"
        Me.Paneltop.Size = New System.Drawing.Size(1450, 227)
        Me.Paneltop.TabIndex = 76
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(516, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 153
        Me.Label7.Text = "Estatus"
        '
        'cbestatus
        '
        Me.cbestatus.Enabled = False
        Me.cbestatus.FormattingEnabled = True
        Me.cbestatus.Location = New System.Drawing.Point(628, 137)
        Me.cbestatus.Name = "cbestatus"
        Me.cbestatus.Size = New System.Drawing.Size(121, 21)
        Me.cbestatus.TabIndex = 152
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "ID "
        '
        'nuNoPacas
        '
        Me.nuNoPacas.Enabled = False
        Me.nuNoPacas.Location = New System.Drawing.Point(607, 93)
        Me.nuNoPacas.Maximum = New Decimal(New Integer() {-1530494977, 232830, 0, 0})
        Me.nuNoPacas.Name = "nuNoPacas"
        Me.nuNoPacas.Size = New System.Drawing.Size(96, 20)
        Me.nuNoPacas.TabIndex = 130
        Me.nuNoPacas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nuNoPacas.ThousandsSeparator = True
        '
        'btconsultaclientes
        '
        Me.btconsultaclientes.BackColor = System.Drawing.Color.Transparent
        Me.btconsultaclientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btconsultaclientes.Image = Global.Capa_Presentacion.My.Resources.Resources.ICONO_CALCULA_COTTON_31_32px
        Me.btconsultaclientes.ImageActive = Nothing
        Me.btconsultaclientes.Location = New System.Drawing.Point(918, 6)
        Me.btconsultaclientes.Name = "btconsultaclientes"
        Me.btconsultaclientes.Size = New System.Drawing.Size(25, 25)
        Me.btconsultaclientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btconsultaclientes.TabIndex = 125
        Me.btconsultaclientes.TabStop = False
        Me.btconsultaclientes.Zoom = 15
        '
        'DtFechaActualizacion
        '
        Me.DtFechaActualizacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtFechaActualizacion.Enabled = False
        Me.DtFechaActualizacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaActualizacion.Location = New System.Drawing.Point(1342, 37)
        Me.DtFechaActualizacion.Name = "DtFechaActualizacion"
        Me.DtFechaActualizacion.Size = New System.Drawing.Size(96, 20)
        Me.DtFechaActualizacion.TabIndex = 79
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(507, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "No. Pacas"
        '
        'TbIdVentaPaca
        '
        Me.TbIdVentaPaca.Enabled = False
        Me.TbIdVentaPaca.Location = New System.Drawing.Point(65, 11)
        Me.TbIdVentaPaca.Name = "TbIdVentaPaca"
        Me.TbIdVentaPaca.Size = New System.Drawing.Size(75, 20)
        Me.TbIdVentaPaca.TabIndex = 60
        Me.TbIdVentaPaca.UseWaitCursor = True
        '
        'TbIdProductor
        '
        Me.TbIdProductor.Enabled = False
        Me.TbIdProductor.Location = New System.Drawing.Point(461, 11)
        Me.TbIdProductor.Name = "TbIdProductor"
        Me.TbIdProductor.Size = New System.Drawing.Size(75, 20)
        Me.TbIdProductor.TabIndex = 61
        '
        'CbPlanta
        '
        Me.CbPlanta.FormattingEnabled = True
        Me.CbPlanta.Location = New System.Drawing.Point(211, 10)
        Me.CbPlanta.Name = "CbPlanta"
        Me.CbPlanta.Size = New System.Drawing.Size(117, 21)
        Me.CbPlanta.TabIndex = 63
        Me.CbPlanta.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Planta"
        Me.Label2.Visible = False
        '
        'DtFechaVenta
        '
        Me.DtFechaVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DtFechaVenta.Enabled = False
        Me.DtFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaVenta.Location = New System.Drawing.Point(1342, 11)
        Me.DtFechaVenta.Name = "DtFechaVenta"
        Me.DtFechaVenta.Size = New System.Drawing.Size(96, 20)
        Me.DtFechaVenta.TabIndex = 65
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(1242, 41)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(70, 13)
        Me.Label25.TabIndex = 67
        Me.Label25.Text = "Actualizacion"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1240, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Fecha de creacion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(349, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Comprador"
        '
        'TbNombreProductor
        '
        Me.TbNombreProductor.Enabled = False
        Me.TbNombreProductor.Location = New System.Drawing.Point(542, 11)
        Me.TbNombreProductor.Name = "TbNombreProductor"
        Me.TbNombreProductor.Size = New System.Drawing.Size(367, 20)
        Me.TbNombreProductor.TabIndex = 72
        '
        'panel6
        '
        Me.panel6.BackColor = System.Drawing.SystemColors.Control
        Me.panel6.Controls.Add(Me.btenviaseleccion)
        Me.panel6.Controls.Add(Me.btfiltroreiniciar)
        Me.panel6.Controls.Add(Me.btfiltros)
        Me.panel6.Controls.Add(Me.btdesmarcarpacas)
        Me.panel6.Controls.Add(Me.btmarcarpacas)
        Me.panel6.Controls.Add(Me.tbcantidadsel1)
        Me.panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel6.Location = New System.Drawing.Point(1399, 251)
        Me.panel6.Name = "panel6"
        Me.panel6.Size = New System.Drawing.Size(51, 505)
        Me.panel6.TabIndex = 108
        '
        'btenviaseleccion
        '
        Me.btenviaseleccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btenviaseleccion.BackColor = System.Drawing.Color.Transparent
        Me.btenviaseleccion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btenviaseleccion.Image = Global.Capa_Presentacion.My.Resources.Resources.ICONO_CALCULA_COTTON_36
        Me.btenviaseleccion.ImageActive = Nothing
        Me.btenviaseleccion.Location = New System.Drawing.Point(12, 3)
        Me.btenviaseleccion.Name = "btenviaseleccion"
        Me.btenviaseleccion.Size = New System.Drawing.Size(30, 30)
        Me.btenviaseleccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btenviaseleccion.TabIndex = 124
        Me.btenviaseleccion.TabStop = False
        Me.btenviaseleccion.Zoom = 15
        '
        'btfiltroreiniciar
        '
        Me.btfiltroreiniciar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btfiltroreiniciar.BackColor = System.Drawing.Color.Transparent
        Me.btfiltroreiniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btfiltroreiniciar.Image = Global.Capa_Presentacion.My.Resources.Resources.ICONO_CALCULA_COTTON_351
        Me.btfiltroreiniciar.ImageActive = Nothing
        Me.btfiltroreiniciar.Location = New System.Drawing.Point(12, 102)
        Me.btfiltroreiniciar.Name = "btfiltroreiniciar"
        Me.btfiltroreiniciar.Size = New System.Drawing.Size(30, 30)
        Me.btfiltroreiniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btfiltroreiniciar.TabIndex = 123
        Me.btfiltroreiniciar.TabStop = False
        Me.btfiltroreiniciar.Zoom = 15
        '
        'btfiltros
        '
        Me.btfiltros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btfiltros.BackColor = System.Drawing.Color.Transparent
        Me.btfiltros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btfiltros.Image = Global.Capa_Presentacion.My.Resources.Resources.ICONO_CALCULA_COTTON_341
        Me.btfiltros.ImageActive = Nothing
        Me.btfiltros.Location = New System.Drawing.Point(12, 55)
        Me.btfiltros.Name = "btfiltros"
        Me.btfiltros.Size = New System.Drawing.Size(30, 30)
        Me.btfiltros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btfiltros.TabIndex = 122
        Me.btfiltros.TabStop = False
        Me.btfiltros.Zoom = 15
        '
        'btdesmarcarpacas
        '
        Me.btdesmarcarpacas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btdesmarcarpacas.BackColor = System.Drawing.Color.Transparent
        Me.btdesmarcarpacas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btdesmarcarpacas.Image = Global.Capa_Presentacion.My.Resources.Resources.ICONO_CALCULA_COTTON_24
        Me.btdesmarcarpacas.ImageActive = Nothing
        Me.btdesmarcarpacas.Location = New System.Drawing.Point(12, 228)
        Me.btdesmarcarpacas.Name = "btdesmarcarpacas"
        Me.btdesmarcarpacas.Size = New System.Drawing.Size(30, 30)
        Me.btdesmarcarpacas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btdesmarcarpacas.TabIndex = 121
        Me.btdesmarcarpacas.TabStop = False
        Me.btdesmarcarpacas.Zoom = 15
        '
        'btmarcarpacas
        '
        Me.btmarcarpacas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btmarcarpacas.BackColor = System.Drawing.Color.Transparent
        Me.btmarcarpacas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btmarcarpacas.Image = Global.Capa_Presentacion.My.Resources.Resources.ICONO_CALCULA_COTTON_23
        Me.btmarcarpacas.ImageActive = Nothing
        Me.btmarcarpacas.Location = New System.Drawing.Point(12, 166)
        Me.btmarcarpacas.Name = "btmarcarpacas"
        Me.btmarcarpacas.Size = New System.Drawing.Size(30, 30)
        Me.btmarcarpacas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btmarcarpacas.TabIndex = 120
        Me.btmarcarpacas.TabStop = False
        Me.btmarcarpacas.Zoom = 15
        '
        'tbcantidadsel1
        '
        Me.tbcantidadsel1.Location = New System.Drawing.Point(6, 202)
        Me.tbcantidadsel1.MaxLength = 5
        Me.tbcantidadsel1.Name = "tbcantidadsel1"
        Me.tbcantidadsel1.Size = New System.Drawing.Size(40, 20)
        Me.tbcantidadsel1.TabIndex = 119
        '
        'dataGridViewOrigen
        '
        Me.dataGridViewOrigen.AllowUserToAddRows = False
        Me.dataGridViewOrigen.AllowUserToDeleteRows = False
        Me.dataGridViewOrigen.AllowUserToOrderColumns = True
        Me.dataGridViewOrigen.AllowUserToResizeRows = False
        Me.dataGridViewOrigen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dataGridViewOrigen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dataGridViewOrigen.BackgroundColor = System.Drawing.Color.White
        Me.dataGridViewOrigen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridViewOrigen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewOrigen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridViewOrigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewOrigen.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridViewOrigen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridViewOrigen.Location = New System.Drawing.Point(0, 251)
        Me.dataGridViewOrigen.MultiSelect = False
        Me.dataGridViewOrigen.Name = "dataGridViewOrigen"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewOrigen.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataGridViewOrigen.RowHeadersVisible = False
        Me.dataGridViewOrigen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridViewOrigen.Size = New System.Drawing.Size(1399, 505)
        Me.dataGridViewOrigen.TabIndex = 109
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 37)
        Me.Label8.TabIndex = 162
        Me.Label8.Text = "Paquete"
        '
        'tbpaquete
        '
        Me.tbpaquete.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpaquete.Location = New System.Drawing.Point(160, 92)
        Me.tbpaquete.MaxLength = 10
        Me.tbpaquete.Name = "tbpaquete"
        Me.tbpaquete.Size = New System.Drawing.Size(197, 44)
        Me.tbpaquete.TabIndex = 163
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(160, 142)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(197, 44)
        Me.TextBox1.TabIndex = 164
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 145)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 37)
        Me.Label13.TabIndex = 165
        Me.Label13.Text = "BaleID"
        '
        'CbClases
        '
        Me.CbClases.FormattingEnabled = True
        Me.CbClases.Location = New System.Drawing.Point(689, 43)
        Me.CbClases.Name = "CbClases"
        Me.CbClases.Size = New System.Drawing.Size(121, 21)
        Me.CbClases.TabIndex = 166
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(625, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 167
        Me.Label3.Text = "Clase"
        '
        'Clasificacion_para_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1450, 756)
        Me.Controls.Add(Me.dataGridViewOrigen)
        Me.Controls.Add(Me.panel6)
        Me.Controls.Add(Me.Paneltop)
        Me.Controls.Add(Me.mnustrip)
        Me.Name = "Clasificacion_para_Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Clasificacion Para Venta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnustrip.ResumeLayout(False)
        Me.mnustrip.PerformLayout()
        Me.Paneltop.ResumeLayout(False)
        Me.Paneltop.PerformLayout()
        CType(Me.nuNoPacas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btconsultaclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel6.ResumeLayout(False)
        Me.panel6.PerformLayout()
        CType(Me.btenviaseleccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btfiltroreiniciar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btfiltros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btdesmarcarpacas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btmarcarpacas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridViewOrigen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents mnustrip As MenuStrip
    Private WithEvents nuevoToolStripMenuItem As ToolStripMenuItem
    Private WithEvents guardarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents cancelarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents consultarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents reportesToolStripMenuItem As ToolStripMenuItem
    Private WithEvents calculoToolStripMenuItem As ToolStripMenuItem
    Private WithEvents hviToolStripMenuItem As ToolStripMenuItem
    Private WithEvents plantillasToolStripMenuItem As ToolStripMenuItem
    Private WithEvents excelToolStripMenuItem As ToolStripMenuItem
    Private WithEvents accessToolStripMenuItem As ToolStripMenuItem
    Private WithEvents eliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Paneltop As Panel
    Private WithEvents Label7 As Label
    Private WithEvents cbestatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nuNoPacas As NumericUpDown
    Private WithEvents btconsultaclientes As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents DtFechaActualizacion As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents TbIdVentaPaca As TextBox
    Friend WithEvents TbIdProductor As TextBox
    Friend WithEvents CbPlanta As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DtFechaVenta As DateTimePicker
    Friend WithEvents Label25 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TbNombreProductor As TextBox
    Private WithEvents panel6 As Panel
    Private WithEvents btenviaseleccion As Bunifu.Framework.UI.BunifuImageButton
    Private WithEvents btfiltroreiniciar As Bunifu.Framework.UI.BunifuImageButton
    Private WithEvents btfiltros As Bunifu.Framework.UI.BunifuImageButton
    Private WithEvents btdesmarcarpacas As Bunifu.Framework.UI.BunifuImageButton
    Private WithEvents btmarcarpacas As Bunifu.Framework.UI.BunifuImageButton
    Private WithEvents tbcantidadsel1 As TextBox
    Private WithEvents dataGridViewOrigen As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents tbpaquete As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CbClases As ComboBox
    Friend WithEvents Label3 As Label
End Class
