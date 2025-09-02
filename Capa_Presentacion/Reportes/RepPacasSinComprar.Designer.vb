<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepPacasSinComprar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepPacasSinComprar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DgvPacasSinComprar = New System.Windows.Forms.DataGridView()
        Me.GbEncabezado = New System.Windows.Forms.GroupBox()
        Me.TbCantidadPacas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtConsultar = New System.Windows.Forms.Button()
        Me.CbPlanta = New System.Windows.Forms.ComboBox()
        Me.TbRangoFin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbRangoInicio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbClase = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportaAExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtConsultarExcel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvPacasSinComprar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbEncabezado.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DgvPacasSinComprar)
        Me.Panel1.Controls.Add(Me.GbEncabezado)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(204, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(894, 636)
        Me.Panel1.TabIndex = 23
        '
        'DgvPacasSinComprar
        '
        Me.DgvPacasSinComprar.AllowUserToAddRows = False
        Me.DgvPacasSinComprar.AllowUserToDeleteRows = False
        Me.DgvPacasSinComprar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacasSinComprar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvPacasSinComprar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvPacasSinComprar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvPacasSinComprar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacasSinComprar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacasSinComprar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvPacasSinComprar.Location = New System.Drawing.Point(0, 43)
        Me.DgvPacasSinComprar.MultiSelect = False
        Me.DgvPacasSinComprar.Name = "DgvPacasSinComprar"
        Me.DgvPacasSinComprar.ReadOnly = True
        Me.DgvPacasSinComprar.RowHeadersVisible = False
        Me.DgvPacasSinComprar.RowHeadersWidth = 40
        Me.DgvPacasSinComprar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPacasSinComprar.Size = New System.Drawing.Size(894, 593)
        Me.DgvPacasSinComprar.TabIndex = 15
        '
        'GbEncabezado
        '
        Me.GbEncabezado.Controls.Add(Me.TbCantidadPacas)
        Me.GbEncabezado.Controls.Add(Me.Label4)
        Me.GbEncabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbEncabezado.Location = New System.Drawing.Point(0, 0)
        Me.GbEncabezado.Name = "GbEncabezado"
        Me.GbEncabezado.Size = New System.Drawing.Size(894, 43)
        Me.GbEncabezado.TabIndex = 19
        Me.GbEncabezado.TabStop = False
        '
        'TbCantidadPacas
        '
        Me.TbCantidadPacas.Location = New System.Drawing.Point(112, 13)
        Me.TbCantidadPacas.Name = "TbCantidadPacas"
        Me.TbCantidadPacas.ReadOnly = True
        Me.TbCantidadPacas.Size = New System.Drawing.Size(121, 20)
        Me.TbCantidadPacas.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Cantidad de Pacas:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtConsultar)
        Me.Panel2.Controls.Add(Me.CbPlanta)
        Me.Panel2.Controls.Add(Me.TbRangoFin)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TbRangoInicio)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.CbClase)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.BtConsultarExcel)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(204, 636)
        Me.Panel2.TabIndex = 24
        '
        'BtConsultar
        '
        Me.BtConsultar.Location = New System.Drawing.Point(103, 306)
        Me.BtConsultar.Name = "BtConsultar"
        Me.BtConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtConsultar.TabIndex = 7
        Me.BtConsultar.Text = "Consultar"
        Me.BtConsultar.UseVisualStyleBackColor = True
        '
        'CbPlanta
        '
        Me.CbPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPlanta.FormattingEnabled = True
        Me.CbPlanta.Location = New System.Drawing.Point(57, 22)
        Me.CbPlanta.Name = "CbPlanta"
        Me.CbPlanta.Size = New System.Drawing.Size(121, 21)
        Me.CbPlanta.TabIndex = 5
        '
        'TbRangoFin
        '
        Me.TbRangoFin.Location = New System.Drawing.Point(83, 148)
        Me.TbRangoFin.MaxLength = 10
        Me.TbRangoFin.Name = "TbRangoFin"
        Me.TbRangoFin.Size = New System.Drawing.Size(95, 20)
        Me.TbRangoFin.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Planta"
        '
        'TbRangoInicio
        '
        Me.TbRangoInicio.Location = New System.Drawing.Point(83, 122)
        Me.TbRangoInicio.MaxLength = 10
        Me.TbRangoInicio.Name = "TbRangoInicio"
        Me.TbRangoInicio.Size = New System.Drawing.Size(95, 20)
        Me.TbRangoInicio.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Clase"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Hasta:"
        '
        'CbClase
        '
        Me.CbClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbClase.FormattingEnabled = True
        Me.CbClase.Location = New System.Drawing.Point(57, 68)
        Me.CbClase.Name = "CbClase"
        Me.CbClase.Size = New System.Drawing.Size(121, 21)
        Me.CbClase.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Paca inicial:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Consulta con Excel"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarToolStripMenuItem, Me.ExportarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1098, 24)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'ExportarToolStripMenuItem
        '
        Me.ExportarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportaAExcelToolStripMenuItem})
        Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.ExportarToolStripMenuItem.Text = "Exportar"
        '
        'ExportaAExcelToolStripMenuItem
        '
        Me.ExportaAExcelToolStripMenuItem.Name = "ExportaAExcelToolStripMenuItem"
        Me.ExportaAExcelToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ExportaAExcelToolStripMenuItem.Text = "Exporta a excel"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'BtConsultarExcel
        '
        Me.BtConsultarExcel.BackgroundImage = CType(resources.GetObject("BtConsultarExcel.BackgroundImage"), System.Drawing.Image)
        Me.BtConsultarExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtConsultarExcel.Location = New System.Drawing.Point(139, 216)
        Me.BtConsultarExcel.Name = "BtConsultarExcel"
        Me.BtConsultarExcel.Size = New System.Drawing.Size(39, 38)
        Me.BtConsultarExcel.TabIndex = 10
        Me.BtConsultarExcel.UseVisualStyleBackColor = True
        '
        'RepPacasSinComprar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 660)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "RepPacasSinComprar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pacas sin comprar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.DgvPacasSinComprar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbEncabezado.ResumeLayout(False)
        Me.GbEncabezado.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DgvPacasSinComprar As DataGridView
    Friend WithEvents GbEncabezado As GroupBox
    Friend WithEvents TbCantidadPacas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtConsultar As Button
    Friend WithEvents CbPlanta As ComboBox
    Friend WithEvents TbRangoFin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TbRangoInicio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CbClase As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtConsultarExcel As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportaAExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
