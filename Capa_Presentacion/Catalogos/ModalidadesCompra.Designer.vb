<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModalidadesCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModalidadesCompra))
        Me.MsMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbIdModoCompra = New System.Windows.Forms.TextBox()
        Me.TbDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgvModosCompra = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvClasificacion = New System.Windows.Forms.DataGridView()
        Me.MsMenu.SuspendLayout()
        CType(Me.DgvModosCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvClasificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MsMenu
        '
        Me.MsMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MsMenu.Location = New System.Drawing.Point(0, 0)
        Me.MsMenu.Name = "MsMenu"
        Me.MsMenu.Size = New System.Drawing.Size(611, 24)
        Me.MsMenu.TabIndex = 0
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
        'TbIdModoCompra
        '
        Me.TbIdModoCompra.Enabled = False
        Me.TbIdModoCompra.Location = New System.Drawing.Point(94, 18)
        Me.TbIdModoCompra.Name = "TbIdModoCompra"
        Me.TbIdModoCompra.Size = New System.Drawing.Size(121, 20)
        Me.TbIdModoCompra.TabIndex = 2
        '
        'TbDescripcion
        '
        Me.TbDescripcion.Location = New System.Drawing.Point(94, 44)
        Me.TbDescripcion.Name = "TbDescripcion"
        Me.TbDescripcion.Size = New System.Drawing.Size(297, 20)
        Me.TbDescripcion.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripcion"
        '
        'DgvModosCompra
        '
        Me.DgvModosCompra.AllowUserToAddRows = False
        Me.DgvModosCompra.AllowUserToDeleteRows = False
        Me.DgvModosCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvModosCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvModosCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvModosCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvModosCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvModosCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvModosCompra.Location = New System.Drawing.Point(12, 132)
        Me.DgvModosCompra.MultiSelect = False
        Me.DgvModosCompra.Name = "DgvModosCompra"
        Me.DgvModosCompra.ReadOnly = True
        Me.DgvModosCompra.RowHeadersVisible = False
        Me.DgvModosCompra.RowHeadersWidth = 40
        Me.DgvModosCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvModosCompra.Size = New System.Drawing.Size(587, 234)
        Me.DgvModosCompra.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Estatus"
        '
        'CbEstatus
        '
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(94, 72)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.CbEstatus.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TbDescripcion)
        Me.GroupBox1.Controls.Add(Me.CbEstatus)
        Me.GroupBox1.Controls.Add(Me.TbIdModoCompra)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(587, 99)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvClasificacion)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 372)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(611, 298)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle de Clases"
        '
        'DgvClasificacion
        '
        Me.DgvClasificacion.AllowUserToAddRows = False
        Me.DgvClasificacion.AllowUserToDeleteRows = False
        Me.DgvClasificacion.AllowUserToResizeColumns = False
        Me.DgvClasificacion.AllowUserToResizeRows = False
        Me.DgvClasificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvClasificacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvClasificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvClasificacion.Location = New System.Drawing.Point(12, 30)
        Me.DgvClasificacion.Name = "DgvClasificacion"
        Me.DgvClasificacion.RowHeadersVisible = False
        Me.DgvClasificacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvClasificacion.Size = New System.Drawing.Size(587, 258)
        Me.DgvClasificacion.TabIndex = 18
        '
        'ModalidadesCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 682)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvModosCompra)
        Me.Controls.Add(Me.MsMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MsMenu
        Me.Name = "ModalidadesCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modalidades de Compra"
        Me.MsMenu.ResumeLayout(False)
        Me.MsMenu.PerformLayout()
        CType(Me.DgvModosCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvClasificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MsMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TbIdModoCompra As TextBox
    Friend WithEvents TbDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DgvModosCompra As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvClasificacion As DataGridView
End Class
