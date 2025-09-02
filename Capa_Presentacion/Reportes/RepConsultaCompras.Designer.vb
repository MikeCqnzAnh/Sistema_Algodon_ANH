<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepConsultaCompras
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.BtAceptar = New System.Windows.Forms.Button()
        Me.TbIdCompra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.BtBuscarProductor = New System.Windows.Forms.Button()
        Me.TbIdProductor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvCompras = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExportarAExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbDatos.SuspendLayout()
        CType(Me.DgvCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.BtAceptar)
        Me.GbDatos.Controls.Add(Me.TbIdCompra)
        Me.GbDatos.Controls.Add(Me.Label2)
        Me.GbDatos.Controls.Add(Me.TbNombre)
        Me.GbDatos.Controls.Add(Me.BtBuscarProductor)
        Me.GbDatos.Controls.Add(Me.TbIdProductor)
        Me.GbDatos.Controls.Add(Me.Label1)
        Me.GbDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatos.Location = New System.Drawing.Point(0, 24)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(974, 150)
        Me.GbDatos.TabIndex = 1
        Me.GbDatos.TabStop = False
        '
        'BtAceptar
        '
        Me.BtAceptar.Location = New System.Drawing.Point(860, 33)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtAceptar.TabIndex = 13
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'TbIdCompra
        '
        Me.TbIdCompra.Location = New System.Drawing.Point(680, 35)
        Me.TbIdCompra.MaxLength = 10
        Me.TbIdCompra.Name = "TbIdCompra"
        Me.TbIdCompra.Size = New System.Drawing.Size(63, 20)
        Me.TbIdCompra.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(625, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Compra :"
        '
        'TbNombre
        '
        Me.TbNombre.Location = New System.Drawing.Point(171, 35)
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(448, 20)
        Me.TbNombre.TabIndex = 10
        '
        'BtBuscarProductor
        '
        Me.BtBuscarProductor.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.search
        Me.BtBuscarProductor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtBuscarProductor.Location = New System.Drawing.Point(141, 33)
        Me.BtBuscarProductor.Name = "BtBuscarProductor"
        Me.BtBuscarProductor.Size = New System.Drawing.Size(24, 23)
        Me.BtBuscarProductor.TabIndex = 9
        Me.BtBuscarProductor.UseVisualStyleBackColor = True
        '
        'TbIdProductor
        '
        Me.TbIdProductor.Location = New System.Drawing.Point(77, 35)
        Me.TbIdProductor.MaxLength = 10
        Me.TbIdProductor.Name = "TbIdProductor"
        Me.TbIdProductor.Size = New System.Drawing.Size(58, 20)
        Me.TbIdProductor.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Productor :"
        '
        'DgvCompras
        '
        Me.DgvCompras.AllowUserToAddRows = False
        Me.DgvCompras.AllowUserToDeleteRows = False
        Me.DgvCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCompras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCompras.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvCompras.Location = New System.Drawing.Point(0, 174)
        Me.DgvCompras.MultiSelect = False
        Me.DgvCompras.Name = "DgvCompras"
        Me.DgvCompras.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvCompras.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvCompras.RowHeadersVisible = False
        Me.DgvCompras.RowHeadersWidth = 40
        Me.DgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCompras.Size = New System.Drawing.Size(974, 405)
        Me.DgvCompras.TabIndex = 16
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportarAExcelToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(974, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExportarAExcelToolStripMenuItem
        '
        Me.ExportarAExcelToolStripMenuItem.Name = "ExportarAExcelToolStripMenuItem"
        Me.ExportarAExcelToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.ExportarAExcelToolStripMenuItem.Text = "Exportar a Excel"
        '
        'RepConsultaCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 579)
        Me.Controls.Add(Me.DgvCompras)
        Me.Controls.Add(Me.GbDatos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RepConsultaCompras"
        Me.Tag = "0,0"
        Me.Text = "Consulta de compras"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        CType(Me.DgvCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents BtAceptar As Button
    Friend WithEvents TbIdCompra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbNombre As TextBox
    Friend WithEvents BtBuscarProductor As Button
    Friend WithEvents TbIdProductor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvCompras As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExportarAExcelToolStripMenuItem As ToolStripMenuItem
End Class
