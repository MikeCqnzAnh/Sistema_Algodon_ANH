<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdenTrabajo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdenTrabajo))
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TbNoModulos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TbPredio = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TbRangoFin = New System.Windows.Forms.TextBox()
        Me.TbRangoInicio = New System.Windows.Forms.TextBox()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.BtBuscarProductor = New System.Windows.Forms.Button()
        Me.TbIdProductor = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TbIdOrdenTrabajo = New System.Windows.Forms.TextBox()
        Me.GbInformacion = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbColonia = New System.Windows.Forms.ComboBox()
        Me.CbVariedad = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbPlantas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvCapturaLotes = New System.Windows.Forms.DataGridView()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.MSMenu.SuspendLayout()
        Me.GbDatosGenerales.SuspendLayout()
        Me.GbInformacion.SuspendLayout()
        CType(Me.DgvCapturaLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(1215, 24)
        Me.MSMenu.TabIndex = 0
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo "
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
        Me.GbDatosGenerales.Controls.Add(Me.CbEstatus)
        Me.GbDatosGenerales.Controls.Add(Me.Label16)
        Me.GbDatosGenerales.Controls.Add(Me.TbNoModulos)
        Me.GbDatosGenerales.Controls.Add(Me.Label3)
        Me.GbDatosGenerales.Controls.Add(Me.Label15)
        Me.GbDatosGenerales.Controls.Add(Me.TbPredio)
        Me.GbDatosGenerales.Controls.Add(Me.Label14)
        Me.GbDatosGenerales.Controls.Add(Me.Label13)
        Me.GbDatosGenerales.Controls.Add(Me.Label12)
        Me.GbDatosGenerales.Controls.Add(Me.TbRangoFin)
        Me.GbDatosGenerales.Controls.Add(Me.TbRangoInicio)
        Me.GbDatosGenerales.Controls.Add(Me.TbNombre)
        Me.GbDatosGenerales.Controls.Add(Me.BtBuscarProductor)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdProductor)
        Me.GbDatosGenerales.Controls.Add(Me.Label11)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdOrdenTrabajo)
        Me.GbDatosGenerales.Controls.Add(Me.GbInformacion)
        Me.GbDatosGenerales.Controls.Add(Me.Label5)
        Me.GbDatosGenerales.Controls.Add(Me.Label4)
        Me.GbDatosGenerales.Controls.Add(Me.CbColonia)
        Me.GbDatosGenerales.Controls.Add(Me.CbVariedad)
        Me.GbDatosGenerales.Controls.Add(Me.Label2)
        Me.GbDatosGenerales.Controls.Add(Me.CbPlantas)
        Me.GbDatosGenerales.Controls.Add(Me.Label1)
        Me.GbDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatosGenerales.Location = New System.Drawing.Point(0, 24)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(1215, 192)
        Me.GbDatosGenerales.TabIndex = 1
        Me.GbDatosGenerales.TabStop = False
        '
        'CbEstatus
        '
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(490, 103)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.CbEstatus.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(371, 106)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 13)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Estatus"
        '
        'TbNoModulos
        '
        Me.TbNoModulos.Enabled = False
        Me.TbNoModulos.Location = New System.Drawing.Point(490, 130)
        Me.TbNoModulos.Name = "TbNoModulos"
        Me.TbNoModulos.Size = New System.Drawing.Size(121, 20)
        Me.TbNoModulos.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(371, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Modulos"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(371, 73)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Predio"
        '
        'TbPredio
        '
        Me.TbPredio.Location = New System.Drawing.Point(490, 70)
        Me.TbPredio.Name = "TbPredio"
        Me.TbPredio.Size = New System.Drawing.Size(121, 20)
        Me.TbPredio.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(226, 131)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "a la"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 133)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "De la"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 105)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Nombre"
        '
        'TbRangoFin
        '
        Me.TbRangoFin.Location = New System.Drawing.Point(257, 128)
        Me.TbRangoFin.Name = "TbRangoFin"
        Me.TbRangoFin.Size = New System.Drawing.Size(100, 20)
        Me.TbRangoFin.TabIndex = 16
        '
        'TbRangoInicio
        '
        Me.TbRangoInicio.Enabled = False
        Me.TbRangoInicio.Location = New System.Drawing.Point(119, 128)
        Me.TbRangoInicio.Name = "TbRangoInicio"
        Me.TbRangoInicio.Size = New System.Drawing.Size(100, 20)
        Me.TbRangoInicio.TabIndex = 15
        '
        'TbNombre
        '
        Me.TbNombre.Enabled = False
        Me.TbNombre.Location = New System.Drawing.Point(119, 102)
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(238, 20)
        Me.TbNombre.TabIndex = 14
        '
        'BtBuscarProductor
        '
        Me.BtBuscarProductor.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.BusquedaUsuario
        Me.BtBuscarProductor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtBuscarProductor.Location = New System.Drawing.Point(225, 65)
        Me.BtBuscarProductor.Name = "BtBuscarProductor"
        Me.BtBuscarProductor.Size = New System.Drawing.Size(34, 32)
        Me.BtBuscarProductor.TabIndex = 13
        Me.BtBuscarProductor.UseVisualStyleBackColor = True
        '
        'TbIdProductor
        '
        Me.TbIdProductor.Location = New System.Drawing.Point(119, 76)
        Me.TbIdProductor.Name = "TbIdProductor"
        Me.TbIdProductor.ReadOnly = True
        Me.TbIdProductor.Size = New System.Drawing.Size(100, 20)
        Me.TbIdProductor.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "ID"
        '
        'TbIdOrdenTrabajo
        '
        Me.TbIdOrdenTrabajo.Enabled = False
        Me.TbIdOrdenTrabajo.Location = New System.Drawing.Point(119, 16)
        Me.TbIdOrdenTrabajo.Name = "TbIdOrdenTrabajo"
        Me.TbIdOrdenTrabajo.Size = New System.Drawing.Size(100, 20)
        Me.TbIdOrdenTrabajo.TabIndex = 10
        '
        'GbInformacion
        '
        Me.GbInformacion.Controls.Add(Me.Label10)
        Me.GbInformacion.Controls.Add(Me.TextBox5)
        Me.GbInformacion.Controls.Add(Me.TextBox4)
        Me.GbInformacion.Controls.Add(Me.Label9)
        Me.GbInformacion.Controls.Add(Me.Label8)
        Me.GbInformacion.Controls.Add(Me.Label7)
        Me.GbInformacion.Controls.Add(Me.TextBox3)
        Me.GbInformacion.Controls.Add(Me.TextBox2)
        Me.GbInformacion.Controls.Add(Me.TextBox1)
        Me.GbInformacion.Controls.Add(Me.Label6)
        Me.GbInformacion.Dock = System.Windows.Forms.DockStyle.Right
        Me.GbInformacion.Location = New System.Drawing.Point(832, 16)
        Me.GbInformacion.Name = "GbInformacion"
        Me.GbInformacion.Size = New System.Drawing.Size(380, 173)
        Me.GbInformacion.TabIndex = 2
        Me.GbInformacion.TabStop = False
        Me.GbInformacion.Text = "Informacion"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(186, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Total de Hueso"
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(274, 128)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(274, 101)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(186, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Tara"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Bruto"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(68, 73)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(68, 46)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(68, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Boleta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(371, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Colonia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(371, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Variedad de Algodon"
        '
        'CbColonia
        '
        Me.CbColonia.FormattingEnabled = True
        Me.CbColonia.Location = New System.Drawing.Point(490, 43)
        Me.CbColonia.Name = "CbColonia"
        Me.CbColonia.Size = New System.Drawing.Size(175, 21)
        Me.CbColonia.TabIndex = 6
        '
        'CbVariedad
        '
        Me.CbVariedad.FormattingEnabled = True
        Me.CbVariedad.Location = New System.Drawing.Point(490, 16)
        Me.CbVariedad.Name = "CbVariedad"
        Me.CbVariedad.Size = New System.Drawing.Size(175, 21)
        Me.CbVariedad.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Id Productor"
        '
        'CbPlantas
        '
        Me.CbPlantas.FormattingEnabled = True
        Me.CbPlantas.Location = New System.Drawing.Point(119, 42)
        Me.CbPlantas.Name = "CbPlantas"
        Me.CbPlantas.Size = New System.Drawing.Size(238, 21)
        Me.CbPlantas.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Planta"
        '
        'DgvCapturaLotes
        '
        Me.DgvCapturaLotes.AllowUserToAddRows = False
        Me.DgvCapturaLotes.AllowUserToDeleteRows = False
        Me.DgvCapturaLotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCapturaLotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvCapturaLotes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvCapturaLotes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvCapturaLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCapturaLotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCapturaLotes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvCapturaLotes.Location = New System.Drawing.Point(0, 216)
        Me.DgvCapturaLotes.MultiSelect = False
        Me.DgvCapturaLotes.Name = "DgvCapturaLotes"
        Me.DgvCapturaLotes.ReadOnly = True
        Me.DgvCapturaLotes.RowHeadersVisible = False
        Me.DgvCapturaLotes.RowHeadersWidth = 40
        Me.DgvCapturaLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCapturaLotes.Size = New System.Drawing.Size(1215, 358)
        Me.DgvCapturaLotes.TabIndex = 14
        '
        'OrdenTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1215, 574)
        Me.Controls.Add(Me.DgvCapturaLotes)
        Me.Controls.Add(Me.GbDatosGenerales)
        Me.Controls.Add(Me.MSMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "OrdenTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Captura de Ordenes de Trabajo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        Me.GbInformacion.ResumeLayout(False)
        Me.GbInformacion.PerformLayout()
        CType(Me.DgvCapturaLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GbDatosGenerales As GroupBox
    Friend WithEvents GbInformacion As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CbColonia As ComboBox
    Friend WithEvents CbVariedad As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CbPlantas As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TbIdProductor As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TbIdOrdenTrabajo As TextBox
    Friend WithEvents BtBuscarProductor As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TbRangoFin As TextBox
    Friend WithEvents TbRangoInicio As TextBox
    Friend WithEvents TbNombre As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TbPredio As TextBox
    Friend WithEvents DgvCapturaLotes As DataGridView
    Friend WithEvents TbNoModulos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents FontDialog1 As FontDialog
End Class
