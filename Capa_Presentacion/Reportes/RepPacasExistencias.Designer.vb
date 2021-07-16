<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RepPacasExistencias
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CkExistencias = New System.Windows.Forms.CheckBox()
        Me.CkSalidas = New System.Windows.Forms.CheckBox()
        Me.CkSinVender = New System.Windows.Forms.CheckBox()
        Me.CkVendidas = New System.Windows.Forms.CheckBox()
        Me.CkSinComprar = New System.Windows.Forms.CheckBox()
        Me.CkCompradas = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbIdSalida = New System.Windows.Forms.TextBox()
        Me.TbIdEmbarque = New System.Windows.Forms.TextBox()
        Me.TbIdPaqVenta = New System.Windows.Forms.TextBox()
        Me.TbIdVenta = New System.Windows.Forms.TextBox()
        Me.TbIdCompra = New System.Windows.Forms.TextBox()
        Me.GbTotales = New System.Windows.Forms.GroupBox()
        Me.DgvPacas = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarAExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CRVReporteExistencias = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbIdProductor = New System.Windows.Forms.TextBox()
        Me.TbProductor = New System.Windows.Forms.TextBox()
        Me.TbIdComprador = New System.Windows.Forms.TextBox()
        Me.TbComprador = New System.Windows.Forms.TextBox()
        Me.BtProductor = New System.Windows.Forms.Button()
        Me.BtComprador = New System.Windows.Forms.Button()
        Me.CkEmbarques = New System.Windows.Forms.CheckBox()
        Me.CkSinEmbarque = New System.Windows.Forms.CheckBox()
        Me.CbPlanta = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GbTotales.SuspendLayout()
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.CbPlanta)
        Me.Panel1.Controls.Add(Me.CkSinEmbarque)
        Me.Panel1.Controls.Add(Me.CkEmbarques)
        Me.Panel1.Controls.Add(Me.BtComprador)
        Me.Panel1.Controls.Add(Me.BtProductor)
        Me.Panel1.Controls.Add(Me.TbComprador)
        Me.Panel1.Controls.Add(Me.TbIdComprador)
        Me.Panel1.Controls.Add(Me.TbProductor)
        Me.Panel1.Controls.Add(Me.TbIdProductor)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.CkExistencias)
        Me.Panel1.Controls.Add(Me.CkSalidas)
        Me.Panel1.Controls.Add(Me.CkSinVender)
        Me.Panel1.Controls.Add(Me.CkVendidas)
        Me.Panel1.Controls.Add(Me.CkSinComprar)
        Me.Panel1.Controls.Add(Me.CkCompradas)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TbIdSalida)
        Me.Panel1.Controls.Add(Me.TbIdEmbarque)
        Me.Panel1.Controls.Add(Me.TbIdPaqVenta)
        Me.Panel1.Controls.Add(Me.TbIdVenta)
        Me.Panel1.Controls.Add(Me.TbIdCompra)
        Me.Panel1.Controls.Add(Me.GbTotales)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1458, 218)
        Me.Panel1.TabIndex = 0
        '
        'CkExistencias
        '
        Me.CkExistencias.AutoSize = True
        Me.CkExistencias.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CkExistencias.Location = New System.Drawing.Point(354, 99)
        Me.CkExistencias.Name = "CkExistencias"
        Me.CkExistencias.Size = New System.Drawing.Size(79, 17)
        Me.CkExistencias.TabIndex = 27
        Me.CkExistencias.Text = "Existencias"
        Me.CkExistencias.UseVisualStyleBackColor = True
        '
        'CkSalidas
        '
        Me.CkSalidas.AutoSize = True
        Me.CkSalidas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CkSalidas.Location = New System.Drawing.Point(278, 99)
        Me.CkSalidas.Name = "CkSalidas"
        Me.CkSalidas.Size = New System.Drawing.Size(60, 17)
        Me.CkSalidas.TabIndex = 26
        Me.CkSalidas.Text = "Salidas"
        Me.CkSalidas.UseVisualStyleBackColor = True
        '
        'CkSinVender
        '
        Me.CkSinVender.AutoSize = True
        Me.CkSinVender.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CkSinVender.Location = New System.Drawing.Point(355, 53)
        Me.CkSinVender.Name = "CkSinVender"
        Me.CkSinVender.Size = New System.Drawing.Size(78, 17)
        Me.CkSinVender.TabIndex = 25
        Me.CkSinVender.Text = "Sin Vender"
        Me.CkSinVender.UseVisualStyleBackColor = True
        '
        'CkVendidas
        '
        Me.CkVendidas.AutoSize = True
        Me.CkVendidas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CkVendidas.Location = New System.Drawing.Point(268, 53)
        Me.CkVendidas.Name = "CkVendidas"
        Me.CkVendidas.Size = New System.Drawing.Size(70, 17)
        Me.CkVendidas.TabIndex = 24
        Me.CkVendidas.Text = "Vendidas"
        Me.CkVendidas.UseVisualStyleBackColor = True
        '
        'CkSinComprar
        '
        Me.CkSinComprar.AutoSize = True
        Me.CkSinComprar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CkSinComprar.Location = New System.Drawing.Point(350, 30)
        Me.CkSinComprar.Name = "CkSinComprar"
        Me.CkSinComprar.Size = New System.Drawing.Size(83, 17)
        Me.CkSinComprar.TabIndex = 23
        Me.CkSinComprar.Text = "Sin Comprar"
        Me.CkSinComprar.UseVisualStyleBackColor = True
        '
        'CkCompradas
        '
        Me.CkCompradas.AutoSize = True
        Me.CkCompradas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CkCompradas.Location = New System.Drawing.Point(259, 30)
        Me.CkCompradas.Name = "CkCompradas"
        Me.CkCompradas.Size = New System.Drawing.Size(79, 17)
        Me.CkCompradas.TabIndex = 22
        Me.CkCompradas.Text = "Compradas"
        Me.CkCompradas.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "ID Salida"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "ID Embarque"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "ID Paq Venta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "ID Venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "ID Compra"
        '
        'TbIdSalida
        '
        Me.TbIdSalida.Location = New System.Drawing.Point(92, 131)
        Me.TbIdSalida.Name = "TbIdSalida"
        Me.TbIdSalida.Size = New System.Drawing.Size(59, 20)
        Me.TbIdSalida.TabIndex = 5
        '
        'TbIdEmbarque
        '
        Me.TbIdEmbarque.Location = New System.Drawing.Point(92, 105)
        Me.TbIdEmbarque.Name = "TbIdEmbarque"
        Me.TbIdEmbarque.Size = New System.Drawing.Size(59, 20)
        Me.TbIdEmbarque.TabIndex = 4
        '
        'TbIdPaqVenta
        '
        Me.TbIdPaqVenta.Location = New System.Drawing.Point(92, 79)
        Me.TbIdPaqVenta.Name = "TbIdPaqVenta"
        Me.TbIdPaqVenta.Size = New System.Drawing.Size(59, 20)
        Me.TbIdPaqVenta.TabIndex = 3
        '
        'TbIdVenta
        '
        Me.TbIdVenta.Location = New System.Drawing.Point(92, 53)
        Me.TbIdVenta.Name = "TbIdVenta"
        Me.TbIdVenta.Size = New System.Drawing.Size(59, 20)
        Me.TbIdVenta.TabIndex = 2
        '
        'TbIdCompra
        '
        Me.TbIdCompra.Location = New System.Drawing.Point(92, 27)
        Me.TbIdCompra.Name = "TbIdCompra"
        Me.TbIdCompra.Size = New System.Drawing.Size(59, 20)
        Me.TbIdCompra.TabIndex = 1
        '
        'GbTotales
        '
        Me.GbTotales.Controls.Add(Me.DgvPacas)
        Me.GbTotales.Dock = System.Windows.Forms.DockStyle.Right
        Me.GbTotales.Location = New System.Drawing.Point(593, 24)
        Me.GbTotales.Name = "GbTotales"
        Me.GbTotales.Size = New System.Drawing.Size(865, 194)
        Me.GbTotales.TabIndex = 9
        Me.GbTotales.TabStop = False
        Me.GbTotales.Text = "Informacion de Pacas"
        '
        'DgvPacas
        '
        Me.DgvPacas.AllowUserToAddRows = False
        Me.DgvPacas.AllowUserToDeleteRows = False
        Me.DgvPacas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvPacas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DgvPacas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvPacas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvPacas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvPacas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvPacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvPacas.Location = New System.Drawing.Point(3, 16)
        Me.DgvPacas.MultiSelect = False
        Me.DgvPacas.Name = "DgvPacas"
        Me.DgvPacas.ReadOnly = True
        Me.DgvPacas.RowHeadersVisible = False
        Me.DgvPacas.RowHeadersWidth = 40
        Me.DgvPacas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPacas.Size = New System.Drawing.Size(859, 175)
        Me.DgvPacas.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.ExportarAExcelToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1458, 24)
        Me.MenuStrip1.TabIndex = 0
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
        'ExportarAExcelToolStripMenuItem
        '
        Me.ExportarAExcelToolStripMenuItem.Name = "ExportarAExcelToolStripMenuItem"
        Me.ExportarAExcelToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.ExportarAExcelToolStripMenuItem.Text = "Exportar a Excel"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'CRVReporteExistencias
        '
        Me.CRVReporteExistencias.ActiveViewIndex = -1
        Me.CRVReporteExistencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVReporteExistencias.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVReporteExistencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVReporteExistencias.Location = New System.Drawing.Point(0, 218)
        Me.CRVReporteExistencias.Name = "CRVReporteExistencias"
        Me.CRVReporteExistencias.ShowCloseButton = False
        Me.CRVReporteExistencias.ShowCopyButton = False
        Me.CRVReporteExistencias.ShowGroupTreeButton = False
        Me.CRVReporteExistencias.ShowLogo = False
        Me.CRVReporteExistencias.ShowParameterPanelButton = False
        Me.CRVReporteExistencias.ShowRefreshButton = False
        Me.CRVReporteExistencias.Size = New System.Drawing.Size(1458, 488)
        Me.CRVReporteExistencias.TabIndex = 1
        Me.CRVReporteExistencias.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Productor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Comprador"
        '
        'TbIdProductor
        '
        Me.TbIdProductor.Enabled = False
        Me.TbIdProductor.Location = New System.Drawing.Point(92, 157)
        Me.TbIdProductor.Name = "TbIdProductor"
        Me.TbIdProductor.Size = New System.Drawing.Size(59, 20)
        Me.TbIdProductor.TabIndex = 30
        '
        'TbProductor
        '
        Me.TbProductor.Enabled = False
        Me.TbProductor.Location = New System.Drawing.Point(157, 157)
        Me.TbProductor.Name = "TbProductor"
        Me.TbProductor.Size = New System.Drawing.Size(385, 20)
        Me.TbProductor.TabIndex = 31
        '
        'TbIdComprador
        '
        Me.TbIdComprador.Enabled = False
        Me.TbIdComprador.Location = New System.Drawing.Point(92, 183)
        Me.TbIdComprador.Name = "TbIdComprador"
        Me.TbIdComprador.Size = New System.Drawing.Size(59, 20)
        Me.TbIdComprador.TabIndex = 32
        '
        'TbComprador
        '
        Me.TbComprador.Enabled = False
        Me.TbComprador.Location = New System.Drawing.Point(157, 183)
        Me.TbComprador.Name = "TbComprador"
        Me.TbComprador.Size = New System.Drawing.Size(385, 20)
        Me.TbComprador.TabIndex = 33
        '
        'BtProductor
        '
        Me.BtProductor.Location = New System.Drawing.Point(548, 157)
        Me.BtProductor.Name = "BtProductor"
        Me.BtProductor.Size = New System.Drawing.Size(30, 20)
        Me.BtProductor.TabIndex = 34
        Me.BtProductor.Text = "..."
        Me.BtProductor.UseVisualStyleBackColor = True
        '
        'BtComprador
        '
        Me.BtComprador.Location = New System.Drawing.Point(548, 183)
        Me.BtComprador.Name = "BtComprador"
        Me.BtComprador.Size = New System.Drawing.Size(30, 20)
        Me.BtComprador.TabIndex = 35
        Me.BtComprador.Text = "..."
        Me.BtComprador.UseVisualStyleBackColor = True
        '
        'CkEmbarques
        '
        Me.CkEmbarques.AutoSize = True
        Me.CkEmbarques.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CkEmbarques.Location = New System.Drawing.Point(259, 76)
        Me.CkEmbarques.Name = "CkEmbarques"
        Me.CkEmbarques.Size = New System.Drawing.Size(79, 17)
        Me.CkEmbarques.TabIndex = 36
        Me.CkEmbarques.Text = "Embarques"
        Me.CkEmbarques.UseVisualStyleBackColor = True
        '
        'CkSinEmbarque
        '
        Me.CkSinEmbarque.AutoSize = True
        Me.CkSinEmbarque.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CkSinEmbarque.Location = New System.Drawing.Point(341, 76)
        Me.CkSinEmbarque.Name = "CkSinEmbarque"
        Me.CkSinEmbarque.Size = New System.Drawing.Size(92, 17)
        Me.CkSinEmbarque.TabIndex = 37
        Me.CkSinEmbarque.Text = "Sin Embarque"
        Me.CkSinEmbarque.UseVisualStyleBackColor = True
        '
        'CbPlanta
        '
        Me.CbPlanta.FormattingEnabled = True
        Me.CbPlanta.Location = New System.Drawing.Point(200, 131)
        Me.CbPlanta.Name = "CbPlanta"
        Me.CbPlanta.Size = New System.Drawing.Size(121, 21)
        Me.CbPlanta.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(157, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Planta"
        '
        'RepPacasExistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1458, 706)
        Me.Controls.Add(Me.CRVReporteExistencias)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RepPacasExistencias"
        Me.Text = "Existencias"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GbTotales.ResumeLayout(False)
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CRVReporteExistencias As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DgvPacas As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GbTotales As GroupBox
    Friend WithEvents ExportarAExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TbIdEmbarque As TextBox
    Friend WithEvents TbIdPaqVenta As TextBox
    Friend WithEvents TbIdVenta As TextBox
    Friend WithEvents TbIdCompra As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TbIdSalida As TextBox
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CkExistencias As CheckBox
    Friend WithEvents CkSalidas As CheckBox
    Friend WithEvents CkSinVender As CheckBox
    Friend WithEvents CkVendidas As CheckBox
    Friend WithEvents CkSinComprar As CheckBox
    Friend WithEvents CkCompradas As CheckBox
    Friend WithEvents TbComprador As TextBox
    Friend WithEvents TbIdComprador As TextBox
    Friend WithEvents TbProductor As TextBox
    Friend WithEvents TbIdProductor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtComprador As Button
    Friend WithEvents BtProductor As Button
    Friend WithEvents CkSinEmbarque As CheckBox
    Friend WithEvents CkEmbarques As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CbPlanta As ComboBox
End Class
