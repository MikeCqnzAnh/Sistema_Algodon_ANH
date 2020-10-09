<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Plantas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Plantas))
        Me.LbID = New System.Windows.Forms.Label()
        Me.TbIdPlanta = New System.Windows.Forms.TextBox()
        Me.TbDescripcion = New System.Windows.Forms.TextBox()
        Me.TbRegistro = New System.Windows.Forms.TextBox()
        Me.LbDescripcion = New System.Windows.Forms.Label()
        Me.LbRegistro = New System.Windows.Forms.Label()
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DgvPlantas = New System.Windows.Forms.DataGridView()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.MSMenu.SuspendLayout()
        CType(Me.DgvPlantas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbDatosGenerales.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbID
        '
        Me.LbID.AutoSize = True
        Me.LbID.Location = New System.Drawing.Point(6, 22)
        Me.LbID.Name = "LbID"
        Me.LbID.Size = New System.Drawing.Size(18, 13)
        Me.LbID.TabIndex = 0
        Me.LbID.Text = "ID"
        '
        'TbIdPlanta
        '
        Me.TbIdPlanta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbIdPlanta.Enabled = False
        Me.TbIdPlanta.Location = New System.Drawing.Point(124, 19)
        Me.TbIdPlanta.Name = "TbIdPlanta"
        Me.TbIdPlanta.Size = New System.Drawing.Size(100, 20)
        Me.TbIdPlanta.TabIndex = 1
        '
        'TbDescripcion
        '
        Me.TbDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbDescripcion.Location = New System.Drawing.Point(124, 45)
        Me.TbDescripcion.Name = "TbDescripcion"
        Me.TbDescripcion.Size = New System.Drawing.Size(149, 20)
        Me.TbDescripcion.TabIndex = 2
        '
        'TbRegistro
        '
        Me.TbRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbRegistro.Location = New System.Drawing.Point(124, 71)
        Me.TbRegistro.Name = "TbRegistro"
        Me.TbRegistro.Size = New System.Drawing.Size(100, 20)
        Me.TbRegistro.TabIndex = 3
        '
        'LbDescripcion
        '
        Me.LbDescripcion.AutoSize = True
        Me.LbDescripcion.Location = New System.Drawing.Point(6, 48)
        Me.LbDescripcion.Name = "LbDescripcion"
        Me.LbDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.LbDescripcion.TabIndex = 4
        Me.LbDescripcion.Text = "Descripcion"
        '
        'LbRegistro
        '
        Me.LbRegistro.AutoSize = True
        Me.LbRegistro.Location = New System.Drawing.Point(6, 74)
        Me.LbRegistro.Name = "LbRegistro"
        Me.LbRegistro.Size = New System.Drawing.Size(46, 13)
        Me.LbRegistro.TabIndex = 5
        Me.LbRegistro.Text = "Registro"
        '
        'MSMenu
        '
        Me.MSMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(987, 24)
        Me.MSMenu.TabIndex = 7
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
        'DgvPlantas
        '
        Me.DgvPlantas.AllowUserToAddRows = False
        Me.DgvPlantas.AllowUserToDeleteRows = False
        Me.DgvPlantas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPlantas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvPlantas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvPlantas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvPlantas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPlantas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPlantas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvPlantas.Location = New System.Drawing.Point(0, 161)
        Me.DgvPlantas.MultiSelect = False
        Me.DgvPlantas.Name = "DgvPlantas"
        Me.DgvPlantas.ReadOnly = True
        Me.DgvPlantas.RowHeadersVisible = False
        Me.DgvPlantas.RowHeadersWidth = 40
        Me.DgvPlantas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPlantas.Size = New System.Drawing.Size(987, 291)
        Me.DgvPlantas.TabIndex = 12
        '
        'CbEstatus
        '
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(124, 97)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(149, 21)
        Me.CbEstatus.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Estatus"
        '
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.Controls.Add(Me.LbID)
        Me.GbDatosGenerales.Controls.Add(Me.Label1)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdPlanta)
        Me.GbDatosGenerales.Controls.Add(Me.CbEstatus)
        Me.GbDatosGenerales.Controls.Add(Me.LbRegistro)
        Me.GbDatosGenerales.Controls.Add(Me.TbDescripcion)
        Me.GbDatosGenerales.Controls.Add(Me.LbDescripcion)
        Me.GbDatosGenerales.Controls.Add(Me.TbRegistro)
        Me.GbDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatosGenerales.Location = New System.Drawing.Point(0, 24)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(987, 137)
        Me.GbDatosGenerales.TabIndex = 15
        Me.GbDatosGenerales.TabStop = False
        Me.GbDatosGenerales.Text = "Datos Generales"
        '
        'Plantas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 452)
        Me.Controls.Add(Me.DgvPlantas)
        Me.Controls.Add(Me.GbDatosGenerales)
        Me.Controls.Add(Me.MSMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "Plantas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plantas"
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        CType(Me.DgvPlantas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbID As Label
    Friend WithEvents TbIdPlanta As TextBox
    Friend WithEvents TbDescripcion As TextBox
    Friend WithEvents TbRegistro As TextBox
    Friend WithEvents LbDescripcion As Label
    Friend WithEvents LbRegistro As Label
    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DgvPlantas As DataGridView
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GbDatosGenerales As GroupBox
End Class
