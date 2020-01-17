<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepCompraYventas
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
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TcCompraVentas = New System.Windows.Forms.TabControl()
        Me.TpCompras = New System.Windows.Forms.TabPage()
        Me.TpVentas = New System.Windows.Forms.TabPage()
        Me.GbFiltrosCompras = New System.Windows.Forms.GroupBox()
        Me.GbFiltrosVentas = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbIdProductor = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbIdCompra = New System.Windows.Forms.TextBox()
        Me.BtAceptar = New System.Windows.Forms.Button()
        Me.DgvCompras = New System.Windows.Forms.DataGridView()
        Me.DgvVentas = New System.Windows.Forms.DataGridView()
        Me.BtBuscarProductor = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.TcCompraVentas.SuspendLayout()
        Me.TpCompras.SuspendLayout()
        Me.TpVentas.SuspendLayout()
        Me.GbFiltrosCompras.SuspendLayout()
        CType(Me.DgvCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ImprimirToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1009, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'TcCompraVentas
        '
        Me.TcCompraVentas.Controls.Add(Me.TpCompras)
        Me.TcCompraVentas.Controls.Add(Me.TpVentas)
        Me.TcCompraVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TcCompraVentas.Location = New System.Drawing.Point(0, 24)
        Me.TcCompraVentas.Name = "TcCompraVentas"
        Me.TcCompraVentas.SelectedIndex = 0
        Me.TcCompraVentas.Size = New System.Drawing.Size(1009, 580)
        Me.TcCompraVentas.TabIndex = 1
        '
        'TpCompras
        '
        Me.TpCompras.Controls.Add(Me.DgvCompras)
        Me.TpCompras.Controls.Add(Me.GbFiltrosCompras)
        Me.TpCompras.Location = New System.Drawing.Point(4, 22)
        Me.TpCompras.Name = "TpCompras"
        Me.TpCompras.Padding = New System.Windows.Forms.Padding(3)
        Me.TpCompras.Size = New System.Drawing.Size(1001, 554)
        Me.TpCompras.TabIndex = 0
        Me.TpCompras.Text = "Compras"
        Me.TpCompras.UseVisualStyleBackColor = True
        '
        'TpVentas
        '
        Me.TpVentas.Controls.Add(Me.DgvVentas)
        Me.TpVentas.Controls.Add(Me.GbFiltrosVentas)
        Me.TpVentas.Location = New System.Drawing.Point(4, 22)
        Me.TpVentas.Name = "TpVentas"
        Me.TpVentas.Padding = New System.Windows.Forms.Padding(3)
        Me.TpVentas.Size = New System.Drawing.Size(1001, 554)
        Me.TpVentas.TabIndex = 1
        Me.TpVentas.Text = "Ventas"
        Me.TpVentas.UseVisualStyleBackColor = True
        '
        'GbFiltrosCompras
        '
        Me.GbFiltrosCompras.Controls.Add(Me.BtAceptar)
        Me.GbFiltrosCompras.Controls.Add(Me.TbIdCompra)
        Me.GbFiltrosCompras.Controls.Add(Me.Label2)
        Me.GbFiltrosCompras.Controls.Add(Me.TextBox2)
        Me.GbFiltrosCompras.Controls.Add(Me.BtBuscarProductor)
        Me.GbFiltrosCompras.Controls.Add(Me.TbIdProductor)
        Me.GbFiltrosCompras.Controls.Add(Me.Label1)
        Me.GbFiltrosCompras.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbFiltrosCompras.Location = New System.Drawing.Point(3, 3)
        Me.GbFiltrosCompras.Name = "GbFiltrosCompras"
        Me.GbFiltrosCompras.Size = New System.Drawing.Size(995, 57)
        Me.GbFiltrosCompras.TabIndex = 0
        Me.GbFiltrosCompras.TabStop = False
        Me.GbFiltrosCompras.Text = "Filtros"
        '
        'GbFiltrosVentas
        '
        Me.GbFiltrosVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbFiltrosVentas.Location = New System.Drawing.Point(3, 3)
        Me.GbFiltrosVentas.Name = "GbFiltrosVentas"
        Me.GbFiltrosVentas.Size = New System.Drawing.Size(995, 100)
        Me.GbFiltrosVentas.TabIndex = 0
        Me.GbFiltrosVentas.TabStop = False
        Me.GbFiltrosVentas.Text = "Filtros"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Productor :"
        '
        'TbIdProductor
        '
        Me.TbIdProductor.Location = New System.Drawing.Point(72, 17)
        Me.TbIdProductor.MaxLength = 10
        Me.TbIdProductor.Name = "TbIdProductor"
        Me.TbIdProductor.Size = New System.Drawing.Size(58, 20)
        Me.TbIdProductor.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(166, 17)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(448, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(620, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Compra :"
        '
        'TbIdCompra
        '
        Me.TbIdCompra.Location = New System.Drawing.Point(675, 17)
        Me.TbIdCompra.MaxLength = 10
        Me.TbIdCompra.Name = "TbIdCompra"
        Me.TbIdCompra.Size = New System.Drawing.Size(63, 20)
        Me.TbIdCompra.TabIndex = 5
        '
        'BtAceptar
        '
        Me.BtAceptar.Location = New System.Drawing.Point(855, 15)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtAceptar.TabIndex = 6
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'DgvCompras
        '
        Me.DgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCompras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCompras.Location = New System.Drawing.Point(3, 60)
        Me.DgvCompras.Name = "DgvCompras"
        Me.DgvCompras.Size = New System.Drawing.Size(995, 491)
        Me.DgvCompras.TabIndex = 1
        '
        'DgvVentas
        '
        Me.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvVentas.Location = New System.Drawing.Point(3, 103)
        Me.DgvVentas.Name = "DgvVentas"
        Me.DgvVentas.Size = New System.Drawing.Size(995, 448)
        Me.DgvVentas.TabIndex = 1
        '
        'BtBuscarProductor
        '
        Me.BtBuscarProductor.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.search
        Me.BtBuscarProductor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtBuscarProductor.Location = New System.Drawing.Point(136, 15)
        Me.BtBuscarProductor.Name = "BtBuscarProductor"
        Me.BtBuscarProductor.Size = New System.Drawing.Size(24, 23)
        Me.BtBuscarProductor.TabIndex = 2
        Me.BtBuscarProductor.UseVisualStyleBackColor = True
        '
        'RepCompraYventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 604)
        Me.Controls.Add(Me.TcCompraVentas)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RepCompraYventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reporte Compras y Ventas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TcCompraVentas.ResumeLayout(False)
        Me.TpCompras.ResumeLayout(False)
        Me.TpVentas.ResumeLayout(False)
        Me.GbFiltrosCompras.ResumeLayout(False)
        Me.GbFiltrosCompras.PerformLayout()
        CType(Me.DgvCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TcCompraVentas As TabControl
    Friend WithEvents TpCompras As TabPage
    Friend WithEvents GbFiltrosCompras As GroupBox
    Friend WithEvents TpVentas As TabPage
    Friend WithEvents GbFiltrosVentas As GroupBox
    Friend WithEvents TbIdCompra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BtBuscarProductor As Button
    Friend WithEvents TbIdProductor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtAceptar As Button
    Friend WithEvents DgvCompras As DataGridView
    Friend WithEvents DgvVentas As DataGridView
End Class
