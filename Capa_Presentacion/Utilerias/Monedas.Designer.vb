<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Monedas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRegistroMoneda = New System.Windows.Forms.Panel()
        Me.DgvMonedas = New System.Windows.Forms.DataGridView()
        Me.GbDatosMoneda = New System.Windows.Forms.GroupBox()
        Me.NuTipodecambio = New System.Windows.Forms.NumericUpDown()
        Me.TbIdMoneda = New System.Windows.Forms.TextBox()
        Me.TbAbreviacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbNombreMoneda = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.PRegistroMoneda.SuspendLayout()
        CType(Me.DgvMonedas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbDatosMoneda.SuspendLayout()
        CType(Me.NuTipodecambio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarActualizarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(917, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'GuardarActualizarToolStripMenuItem
        '
        Me.GuardarActualizarToolStripMenuItem.Name = "GuardarActualizarToolStripMenuItem"
        Me.GuardarActualizarToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.GuardarActualizarToolStripMenuItem.Text = "Guardar/Actualizar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        Me.EliminarToolStripMenuItem.Visible = False
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PRegistroMoneda
        '
        Me.PRegistroMoneda.Controls.Add(Me.DgvMonedas)
        Me.PRegistroMoneda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PRegistroMoneda.Location = New System.Drawing.Point(0, 118)
        Me.PRegistroMoneda.Name = "PRegistroMoneda"
        Me.PRegistroMoneda.Size = New System.Drawing.Size(917, 221)
        Me.PRegistroMoneda.TabIndex = 1
        '
        'DgvMonedas
        '
        Me.DgvMonedas.AllowUserToAddRows = False
        Me.DgvMonedas.AllowUserToDeleteRows = False
        Me.DgvMonedas.AllowUserToOrderColumns = True
        Me.DgvMonedas.AllowUserToResizeColumns = False
        Me.DgvMonedas.AllowUserToResizeRows = False
        Me.DgvMonedas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvMonedas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvMonedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMonedas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvMonedas.Location = New System.Drawing.Point(0, 0)
        Me.DgvMonedas.MultiSelect = False
        Me.DgvMonedas.Name = "DgvMonedas"
        Me.DgvMonedas.RowHeadersVisible = False
        Me.DgvMonedas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMonedas.Size = New System.Drawing.Size(917, 221)
        Me.DgvMonedas.TabIndex = 1
        '
        'GbDatosMoneda
        '
        Me.GbDatosMoneda.Controls.Add(Me.NuTipodecambio)
        Me.GbDatosMoneda.Controls.Add(Me.TbIdMoneda)
        Me.GbDatosMoneda.Controls.Add(Me.TbAbreviacion)
        Me.GbDatosMoneda.Controls.Add(Me.Label3)
        Me.GbDatosMoneda.Controls.Add(Me.TbNombreMoneda)
        Me.GbDatosMoneda.Controls.Add(Me.Label4)
        Me.GbDatosMoneda.Controls.Add(Me.Label2)
        Me.GbDatosMoneda.Controls.Add(Me.Label1)
        Me.GbDatosMoneda.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatosMoneda.Location = New System.Drawing.Point(0, 24)
        Me.GbDatosMoneda.Name = "GbDatosMoneda"
        Me.GbDatosMoneda.Size = New System.Drawing.Size(917, 94)
        Me.GbDatosMoneda.TabIndex = 2
        Me.GbDatosMoneda.TabStop = False
        Me.GbDatosMoneda.Text = "Datos"
        '
        'NuTipodecambio
        '
        Me.NuTipodecambio.DecimalPlaces = 4
        Me.NuTipodecambio.Location = New System.Drawing.Point(641, 45)
        Me.NuTipodecambio.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NuTipodecambio.Name = "NuTipodecambio"
        Me.NuTipodecambio.Size = New System.Drawing.Size(120, 20)
        Me.NuTipodecambio.TabIndex = 3
        Me.NuTipodecambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuTipodecambio.ThousandsSeparator = True
        '
        'TbIdMoneda
        '
        Me.TbIdMoneda.Enabled = False
        Me.TbIdMoneda.Location = New System.Drawing.Point(105, 19)
        Me.TbIdMoneda.Name = "TbIdMoneda"
        Me.TbIdMoneda.Size = New System.Drawing.Size(100, 20)
        Me.TbIdMoneda.TabIndex = 2
        '
        'TbAbreviacion
        '
        Me.TbAbreviacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbAbreviacion.Location = New System.Drawing.Point(410, 45)
        Me.TbAbreviacion.MaxLength = 6
        Me.TbAbreviacion.Name = "TbAbreviacion"
        Me.TbAbreviacion.Size = New System.Drawing.Size(100, 20)
        Me.TbAbreviacion.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ID:"
        '
        'TbNombreMoneda
        '
        Me.TbNombreMoneda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNombreMoneda.Location = New System.Drawing.Point(105, 45)
        Me.TbNombreMoneda.MaxLength = 50
        Me.TbNombreMoneda.Name = "TbNombreMoneda"
        Me.TbNombreMoneda.Size = New System.Drawing.Size(200, 20)
        Me.TbNombreMoneda.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(552, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tipo de cambio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(338, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Abreviacion:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Moneda:"
        '
        'Monedas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 339)
        Me.Controls.Add(Me.PRegistroMoneda)
        Me.Controls.Add(Me.GbDatosMoneda)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Monedas"
        Me.Text = "Monedas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PRegistroMoneda.ResumeLayout(False)
        CType(Me.DgvMonedas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbDatosMoneda.ResumeLayout(False)
        Me.GbDatosMoneda.PerformLayout()
        CType(Me.NuTipodecambio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRegistroMoneda As Panel
    Friend WithEvents DgvMonedas As DataGridView
    Friend WithEvents GbDatosMoneda As GroupBox
    Friend WithEvents TbAbreviacion As TextBox
    Friend WithEvents TbNombreMoneda As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TbIdMoneda As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NuTipodecambio As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
End Class
