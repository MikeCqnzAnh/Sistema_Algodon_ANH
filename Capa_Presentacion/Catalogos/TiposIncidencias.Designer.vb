<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TiposIncidencias
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbIdTipoIncidencia = New System.Windows.Forms.TextBox()
        Me.DgvTipoIncidencia = New System.Windows.Forms.DataGridView()
        Me.MSMenu.SuspendLayout()
        Me.GbDatosGenerales.SuspendLayout()
        CType(Me.DgvTipoIncidencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(982, 24)
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
        Me.GbDatosGenerales.Controls.Add(Me.Label4)
        Me.GbDatosGenerales.Controls.Add(Me.CbEstatus)
        Me.GbDatosGenerales.Controls.Add(Me.Label3)
        Me.GbDatosGenerales.Controls.Add(Me.TbDescripcion)
        Me.GbDatosGenerales.Controls.Add(Me.Label1)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdTipoIncidencia)
        Me.GbDatosGenerales.Location = New System.Drawing.Point(12, 27)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(957, 111)
        Me.GbDatosGenerales.TabIndex = 2
        Me.GbDatosGenerales.TabStop = False
        Me.GbDatosGenerales.Text = "Datos Generales"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Estatus"
        '
        'CbEstatus
        '
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(115, 71)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.CbEstatus.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Descripcion"
        '
        'TbDescripcion
        '
        Me.TbDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbDescripcion.Location = New System.Drawing.Point(115, 45)
        Me.TbDescripcion.Name = "TbDescripcion"
        Me.TbDescripcion.Size = New System.Drawing.Size(208, 20)
        Me.TbDescripcion.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'TbIdTipoIncidencia
        '
        Me.TbIdTipoIncidencia.Enabled = False
        Me.TbIdTipoIncidencia.Location = New System.Drawing.Point(115, 19)
        Me.TbIdTipoIncidencia.Name = "TbIdTipoIncidencia"
        Me.TbIdTipoIncidencia.Size = New System.Drawing.Size(100, 20)
        Me.TbIdTipoIncidencia.TabIndex = 0
        '
        'DgvTipoIncidencia
        '
        Me.DgvTipoIncidencia.AllowUserToAddRows = False
        Me.DgvTipoIncidencia.AllowUserToDeleteRows = False
        Me.DgvTipoIncidencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvTipoIncidencia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvTipoIncidencia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvTipoIncidencia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvTipoIncidencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTipoIncidencia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvTipoIncidencia.Location = New System.Drawing.Point(13, 144)
        Me.DgvTipoIncidencia.MultiSelect = False
        Me.DgvTipoIncidencia.Name = "DgvTipoIncidencia"
        Me.DgvTipoIncidencia.ReadOnly = True
        Me.DgvTipoIncidencia.RowHeadersVisible = False
        Me.DgvTipoIncidencia.RowHeadersWidth = 40
        Me.DgvTipoIncidencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvTipoIncidencia.Size = New System.Drawing.Size(957, 266)
        Me.DgvTipoIncidencia.TabIndex = 14
        '
        'TiposIncidencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 423)
        Me.Controls.Add(Me.DgvTipoIncidencia)
        Me.Controls.Add(Me.GbDatosGenerales)
        Me.Controls.Add(Me.MSMenu)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "TiposIncidencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de Incidencia"
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        CType(Me.DgvTipoIncidencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GbDatosGenerales As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TbIdTipoIncidencia As TextBox
    Friend WithEvents DgvTipoIncidencia As DataGridView
End Class
