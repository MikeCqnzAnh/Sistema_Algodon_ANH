<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModalidadesVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModalidadesVenta))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvClasificacion = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TbDescripcion = New System.Windows.Forms.TextBox()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.TbIdModoVenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DgvModosVenta = New System.Windows.Forms.DataGridView()
        Me.MsMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvClasificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvModosVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvClasificacion)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 378)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(611, 298)
        Me.GroupBox2.TabIndex = 21
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TbDescripcion)
        Me.GroupBox1.Controls.Add(Me.CbEstatus)
        Me.GroupBox1.Controls.Add(Me.TbIdModoVenta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(587, 99)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'TbDescripcion
        '
        Me.TbDescripcion.Location = New System.Drawing.Point(94, 44)
        Me.TbDescripcion.Name = "TbDescripcion"
        Me.TbDescripcion.Size = New System.Drawing.Size(297, 20)
        Me.TbDescripcion.TabIndex = 2
        '
        'CbEstatus
        '
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(94, 72)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.CbEstatus.TabIndex = 15
        '
        'TbIdModoVenta
        '
        Me.TbIdModoVenta.Enabled = False
        Me.TbIdModoVenta.Location = New System.Drawing.Point(94, 18)
        Me.TbIdModoVenta.Name = "TbIdModoVenta"
        Me.TbIdModoVenta.Size = New System.Drawing.Size(121, 20)
        Me.TbIdModoVenta.TabIndex = 2
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Estatus"
        '
        'DgvModosVenta
        '
        Me.DgvModosVenta.AllowUserToAddRows = False
        Me.DgvModosVenta.AllowUserToDeleteRows = False
        Me.DgvModosVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvModosVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvModosVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvModosVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvModosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvModosVenta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvModosVenta.Location = New System.Drawing.Point(12, 138)
        Me.DgvModosVenta.MultiSelect = False
        Me.DgvModosVenta.Name = "DgvModosVenta"
        Me.DgvModosVenta.ReadOnly = True
        Me.DgvModosVenta.RowHeadersVisible = False
        Me.DgvModosVenta.RowHeadersWidth = 40
        Me.DgvModosVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvModosVenta.Size = New System.Drawing.Size(587, 234)
        Me.DgvModosVenta.TabIndex = 19
        '
        'MsMenu
        '
        Me.MsMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MsMenu.Location = New System.Drawing.Point(0, 0)
        Me.MsMenu.Name = "MsMenu"
        Me.MsMenu.Size = New System.Drawing.Size(611, 24)
        Me.MsMenu.TabIndex = 18
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
        'ModalidadesVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 682)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvModosVenta)
        Me.Controls.Add(Me.MsMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModalidadesVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modalidades de Venta"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvClasificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvModosVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MsMenu.ResumeLayout(False)
        Me.MsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvClasificacion As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TbDescripcion As TextBox
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents TbIdModoVenta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DgvModosVenta As DataGridView
    Friend WithEvents MsMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
