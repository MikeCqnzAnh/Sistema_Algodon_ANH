<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncidenciasBoletasPorLotes
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
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.BtArreglaIncidencia = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IncidenciasRevisadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScIncidencias = New System.Windows.Forms.SplitContainer()
        Me.GbEntradas = New System.Windows.Forms.GroupBox()
        Me.DgvModulos = New System.Windows.Forms.DataGridView()
        Me.GbSalidas = New System.Windows.Forms.GroupBox()
        Me.DgvIncidencias = New System.Windows.Forms.DataGridView()
        Me.GbDatosGenerales.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ScIncidencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ScIncidencias.Panel1.SuspendLayout()
        Me.ScIncidencias.Panel2.SuspendLayout()
        Me.ScIncidencias.SuspendLayout()
        Me.GbEntradas.SuspendLayout()
        CType(Me.DgvModulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbSalidas.SuspendLayout()
        CType(Me.DgvIncidencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.Controls.Add(Me.BtArreglaIncidencia)
        Me.GbDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatosGenerales.Location = New System.Drawing.Point(0, 24)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(1102, 83)
        Me.GbDatosGenerales.TabIndex = 0
        Me.GbDatosGenerales.TabStop = False
        '
        'BtArreglaIncidencia
        '
        Me.BtArreglaIncidencia.Location = New System.Drawing.Point(12, 19)
        Me.BtArreglaIncidencia.Name = "BtArreglaIncidencia"
        Me.BtArreglaIncidencia.Size = New System.Drawing.Size(95, 34)
        Me.BtArreglaIncidencia.TabIndex = 0
        Me.BtArreglaIncidencia.Text = "Iniciar Proceso"
        Me.BtArreglaIncidencia.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncidenciasRevisadasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1102, 24)
        Me.MenuStrip1.TabIndex = 33
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IncidenciasRevisadasToolStripMenuItem
        '
        Me.IncidenciasRevisadasToolStripMenuItem.Name = "IncidenciasRevisadasToolStripMenuItem"
        Me.IncidenciasRevisadasToolStripMenuItem.Size = New System.Drawing.Size(195, 20)
        Me.IncidenciasRevisadasToolStripMenuItem.Text = "Historial de Incidencias Revisadas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ScIncidencias
        '
        Me.ScIncidencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScIncidencias.Location = New System.Drawing.Point(0, 107)
        Me.ScIncidencias.Name = "ScIncidencias"
        '
        'ScIncidencias.Panel1
        '
        Me.ScIncidencias.Panel1.Controls.Add(Me.GbEntradas)
        Me.ScIncidencias.Panel1.Tag = "Entradas de Modulos"
        '
        'ScIncidencias.Panel2
        '
        Me.ScIncidencias.Panel2.Controls.Add(Me.GbSalidas)
        Me.ScIncidencias.Panel2.Tag = "Salida de Modulos"
        Me.ScIncidencias.Size = New System.Drawing.Size(1102, 507)
        Me.ScIncidencias.SplitterDistance = 536
        Me.ScIncidencias.TabIndex = 34
        '
        'GbEntradas
        '
        Me.GbEntradas.Controls.Add(Me.DgvModulos)
        Me.GbEntradas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbEntradas.Location = New System.Drawing.Point(0, 0)
        Me.GbEntradas.Name = "GbEntradas"
        Me.GbEntradas.Size = New System.Drawing.Size(536, 507)
        Me.GbEntradas.TabIndex = 0
        Me.GbEntradas.TabStop = False
        Me.GbEntradas.Text = "Entradas"
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
        Me.DgvModulos.Size = New System.Drawing.Size(530, 488)
        Me.DgvModulos.TabIndex = 39
        '
        'GbSalidas
        '
        Me.GbSalidas.Controls.Add(Me.DgvIncidencias)
        Me.GbSalidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbSalidas.Location = New System.Drawing.Point(0, 0)
        Me.GbSalidas.Name = "GbSalidas"
        Me.GbSalidas.Size = New System.Drawing.Size(562, 507)
        Me.GbSalidas.TabIndex = 0
        Me.GbSalidas.TabStop = False
        Me.GbSalidas.Text = "Salidas"
        '
        'DgvIncidencias
        '
        Me.DgvIncidencias.AllowUserToAddRows = False
        Me.DgvIncidencias.AllowUserToDeleteRows = False
        Me.DgvIncidencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvIncidencias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvIncidencias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvIncidencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvIncidencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvIncidencias.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvIncidencias.Location = New System.Drawing.Point(3, 16)
        Me.DgvIncidencias.MultiSelect = False
        Me.DgvIncidencias.Name = "DgvIncidencias"
        Me.DgvIncidencias.RowHeadersVisible = False
        Me.DgvIncidencias.RowHeadersWidth = 40
        Me.DgvIncidencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvIncidencias.Size = New System.Drawing.Size(556, 488)
        Me.DgvIncidencias.TabIndex = 38
        '
        'IncidenciasBoletasPorLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 614)
        Me.Controls.Add(Me.ScIncidencias)
        Me.Controls.Add(Me.GbDatosGenerales)
        Me.Controls.Add(Me.MenuStrip1)
        Me.HelpButton = True
        Me.Name = "IncidenciasBoletasPorLotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Incidencias de Boletas por Lotes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ScIncidencias.Panel1.ResumeLayout(False)
        Me.ScIncidencias.Panel2.ResumeLayout(False)
        CType(Me.ScIncidencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ScIncidencias.ResumeLayout(False)
        Me.GbEntradas.ResumeLayout(False)
        CType(Me.DgvModulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbSalidas.ResumeLayout(False)
        CType(Me.DgvIncidencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GbDatosGenerales As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IncidenciasRevisadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtArreglaIncidencia As Button
    Friend WithEvents ScIncidencias As SplitContainer
    Friend WithEvents GbEntradas As GroupBox
    Friend WithEvents DgvModulos As DataGridView
    Friend WithEvents GbSalidas As GroupBox
    Friend WithEvents DgvIncidencias As DataGridView
End Class
