<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bitacora
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PDatos = New System.Windows.Forms.Panel()
        Me.DgvBitacora = New System.Windows.Forms.DataGridView()
        Me.GbFiltros = New System.Windows.Forms.GroupBox()
        Me.BtConsulta = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.DtFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LimpiarCamposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarBitacoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PDatos.SuspendLayout()
        CType(Me.DgvBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbFiltros.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PDatos
        '
        Me.PDatos.Controls.Add(Me.DgvBitacora)
        Me.PDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PDatos.Location = New System.Drawing.Point(0, 258)
        Me.PDatos.Name = "PDatos"
        Me.PDatos.Size = New System.Drawing.Size(1034, 355)
        Me.PDatos.TabIndex = 0
        '
        'DgvBitacora
        '
        Me.DgvBitacora.AllowUserToAddRows = False
        Me.DgvBitacora.AllowUserToDeleteRows = False
        Me.DgvBitacora.AllowUserToOrderColumns = True
        Me.DgvBitacora.AllowUserToResizeColumns = False
        Me.DgvBitacora.AllowUserToResizeRows = False
        Me.DgvBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvBitacora.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBitacora.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvBitacora.Location = New System.Drawing.Point(0, 0)
        Me.DgvBitacora.MultiSelect = False
        Me.DgvBitacora.Name = "DgvBitacora"
        Me.DgvBitacora.RowHeadersVisible = False
        Me.DgvBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvBitacora.Size = New System.Drawing.Size(1034, 355)
        Me.DgvBitacora.TabIndex = 2
        '
        'GbFiltros
        '
        Me.GbFiltros.Controls.Add(Me.BtConsulta)
        Me.GbFiltros.Controls.Add(Me.Label2)
        Me.GbFiltros.Controls.Add(Me.Label1)
        Me.GbFiltros.Controls.Add(Me.DtFechaFin)
        Me.GbFiltros.Controls.Add(Me.DtFechaInicio)
        Me.GbFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbFiltros.Location = New System.Drawing.Point(0, 24)
        Me.GbFiltros.Name = "GbFiltros"
        Me.GbFiltros.Size = New System.Drawing.Size(1034, 234)
        Me.GbFiltros.TabIndex = 1
        Me.GbFiltros.TabStop = False
        '
        'BtConsulta
        '
        Me.BtConsulta.Location = New System.Drawing.Point(902, 205)
        Me.BtConsulta.Name = "BtConsulta"
        Me.BtConsulta.Size = New System.Drawing.Size(75, 23)
        Me.BtConsulta.TabIndex = 2
        Me.BtConsulta.Text = "Consultar"
        Me.BtConsulta.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(832, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(654, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Desde"
        '
        'DtFechaFin
        '
        Me.DtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaFin.Location = New System.Drawing.Point(873, 122)
        Me.DtFechaFin.Name = "DtFechaFin"
        Me.DtFechaFin.Size = New System.Drawing.Size(104, 20)
        Me.DtFechaFin.TabIndex = 0
        '
        'DtFechaInicio
        '
        Me.DtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaInicio.Location = New System.Drawing.Point(698, 123)
        Me.DtFechaInicio.Name = "DtFechaInicio"
        Me.DtFechaInicio.Size = New System.Drawing.Size(104, 20)
        Me.DtFechaInicio.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarCamposToolStripMenuItem, Me.ExportarBitacoraToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1034, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LimpiarCamposToolStripMenuItem
        '
        Me.LimpiarCamposToolStripMenuItem.Name = "LimpiarCamposToolStripMenuItem"
        Me.LimpiarCamposToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.LimpiarCamposToolStripMenuItem.Text = "Limpiar Campos"
        '
        'ExportarBitacoraToolStripMenuItem
        '
        Me.ExportarBitacoraToolStripMenuItem.Name = "ExportarBitacoraToolStripMenuItem"
        Me.ExportarBitacoraToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.ExportarBitacoraToolStripMenuItem.Text = "Exportar Bitacora"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Bitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 613)
        Me.Controls.Add(Me.PDatos)
        Me.Controls.Add(Me.GbFiltros)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Bitacora"
        Me.Text = "Bitacora"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PDatos.ResumeLayout(False)
        CType(Me.DgvBitacora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbFiltros.ResumeLayout(False)
        Me.GbFiltros.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PDatos As Panel
    Friend WithEvents DgvBitacora As DataGridView
    Friend WithEvents GbFiltros As GroupBox
    Friend WithEvents DtFechaFin As DateTimePicker
    Friend WithEvents DtFechaInicio As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtConsulta As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LimpiarCamposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportarBitacoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
