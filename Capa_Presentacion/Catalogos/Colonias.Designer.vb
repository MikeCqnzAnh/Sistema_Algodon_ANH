<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Colonias
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.LbNumPacas = New System.Windows.Forms.Label()
        Me.LbDescripcion = New System.Windows.Forms.Label()
        Me.TbNoPacas = New System.Windows.Forms.TextBox()
        Me.TbDescripcion = New System.Windows.Forms.TextBox()
        Me.TbIdColonia = New System.Windows.Forms.TextBox()
        Me.LbID = New System.Windows.Forms.Label()
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DgvCompradores = New System.Windows.Forms.DataGridView()
        Me.GbDatosGenerales.SuspendLayout()
        Me.MSMenu.SuspendLayout()
        CType(Me.DgvCompradores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.Controls.Add(Me.Label1)
        Me.GbDatosGenerales.Controls.Add(Me.CbEstatus)
        Me.GbDatosGenerales.Controls.Add(Me.LbNumPacas)
        Me.GbDatosGenerales.Controls.Add(Me.LbDescripcion)
        Me.GbDatosGenerales.Controls.Add(Me.TbNoPacas)
        Me.GbDatosGenerales.Controls.Add(Me.TbDescripcion)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdColonia)
        Me.GbDatosGenerales.Controls.Add(Me.LbID)
        Me.GbDatosGenerales.Location = New System.Drawing.Point(13, 27)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(957, 125)
        Me.GbDatosGenerales.TabIndex = 0
        Me.GbDatosGenerales.TabStop = False
        Me.GbDatosGenerales.Text = "Datos Generales"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Estatus"
        '
        'CbEstatus
        '
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(138, 96)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(168, 21)
        Me.CbEstatus.TabIndex = 6
        '
        'LbNumPacas
        '
        Me.LbNumPacas.AutoSize = True
        Me.LbNumPacas.Location = New System.Drawing.Point(6, 73)
        Me.LbNumPacas.Name = "LbNumPacas"
        Me.LbNumPacas.Size = New System.Drawing.Size(94, 13)
        Me.LbNumPacas.TabIndex = 5
        Me.LbNumPacas.Text = "Numero Pacas Ha"
        '
        'LbDescripcion
        '
        Me.LbDescripcion.AutoSize = True
        Me.LbDescripcion.Location = New System.Drawing.Point(6, 46)
        Me.LbDescripcion.Name = "LbDescripcion"
        Me.LbDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.LbDescripcion.TabIndex = 4
        Me.LbDescripcion.Text = "Descripcion"
        '
        'TbNoPacas
        '
        Me.TbNoPacas.Location = New System.Drawing.Point(138, 70)
        Me.TbNoPacas.Name = "TbNoPacas"
        Me.TbNoPacas.Size = New System.Drawing.Size(156, 20)
        Me.TbNoPacas.TabIndex = 3
        '
        'TbDescripcion
        '
        Me.TbDescripcion.Location = New System.Drawing.Point(138, 43)
        Me.TbDescripcion.Name = "TbDescripcion"
        Me.TbDescripcion.Size = New System.Drawing.Size(156, 20)
        Me.TbDescripcion.TabIndex = 2
        '
        'TbIdColonia
        '
        Me.TbIdColonia.Enabled = False
        Me.TbIdColonia.Location = New System.Drawing.Point(138, 16)
        Me.TbIdColonia.Name = "TbIdColonia"
        Me.TbIdColonia.Size = New System.Drawing.Size(100, 20)
        Me.TbIdColonia.TabIndex = 1
        '
        'LbID
        '
        Me.LbID.AutoSize = True
        Me.LbID.Location = New System.Drawing.Point(6, 23)
        Me.LbID.Name = "LbID"
        Me.LbID.Size = New System.Drawing.Size(18, 13)
        Me.LbID.TabIndex = 0
        Me.LbID.Text = "ID"
        '
        'MSMenu
        '
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(984, 24)
        Me.MSMenu.TabIndex = 2
        Me.MSMenu.Text = "MenuStrip1"
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
        'DgvCompradores
        '
        Me.DgvCompradores.AllowUserToAddRows = False
        Me.DgvCompradores.AllowUserToDeleteRows = False
        Me.DgvCompradores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCompradores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvCompradores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvCompradores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvCompradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCompradores.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvCompradores.Location = New System.Drawing.Point(13, 158)
        Me.DgvCompradores.MultiSelect = False
        Me.DgvCompradores.Name = "DgvCompradores"
        Me.DgvCompradores.ReadOnly = True
        Me.DgvCompradores.RowHeadersVisible = False
        Me.DgvCompradores.RowHeadersWidth = 40
        Me.DgvCompradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCompradores.Size = New System.Drawing.Size(957, 266)
        Me.DgvCompradores.TabIndex = 11
        '
        'Colonias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 444)
        Me.Controls.Add(Me.DgvCompradores)
        Me.Controls.Add(Me.GbDatosGenerales)
        Me.Controls.Add(Me.MSMenu)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "Colonias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Colonias"
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        CType(Me.DgvCompradores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbDatosGenerales As GroupBox
    Friend WithEvents LbNumPacas As Label
    Friend WithEvents LbDescripcion As Label
    Friend WithEvents TbNoPacas As TextBox
    Friend WithEvents TbDescripcion As TextBox
    Friend WithEvents TbIdColonia As TextBox
    Friend WithEvents LbID As Label
    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DgvCompradores As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents CbEstatus As ComboBox
End Class
