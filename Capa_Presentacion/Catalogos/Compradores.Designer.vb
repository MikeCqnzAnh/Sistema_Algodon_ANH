<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compradores
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
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.TbCorreo = New System.Windows.Forms.TextBox()
        Me.TbTelefono = New System.Windows.Forms.TextBox()
        Me.CbMunicipio = New System.Windows.Forms.ComboBox()
        Me.CbEstado = New System.Windows.Forms.ComboBox()
        Me.TbDomicilio = New System.Windows.Forms.TextBox()
        Me.TbCurp = New System.Windows.Forms.TextBox()
        Me.TbRfc = New System.Windows.Forms.TextBox()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.TbIdComprador = New System.Windows.Forms.TextBox()
        Me.LbCorreo = New System.Windows.Forms.Label()
        Me.LbTelefono = New System.Windows.Forms.Label()
        Me.LbEstado = New System.Windows.Forms.Label()
        Me.LbMunicipio = New System.Windows.Forms.Label()
        Me.LbDomicilio = New System.Windows.Forms.Label()
        Me.LbCURP = New System.Windows.Forms.Label()
        Me.LbRFC = New System.Windows.Forms.Label()
        Me.LbNombre = New System.Windows.Forms.Label()
        Me.LbID = New System.Windows.Forms.Label()
        Me.DgvCompradores = New System.Windows.Forms.DataGridView()
        Me.MSMenu.SuspendLayout()
        Me.GbDatosGenerales.SuspendLayout()
        CType(Me.DgvCompradores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.SalirToolStripMenuItem})
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
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.Controls.Add(Me.Label1)
        Me.GbDatosGenerales.Controls.Add(Me.CbEstatus)
        Me.GbDatosGenerales.Controls.Add(Me.TbCorreo)
        Me.GbDatosGenerales.Controls.Add(Me.TbTelefono)
        Me.GbDatosGenerales.Controls.Add(Me.CbMunicipio)
        Me.GbDatosGenerales.Controls.Add(Me.CbEstado)
        Me.GbDatosGenerales.Controls.Add(Me.TbDomicilio)
        Me.GbDatosGenerales.Controls.Add(Me.TbCurp)
        Me.GbDatosGenerales.Controls.Add(Me.TbRfc)
        Me.GbDatosGenerales.Controls.Add(Me.TbNombre)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdComprador)
        Me.GbDatosGenerales.Controls.Add(Me.LbCorreo)
        Me.GbDatosGenerales.Controls.Add(Me.LbTelefono)
        Me.GbDatosGenerales.Controls.Add(Me.LbEstado)
        Me.GbDatosGenerales.Controls.Add(Me.LbMunicipio)
        Me.GbDatosGenerales.Controls.Add(Me.LbDomicilio)
        Me.GbDatosGenerales.Controls.Add(Me.LbCURP)
        Me.GbDatosGenerales.Controls.Add(Me.LbRFC)
        Me.GbDatosGenerales.Controls.Add(Me.LbNombre)
        Me.GbDatosGenerales.Controls.Add(Me.LbID)
        Me.GbDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatosGenerales.Location = New System.Drawing.Point(0, 24)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(982, 170)
        Me.GbDatosGenerales.TabIndex = 1
        Me.GbDatosGenerales.TabStop = False
        Me.GbDatosGenerales.Text = "Datos Generales"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(361, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Estatus"
        '
        'CbEstatus
        '
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(462, 117)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(190, 21)
        Me.CbEstatus.TabIndex = 18
        '
        'TbCorreo
        '
        Me.TbCorreo.Location = New System.Drawing.Point(462, 91)
        Me.TbCorreo.Name = "TbCorreo"
        Me.TbCorreo.Size = New System.Drawing.Size(236, 20)
        Me.TbCorreo.TabIndex = 17
        '
        'TbTelefono
        '
        Me.TbTelefono.Location = New System.Drawing.Point(462, 64)
        Me.TbTelefono.Name = "TbTelefono"
        Me.TbTelefono.Size = New System.Drawing.Size(190, 20)
        Me.TbTelefono.TabIndex = 16
        '
        'CbMunicipio
        '
        Me.CbMunicipio.FormattingEnabled = True
        Me.CbMunicipio.Location = New System.Drawing.Point(462, 36)
        Me.CbMunicipio.Name = "CbMunicipio"
        Me.CbMunicipio.Size = New System.Drawing.Size(190, 21)
        Me.CbMunicipio.TabIndex = 15
        '
        'CbEstado
        '
        Me.CbEstado.FormattingEnabled = True
        Me.CbEstado.Location = New System.Drawing.Point(462, 8)
        Me.CbEstado.Name = "CbEstado"
        Me.CbEstado.Size = New System.Drawing.Size(190, 21)
        Me.CbEstado.TabIndex = 14
        '
        'TbDomicilio
        '
        Me.TbDomicilio.Location = New System.Drawing.Point(107, 125)
        Me.TbDomicilio.Name = "TbDomicilio"
        Me.TbDomicilio.Size = New System.Drawing.Size(236, 20)
        Me.TbDomicilio.TabIndex = 13
        '
        'TbCurp
        '
        Me.TbCurp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbCurp.Location = New System.Drawing.Point(107, 98)
        Me.TbCurp.Name = "TbCurp"
        Me.TbCurp.Size = New System.Drawing.Size(169, 20)
        Me.TbCurp.TabIndex = 12
        '
        'TbRfc
        '
        Me.TbRfc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbRfc.Location = New System.Drawing.Point(107, 71)
        Me.TbRfc.Name = "TbRfc"
        Me.TbRfc.Size = New System.Drawing.Size(169, 20)
        Me.TbRfc.TabIndex = 11
        '
        'TbNombre
        '
        Me.TbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNombre.Location = New System.Drawing.Point(107, 44)
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(236, 20)
        Me.TbNombre.TabIndex = 10
        '
        'TbIdComprador
        '
        Me.TbIdComprador.Enabled = False
        Me.TbIdComprador.Location = New System.Drawing.Point(107, 17)
        Me.TbIdComprador.Name = "TbIdComprador"
        Me.TbIdComprador.Size = New System.Drawing.Size(100, 20)
        Me.TbIdComprador.TabIndex = 9
        '
        'LbCorreo
        '
        Me.LbCorreo.AutoSize = True
        Me.LbCorreo.Location = New System.Drawing.Point(361, 98)
        Me.LbCorreo.Name = "LbCorreo"
        Me.LbCorreo.Size = New System.Drawing.Size(94, 13)
        Me.LbCorreo.TabIndex = 8
        Me.LbCorreo.Text = "Correo Electronico"
        '
        'LbTelefono
        '
        Me.LbTelefono.AutoSize = True
        Me.LbTelefono.Location = New System.Drawing.Point(361, 71)
        Me.LbTelefono.Name = "LbTelefono"
        Me.LbTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LbTelefono.TabIndex = 7
        Me.LbTelefono.Text = "Telefono"
        '
        'LbEstado
        '
        Me.LbEstado.AutoSize = True
        Me.LbEstado.Location = New System.Drawing.Point(361, 16)
        Me.LbEstado.Name = "LbEstado"
        Me.LbEstado.Size = New System.Drawing.Size(40, 13)
        Me.LbEstado.TabIndex = 6
        Me.LbEstado.Text = "Estado"
        '
        'LbMunicipio
        '
        Me.LbMunicipio.AutoSize = True
        Me.LbMunicipio.Location = New System.Drawing.Point(361, 44)
        Me.LbMunicipio.Name = "LbMunicipio"
        Me.LbMunicipio.Size = New System.Drawing.Size(52, 13)
        Me.LbMunicipio.TabIndex = 5
        Me.LbMunicipio.Text = "Municipio"
        '
        'LbDomicilio
        '
        Me.LbDomicilio.AutoSize = True
        Me.LbDomicilio.Location = New System.Drawing.Point(6, 132)
        Me.LbDomicilio.Name = "LbDomicilio"
        Me.LbDomicilio.Size = New System.Drawing.Size(49, 13)
        Me.LbDomicilio.TabIndex = 4
        Me.LbDomicilio.Text = "Domicilio"
        '
        'LbCURP
        '
        Me.LbCURP.AutoSize = True
        Me.LbCURP.Location = New System.Drawing.Point(6, 105)
        Me.LbCURP.Name = "LbCURP"
        Me.LbCURP.Size = New System.Drawing.Size(37, 13)
        Me.LbCURP.TabIndex = 3
        Me.LbCURP.Text = "CURP"
        '
        'LbRFC
        '
        Me.LbRFC.AutoSize = True
        Me.LbRFC.Location = New System.Drawing.Point(6, 78)
        Me.LbRFC.Name = "LbRFC"
        Me.LbRFC.Size = New System.Drawing.Size(28, 13)
        Me.LbRFC.TabIndex = 2
        Me.LbRFC.Text = "RFC"
        '
        'LbNombre
        '
        Me.LbNombre.AutoSize = True
        Me.LbNombre.Location = New System.Drawing.Point(6, 51)
        Me.LbNombre.Name = "LbNombre"
        Me.LbNombre.Size = New System.Drawing.Size(44, 13)
        Me.LbNombre.TabIndex = 1
        Me.LbNombre.Text = "Nombre"
        '
        'LbID
        '
        Me.LbID.AutoSize = True
        Me.LbID.Location = New System.Drawing.Point(6, 24)
        Me.LbID.Name = "LbID"
        Me.LbID.Size = New System.Drawing.Size(18, 13)
        Me.LbID.TabIndex = 0
        Me.LbID.Text = "ID"
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
        Me.DgvCompradores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCompradores.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvCompradores.Location = New System.Drawing.Point(0, 194)
        Me.DgvCompradores.MultiSelect = False
        Me.DgvCompradores.Name = "DgvCompradores"
        Me.DgvCompradores.ReadOnly = True
        Me.DgvCompradores.RowHeadersVisible = False
        Me.DgvCompradores.RowHeadersWidth = 40
        Me.DgvCompradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCompradores.Size = New System.Drawing.Size(982, 308)
        Me.DgvCompradores.TabIndex = 10
        '
        'Compradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 502)
        Me.Controls.Add(Me.DgvCompradores)
        Me.Controls.Add(Me.GbDatosGenerales)
        Me.Controls.Add(Me.MSMenu)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "Compradores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compradores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        CType(Me.DgvCompradores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GbDatosGenerales As GroupBox
    Friend WithEvents TbCorreo As TextBox
    Friend WithEvents TbTelefono As TextBox
    Friend WithEvents CbMunicipio As ComboBox
    Friend WithEvents CbEstado As ComboBox
    Friend WithEvents TbDomicilio As TextBox
    Friend WithEvents TbCurp As TextBox
    Friend WithEvents TbRfc As TextBox
    Friend WithEvents TbNombre As TextBox
    Friend WithEvents TbIdComprador As TextBox
    Friend WithEvents LbCorreo As Label
    Friend WithEvents LbTelefono As Label
    Friend WithEvents LbEstado As Label
    Friend WithEvents LbMunicipio As Label
    Friend WithEvents LbDomicilio As Label
    Friend WithEvents LbCURP As Label
    Friend WithEvents LbRFC As Label
    Friend WithEvents LbNombre As Label
    Friend WithEvents LbID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents DgvCompradores As DataGridView
End Class
