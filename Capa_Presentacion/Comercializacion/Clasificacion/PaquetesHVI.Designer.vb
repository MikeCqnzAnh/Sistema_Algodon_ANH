<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaquetesHVI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaquetesHVI))
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatExtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.GbConsultaPaca = New System.Windows.Forms.GroupBox()
        Me.DgvConsultaLotID = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbNoPacaConsulta = New System.Windows.Forms.TextBox()
        Me.NuCantidadPacas = New System.Windows.Forms.NumericUpDown()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbRuta = New System.Windows.Forms.TextBox()
        Me.BtSeleccionar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbPaquete = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbPlanta = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbIdPaqueteHVI = New System.Windows.Forms.TextBox()
        Me.DgvPaquetesHVI = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbbottom = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btbajaparametros = New System.Windows.Forms.Button()
        Me.btaltaparametros = New System.Windows.Forms.Button()
        Me.btpacacomprada = New System.Windows.Forms.Button()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtCargaAccess = New System.Windows.Forms.Button()
        Me.BtCargaExcel = New System.Windows.Forms.Button()
        Me.MSMenu.SuspendLayout()
        Me.GbDatosGenerales.SuspendLayout()
        Me.GbConsultaPaca.SuspendLayout()
        CType(Me.DgvConsultaLotID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuCantidadPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvPaquetesHVI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gbbottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.MatExtToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(1279, 24)
        Me.MSMenu.TabIndex = 0
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'MatExtToolStripMenuItem
        '
        Me.MatExtToolStripMenuItem.Name = "MatExtToolStripMenuItem"
        Me.MatExtToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.MatExtToolStripMenuItem.Text = "Mat. Ext."
        Me.MatExtToolStripMenuItem.Visible = False
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
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.Controls.Add(Me.BtCargaAccess)
        Me.GbDatosGenerales.Controls.Add(Me.BtCargaExcel)
        Me.GbDatosGenerales.Controls.Add(Me.GbConsultaPaca)
        Me.GbDatosGenerales.Controls.Add(Me.NuCantidadPacas)
        Me.GbDatosGenerales.Controls.Add(Me.CbEstatus)
        Me.GbDatosGenerales.Controls.Add(Me.Label5)
        Me.GbDatosGenerales.Controls.Add(Me.TbRuta)
        Me.GbDatosGenerales.Controls.Add(Me.BtSeleccionar)
        Me.GbDatosGenerales.Controls.Add(Me.Label6)
        Me.GbDatosGenerales.Controls.Add(Me.Label4)
        Me.GbDatosGenerales.Controls.Add(Me.TbPaquete)
        Me.GbDatosGenerales.Controls.Add(Me.Label3)
        Me.GbDatosGenerales.Controls.Add(Me.DtpFecha)
        Me.GbDatosGenerales.Controls.Add(Me.Label2)
        Me.GbDatosGenerales.Controls.Add(Me.CbPlanta)
        Me.GbDatosGenerales.Controls.Add(Me.Label1)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdPaqueteHVI)
        Me.GbDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatosGenerales.Location = New System.Drawing.Point(0, 24)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(1279, 196)
        Me.GbDatosGenerales.TabIndex = 1
        Me.GbDatosGenerales.TabStop = False
        Me.GbDatosGenerales.Text = "Datos Generales"
        '
        'GbConsultaPaca
        '
        Me.GbConsultaPaca.Controls.Add(Me.DgvConsultaLotID)
        Me.GbConsultaPaca.Controls.Add(Me.Label7)
        Me.GbConsultaPaca.Controls.Add(Me.TbNoPacaConsulta)
        Me.GbConsultaPaca.Dock = System.Windows.Forms.DockStyle.Right
        Me.GbConsultaPaca.Location = New System.Drawing.Point(990, 16)
        Me.GbConsultaPaca.Name = "GbConsultaPaca"
        Me.GbConsultaPaca.Size = New System.Drawing.Size(286, 177)
        Me.GbConsultaPaca.TabIndex = 13
        Me.GbConsultaPaca.TabStop = False
        Me.GbConsultaPaca.Text = "Consulta Lote de paca"
        '
        'DgvConsultaLotID
        '
        Me.DgvConsultaLotID.AllowUserToAddRows = False
        Me.DgvConsultaLotID.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgvConsultaLotID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConsultaLotID.Location = New System.Drawing.Point(10, 71)
        Me.DgvConsultaLotID.Name = "DgvConsultaLotID"
        Me.DgvConsultaLotID.Size = New System.Drawing.Size(267, 94)
        Me.DgvConsultaLotID.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "No. Paca"
        '
        'TbNoPacaConsulta
        '
        Me.TbNoPacaConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNoPacaConsulta.Location = New System.Drawing.Point(93, 39)
        Me.TbNoPacaConsulta.MaxLength = 10
        Me.TbNoPacaConsulta.Name = "TbNoPacaConsulta"
        Me.TbNoPacaConsulta.Size = New System.Drawing.Size(184, 26)
        Me.TbNoPacaConsulta.TabIndex = 0
        '
        'NuCantidadPacas
        '
        Me.NuCantidadPacas.Enabled = False
        Me.NuCantidadPacas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuCantidadPacas.Location = New System.Drawing.Point(862, 95)
        Me.NuCantidadPacas.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NuCantidadPacas.Name = "NuCantidadPacas"
        Me.NuCantidadPacas.Size = New System.Drawing.Size(122, 31)
        Me.NuCantidadPacas.TabIndex = 12
        Me.NuCantidadPacas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CbEstatus
        '
        Me.CbEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(482, 95)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(180, 33)
        Me.CbEstatus.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(385, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Estatus"
        '
        'TbRuta
        '
        Me.TbRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbRuta.Location = New System.Drawing.Point(482, 131)
        Me.TbRuta.Name = "TbRuta"
        Me.TbRuta.Size = New System.Drawing.Size(502, 31)
        Me.TbRuta.TabIndex = 9
        Me.TbRuta.Visible = False
        '
        'BtSeleccionar
        '
        Me.BtSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtSeleccionar.Location = New System.Drawing.Point(322, 131)
        Me.BtSeleccionar.Name = "BtSeleccionar"
        Me.BtSeleccionar.Size = New System.Drawing.Size(154, 31)
        Me.BtSeleccionar.TabIndex = 8
        Me.BtSeleccionar.Text = "Seleccionar"
        Me.BtSeleccionar.UseVisualStyleBackColor = True
        Me.BtSeleccionar.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(678, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Cantidad Pacas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Paquete"
        '
        'TbPaquete
        '
        Me.TbPaquete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbPaquete.Location = New System.Drawing.Point(175, 95)
        Me.TbPaquete.Name = "TbPaquete"
        Me.TbPaquete.Size = New System.Drawing.Size(156, 31)
        Me.TbPaquete.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha"
        '
        'DtpFecha
        '
        Me.DtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFecha.Location = New System.Drawing.Point(175, 58)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(487, 31)
        Me.DtpFecha.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Planta"
        '
        'CbPlanta
        '
        Me.CbPlanta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbPlanta.FormattingEnabled = True
        Me.CbPlanta.Location = New System.Drawing.Point(175, 19)
        Me.CbPlanta.Name = "CbPlanta"
        Me.CbPlanta.Size = New System.Drawing.Size(390, 33)
        Me.CbPlanta.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(844, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'TbIdPaqueteHVI
        '
        Me.TbIdPaqueteHVI.Enabled = False
        Me.TbIdPaqueteHVI.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbIdPaqueteHVI.Location = New System.Drawing.Point(884, 19)
        Me.TbIdPaqueteHVI.Name = "TbIdPaqueteHVI"
        Me.TbIdPaqueteHVI.Size = New System.Drawing.Size(100, 31)
        Me.TbIdPaqueteHVI.TabIndex = 0
        '
        'DgvPaquetesHVI
        '
        Me.DgvPaquetesHVI.AllowUserToAddRows = False
        Me.DgvPaquetesHVI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPaquetesHVI.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgvPaquetesHVI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPaquetesHVI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPaquetesHVI.Location = New System.Drawing.Point(0, 0)
        Me.DgvPaquetesHVI.Name = "DgvPaquetesHVI"
        Me.DgvPaquetesHVI.Size = New System.Drawing.Size(1279, 367)
        Me.DgvPaquetesHVI.TabIndex = 2
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DgvPaquetesHVI)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 220)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1279, 367)
        Me.Panel1.TabIndex = 3
        '
        'gbbottom
        '
        Me.gbbottom.Controls.Add(Me.Label10)
        Me.gbbottom.Controls.Add(Me.Label9)
        Me.gbbottom.Controls.Add(Me.Label8)
        Me.gbbottom.Controls.Add(Me.btbajaparametros)
        Me.gbbottom.Controls.Add(Me.btaltaparametros)
        Me.gbbottom.Controls.Add(Me.btpacacomprada)
        Me.gbbottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbbottom.Location = New System.Drawing.Point(0, 587)
        Me.gbbottom.Name = "gbbottom"
        Me.gbbottom.Size = New System.Drawing.Size(1279, 49)
        Me.gbbottom.TabIndex = 3
        Me.gbbottom.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(379, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Paca baja en parametros:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(170, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Paca alta en parametros:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Paca comprada:"
        '
        'btbajaparametros
        '
        Me.btbajaparametros.BackColor = System.Drawing.Color.LemonChiffon
        Me.btbajaparametros.Enabled = False
        Me.btbajaparametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btbajaparametros.Location = New System.Drawing.Point(537, 17)
        Me.btbajaparametros.Name = "btbajaparametros"
        Me.btbajaparametros.Size = New System.Drawing.Size(48, 23)
        Me.btbajaparametros.TabIndex = 2
        Me.btbajaparametros.UseVisualStyleBackColor = False
        '
        'btaltaparametros
        '
        Me.btaltaparametros.BackColor = System.Drawing.Color.LightCoral
        Me.btaltaparametros.Enabled = False
        Me.btaltaparametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btaltaparametros.Location = New System.Drawing.Point(325, 17)
        Me.btaltaparametros.Name = "btaltaparametros"
        Me.btaltaparametros.Size = New System.Drawing.Size(48, 23)
        Me.btaltaparametros.TabIndex = 1
        Me.btaltaparametros.UseVisualStyleBackColor = False
        '
        'btpacacomprada
        '
        Me.btpacacomprada.BackColor = System.Drawing.Color.SkyBlue
        Me.btpacacomprada.Enabled = False
        Me.btpacacomprada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btpacacomprada.Location = New System.Drawing.Point(115, 16)
        Me.btpacacomprada.Name = "btpacacomprada"
        Me.btpacacomprada.Size = New System.Drawing.Size(48, 23)
        Me.btpacacomprada.TabIndex = 0
        Me.btpacacomprada.UseVisualStyleBackColor = False
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'BtCargaAccess
        '
        Me.BtCargaAccess.BackgroundImage = CType(resources.GetObject("BtCargaAccess.BackgroundImage"), System.Drawing.Image)
        Me.BtCargaAccess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtCargaAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtCargaAccess.Location = New System.Drawing.Point(58, 132)
        Me.BtCargaAccess.Name = "BtCargaAccess"
        Me.BtCargaAccess.Size = New System.Drawing.Size(37, 35)
        Me.BtCargaAccess.TabIndex = 15
        Me.BtCargaAccess.Tag = "Cargar Access"
        Me.BtCargaAccess.UseVisualStyleBackColor = True
        '
        'BtCargaExcel
        '
        Me.BtCargaExcel.BackgroundImage = CType(resources.GetObject("BtCargaExcel.BackgroundImage"), System.Drawing.Image)
        Me.BtCargaExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtCargaExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtCargaExcel.Location = New System.Drawing.Point(15, 132)
        Me.BtCargaExcel.Name = "BtCargaExcel"
        Me.BtCargaExcel.Size = New System.Drawing.Size(37, 35)
        Me.BtCargaExcel.TabIndex = 14
        Me.BtCargaExcel.Tag = "Cargar Excel"
        Me.BtCargaExcel.UseVisualStyleBackColor = True
        '
        'PaquetesHVI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1279, 636)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbbottom)
        Me.Controls.Add(Me.GbDatosGenerales)
        Me.Controls.Add(Me.MSMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "PaquetesHVI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de paquetes HVI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        Me.GbConsultaPaca.ResumeLayout(False)
        Me.GbConsultaPaca.PerformLayout()
        CType(Me.DgvConsultaLotID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuCantidadPacas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvPaquetesHVI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.gbbottom.ResumeLayout(False)
        Me.gbbottom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GbDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbIdPaqueteHVI As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TbPaquete As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbPlanta As System.Windows.Forms.ComboBox
    Friend WithEvents BtSeleccionar As Button
    Friend WithEvents TbRuta As TextBox
    Friend WithEvents DgvPaquetesHVI As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NuCantidadPacas As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents MatExtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GbConsultaPaca As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TbNoPacaConsulta As TextBox
    Friend WithEvents DgvConsultaLotID As DataGridView
    Friend WithEvents BtCargaAccess As Button
    Friend WithEvents BtCargaExcel As Button
    Friend WithEvents gbbottom As GroupBox
    Friend WithEvents btbajaparametros As Button
    Friend WithEvents btaltaparametros As Button
    Friend WithEvents btpacacomprada As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
End Class
