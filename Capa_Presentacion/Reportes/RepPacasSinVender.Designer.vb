<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RepPacasSinVender
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepPacasSinVender))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportaAExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CbPlanta = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtConsultar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbClase = New System.Windows.Forms.ComboBox()
        Me.BtConsultarExcel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbCantidadPacas = New System.Windows.Forms.TextBox()
        Me.DgvPacasSinVender = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbRangoInicio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbRangoFin = New System.Windows.Forms.TextBox()
        Me.GbEncabezado = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DgvPacasSinVender, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbEncabezado.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarToolStripMenuItem, Me.ExportarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1045, 24)
        Me.MenuStrip1.TabIndex = 4
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
        'CbPlanta
        '
        Me.CbPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPlanta.FormattingEnabled = True
        Me.CbPlanta.Location = New System.Drawing.Point(57, 22)
        Me.CbPlanta.Name = "CbPlanta"
        Me.CbPlanta.Size = New System.Drawing.Size(121, 21)
        Me.CbPlanta.TabIndex = 5
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
        'BtConsultar
        '
        Me.BtConsultar.Location = New System.Drawing.Point(103, 306)
        Me.BtConsultar.Name = "BtConsultar"
        Me.BtConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtConsultar.TabIndex = 7
        Me.BtConsultar.Text = "Consultar"
        Me.BtConsultar.UseVisualStyleBackColor = True
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
        'CbClase
        '
        Me.CbClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbClase.FormattingEnabled = True
        Me.CbClase.Location = New System.Drawing.Point(57, 68)
        Me.CbClase.Name = "CbClase"
        Me.CbClase.Size = New System.Drawing.Size(121, 21)
        Me.CbClase.TabIndex = 9
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Consulta con Excel"
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
        'TbCantidadPacas
        '
        Me.TbCantidadPacas.Location = New System.Drawing.Point(112, 13)
        Me.TbCantidadPacas.Name = "TbCantidadPacas"
        Me.TbCantidadPacas.ReadOnly = True
        Me.TbCantidadPacas.Size = New System.Drawing.Size(121, 20)
        Me.TbCantidadPacas.TabIndex = 14
        '
        'DgvPacasSinVender
        '
        Me.DgvPacasSinVender.AllowUserToAddRows = False
        Me.DgvPacasSinVender.AllowUserToDeleteRows = False
        Me.DgvPacasSinVender.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacasSinVender.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvPacasSinVender.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvPacasSinVender.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvPacasSinVender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacasSinVender.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacasSinVender.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvPacasSinVender.Location = New System.Drawing.Point(0, 43)
        Me.DgvPacasSinVender.MultiSelect = False
        Me.DgvPacasSinVender.Name = "DgvPacasSinVender"
        Me.DgvPacasSinVender.ReadOnly = True
        Me.DgvPacasSinVender.RowHeadersVisible = False
        Me.DgvPacasSinVender.RowHeadersWidth = 40
        Me.DgvPacasSinVender.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPacasSinVender.Size = New System.Drawing.Size(841, 605)
        Me.DgvPacasSinVender.TabIndex = 15
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
        'TbRangoInicio
        '
        Me.TbRangoInicio.Location = New System.Drawing.Point(103, 122)
        Me.TbRangoInicio.Name = "TbRangoInicio"
        Me.TbRangoInicio.Size = New System.Drawing.Size(75, 20)
        Me.TbRangoInicio.TabIndex = 17
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
        'TbRangoFin
        '
        Me.TbRangoFin.Location = New System.Drawing.Point(103, 148)
        Me.TbRangoFin.Name = "TbRangoFin"
        Me.TbRangoFin.Size = New System.Drawing.Size(75, 20)
        Me.TbRangoFin.TabIndex = 18
        '
        'GbEncabezado
        '
        Me.GbEncabezado.Controls.Add(Me.TbCantidadPacas)
        Me.GbEncabezado.Controls.Add(Me.Label4)
        Me.GbEncabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbEncabezado.Location = New System.Drawing.Point(0, 0)
        Me.GbEncabezado.Name = "GbEncabezado"
        Me.GbEncabezado.Size = New System.Drawing.Size(841, 43)
        Me.GbEncabezado.TabIndex = 19
        Me.GbEncabezado.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DgvPacasSinVender)
        Me.Panel1.Controls.Add(Me.GbEncabezado)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(204, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(841, 648)
        Me.Panel1.TabIndex = 20
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
        Me.Panel2.Size = New System.Drawing.Size(204, 648)
        Me.Panel2.TabIndex = 21
        '
        'RepPacasSinVender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 672)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RepPacasSinVender"
        Me.Text = "Pacas sin vender"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DgvPacasSinVender, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbEncabezado.ResumeLayout(False)
        Me.GbEncabezado.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CbPlanta As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtConsultar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CbClase As ComboBox
    Friend WithEvents BtConsultarExcel As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TbCantidadPacas As TextBox
    Friend WithEvents ExportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportaAExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DgvPacasSinVender As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TbRangoInicio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbRangoFin As TextBox
    Friend WithEvents GbEncabezado As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
