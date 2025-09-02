<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventarioPacas
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
        Me.gbdatos = New System.Windows.Forms.GroupBox()
        Me.tbidcomprador = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbcomprador = New System.Windows.Forms.TextBox()
        Me.btbuscar = New System.Windows.Forms.Button()
        Me.tblotesexistentes = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tblotesembarcados = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbpacasenpatio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbpacasembarcadas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbcantidadlotescompradas = New System.Windows.Forms.TextBox()
        Me.tbcantidadpacascompradas = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tclotes = New System.Windows.Forms.TabControl()
        Me.tppacaporlote = New System.Windows.Forms.TabPage()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.tppacas = New System.Windows.Forms.TabPage()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.DgvPacas = New System.Windows.Forms.DataGridView()
        Me.dgvlotes = New System.Windows.Forms.DataGridView()
        Me.cbplantas = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cblotes = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cksincomprador = New System.Windows.Forms.CheckBox()
        Me.ckSinlote = New System.Windows.Forms.CheckBox()
        Me.ExportarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbconsultarcomprador = New System.Windows.Forms.Button()
        Me.FormatoInventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbdatos.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.tclotes.SuspendLayout()
        Me.tppacaporlote.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.tppacas.SuspendLayout()
        Me.MenuStrip3.SuspendLayout()
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvlotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbdatos
        '
        Me.gbdatos.Controls.Add(Me.ckSinlote)
        Me.gbdatos.Controls.Add(Me.cksincomprador)
        Me.gbdatos.Controls.Add(Me.Label9)
        Me.gbdatos.Controls.Add(Me.cblotes)
        Me.gbdatos.Controls.Add(Me.Label8)
        Me.gbdatos.Controls.Add(Me.cbplantas)
        Me.gbdatos.Controls.Add(Me.tbidcomprador)
        Me.gbdatos.Controls.Add(Me.Label1)
        Me.gbdatos.Controls.Add(Me.tbconsultarcomprador)
        Me.gbdatos.Controls.Add(Me.tbcomprador)
        Me.gbdatos.Controls.Add(Me.btbuscar)
        Me.gbdatos.Controls.Add(Me.tblotesexistentes)
        Me.gbdatos.Controls.Add(Me.Label7)
        Me.gbdatos.Controls.Add(Me.tblotesembarcados)
        Me.gbdatos.Controls.Add(Me.Label6)
        Me.gbdatos.Controls.Add(Me.tbpacasenpatio)
        Me.gbdatos.Controls.Add(Me.Label5)
        Me.gbdatos.Controls.Add(Me.tbpacasembarcadas)
        Me.gbdatos.Controls.Add(Me.Label4)
        Me.gbdatos.Controls.Add(Me.Label3)
        Me.gbdatos.Controls.Add(Me.Label2)
        Me.gbdatos.Controls.Add(Me.tbcantidadlotescompradas)
        Me.gbdatos.Controls.Add(Me.tbcantidadpacascompradas)
        Me.gbdatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbdatos.Location = New System.Drawing.Point(0, 24)
        Me.gbdatos.Name = "gbdatos"
        Me.gbdatos.Size = New System.Drawing.Size(1268, 147)
        Me.gbdatos.TabIndex = 0
        Me.gbdatos.TabStop = False
        '
        'tbidcomprador
        '
        Me.tbidcomprador.Location = New System.Drawing.Point(70, 25)
        Me.tbidcomprador.Name = "tbidcomprador"
        Me.tbidcomprador.ReadOnly = True
        Me.tbidcomprador.Size = New System.Drawing.Size(70, 20)
        Me.tbidcomprador.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Comprador"
        '
        'tbcomprador
        '
        Me.tbcomprador.Location = New System.Drawing.Point(146, 25)
        Me.tbcomprador.Name = "tbcomprador"
        Me.tbcomprador.ReadOnly = True
        Me.tbcomprador.Size = New System.Drawing.Size(382, 20)
        Me.tbcomprador.TabIndex = 19
        '
        'btbuscar
        '
        Me.btbuscar.Location = New System.Drawing.Point(1132, 70)
        Me.btbuscar.Name = "btbuscar"
        Me.btbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btbuscar.TabIndex = 20
        Me.btbuscar.Text = "Buscar"
        Me.btbuscar.UseVisualStyleBackColor = True
        '
        'tblotesexistentes
        '
        Me.tblotesexistentes.Location = New System.Drawing.Point(1134, 105)
        Me.tblotesexistentes.Name = "tblotesexistentes"
        Me.tblotesexistentes.ReadOnly = True
        Me.tblotesexistentes.Size = New System.Drawing.Size(100, 20)
        Me.tblotesexistentes.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1036, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Lotes en Patio:"
        '
        'tblotesembarcados
        '
        Me.tblotesembarcados.Location = New System.Drawing.Point(930, 105)
        Me.tblotesembarcados.Name = "tblotesembarcados"
        Me.tblotesembarcados.ReadOnly = True
        Me.tblotesembarcados.Size = New System.Drawing.Size(100, 20)
        Me.tblotesembarcados.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(826, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Lotes Embarcados:"
        '
        'tbpacasenpatio
        '
        Me.tbpacasenpatio.Location = New System.Drawing.Point(720, 105)
        Me.tbpacasenpatio.Name = "tbpacasenpatio"
        Me.tbpacasenpatio.ReadOnly = True
        Me.tbpacasenpatio.Size = New System.Drawing.Size(100, 20)
        Me.tbpacasenpatio.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(632, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Pacas en Patio:"
        '
        'tbpacasembarcadas
        '
        Me.tbpacasembarcadas.Location = New System.Drawing.Point(526, 105)
        Me.tbpacasembarcadas.Name = "tbpacasembarcadas"
        Me.tbpacasembarcadas.ReadOnly = True
        Me.tbpacasembarcadas.Size = New System.Drawing.Size(100, 20)
        Me.tbpacasembarcadas.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(418, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Pacas Embarcadas:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(210, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Pacas Compradas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Lotes Comprados:"
        '
        'tbcantidadlotescompradas
        '
        Me.tbcantidadlotescompradas.Location = New System.Drawing.Point(104, 105)
        Me.tbcantidadlotescompradas.Name = "tbcantidadlotescompradas"
        Me.tbcantidadlotescompradas.ReadOnly = True
        Me.tbcantidadlotescompradas.Size = New System.Drawing.Size(100, 20)
        Me.tbcantidadlotescompradas.TabIndex = 7
        '
        'tbcantidadpacascompradas
        '
        Me.tbcantidadpacascompradas.Location = New System.Drawing.Point(312, 105)
        Me.tbcantidadpacascompradas.Name = "tbcantidadpacascompradas"
        Me.tbcantidadpacascompradas.ReadOnly = True
        Me.tbcantidadpacascompradas.Size = New System.Drawing.Size(100, 20)
        Me.tbcantidadpacascompradas.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.FormatoInventarioToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1268, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.NuevoToolStripMenuItem.Text = "Limpiar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'tclotes
        '
        Me.tclotes.Controls.Add(Me.tppacaporlote)
        Me.tclotes.Controls.Add(Me.tppacas)
        Me.tclotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tclotes.Location = New System.Drawing.Point(0, 171)
        Me.tclotes.Name = "tclotes"
        Me.tclotes.SelectedIndex = 0
        Me.tclotes.Size = New System.Drawing.Size(1268, 549)
        Me.tclotes.TabIndex = 2
        '
        'tppacaporlote
        '
        Me.tppacaporlote.Controls.Add(Me.dgvlotes)
        Me.tppacaporlote.Controls.Add(Me.MenuStrip2)
        Me.tppacaporlote.Location = New System.Drawing.Point(4, 22)
        Me.tppacaporlote.Name = "tppacaporlote"
        Me.tppacaporlote.Padding = New System.Windows.Forms.Padding(3)
        Me.tppacaporlote.Size = New System.Drawing.Size(1260, 523)
        Me.tppacaporlote.TabIndex = 0
        Me.tppacaporlote.Text = "Lotes "
        Me.tppacaporlote.UseVisualStyleBackColor = True
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportarToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(3, 3)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1254, 24)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'tppacas
        '
        Me.tppacas.Controls.Add(Me.DgvPacas)
        Me.tppacas.Controls.Add(Me.MenuStrip3)
        Me.tppacas.Location = New System.Drawing.Point(4, 22)
        Me.tppacas.Name = "tppacas"
        Me.tppacas.Padding = New System.Windows.Forms.Padding(3)
        Me.tppacas.Size = New System.Drawing.Size(1260, 523)
        Me.tppacas.TabIndex = 1
        Me.tppacas.Text = "Pacas"
        Me.tppacas.UseVisualStyleBackColor = True
        '
        'MenuStrip3
        '
        Me.MenuStrip3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportarToolStripMenuItem2})
        Me.MenuStrip3.Location = New System.Drawing.Point(3, 3)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(1254, 24)
        Me.MenuStrip3.TabIndex = 1
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'DgvPacas
        '
        Me.DgvPacas.AllowUserToAddRows = False
        Me.DgvPacas.AllowUserToDeleteRows = False
        Me.DgvPacas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvPacas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvPacas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvPacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvPacas.Location = New System.Drawing.Point(3, 27)
        Me.DgvPacas.MultiSelect = False
        Me.DgvPacas.Name = "DgvPacas"
        Me.DgvPacas.ReadOnly = True
        Me.DgvPacas.RowHeadersVisible = False
        Me.DgvPacas.RowHeadersWidth = 40
        Me.DgvPacas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPacas.Size = New System.Drawing.Size(1254, 493)
        Me.DgvPacas.TabIndex = 15
        '
        'dgvlotes
        '
        Me.dgvlotes.AllowUserToAddRows = False
        Me.dgvlotes.AllowUserToDeleteRows = False
        Me.dgvlotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvlotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvlotes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgvlotes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvlotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvlotes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvlotes.Location = New System.Drawing.Point(3, 27)
        Me.dgvlotes.MultiSelect = False
        Me.dgvlotes.Name = "dgvlotes"
        Me.dgvlotes.ReadOnly = True
        Me.dgvlotes.RowHeadersVisible = False
        Me.dgvlotes.RowHeadersWidth = 40
        Me.dgvlotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvlotes.Size = New System.Drawing.Size(1254, 493)
        Me.dgvlotes.TabIndex = 14
        '
        'cbplantas
        '
        Me.cbplantas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbplantas.FormattingEnabled = True
        Me.cbplantas.Location = New System.Drawing.Point(316, 51)
        Me.cbplantas.Name = "cbplantas"
        Me.cbplantas.Size = New System.Drawing.Size(212, 21)
        Me.cbplantas.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(252, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Planta"
        '
        'cblotes
        '
        Me.cblotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cblotes.FormattingEnabled = True
        Me.cblotes.Location = New System.Drawing.Point(70, 51)
        Me.cblotes.Name = "cblotes"
        Me.cblotes.Size = New System.Drawing.Size(134, 21)
        Me.cblotes.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Lotes"
        '
        'cksincomprador
        '
        Me.cksincomprador.AutoSize = True
        Me.cksincomprador.Location = New System.Drawing.Point(611, 28)
        Me.cksincomprador.Name = "cksincomprador"
        Me.cksincomprador.Size = New System.Drawing.Size(95, 17)
        Me.cksincomprador.TabIndex = 29
        Me.cksincomprador.Text = "Sin Comprador"
        Me.cksincomprador.UseVisualStyleBackColor = True
        '
        'ckSinlote
        '
        Me.ckSinlote.AutoSize = True
        Me.ckSinlote.Location = New System.Drawing.Point(720, 28)
        Me.ckSinlote.Name = "ckSinlote"
        Me.ckSinlote.Size = New System.Drawing.Size(65, 17)
        Me.ckSinlote.TabIndex = 30
        Me.ckSinlote.Text = "Sin Lote"
        Me.ckSinlote.UseVisualStyleBackColor = True
        '
        'ExportarToolStripMenuItem1
        '
        Me.ExportarToolStripMenuItem1.Image = Global.Capa_Presentacion.My.Resources.Resources.excel
        Me.ExportarToolStripMenuItem1.Name = "ExportarToolStripMenuItem1"
        Me.ExportarToolStripMenuItem1.Size = New System.Drawing.Size(79, 20)
        Me.ExportarToolStripMenuItem1.Text = "Exportar"
        '
        'ExportarToolStripMenuItem2
        '
        Me.ExportarToolStripMenuItem2.Image = Global.Capa_Presentacion.My.Resources.Resources.excel
        Me.ExportarToolStripMenuItem2.Name = "ExportarToolStripMenuItem2"
        Me.ExportarToolStripMenuItem2.Size = New System.Drawing.Size(79, 20)
        Me.ExportarToolStripMenuItem2.Text = "Exportar"
        '
        'tbconsultarcomprador
        '
        Me.tbconsultarcomprador.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.clienteadd
        Me.tbconsultarcomprador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tbconsultarcomprador.Location = New System.Drawing.Point(534, 15)
        Me.tbconsultarcomprador.Name = "tbconsultarcomprador"
        Me.tbconsultarcomprador.Size = New System.Drawing.Size(30, 30)
        Me.tbconsultarcomprador.TabIndex = 23
        Me.tbconsultarcomprador.UseVisualStyleBackColor = True
        '
        'FormatoInventarioToolStripMenuItem
        '
        Me.FormatoInventarioToolStripMenuItem.Name = "FormatoInventarioToolStripMenuItem"
        Me.FormatoInventarioToolStripMenuItem.Size = New System.Drawing.Size(120, 20)
        Me.FormatoInventarioToolStripMenuItem.Text = "Formato inventario"
        '
        'InventarioPacas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 720)
        Me.Controls.Add(Me.tclotes)
        Me.Controls.Add(Me.gbdatos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "InventarioPacas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "0,0"
        Me.Text = "Inventario de Pacas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbdatos.ResumeLayout(False)
        Me.gbdatos.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tclotes.ResumeLayout(False)
        Me.tppacaporlote.ResumeLayout(False)
        Me.tppacaporlote.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.tppacas.ResumeLayout(False)
        Me.tppacas.PerformLayout()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvlotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbdatos As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbcantidadlotescompradas As TextBox
    Friend WithEvents tbcantidadpacascompradas As TextBox
    Friend WithEvents tbpacasenpatio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbpacasembarcadas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tblotesexistentes As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tblotesembarcados As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbconsultarcomprador As Button
    Friend WithEvents tbcomprador As TextBox
    Friend WithEvents btbuscar As Button
    Friend WithEvents tclotes As TabControl
    Friend WithEvents tppacaporlote As TabPage
    Friend WithEvents tppacas As TabPage
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ExportarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents tbidcomprador As TextBox
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents ExportarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents DgvPacas As DataGridView
    Friend WithEvents dgvlotes As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents cbplantas As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cblotes As ComboBox
    Friend WithEvents ckSinlote As CheckBox
    Friend WithEvents cksincomprador As CheckBox
    Friend WithEvents FormatoInventarioToolStripMenuItem As ToolStripMenuItem
End Class
