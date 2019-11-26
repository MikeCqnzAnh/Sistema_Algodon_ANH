<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentaClasificacion
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
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.NuPromedioUI = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtIgualarClasificacion = New System.Windows.Forms.Button()
        Me.BtRevisarClases = New System.Windows.Forms.Button()
        Me.NuCantidadPacas = New System.Windows.Forms.NumericUpDown()
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GbRegistros = New System.Windows.Forms.GroupBox()
        Me.DgvPacasClasificacion = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteClasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteHVIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchivoExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchivoAccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPacasSeleccionadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbSeleccionarTodasPacas = New System.Windows.Forms.GroupBox()
        Me.BtDeseleccionarTodo = New System.Windows.Forms.Button()
        Me.BtSeleccionarTodo = New System.Windows.Forms.Button()
        Me.GbDatos.SuspendLayout()
        CType(Me.NuPromedioUI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuCantidadPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbRegistros.SuspendLayout()
        CType(Me.DgvPacasClasificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GbSeleccionarTodasPacas.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.NuPromedioUI)
        Me.GbDatos.Controls.Add(Me.Label3)
        Me.GbDatos.Controls.Add(Me.BtIgualarClasificacion)
        Me.GbDatos.Controls.Add(Me.BtRevisarClases)
        Me.GbDatos.Controls.Add(Me.NuCantidadPacas)
        Me.GbDatos.Controls.Add(Me.Label8)
        Me.GbDatos.Controls.Add(Me.CbEstatus)
        Me.GbDatos.Controls.Add(Me.TbIdPaquete)
        Me.GbDatos.Controls.Add(Me.Label6)
        Me.GbDatos.Controls.Add(Me.TbEntrega)
        Me.GbDatos.Controls.Add(Me.TbDescripcion)
        Me.GbDatos.Controls.Add(Me.CbComprador)
        Me.GbDatos.Controls.Add(Me.CbClases)
        Me.GbDatos.Controls.Add(Me.TbNoPaca)
        Me.GbDatos.Controls.Add(Me.CbPlanta)
        Me.GbDatos.Controls.Add(Me.Label10)
        Me.GbDatos.Controls.Add(Me.Label9)
        Me.GbDatos.Controls.Add(Me.Label7)
        Me.GbDatos.Controls.Add(Me.Label5)
        Me.GbDatos.Controls.Add(Me.Label4)
        Me.GbDatos.Controls.Add(Me.Label2)
        Me.GbDatos.Controls.Add(Me.Label1)
        Me.GbDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatos.Location = New System.Drawing.Point(0, 24)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(1351, 210)
        Me.GbDatos.TabIndex = 0
        Me.GbDatos.TabStop = False
        '
        'NuPromedioUI
        '
        Me.NuPromedioUI.DecimalPlaces = 2
        Me.NuPromedioUI.Enabled = False
        Me.NuPromedioUI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuPromedioUI.Location = New System.Drawing.Point(774, 52)
        Me.NuPromedioUI.Name = "NuPromedioUI"
        Me.NuPromedioUI.Size = New System.Drawing.Size(91, 20)
        Me.NuPromedioUI.TabIndex = 6
        Me.NuPromedioUI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(705, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Promedio UI"
        '
        'BtIgualarClasificacion
        '
        Me.BtIgualarClasificacion.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtIgualarClasificacion.Location = New System.Drawing.Point(1103, 16)
        Me.BtIgualarClasificacion.Name = "BtIgualarClasificacion"
        Me.BtIgualarClasificacion.Size = New System.Drawing.Size(126, 191)
        Me.BtIgualarClasificacion.TabIndex = 9
        Me.BtIgualarClasificacion.Text = "Igualar Clasificacion"
        Me.BtIgualarClasificacion.UseVisualStyleBackColor = True
        '
        'BtRevisarClases
        '
        Me.BtRevisarClases.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtRevisarClases.Location = New System.Drawing.Point(1229, 16)
        Me.BtRevisarClases.Name = "BtRevisarClases"
        Me.BtRevisarClases.Size = New System.Drawing.Size(119, 191)
        Me.BtRevisarClases.TabIndex = 31
        Me.BtRevisarClases.Text = "Revisar Clases De  Paquete"
        Me.BtRevisarClases.UseVisualStyleBackColor = True
        Me.BtRevisarClases.Visible = False
        '
        'NuCantidadPacas
        '
        Me.NuCantidadPacas.Enabled = False
        Me.NuCantidadPacas.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuCantidadPacas.Location = New System.Drawing.Point(909, 144)
        Me.NuCantidadPacas.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.NuCantidadPacas.Name = "NuCantidadPacas"
        Me.NuCantidadPacas.Size = New System.Drawing.Size(184, 49)
        Me.NuCantidadPacas.TabIndex = 29
        Me.NuCantidadPacas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(483, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Estatus"
        '
        'CbEstatus
        '
        Me.CbEstatus.Enabled = False
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(547, 51)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.CbEstatus.TabIndex = 5
        '
        'TbIdPaquete
        '
        Me.TbIdPaquete.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbIdPaquete.Location = New System.Drawing.Point(166, 90)
        Me.TbIdPaquete.MaxLength = 10
        Me.TbIdPaquete.Name = "TbIdPaquete"
        Me.TbIdPaquete.Size = New System.Drawing.Size(275, 44)
        Me.TbIdPaquete.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 37)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Paquete"
        '
        'TbEntrega
        '
        Me.TbEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbEntrega.Location = New System.Drawing.Point(337, 51)
        Me.TbEntrega.Name = "TbEntrega"
        Me.TbEntrega.Size = New System.Drawing.Size(91, 20)
        Me.TbEntrega.TabIndex = 4
        Me.TbEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbDescripcion
        '
        Me.TbDescripcion.Enabled = False
        Me.TbDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbDescripcion.Location = New System.Drawing.Point(75, 51)
        Me.TbDescripcion.Multiline = True
        Me.TbDescripcion.Name = "TbDescripcion"
        Me.TbDescripcion.Size = New System.Drawing.Size(133, 20)
        Me.TbDescripcion.TabIndex = 3
        Me.TbDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CbComprador
        '
        Me.CbComprador.FormattingEnabled = True
        Me.CbComprador.Location = New System.Drawing.Point(547, 10)
        Me.CbComprador.Name = "CbComprador"
        Me.CbComprador.Size = New System.Drawing.Size(223, 21)
        Me.CbComprador.TabIndex = 2
        '
        'CbClases
        '
        Me.CbClases.FormattingEnabled = True
        Me.CbClases.Location = New System.Drawing.Point(337, 10)
        Me.CbClases.Name = "CbClases"
        Me.CbClases.Size = New System.Drawing.Size(121, 21)
        Me.CbClases.TabIndex = 1
        '
        'TbNoPaca
        '
        Me.TbNoPaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNoPaca.Location = New System.Drawing.Point(166, 149)
        Me.TbNoPaca.Name = "TbNoPaca"
        Me.TbNoPaca.Size = New System.Drawing.Size(275, 44)
        Me.TbNoPaca.TabIndex = 8
        '
        'CbPlanta
        '
        Me.CbPlanta.FormattingEnabled = True
        Me.CbPlanta.Location = New System.Drawing.Point(75, 13)
        Me.CbPlanta.Name = "CbPlanta"
        Me.CbPlanta.Size = New System.Drawing.Size(180, 21)
        Me.CbPlanta.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(483, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Comprador"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(273, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Entrega"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(738, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 37)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Cantidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Descripcion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(273, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Clase"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 37)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "No. Paca"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Planta"
        '
        'GbRegistros
        '
        Me.GbRegistros.Controls.Add(Me.DgvPacasClasificacion)
        Me.GbRegistros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbRegistros.Location = New System.Drawing.Point(0, 234)
        Me.GbRegistros.Name = "GbRegistros"
        Me.GbRegistros.Size = New System.Drawing.Size(1250, 362)
        Me.GbRegistros.TabIndex = 1
        Me.GbRegistros.TabStop = False
        '
        'DgvPacasClasificacion
        '
        Me.DgvPacasClasificacion.AllowUserToAddRows = False
        Me.DgvPacasClasificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacasClasificacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvPacasClasificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacasClasificacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacasClasificacion.Location = New System.Drawing.Point(3, 16)
        Me.DgvPacasClasificacion.Name = "DgvPacasClasificacion"
        Me.DgvPacasClasificacion.Size = New System.Drawing.Size(1244, 343)
        Me.DgvPacasClasificacion.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.ImprimirToolStripMenuItem, Me.ExportarToolStripMenuItem, Me.EliminarPacasSeleccionadasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1351, 24)
        Me.MenuStrip1.TabIndex = 30
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
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteClasesToolStripMenuItem, Me.ReporteHVIToolStripMenuItem})
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'ReporteClasesToolStripMenuItem
        '
        Me.ReporteClasesToolStripMenuItem.Name = "ReporteClasesToolStripMenuItem"
        Me.ReporteClasesToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ReporteClasesToolStripMenuItem.Text = "Reporte Clases"
        '
        'ReporteHVIToolStripMenuItem
        '
        Me.ReporteHVIToolStripMenuItem.Name = "ReporteHVIToolStripMenuItem"
        Me.ReporteHVIToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ReporteHVIToolStripMenuItem.Text = "Reporte HVI"
        '
        'ExportarToolStripMenuItem
        '
        Me.ExportarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoExcelToolStripMenuItem, Me.ArchivoAccessToolStripMenuItem})
        Me.ExportarToolStripMenuItem.Name = "ExportarToolStripMenuItem"
        Me.ExportarToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
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
        'GbSeleccionarTodasPacas
        '
        Me.GbSeleccionarTodasPacas.Controls.Add(Me.BtDeseleccionarTodo)
        Me.GbSeleccionarTodasPacas.Controls.Add(Me.BtSeleccionarTodo)
        Me.GbSeleccionarTodasPacas.Dock = System.Windows.Forms.DockStyle.Right
        Me.GbSeleccionarTodasPacas.Location = New System.Drawing.Point(1250, 234)
        Me.GbSeleccionarTodasPacas.Name = "GbSeleccionarTodasPacas"
        Me.GbSeleccionarTodasPacas.Size = New System.Drawing.Size(101, 362)
        Me.GbSeleccionarTodasPacas.TabIndex = 68
        Me.GbSeleccionarTodasPacas.TabStop = False
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
        'VentaClasificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1351, 596)
        Me.Controls.Add(Me.GbRegistros)
        Me.Controls.Add(Me.GbSeleccionarTodasPacas)
        Me.Controls.Add(Me.GbDatos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "VentaClasificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clasificacion para Venta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        CType(Me.NuPromedioUI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuCantidadPacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbRegistros.ResumeLayout(False)
        CType(Me.DgvPacasClasificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GbSeleccionarTodasPacas.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents GbRegistros As GroupBox
    Friend WithEvents DgvPacasClasificacion As DataGridView
    Friend WithEvents NuCantidadPacas As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents TbIdPaquete As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbEntrega As TextBox
    Friend WithEvents TbDescripcion As TextBox
    Friend WithEvents CbComprador As ComboBox
    Friend WithEvents CbClases As ComboBox
    Friend WithEvents TbNoPaca As TextBox
    Friend WithEvents CbPlanta As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarPacasSeleccionadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteClasesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteHVIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArchivoExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArchivoAccessToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtIgualarClasificacion As Button
    Friend WithEvents BtRevisarClases As Button
    Friend WithEvents NuPromedioUI As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents GbSeleccionarTodasPacas As GroupBox
    Friend WithEvents BtDeseleccionarTodo As Button
    Friend WithEvents BtSeleccionarTodo As Button
End Class
