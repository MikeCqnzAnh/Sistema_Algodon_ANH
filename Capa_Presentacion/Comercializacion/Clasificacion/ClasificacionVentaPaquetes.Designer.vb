<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClasificacionVentaPaquetes
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
        Me.GbProductos = New System.Windows.Forms.GroupBox()
        Me.NuCantidadPacas = New System.Windows.Forms.NumericUpDown()
        Me.NuPromedioUI = New System.Windows.Forms.NumericUpDown()
        Me.chkfinalizado = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.TbIdPaquete = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbEntrega = New System.Windows.Forms.TextBox()
        Me.TbDescripcion = New System.Windows.Forms.TextBox()
        Me.CbComprador = New System.Windows.Forms.ComboBox()
        Me.CbClases = New System.Windows.Forms.ComboBox()
        Me.TbNoPaca = New System.Windows.Forms.TextBox()
        Me.CbPlanta = New System.Windows.Forms.ComboBox()
        Me.BtIgualarClasificacion = New System.Windows.Forms.Button()
        Me.BtRevisarClases = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirClasesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirHVIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchivoExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchivoAccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPacasSeleccionadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GbDgv = New System.Windows.Forms.GroupBox()
        Me.DgvPacasClasificacion1 = New Capa_Presentacion.ClasificacionVentaPaquetes.DgvPlus()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GbSeleccionarTodasPacas = New System.Windows.Forms.GroupBox()
        Me.BtSeleccionarTodo = New System.Windows.Forms.Button()
        Me.BtDeseleccionarTodo = New System.Windows.Forms.Button()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbProductos.SuspendLayout()
        CType(Me.NuCantidadPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuPromedioUI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GbDgv.SuspendLayout()
        CType(Me.DgvPacasClasificacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbSeleccionarTodasPacas.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbProductos
        '
        Me.GbProductos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GbProductos.Controls.Add(Me.NuCantidadPacas)
        Me.GbProductos.Controls.Add(Me.NuPromedioUI)
        Me.GbProductos.Controls.Add(Me.chkfinalizado)
        Me.GbProductos.Controls.Add(Me.Label8)
        Me.GbProductos.Controls.Add(Me.CbEstatus)
        Me.GbProductos.Controls.Add(Me.TbIdPaquete)
        Me.GbProductos.Controls.Add(Me.Label6)
        Me.GbProductos.Controls.Add(Me.TbEntrega)
        Me.GbProductos.Controls.Add(Me.TbDescripcion)
        Me.GbProductos.Controls.Add(Me.CbComprador)
        Me.GbProductos.Controls.Add(Me.CbClases)
        Me.GbProductos.Controls.Add(Me.TbNoPaca)
        Me.GbProductos.Controls.Add(Me.CbPlanta)
        Me.GbProductos.Controls.Add(Me.BtIgualarClasificacion)
        Me.GbProductos.Controls.Add(Me.BtRevisarClases)
        Me.GbProductos.Controls.Add(Me.Label3)
        Me.GbProductos.Controls.Add(Me.Label10)
        Me.GbProductos.Controls.Add(Me.Label9)
        Me.GbProductos.Controls.Add(Me.Label7)
        Me.GbProductos.Controls.Add(Me.Label5)
        Me.GbProductos.Controls.Add(Me.Label4)
        Me.GbProductos.Controls.Add(Me.Label2)
        Me.GbProductos.Controls.Add(Me.Label1)
        Me.GbProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbProductos.Location = New System.Drawing.Point(0, 24)
        Me.GbProductos.Name = "GbProductos"
        Me.GbProductos.Size = New System.Drawing.Size(1561, 206)
        Me.GbProductos.TabIndex = 0
        Me.GbProductos.TabStop = False
        '
        'NuCantidadPacas
        '
        Me.NuCantidadPacas.Enabled = False
        Me.NuCantidadPacas.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuCantidadPacas.Location = New System.Drawing.Point(909, 145)
        Me.NuCantidadPacas.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.NuCantidadPacas.Name = "NuCantidadPacas"
        Me.NuCantidadPacas.Size = New System.Drawing.Size(184, 49)
        Me.NuCantidadPacas.TabIndex = 11
        Me.NuCantidadPacas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NuPromedioUI
        '
        Me.NuPromedioUI.DecimalPlaces = 2
        Me.NuPromedioUI.Enabled = False
        Me.NuPromedioUI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuPromedioUI.Location = New System.Drawing.Point(774, 53)
        Me.NuPromedioUI.Name = "NuPromedioUI"
        Me.NuPromedioUI.Size = New System.Drawing.Size(91, 20)
        Me.NuPromedioUI.TabIndex = 11
        Me.NuPromedioUI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkfinalizado
        '
        Me.chkfinalizado.AutoSize = True
        Me.chkfinalizado.Location = New System.Drawing.Point(909, 55)
        Me.chkfinalizado.Name = "chkfinalizado"
        Me.chkfinalizado.Size = New System.Drawing.Size(118, 17)
        Me.chkfinalizado.TabIndex = 10
        Me.chkfinalizado.Text = "Paquete terminado."
        Me.chkfinalizado.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(483, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Estatus"
        '
        'CbEstatus
        '
        Me.CbEstatus.Enabled = False
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(547, 52)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.CbEstatus.TabIndex = 8
        '
        'TbIdPaquete
        '
        Me.TbIdPaquete.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbIdPaquete.Location = New System.Drawing.Point(166, 91)
        Me.TbIdPaquete.MaxLength = 10
        Me.TbIdPaquete.Name = "TbIdPaquete"
        Me.TbIdPaquete.Size = New System.Drawing.Size(275, 44)
        Me.TbIdPaquete.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 37)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Paquete"
        '
        'TbEntrega
        '
        Me.TbEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbEntrega.Location = New System.Drawing.Point(337, 52)
        Me.TbEntrega.Name = "TbEntrega"
        Me.TbEntrega.Size = New System.Drawing.Size(91, 20)
        Me.TbEntrega.TabIndex = 5
        Me.TbEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbDescripcion
        '
        Me.TbDescripcion.Enabled = False
        Me.TbDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbDescripcion.Location = New System.Drawing.Point(75, 52)
        Me.TbDescripcion.Multiline = True
        Me.TbDescripcion.Name = "TbDescripcion"
        Me.TbDescripcion.Size = New System.Drawing.Size(133, 20)
        Me.TbDescripcion.TabIndex = 5
        Me.TbDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CbComprador
        '
        Me.CbComprador.FormattingEnabled = True
        Me.CbComprador.Location = New System.Drawing.Point(547, 11)
        Me.CbComprador.Name = "CbComprador"
        Me.CbComprador.Size = New System.Drawing.Size(223, 21)
        Me.CbComprador.TabIndex = 4
        '
        'CbClases
        '
        Me.CbClases.FormattingEnabled = True
        Me.CbClases.Location = New System.Drawing.Point(337, 11)
        Me.CbClases.Name = "CbClases"
        Me.CbClases.Size = New System.Drawing.Size(121, 21)
        Me.CbClases.TabIndex = 4
        '
        'TbNoPaca
        '
        Me.TbNoPaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNoPaca.Location = New System.Drawing.Point(166, 150)
        Me.TbNoPaca.Name = "TbNoPaca"
        Me.TbNoPaca.Size = New System.Drawing.Size(275, 44)
        Me.TbNoPaca.TabIndex = 3
        '
        'CbPlanta
        '
        Me.CbPlanta.FormattingEnabled = True
        Me.CbPlanta.Location = New System.Drawing.Point(75, 14)
        Me.CbPlanta.Name = "CbPlanta"
        Me.CbPlanta.Size = New System.Drawing.Size(180, 21)
        Me.CbPlanta.TabIndex = 2
        '
        'BtIgualarClasificacion
        '
        Me.BtIgualarClasificacion.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtIgualarClasificacion.Location = New System.Drawing.Point(1313, 16)
        Me.BtIgualarClasificacion.Name = "BtIgualarClasificacion"
        Me.BtIgualarClasificacion.Size = New System.Drawing.Size(126, 187)
        Me.BtIgualarClasificacion.TabIndex = 1
        Me.BtIgualarClasificacion.Text = "Igualar Clasificacion"
        Me.BtIgualarClasificacion.UseVisualStyleBackColor = True
        '
        'BtRevisarClases
        '
        Me.BtRevisarClases.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtRevisarClases.Location = New System.Drawing.Point(1439, 16)
        Me.BtRevisarClases.Name = "BtRevisarClases"
        Me.BtRevisarClases.Size = New System.Drawing.Size(119, 187)
        Me.BtRevisarClases.TabIndex = 1
        Me.BtRevisarClases.Text = "Revisar Clases De  Paquete"
        Me.BtRevisarClases.UseVisualStyleBackColor = True
        Me.BtRevisarClases.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(705, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Promedio UI"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(483, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Comprador"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(273, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Entrega"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(738, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 37)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cantidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Descripcion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(273, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Clase"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 37)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "No. Paca"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Planta"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.ImprimirToolStripMenuItem, Me.ExportarToolStripMenuItem, Me.EliminarPacasSeleccionadasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1561, 24)
        Me.MenuStrip1.TabIndex = 1
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
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.BuscarToolStripMenuItem.Text = "Consultar"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirClasesToolStripMenuItem1, Me.ImprimirHVIToolStripMenuItem})
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'ImprimirClasesToolStripMenuItem1
        '
        Me.ImprimirClasesToolStripMenuItem1.Name = "ImprimirClasesToolStripMenuItem1"
        Me.ImprimirClasesToolStripMenuItem1.Size = New System.Drawing.Size(156, 22)
        Me.ImprimirClasesToolStripMenuItem1.Text = "Imprimir Clases"
        '
        'ImprimirHVIToolStripMenuItem
        '
        Me.ImprimirHVIToolStripMenuItem.Name = "ImprimirHVIToolStripMenuItem"
        Me.ImprimirHVIToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ImprimirHVIToolStripMenuItem.Text = "Imprimir HVI"
        '
        'ExportarToolStripMenuItem
        '
        Me.ExportarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoExcelToolStripMenuItem, Me.ArchivoAccessToolStripMenuItem})
        Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ExportarToolStripMenuItem.Text = "Exportar"
        '
        'ArchivoExcelToolStripMenuItem
        '
        Me.ArchivoExcelToolStripMenuItem.Name = "ArchivoExcelToolStripMenuItem"
        Me.ArchivoExcelToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ArchivoExcelToolStripMenuItem.Text = "Archivo Excel"
        '
        'ArchivoAccessToolStripMenuItem
        '
        Me.ArchivoAccessToolStripMenuItem.Name = "ArchivoAccessToolStripMenuItem"
        Me.ArchivoAccessToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ArchivoAccessToolStripMenuItem.Text = "Archivo Access"
        '
        'EliminarPacasSeleccionadasToolStripMenuItem
        '
        Me.EliminarPacasSeleccionadasToolStripMenuItem.Name = "EliminarPacasSeleccionadasToolStripMenuItem"
        Me.EliminarPacasSeleccionadasToolStripMenuItem.Size = New System.Drawing.Size(172, 20)
        Me.EliminarPacasSeleccionadasToolStripMenuItem.Text = "Eliminar Pacas Seleccionadas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GbDgv
        '
        Me.GbDgv.Controls.Add(Me.DgvPacasClasificacion1)
        Me.GbDgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbDgv.Location = New System.Drawing.Point(0, 230)
        Me.GbDgv.Name = "GbDgv"
        Me.GbDgv.Size = New System.Drawing.Size(1460, 508)
        Me.GbDgv.TabIndex = 66
        Me.GbDgv.TabStop = False
        '
        'DgvPacasClasificacion1
        '
        Me.DgvPacasClasificacion1.AllowUserToAddRows = False
        Me.DgvPacasClasificacion1.AllowUserToDeleteRows = False
        Me.DgvPacasClasificacion1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacasClasificacion1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvPacasClasificacion1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvPacasClasificacion1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvPacasClasificacion1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacasClasificacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacasClasificacion1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvPacasClasificacion1.Location = New System.Drawing.Point(3, 16)
        Me.DgvPacasClasificacion1.MultiSelect = False
        Me.DgvPacasClasificacion1.Name = "DgvPacasClasificacion1"
        Me.DgvPacasClasificacion1.RowHeadersWidth = 40
        Me.DgvPacasClasificacion1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvPacasClasificacion1.Size = New System.Drawing.Size(1454, 489)
        Me.DgvPacasClasificacion1.TabIndex = 15
        '
        'Sel
        '
        Me.Sel.HeaderText = "Seleccion"
        Me.Sel.Name = "Sel"
        '
        'GbSeleccionarTodasPacas
        '
        Me.GbSeleccionarTodasPacas.Controls.Add(Me.BtDeseleccionarTodo)
        Me.GbSeleccionarTodasPacas.Controls.Add(Me.BtSeleccionarTodo)
        Me.GbSeleccionarTodasPacas.Dock = System.Windows.Forms.DockStyle.Right
        Me.GbSeleccionarTodasPacas.Location = New System.Drawing.Point(1460, 230)
        Me.GbSeleccionarTodasPacas.Name = "GbSeleccionarTodasPacas"
        Me.GbSeleccionarTodasPacas.Size = New System.Drawing.Size(101, 508)
        Me.GbSeleccionarTodasPacas.TabIndex = 67
        Me.GbSeleccionarTodasPacas.TabStop = False
        '
        'BtSeleccionarTodo
        '
        Me.BtSeleccionarTodo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtSeleccionarTodo.Location = New System.Drawing.Point(3, 16)
        Me.BtSeleccionarTodo.Name = "BtSeleccionarTodo"
        Me.BtSeleccionarTodo.Size = New System.Drawing.Size(95, 38)
        Me.BtSeleccionarTodo.TabIndex = 0
        Me.BtSeleccionarTodo.Text = "Seleccionar Todo"
        Me.BtSeleccionarTodo.UseVisualStyleBackColor = True
        '
        'BtDeseleccionarTodo
        '
        Me.BtDeseleccionarTodo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtDeseleccionarTodo.Location = New System.Drawing.Point(3, 54)
        Me.BtDeseleccionarTodo.Name = "BtDeseleccionarTodo"
        Me.BtDeseleccionarTodo.Size = New System.Drawing.Size(95, 41)
        Me.BtDeseleccionarTodo.TabIndex = 1
        Me.BtDeseleccionarTodo.Text = "Deseleccionar Todo"
        Me.BtDeseleccionarTodo.UseVisualStyleBackColor = True
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'ClasificacionVentaPaquetes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1561, 738)
        Me.Controls.Add(Me.GbDgv)
        Me.Controls.Add(Me.GbSeleccionarTodasPacas)
        Me.Controls.Add(Me.GbProductos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1090, 550)
        Me.Name = "ClasificacionVentaPaquetes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clasificacion de Venta "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbProductos.ResumeLayout(False)
        Me.GbProductos.PerformLayout()
        CType(Me.NuCantidadPacas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuPromedioUI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GbDgv.ResumeLayout(False)
        CType(Me.DgvPacasClasificacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbSeleccionarTodasPacas.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbProductos As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtIgualarClasificacion As Button
    Friend WithEvents BtRevisarClases As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TbNoPaca As TextBox
    Friend WithEvents CbPlanta As ComboBox
    Friend WithEvents CbClases As ComboBox
    Friend WithEvents TbDescripcion As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GbDgv As GroupBox
    Friend WithEvents EliminarPacasSeleccionadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Sel As DataGridViewCheckBoxColumn
    Friend WithEvents DgvPacasClasificacion1 As DgvPlus
    Friend WithEvents TbIdPaquete As TextBox

    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label

    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents chkfinalizado As CheckBox
    Friend WithEvents NuPromedioUI As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents TbEntrega As TextBox

    Friend WithEvents Label9 As Label
    Friend WithEvents CbComprador As ComboBox

    Friend WithEvents Label10 As Label
    Friend WithEvents ExportarToolStripMenuItem As ToolStripMenuItem

    Friend WithEvents ArchivoExcelToolStripMenuItem As ToolStripMenuItem

    Friend WithEvents ArchivoAccessToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuCantidadPacas As NumericUpDown
    Friend WithEvents ImprimirClasesToolStripMenuItem1 As ToolStripMenuItem

    Friend WithEvents ImprimirHVIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GbSeleccionarTodasPacas As GroupBox
    Friend WithEvents BtDeseleccionarTodo As Button

    Friend WithEvents BtSeleccionarTodo As Button
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem

    Public Class DgvPlus
        Inherits DataGridView
        Protected Overrides Function ProcessDialogKey(keyData As Keys) As Boolean
            If keyData = Keys.Enter Then
                'If Me.CurrentCell.ColumnIndex = Me.ColumnCount - 1 Then
                ClasificacionVentaPaquetes.EditaFila()
                SendKeys.Send(Chr(Keys.Tab))
                ' ClasificacionVentaPaquetes.TextBox_PreviewKeyDown()
                Return True
                'End If
            Else
                Return MyBase.ProcessDialogKey(keyData)
            End If
        End Function

        Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
            If e.KeyData = Keys.Enter Then
                SendKeys.Send(Chr(Keys.Tab))
            Else
                MyBase.OnKeyDown(e)
            End If
        End Sub
    End Class
End Class
