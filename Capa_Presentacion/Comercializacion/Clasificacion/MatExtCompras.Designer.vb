<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MatExtCompras
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
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.NuCantidadPacas = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbIdPaquete = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbPlanta = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbNoPaca = New System.Windows.Forms.TextBox()
        Me.GbParametros = New System.Windows.Forms.GroupBox()
        Me.GbLevel1 = New System.Windows.Forms.GroupBox()
        Me.RbSinCastigoLevel1 = New System.Windows.Forms.RadioButton()
        Me.NuPlasticLevel1 = New System.Windows.Forms.NumericUpDown()
        Me.NuOtherLevel1 = New System.Windows.Forms.NumericUpDown()
        Me.NuPrepLevel1 = New System.Windows.Forms.NumericUpDown()
        Me.NuBarkLevel1 = New System.Windows.Forms.NumericUpDown()
        Me.RbBark1 = New System.Windows.Forms.RadioButton()
        Me.RbPlastic1 = New System.Windows.Forms.RadioButton()
        Me.RbPrep1 = New System.Windows.Forms.RadioButton()
        Me.RbOther1 = New System.Windows.Forms.RadioButton()
        Me.GbLevel2 = New System.Windows.Forms.GroupBox()
        Me.RbSinCastigoLevel2 = New System.Windows.Forms.RadioButton()
        Me.NuPlasticLevel2 = New System.Windows.Forms.NumericUpDown()
        Me.NuOtherLevel2 = New System.Windows.Forms.NumericUpDown()
        Me.NuPrepLevel2 = New System.Windows.Forms.NumericUpDown()
        Me.NuBarkLevel2 = New System.Windows.Forms.NumericUpDown()
        Me.RbPlastic2 = New System.Windows.Forms.RadioButton()
        Me.RbOther2 = New System.Windows.Forms.RadioButton()
        Me.RbPrep2 = New System.Windows.Forms.RadioButton()
        Me.RbBark2 = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbDatagrid = New System.Windows.Forms.GroupBox()
        Me.DgvPacas = New System.Windows.Forms.DataGridView()
        Me.GbDatos.SuspendLayout()
        CType(Me.NuCantidadPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbParametros.SuspendLayout()
        Me.GbLevel1.SuspendLayout()
        CType(Me.NuPlasticLevel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuOtherLevel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuPrepLevel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuBarkLevel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbLevel2.SuspendLayout()
        CType(Me.NuPlasticLevel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuOtherLevel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuPrepLevel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuBarkLevel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GbDatagrid.SuspendLayout()
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.NuCantidadPacas)
        Me.GbDatos.Controls.Add(Me.Label4)
        Me.GbDatos.Controls.Add(Me.Label3)
        Me.GbDatos.Controls.Add(Me.TbIdPaquete)
        Me.GbDatos.Controls.Add(Me.Label1)
        Me.GbDatos.Controls.Add(Me.CbPlanta)
        Me.GbDatos.Controls.Add(Me.Label2)
        Me.GbDatos.Controls.Add(Me.TbNoPaca)
        Me.GbDatos.Controls.Add(Me.GbParametros)
        Me.GbDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatos.Location = New System.Drawing.Point(0, 24)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(1356, 194)
        Me.GbDatos.TabIndex = 0
        Me.GbDatos.TabStop = False
        '
        'NuCantidadPacas
        '
        Me.NuCantidadPacas.Enabled = False
        Me.NuCantidadPacas.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.NuCantidadPacas.Location = New System.Drawing.Point(720, 132)
        Me.NuCantidadPacas.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.NuCantidadPacas.Name = "NuCantidadPacas"
        Me.NuCantidadPacas.Size = New System.Drawing.Size(170, 44)
        Me.NuCantidadPacas.TabIndex = 27
        Me.NuCantidadPacas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuCantidadPacas.ThousandsSeparator = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(560, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 37)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(12, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 37)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Paquete"
        '
        'TbIdPaquete
        '
        Me.TbIdPaquete.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold)
        Me.TbIdPaquete.Location = New System.Drawing.Point(176, 81)
        Me.TbIdPaquete.Name = "TbIdPaquete"
        Me.TbIdPaquete.Size = New System.Drawing.Size(275, 44)
        Me.TbIdPaquete.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Planta :"
        '
        'CbPlanta
        '
        Me.CbPlanta.Enabled = False
        Me.CbPlanta.FormattingEnabled = True
        Me.CbPlanta.Location = New System.Drawing.Point(176, 16)
        Me.CbPlanta.Name = "CbPlanta"
        Me.CbPlanta.Size = New System.Drawing.Size(121, 21)
        Me.CbPlanta.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 37)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "No. Paca"
        '
        'TbNoPaca
        '
        Me.TbNoPaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNoPaca.Location = New System.Drawing.Point(176, 132)
        Me.TbNoPaca.Name = "TbNoPaca"
        Me.TbNoPaca.Size = New System.Drawing.Size(275, 44)
        Me.TbNoPaca.TabIndex = 2
        '
        'GbParametros
        '
        Me.GbParametros.Controls.Add(Me.GbLevel1)
        Me.GbParametros.Controls.Add(Me.GbLevel2)
        Me.GbParametros.Dock = System.Windows.Forms.DockStyle.Right
        Me.GbParametros.Location = New System.Drawing.Point(896, 16)
        Me.GbParametros.Name = "GbParametros"
        Me.GbParametros.Size = New System.Drawing.Size(457, 175)
        Me.GbParametros.TabIndex = 3
        Me.GbParametros.TabStop = False
        Me.GbParametros.Text = "Parametros"
        '
        'GbLevel1
        '
        Me.GbLevel1.Controls.Add(Me.RbSinCastigoLevel1)
        Me.GbLevel1.Controls.Add(Me.NuPlasticLevel1)
        Me.GbLevel1.Controls.Add(Me.NuOtherLevel1)
        Me.GbLevel1.Controls.Add(Me.NuPrepLevel1)
        Me.GbLevel1.Controls.Add(Me.NuBarkLevel1)
        Me.GbLevel1.Controls.Add(Me.RbBark1)
        Me.GbLevel1.Controls.Add(Me.RbPlastic1)
        Me.GbLevel1.Controls.Add(Me.RbPrep1)
        Me.GbLevel1.Controls.Add(Me.RbOther1)
        Me.GbLevel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbLevel1.Location = New System.Drawing.Point(3, 16)
        Me.GbLevel1.Name = "GbLevel1"
        Me.GbLevel1.Size = New System.Drawing.Size(234, 156)
        Me.GbLevel1.TabIndex = 0
        Me.GbLevel1.TabStop = False
        Me.GbLevel1.Text = "Nivel 1"
        '
        'RbSinCastigoLevel1
        '
        Me.RbSinCastigoLevel1.AutoSize = True
        Me.RbSinCastigoLevel1.Location = New System.Drawing.Point(6, 19)
        Me.RbSinCastigoLevel1.Name = "RbSinCastigoLevel1"
        Me.RbSinCastigoLevel1.Size = New System.Drawing.Size(45, 17)
        Me.RbSinCastigoLevel1.TabIndex = 24
        Me.RbSinCastigoLevel1.TabStop = True
        Me.RbSinCastigoLevel1.Text = "N/A"
        Me.RbSinCastigoLevel1.UseVisualStyleBackColor = True
        '
        'NuPlasticLevel1
        '
        Me.NuPlasticLevel1.DecimalPlaces = 2
        Me.NuPlasticLevel1.Enabled = False
        Me.NuPlasticLevel1.Location = New System.Drawing.Point(68, 119)
        Me.NuPlasticLevel1.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.NuPlasticLevel1.Name = "NuPlasticLevel1"
        Me.NuPlasticLevel1.Size = New System.Drawing.Size(111, 20)
        Me.NuPlasticLevel1.TabIndex = 3
        Me.NuPlasticLevel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuPlasticLevel1.ThousandsSeparator = True
        '
        'NuOtherLevel1
        '
        Me.NuOtherLevel1.DecimalPlaces = 2
        Me.NuOtherLevel1.Enabled = False
        Me.NuOtherLevel1.Location = New System.Drawing.Point(68, 93)
        Me.NuOtherLevel1.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.NuOtherLevel1.Name = "NuOtherLevel1"
        Me.NuOtherLevel1.Size = New System.Drawing.Size(111, 20)
        Me.NuOtherLevel1.TabIndex = 2
        Me.NuOtherLevel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuOtherLevel1.ThousandsSeparator = True
        '
        'NuPrepLevel1
        '
        Me.NuPrepLevel1.DecimalPlaces = 2
        Me.NuPrepLevel1.Enabled = False
        Me.NuPrepLevel1.Location = New System.Drawing.Point(68, 67)
        Me.NuPrepLevel1.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.NuPrepLevel1.Name = "NuPrepLevel1"
        Me.NuPrepLevel1.Size = New System.Drawing.Size(111, 20)
        Me.NuPrepLevel1.TabIndex = 1
        Me.NuPrepLevel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuPrepLevel1.ThousandsSeparator = True
        '
        'NuBarkLevel1
        '
        Me.NuBarkLevel1.DecimalPlaces = 2
        Me.NuBarkLevel1.Enabled = False
        Me.NuBarkLevel1.Location = New System.Drawing.Point(68, 41)
        Me.NuBarkLevel1.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.NuBarkLevel1.Name = "NuBarkLevel1"
        Me.NuBarkLevel1.Size = New System.Drawing.Size(111, 20)
        Me.NuBarkLevel1.TabIndex = 0
        Me.NuBarkLevel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuBarkLevel1.ThousandsSeparator = True
        '
        'RbBark1
        '
        Me.RbBark1.AutoSize = True
        Me.RbBark1.Location = New System.Drawing.Point(6, 42)
        Me.RbBark1.Name = "RbBark1"
        Me.RbBark1.Size = New System.Drawing.Size(47, 17)
        Me.RbBark1.TabIndex = 16
        Me.RbBark1.TabStop = True
        Me.RbBark1.Text = "Bark"
        Me.RbBark1.UseVisualStyleBackColor = True
        '
        'RbPlastic1
        '
        Me.RbPlastic1.AutoSize = True
        Me.RbPlastic1.Location = New System.Drawing.Point(6, 120)
        Me.RbPlastic1.Name = "RbPlastic1"
        Me.RbPlastic1.Size = New System.Drawing.Size(56, 17)
        Me.RbPlastic1.TabIndex = 19
        Me.RbPlastic1.TabStop = True
        Me.RbPlastic1.Text = "Plastic"
        Me.RbPlastic1.UseVisualStyleBackColor = True
        '
        'RbPrep1
        '
        Me.RbPrep1.AutoSize = True
        Me.RbPrep1.Location = New System.Drawing.Point(6, 68)
        Me.RbPrep1.Name = "RbPrep1"
        Me.RbPrep1.Size = New System.Drawing.Size(47, 17)
        Me.RbPrep1.TabIndex = 17
        Me.RbPrep1.TabStop = True
        Me.RbPrep1.Text = "Prep"
        Me.RbPrep1.UseVisualStyleBackColor = True
        '
        'RbOther1
        '
        Me.RbOther1.AutoSize = True
        Me.RbOther1.Location = New System.Drawing.Point(6, 94)
        Me.RbOther1.Name = "RbOther1"
        Me.RbOther1.Size = New System.Drawing.Size(51, 17)
        Me.RbOther1.TabIndex = 18
        Me.RbOther1.TabStop = True
        Me.RbOther1.Text = "Other"
        Me.RbOther1.UseVisualStyleBackColor = True
        '
        'GbLevel2
        '
        Me.GbLevel2.Controls.Add(Me.RbSinCastigoLevel2)
        Me.GbLevel2.Controls.Add(Me.NuPlasticLevel2)
        Me.GbLevel2.Controls.Add(Me.NuOtherLevel2)
        Me.GbLevel2.Controls.Add(Me.NuPrepLevel2)
        Me.GbLevel2.Controls.Add(Me.NuBarkLevel2)
        Me.GbLevel2.Controls.Add(Me.RbPlastic2)
        Me.GbLevel2.Controls.Add(Me.RbOther2)
        Me.GbLevel2.Controls.Add(Me.RbPrep2)
        Me.GbLevel2.Controls.Add(Me.RbBark2)
        Me.GbLevel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GbLevel2.Location = New System.Drawing.Point(237, 16)
        Me.GbLevel2.Name = "GbLevel2"
        Me.GbLevel2.Size = New System.Drawing.Size(217, 156)
        Me.GbLevel2.TabIndex = 1
        Me.GbLevel2.TabStop = False
        Me.GbLevel2.Text = "Nivel 2"
        '
        'RbSinCastigoLevel2
        '
        Me.RbSinCastigoLevel2.AutoSize = True
        Me.RbSinCastigoLevel2.Location = New System.Drawing.Point(6, 19)
        Me.RbSinCastigoLevel2.Name = "RbSinCastigoLevel2"
        Me.RbSinCastigoLevel2.Size = New System.Drawing.Size(45, 17)
        Me.RbSinCastigoLevel2.TabIndex = 28
        Me.RbSinCastigoLevel2.TabStop = True
        Me.RbSinCastigoLevel2.Text = "N/A"
        Me.RbSinCastigoLevel2.UseVisualStyleBackColor = True
        '
        'NuPlasticLevel2
        '
        Me.NuPlasticLevel2.DecimalPlaces = 2
        Me.NuPlasticLevel2.Enabled = False
        Me.NuPlasticLevel2.Location = New System.Drawing.Point(68, 119)
        Me.NuPlasticLevel2.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.NuPlasticLevel2.Name = "NuPlasticLevel2"
        Me.NuPlasticLevel2.Size = New System.Drawing.Size(120, 20)
        Me.NuPlasticLevel2.TabIndex = 3
        Me.NuPlasticLevel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuPlasticLevel2.ThousandsSeparator = True
        '
        'NuOtherLevel2
        '
        Me.NuOtherLevel2.DecimalPlaces = 2
        Me.NuOtherLevel2.Enabled = False
        Me.NuOtherLevel2.Location = New System.Drawing.Point(68, 93)
        Me.NuOtherLevel2.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.NuOtherLevel2.Name = "NuOtherLevel2"
        Me.NuOtherLevel2.Size = New System.Drawing.Size(120, 20)
        Me.NuOtherLevel2.TabIndex = 2
        Me.NuOtherLevel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuOtherLevel2.ThousandsSeparator = True
        '
        'NuPrepLevel2
        '
        Me.NuPrepLevel2.DecimalPlaces = 2
        Me.NuPrepLevel2.Enabled = False
        Me.NuPrepLevel2.Location = New System.Drawing.Point(68, 67)
        Me.NuPrepLevel2.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.NuPrepLevel2.Name = "NuPrepLevel2"
        Me.NuPrepLevel2.Size = New System.Drawing.Size(120, 20)
        Me.NuPrepLevel2.TabIndex = 1
        Me.NuPrepLevel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuPrepLevel2.ThousandsSeparator = True
        '
        'NuBarkLevel2
        '
        Me.NuBarkLevel2.DecimalPlaces = 2
        Me.NuBarkLevel2.Enabled = False
        Me.NuBarkLevel2.Location = New System.Drawing.Point(68, 41)
        Me.NuBarkLevel2.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.NuBarkLevel2.Name = "NuBarkLevel2"
        Me.NuBarkLevel2.Size = New System.Drawing.Size(120, 20)
        Me.NuBarkLevel2.TabIndex = 0
        Me.NuBarkLevel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuBarkLevel2.ThousandsSeparator = True
        '
        'RbPlastic2
        '
        Me.RbPlastic2.AutoSize = True
        Me.RbPlastic2.Location = New System.Drawing.Point(6, 120)
        Me.RbPlastic2.Name = "RbPlastic2"
        Me.RbPlastic2.Size = New System.Drawing.Size(56, 17)
        Me.RbPlastic2.TabIndex = 23
        Me.RbPlastic2.TabStop = True
        Me.RbPlastic2.Text = "Plastic"
        Me.RbPlastic2.UseVisualStyleBackColor = True
        '
        'RbOther2
        '
        Me.RbOther2.AutoSize = True
        Me.RbOther2.Location = New System.Drawing.Point(6, 94)
        Me.RbOther2.Name = "RbOther2"
        Me.RbOther2.Size = New System.Drawing.Size(51, 17)
        Me.RbOther2.TabIndex = 22
        Me.RbOther2.TabStop = True
        Me.RbOther2.Text = "Other"
        Me.RbOther2.UseVisualStyleBackColor = True
        '
        'RbPrep2
        '
        Me.RbPrep2.AutoSize = True
        Me.RbPrep2.Location = New System.Drawing.Point(6, 68)
        Me.RbPrep2.Name = "RbPrep2"
        Me.RbPrep2.Size = New System.Drawing.Size(47, 17)
        Me.RbPrep2.TabIndex = 21
        Me.RbPrep2.TabStop = True
        Me.RbPrep2.Text = "Prep"
        Me.RbPrep2.UseVisualStyleBackColor = True
        '
        'RbBark2
        '
        Me.RbBark2.AutoSize = True
        Me.RbBark2.Location = New System.Drawing.Point(6, 42)
        Me.RbBark2.Name = "RbBark2"
        Me.RbBark2.Size = New System.Drawing.Size(47, 17)
        Me.RbBark2.TabIndex = 20
        Me.RbBark2.TabStop = True
        Me.RbBark2.Text = "Bark"
        Me.RbBark2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1356, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GbDatagrid
        '
        Me.GbDatagrid.Controls.Add(Me.DgvPacas)
        Me.GbDatagrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbDatagrid.Location = New System.Drawing.Point(0, 218)
        Me.GbDatagrid.Name = "GbDatagrid"
        Me.GbDatagrid.Size = New System.Drawing.Size(1356, 480)
        Me.GbDatagrid.TabIndex = 2
        Me.GbDatagrid.TabStop = False
        '
        'DgvPacas
        '
        Me.DgvPacas.AllowUserToAddRows = False
        Me.DgvPacas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacas.Location = New System.Drawing.Point(3, 16)
        Me.DgvPacas.Name = "DgvPacas"
        Me.DgvPacas.ReadOnly = True
        Me.DgvPacas.Size = New System.Drawing.Size(1350, 461)
        Me.DgvPacas.TabIndex = 3
        '
        'MatExtCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 698)
        Me.Controls.Add(Me.GbDatagrid)
        Me.Controls.Add(Me.GbDatos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MatExtCompras"
        Me.Text = "Materias Extrañas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        CType(Me.NuCantidadPacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbParametros.ResumeLayout(False)
        Me.GbLevel1.ResumeLayout(False)
        Me.GbLevel1.PerformLayout()
        CType(Me.NuPlasticLevel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuOtherLevel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuPrepLevel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuBarkLevel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbLevel2.ResumeLayout(False)
        Me.GbLevel2.PerformLayout()
        CType(Me.NuPlasticLevel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuOtherLevel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuPrepLevel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuBarkLevel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GbDatagrid.ResumeLayout(False)
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents TbNoPaca As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents GbDatagrid As GroupBox
    Friend WithEvents GbParametros As GroupBox
    Friend WithEvents RbPlastic2 As RadioButton
    Friend WithEvents RbOther2 As RadioButton
    Friend WithEvents RbPrep2 As RadioButton
    Friend WithEvents RbBark2 As RadioButton
    Friend WithEvents RbPlastic1 As RadioButton
    Friend WithEvents RbOther1 As RadioButton
    Friend WithEvents RbPrep1 As RadioButton
    Friend WithEvents RbBark1 As RadioButton
    Friend WithEvents GbLevel2 As GroupBox
    Friend WithEvents NuPlasticLevel2 As NumericUpDown
    Friend WithEvents NuOtherLevel2 As NumericUpDown
    Friend WithEvents NuPrepLevel2 As NumericUpDown
    Friend WithEvents NuBarkLevel2 As NumericUpDown
    Friend WithEvents GbLevel1 As GroupBox
    Friend WithEvents NuPlasticLevel1 As NumericUpDown
    Friend WithEvents NuOtherLevel1 As NumericUpDown
    Friend WithEvents NuPrepLevel1 As NumericUpDown
    Friend WithEvents NuBarkLevel1 As NumericUpDown
    Friend WithEvents RbSinCastigoLevel2 As RadioButton
    Friend WithEvents RbSinCastigoLevel1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents CbPlanta As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbIdPaquete As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NuCantidadPacas As NumericUpDown
    Friend WithEvents DgvPacas As DataGridView
End Class
