<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConfiguracionParametros
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
        Me.PanelParametrosBascula = New System.Windows.Forms.Panel()
        Me.GbPesoPacas = New System.Windows.Forms.GroupBox()
        Me.NuInicialPacas = New System.Windows.Forms.NumericUpDown()
        Me.NuCaracterPacas = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GbPesoProduccion = New System.Windows.Forms.GroupBox()
        Me.NuCaracterBoletaNeto = New System.Windows.Forms.NumericUpDown()
        Me.NuInicialBoletaNeto = New System.Windows.Forms.NumericUpDown()
        Me.NuInicialBoletaBruto = New System.Windows.Forms.NumericUpDown()
        Me.NuCaracterBoletaBruto = New System.Windows.Forms.NumericUpDown()
        Me.NuInicialBoletaTara = New System.Windows.Forms.NumericUpDown()
        Me.NuCaracterBoletaTara = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GbIdProduccion = New System.Windows.Forms.GroupBox()
        Me.NuCaracterTransporte = New System.Windows.Forms.NumericUpDown()
        Me.NuInicialTransporte = New System.Windows.Forms.NumericUpDown()
        Me.NuCaracterModulo = New System.Windows.Forms.NumericUpDown()
        Me.NuInicialModulo = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GbPuerto = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbPuertosSeriales = New System.Windows.Forms.ComboBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsNombrePc = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsSeparador = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsIpComputadora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsIdConfiguracion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TbGross = New System.Windows.Forms.TextBox()
        Me.PanelParametrosBascula.SuspendLayout()
        Me.GbPesoPacas.SuspendLayout()
        CType(Me.NuInicialPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuCaracterPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbPesoProduccion.SuspendLayout()
        CType(Me.NuCaracterBoletaNeto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuInicialBoletaNeto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuInicialBoletaBruto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuCaracterBoletaBruto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuInicialBoletaTara, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuCaracterBoletaTara, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbIdProduccion.SuspendLayout()
        CType(Me.NuCaracterTransporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuInicialTransporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuCaracterModulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuInicialModulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbPuerto.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelParametrosBascula
        '
        Me.PanelParametrosBascula.Controls.Add(Me.GbPesoPacas)
        Me.PanelParametrosBascula.Controls.Add(Me.GbPesoProduccion)
        Me.PanelParametrosBascula.Controls.Add(Me.GbIdProduccion)
        Me.PanelParametrosBascula.Controls.Add(Me.GbPuerto)
        Me.PanelParametrosBascula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelParametrosBascula.Location = New System.Drawing.Point(0, 24)
        Me.PanelParametrosBascula.Name = "PanelParametrosBascula"
        Me.PanelParametrosBascula.Size = New System.Drawing.Size(1028, 577)
        Me.PanelParametrosBascula.TabIndex = 2
        '
        'GbPesoPacas
        '
        Me.GbPesoPacas.Controls.Add(Me.NuInicialPacas)
        Me.GbPesoPacas.Controls.Add(Me.NuCaracterPacas)
        Me.GbPesoPacas.Controls.Add(Me.Label13)
        Me.GbPesoPacas.Controls.Add(Me.Label12)
        Me.GbPesoPacas.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbPesoPacas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbPesoPacas.Location = New System.Drawing.Point(0, 400)
        Me.GbPesoPacas.Name = "GbPesoPacas"
        Me.GbPesoPacas.Size = New System.Drawing.Size(1028, 174)
        Me.GbPesoPacas.TabIndex = 11
        Me.GbPesoPacas.TabStop = False
        Me.GbPesoPacas.Text = "Peso De Pacas"
        '
        'NuInicialPacas
        '
        Me.NuInicialPacas.Location = New System.Drawing.Point(133, 41)
        Me.NuInicialPacas.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NuInicialPacas.Name = "NuInicialPacas"
        Me.NuInicialPacas.Size = New System.Drawing.Size(62, 20)
        Me.NuInicialPacas.TabIndex = 5
        Me.NuInicialPacas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NuCaracterPacas
        '
        Me.NuCaracterPacas.Location = New System.Drawing.Point(317, 41)
        Me.NuCaracterPacas.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NuCaracterPacas.Name = "NuCaracterPacas"
        Me.NuCaracterPacas.Size = New System.Drawing.Size(62, 20)
        Me.NuCaracterPacas.TabIndex = 5
        Me.NuCaracterPacas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Posicion Inicial"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(253, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Caracteres"
        '
        'GbPesoProduccion
        '
        Me.GbPesoProduccion.Controls.Add(Me.NuCaracterBoletaNeto)
        Me.GbPesoProduccion.Controls.Add(Me.NuInicialBoletaNeto)
        Me.GbPesoProduccion.Controls.Add(Me.NuInicialBoletaBruto)
        Me.GbPesoProduccion.Controls.Add(Me.NuCaracterBoletaBruto)
        Me.GbPesoProduccion.Controls.Add(Me.NuInicialBoletaTara)
        Me.GbPesoProduccion.Controls.Add(Me.NuCaracterBoletaTara)
        Me.GbPesoProduccion.Controls.Add(Me.Label7)
        Me.GbPesoProduccion.Controls.Add(Me.Label8)
        Me.GbPesoProduccion.Controls.Add(Me.Label10)
        Me.GbPesoProduccion.Controls.Add(Me.Label6)
        Me.GbPesoProduccion.Controls.Add(Me.Label9)
        Me.GbPesoProduccion.Controls.Add(Me.Label11)
        Me.GbPesoProduccion.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbPesoProduccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbPesoProduccion.Location = New System.Drawing.Point(0, 240)
        Me.GbPesoProduccion.Name = "GbPesoProduccion"
        Me.GbPesoProduccion.Size = New System.Drawing.Size(1028, 160)
        Me.GbPesoProduccion.TabIndex = 10
        Me.GbPesoProduccion.TabStop = False
        Me.GbPesoProduccion.Text = "Pesos En Captura De Boletas"
        '
        'NuCaracterBoletaNeto
        '
        Me.NuCaracterBoletaNeto.Location = New System.Drawing.Point(317, 74)
        Me.NuCaracterBoletaNeto.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NuCaracterBoletaNeto.Name = "NuCaracterBoletaNeto"
        Me.NuCaracterBoletaNeto.Size = New System.Drawing.Size(62, 20)
        Me.NuCaracterBoletaNeto.TabIndex = 5
        Me.NuCaracterBoletaNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NuInicialBoletaNeto
        '
        Me.NuInicialBoletaNeto.Location = New System.Drawing.Point(133, 74)
        Me.NuInicialBoletaNeto.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NuInicialBoletaNeto.Name = "NuInicialBoletaNeto"
        Me.NuInicialBoletaNeto.Size = New System.Drawing.Size(62, 20)
        Me.NuInicialBoletaNeto.TabIndex = 5
        Me.NuInicialBoletaNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NuInicialBoletaBruto
        '
        Me.NuInicialBoletaBruto.Location = New System.Drawing.Point(133, 24)
        Me.NuInicialBoletaBruto.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NuInicialBoletaBruto.Name = "NuInicialBoletaBruto"
        Me.NuInicialBoletaBruto.Size = New System.Drawing.Size(62, 20)
        Me.NuInicialBoletaBruto.TabIndex = 5
        Me.NuInicialBoletaBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NuCaracterBoletaBruto
        '
        Me.NuCaracterBoletaBruto.Location = New System.Drawing.Point(317, 24)
        Me.NuCaracterBoletaBruto.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NuCaracterBoletaBruto.Name = "NuCaracterBoletaBruto"
        Me.NuCaracterBoletaBruto.Size = New System.Drawing.Size(62, 20)
        Me.NuCaracterBoletaBruto.TabIndex = 5
        Me.NuCaracterBoletaBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NuInicialBoletaTara
        '
        Me.NuInicialBoletaTara.Location = New System.Drawing.Point(569, 24)
        Me.NuInicialBoletaTara.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NuInicialBoletaTara.Name = "NuInicialBoletaTara"
        Me.NuInicialBoletaTara.Size = New System.Drawing.Size(62, 20)
        Me.NuInicialBoletaTara.TabIndex = 5
        Me.NuInicialBoletaTara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NuCaracterBoletaTara
        '
        Me.NuCaracterBoletaTara.Location = New System.Drawing.Point(743, 24)
        Me.NuCaracterBoletaTara.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NuCaracterBoletaTara.Name = "NuCaracterBoletaTara"
        Me.NuCaracterBoletaTara.Size = New System.Drawing.Size(62, 20)
        Me.NuCaracterBoletaTara.TabIndex = 5
        Me.NuCaracterBoletaTara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Posicion Inicial Bruto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(679, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Caracteres"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(253, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Caracteres"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(253, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Caracteres"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(448, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Posicion Inicial Tara"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Posicion Inicial Neto"
        '
        'GbIdProduccion
        '
        Me.GbIdProduccion.Controls.Add(Me.TbGross)
        Me.GbIdProduccion.Controls.Add(Me.NuCaracterTransporte)
        Me.GbIdProduccion.Controls.Add(Me.NuInicialTransporte)
        Me.GbIdProduccion.Controls.Add(Me.NuCaracterModulo)
        Me.GbIdProduccion.Controls.Add(Me.NuInicialModulo)
        Me.GbIdProduccion.Controls.Add(Me.Label14)
        Me.GbIdProduccion.Controls.Add(Me.Label3)
        Me.GbIdProduccion.Controls.Add(Me.Label1)
        Me.GbIdProduccion.Controls.Add(Me.Label4)
        Me.GbIdProduccion.Controls.Add(Me.Label5)
        Me.GbIdProduccion.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbIdProduccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbIdProduccion.Location = New System.Drawing.Point(0, 82)
        Me.GbIdProduccion.Name = "GbIdProduccion"
        Me.GbIdProduccion.Size = New System.Drawing.Size(1028, 158)
        Me.GbIdProduccion.TabIndex = 9
        Me.GbIdProduccion.TabStop = False
        Me.GbIdProduccion.Text = "Id Modulo y Camion Produccion"
        '
        'NuCaracterTransporte
        '
        Me.NuCaracterTransporte.Location = New System.Drawing.Point(743, 39)
        Me.NuCaracterTransporte.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NuCaracterTransporte.Name = "NuCaracterTransporte"
        Me.NuCaracterTransporte.Size = New System.Drawing.Size(62, 20)
        Me.NuCaracterTransporte.TabIndex = 5
        Me.NuCaracterTransporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NuInicialTransporte
        '
        Me.NuInicialTransporte.Location = New System.Drawing.Point(569, 39)
        Me.NuInicialTransporte.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NuInicialTransporte.Name = "NuInicialTransporte"
        Me.NuInicialTransporte.Size = New System.Drawing.Size(62, 20)
        Me.NuInicialTransporte.TabIndex = 5
        Me.NuInicialTransporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NuCaracterModulo
        '
        Me.NuCaracterModulo.Location = New System.Drawing.Point(317, 39)
        Me.NuCaracterModulo.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NuCaracterModulo.Name = "NuCaracterModulo"
        Me.NuCaracterModulo.Size = New System.Drawing.Size(62, 20)
        Me.NuCaracterModulo.TabIndex = 5
        Me.NuCaracterModulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NuInicialModulo
        '
        Me.NuInicialModulo.Location = New System.Drawing.Point(133, 39)
        Me.NuInicialModulo.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NuInicialModulo.Name = "NuInicialModulo"
        Me.NuInicialModulo.Size = New System.Drawing.Size(62, 20)
        Me.NuInicialModulo.TabIndex = 5
        Me.NuInicialModulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Posicion Inicial Modulo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(679, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Caracteres"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(253, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Caracteres"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(448, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Posicion Inicial Camion"
        '
        'GbPuerto
        '
        Me.GbPuerto.Controls.Add(Me.Label2)
        Me.GbPuerto.Controls.Add(Me.CbPuertosSeriales)
        Me.GbPuerto.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbPuerto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbPuerto.Location = New System.Drawing.Point(0, 0)
        Me.GbPuerto.Name = "GbPuerto"
        Me.GbPuerto.Size = New System.Drawing.Size(1028, 82)
        Me.GbPuerto.TabIndex = 8
        Me.GbPuerto.TabStop = False
        Me.GbPuerto.Text = "Puerto Serial General"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Puerto Serial:"
        '
        'CbPuertosSeriales
        '
        Me.CbPuertosSeriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbPuertosSeriales.FormattingEnabled = True
        Me.CbPuertosSeriales.Location = New System.Drawing.Point(99, 29)
        Me.CbPuertosSeriales.Name = "CbPuertosSeriales"
        Me.CbPuertosSeriales.Size = New System.Drawing.Size(121, 21)
        Me.CbPuertosSeriales.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.TsNombrePc, Me.TsSeparador, Me.ToolStripStatusLabel2, Me.TsIpComputadora, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.TsIdConfiguracion})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 601)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1028, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(75, 17)
        Me.ToolStripStatusLabel1.Text = "Nombre PC :"
        '
        'TsNombrePc
        '
        Me.TsNombrePc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TsNombrePc.Name = "TsNombrePc"
        Me.TsNombrePc.Size = New System.Drawing.Size(0, 17)
        '
        'TsSeparador
        '
        Me.TsSeparador.Name = "TsSeparador"
        Me.TsSeparador.Size = New System.Drawing.Size(10, 17)
        Me.TsSeparador.Text = "|"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(76, 17)
        Me.ToolStripStatusLabel2.Text = "Direccion IP :"
        '
        'TsIpComputadora
        '
        Me.TsIpComputadora.Name = "TsIpComputadora"
        Me.TsIpComputadora.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel3.Text = "|"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(103, 17)
        Me.ToolStripStatusLabel4.Text = "ID Configuracion :"
        '
        'TsIdConfiguracion
        '
        Me.TsIdConfiguracion.Name = "TsIdConfiguracion"
        Me.TsIdConfiguracion.Size = New System.Drawing.Size(0, 17)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Posiciona peso Bruto"
        '
        'TbGross
        '
        Me.TbGross.Location = New System.Drawing.Point(125, 74)
        Me.TbGross.Name = "TbGross"
        Me.TbGross.Size = New System.Drawing.Size(105, 20)
        Me.TbGross.TabIndex = 6
        '
        'ConfiguracionParametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 623)
        Me.Controls.Add(Me.PanelParametrosBascula)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1044, 662)
        Me.Name = "ConfiguracionParametros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuracion De Parametros"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelParametrosBascula.ResumeLayout(False)
        Me.GbPesoPacas.ResumeLayout(False)
        Me.GbPesoPacas.PerformLayout()
        CType(Me.NuInicialPacas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuCaracterPacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbPesoProduccion.ResumeLayout(False)
        Me.GbPesoProduccion.PerformLayout()
        CType(Me.NuCaracterBoletaNeto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuInicialBoletaNeto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuInicialBoletaBruto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuCaracterBoletaBruto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuInicialBoletaTara, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuCaracterBoletaTara, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbIdProduccion.ResumeLayout(False)
        Me.GbIdProduccion.PerformLayout()
        CType(Me.NuCaracterTransporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuInicialTransporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuCaracterModulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuInicialModulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbPuerto.ResumeLayout(False)
        Me.GbPuerto.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelParametrosBascula As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents TsNombrePc As ToolStripStatusLabel
    Friend WithEvents TsSeparador As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents TsIpComputadora As ToolStripStatusLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GbPesoProduccion As GroupBox
    Friend WithEvents GbIdProduccion As GroupBox
    Friend WithEvents GbPuerto As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CbPuertosSeriales As ComboBox
    Friend WithEvents GbPesoPacas As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NuInicialPacas As NumericUpDown
    Friend WithEvents NuCaracterPacas As NumericUpDown
    Friend WithEvents NuCaracterBoletaNeto As NumericUpDown
    Friend WithEvents NuInicialBoletaNeto As NumericUpDown
    Friend WithEvents NuInicialBoletaBruto As NumericUpDown
    Friend WithEvents NuCaracterBoletaBruto As NumericUpDown
    Friend WithEvents NuInicialBoletaTara As NumericUpDown
    Friend WithEvents NuCaracterBoletaTara As NumericUpDown
    Friend WithEvents NuCaracterTransporte As NumericUpDown
    Friend WithEvents NuInicialTransporte As NumericUpDown
    Friend WithEvents NuCaracterModulo As NumericUpDown
    Friend WithEvents NuInicialModulo As NumericUpDown
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents TsIdConfiguracion As ToolStripStatusLabel
    Friend WithEvents TbGross As TextBox
    Friend WithEvents Label14 As Label
End Class
