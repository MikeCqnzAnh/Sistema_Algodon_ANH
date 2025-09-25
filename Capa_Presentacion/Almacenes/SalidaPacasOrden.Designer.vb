<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalidaPacasOrden
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabpacas = New System.Windows.Forms.TabControl()
        Me.tppacas = New System.Windows.Forms.TabPage()
        Me.dgvpacaorigen = New System.Windows.Forms.DataGridView()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.label16 = New System.Windows.Forms.Label()
        Me.label17 = New System.Windows.Forms.Label()
        Me.label18 = New System.Windows.Forms.Label()
        Me.nutotalkilos = New System.Windows.Forms.NumericUpDown()
        Me.label15 = New System.Windows.Forms.Label()
        Me.cbestatus = New System.Windows.Forms.ComboBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tbplacacaja = New System.Windows.Forms.TextBox()
        Me.tbplacatractocamion = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.tblicencia = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.tbdestino = New System.Windows.Forms.TextBox()
        Me.tbfoliosalida = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.tbtelefono = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.tbnombretransportista = New System.Windows.Forms.TextBox()
        Me.tbobservaciones = New System.Windows.Forms.TextBox()
        Me.label20 = New System.Windows.Forms.Label()
        Me.nutotalpacas = New System.Windows.Forms.NumericUpDown()
        Me.label13 = New System.Windows.Forms.Label()
        Me.tbnombrecliente = New System.Windows.Forms.TextBox()
        Me.tbidcliente = New System.Windows.Forms.TextBox()
        Me.label19 = New System.Windows.Forms.Label()
        Me.tbidembarque = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.nupesoneto = New System.Windows.Forms.NumericUpDown()
        Me.nupesotara = New System.Windows.Forms.NumericUpDown()
        Me.nupesobruto = New System.Windows.Forms.NumericUpDown()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.dtfechaactualizacion = New System.Windows.Forms.DateTimePicker()
        Me.dtfechacreacion = New System.Windows.Forms.DateTimePicker()
        Me.tbidsalida = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.mnustrip = New System.Windows.Forms.MenuStrip()
        Me.nuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.generaSalidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.guardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.consultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cancelarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btconsultaorden = New Bunifu.Framework.UI.BunifuImageButton()
        Me.tabpacas.SuspendLayout()
        Me.tppacas.SuspendLayout()
        CType(Me.dgvpacaorigen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.nutotalkilos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nutotalpacas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupesoneto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupesotara, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nupesobruto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnustrip.SuspendLayout()
        CType(Me.btconsultaorden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabpacas
        '
        Me.tabpacas.Controls.Add(Me.tppacas)
        Me.tabpacas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabpacas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabpacas.Location = New System.Drawing.Point(0, 330)
        Me.tabpacas.Name = "tabpacas"
        Me.tabpacas.SelectedIndex = 0
        Me.tabpacas.Size = New System.Drawing.Size(1125, 335)
        Me.tabpacas.TabIndex = 139
        '
        'tppacas
        '
        Me.tppacas.Controls.Add(Me.dgvpacaorigen)
        Me.tppacas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tppacas.Location = New System.Drawing.Point(4, 29)
        Me.tppacas.Name = "tppacas"
        Me.tppacas.Padding = New System.Windows.Forms.Padding(3)
        Me.tppacas.Size = New System.Drawing.Size(1117, 302)
        Me.tppacas.TabIndex = 1
        Me.tppacas.Text = "Pacas"
        Me.tppacas.UseVisualStyleBackColor = True
        '
        'dgvpacaorigen
        '
        Me.dgvpacaorigen.AllowUserToAddRows = False
        Me.dgvpacaorigen.AllowUserToDeleteRows = False
        Me.dgvpacaorigen.AllowUserToOrderColumns = True
        Me.dgvpacaorigen.AllowUserToResizeRows = False
        Me.dgvpacaorigen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvpacaorigen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvpacaorigen.BackgroundColor = System.Drawing.Color.White
        Me.dgvpacaorigen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvpacaorigen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvpacaorigen.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvpacaorigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvpacaorigen.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvpacaorigen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvpacaorigen.Location = New System.Drawing.Point(3, 3)
        Me.dgvpacaorigen.MultiSelect = False
        Me.dgvpacaorigen.Name = "dgvpacaorigen"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvpacaorigen.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvpacaorigen.RowHeadersVisible = False
        Me.dgvpacaorigen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvpacaorigen.Size = New System.Drawing.Size(1111, 296)
        Me.dgvpacaorigen.TabIndex = 3
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.label16)
        Me.panel2.Controls.Add(Me.label17)
        Me.panel2.Controls.Add(Me.label18)
        Me.panel2.Controls.Add(Me.nutotalkilos)
        Me.panel2.Controls.Add(Me.label15)
        Me.panel2.Controls.Add(Me.cbestatus)
        Me.panel2.Controls.Add(Me.label14)
        Me.panel2.Controls.Add(Me.label2)
        Me.panel2.Controls.Add(Me.tbplacacaja)
        Me.panel2.Controls.Add(Me.tbplacatractocamion)
        Me.panel2.Controls.Add(Me.label3)
        Me.panel2.Controls.Add(Me.tblicencia)
        Me.panel2.Controls.Add(Me.label4)
        Me.panel2.Controls.Add(Me.label5)
        Me.panel2.Controls.Add(Me.tbdestino)
        Me.panel2.Controls.Add(Me.tbfoliosalida)
        Me.panel2.Controls.Add(Me.label10)
        Me.panel2.Controls.Add(Me.tbtelefono)
        Me.panel2.Controls.Add(Me.label11)
        Me.panel2.Controls.Add(Me.label12)
        Me.panel2.Controls.Add(Me.tbnombretransportista)
        Me.panel2.Controls.Add(Me.tbobservaciones)
        Me.panel2.Controls.Add(Me.label20)
        Me.panel2.Controls.Add(Me.nutotalpacas)
        Me.panel2.Controls.Add(Me.label13)
        Me.panel2.Controls.Add(Me.tbnombrecliente)
        Me.panel2.Controls.Add(Me.tbidcliente)
        Me.panel2.Controls.Add(Me.label19)
        Me.panel2.Controls.Add(Me.btconsultaorden)
        Me.panel2.Controls.Add(Me.tbidembarque)
        Me.panel2.Controls.Add(Me.label9)
        Me.panel2.Controls.Add(Me.nupesoneto)
        Me.panel2.Controls.Add(Me.nupesotara)
        Me.panel2.Controls.Add(Me.nupesobruto)
        Me.panel2.Controls.Add(Me.label8)
        Me.panel2.Controls.Add(Me.label7)
        Me.panel2.Controls.Add(Me.label6)
        Me.panel2.Controls.Add(Me.dtfechaactualizacion)
        Me.panel2.Controls.Add(Me.dtfechacreacion)
        Me.panel2.Controls.Add(Me.tbidsalida)
        Me.panel2.Controls.Add(Me.label1)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(0, 24)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1125, 306)
        Me.panel2.TabIndex = 137
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label16.Location = New System.Drawing.Point(985, 196)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(85, 37)
        Me.label16.TabIndex = 185
        Me.label16.Text = "Kgs."
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label17.Location = New System.Drawing.Point(985, 146)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(85, 37)
        Me.label17.TabIndex = 184
        Me.label17.Text = "Kgs."
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label18.Location = New System.Drawing.Point(985, 96)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(85, 37)
        Me.label18.TabIndex = 183
        Me.label18.Text = "Kgs."
        '
        'nutotalkilos
        '
        Me.nutotalkilos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nutotalkilos.DecimalPlaces = 2
        Me.nutotalkilos.Enabled = False
        Me.nutotalkilos.Location = New System.Drawing.Point(116, 253)
        Me.nutotalkilos.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nutotalkilos.Name = "nutotalkilos"
        Me.nutotalkilos.ReadOnly = True
        Me.nutotalkilos.Size = New System.Drawing.Size(100, 20)
        Me.nutotalkilos.TabIndex = 182
        Me.nutotalkilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nutotalkilos.ThousandsSeparator = True
        Me.nutotalkilos.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Location = New System.Drawing.Point(4, 255)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(29, 13)
        Me.label15.TabIndex = 181
        Me.label15.Text = "Kilos"
        '
        'cbestatus
        '
        Me.cbestatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbestatus.Enabled = False
        Me.cbestatus.FormattingEnabled = True
        Me.cbestatus.Location = New System.Drawing.Point(299, 252)
        Me.cbestatus.Name = "cbestatus"
        Me.cbestatus.Size = New System.Drawing.Size(121, 21)
        Me.cbestatus.TabIndex = 180
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(238, 255)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(42, 13)
        Me.label14.TabIndex = 179
        Me.label14.Text = "Estatus"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(238, 151)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(73, 13)
        Me.label2.TabIndex = 178
        Me.label2.Text = "Placa de Caja"
        '
        'tbplacacaja
        '
        Me.tbplacacaja.Location = New System.Drawing.Point(317, 148)
        Me.tbplacacaja.Name = "tbplacacaja"
        Me.tbplacacaja.ReadOnly = True
        Me.tbplacacaja.Size = New System.Drawing.Size(81, 20)
        Me.tbplacacaja.TabIndex = 177
        '
        'tbplacatractocamion
        '
        Me.tbplacatractocamion.Location = New System.Drawing.Point(116, 149)
        Me.tbplacatractocamion.Name = "tbplacatractocamion"
        Me.tbplacatractocamion.ReadOnly = True
        Me.tbplacatractocamion.Size = New System.Drawing.Size(84, 20)
        Me.tbplacatractocamion.TabIndex = 176
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(4, 152)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(106, 13)
        Me.label3.TabIndex = 175
        Me.label3.Text = "Placa Tracto-Camion"
        '
        'tblicencia
        '
        Me.tblicencia.Location = New System.Drawing.Point(116, 122)
        Me.tblicencia.Name = "tblicencia"
        Me.tblicencia.ReadOnly = True
        Me.tblicencia.Size = New System.Drawing.Size(100, 20)
        Me.tblicencia.TabIndex = 174
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(4, 123)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(47, 13)
        Me.label4.TabIndex = 173
        Me.label4.Text = "Licencia"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(4, 178)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(43, 13)
        Me.label5.TabIndex = 172
        Me.label5.Text = "Destino"
        '
        'tbdestino
        '
        Me.tbdestino.Location = New System.Drawing.Point(116, 175)
        Me.tbdestino.Name = "tbdestino"
        Me.tbdestino.ReadOnly = True
        Me.tbdestino.Size = New System.Drawing.Size(478, 20)
        Me.tbdestino.TabIndex = 171
        '
        'tbfoliosalida
        '
        Me.tbfoliosalida.Location = New System.Drawing.Point(494, 122)
        Me.tbfoliosalida.Name = "tbfoliosalida"
        Me.tbfoliosalida.ReadOnly = True
        Me.tbfoliosalida.Size = New System.Drawing.Size(100, 20)
        Me.tbfoliosalida.TabIndex = 170
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(427, 125)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(61, 13)
        Me.label10.TabIndex = 169
        Me.label10.Text = "Folio Salida"
        '
        'tbtelefono
        '
        Me.tbtelefono.Location = New System.Drawing.Point(299, 122)
        Me.tbtelefono.Name = "tbtelefono"
        Me.tbtelefono.ReadOnly = True
        Me.tbtelefono.Size = New System.Drawing.Size(100, 20)
        Me.tbtelefono.TabIndex = 168
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(234, 125)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(49, 13)
        Me.label11.TabIndex = 167
        Me.label11.Text = "Telefono"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(4, 100)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(68, 13)
        Me.label12.TabIndex = 166
        Me.label12.Text = "Transportista"
        '
        'tbnombretransportista
        '
        Me.tbnombretransportista.Location = New System.Drawing.Point(116, 96)
        Me.tbnombretransportista.Name = "tbnombretransportista"
        Me.tbnombretransportista.ReadOnly = True
        Me.tbnombretransportista.Size = New System.Drawing.Size(478, 20)
        Me.tbnombretransportista.TabIndex = 165
        '
        'tbobservaciones
        '
        Me.tbobservaciones.Location = New System.Drawing.Point(116, 201)
        Me.tbobservaciones.MaxLength = 150
        Me.tbobservaciones.Multiline = True
        Me.tbobservaciones.Name = "tbobservaciones"
        Me.tbobservaciones.ReadOnly = True
        Me.tbobservaciones.Size = New System.Drawing.Size(478, 46)
        Me.tbobservaciones.TabIndex = 162
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(4, 201)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(78, 13)
        Me.label20.TabIndex = 163
        Me.label20.Text = "Observaciones"
        '
        'nutotalpacas
        '
        Me.nutotalpacas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nutotalpacas.Location = New System.Drawing.Point(493, 148)
        Me.nutotalpacas.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.nutotalpacas.Name = "nutotalpacas"
        Me.nutotalpacas.ReadOnly = True
        Me.nutotalpacas.Size = New System.Drawing.Size(100, 20)
        Me.nutotalpacas.TabIndex = 160
        Me.nutotalpacas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nutotalpacas.ThousandsSeparator = True
        Me.nutotalpacas.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(404, 150)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(79, 13)
        Me.label13.TabIndex = 161
        Me.label13.Text = "Total de Pacas"
        '
        'tbnombrecliente
        '
        Me.tbnombrecliente.Location = New System.Drawing.Point(185, 68)
        Me.tbnombrecliente.Name = "tbnombrecliente"
        Me.tbnombrecliente.ReadOnly = True
        Me.tbnombrecliente.Size = New System.Drawing.Size(408, 20)
        Me.tbnombrecliente.TabIndex = 159
        '
        'tbidcliente
        '
        Me.tbidcliente.Location = New System.Drawing.Point(116, 68)
        Me.tbidcliente.Name = "tbidcliente"
        Me.tbidcliente.ReadOnly = True
        Me.tbidcliente.Size = New System.Drawing.Size(63, 20)
        Me.tbidcliente.TabIndex = 158
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Location = New System.Drawing.Point(3, 71)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(39, 13)
        Me.label19.TabIndex = 157
        Me.label19.Text = "Cliente"
        '
        'tbidembarque
        '
        Me.tbidembarque.Location = New System.Drawing.Point(116, 42)
        Me.tbidembarque.Name = "tbidembarque"
        Me.tbidembarque.ReadOnly = True
        Me.tbidembarque.Size = New System.Drawing.Size(63, 20)
        Me.tbidembarque.TabIndex = 154
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(4, 45)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(78, 13)
        Me.label9.TabIndex = 153
        Me.label9.Text = "Orden de Emb."
        '
        'nupesoneto
        '
        Me.nupesoneto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nupesoneto.DecimalPlaces = 2
        Me.nupesoneto.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupesoneto.Location = New System.Drawing.Point(727, 194)
        Me.nupesoneto.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.nupesoneto.Name = "nupesoneto"
        Me.nupesoneto.ReadOnly = True
        Me.nupesoneto.Size = New System.Drawing.Size(252, 44)
        Me.nupesoneto.TabIndex = 152
        Me.nupesoneto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nupesoneto.ThousandsSeparator = True
        Me.nupesoneto.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'nupesotara
        '
        Me.nupesotara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nupesotara.DecimalPlaces = 2
        Me.nupesotara.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupesotara.Location = New System.Drawing.Point(727, 144)
        Me.nupesotara.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.nupesotara.Name = "nupesotara"
        Me.nupesotara.Size = New System.Drawing.Size(252, 44)
        Me.nupesotara.TabIndex = 151
        Me.nupesotara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nupesotara.ThousandsSeparator = True
        Me.nupesotara.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'nupesobruto
        '
        Me.nupesobruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nupesobruto.DecimalPlaces = 2
        Me.nupesobruto.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupesobruto.Location = New System.Drawing.Point(727, 94)
        Me.nupesobruto.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.nupesobruto.Name = "nupesobruto"
        Me.nupesobruto.Size = New System.Drawing.Size(252, 44)
        Me.nupesobruto.TabIndex = 150
        Me.nupesobruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nupesobruto.ThousandsSeparator = True
        Me.nupesobruto.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(622, 196)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(89, 37)
        Me.label8.TabIndex = 149
        Me.label8.Text = "Neto"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(622, 146)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(88, 37)
        Me.label7.TabIndex = 148
        Me.label7.Text = "Tara"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(622, 96)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(99, 37)
        Me.label6.TabIndex = 147
        Me.label6.Text = "Bruto"
        '
        'dtfechaactualizacion
        '
        Me.dtfechaactualizacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtfechaactualizacion.CustomFormat = "dd/MM/yyyy hh:mm tt"
        Me.dtfechaactualizacion.Enabled = False
        Me.dtfechaactualizacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfechaactualizacion.Location = New System.Drawing.Point(956, 39)
        Me.dtfechaactualizacion.Name = "dtfechaactualizacion"
        Me.dtfechaactualizacion.Size = New System.Drawing.Size(158, 20)
        Me.dtfechaactualizacion.TabIndex = 141
        '
        'dtfechacreacion
        '
        Me.dtfechacreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtfechacreacion.CustomFormat = "dd/MM/yyyy hh:mm tt"
        Me.dtfechacreacion.Enabled = False
        Me.dtfechacreacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfechacreacion.Location = New System.Drawing.Point(956, 13)
        Me.dtfechacreacion.Name = "dtfechacreacion"
        Me.dtfechacreacion.Size = New System.Drawing.Size(158, 20)
        Me.dtfechacreacion.TabIndex = 140
        '
        'tbidsalida
        '
        Me.tbidsalida.Enabled = False
        Me.tbidsalida.Location = New System.Drawing.Point(116, 16)
        Me.tbidsalida.Name = "tbidsalida"
        Me.tbidsalida.ReadOnly = True
        Me.tbidsalida.Size = New System.Drawing.Size(63, 20)
        Me.tbidsalida.TabIndex = 125
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(3, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(18, 13)
        Me.label1.TabIndex = 126
        Me.label1.Text = "ID"
        '
        'mnustrip
        '
        Me.mnustrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.mnustrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nuevoToolStripMenuItem, Me.generaSalidaToolStripMenuItem, Me.guardarToolStripMenuItem, Me.consultarToolStripMenuItem, Me.cancelarToolStripMenuItem})
        Me.mnustrip.Location = New System.Drawing.Point(0, 0)
        Me.mnustrip.Name = "mnustrip"
        Me.mnustrip.Size = New System.Drawing.Size(1125, 24)
        Me.mnustrip.TabIndex = 138
        Me.mnustrip.Text = "menuStrip1"
        '
        'nuevoToolStripMenuItem
        '
        Me.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem"
        Me.nuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.nuevoToolStripMenuItem.Text = "Nuevo"
        '
        'generaSalidaToolStripMenuItem
        '
        Me.generaSalidaToolStripMenuItem.Name = "generaSalidaToolStripMenuItem"
        Me.generaSalidaToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.generaSalidaToolStripMenuItem.Text = "Genera Salida"
        '
        'guardarToolStripMenuItem
        '
        Me.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem"
        Me.guardarToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.guardarToolStripMenuItem.Text = "Guardar"
        Me.guardarToolStripMenuItem.Visible = False
        '
        'consultarToolStripMenuItem
        '
        Me.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem"
        Me.consultarToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.consultarToolStripMenuItem.Text = "Consultar"
        '
        'cancelarToolStripMenuItem
        '
        Me.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem"
        Me.cancelarToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.cancelarToolStripMenuItem.Text = "Cancelar"
        '
        'btconsultaorden
        '
        Me.btconsultaorden.BackColor = System.Drawing.Color.Transparent
        Me.btconsultaorden.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btconsultaorden.Image = Global.Capa_Presentacion.My.Resources.Resources.ICONO_CALCULA_COTTON_31_32px
        Me.btconsultaorden.ImageActive = Nothing
        Me.btconsultaorden.Location = New System.Drawing.Point(185, 37)
        Me.btconsultaorden.Name = "btconsultaorden"
        Me.btconsultaorden.Size = New System.Drawing.Size(25, 25)
        Me.btconsultaorden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btconsultaorden.TabIndex = 156
        Me.btconsultaorden.TabStop = False
        Me.btconsultaorden.Zoom = 15
        '
        'SalidaPacasOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 665)
        Me.Controls.Add(Me.tabpacas)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.mnustrip)
        Me.Name = "SalidaPacasOrden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Salidas Por Orden "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tabpacas.ResumeLayout(False)
        Me.tppacas.ResumeLayout(False)
        CType(Me.dgvpacaorigen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.nutotalkilos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nutotalpacas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupesoneto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupesotara, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nupesobruto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnustrip.ResumeLayout(False)
        Me.mnustrip.PerformLayout()
        CType(Me.btconsultaorden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents tabpacas As TabControl
    Private WithEvents tppacas As TabPage
    Private WithEvents dgvpacaorigen As DataGridView
    Private WithEvents panel2 As Panel
    Private WithEvents label16 As Label
    Private WithEvents label17 As Label
    Private WithEvents label18 As Label
    Private WithEvents nutotalkilos As NumericUpDown
    Private WithEvents label15 As Label
    Private WithEvents cbestatus As ComboBox
    Private WithEvents label14 As Label
    Private WithEvents label2 As Label
    Private WithEvents tbplacacaja As TextBox
    Private WithEvents tbplacatractocamion As TextBox
    Private WithEvents label3 As Label
    Private WithEvents tblicencia As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label5 As Label
    Private WithEvents tbdestino As TextBox
    Private WithEvents tbfoliosalida As TextBox
    Private WithEvents label10 As Label
    Private WithEvents tbtelefono As TextBox
    Private WithEvents label11 As Label
    Private WithEvents label12 As Label
    Private WithEvents tbnombretransportista As TextBox
    Private WithEvents tbobservaciones As TextBox
    Private WithEvents label20 As Label
    Private WithEvents nutotalpacas As NumericUpDown
    Private WithEvents label13 As Label
    Private WithEvents tbnombrecliente As TextBox
    Private WithEvents tbidcliente As TextBox
    Private WithEvents label19 As Label
    Private WithEvents btconsultaorden As Bunifu.Framework.UI.BunifuImageButton
    Private WithEvents tbidembarque As TextBox
    Private WithEvents label9 As Label
    Private WithEvents nupesoneto As NumericUpDown
    Private WithEvents nupesotara As NumericUpDown
    Private WithEvents nupesobruto As NumericUpDown
    Private WithEvents label8 As Label
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents dtfechaactualizacion As DateTimePicker
    Private WithEvents dtfechacreacion As DateTimePicker
    Private WithEvents tbidsalida As TextBox
    Private WithEvents label1 As Label
    Private WithEvents mnustrip As MenuStrip
    Private WithEvents nuevoToolStripMenuItem As ToolStripMenuItem
    Private WithEvents generaSalidaToolStripMenuItem As ToolStripMenuItem
    Private WithEvents guardarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents consultarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents cancelarToolStripMenuItem As ToolStripMenuItem
End Class
