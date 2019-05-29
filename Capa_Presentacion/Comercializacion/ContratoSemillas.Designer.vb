<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContratoSemillas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TbTestigo2 = New System.Windows.Forms.TextBox()
        Me.TbTestigo1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbComprador = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbFolio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbIdContratoSemilla = New System.Windows.Forms.TextBox()
        Me.DgvContratoSemillas = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NuPrecioTonelada = New System.Windows.Forms.NumericUpDown()
        Me.NuCantidad = New System.Windows.Forms.NumericUpDown()
        Me.CbMoneda = New System.Windows.Forms.ComboBox()
        Me.MSMenu.SuspendLayout()
        Me.GbDatosGenerales.SuspendLayout()
        CType(Me.DgvContratoSemillas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.NuPrecioTonelada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(1194, 24)
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
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.Controls.Add(Me.CbMoneda)
        Me.GbDatosGenerales.Controls.Add(Me.NuCantidad)
        Me.GbDatosGenerales.Controls.Add(Me.NuPrecioTonelada)
        Me.GbDatosGenerales.Controls.Add(Me.Label9)
        Me.GbDatosGenerales.Controls.Add(Me.CbEstatus)
        Me.GbDatosGenerales.Controls.Add(Me.Label8)
        Me.GbDatosGenerales.Controls.Add(Me.Label7)
        Me.GbDatosGenerales.Controls.Add(Me.TbTestigo2)
        Me.GbDatosGenerales.Controls.Add(Me.TbTestigo1)
        Me.GbDatosGenerales.Controls.Add(Me.Label6)
        Me.GbDatosGenerales.Controls.Add(Me.Label5)
        Me.GbDatosGenerales.Controls.Add(Me.Label4)
        Me.GbDatosGenerales.Controls.Add(Me.CbComprador)
        Me.GbDatosGenerales.Controls.Add(Me.Label3)
        Me.GbDatosGenerales.Controls.Add(Me.DtpFecha)
        Me.GbDatosGenerales.Controls.Add(Me.Label2)
        Me.GbDatosGenerales.Controls.Add(Me.TbFolio)
        Me.GbDatosGenerales.Controls.Add(Me.Label1)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdContratoSemilla)
        Me.GbDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatosGenerales.Location = New System.Drawing.Point(0, 24)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(1194, 185)
        Me.GbDatosGenerales.TabIndex = 1
        Me.GbDatosGenerales.TabStop = False
        Me.GbDatosGenerales.Text = "Datos Generales"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Estatus"
        '
        'CbEstatus
        '
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(117, 150)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.CbEstatus.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(337, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Testigo 2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(337, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Testigo 1"
        '
        'TbTestigo2
        '
        Me.TbTestigo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbTestigo2.Location = New System.Drawing.Point(448, 71)
        Me.TbTestigo2.Name = "TbTestigo2"
        Me.TbTestigo2.Size = New System.Drawing.Size(266, 20)
        Me.TbTestigo2.TabIndex = 8
        '
        'TbTestigo1
        '
        Me.TbTestigo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbTestigo1.Location = New System.Drawing.Point(448, 45)
        Me.TbTestigo1.Name = "TbTestigo1"
        Me.TbTestigo1.Size = New System.Drawing.Size(266, 20)
        Me.TbTestigo1.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(337, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Precio Tonelada"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Cantidad (Ton)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Comprador"
        '
        'CbComprador
        '
        Me.CbComprador.FormattingEnabled = True
        Me.CbComprador.Location = New System.Drawing.Point(117, 97)
        Me.CbComprador.Name = "CbComprador"
        Me.CbComprador.Size = New System.Drawing.Size(200, 21)
        Me.CbComprador.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha"
        '
        'DtpFecha
        '
        Me.DtpFecha.Location = New System.Drawing.Point(117, 71)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(200, 20)
        Me.DtpFecha.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Folio"
        '
        'TbFolio
        '
        Me.TbFolio.Location = New System.Drawing.Point(117, 45)
        Me.TbFolio.Name = "TbFolio"
        Me.TbFolio.Size = New System.Drawing.Size(200, 20)
        Me.TbFolio.TabIndex = 1
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
        'TbIdContratoSemilla
        '
        Me.TbIdContratoSemilla.Enabled = False
        Me.TbIdContratoSemilla.Location = New System.Drawing.Point(117, 19)
        Me.TbIdContratoSemilla.Name = "TbIdContratoSemilla"
        Me.TbIdContratoSemilla.Size = New System.Drawing.Size(100, 20)
        Me.TbIdContratoSemilla.TabIndex = 0
        '
        'DgvContratoSemillas
        '
        Me.DgvContratoSemillas.AllowUserToAddRows = False
        Me.DgvContratoSemillas.AllowUserToDeleteRows = False
        Me.DgvContratoSemillas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvContratoSemillas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvContratoSemillas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvContratoSemillas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvContratoSemillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvContratoSemillas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvContratoSemillas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvContratoSemillas.Location = New System.Drawing.Point(0, 0)
        Me.DgvContratoSemillas.MultiSelect = False
        Me.DgvContratoSemillas.Name = "DgvContratoSemillas"
        Me.DgvContratoSemillas.ReadOnly = True
        Me.DgvContratoSemillas.RowHeadersVisible = False
        Me.DgvContratoSemillas.RowHeadersWidth = 40
        Me.DgvContratoSemillas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvContratoSemillas.Size = New System.Drawing.Size(1194, 365)
        Me.DgvContratoSemillas.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DgvContratoSemillas)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 209)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1194, 365)
        Me.Panel1.TabIndex = 15
        '
        'NuPrecioTonelada
        '
        Me.NuPrecioTonelada.DecimalPlaces = 4
        Me.NuPrecioTonelada.Location = New System.Drawing.Point(448, 20)
        Me.NuPrecioTonelada.Maximum = New Decimal(New Integer() {-1304428545, 434162106, 542, 0})
        Me.NuPrecioTonelada.Name = "NuPrecioTonelada"
        Me.NuPrecioTonelada.Size = New System.Drawing.Size(120, 20)
        Me.NuPrecioTonelada.TabIndex = 15
        Me.NuPrecioTonelada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuPrecioTonelada.ThousandsSeparator = True
        '
        'NuCantidad
        '
        Me.NuCantidad.Location = New System.Drawing.Point(117, 125)
        Me.NuCantidad.Maximum = New Decimal(New Integer() {-727379969, 232, 0, 0})
        Me.NuCantidad.Name = "NuCantidad"
        Me.NuCantidad.Size = New System.Drawing.Size(120, 20)
        Me.NuCantidad.TabIndex = 15
        Me.NuCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuCantidad.ThousandsSeparator = True
        '
        'CbMoneda
        '
        Me.CbMoneda.FormattingEnabled = True
        Me.CbMoneda.Location = New System.Drawing.Point(584, 19)
        Me.CbMoneda.Name = "CbMoneda"
        Me.CbMoneda.Size = New System.Drawing.Size(64, 21)
        Me.CbMoneda.TabIndex = 16
        '
        'ContratoSemillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1194, 574)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GbDatosGenerales)
        Me.Controls.Add(Me.MSMenu)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "ContratoSemillas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contrato de Semillas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        CType(Me.DgvContratoSemillas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.NuPrecioTonelada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GbDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TbFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbIdContratoSemilla As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CbComprador As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TbTestigo2 As System.Windows.Forms.TextBox
    Friend WithEvents TbTestigo1 As System.Windows.Forms.TextBox
    Friend WithEvents DgvContratoSemillas As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NuCantidad As NumericUpDown
    Friend WithEvents NuPrecioTonelada As NumericUpDown
    Friend WithEvents CbMoneda As ComboBox
End Class
