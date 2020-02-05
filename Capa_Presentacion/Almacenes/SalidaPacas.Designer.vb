<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalidaPacas
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
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TbIdSalidaPacas = New System.Windows.Forms.TextBox()
        Me.FechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.NuCantPacas = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbNoPacaCaptura = New System.Windows.Forms.TextBox()
        Me.DgvPacasSalida = New Capa_Presentacion.ClasificacionVentaPaquetes.DgvPlus()
        Me.MSMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GbDatosGenerales.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.NuCantPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvPacasSalida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(1483, 24)
        Me.MSMenu.TabIndex = 1
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
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 202)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1483, 441)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DgvPacasSalida)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 16)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1477, 422)
        Me.Panel4.TabIndex = 7
        '
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.Controls.Add(Me.GroupBox5)
        Me.GbDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatosGenerales.Location = New System.Drawing.Point(0, 24)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(1483, 178)
        Me.GbDatosGenerales.TabIndex = 7
        Me.GbDatosGenerales.TabStop = False
        Me.GbDatosGenerales.Text = "Datos Generales"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Panel3)
        Me.GroupBox5.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox5.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(976, 159)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.TbNoPacaCaptura)
        Me.Panel3.Controls.Add(Me.NuCantPacas)
        Me.Panel3.Controls.Add(Me.FechaSalida)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.TbIdSalidaPacas)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(970, 140)
        Me.Panel3.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "ID Salida"
        Me.Label1.UseWaitCursor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Cant. Pacas"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 16)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Fecha"
        '
        'TbIdSalidaPacas
        '
        Me.TbIdSalidaPacas.Enabled = False
        Me.TbIdSalidaPacas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbIdSalidaPacas.Location = New System.Drawing.Point(91, 5)
        Me.TbIdSalidaPacas.Name = "TbIdSalidaPacas"
        Me.TbIdSalidaPacas.Size = New System.Drawing.Size(99, 26)
        Me.TbIdSalidaPacas.TabIndex = 17
        Me.TbIdSalidaPacas.UseWaitCursor = True
        '
        'FechaSalida
        '
        Me.FechaSalida.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaSalida.Location = New System.Drawing.Point(92, 36)
        Me.FechaSalida.Name = "FechaSalida"
        Me.FechaSalida.Size = New System.Drawing.Size(342, 26)
        Me.FechaSalida.TabIndex = 17
        '
        'NuCantPacas
        '
        Me.NuCantPacas.Enabled = False
        Me.NuCantPacas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuCantPacas.Location = New System.Drawing.Point(92, 68)
        Me.NuCantPacas.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.NuCantPacas.Name = "NuCantPacas"
        Me.NuCantPacas.Size = New System.Drawing.Size(122, 26)
        Me.NuCantPacas.TabIndex = 47
        Me.NuCantPacas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "No. Paca"
        '
        'TbNoPacaCaptura
        '
        Me.TbNoPacaCaptura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNoPacaCaptura.Location = New System.Drawing.Point(91, 100)
        Me.TbNoPacaCaptura.MaxLength = 10
        Me.TbNoPacaCaptura.Name = "TbNoPacaCaptura"
        Me.TbNoPacaCaptura.Size = New System.Drawing.Size(131, 26)
        Me.TbNoPacaCaptura.TabIndex = 48
        '
        'DgvPacasSalida
        '
        Me.DgvPacasSalida.AllowUserToAddRows = False
        Me.DgvPacasSalida.AllowUserToDeleteRows = False
        Me.DgvPacasSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacasSalida.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvPacasSalida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvPacasSalida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvPacasSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacasSalida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacasSalida.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvPacasSalida.Location = New System.Drawing.Point(0, 0)
        Me.DgvPacasSalida.MultiSelect = False
        Me.DgvPacasSalida.Name = "DgvPacasSalida"
        Me.DgvPacasSalida.RowHeadersWidth = 40
        Me.DgvPacasSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvPacasSalida.Size = New System.Drawing.Size(1477, 422)
        Me.DgvPacasSalida.TabIndex = 16
        '
        'SalidaPacas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1483, 643)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GbDatosGenerales)
        Me.Controls.Add(Me.MSMenu)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "SalidaPacas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Salida de Pacas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.NuCantPacas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvPacasSalida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GbDatosGenerales As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TbIdSalidaPacas As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents FechaSalida As DateTimePicker
    Friend WithEvents NuCantPacas As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents TbNoPacaCaptura As TextBox
    Friend DgvPacasSalida As ClasificacionVentaPaquetes.DgvPlus
End Class
