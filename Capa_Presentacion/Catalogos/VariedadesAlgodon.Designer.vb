<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VariedadesAlgodon
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
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.TbDescripcion = New System.Windows.Forms.TextBox()
        Me.TbIdVariedadAlgodon = New System.Windows.Forms.TextBox()
        Me.LbHasta = New System.Windows.Forms.Label()
        Me.LbDe = New System.Windows.Forms.Label()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvVariedadesAlgodon = New System.Windows.Forms.DataGridView()
        Me.MSMenu.SuspendLayout()
        Me.GbDatosGenerales.SuspendLayout()
        CType(Me.DgvVariedadesAlgodon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(449, 24)
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
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.Controls.Add(Me.CbEstatus)
        Me.GbDatosGenerales.Controls.Add(Me.TbDescripcion)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdVariedadAlgodon)
        Me.GbDatosGenerales.Controls.Add(Me.Label1)
        Me.GbDatosGenerales.Controls.Add(Me.LbHasta)
        Me.GbDatosGenerales.Controls.Add(Me.LbDe)
        Me.GbDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatosGenerales.Location = New System.Drawing.Point(0, 24)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(449, 110)
        Me.GbDatosGenerales.TabIndex = 5
        Me.GbDatosGenerales.TabStop = False
        Me.GbDatosGenerales.Text = "Datos Generales"
        '
        'TbDescripcion
        '
        Me.TbDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbDescripcion.Location = New System.Drawing.Point(75, 46)
        Me.TbDescripcion.Name = "TbDescripcion"
        Me.TbDescripcion.Size = New System.Drawing.Size(164, 20)
        Me.TbDescripcion.TabIndex = 7
        '
        'TbIdVariedadAlgodon
        '
        Me.TbIdVariedadAlgodon.Enabled = False
        Me.TbIdVariedadAlgodon.Location = New System.Drawing.Point(75, 20)
        Me.TbIdVariedadAlgodon.Name = "TbIdVariedadAlgodon"
        Me.TbIdVariedadAlgodon.Size = New System.Drawing.Size(83, 20)
        Me.TbIdVariedadAlgodon.TabIndex = 6
        '
        'LbHasta
        '
        Me.LbHasta.AutoSize = True
        Me.LbHasta.Location = New System.Drawing.Point(6, 49)
        Me.LbHasta.Name = "LbHasta"
        Me.LbHasta.Size = New System.Drawing.Size(63, 13)
        Me.LbHasta.TabIndex = 5
        Me.LbHasta.Text = "Descripción"
        '
        'LbDe
        '
        Me.LbDe.AutoSize = True
        Me.LbDe.Location = New System.Drawing.Point(6, 23)
        Me.LbDe.Name = "LbDe"
        Me.LbDe.Size = New System.Drawing.Size(18, 13)
        Me.LbDe.TabIndex = 4
        Me.LbDe.Text = "ID"
        '
        'CbEstatus
        '
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(75, 73)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.CbEstatus.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Estatus"
        '
        'DgvVariedadesAlgodon
        '
        Me.DgvVariedadesAlgodon.AllowUserToAddRows = False
        Me.DgvVariedadesAlgodon.AllowUserToDeleteRows = False
        Me.DgvVariedadesAlgodon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvVariedadesAlgodon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvVariedadesAlgodon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvVariedadesAlgodon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvVariedadesAlgodon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVariedadesAlgodon.Dock = System.Windows.Forms.DockStyle.Top
        Me.DgvVariedadesAlgodon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvVariedadesAlgodon.Location = New System.Drawing.Point(0, 134)
        Me.DgvVariedadesAlgodon.MultiSelect = False
        Me.DgvVariedadesAlgodon.Name = "DgvVariedadesAlgodon"
        Me.DgvVariedadesAlgodon.ReadOnly = True
        Me.DgvVariedadesAlgodon.RowHeadersVisible = False
        Me.DgvVariedadesAlgodon.RowHeadersWidth = 40
        Me.DgvVariedadesAlgodon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvVariedadesAlgodon.Size = New System.Drawing.Size(449, 276)
        Me.DgvVariedadesAlgodon.TabIndex = 17
        '
        'VariedadesAlgodon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 415)
        Me.Controls.Add(Me.DgvVariedadesAlgodon)
        Me.Controls.Add(Me.GbDatosGenerales)
        Me.Controls.Add(Me.MSMenu)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "VariedadesAlgodon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Variedades de Algodon"
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        CType(Me.DgvVariedadesAlgodon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GbDatosGenerales As GroupBox
    Friend WithEvents TbDescripcion As TextBox
    Friend WithEvents TbIdVariedadAlgodon As TextBox
    Friend WithEvents LbHasta As Label
    Friend WithEvents LbDe As Label
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvVariedadesAlgodon As DataGridView
End Class
