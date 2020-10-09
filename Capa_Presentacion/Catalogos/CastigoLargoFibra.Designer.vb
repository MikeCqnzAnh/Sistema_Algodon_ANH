<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CastigoLargoFibra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CastigoLargoFibra))
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbIdModoLargoFibraEncabezado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.DgvLargoDetalle = New System.Windows.Forms.DataGridView()
        Me.DgvEncabezado = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvEquivalente = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbDescripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbTipoContrato = New System.Windows.Forms.ComboBox()
        Me.MSMenu.SuspendLayout()
        CType(Me.DgvLargoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvEquivalente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(1086, 24)
        Me.MSMenu.TabIndex = 0
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'TbIdModoLargoFibraEncabezado
        '
        Me.TbIdModoLargoFibraEncabezado.Enabled = False
        Me.TbIdModoLargoFibraEncabezado.Location = New System.Drawing.Point(125, 19)
        Me.TbIdModoLargoFibraEncabezado.Name = "TbIdModoLargoFibraEncabezado"
        Me.TbIdModoLargoFibraEncabezado.Size = New System.Drawing.Size(100, 20)
        Me.TbIdModoLargoFibraEncabezado.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(252, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Estatus"
        '
        'CbEstatus
        '
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(300, 71)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.CbEstatus.TabIndex = 3
        '
        'DgvLargoDetalle
        '
        Me.DgvLargoDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvLargoDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvLargoDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvLargoDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvLargoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLargoDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvLargoDetalle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvLargoDetalle.Location = New System.Drawing.Point(3, 16)
        Me.DgvLargoDetalle.MultiSelect = False
        Me.DgvLargoDetalle.Name = "DgvLargoDetalle"
        Me.DgvLargoDetalle.RowHeadersWidth = 40
        Me.DgvLargoDetalle.Size = New System.Drawing.Size(308, 510)
        Me.DgvLargoDetalle.TabIndex = 0
        '
        'DgvEncabezado
        '
        Me.DgvEncabezado.AllowUserToAddRows = False
        Me.DgvEncabezado.AllowUserToDeleteRows = False
        Me.DgvEncabezado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEncabezado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvEncabezado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvEncabezado.Location = New System.Drawing.Point(3, 16)
        Me.DgvEncabezado.Name = "DgvEncabezado"
        Me.DgvEncabezado.ReadOnly = True
        Me.DgvEncabezado.RowHeadersVisible = False
        Me.DgvEncabezado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEncabezado.Size = New System.Drawing.Size(1080, 90)
        Me.DgvEncabezado.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvEncabezado)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1086, 109)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modos de Castigo"
        '
        'DgvEquivalente
        '
        Me.DgvEquivalente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEquivalente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvEquivalente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEquivalente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvEquivalente.Location = New System.Drawing.Point(3, 16)
        Me.DgvEquivalente.Name = "DgvEquivalente"
        Me.DgvEquivalente.Size = New System.Drawing.Size(760, 510)
        Me.DgvEquivalente.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 240)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1086, 548)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DgvLargoDetalle)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(314, 529)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Largos de Fibra"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DgvEquivalente)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox3.Location = New System.Drawing.Point(317, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(766, 529)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Equivalentes"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.TbDescripcion)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.CbTipoContrato)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.TbIdModoLargoFibraEncabezado)
        Me.GroupBox5.Controls.Add(Me.CbEstatus)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1086, 107)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Descripcion"
        '
        'TbDescripcion
        '
        Me.TbDescripcion.Location = New System.Drawing.Point(125, 45)
        Me.TbDescripcion.Name = "TbDescripcion"
        Me.TbDescripcion.Size = New System.Drawing.Size(296, 20)
        Me.TbDescripcion.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Tipo Comercializacion"
        '
        'CbTipoContrato
        '
        Me.CbTipoContrato.FormattingEnabled = True
        Me.CbTipoContrato.Location = New System.Drawing.Point(125, 71)
        Me.CbTipoContrato.Name = "CbTipoContrato"
        Me.CbTipoContrato.Size = New System.Drawing.Size(121, 21)
        Me.CbTipoContrato.TabIndex = 2
        '
        'CastigoLargoFibra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 788)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MSMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "CastigoLargoFibra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Castigo Por Largo de Fibra"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        CType(Me.DgvLargoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvEquivalente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TbIdModoLargoFibraEncabezado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents DgvLargoDetalle As DataGridView
    Friend WithEvents DgvEncabezado As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgvEquivalente As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CbTipoContrato As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TbDescripcion As TextBox
End Class
