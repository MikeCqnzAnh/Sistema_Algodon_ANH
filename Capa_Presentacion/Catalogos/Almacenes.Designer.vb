<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Almacenes
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarTipoDeAlmacenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbIdBodega = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NuCapacidad = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbDescripcion = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbNumero = New System.Windows.Forms.TextBox()
        Me.TbCodigoPostal = New System.Windows.Forms.TextBox()
        Me.TbCalle = New System.Windows.Forms.TextBox()
        Me.CbEstado = New System.Windows.Forms.ComboBox()
        Me.TbColonia = New System.Windows.Forms.TextBox()
        Me.CbCiudad = New System.Windows.Forms.ComboBox()
        Me.DgvBodegas = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.NuCapacidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvBodegas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.AgregarTipoDeAlmacenToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1214, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'AgregarTipoDeAlmacenToolStripMenuItem
        '
        Me.AgregarTipoDeAlmacenToolStripMenuItem.Name = "AgregarTipoDeAlmacenToolStripMenuItem"
        Me.AgregarTipoDeAlmacenToolStripMenuItem.Size = New System.Drawing.Size(154, 20)
        Me.AgregarTipoDeAlmacenToolStripMenuItem.Text = "Agregar Tipo de Almacen"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'TbIdBodega
        '
        Me.TbIdBodega.Enabled = False
        Me.TbIdBodega.Location = New System.Drawing.Point(78, 17)
        Me.TbIdBodega.Name = "TbIdBodega"
        Me.TbIdBodega.Size = New System.Drawing.Size(110, 20)
        Me.TbIdBodega.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID:"
        '
        'CbTipo
        '
        Me.CbTipo.FormattingEnabled = True
        Me.CbTipo.Location = New System.Drawing.Point(396, 48)
        Me.CbTipo.Name = "CbTipo"
        Me.CbTipo.Size = New System.Drawing.Size(121, 21)
        Me.CbTipo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(359, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo:"
        '
        'NuCapacidad
        '
        Me.NuCapacidad.DecimalPlaces = 4
        Me.NuCapacidad.Location = New System.Drawing.Point(78, 135)
        Me.NuCapacidad.Maximum = New Decimal(New Integer() {-1593835521, 466537709, 54210, 0})
        Me.NuCapacidad.Name = "NuCapacidad"
        Me.NuCapacidad.Size = New System.Drawing.Size(120, 20)
        Me.NuCapacidad.TabIndex = 9
        Me.NuCapacidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Capacidad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Descripcion:"
        '
        'TbDescripcion
        '
        Me.TbDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbDescripcion.Location = New System.Drawing.Point(78, 48)
        Me.TbDescripcion.Name = "TbDescripcion"
        Me.TbDescripcion.Size = New System.Drawing.Size(275, 20)
        Me.TbDescripcion.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TbIdBodega)
        Me.GroupBox1.Controls.Add(Me.NuCapacidad)
        Me.GroupBox1.Controls.Add(Me.TbNumero)
        Me.GroupBox1.Controls.Add(Me.TbCodigoPostal)
        Me.GroupBox1.Controls.Add(Me.TbCalle)
        Me.GroupBox1.Controls.Add(Me.CbEstado)
        Me.GroupBox1.Controls.Add(Me.TbColonia)
        Me.GroupBox1.Controls.Add(Me.TbDescripcion)
        Me.GroupBox1.Controls.Add(Me.CbCiudad)
        Me.GroupBox1.Controls.Add(Me.CbTipo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1214, 206)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(420, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Estado:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(596, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Ciudad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(183, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Colonia:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(523, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "No:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "CP:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Calle:"
        '
        'TbNumero
        '
        Me.TbNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNumero.Location = New System.Drawing.Point(553, 74)
        Me.TbNumero.Name = "TbNumero"
        Me.TbNumero.Size = New System.Drawing.Size(84, 20)
        Me.TbNumero.TabIndex = 4
        '
        'TbCodigoPostal
        '
        Me.TbCodigoPostal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbCodigoPostal.Location = New System.Drawing.Point(78, 108)
        Me.TbCodigoPostal.Name = "TbCodigoPostal"
        Me.TbCodigoPostal.Size = New System.Drawing.Size(99, 20)
        Me.TbCodigoPostal.TabIndex = 5
        '
        'TbCalle
        '
        Me.TbCalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbCalle.Location = New System.Drawing.Point(78, 74)
        Me.TbCalle.Name = "TbCalle"
        Me.TbCalle.Size = New System.Drawing.Size(439, 20)
        Me.TbCalle.TabIndex = 3
        '
        'CbEstado
        '
        Me.CbEstado.FormattingEnabled = True
        Me.CbEstado.Location = New System.Drawing.Point(469, 108)
        Me.CbEstado.Name = "CbEstado"
        Me.CbEstado.Size = New System.Drawing.Size(121, 21)
        Me.CbEstado.TabIndex = 8
        '
        'TbColonia
        '
        Me.TbColonia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbColonia.Location = New System.Drawing.Point(234, 108)
        Me.TbColonia.Name = "TbColonia"
        Me.TbColonia.Size = New System.Drawing.Size(180, 20)
        Me.TbColonia.TabIndex = 1
        '
        'CbCiudad
        '
        Me.CbCiudad.FormattingEnabled = True
        Me.CbCiudad.Location = New System.Drawing.Point(645, 107)
        Me.CbCiudad.Name = "CbCiudad"
        Me.CbCiudad.Size = New System.Drawing.Size(121, 21)
        Me.CbCiudad.TabIndex = 7
        '
        'DgvBodegas
        '
        Me.DgvBodegas.AllowUserToAddRows = False
        Me.DgvBodegas.AllowUserToDeleteRows = False
        Me.DgvBodegas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvBodegas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvBodegas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvBodegas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvBodegas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBodegas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvBodegas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvBodegas.Location = New System.Drawing.Point(0, 230)
        Me.DgvBodegas.MultiSelect = False
        Me.DgvBodegas.Name = "DgvBodegas"
        Me.DgvBodegas.ReadOnly = True
        Me.DgvBodegas.RowHeadersVisible = False
        Me.DgvBodegas.RowHeadersWidth = 40
        Me.DgvBodegas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvBodegas.Size = New System.Drawing.Size(1214, 281)
        Me.DgvBodegas.TabIndex = 6
        '
        'Almacenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 511)
        Me.Controls.Add(Me.DgvBodegas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Almacenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Almacenes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.NuCapacidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvBodegas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TbIdBodega As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CbTipo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NuCapacidad As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TbDescripcion As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AgregarTipoDeAlmacenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TbCodigoPostal As TextBox
    Friend WithEvents CbCiudad As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TbNumero As TextBox
    Friend WithEvents TbCalle As TextBox
    Friend WithEvents CbEstado As ComboBox
    Friend WithEvents TbColonia As TextBox
    Friend WithEvents DgvBodegas As DataGridView
End Class
