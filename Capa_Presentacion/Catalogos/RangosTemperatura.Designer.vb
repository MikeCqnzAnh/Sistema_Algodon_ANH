<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RangosTemperatura
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
        Me.TbRangoInicial = New System.Windows.Forms.TextBox()
        Me.TbRangoFinal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChkDentroLim = New System.Windows.Forms.CheckBox()
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.LbID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbIdRango = New System.Windows.Forms.TextBox()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.DgvRangos = New System.Windows.Forms.DataGridView()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.GbDatosGenerales.SuspendLayout()
        CType(Me.DgvRangos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MSMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TbRangoInicial
        '
        Me.TbRangoInicial.Location = New System.Drawing.Point(124, 45)
        Me.TbRangoInicial.Name = "TbRangoInicial"
        Me.TbRangoInicial.Size = New System.Drawing.Size(100, 20)
        Me.TbRangoInicial.TabIndex = 1
        '
        'TbRangoFinal
        '
        Me.TbRangoFinal.Location = New System.Drawing.Point(230, 45)
        Me.TbRangoFinal.Name = "TbRangoFinal"
        Me.TbRangoFinal.Size = New System.Drawing.Size(100, 20)
        Me.TbRangoFinal.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Rango"
        '
        'ChkDentroLim
        '
        Me.ChkDentroLim.AutoSize = True
        Me.ChkDentroLim.Location = New System.Drawing.Point(336, 48)
        Me.ChkDentroLim.Name = "ChkDentroLim"
        Me.ChkDentroLim.Size = New System.Drawing.Size(97, 17)
        Me.ChkDentroLim.TabIndex = 7
        Me.ChkDentroLim.Text = "Dentro del Lim."
        Me.ChkDentroLim.UseVisualStyleBackColor = True
        '
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.Controls.Add(Me.LbID)
        Me.GbDatosGenerales.Controls.Add(Me.Label1)
        Me.GbDatosGenerales.Controls.Add(Me.ChkDentroLim)
        Me.GbDatosGenerales.Controls.Add(Me.Label2)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdRango)
        Me.GbDatosGenerales.Controls.Add(Me.TbRangoFinal)
        Me.GbDatosGenerales.Controls.Add(Me.CbEstatus)
        Me.GbDatosGenerales.Controls.Add(Me.TbRangoInicial)
        Me.GbDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatosGenerales.Location = New System.Drawing.Point(0, 24)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(978, 96)
        Me.GbDatosGenerales.TabIndex = 16
        Me.GbDatosGenerales.TabStop = False
        Me.GbDatosGenerales.Text = "Datos Generales"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Estatus"
        '
        'TbIdRango
        '
        Me.TbIdRango.Enabled = False
        Me.TbIdRango.Location = New System.Drawing.Point(124, 19)
        Me.TbIdRango.Name = "TbIdRango"
        Me.TbIdRango.Size = New System.Drawing.Size(100, 20)
        Me.TbIdRango.TabIndex = 1
        '
        'CbEstatus
        '
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(124, 71)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(149, 21)
        Me.CbEstatus.TabIndex = 13
        '
        'DgvRangos
        '
        Me.DgvRangos.AllowUserToAddRows = False
        Me.DgvRangos.AllowUserToDeleteRows = False
        Me.DgvRangos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvRangos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvRangos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvRangos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvRangos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRangos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvRangos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvRangos.Location = New System.Drawing.Point(0, 120)
        Me.DgvRangos.MultiSelect = False
        Me.DgvRangos.Name = "DgvRangos"
        Me.DgvRangos.ReadOnly = True
        Me.DgvRangos.RowHeadersVisible = False
        Me.DgvRangos.RowHeadersWidth = 40
        Me.DgvRangos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvRangos.Size = New System.Drawing.Size(978, 286)
        Me.DgvRangos.TabIndex = 17
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
        'MSMenu
        '
        Me.MSMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(978, 24)
        Me.MSMenu.TabIndex = 0
        '
        'RangosTemperatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 406)
        Me.Controls.Add(Me.DgvRangos)
        Me.Controls.Add(Me.GbDatosGenerales)
        Me.Controls.Add(Me.MSMenu)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "RangosTemperatura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rangos de Temperatura"
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        CType(Me.DgvRangos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TbRangoInicial As TextBox
    Friend WithEvents TbRangoFinal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ChkDentroLim As CheckBox
    Friend WithEvents GbDatosGenerales As GroupBox
    Friend WithEvents LbID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbIdRango As TextBox
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents DgvRangos As DataGridView
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MSMenu As MenuStrip
End Class
