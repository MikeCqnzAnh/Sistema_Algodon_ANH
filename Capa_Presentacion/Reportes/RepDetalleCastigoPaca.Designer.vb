<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepDetalleCastigoPaca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepDetalleCastigoPaca))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExportarAExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TbValorConversion = New System.Windows.Forms.TextBox()
        Me.CbUnidadPeso = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CbModoUniformidad = New System.Windows.Forms.ComboBox()
        Me.CbModoResistenciaFibra = New System.Windows.Forms.ComboBox()
        Me.CbModoLargoFibra = New System.Windows.Forms.ComboBox()
        Me.ChUniformidad = New System.Windows.Forms.CheckBox()
        Me.ChResistenciaFibra = New System.Windows.Forms.CheckBox()
        Me.ChLargoFibra = New System.Windows.Forms.CheckBox()
        Me.ChMicros = New System.Windows.Forms.CheckBox()
        Me.CbModoMicros = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbIdVenta = New System.Windows.Forms.TextBox()
        Me.DgvPacas = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportarAExcelToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1293, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TbValorConversion)
        Me.GroupBox1.Controls.Add(Me.CbUnidadPeso)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.CbModoUniformidad)
        Me.GroupBox1.Controls.Add(Me.CbModoResistenciaFibra)
        Me.GroupBox1.Controls.Add(Me.CbModoLargoFibra)
        Me.GroupBox1.Controls.Add(Me.ChUniformidad)
        Me.GroupBox1.Controls.Add(Me.ChResistenciaFibra)
        Me.GroupBox1.Controls.Add(Me.ChLargoFibra)
        Me.GroupBox1.Controls.Add(Me.ChMicros)
        Me.GroupBox1.Controls.Add(Me.CbModoMicros)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TbIdVenta)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1293, 193)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TbValorConversion
        '
        Me.TbValorConversion.Enabled = False
        Me.TbValorConversion.Location = New System.Drawing.Point(252, 153)
        Me.TbValorConversion.Name = "TbValorConversion"
        Me.TbValorConversion.Size = New System.Drawing.Size(75, 20)
        Me.TbValorConversion.TabIndex = 73
        '
        'CbUnidadPeso
        '
        Me.CbUnidadPeso.Enabled = False
        Me.CbUnidadPeso.FormattingEnabled = True
        Me.CbUnidadPeso.Location = New System.Drawing.Point(125, 152)
        Me.CbUnidadPeso.Name = "CbUnidadPeso"
        Me.CbUnidadPeso.Size = New System.Drawing.Size(121, 21)
        Me.CbUnidadPeso.TabIndex = 72
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(9, 156)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(83, 13)
        Me.Label21.TabIndex = 71
        Me.Label21.Text = "Unidad de Peso"
        '
        'CbModoUniformidad
        '
        Me.CbModoUniformidad.Enabled = False
        Me.CbModoUniformidad.FormattingEnabled = True
        Me.CbModoUniformidad.Location = New System.Drawing.Point(125, 125)
        Me.CbModoUniformidad.Name = "CbModoUniformidad"
        Me.CbModoUniformidad.Size = New System.Drawing.Size(121, 21)
        Me.CbModoUniformidad.TabIndex = 70
        '
        'CbModoResistenciaFibra
        '
        Me.CbModoResistenciaFibra.Enabled = False
        Me.CbModoResistenciaFibra.FormattingEnabled = True
        Me.CbModoResistenciaFibra.Location = New System.Drawing.Point(125, 101)
        Me.CbModoResistenciaFibra.Name = "CbModoResistenciaFibra"
        Me.CbModoResistenciaFibra.Size = New System.Drawing.Size(121, 21)
        Me.CbModoResistenciaFibra.TabIndex = 69
        '
        'CbModoLargoFibra
        '
        Me.CbModoLargoFibra.Enabled = False
        Me.CbModoLargoFibra.FormattingEnabled = True
        Me.CbModoLargoFibra.Location = New System.Drawing.Point(125, 77)
        Me.CbModoLargoFibra.Name = "CbModoLargoFibra"
        Me.CbModoLargoFibra.Size = New System.Drawing.Size(121, 21)
        Me.CbModoLargoFibra.TabIndex = 68
        '
        'ChUniformidad
        '
        Me.ChUniformidad.AutoSize = True
        Me.ChUniformidad.Enabled = False
        Me.ChUniformidad.Location = New System.Drawing.Point(12, 127)
        Me.ChUniformidad.Name = "ChUniformidad"
        Me.ChUniformidad.Size = New System.Drawing.Size(82, 17)
        Me.ChUniformidad.TabIndex = 67
        Me.ChUniformidad.Text = "Uniformidad"
        Me.ChUniformidad.UseVisualStyleBackColor = True
        '
        'ChResistenciaFibra
        '
        Me.ChResistenciaFibra.AutoSize = True
        Me.ChResistenciaFibra.Enabled = False
        Me.ChResistenciaFibra.Location = New System.Drawing.Point(12, 103)
        Me.ChResistenciaFibra.Name = "ChResistenciaFibra"
        Me.ChResistenciaFibra.Size = New System.Drawing.Size(107, 17)
        Me.ChResistenciaFibra.TabIndex = 66
        Me.ChResistenciaFibra.Text = "Resistencia Fibra"
        Me.ChResistenciaFibra.UseVisualStyleBackColor = True
        '
        'ChLargoFibra
        '
        Me.ChLargoFibra.AutoSize = True
        Me.ChLargoFibra.Enabled = False
        Me.ChLargoFibra.Location = New System.Drawing.Point(12, 79)
        Me.ChLargoFibra.Name = "ChLargoFibra"
        Me.ChLargoFibra.Size = New System.Drawing.Size(79, 17)
        Me.ChLargoFibra.TabIndex = 65
        Me.ChLargoFibra.Text = "Largo Fibra"
        Me.ChLargoFibra.UseVisualStyleBackColor = True
        '
        'ChMicros
        '
        Me.ChMicros.AutoSize = True
        Me.ChMicros.Enabled = False
        Me.ChMicros.Location = New System.Drawing.Point(12, 55)
        Me.ChMicros.Name = "ChMicros"
        Me.ChMicros.Size = New System.Drawing.Size(57, 17)
        Me.ChMicros.TabIndex = 64
        Me.ChMicros.Text = "Micros"
        Me.ChMicros.UseVisualStyleBackColor = True
        '
        'CbModoMicros
        '
        Me.CbModoMicros.Enabled = False
        Me.CbModoMicros.FormattingEnabled = True
        Me.CbModoMicros.Location = New System.Drawing.Point(125, 53)
        Me.CbModoMicros.Name = "CbModoMicros"
        Me.CbModoMicros.Size = New System.Drawing.Size(121, 21)
        Me.CbModoMicros.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID Venta"
        '
        'TbIdVenta
        '
        Me.TbIdVenta.Location = New System.Drawing.Point(64, 19)
        Me.TbIdVenta.Name = "TbIdVenta"
        Me.TbIdVenta.ReadOnly = True
        Me.TbIdVenta.Size = New System.Drawing.Size(100, 20)
        Me.TbIdVenta.TabIndex = 0
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
        Me.DgvPacas.Location = New System.Drawing.Point(0, 217)
        Me.DgvPacas.MultiSelect = False
        Me.DgvPacas.Name = "DgvPacas"
        Me.DgvPacas.ReadOnly = True
        Me.DgvPacas.RowHeadersVisible = False
        Me.DgvPacas.RowHeadersWidth = 40
        Me.DgvPacas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPacas.Size = New System.Drawing.Size(1293, 590)
        Me.DgvPacas.TabIndex = 14
        '
        'RepDetalleCastigoPaca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1293, 807)
        Me.Controls.Add(Me.DgvPacas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RepDetalleCastigoPaca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Castigo por Pacas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExportarAExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TbIdVenta As TextBox
    Friend WithEvents CbModoUniformidad As ComboBox
    Friend WithEvents CbModoResistenciaFibra As ComboBox
    Friend WithEvents CbModoLargoFibra As ComboBox
    Friend WithEvents ChUniformidad As CheckBox
    Friend WithEvents ChResistenciaFibra As CheckBox
    Friend WithEvents ChLargoFibra As CheckBox
    Friend WithEvents ChMicros As CheckBox
    Friend WithEvents CbModoMicros As ComboBox
    Friend WithEvents TbValorConversion As TextBox
    Friend WithEvents CbUnidadPeso As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents DgvPacas As DataGridView
End Class
