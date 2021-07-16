<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdenEmbarquePorPacas
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
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmbarqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbEncabezado = New System.Windows.Forms.GroupBox()
        Me.BtnBuscarProd = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbNoPacas = New System.Windows.Forms.TextBox()
        Me.TbObservaciones = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DgvLotes = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtQuitar = New System.Windows.Forms.Button()
        Me.BtAgregar = New System.Windows.Forms.Button()
        Me.TbCantidadPacas = New System.Windows.Forms.TextBox()
        Me.TbNoLote = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.TbIdComprador = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbIdEmbarque = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DgvPaqueteDisponible = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DgvPacasDisponibles = New System.Windows.Forms.DataGridView()
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbPacasMarcadas = New System.Windows.Forms.TextBox()
        Me.TbPacasDisponibles = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbCantidadPacasCombo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbLotes = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtExcel = New System.Windows.Forms.Button()
        Me.BtDevuelvePacas = New System.Windows.Forms.Button()
        Me.BtEnviaPacas = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DgvPaquete = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DgvPacas = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TbPacasMarcadasLotes = New System.Windows.Forms.TextBox()
        Me.TbPacasLoteadas = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MSMenu.SuspendLayout()
        Me.GbEncabezado.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DgvPaqueteDisponible, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DgvPacasDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbDatos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DgvPaquete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(1370, 24)
        Me.MSMenu.TabIndex = 1
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
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmbarqueToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'EmbarqueToolStripMenuItem
        '
        Me.EmbarqueToolStripMenuItem.Name = "EmbarqueToolStripMenuItem"
        Me.EmbarqueToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.EmbarqueToolStripMenuItem.Text = "Embarque"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GbEncabezado
        '
        Me.GbEncabezado.Controls.Add(Me.BtnBuscarProd)
        Me.GbEncabezado.Controls.Add(Me.Label6)
        Me.GbEncabezado.Controls.Add(Me.TbNoPacas)
        Me.GbEncabezado.Controls.Add(Me.TbObservaciones)
        Me.GbEncabezado.Controls.Add(Me.Label21)
        Me.GbEncabezado.Controls.Add(Me.DtpFecha)
        Me.GbEncabezado.Controls.Add(Me.Panel1)
        Me.GbEncabezado.Controls.Add(Me.TbNombre)
        Me.GbEncabezado.Controls.Add(Me.TbIdComprador)
        Me.GbEncabezado.Controls.Add(Me.Label2)
        Me.GbEncabezado.Controls.Add(Me.Label1)
        Me.GbEncabezado.Controls.Add(Me.TbIdEmbarque)
        Me.GbEncabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbEncabezado.Location = New System.Drawing.Point(0, 24)
        Me.GbEncabezado.Name = "GbEncabezado"
        Me.GbEncabezado.Size = New System.Drawing.Size(1370, 159)
        Me.GbEncabezado.TabIndex = 2
        Me.GbEncabezado.TabStop = False
        '
        'BtnBuscarProd
        '
        Me.BtnBuscarProd.Location = New System.Drawing.Point(538, 39)
        Me.BtnBuscarProd.Name = "BtnBuscarProd"
        Me.BtnBuscarProd.Size = New System.Drawing.Size(41, 23)
        Me.BtnBuscarProd.TabIndex = 49
        Me.BtnBuscarProd.Text = "..."
        Me.BtnBuscarProd.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "No. Pacas"
        '
        'TbNoPacas
        '
        Me.TbNoPacas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNoPacas.Enabled = False
        Me.TbNoPacas.Location = New System.Drawing.Point(95, 122)
        Me.TbNoPacas.Name = "TbNoPacas"
        Me.TbNoPacas.Size = New System.Drawing.Size(63, 20)
        Me.TbNoPacas.TabIndex = 47
        '
        'TbObservaciones
        '
        Me.TbObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbObservaciones.Location = New System.Drawing.Point(95, 68)
        Me.TbObservaciones.Multiline = True
        Me.TbObservaciones.Name = "TbObservaciones"
        Me.TbObservaciones.Size = New System.Drawing.Size(484, 48)
        Me.TbObservaciones.TabIndex = 32
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(12, 71)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(78, 13)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "Observaciones"
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(461, 122)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(118, 20)
        Me.DtpFecha.TabIndex = 30
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DgvLotes)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.BtQuitar)
        Me.Panel1.Controls.Add(Me.BtAgregar)
        Me.Panel1.Controls.Add(Me.TbCantidadPacas)
        Me.Panel1.Controls.Add(Me.TbNoLote)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(585, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(782, 140)
        Me.Panel1.TabIndex = 5
        '
        'DgvLotes
        '
        Me.DgvLotes.AllowUserToAddRows = False
        Me.DgvLotes.AllowUserToDeleteRows = False
        Me.DgvLotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvLotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvLotes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvLotes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLotes.Dock = System.Windows.Forms.DockStyle.Right
        Me.DgvLotes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvLotes.Location = New System.Drawing.Point(191, 0)
        Me.DgvLotes.MultiSelect = False
        Me.DgvLotes.Name = "DgvLotes"
        Me.DgvLotes.RowHeadersVisible = False
        Me.DgvLotes.RowHeadersWidth = 40
        Me.DgvLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvLotes.Size = New System.Drawing.Size(591, 140)
        Me.DgvLotes.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Pacas por lote"
        '
        'BtQuitar
        '
        Me.BtQuitar.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.quit
        Me.BtQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtQuitar.Location = New System.Drawing.Point(155, 36)
        Me.BtQuitar.Name = "BtQuitar"
        Me.BtQuitar.Size = New System.Drawing.Size(30, 30)
        Me.BtQuitar.TabIndex = 5
        Me.BtQuitar.UseVisualStyleBackColor = True
        '
        'BtAgregar
        '
        Me.BtAgregar.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.add
        Me.BtAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtAgregar.Location = New System.Drawing.Point(155, 0)
        Me.BtAgregar.Name = "BtAgregar"
        Me.BtAgregar.Size = New System.Drawing.Size(30, 30)
        Me.BtAgregar.TabIndex = 3
        Me.BtAgregar.UseVisualStyleBackColor = True
        '
        'TbCantidadPacas
        '
        Me.TbCantidadPacas.Location = New System.Drawing.Point(85, 42)
        Me.TbCantidadPacas.Name = "TbCantidadPacas"
        Me.TbCantidadPacas.Size = New System.Drawing.Size(64, 20)
        Me.TbCantidadPacas.TabIndex = 1
        '
        'TbNoLote
        '
        Me.TbNoLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNoLote.Location = New System.Drawing.Point(49, 6)
        Me.TbNoLote.MaxLength = 15
        Me.TbNoLote.Name = "TbNoLote"
        Me.TbNoLote.Size = New System.Drawing.Size(100, 20)
        Me.TbNoLote.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "No lote"
        '
        'TbNombre
        '
        Me.TbNombre.Enabled = False
        Me.TbNombre.Location = New System.Drawing.Point(164, 42)
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(368, 20)
        Me.TbNombre.TabIndex = 4
        '
        'TbIdComprador
        '
        Me.TbIdComprador.Enabled = False
        Me.TbIdComprador.Location = New System.Drawing.Point(95, 42)
        Me.TbIdComprador.Name = "TbIdComprador"
        Me.TbIdComprador.Size = New System.Drawing.Size(63, 20)
        Me.TbIdComprador.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Comprador"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Embarque"
        '
        'TbIdEmbarque
        '
        Me.TbIdEmbarque.Enabled = False
        Me.TbIdEmbarque.Location = New System.Drawing.Point(95, 16)
        Me.TbIdEmbarque.Name = "TbIdEmbarque"
        Me.TbIdEmbarque.Size = New System.Drawing.Size(63, 20)
        Me.TbIdEmbarque.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TabControl2)
        Me.Panel2.Controls.Add(Me.GbDatos)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 183)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1370, 386)
        Me.Panel2.TabIndex = 3
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(0, 56)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(641, 278)
        Me.TabControl2.TabIndex = 3
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DgvPaqueteDisponible)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(633, 252)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Paquetes"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DgvPaqueteDisponible
        '
        Me.DgvPaqueteDisponible.AllowUserToAddRows = False
        Me.DgvPaqueteDisponible.AllowUserToDeleteRows = False
        Me.DgvPaqueteDisponible.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPaqueteDisponible.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvPaqueteDisponible.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvPaqueteDisponible.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvPaqueteDisponible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPaqueteDisponible.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPaqueteDisponible.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvPaqueteDisponible.Location = New System.Drawing.Point(3, 3)
        Me.DgvPaqueteDisponible.MultiSelect = False
        Me.DgvPaqueteDisponible.Name = "DgvPaqueteDisponible"
        Me.DgvPaqueteDisponible.RowHeadersVisible = False
        Me.DgvPaqueteDisponible.RowHeadersWidth = 40
        Me.DgvPaqueteDisponible.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPaqueteDisponible.Size = New System.Drawing.Size(627, 246)
        Me.DgvPaqueteDisponible.TabIndex = 18
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DgvPacasDisponibles)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(633, 252)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Pacas Disponibles"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DgvPacasDisponibles
        '
        Me.DgvPacasDisponibles.AllowUserToAddRows = False
        Me.DgvPacasDisponibles.AllowUserToDeleteRows = False
        Me.DgvPacasDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacasDisponibles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvPacasDisponibles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvPacasDisponibles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvPacasDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacasDisponibles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacasDisponibles.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvPacasDisponibles.Location = New System.Drawing.Point(3, 3)
        Me.DgvPacasDisponibles.MultiSelect = False
        Me.DgvPacasDisponibles.Name = "DgvPacasDisponibles"
        Me.DgvPacasDisponibles.RowHeadersVisible = False
        Me.DgvPacasDisponibles.RowHeadersWidth = 40
        Me.DgvPacasDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPacasDisponibles.Size = New System.Drawing.Size(627, 246)
        Me.DgvPacasDisponibles.TabIndex = 18
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.Label9)
        Me.GbDatos.Controls.Add(Me.TbPacasMarcadas)
        Me.GbDatos.Controls.Add(Me.TbPacasDisponibles)
        Me.GbDatos.Controls.Add(Me.Label8)
        Me.GbDatos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GbDatos.Location = New System.Drawing.Point(0, 334)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(641, 52)
        Me.GbDatos.TabIndex = 19
        Me.GbDatos.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(244, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Pacas Marcadas"
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Pacas Disponibles"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TbCantidadPacasCombo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CbLotes)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(641, 56)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(202, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Cant."
        '
        'TbCantidadPacasCombo
        '
        Me.TbCantidadPacasCombo.Enabled = False
        Me.TbCantidadPacasCombo.Location = New System.Drawing.Point(240, 19)
        Me.TbCantidadPacasCombo.MaxLength = 5
        Me.TbCantidadPacasCombo.Name = "TbCantidadPacasCombo"
        Me.TbCantidadPacasCombo.Size = New System.Drawing.Size(50, 20)
        Me.TbCantidadPacasCombo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Lotes"
        '
        'CbLotes
        '
        Me.CbLotes.FormattingEnabled = True
        Me.CbLotes.Location = New System.Drawing.Point(95, 18)
        Me.CbLotes.Name = "CbLotes"
        Me.CbLotes.Size = New System.Drawing.Size(100, 21)
        Me.CbLotes.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.BtExcel)
        Me.Panel5.Controls.Add(Me.BtDevuelvePacas)
        Me.Panel5.Controls.Add(Me.BtEnviaPacas)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(641, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(38, 386)
        Me.Panel5.TabIndex = 1
        '
        'BtExcel
        '
        Me.BtExcel.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.excel
        Me.BtExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtExcel.Location = New System.Drawing.Point(4, 150)
        Me.BtExcel.Name = "BtExcel"
        Me.BtExcel.Size = New System.Drawing.Size(30, 30)
        Me.BtExcel.TabIndex = 19
        Me.BtExcel.Text = "..."
        Me.BtExcel.UseVisualStyleBackColor = True
        '
        'BtDevuelvePacas
        '
        Me.BtDevuelvePacas.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.back_button
        Me.BtDevuelvePacas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtDevuelvePacas.Location = New System.Drawing.Point(4, 114)
        Me.BtDevuelvePacas.Name = "BtDevuelvePacas"
        Me.BtDevuelvePacas.Size = New System.Drawing.Size(30, 30)
        Me.BtDevuelvePacas.TabIndex = 1
        Me.BtDevuelvePacas.UseVisualStyleBackColor = True
        '
        'BtEnviaPacas
        '
        Me.BtEnviaPacas.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.play_button
        Me.BtEnviaPacas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtEnviaPacas.Location = New System.Drawing.Point(4, 78)
        Me.BtEnviaPacas.Name = "BtEnviaPacas"
        Me.BtEnviaPacas.Size = New System.Drawing.Size(30, 30)
        Me.BtEnviaPacas.TabIndex = 0
        Me.BtEnviaPacas.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.TabControl1)
        Me.Panel4.Controls.Add(Me.GroupBox3)
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(679, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(691, 386)
        Me.Panel4.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 56)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(691, 278)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DgvPaquete)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(683, 252)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lote"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DgvPaquete
        '
        Me.DgvPaquete.AllowUserToAddRows = False
        Me.DgvPaquete.AllowUserToDeleteRows = False
        Me.DgvPaquete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPaquete.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvPaquete.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvPaquete.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvPaquete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPaquete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPaquete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvPaquete.Location = New System.Drawing.Point(3, 3)
        Me.DgvPaquete.MultiSelect = False
        Me.DgvPaquete.Name = "DgvPaquete"
        Me.DgvPaquete.RowHeadersVisible = False
        Me.DgvPaquete.RowHeadersWidth = 40
        Me.DgvPaquete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPaquete.Size = New System.Drawing.Size(677, 246)
        Me.DgvPaquete.TabIndex = 18
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DgvPacas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(683, 252)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pacas"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        Me.DgvPacas.Location = New System.Drawing.Point(3, 3)
        Me.DgvPacas.MultiSelect = False
        Me.DgvPacas.Name = "DgvPacas"
        Me.DgvPacas.RowHeadersVisible = False
        Me.DgvPacas.RowHeadersWidth = 40
        Me.DgvPacas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPacas.Size = New System.Drawing.Size(677, 246)
        Me.DgvPacas.TabIndex = 18
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TbPacasMarcadasLotes)
        Me.GroupBox3.Controls.Add(Me.TbPacasLoteadas)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(0, 334)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(691, 52)
        Me.GroupBox3.TabIndex = 19
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(215, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Pacas Marcadas"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Total de Pacas"
        '
        'GroupBox2
        '
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(691, 56)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'OrdenEmbarquePorPacas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 569)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GbEncabezado)
        Me.Controls.Add(Me.MSMenu)
        Me.MinimumSize = New System.Drawing.Size(1287, 608)
        Me.Name = "OrdenEmbarquePorPacas"
        Me.Text = "Orden de Embarques de Pacas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GbEncabezado.ResumeLayout(False)
        Me.GbEncabezado.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DgvPaqueteDisponible, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DgvPacasDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DgvPaquete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmbarqueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GbEncabezado As GroupBox
    Friend WithEvents TbNombre As TextBox
    Friend WithEvents TbIdComprador As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TbIdEmbarque As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents TbObservaciones As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TbNoPacas As TextBox
    Friend WithEvents BtnBuscarProd As Button
    Friend WithEvents BtAgregar As Button
    Friend WithEvents TbNoLote As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtQuitar As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtEnviaPacas As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtDevuelvePacas As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CbLotes As ComboBox
    Friend WithEvents TbCantidadPacas As TextBox
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DgvPaqueteDisponible As DataGridView
    Friend WithEvents DgvPacasDisponibles As DataGridView
    Friend WithEvents DgvPaquete As DataGridView
    Friend WithEvents DgvPacas As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvLotes As DataGridView
    Friend WithEvents TbCantidadPacasCombo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TbPacasMarcadas As TextBox
    Friend WithEvents TbPacasDisponibles As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TbPacasMarcadasLotes As TextBox
    Friend WithEvents TbPacasLoteadas As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BtExcel As Button
End Class
