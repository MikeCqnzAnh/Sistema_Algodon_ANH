<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RevisionProduccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RevisionProduccion))
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbPesoPesado = New System.Windows.Forms.TextBox()
        Me.TbPesoLigero = New System.Windows.Forms.TextBox()
        Me.TbPesoPromedio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbPacaPesada = New System.Windows.Forms.TextBox()
        Me.TbPacaLigera = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbIdOrdenTrabajo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbUltimaPaca = New System.Windows.Forms.TextBox()
        Me.TbPrimerPaca = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbPacasFaltantes = New System.Windows.Forms.GroupBox()
        Me.DgvPacasFaltantes = New System.Windows.Forms.DataGridView()
        Me.GbPacasLigeras = New System.Windows.Forms.GroupBox()
        Me.DgvPacasLigeras = New System.Windows.Forms.DataGridView()
        Me.GbPacasPesadas = New System.Windows.Forms.GroupBox()
        Me.DgvPacasPesadas = New System.Windows.Forms.DataGridView()
        Me.GbDetalle = New System.Windows.Forms.GroupBox()
        Me.Gbfondo = New System.Windows.Forms.GroupBox()
        Me.TbIdProduccion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CbPlanta = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BtConsultarL = New System.Windows.Forms.Button()
        Me.BtConsultarP = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TbPacasProducidas = New System.Windows.Forms.TextBox()
        Me.GbDatos.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GbPacasFaltantes.SuspendLayout()
        CType(Me.DgvPacasFaltantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbPacasLigeras.SuspendLayout()
        CType(Me.DgvPacasLigeras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbPacasPesadas.SuspendLayout()
        CType(Me.DgvPacasPesadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbDetalle.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.TbPacasProducidas)
        Me.GbDatos.Controls.Add(Me.Label16)
        Me.GbDatos.Controls.Add(Me.Label15)
        Me.GbDatos.Controls.Add(Me.Label11)
        Me.GbDatos.Controls.Add(Me.CbPlanta)
        Me.GbDatos.Controls.Add(Me.Label9)
        Me.GbDatos.Controls.Add(Me.TbIdProduccion)
        Me.GbDatos.Controls.Add(Me.Label8)
        Me.GbDatos.Controls.Add(Me.Label7)
        Me.GbDatos.Controls.Add(Me.TbPesoPesado)
        Me.GbDatos.Controls.Add(Me.TbPesoLigero)
        Me.GbDatos.Controls.Add(Me.TbPesoPromedio)
        Me.GbDatos.Controls.Add(Me.Label6)
        Me.GbDatos.Controls.Add(Me.TbPacaPesada)
        Me.GbDatos.Controls.Add(Me.TbPacaLigera)
        Me.GbDatos.Controls.Add(Me.Label5)
        Me.GbDatos.Controls.Add(Me.Label4)
        Me.GbDatos.Controls.Add(Me.TbIdOrdenTrabajo)
        Me.GbDatos.Controls.Add(Me.Label3)
        Me.GbDatos.Controls.Add(Me.TbUltimaPaca)
        Me.GbDatos.Controls.Add(Me.TbPrimerPaca)
        Me.GbDatos.Controls.Add(Me.Label2)
        Me.GbDatos.Controls.Add(Me.Label1)
        Me.GbDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatos.Location = New System.Drawing.Point(0, 24)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(1300, 149)
        Me.GbDatos.TabIndex = 0
        Me.GbDatos.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(559, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Kgs"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(559, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Kgs"
        '
        'TbPesoPesado
        '
        Me.TbPesoPesado.Location = New System.Drawing.Point(475, 65)
        Me.TbPesoPesado.MaxLength = 10
        Me.TbPesoPesado.Name = "TbPesoPesado"
        Me.TbPesoPesado.ReadOnly = True
        Me.TbPesoPesado.Size = New System.Drawing.Size(78, 20)
        Me.TbPesoPesado.TabIndex = 13
        Me.TbPesoPesado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbPesoLigero
        '
        Me.TbPesoLigero.Location = New System.Drawing.Point(475, 39)
        Me.TbPesoLigero.MaxLength = 10
        Me.TbPesoLigero.Name = "TbPesoLigero"
        Me.TbPesoLigero.ReadOnly = True
        Me.TbPesoLigero.Size = New System.Drawing.Size(78, 20)
        Me.TbPesoLigero.TabIndex = 12
        Me.TbPesoLigero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbPesoPromedio
        '
        Me.TbPesoPromedio.Location = New System.Drawing.Point(369, 91)
        Me.TbPesoPromedio.MaxLength = 10
        Me.TbPesoPromedio.Name = "TbPesoPromedio"
        Me.TbPesoPromedio.ReadOnly = True
        Me.TbPesoPromedio.Size = New System.Drawing.Size(100, 20)
        Me.TbPesoPromedio.TabIndex = 11
        Me.TbPesoPromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(267, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Peso promedio:"
        '
        'TbPacaPesada
        '
        Me.TbPacaPesada.Location = New System.Drawing.Point(369, 65)
        Me.TbPacaPesada.MaxLength = 10
        Me.TbPacaPesada.Name = "TbPacaPesada"
        Me.TbPacaPesada.ReadOnly = True
        Me.TbPacaPesada.Size = New System.Drawing.Size(100, 20)
        Me.TbPacaPesada.TabIndex = 9
        Me.TbPacaPesada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbPacaLigera
        '
        Me.TbPacaLigera.Location = New System.Drawing.Point(369, 39)
        Me.TbPacaLigera.MaxLength = 10
        Me.TbPacaLigera.Name = "TbPacaLigera"
        Me.TbPacaLigera.ReadOnly = True
        Me.TbPacaLigera.Size = New System.Drawing.Size(100, 20)
        Me.TbPacaLigera.TabIndex = 8
        Me.TbPacaLigera.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(267, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Paca mas pesada:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(267, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Paca mas ligera:"
        '
        'TbIdOrdenTrabajo
        '
        Me.TbIdOrdenTrabajo.Location = New System.Drawing.Point(127, 13)
        Me.TbIdOrdenTrabajo.MaxLength = 10
        Me.TbIdOrdenTrabajo.Name = "TbIdOrdenTrabajo"
        Me.TbIdOrdenTrabajo.Size = New System.Drawing.Size(100, 20)
        Me.TbIdOrdenTrabajo.TabIndex = 5
        Me.TbIdOrdenTrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID Orden:"
        '
        'TbUltimaPaca
        '
        Me.TbUltimaPaca.Location = New System.Drawing.Point(127, 118)
        Me.TbUltimaPaca.MaxLength = 10
        Me.TbUltimaPaca.Name = "TbUltimaPaca"
        Me.TbUltimaPaca.ReadOnly = True
        Me.TbUltimaPaca.Size = New System.Drawing.Size(100, 20)
        Me.TbUltimaPaca.TabIndex = 3
        Me.TbUltimaPaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbPrimerPaca
        '
        Me.TbPrimerPaca.Location = New System.Drawing.Point(127, 92)
        Me.TbPrimerPaca.MaxLength = 10
        Me.TbPrimerPaca.Name = "TbPrimerPaca"
        Me.TbPrimerPaca.ReadOnly = True
        Me.TbPrimerPaca.Size = New System.Drawing.Size(100, 20)
        Me.TbPrimerPaca.TabIndex = 2
        Me.TbPrimerPaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ultima paca:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Primer paca:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1300, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'GbPacasFaltantes
        '
        Me.GbPacasFaltantes.Controls.Add(Me.DgvPacasFaltantes)
        Me.GbPacasFaltantes.Controls.Add(Me.Panel1)
        Me.GbPacasFaltantes.Dock = System.Windows.Forms.DockStyle.Left
        Me.GbPacasFaltantes.Location = New System.Drawing.Point(3, 16)
        Me.GbPacasFaltantes.Name = "GbPacasFaltantes"
        Me.GbPacasFaltantes.Size = New System.Drawing.Size(430, 328)
        Me.GbPacasFaltantes.TabIndex = 2
        Me.GbPacasFaltantes.TabStop = False
        Me.GbPacasFaltantes.Text = "Pacas faltantes"
        '
        'DgvPacasFaltantes
        '
        Me.DgvPacasFaltantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacasFaltantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacasFaltantes.Location = New System.Drawing.Point(3, 48)
        Me.DgvPacasFaltantes.Name = "DgvPacasFaltantes"
        Me.DgvPacasFaltantes.Size = New System.Drawing.Size(424, 277)
        Me.DgvPacasFaltantes.TabIndex = 0
        '
        'GbPacasLigeras
        '
        Me.GbPacasLigeras.Controls.Add(Me.DgvPacasLigeras)
        Me.GbPacasLigeras.Controls.Add(Me.Panel2)
        Me.GbPacasLigeras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbPacasLigeras.Location = New System.Drawing.Point(433, 16)
        Me.GbPacasLigeras.Name = "GbPacasLigeras"
        Me.GbPacasLigeras.Size = New System.Drawing.Size(434, 328)
        Me.GbPacasLigeras.TabIndex = 3
        Me.GbPacasLigeras.TabStop = False
        Me.GbPacasLigeras.Text = "Pacas ligeras"
        '
        'DgvPacasLigeras
        '
        Me.DgvPacasLigeras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacasLigeras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacasLigeras.Location = New System.Drawing.Point(3, 48)
        Me.DgvPacasLigeras.Name = "DgvPacasLigeras"
        Me.DgvPacasLigeras.Size = New System.Drawing.Size(428, 277)
        Me.DgvPacasLigeras.TabIndex = 0
        '
        'GbPacasPesadas
        '
        Me.GbPacasPesadas.Controls.Add(Me.DgvPacasPesadas)
        Me.GbPacasPesadas.Controls.Add(Me.Panel4)
        Me.GbPacasPesadas.Dock = System.Windows.Forms.DockStyle.Right
        Me.GbPacasPesadas.Location = New System.Drawing.Point(867, 16)
        Me.GbPacasPesadas.Name = "GbPacasPesadas"
        Me.GbPacasPesadas.Size = New System.Drawing.Size(430, 328)
        Me.GbPacasPesadas.TabIndex = 4
        Me.GbPacasPesadas.TabStop = False
        Me.GbPacasPesadas.Text = "Pacas pesadas"
        '
        'DgvPacasPesadas
        '
        Me.DgvPacasPesadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacasPesadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacasPesadas.Location = New System.Drawing.Point(3, 48)
        Me.DgvPacasPesadas.Name = "DgvPacasPesadas"
        Me.DgvPacasPesadas.Size = New System.Drawing.Size(424, 277)
        Me.DgvPacasPesadas.TabIndex = 0
        '
        'GbDetalle
        '
        Me.GbDetalle.Controls.Add(Me.GbPacasLigeras)
        Me.GbDetalle.Controls.Add(Me.GbPacasPesadas)
        Me.GbDetalle.Controls.Add(Me.GbPacasFaltantes)
        Me.GbDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbDetalle.Location = New System.Drawing.Point(0, 173)
        Me.GbDetalle.Name = "GbDetalle"
        Me.GbDetalle.Size = New System.Drawing.Size(1300, 347)
        Me.GbDetalle.TabIndex = 5
        Me.GbDetalle.TabStop = False
        '
        'Gbfondo
        '
        Me.Gbfondo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Gbfondo.Location = New System.Drawing.Point(0, 520)
        Me.Gbfondo.Name = "Gbfondo"
        Me.Gbfondo.Size = New System.Drawing.Size(1300, 224)
        Me.Gbfondo.TabIndex = 5
        Me.Gbfondo.TabStop = False
        '
        'TbIdProduccion
        '
        Me.TbIdProduccion.Location = New System.Drawing.Point(127, 39)
        Me.TbIdProduccion.Name = "TbIdProduccion"
        Me.TbIdProduccion.Size = New System.Drawing.Size(100, 20)
        Me.TbIdProduccion.TabIndex = 16
        Me.TbIdProduccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "ID Produccion:"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 32)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtConsultarL)
        Me.Panel2.Controls.Add(Me.NumericUpDown3)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.NumericUpDown1)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(428, 32)
        Me.Panel2.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(2, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "No. de reg:"
        '
        'CbPlanta
        '
        Me.CbPlanta.FormattingEnabled = True
        Me.CbPlanta.Location = New System.Drawing.Point(127, 65)
        Me.CbPlanta.Name = "CbPlanta"
        Me.CbPlanta.Size = New System.Drawing.Size(121, 21)
        Me.CbPlanta.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Planta:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(68, 4)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDown1.TabIndex = 1
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown1.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BtConsultarP)
        Me.Panel4.Controls.Add(Me.NumericUpDown4)
        Me.Panel4.Controls.Add(Me.NumericUpDown2)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 16)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(424, 32)
        Me.Panel4.TabIndex = 3
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(68, 4)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(49, 20)
        Me.NumericUpDown2.TabIndex = 1
        Me.NumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown2.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "No. de reg:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(132, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Peso menor a:"
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(213, 4)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(64, 20)
        Me.NumericUpDown3.TabIndex = 3
        Me.NumericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown3.Value = New Decimal(New Integer() {180, 0, 0, 0})
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Location = New System.Drawing.Point(215, 4)
        Me.NumericUpDown4.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(64, 20)
        Me.NumericUpDown4.TabIndex = 5
        Me.NumericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumericUpDown4.Value = New Decimal(New Integer() {250, 0, 0, 0})
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(135, 6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Peso mayor a:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(475, 94)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(25, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Kgs"
        '
        'BtConsultarL
        '
        Me.BtConsultarL.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtConsultarL.Location = New System.Drawing.Point(350, 4)
        Me.BtConsultarL.Name = "BtConsultarL"
        Me.BtConsultarL.Size = New System.Drawing.Size(75, 23)
        Me.BtConsultarL.TabIndex = 4
        Me.BtConsultarL.Text = "Consultar"
        Me.BtConsultarL.UseVisualStyleBackColor = True
        '
        'BtConsultarP
        '
        Me.BtConsultarP.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtConsultarP.Location = New System.Drawing.Point(346, 3)
        Me.BtConsultarP.Name = "BtConsultarP"
        Me.BtConsultarP.Size = New System.Drawing.Size(75, 23)
        Me.BtConsultarP.TabIndex = 6
        Me.BtConsultarP.Text = "Consultar"
        Me.BtConsultarP.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(267, 121)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Pacas Producidas:"
        '
        'TbPacasProducidas
        '
        Me.TbPacasProducidas.Location = New System.Drawing.Point(369, 118)
        Me.TbPacasProducidas.Name = "TbPacasProducidas"
        Me.TbPacasProducidas.ReadOnly = True
        Me.TbPacasProducidas.Size = New System.Drawing.Size(100, 20)
        Me.TbPacasProducidas.TabIndex = 22
        Me.TbPacasProducidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RevisionProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 744)
        Me.Controls.Add(Me.GbDetalle)
        Me.Controls.Add(Me.GbDatos)
        Me.Controls.Add(Me.Gbfondo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RevisionProduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Revision de produccion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GbPacasFaltantes.ResumeLayout(False)
        CType(Me.DgvPacasFaltantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbPacasLigeras.ResumeLayout(False)
        CType(Me.DgvPacasLigeras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbPacasPesadas.ResumeLayout(False)
        CType(Me.DgvPacasPesadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbDetalle.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TbPesoPromedio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbPacaPesada As TextBox
    Friend WithEvents TbPacaLigera As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TbIdOrdenTrabajo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbUltimaPaca As TextBox
    Friend WithEvents TbPrimerPaca As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GbPacasFaltantes As GroupBox
    Friend WithEvents DgvPacasFaltantes As DataGridView
    Friend WithEvents GbPacasLigeras As GroupBox
    Friend WithEvents DgvPacasLigeras As DataGridView
    Friend WithEvents GbPacasPesadas As GroupBox
    Friend WithEvents DgvPacasPesadas As DataGridView
    Friend WithEvents TbPesoPesado As TextBox
    Friend WithEvents TbPesoLigero As TextBox
    Friend WithEvents GbDetalle As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Gbfondo As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TbIdProduccion As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents CbPlanta As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Panel4 As Panel
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents BtConsultarL As Button
    Friend WithEvents BtConsultarP As Button
    Friend WithEvents TbPacasProducidas As TextBox
    Friend WithEvents Label16 As Label
End Class
