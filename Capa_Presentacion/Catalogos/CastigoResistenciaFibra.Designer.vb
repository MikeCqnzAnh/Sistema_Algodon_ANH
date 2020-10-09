<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CastigoResistenciaFibra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CastigoResistenciaFibra))
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbIdResistenciaEncabezado = New System.Windows.Forms.TextBox()
        Me.TbRango1 = New System.Windows.Forms.TextBox()
        Me.TbRango2 = New System.Windows.Forms.TextBox()
        Me.TbCastigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbTipoContrato = New System.Windows.Forms.ComboBox()
        Me.TbDescripcion = New System.Windows.Forms.TextBox()
        Me.GbModosCastigo = New System.Windows.Forms.GroupBox()
        Me.DgvEncabezado = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DgvDetalle = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.MSMenu.SuspendLayout()
        Me.GbDatosGenerales.SuspendLayout()
        Me.GbModosCastigo.SuspendLayout()
        CType(Me.DgvEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(684, 24)
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
        'TbIdResistenciaEncabezado
        '
        Me.TbIdResistenciaEncabezado.Enabled = False
        Me.TbIdResistenciaEncabezado.Location = New System.Drawing.Point(96, 19)
        Me.TbIdResistenciaEncabezado.Name = "TbIdResistenciaEncabezado"
        Me.TbIdResistenciaEncabezado.Size = New System.Drawing.Size(121, 20)
        Me.TbIdResistenciaEncabezado.TabIndex = 0
        '
        'TbRango1
        '
        Me.TbRango1.Location = New System.Drawing.Point(60, 28)
        Me.TbRango1.Name = "TbRango1"
        Me.TbRango1.Size = New System.Drawing.Size(100, 20)
        Me.TbRango1.TabIndex = 0
        '
        'TbRango2
        '
        Me.TbRango2.Location = New System.Drawing.Point(220, 28)
        Me.TbRango2.Name = "TbRango2"
        Me.TbRango2.Size = New System.Drawing.Size(100, 20)
        Me.TbRango2.TabIndex = 1
        '
        'TbCastigo
        '
        Me.TbCastigo.Location = New System.Drawing.Point(374, 28)
        Me.TbCastigo.Name = "TbCastigo"
        Me.TbCastigo.Size = New System.Drawing.Size(100, 20)
        Me.TbCastigo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Rango 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Rango 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(326, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Castigo"
        '
        'CbEstatus
        '
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(271, 71)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.CbEstatus.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(223, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Estatus"
        '
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.Controls.Add(Me.Label7)
        Me.GbDatosGenerales.Controls.Add(Me.Label6)
        Me.GbDatosGenerales.Controls.Add(Me.CbTipoContrato)
        Me.GbDatosGenerales.Controls.Add(Me.TbDescripcion)
        Me.GbDatosGenerales.Controls.Add(Me.CbEstatus)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdResistenciaEncabezado)
        Me.GbDatosGenerales.Controls.Add(Me.Label5)
        Me.GbDatosGenerales.Controls.Add(Me.Label1)
        Me.GbDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatosGenerales.Location = New System.Drawing.Point(0, 24)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(684, 115)
        Me.GbDatosGenerales.TabIndex = 1
        Me.GbDatosGenerales.TabStop = False
        Me.GbDatosGenerales.Text = "Datos Generales"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Tipo de Contrato"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Descripcion"
        '
        'CbTipoContrato
        '
        Me.CbTipoContrato.FormattingEnabled = True
        Me.CbTipoContrato.Location = New System.Drawing.Point(96, 71)
        Me.CbTipoContrato.Name = "CbTipoContrato"
        Me.CbTipoContrato.Size = New System.Drawing.Size(121, 21)
        Me.CbTipoContrato.TabIndex = 2
        '
        'TbDescripcion
        '
        Me.TbDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbDescripcion.Location = New System.Drawing.Point(96, 45)
        Me.TbDescripcion.Name = "TbDescripcion"
        Me.TbDescripcion.Size = New System.Drawing.Size(296, 20)
        Me.TbDescripcion.TabIndex = 1
        '
        'GbModosCastigo
        '
        Me.GbModosCastigo.Controls.Add(Me.DgvEncabezado)
        Me.GbModosCastigo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbModosCastigo.Location = New System.Drawing.Point(0, 139)
        Me.GbModosCastigo.Name = "GbModosCastigo"
        Me.GbModosCastigo.Size = New System.Drawing.Size(684, 121)
        Me.GbModosCastigo.TabIndex = 2
        Me.GbModosCastigo.TabStop = False
        Me.GbModosCastigo.Text = "Modos de Castigo"
        '
        'DgvEncabezado
        '
        Me.DgvEncabezado.AllowUserToAddRows = False
        Me.DgvEncabezado.AllowUserToDeleteRows = False
        Me.DgvEncabezado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEncabezado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvEncabezado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvEncabezado.Location = New System.Drawing.Point(3, 16)
        Me.DgvEncabezado.Name = "DgvEncabezado"
        Me.DgvEncabezado.ReadOnly = True
        Me.DgvEncabezado.RowHeadersVisible = False
        Me.DgvEncabezado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEncabezado.Size = New System.Drawing.Size(678, 102)
        Me.DgvEncabezado.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DgvDetalle)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(0, 260)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(684, 468)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle de Clases"
        '
        'DgvDetalle
        '
        Me.DgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvDetalle.Location = New System.Drawing.Point(3, 79)
        Me.DgvDetalle.MultiSelect = False
        Me.DgvDetalle.Name = "DgvDetalle"
        Me.DgvDetalle.Size = New System.Drawing.Size(678, 386)
        Me.DgvDetalle.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TbCastigo)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.TbRango1)
        Me.GroupBox4.Controls.Add(Me.TbRango2)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(678, 63)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'CastigoResistenciaFibra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 728)
        Me.Controls.Add(Me.GbModosCastigo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GbDatosGenerales)
        Me.Controls.Add(Me.MSMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "CastigoResistenciaFibra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Castigo Por Resistencia de Fibra"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        Me.GbModosCastigo.ResumeLayout(False)
        CType(Me.DgvEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TbIdResistenciaEncabezado As TextBox
    Friend WithEvents TbRango1 As TextBox
    Friend WithEvents TbRango2 As TextBox
    Friend WithEvents TbCastigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GbDatosGenerales As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CbTipoContrato As ComboBox
    Friend WithEvents TbDescripcion As TextBox
    Friend WithEvents GbModosCastigo As GroupBox
    Friend WithEvents DgvEncabezado As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DgvDetalle As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
End Class
