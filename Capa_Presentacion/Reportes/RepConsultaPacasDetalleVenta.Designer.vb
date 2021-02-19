<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepConsultaPacasDetalleVenta
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbIdSalida = New System.Windows.Forms.TextBox()
        Me.TbIdEmbarque = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbFin = New System.Windows.Forms.TextBox()
        Me.TbInicio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbNoLote = New System.Windows.Forms.TextBox()
        Me.CbPlanta = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtConsultar = New System.Windows.Forms.Button()
        Me.TbIdVenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbIdLiquidacion = New System.Windows.Forms.TextBox()
        Me.TbIdOrdenTrabajo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbPaca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CRVReportePacasDetalleVenta = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportaAExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbDatos.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.Label10)
        Me.GbDatos.Controls.Add(Me.Label9)
        Me.GbDatos.Controls.Add(Me.TbIdSalida)
        Me.GbDatos.Controls.Add(Me.TbIdEmbarque)
        Me.GbDatos.Controls.Add(Me.Label8)
        Me.GbDatos.Controls.Add(Me.TbFin)
        Me.GbDatos.Controls.Add(Me.TbInicio)
        Me.GbDatos.Controls.Add(Me.Label7)
        Me.GbDatos.Controls.Add(Me.Label6)
        Me.GbDatos.Controls.Add(Me.TbNoLote)
        Me.GbDatos.Controls.Add(Me.CbPlanta)
        Me.GbDatos.Controls.Add(Me.Label5)
        Me.GbDatos.Controls.Add(Me.BtConsultar)
        Me.GbDatos.Controls.Add(Me.TbIdVenta)
        Me.GbDatos.Controls.Add(Me.Label4)
        Me.GbDatos.Controls.Add(Me.TbIdLiquidacion)
        Me.GbDatos.Controls.Add(Me.TbIdOrdenTrabajo)
        Me.GbDatos.Controls.Add(Me.Label3)
        Me.GbDatos.Controls.Add(Me.Label2)
        Me.GbDatos.Controls.Add(Me.TbPaca)
        Me.GbDatos.Controls.Add(Me.Label1)
        Me.GbDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatos.Location = New System.Drawing.Point(0, 24)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(898, 120)
        Me.GbDatos.TabIndex = 1
        Me.GbDatos.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(525, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "ID Salida"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(525, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "ID Embarque"
        '
        'TbIdSalida
        '
        Me.TbIdSalida.Location = New System.Drawing.Point(600, 45)
        Me.TbIdSalida.MaxLength = 10
        Me.TbIdSalida.Name = "TbIdSalida"
        Me.TbIdSalida.Size = New System.Drawing.Size(74, 20)
        Me.TbIdSalida.TabIndex = 26
        '
        'TbIdEmbarque
        '
        Me.TbIdEmbarque.Location = New System.Drawing.Point(600, 19)
        Me.TbIdEmbarque.MaxLength = 10
        Me.TbIdEmbarque.Name = "TbIdEmbarque"
        Me.TbIdEmbarque.Size = New System.Drawing.Size(74, 20)
        Me.TbIdEmbarque.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(391, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Hasta"
        '
        'TbFin
        '
        Me.TbFin.Location = New System.Drawing.Point(435, 19)
        Me.TbFin.MaxLength = 10
        Me.TbFin.Name = "TbFin"
        Me.TbFin.Size = New System.Drawing.Size(74, 20)
        Me.TbFin.TabIndex = 23
        '
        'TbInicio
        '
        Me.TbInicio.Location = New System.Drawing.Point(311, 19)
        Me.TbInicio.MaxLength = 10
        Me.TbInicio.Name = "TbInicio"
        Me.TbInicio.Size = New System.Drawing.Size(74, 20)
        Me.TbInicio.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(241, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 26)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Rango " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Pacas:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "No Lote:"
        '
        'TbNoLote
        '
        Me.TbNoLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNoLote.Location = New System.Drawing.Point(109, 71)
        Me.TbNoLote.MaxLength = 15
        Me.TbNoLote.Name = "TbNoLote"
        Me.TbNoLote.Size = New System.Drawing.Size(100, 20)
        Me.TbNoLote.TabIndex = 19
        '
        'CbPlanta
        '
        Me.CbPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPlanta.FormattingEnabled = True
        Me.CbPlanta.Location = New System.Drawing.Point(311, 71)
        Me.CbPlanta.Name = "CbPlanta"
        Me.CbPlanta.Size = New System.Drawing.Size(121, 21)
        Me.CbPlanta.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(241, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Planta:"
        '
        'BtConsultar
        '
        Me.BtConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtConsultar.Location = New System.Drawing.Point(811, 74)
        Me.BtConsultar.Name = "BtConsultar"
        Me.BtConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtConsultar.TabIndex = 16
        Me.BtConsultar.Text = "Consultar"
        Me.BtConsultar.UseVisualStyleBackColor = True
        '
        'TbIdVenta
        '
        Me.TbIdVenta.Location = New System.Drawing.Point(435, 45)
        Me.TbIdVenta.MaxLength = 10
        Me.TbIdVenta.Name = "TbIdVenta"
        Me.TbIdVenta.Size = New System.Drawing.Size(74, 20)
        Me.TbIdVenta.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(391, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Venta:"
        '
        'TbIdLiquidacion
        '
        Me.TbIdLiquidacion.Location = New System.Drawing.Point(311, 45)
        Me.TbIdLiquidacion.MaxLength = 10
        Me.TbIdLiquidacion.Name = "TbIdLiquidacion"
        Me.TbIdLiquidacion.Size = New System.Drawing.Size(74, 20)
        Me.TbIdLiquidacion.TabIndex = 13
        '
        'TbIdOrdenTrabajo
        '
        Me.TbIdOrdenTrabajo.Location = New System.Drawing.Point(109, 45)
        Me.TbIdOrdenTrabajo.MaxLength = 10
        Me.TbIdOrdenTrabajo.Name = "TbIdOrdenTrabajo"
        Me.TbIdOrdenTrabajo.Size = New System.Drawing.Size(74, 20)
        Me.TbIdOrdenTrabajo.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(241, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Liquidacion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Orden de trabajo:"
        '
        'TbPaca
        '
        Me.TbPaca.Location = New System.Drawing.Point(109, 19)
        Me.TbPaca.MaxLength = 10
        Me.TbPaca.Name = "TbPaca"
        Me.TbPaca.Size = New System.Drawing.Size(74, 20)
        Me.TbPaca.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Etiqueta de paca:"
        '
        'CRVReportePacasDetalleVenta
        '
        Me.CRVReportePacasDetalleVenta.ActiveViewIndex = -1
        Me.CRVReportePacasDetalleVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVReportePacasDetalleVenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVReportePacasDetalleVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVReportePacasDetalleVenta.Location = New System.Drawing.Point(0, 144)
        Me.CRVReportePacasDetalleVenta.Name = "CRVReportePacasDetalleVenta"
        Me.CRVReportePacasDetalleVenta.ShowCloseButton = False
        Me.CRVReportePacasDetalleVenta.ShowCopyButton = False
        Me.CRVReportePacasDetalleVenta.ShowGroupTreeButton = False
        Me.CRVReportePacasDetalleVenta.ShowLogo = False
        Me.CRVReportePacasDetalleVenta.ShowParameterPanelButton = False
        Me.CRVReportePacasDetalleVenta.ShowRefreshButton = False
        Me.CRVReportePacasDetalleVenta.Size = New System.Drawing.Size(898, 463)
        Me.CRVReportePacasDetalleVenta.TabIndex = 6
        Me.CRVReportePacasDetalleVenta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarToolStripMenuItem, Me.ExportaAExcelToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(898, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'ExportaAExcelToolStripMenuItem
        '
        Me.ExportaAExcelToolStripMenuItem.Name = "ExportaAExcelToolStripMenuItem"
        Me.ExportaAExcelToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.ExportaAExcelToolStripMenuItem.Text = "Exportar a excel"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'RepConsultaPacasDetalleVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 607)
        Me.Controls.Add(Me.CRVReportePacasDetalleVenta)
        Me.Controls.Add(Me.GbDatos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "RepConsultaPacasDetalleVenta"
        Me.Text = "Consulta pacas por detalle de venta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents TbIdVenta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbIdLiquidacion As TextBox
    Friend WithEvents TbIdOrdenTrabajo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbPaca As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtConsultar As Button
    Friend WithEvents CRVReportePacasDetalleVenta As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExportaAExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CbPlanta As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbNoLote As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TbFin As TextBox
    Friend WithEvents TbInicio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TbIdSalida As TextBox
    Friend WithEvents TbIdEmbarque As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
End Class
