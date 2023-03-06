<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaReporteModulos
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
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbGenerales = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvModulos = New Capa_Presentacion.CapturaBoletasPorLotes.DgvPlusCapturaBoletas()
        Me.ExportaAExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSMenu.SuspendLayout()
        Me.GbGenerales.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvModulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ExportaAExcelToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(950, 24)
        Me.MSMenu.TabIndex = 1
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'GbGenerales
        '
        Me.GbGenerales.Controls.Add(Me.Label2)
        Me.GbGenerales.Controls.Add(Me.Label1)
        Me.GbGenerales.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbGenerales.Location = New System.Drawing.Point(0, 24)
        Me.GbGenerales.Name = "GbGenerales"
        Me.GbGenerales.Size = New System.Drawing.Size(950, 102)
        Me.GbGenerales.TabIndex = 31
        Me.GbGenerales.TabStop = False
        Me.GbGenerales.Text = "Datos Generales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Puerto Serial"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 63
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvModulos)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(950, 500)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion"
        '
        'DgvModulos
        '
        Me.DgvModulos.AllowUserToAddRows = False
        Me.DgvModulos.AllowUserToDeleteRows = False
        Me.DgvModulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvModulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvModulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvModulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvModulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvModulos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvModulos.Location = New System.Drawing.Point(3, 16)
        Me.DgvModulos.MultiSelect = False
        Me.DgvModulos.Name = "DgvModulos"
        Me.DgvModulos.RowHeadersVisible = False
        Me.DgvModulos.RowHeadersWidth = 40
        Me.DgvModulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvModulos.Size = New System.Drawing.Size(944, 481)
        Me.DgvModulos.TabIndex = 30
        '
        'ExportaAExcelToolStripMenuItem
        '
        Me.ExportaAExcelToolStripMenuItem.Name = "ExportaAExcelToolStripMenuItem"
        Me.ExportaAExcelToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.ExportaAExcelToolStripMenuItem.Text = "Exporta a Excel"
        '
        'ConsultaReporteModulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(950, 626)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GbGenerales)
        Me.Controls.Add(Me.MSMenu)
        Me.Name = "ConsultaReporteModulos"
        Me.Text = "Consulta Reporte de Modulos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GbGenerales.ResumeLayout(False)
        Me.GbGenerales.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvModulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GbGenerales As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend DgvModulos As CapturaBoletasPorLotes.DgvPlusCapturaBoletas
    Friend WithEvents ExportaAExcelToolStripMenuItem As ToolStripMenuItem
End Class
