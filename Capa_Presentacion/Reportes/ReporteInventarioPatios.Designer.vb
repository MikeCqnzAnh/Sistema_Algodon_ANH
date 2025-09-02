<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteInventarioPatios
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LimpirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbcantidadpcas = New System.Windows.Forms.TextBox()
        Me.btimportaexcel = New System.Windows.Forms.Button()
        Me.dgvPacas = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbplantas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpirToolStripMenuItem, Me.ImprimirToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1038, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LimpirToolStripMenuItem
        '
        Me.LimpirToolStripMenuItem.Name = "LimpirToolStripMenuItem"
        Me.LimpirToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LimpirToolStripMenuItem.Text = "Limpiar"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cbplantas)
        Me.GroupBox1.Controls.Add(Me.tbcantidadpcas)
        Me.GroupBox1.Controls.Add(Me.btimportaexcel)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1038, 82)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'tbcantidadpcas
        '
        Me.tbcantidadpcas.Location = New System.Drawing.Point(112, 46)
        Me.tbcantidadpcas.Name = "tbcantidadpcas"
        Me.tbcantidadpcas.ReadOnly = True
        Me.tbcantidadpcas.Size = New System.Drawing.Size(143, 20)
        Me.tbcantidadpcas.TabIndex = 1
        '
        'btimportaexcel
        '
        Me.btimportaexcel.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.excel
        Me.btimportaexcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btimportaexcel.Location = New System.Drawing.Point(341, 19)
        Me.btimportaexcel.Name = "btimportaexcel"
        Me.btimportaexcel.Size = New System.Drawing.Size(51, 51)
        Me.btimportaexcel.TabIndex = 0
        Me.btimportaexcel.Text = ".."
        Me.btimportaexcel.UseVisualStyleBackColor = True
        '
        'dgvPacas
        '
        Me.dgvPacas.AllowUserToAddRows = False
        Me.dgvPacas.AllowUserToDeleteRows = False
        Me.dgvPacas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPacas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvPacas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgvPacas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPacas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPacas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvPacas.Location = New System.Drawing.Point(0, 106)
        Me.dgvPacas.MultiSelect = False
        Me.dgvPacas.Name = "dgvPacas"
        Me.dgvPacas.ReadOnly = True
        Me.dgvPacas.RowHeadersVisible = False
        Me.dgvPacas.RowHeadersWidth = 40
        Me.dgvPacas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPacas.Size = New System.Drawing.Size(1038, 519)
        Me.dgvPacas.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Planta"
        '
        'cbplantas
        '
        Me.cbplantas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbplantas.FormattingEnabled = True
        Me.cbplantas.Location = New System.Drawing.Point(112, 19)
        Me.cbplantas.Name = "cbplantas"
        Me.cbplantas.Size = New System.Drawing.Size(212, 21)
        Me.cbplantas.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Cantidad de Pacas"
        '
        'ReporteInventarioPatios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 625)
        Me.Controls.Add(Me.dgvPacas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ReporteInventarioPatios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "0,0"
        Me.Text = "Reporte para inventario de pacas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvPacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LimpirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvPacas As DataGridView
    Friend WithEvents btimportaexcel As Button
    Friend WithEvents tbcantidadpcas As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbplantas As ComboBox
    Friend WithEvents Label1 As Label
End Class
