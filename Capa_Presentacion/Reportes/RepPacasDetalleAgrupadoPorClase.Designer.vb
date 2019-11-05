<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepPacasDetalleAgrupadoPorClase
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
        Me.BtAgrupadoPorClase = New System.Windows.Forms.Button()
        Me.BtDetallado = New System.Windows.Forms.Button()
        Me.CkSinVender = New System.Windows.Forms.CheckBox()
        Me.CkSinComprar = New System.Windows.Forms.CheckBox()
        Me.CkQuemadas = New System.Windows.Forms.CheckBox()
        Me.BtConsultaCliente = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbNombreCliente = New System.Windows.Forms.TextBox()
        Me.TbHastaPaca = New System.Windows.Forms.TextBox()
        Me.TbPredio = New System.Windows.Forms.TextBox()
        Me.TbDesdePaca = New System.Windows.Forms.TextBox()
        Me.TbIdCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbOrdenProduccion = New System.Windows.Forms.ComboBox()
        Me.CbVariedad = New System.Windows.Forms.ComboBox()
        Me.CbClases = New System.Windows.Forms.ComboBox()
        Me.CbPlantaOrigen = New System.Windows.Forms.ComboBox()
        Me.CbPlantaDestino = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CRVRepPacasDetallado = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GbDatos.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.BtAgrupadoPorClase)
        Me.GbDatos.Controls.Add(Me.BtDetallado)
        Me.GbDatos.Controls.Add(Me.CkSinVender)
        Me.GbDatos.Controls.Add(Me.CkSinComprar)
        Me.GbDatos.Controls.Add(Me.CkQuemadas)
        Me.GbDatos.Controls.Add(Me.BtConsultaCliente)
        Me.GbDatos.Controls.Add(Me.Label6)
        Me.GbDatos.Controls.Add(Me.Label9)
        Me.GbDatos.Controls.Add(Me.Label8)
        Me.GbDatos.Controls.Add(Me.Label7)
        Me.GbDatos.Controls.Add(Me.Label5)
        Me.GbDatos.Controls.Add(Me.Label4)
        Me.GbDatos.Controls.Add(Me.Label3)
        Me.GbDatos.Controls.Add(Me.TbNombreCliente)
        Me.GbDatos.Controls.Add(Me.TbHastaPaca)
        Me.GbDatos.Controls.Add(Me.TbPredio)
        Me.GbDatos.Controls.Add(Me.TbDesdePaca)
        Me.GbDatos.Controls.Add(Me.TbIdCliente)
        Me.GbDatos.Controls.Add(Me.Label2)
        Me.GbDatos.Controls.Add(Me.Label1)
        Me.GbDatos.Controls.Add(Me.CbOrdenProduccion)
        Me.GbDatos.Controls.Add(Me.CbVariedad)
        Me.GbDatos.Controls.Add(Me.CbClases)
        Me.GbDatos.Controls.Add(Me.CbPlantaOrigen)
        Me.GbDatos.Controls.Add(Me.CbPlantaDestino)
        Me.GbDatos.Dock = System.Windows.Forms.DockStyle.Left
        Me.GbDatos.Location = New System.Drawing.Point(0, 24)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(367, 704)
        Me.GbDatos.TabIndex = 0
        Me.GbDatos.TabStop = False
        '
        'BtAgrupadoPorClase
        '
        Me.BtAgrupadoPorClase.Location = New System.Drawing.Point(15, 461)
        Me.BtAgrupadoPorClase.Name = "BtAgrupadoPorClase"
        Me.BtAgrupadoPorClase.Size = New System.Drawing.Size(137, 29)
        Me.BtAgrupadoPorClase.TabIndex = 6
        Me.BtAgrupadoPorClase.Text = "Agrupado por Clase"
        Me.BtAgrupadoPorClase.UseVisualStyleBackColor = True
        '
        'BtDetallado
        '
        Me.BtDetallado.Location = New System.Drawing.Point(15, 432)
        Me.BtDetallado.Name = "BtDetallado"
        Me.BtDetallado.Size = New System.Drawing.Size(137, 23)
        Me.BtDetallado.TabIndex = 6
        Me.BtDetallado.Text = "Detallado"
        Me.BtDetallado.UseVisualStyleBackColor = True
        '
        'CkSinVender
        '
        Me.CkSinVender.AutoSize = True
        Me.CkSinVender.Location = New System.Drawing.Point(236, 170)
        Me.CkSinVender.Name = "CkSinVender"
        Me.CkSinVender.Size = New System.Drawing.Size(78, 17)
        Me.CkSinVender.TabIndex = 5
        Me.CkSinVender.Text = "Sin Vender"
        Me.CkSinVender.UseVisualStyleBackColor = True
        '
        'CkSinComprar
        '
        Me.CkSinComprar.AutoSize = True
        Me.CkSinComprar.Location = New System.Drawing.Point(147, 170)
        Me.CkSinComprar.Name = "CkSinComprar"
        Me.CkSinComprar.Size = New System.Drawing.Size(83, 17)
        Me.CkSinComprar.TabIndex = 5
        Me.CkSinComprar.Text = "Sin Comprar"
        Me.CkSinComprar.UseVisualStyleBackColor = True
        '
        'CkQuemadas
        '
        Me.CkQuemadas.AutoSize = True
        Me.CkQuemadas.Location = New System.Drawing.Point(6, 170)
        Me.CkQuemadas.Name = "CkQuemadas"
        Me.CkQuemadas.Size = New System.Drawing.Size(135, 17)
        Me.CkQuemadas.TabIndex = 5
        Me.CkQuemadas.Text = "Imprimir solo quemadas"
        Me.CkQuemadas.UseVisualStyleBackColor = True
        '
        'BtConsultaCliente
        '
        Me.BtConsultaCliente.Location = New System.Drawing.Point(122, 72)
        Me.BtConsultaCliente.Name = "BtConsultaCliente"
        Me.BtConsultaCliente.Size = New System.Drawing.Size(33, 23)
        Me.BtConsultaCliente.TabIndex = 4
        Me.BtConsultaCliente.Text = "..."
        Me.BtConsultaCliente.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(193, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Hasta :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Variedad :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 263)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Clase :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Predio :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Desde paca :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Orden de Produccion :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cliente :"
        '
        'TbNombreCliente
        '
        Me.TbNombreCliente.Location = New System.Drawing.Point(161, 74)
        Me.TbNombreCliente.Name = "TbNombreCliente"
        Me.TbNombreCliente.ReadOnly = True
        Me.TbNombreCliente.Size = New System.Drawing.Size(200, 20)
        Me.TbNombreCliente.TabIndex = 2
        '
        'TbHastaPaca
        '
        Me.TbHastaPaca.Location = New System.Drawing.Point(240, 208)
        Me.TbHastaPaca.Name = "TbHastaPaca"
        Me.TbHastaPaca.Size = New System.Drawing.Size(89, 20)
        Me.TbHastaPaca.TabIndex = 2
        '
        'TbPredio
        '
        Me.TbPredio.Location = New System.Drawing.Point(87, 234)
        Me.TbPredio.Name = "TbPredio"
        Me.TbPredio.Size = New System.Drawing.Size(100, 20)
        Me.TbPredio.TabIndex = 2
        '
        'TbDesdePaca
        '
        Me.TbDesdePaca.Location = New System.Drawing.Point(87, 208)
        Me.TbDesdePaca.Name = "TbDesdePaca"
        Me.TbDesdePaca.Size = New System.Drawing.Size(89, 20)
        Me.TbDesdePaca.TabIndex = 2
        '
        'TbIdCliente
        '
        Me.TbIdCliente.Location = New System.Drawing.Point(13, 74)
        Me.TbIdCliente.MaxLength = 10
        Me.TbIdCliente.Name = "TbIdCliente"
        Me.TbIdCliente.Size = New System.Drawing.Size(103, 20)
        Me.TbIdCliente.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Planta Destino :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Planta Origen :"
        '
        'CbOrdenProduccion
        '
        Me.CbOrdenProduccion.FormattingEnabled = True
        Me.CbOrdenProduccion.Location = New System.Drawing.Point(13, 122)
        Me.CbOrdenProduccion.Name = "CbOrdenProduccion"
        Me.CbOrdenProduccion.Size = New System.Drawing.Size(121, 21)
        Me.CbOrdenProduccion.TabIndex = 0
        '
        'CbVariedad
        '
        Me.CbVariedad.FormattingEnabled = True
        Me.CbVariedad.Location = New System.Drawing.Point(87, 287)
        Me.CbVariedad.Name = "CbVariedad"
        Me.CbVariedad.Size = New System.Drawing.Size(121, 21)
        Me.CbVariedad.TabIndex = 0
        '
        'CbClases
        '
        Me.CbClases.FormattingEnabled = True
        Me.CbClases.Location = New System.Drawing.Point(87, 260)
        Me.CbClases.Name = "CbClases"
        Me.CbClases.Size = New System.Drawing.Size(121, 21)
        Me.CbClases.TabIndex = 0
        '
        'CbPlantaOrigen
        '
        Me.CbPlantaOrigen.FormattingEnabled = True
        Me.CbPlantaOrigen.Location = New System.Drawing.Point(161, 34)
        Me.CbPlantaOrigen.Name = "CbPlantaOrigen"
        Me.CbPlantaOrigen.Size = New System.Drawing.Size(121, 21)
        Me.CbPlantaOrigen.TabIndex = 0
        '
        'CbPlantaDestino
        '
        Me.CbPlantaDestino.FormattingEnabled = True
        Me.CbPlantaDestino.Location = New System.Drawing.Point(13, 34)
        Me.CbPlantaDestino.Name = "CbPlantaDestino"
        Me.CbPlantaDestino.Size = New System.Drawing.Size(121, 21)
        Me.CbPlantaDestino.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1327, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'CRVRepPacasDetallado
        '
        Me.CRVRepPacasDetallado.ActiveViewIndex = -1
        Me.CRVRepPacasDetallado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVRepPacasDetallado.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVRepPacasDetallado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVRepPacasDetallado.Location = New System.Drawing.Point(367, 24)
        Me.CRVRepPacasDetallado.Name = "CRVRepPacasDetallado"
        Me.CRVRepPacasDetallado.ShowCloseButton = False
        Me.CRVRepPacasDetallado.ShowCopyButton = False
        Me.CRVRepPacasDetallado.ShowGroupTreeButton = False
        Me.CRVRepPacasDetallado.ShowLogo = False
        Me.CRVRepPacasDetallado.ShowParameterPanelButton = False
        Me.CRVRepPacasDetallado.ShowRefreshButton = False
        Me.CRVRepPacasDetallado.Size = New System.Drawing.Size(960, 704)
        Me.CRVRepPacasDetallado.TabIndex = 2
        Me.CRVRepPacasDetallado.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepPacasDetalleAgrupadoPorClase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1327, 728)
        Me.Controls.Add(Me.CRVRepPacasDetallado)
        Me.Controls.Add(Me.GbDatos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RepPacasDetalleAgrupadoPorClase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reporte de Pacas Detallado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents BtAgrupadoPorClase As Button
    Friend WithEvents BtDetallado As Button
    Friend WithEvents CkSinVender As CheckBox
    Friend WithEvents CkSinComprar As CheckBox
    Friend WithEvents CkQuemadas As CheckBox
    Friend WithEvents BtConsultaCliente As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TbNombreCliente As TextBox
    Friend WithEvents TbHastaPaca As TextBox
    Friend WithEvents TbPredio As TextBox
    Friend WithEvents TbDesdePaca As TextBox
    Friend WithEvents TbIdCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CbOrdenProduccion As ComboBox
    Friend WithEvents CbVariedad As ComboBox
    Friend WithEvents CbClases As ComboBox
    Friend WithEvents CbPlantaOrigen As ComboBox
    Friend WithEvents CbPlantaDestino As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CRVRepPacasDetallado As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
