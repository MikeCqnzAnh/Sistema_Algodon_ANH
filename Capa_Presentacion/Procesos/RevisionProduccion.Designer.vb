<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RevisionProduccion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RevisionProduccion))
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.GbFolioInicial = New System.Windows.Forms.GroupBox()
        Me.TbConsecutivoInicial = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.CbTipo = New System.Windows.Forms.ComboBox()
        Me.CbTipoProducto = New System.Windows.Forms.ComboBox()
        Me.CbOperador = New System.Windows.Forms.ComboBox()
        Me.CbTurno = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.RbActualizar = New System.Windows.Forms.RadioButton()
        Me.RbAgregar = New System.Windows.Forms.RadioButton()
        Me.BtEliminarPacas = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TbPacasProducidas = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TbIdProductor = New System.Windows.Forms.TextBox()
        Me.TbNombreProductor = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CbPlanta = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbIdProduccion = New System.Windows.Forms.TextBox()
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
        Me.GbTipoCaptura = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TbFolioCIA = New System.Windows.Forms.TextBox()
        Me.TbKilos = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GbModulos = New System.Windows.Forms.GroupBox()
        Me.TbTotalPacas = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TbTotalKilos = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TbTotalModulos = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TbModulos = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbPacasFaltantes = New System.Windows.Forms.GroupBox()
        Me.DgvPacasFaltantes = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TbContarFaltantes = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtConsultarFaltante = New System.Windows.Forms.Button()
        Me.TbFinFaltante = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TbInicioFaltante = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.GbPacasLigeras = New System.Windows.Forms.GroupBox()
        Me.DgvPacasLigeras = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TbContarLigeras = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtConsultarL = New System.Windows.Forms.Button()
        Me.NuPesoLigero = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.NuRegistrosLigero = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GbPacasPesadas = New System.Windows.Forms.GroupBox()
        Me.DgvPacasPesadas = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TbContarPesadas = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtConsultarP = New System.Windows.Forms.Button()
        Me.NuPesoPesado = New System.Windows.Forms.NumericUpDown()
        Me.NuRegistroPesado = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GbDetalle = New System.Windows.Forms.GroupBox()
        Me.Gbfondo = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvPacas = New System.Windows.Forms.DataGridView()
        Me.CkPaca = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GbCapturaAutomatica = New System.Windows.Forms.GroupBox()
        Me.GbLotes = New System.Windows.Forms.GroupBox()
        Me.BtFin = New System.Windows.Forms.Button()
        Me.BtInicio = New System.Windows.Forms.Button()
        Me.BtSiguiente = New System.Windows.Forms.Button()
        Me.BtAnterior = New System.Windows.Forms.Button()
        Me.BtAgregarExcel = New System.Windows.Forms.Button()
        Me.BtImprimir = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.GbDatos.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.GbFolioInicial.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GbTipoCaptura.SuspendLayout()
        Me.GbModulos.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GbPacasFaltantes.SuspendLayout()
        CType(Me.DgvPacasFaltantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GbPacasLigeras.SuspendLayout()
        CType(Me.DgvPacasLigeras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.NuPesoLigero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuRegistrosLigero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbPacasPesadas.SuspendLayout()
        CType(Me.DgvPacasPesadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.NuPesoPesado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuRegistroPesado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbDetalle.SuspendLayout()
        Me.Gbfondo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbCapturaAutomatica.SuspendLayout()
        Me.GbLotes.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.Panel7)
        Me.GbDatos.Controls.Add(Me.GbModulos)
        Me.GbDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatos.Location = New System.Drawing.Point(0, 24)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(1241, 294)
        Me.GbDatos.TabIndex = 0
        Me.GbDatos.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.GbFolioInicial)
        Me.Panel7.Controls.Add(Me.GroupBox3)
        Me.Panel7.Controls.Add(Me.GbTipoCaptura)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 16)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1235, 167)
        Me.Panel7.TabIndex = 23
        '
        'GbFolioInicial
        '
        Me.GbFolioInicial.Controls.Add(Me.TbConsecutivoInicial)
        Me.GbFolioInicial.Controls.Add(Me.Label32)
        Me.GbFolioInicial.Controls.Add(Me.Label27)
        Me.GbFolioInicial.Controls.Add(Me.CbTipo)
        Me.GbFolioInicial.Controls.Add(Me.CbTipoProducto)
        Me.GbFolioInicial.Controls.Add(Me.CbOperador)
        Me.GbFolioInicial.Controls.Add(Me.CbTurno)
        Me.GbFolioInicial.Controls.Add(Me.Label21)
        Me.GbFolioInicial.Controls.Add(Me.Label23)
        Me.GbFolioInicial.Controls.Add(Me.Label26)
        Me.GbFolioInicial.Controls.Add(Me.RbActualizar)
        Me.GbFolioInicial.Controls.Add(Me.RbAgregar)
        Me.GbFolioInicial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbFolioInicial.Enabled = False
        Me.GbFolioInicial.Location = New System.Drawing.Point(575, 0)
        Me.GbFolioInicial.Name = "GbFolioInicial"
        Me.GbFolioInicial.Size = New System.Drawing.Size(472, 167)
        Me.GbFolioInicial.TabIndex = 23
        Me.GbFolioInicial.TabStop = False
        '
        'TbConsecutivoInicial
        '
        Me.TbConsecutivoInicial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbConsecutivoInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TbConsecutivoInicial.Location = New System.Drawing.Point(290, 48)
        Me.TbConsecutivoInicial.MaxLength = 10
        Me.TbConsecutivoInicial.Name = "TbConsecutivoInicial"
        Me.TbConsecutivoInicial.Size = New System.Drawing.Size(175, 38)
        Me.TbConsecutivoInicial.TabIndex = 84
        '
        'Label32
        '
        Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label32.Location = New System.Drawing.Point(295, 11)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(158, 31)
        Me.Label32.TabIndex = 83
        Me.Label32.Text = "Folio Inicial:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 14)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(28, 13)
        Me.Label27.TabIndex = 82
        Me.Label27.Text = "Tipo"
        '
        'CbTipo
        '
        Me.CbTipo.Enabled = False
        Me.CbTipo.FormattingEnabled = True
        Me.CbTipo.Location = New System.Drawing.Point(63, 11)
        Me.CbTipo.Name = "CbTipo"
        Me.CbTipo.Size = New System.Drawing.Size(121, 21)
        Me.CbTipo.TabIndex = 81
        '
        'CbTipoProducto
        '
        Me.CbTipoProducto.FormattingEnabled = True
        Me.CbTipoProducto.Items.AddRange(New Object() {"PACA"})
        Me.CbTipoProducto.Location = New System.Drawing.Point(63, 65)
        Me.CbTipoProducto.Name = "CbTipoProducto"
        Me.CbTipoProducto.Size = New System.Drawing.Size(121, 21)
        Me.CbTipoProducto.TabIndex = 80
        '
        'CbOperador
        '
        Me.CbOperador.FormattingEnabled = True
        Me.CbOperador.Location = New System.Drawing.Point(63, 91)
        Me.CbOperador.Name = "CbOperador"
        Me.CbOperador.Size = New System.Drawing.Size(121, 21)
        Me.CbOperador.TabIndex = 79
        Me.CbOperador.Visible = False
        '
        'CbTurno
        '
        Me.CbTurno.FormattingEnabled = True
        Me.CbTurno.Location = New System.Drawing.Point(63, 38)
        Me.CbTurno.Name = "CbTurno"
        Me.CbTurno.Size = New System.Drawing.Size(121, 21)
        Me.CbTurno.TabIndex = 78
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 42)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(35, 13)
        Me.Label21.TabIndex = 75
        Me.Label21.Text = "Turno"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 68)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(28, 13)
        Me.Label23.TabIndex = 76
        Me.Label23.Text = "Tipo"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 94)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(51, 13)
        Me.Label26.TabIndex = 77
        Me.Label26.Text = "Operador"
        Me.Label26.Visible = False
        '
        'RbActualizar
        '
        Me.RbActualizar.AutoSize = True
        Me.RbActualizar.Location = New System.Drawing.Point(6, 141)
        Me.RbActualizar.Name = "RbActualizar"
        Me.RbActualizar.Size = New System.Drawing.Size(98, 17)
        Me.RbActualizar.TabIndex = 74
        Me.RbActualizar.TabStop = True
        Me.RbActualizar.Text = "Actualizar paca"
        Me.RbActualizar.UseVisualStyleBackColor = True
        '
        'RbAgregar
        '
        Me.RbAgregar.AutoSize = True
        Me.RbAgregar.Location = New System.Drawing.Point(6, 118)
        Me.RbAgregar.Name = "RbAgregar"
        Me.RbAgregar.Size = New System.Drawing.Size(94, 17)
        Me.RbAgregar.TabIndex = 73
        Me.RbAgregar.TabStop = True
        Me.RbAgregar.Text = "Agregar pacas"
        Me.RbAgregar.UseVisualStyleBackColor = True
        '
        'BtEliminarPacas
        '
        Me.BtEliminarPacas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtEliminarPacas.Location = New System.Drawing.Point(77, 172)
        Me.BtEliminarPacas.MaximumSize = New System.Drawing.Size(173, 23)
        Me.BtEliminarPacas.MinimumSize = New System.Drawing.Size(173, 23)
        Me.BtEliminarPacas.Name = "BtEliminarPacas"
        Me.BtEliminarPacas.Size = New System.Drawing.Size(173, 23)
        Me.BtEliminarPacas.TabIndex = 72
        Me.BtEliminarPacas.Text = "Eliminar Pacas Seleccionadas"
        Me.BtEliminarPacas.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.TbPacasProducidas)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.TbIdProductor)
        Me.GroupBox3.Controls.Add(Me.TbNombreProductor)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.CbPlanta)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TbIdProduccion)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TbPesoPesado)
        Me.GroupBox3.Controls.Add(Me.TbPesoLigero)
        Me.GroupBox3.Controls.Add(Me.TbPesoPromedio)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TbPacaPesada)
        Me.GroupBox3.Controls.Add(Me.TbPacaLigera)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TbIdOrdenTrabajo)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TbUltimaPaca)
        Me.GroupBox3.Controls.Add(Me.TbPrimerPaca)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(575, 167)
        Me.GroupBox3.TabIndex = 67
        Me.GroupBox3.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(28, 12)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 13)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Productor:"
        '
        'TbPacasProducidas
        '
        Me.TbPacasProducidas.Location = New System.Drawing.Point(350, 140)
        Me.TbPacasProducidas.Name = "TbPacasProducidas"
        Me.TbPacasProducidas.ReadOnly = True
        Me.TbPacasProducidas.Size = New System.Drawing.Size(100, 20)
        Me.TbPacasProducidas.TabIndex = 22
        Me.TbPacasProducidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(248, 143)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Pacas Producidas:"
        '
        'TbIdProductor
        '
        Me.TbIdProductor.Location = New System.Drawing.Point(112, 9)
        Me.TbIdProductor.Name = "TbIdProductor"
        Me.TbIdProductor.ReadOnly = True
        Me.TbIdProductor.Size = New System.Drawing.Size(100, 20)
        Me.TbIdProductor.TabIndex = 24
        '
        'TbNombreProductor
        '
        Me.TbNombreProductor.Location = New System.Drawing.Point(218, 9)
        Me.TbNombreProductor.Name = "TbNombreProductor"
        Me.TbNombreProductor.ReadOnly = True
        Me.TbNombreProductor.Size = New System.Drawing.Size(316, 20)
        Me.TbNombreProductor.TabIndex = 23
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(456, 116)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(25, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Kgs"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Planta:"
        '
        'CbPlanta
        '
        Me.CbPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPlanta.Enabled = False
        Me.CbPlanta.FormattingEnabled = True
        Me.CbPlanta.Location = New System.Drawing.Point(112, 61)
        Me.CbPlanta.Name = "CbPlanta"
        Me.CbPlanta.Size = New System.Drawing.Size(121, 21)
        Me.CbPlanta.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(248, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "ID Produccion:"
        '
        'TbIdProduccion
        '
        Me.TbIdProduccion.Location = New System.Drawing.Point(350, 35)
        Me.TbIdProduccion.Name = "TbIdProduccion"
        Me.TbIdProduccion.ReadOnly = True
        Me.TbIdProduccion.Size = New System.Drawing.Size(100, 20)
        Me.TbIdProduccion.TabIndex = 16
        Me.TbIdProduccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(540, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Kgs"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(540, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Kgs"
        '
        'TbPesoPesado
        '
        Me.TbPesoPesado.Location = New System.Drawing.Point(456, 87)
        Me.TbPesoPesado.MaxLength = 10
        Me.TbPesoPesado.Name = "TbPesoPesado"
        Me.TbPesoPesado.ReadOnly = True
        Me.TbPesoPesado.Size = New System.Drawing.Size(78, 20)
        Me.TbPesoPesado.TabIndex = 13
        Me.TbPesoPesado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbPesoLigero
        '
        Me.TbPesoLigero.Location = New System.Drawing.Point(456, 61)
        Me.TbPesoLigero.MaxLength = 10
        Me.TbPesoLigero.Name = "TbPesoLigero"
        Me.TbPesoLigero.ReadOnly = True
        Me.TbPesoLigero.Size = New System.Drawing.Size(78, 20)
        Me.TbPesoLigero.TabIndex = 12
        Me.TbPesoLigero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbPesoPromedio
        '
        Me.TbPesoPromedio.Location = New System.Drawing.Point(350, 113)
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
        Me.Label6.Location = New System.Drawing.Point(248, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Peso promedio:"
        '
        'TbPacaPesada
        '
        Me.TbPacaPesada.Location = New System.Drawing.Point(350, 87)
        Me.TbPacaPesada.MaxLength = 10
        Me.TbPacaPesada.Name = "TbPacaPesada"
        Me.TbPacaPesada.ReadOnly = True
        Me.TbPacaPesada.Size = New System.Drawing.Size(100, 20)
        Me.TbPacaPesada.TabIndex = 9
        Me.TbPacaPesada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbPacaLigera
        '
        Me.TbPacaLigera.Location = New System.Drawing.Point(350, 61)
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
        Me.Label5.Location = New System.Drawing.Point(248, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Paca mas pesada:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(248, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Paca mas ligera:"
        '
        'TbIdOrdenTrabajo
        '
        Me.TbIdOrdenTrabajo.Location = New System.Drawing.Point(112, 35)
        Me.TbIdOrdenTrabajo.MaxLength = 10
        Me.TbIdOrdenTrabajo.Name = "TbIdOrdenTrabajo"
        Me.TbIdOrdenTrabajo.ReadOnly = True
        Me.TbIdOrdenTrabajo.Size = New System.Drawing.Size(100, 20)
        Me.TbIdOrdenTrabajo.TabIndex = 5
        Me.TbIdOrdenTrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID Orden:"
        '
        'TbUltimaPaca
        '
        Me.TbUltimaPaca.Location = New System.Drawing.Point(112, 114)
        Me.TbUltimaPaca.MaxLength = 10
        Me.TbUltimaPaca.Name = "TbUltimaPaca"
        Me.TbUltimaPaca.ReadOnly = True
        Me.TbUltimaPaca.Size = New System.Drawing.Size(100, 20)
        Me.TbUltimaPaca.TabIndex = 3
        Me.TbUltimaPaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbPrimerPaca
        '
        Me.TbPrimerPaca.Location = New System.Drawing.Point(112, 88)
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
        Me.Label2.Location = New System.Drawing.Point(28, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ultima paca:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Primer paca:"
        '
        'GbTipoCaptura
        '
        Me.GbTipoCaptura.Controls.Add(Me.Label24)
        Me.GbTipoCaptura.Controls.Add(Me.TbFolioCIA)
        Me.GbTipoCaptura.Controls.Add(Me.TbKilos)
        Me.GbTipoCaptura.Controls.Add(Me.Label22)
        Me.GbTipoCaptura.Dock = System.Windows.Forms.DockStyle.Right
        Me.GbTipoCaptura.Location = New System.Drawing.Point(1047, 0)
        Me.GbTipoCaptura.Name = "GbTipoCaptura"
        Me.GbTipoCaptura.Size = New System.Drawing.Size(188, 167)
        Me.GbTipoCaptura.TabIndex = 66
        Me.GbTipoCaptura.TabStop = False
        Me.GbTipoCaptura.Text = "Captura Peso"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(6, 93)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 29)
        Me.Label24.TabIndex = 52
        Me.Label24.Text = "Kilos"
        '
        'TbFolioCIA
        '
        Me.TbFolioCIA.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TbFolioCIA.Location = New System.Drawing.Point(6, 48)
        Me.TbFolioCIA.MaxLength = 10
        Me.TbFolioCIA.Name = "TbFolioCIA"
        Me.TbFolioCIA.Size = New System.Drawing.Size(166, 38)
        Me.TbFolioCIA.TabIndex = 47
        '
        'TbKilos
        '
        Me.TbKilos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.TbKilos.Location = New System.Drawing.Point(6, 125)
        Me.TbKilos.MaxLength = 3
        Me.TbKilos.Name = "TbKilos"
        Me.TbKilos.Size = New System.Drawing.Size(166, 38)
        Me.TbKilos.TabIndex = 49
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 14)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(121, 29)
        Me.Label22.TabIndex = 50
        Me.Label22.Text = "Folio CIA"
        '
        'GbModulos
        '
        Me.GbModulos.Controls.Add(Me.TbTotalPacas)
        Me.GbModulos.Controls.Add(Me.Label29)
        Me.GbModulos.Controls.Add(Me.TbTotalKilos)
        Me.GbModulos.Controls.Add(Me.Label28)
        Me.GbModulos.Controls.Add(Me.TbTotalModulos)
        Me.GbModulos.Controls.Add(Me.Label25)
        Me.GbModulos.Controls.Add(Me.TbModulos)
        Me.GbModulos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GbModulos.Location = New System.Drawing.Point(3, 183)
        Me.GbModulos.Name = "GbModulos"
        Me.GbModulos.Size = New System.Drawing.Size(1235, 108)
        Me.GbModulos.TabIndex = 68
        Me.GbModulos.TabStop = False
        Me.GbModulos.Text = "Modulos"
        '
        'TbTotalPacas
        '
        Me.TbTotalPacas.Enabled = False
        Me.TbTotalPacas.Location = New System.Drawing.Point(282, 82)
        Me.TbTotalPacas.Name = "TbTotalPacas"
        Me.TbTotalPacas.Size = New System.Drawing.Size(100, 20)
        Me.TbTotalPacas.TabIndex = 59
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(198, 85)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(78, 13)
        Me.Label29.TabIndex = 60
        Me.Label29.Text = "Total de pacas"
        '
        'TbTotalKilos
        '
        Me.TbTotalKilos.Enabled = False
        Me.TbTotalKilos.Location = New System.Drawing.Point(472, 82)
        Me.TbTotalKilos.Name = "TbTotalKilos"
        Me.TbTotalKilos.Size = New System.Drawing.Size(100, 20)
        Me.TbTotalKilos.TabIndex = 57
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(388, 85)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(71, 13)
        Me.Label28.TabIndex = 58
        Me.Label28.Text = "Total de Kilos"
        '
        'TbTotalModulos
        '
        Me.TbTotalModulos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TbTotalModulos.Enabled = False
        Me.TbTotalModulos.Location = New System.Drawing.Point(92, 82)
        Me.TbTotalModulos.Name = "TbTotalModulos"
        Me.TbTotalModulos.Size = New System.Drawing.Size(100, 20)
        Me.TbTotalModulos.TabIndex = 56
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(-3, 85)
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
        Me.TbModulos.Size = New System.Drawing.Size(1229, 58)
        Me.TbModulos.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1241, 24)
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
        Me.GbPacasFaltantes.Controls.Add(Me.Panel3)
        Me.GbPacasFaltantes.Controls.Add(Me.Panel1)
        Me.GbPacasFaltantes.Dock = System.Windows.Forms.DockStyle.Left
        Me.GbPacasFaltantes.Location = New System.Drawing.Point(3, 16)
        Me.GbPacasFaltantes.Name = "GbPacasFaltantes"
        Me.GbPacasFaltantes.Size = New System.Drawing.Size(430, 217)
        Me.GbPacasFaltantes.TabIndex = 2
        Me.GbPacasFaltantes.TabStop = False
        Me.GbPacasFaltantes.Text = "Pacas faltantes"
        '
        'DgvPacasFaltantes
        '
        Me.DgvPacasFaltantes.AllowUserToAddRows = False
        Me.DgvPacasFaltantes.AllowUserToDeleteRows = False
        Me.DgvPacasFaltantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacasFaltantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvPacasFaltantes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvPacasFaltantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvPacasFaltantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacasFaltantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacasFaltantes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvPacasFaltantes.Location = New System.Drawing.Point(3, 48)
        Me.DgvPacasFaltantes.MultiSelect = False
        Me.DgvPacasFaltantes.Name = "DgvPacasFaltantes"
        Me.DgvPacasFaltantes.ReadOnly = True
        Me.DgvPacasFaltantes.RowHeadersVisible = False
        Me.DgvPacasFaltantes.RowHeadersWidth = 40
        Me.DgvPacasFaltantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPacasFaltantes.Size = New System.Drawing.Size(424, 134)
        Me.DgvPacasFaltantes.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.TbContarFaltantes)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(3, 182)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(424, 32)
        Me.Panel3.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 13)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Cantidad:"
        '
        'TbContarFaltantes
        '
        Me.TbContarFaltantes.Location = New System.Drawing.Point(64, 6)
        Me.TbContarFaltantes.Name = "TbContarFaltantes"
        Me.TbContarFaltantes.ReadOnly = True
        Me.TbContarFaltantes.Size = New System.Drawing.Size(81, 20)
        Me.TbContarFaltantes.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtConsultarFaltante)
        Me.Panel1.Controls.Add(Me.TbFinFaltante)
        Me.Panel1.Controls.Add(Me.Label31)
        Me.Panel1.Controls.Add(Me.TbInicioFaltante)
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 32)
        Me.Panel1.TabIndex = 1
        '
        'BtConsultarFaltante
        '
        Me.BtConsultarFaltante.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtConsultarFaltante.Location = New System.Drawing.Point(347, 4)
        Me.BtConsultarFaltante.Name = "BtConsultarFaltante"
        Me.BtConsultarFaltante.Size = New System.Drawing.Size(74, 23)
        Me.BtConsultarFaltante.TabIndex = 4
        Me.BtConsultarFaltante.Text = "Consultar"
        Me.BtConsultarFaltante.UseVisualStyleBackColor = True
        '
        'TbFinFaltante
        '
        Me.TbFinFaltante.Location = New System.Drawing.Point(164, 5)
        Me.TbFinFaltante.MaxLength = 10
        Me.TbFinFaltante.Name = "TbFinFaltante"
        Me.TbFinFaltante.Size = New System.Drawing.Size(68, 20)
        Me.TbFinFaltante.TabIndex = 3
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(134, 9)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(24, 13)
        Me.Label31.TabIndex = 2
        Me.Label31.Text = "Fin:"
        '
        'TbInicioFaltante
        '
        Me.TbInicioFaltante.Location = New System.Drawing.Point(47, 5)
        Me.TbInicioFaltante.MaxLength = 10
        Me.TbInicioFaltante.Name = "TbInicioFaltante"
        Me.TbInicioFaltante.Size = New System.Drawing.Size(68, 20)
        Me.TbInicioFaltante.TabIndex = 1
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(6, 9)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(35, 13)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Inicio:"
        '
        'GbPacasLigeras
        '
        Me.GbPacasLigeras.Controls.Add(Me.DgvPacasLigeras)
        Me.GbPacasLigeras.Controls.Add(Me.Panel5)
        Me.GbPacasLigeras.Controls.Add(Me.Panel2)
        Me.GbPacasLigeras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbPacasLigeras.Location = New System.Drawing.Point(433, 16)
        Me.GbPacasLigeras.Name = "GbPacasLigeras"
        Me.GbPacasLigeras.Size = New System.Drawing.Size(375, 217)
        Me.GbPacasLigeras.TabIndex = 3
        Me.GbPacasLigeras.TabStop = False
        Me.GbPacasLigeras.Text = "Pacas ligeras"
        '
        'DgvPacasLigeras
        '
        Me.DgvPacasLigeras.AllowUserToAddRows = False
        Me.DgvPacasLigeras.AllowUserToDeleteRows = False
        Me.DgvPacasLigeras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacasLigeras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvPacasLigeras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvPacasLigeras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvPacasLigeras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacasLigeras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacasLigeras.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvPacasLigeras.Location = New System.Drawing.Point(3, 48)
        Me.DgvPacasLigeras.MultiSelect = False
        Me.DgvPacasLigeras.Name = "DgvPacasLigeras"
        Me.DgvPacasLigeras.ReadOnly = True
        Me.DgvPacasLigeras.RowHeadersVisible = False
        Me.DgvPacasLigeras.RowHeadersWidth = 40
        Me.DgvPacasLigeras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPacasLigeras.Size = New System.Drawing.Size(369, 134)
        Me.DgvPacasLigeras.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.TbContarLigeras)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(3, 182)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(369, 32)
        Me.Panel5.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 13)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Cantidad:"
        '
        'TbContarLigeras
        '
        Me.TbContarLigeras.Location = New System.Drawing.Point(61, 6)
        Me.TbContarLigeras.Name = "TbContarLigeras"
        Me.TbContarLigeras.ReadOnly = True
        Me.TbContarLigeras.Size = New System.Drawing.Size(81, 20)
        Me.TbContarLigeras.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtConsultarL)
        Me.Panel2.Controls.Add(Me.NuPesoLigero)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.NuRegistrosLigero)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(369, 32)
        Me.Panel2.TabIndex = 1
        '
        'BtConsultarL
        '
        Me.BtConsultarL.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtConsultarL.Location = New System.Drawing.Point(291, 4)
        Me.BtConsultarL.Name = "BtConsultarL"
        Me.BtConsultarL.Size = New System.Drawing.Size(75, 23)
        Me.BtConsultarL.TabIndex = 4
        Me.BtConsultarL.Text = "Consultar"
        Me.BtConsultarL.UseVisualStyleBackColor = True
        '
        'NuPesoLigero
        '
        Me.NuPesoLigero.Location = New System.Drawing.Point(213, 5)
        Me.NuPesoLigero.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.NuPesoLigero.Name = "NuPesoLigero"
        Me.NuPesoLigero.Size = New System.Drawing.Size(64, 20)
        Me.NuPesoLigero.TabIndex = 3
        Me.NuPesoLigero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuPesoLigero.Value = New Decimal(New Integer() {180, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(132, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Peso menor a:"
        '
        'NuRegistrosLigero
        '
        Me.NuRegistrosLigero.Location = New System.Drawing.Point(68, 5)
        Me.NuRegistrosLigero.Name = "NuRegistrosLigero"
        Me.NuRegistrosLigero.Size = New System.Drawing.Size(49, 20)
        Me.NuRegistrosLigero.TabIndex = 1
        Me.NuRegistrosLigero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuRegistrosLigero.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(2, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "No. de reg:"
        '
        'GbPacasPesadas
        '
        Me.GbPacasPesadas.Controls.Add(Me.DgvPacasPesadas)
        Me.GbPacasPesadas.Controls.Add(Me.Panel6)
        Me.GbPacasPesadas.Controls.Add(Me.Panel4)
        Me.GbPacasPesadas.Dock = System.Windows.Forms.DockStyle.Right
        Me.GbPacasPesadas.Location = New System.Drawing.Point(808, 16)
        Me.GbPacasPesadas.Name = "GbPacasPesadas"
        Me.GbPacasPesadas.Size = New System.Drawing.Size(430, 217)
        Me.GbPacasPesadas.TabIndex = 4
        Me.GbPacasPesadas.TabStop = False
        Me.GbPacasPesadas.Text = "Pacas pesadas"
        '
        'DgvPacasPesadas
        '
        Me.DgvPacasPesadas.AllowUserToAddRows = False
        Me.DgvPacasPesadas.AllowUserToDeleteRows = False
        Me.DgvPacasPesadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacasPesadas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvPacasPesadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvPacasPesadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvPacasPesadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacasPesadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacasPesadas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvPacasPesadas.Location = New System.Drawing.Point(3, 48)
        Me.DgvPacasPesadas.MultiSelect = False
        Me.DgvPacasPesadas.Name = "DgvPacasPesadas"
        Me.DgvPacasPesadas.ReadOnly = True
        Me.DgvPacasPesadas.RowHeadersVisible = False
        Me.DgvPacasPesadas.RowHeadersWidth = 40
        Me.DgvPacasPesadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPacasPesadas.Size = New System.Drawing.Size(424, 134)
        Me.DgvPacasPesadas.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label19)
        Me.Panel6.Controls.Add(Me.TbContarPesadas)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(3, 182)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(424, 32)
        Me.Panel6.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 9)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 13)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Cantidad:"
        '
        'TbContarPesadas
        '
        Me.TbContarPesadas.Location = New System.Drawing.Point(61, 6)
        Me.TbContarPesadas.Name = "TbContarPesadas"
        Me.TbContarPesadas.ReadOnly = True
        Me.TbContarPesadas.Size = New System.Drawing.Size(81, 20)
        Me.TbContarPesadas.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BtConsultarP)
        Me.Panel4.Controls.Add(Me.NuPesoPesado)
        Me.Panel4.Controls.Add(Me.NuRegistroPesado)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 16)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(424, 32)
        Me.Panel4.TabIndex = 3
        '
        'BtConsultarP
        '
        Me.BtConsultarP.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtConsultarP.Location = New System.Drawing.Point(346, 4)
        Me.BtConsultarP.Name = "BtConsultarP"
        Me.BtConsultarP.Size = New System.Drawing.Size(75, 23)
        Me.BtConsultarP.TabIndex = 6
        Me.BtConsultarP.Text = "Consultar"
        Me.BtConsultarP.UseVisualStyleBackColor = True
        '
        'NuPesoPesado
        '
        Me.NuPesoPesado.Location = New System.Drawing.Point(215, 5)
        Me.NuPesoPesado.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.NuPesoPesado.Name = "NuPesoPesado"
        Me.NuPesoPesado.Size = New System.Drawing.Size(64, 20)
        Me.NuPesoPesado.TabIndex = 5
        Me.NuPesoPesado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuPesoPesado.Value = New Decimal(New Integer() {250, 0, 0, 0})
        '
        'NuRegistroPesado
        '
        Me.NuRegistroPesado.Location = New System.Drawing.Point(68, 5)
        Me.NuRegistroPesado.Name = "NuRegistroPesado"
        Me.NuRegistroPesado.Size = New System.Drawing.Size(49, 20)
        Me.NuRegistroPesado.TabIndex = 1
        Me.NuRegistroPesado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuRegistroPesado.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(135, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Peso mayor a:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "No. de reg:"
        '
        'GbDetalle
        '
        Me.GbDetalle.Controls.Add(Me.GbPacasLigeras)
        Me.GbDetalle.Controls.Add(Me.GbPacasPesadas)
        Me.GbDetalle.Controls.Add(Me.GbPacasFaltantes)
        Me.GbDetalle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GbDetalle.Location = New System.Drawing.Point(0, 557)
        Me.GbDetalle.Name = "GbDetalle"
        Me.GbDetalle.Size = New System.Drawing.Size(1241, 236)
        Me.GbDetalle.TabIndex = 5
        Me.GbDetalle.TabStop = False
        '
        'Gbfondo
        '
        Me.Gbfondo.Controls.Add(Me.GroupBox2)
        Me.Gbfondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gbfondo.Location = New System.Drawing.Point(0, 318)
        Me.Gbfondo.Name = "Gbfondo"
        Me.Gbfondo.Size = New System.Drawing.Size(1241, 239)
        Me.Gbfondo.TabIndex = 5
        Me.Gbfondo.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.GbCapturaAutomatica)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1235, 220)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvPacas)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(893, 201)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
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
        Me.DgvPacas.Location = New System.Drawing.Point(3, 16)
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
        Me.DgvPacas.Size = New System.Drawing.Size(887, 182)
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
        'GbCapturaAutomatica
        '
        Me.GbCapturaAutomatica.Controls.Add(Me.GbLotes)
        Me.GbCapturaAutomatica.Controls.Add(Me.BtAgregarExcel)
        Me.GbCapturaAutomatica.Controls.Add(Me.BtImprimir)
        Me.GbCapturaAutomatica.Controls.Add(Me.NumericUpDown1)
        Me.GbCapturaAutomatica.Controls.Add(Me.BtEliminarPacas)
        Me.GbCapturaAutomatica.Dock = System.Windows.Forms.DockStyle.Right
        Me.GbCapturaAutomatica.Location = New System.Drawing.Point(896, 16)
        Me.GbCapturaAutomatica.Name = "GbCapturaAutomatica"
        Me.GbCapturaAutomatica.Size = New System.Drawing.Size(336, 201)
        Me.GbCapturaAutomatica.TabIndex = 62
        Me.GbCapturaAutomatica.TabStop = False
        '
        'GbLotes
        '
        Me.GbLotes.Controls.Add(Me.BtFin)
        Me.GbLotes.Controls.Add(Me.BtInicio)
        Me.GbLotes.Controls.Add(Me.BtSiguiente)
        Me.GbLotes.Controls.Add(Me.BtAnterior)
        Me.GbLotes.Location = New System.Drawing.Point(7, 84)
        Me.GbLotes.Name = "GbLotes"
        Me.GbLotes.Size = New System.Drawing.Size(323, 83)
        Me.GbLotes.TabIndex = 63
        Me.GbLotes.TabStop = False
        Me.GbLotes.Text = "Lotes"
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
        'BtAgregarExcel
        '
        Me.BtAgregarExcel.Location = New System.Drawing.Point(7, 23)
        Me.BtAgregarExcel.Name = "BtAgregarExcel"
        Me.BtAgregarExcel.Size = New System.Drawing.Size(305, 29)
        Me.BtAgregarExcel.TabIndex = 58
        Me.BtAgregarExcel.Text = "Agregar Pacas desde Archivo de Excel"
        Me.BtAgregarExcel.UseVisualStyleBackColor = True
        '
        'BtImprimir
        '
        Me.BtImprimir.Location = New System.Drawing.Point(128, 55)
        Me.BtImprimir.Name = "BtImprimir"
        Me.BtImprimir.Size = New System.Drawing.Size(184, 23)
        Me.BtImprimir.TabIndex = 60
        Me.BtImprimir.Text = "Imprimir"
        Me.BtImprimir.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(7, 58)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 59
        '
        'RevisionProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 793)
        Me.Controls.Add(Me.Gbfondo)
        Me.Controls.Add(Me.GbDetalle)
        Me.Controls.Add(Me.GbDatos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RevisionProduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Revision de produccion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbDatos.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.GbFolioInicial.ResumeLayout(False)
        Me.GbFolioInicial.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GbTipoCaptura.ResumeLayout(False)
        Me.GbTipoCaptura.PerformLayout()
        Me.GbModulos.ResumeLayout(False)
        Me.GbModulos.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GbPacasFaltantes.ResumeLayout(False)
        CType(Me.DgvPacasFaltantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GbPacasLigeras.ResumeLayout(False)
        CType(Me.DgvPacasLigeras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NuPesoLigero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuRegistrosLigero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbPacasPesadas.ResumeLayout(False)
        CType(Me.DgvPacasPesadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.NuPesoPesado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuRegistroPesado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbDetalle.ResumeLayout(False)
        Me.Gbfondo.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbCapturaAutomatica.ResumeLayout(False)
        Me.GbLotes.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GbPacasLigeras As GroupBox
    Friend WithEvents GbPacasPesadas As GroupBox
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
    Friend WithEvents NuRegistrosLigero As NumericUpDown
    Friend WithEvents Panel4 As Panel
    Friend WithEvents NuRegistroPesado As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents NuPesoLigero As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents NuPesoPesado As NumericUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents BtConsultarL As Button
    Friend WithEvents BtConsultarP As Button
    Friend WithEvents TbPacasProducidas As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents DgvPacasFaltantes As DataGridView
    Friend WithEvents DgvPacasLigeras As DataGridView
    Friend WithEvents DgvPacasPesadas As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents TbContarFaltantes As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TbContarLigeras As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TbContarPesadas As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgvPacas As DataGridView
    Friend WithEvents CkPaca As DataGridViewCheckBoxColumn
    Friend WithEvents GbCapturaAutomatica As GroupBox
    Friend WithEvents GbLotes As GroupBox
    Friend WithEvents BtFin As Button
    Friend WithEvents BtInicio As Button
    Friend WithEvents BtSiguiente As Button
    Friend WithEvents BtAnterior As Button
    Friend WithEvents BtAgregarExcel As Button
    Friend WithEvents BtImprimir As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents GbTipoCaptura As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TbFolioCIA As TextBox
    Friend WithEvents TbKilos As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents GbModulos As GroupBox
    Friend WithEvents TbTotalModulos As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TbModulos As TextBox
    Friend WithEvents GbFolioInicial As GroupBox
    Friend WithEvents BtEliminarPacas As Button
    Friend WithEvents TbNombreProductor As TextBox
    Friend WithEvents TbIdProductor As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents RbActualizar As RadioButton
    Friend WithEvents RbAgregar As RadioButton
    Friend WithEvents CbOperador As ComboBox
    Friend WithEvents CbTurno As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents CbTipo As ComboBox
    Friend WithEvents TbTotalKilos As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents TbTotalPacas As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents CbTipoProducto As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TbFinFaltante As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents TbInicioFaltante As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents BtConsultarFaltante As Button
    Friend WithEvents TbConsecutivoInicial As TextBox
    Friend WithEvents Label32 As Label
End Class
