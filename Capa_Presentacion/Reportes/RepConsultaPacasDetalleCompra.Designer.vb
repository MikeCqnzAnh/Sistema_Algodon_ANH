﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepConsultaPacasDetalleCompra
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbLotID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbFin = New System.Windows.Forms.TextBox()
        Me.TbInicio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbPlanta = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtConsultar = New System.Windows.Forms.Button()
        Me.TbIdCompra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbIdLiquidacion = New System.Windows.Forms.TextBox()
        Me.TbIdOrdenTrabajo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbPaca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExportaAExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CRVReportePacasDetalleCompra = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbDatos.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.Label6)
        Me.GbDatos.Controls.Add(Me.TbLotID)
        Me.GbDatos.Controls.Add(Me.Label8)
        Me.GbDatos.Controls.Add(Me.TbFin)
        Me.GbDatos.Controls.Add(Me.TbInicio)
        Me.GbDatos.Controls.Add(Me.Label7)
        Me.GbDatos.Controls.Add(Me.CbPlanta)
        Me.GbDatos.Controls.Add(Me.Label5)
        Me.GbDatos.Controls.Add(Me.BtConsultar)
        Me.GbDatos.Controls.Add(Me.TbIdCompra)
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
        Me.GbDatos.Size = New System.Drawing.Size(898, 113)
        Me.GbDatos.TabIndex = 0
        Me.GbDatos.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Lot ID:"
        '
        'TbLotID
        '
        Me.TbLotID.Location = New System.Drawing.Point(109, 48)
        Me.TbLotID.Name = "TbLotID"
        Me.TbLotID.Size = New System.Drawing.Size(74, 20)
        Me.TbLotID.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(360, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Hasta"
        '
        'TbFin
        '
        Me.TbFin.Location = New System.Drawing.Point(412, 22)
        Me.TbFin.MaxLength = 10
        Me.TbFin.Name = "TbFin"
        Me.TbFin.Size = New System.Drawing.Size(74, 20)
        Me.TbFin.TabIndex = 2
        '
        'TbInicio
        '
        Me.TbInicio.Location = New System.Drawing.Point(280, 22)
        Me.TbInicio.MaxLength = 10
        Me.TbInicio.Name = "TbInicio"
        Me.TbInicio.Size = New System.Drawing.Size(74, 20)
        Me.TbInicio.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(210, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 26)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Rango " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Pacas:"
        '
        'CbPlanta
        '
        Me.CbPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPlanta.FormattingEnabled = True
        Me.CbPlanta.Location = New System.Drawing.Point(544, 48)
        Me.CbPlanta.Name = "CbPlanta"
        Me.CbPlanta.Size = New System.Drawing.Size(121, 21)
        Me.CbPlanta.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(494, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Planta:"
        '
        'BtConsultar
        '
        Me.BtConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtConsultar.Location = New System.Drawing.Point(811, 75)
        Me.BtConsultar.Name = "BtConsultar"
        Me.BtConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtConsultar.TabIndex = 8
        Me.BtConsultar.Text = "Consultar"
        Me.BtConsultar.UseVisualStyleBackColor = True
        '
        'TbIdCompra
        '
        Me.TbIdCompra.Location = New System.Drawing.Point(412, 48)
        Me.TbIdCompra.MaxLength = 10
        Me.TbIdCompra.Name = "TbIdCompra"
        Me.TbIdCompra.Size = New System.Drawing.Size(74, 20)
        Me.TbIdCompra.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(360, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Compra:"
        '
        'TbIdLiquidacion
        '
        Me.TbIdLiquidacion.Location = New System.Drawing.Point(280, 48)
        Me.TbIdLiquidacion.MaxLength = 10
        Me.TbIdLiquidacion.Name = "TbIdLiquidacion"
        Me.TbIdLiquidacion.Size = New System.Drawing.Size(74, 20)
        Me.TbIdLiquidacion.TabIndex = 5
        '
        'TbIdOrdenTrabajo
        '
        Me.TbIdOrdenTrabajo.Location = New System.Drawing.Point(591, 22)
        Me.TbIdOrdenTrabajo.MaxLength = 10
        Me.TbIdOrdenTrabajo.Name = "TbIdOrdenTrabajo"
        Me.TbIdOrdenTrabajo.Size = New System.Drawing.Size(74, 20)
        Me.TbIdOrdenTrabajo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(210, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Liquidacion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(494, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Orden de trabajo:"
        '
        'TbPaca
        '
        Me.TbPaca.Location = New System.Drawing.Point(109, 22)
        Me.TbPaca.MaxLength = 10
        Me.TbPaca.Name = "TbPaca"
        Me.TbPaca.Size = New System.Drawing.Size(74, 20)
        Me.TbPaca.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Etiqueta de paca:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarToolStripMenuItem, Me.ExportaAExcelToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(898, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'CRVReportePacasDetalleCompra
        '
        Me.CRVReportePacasDetalleCompra.ActiveViewIndex = -1
        Me.CRVReportePacasDetalleCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVReportePacasDetalleCompra.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVReportePacasDetalleCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVReportePacasDetalleCompra.Location = New System.Drawing.Point(0, 137)
        Me.CRVReportePacasDetalleCompra.Name = "CRVReportePacasDetalleCompra"
        Me.CRVReportePacasDetalleCompra.ShowCloseButton = False
        Me.CRVReportePacasDetalleCompra.ShowCopyButton = False
        Me.CRVReportePacasDetalleCompra.ShowGroupTreeButton = False
        Me.CRVReportePacasDetalleCompra.ShowLogo = False
        Me.CRVReportePacasDetalleCompra.ShowParameterPanelButton = False
        Me.CRVReportePacasDetalleCompra.ShowRefreshButton = False
        Me.CRVReportePacasDetalleCompra.Size = New System.Drawing.Size(898, 470)
        Me.CRVReportePacasDetalleCompra.TabIndex = 7
        Me.CRVReportePacasDetalleCompra.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'RepConsultaPacasDetalleCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 607)
        Me.Controls.Add(Me.CRVReportePacasDetalleCompra)
        Me.Controls.Add(Me.GbDatos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RepConsultaPacasDetalleCompra"
        Me.Text = "Consulta pacas por detalle de compra"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExportaAExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TbPaca As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbIdLiquidacion As TextBox
    Friend WithEvents TbIdOrdenTrabajo As TextBox
    Friend WithEvents TbIdCompra As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtConsultar As Button
    Friend WithEvents CRVReportePacasDetalleCompra As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CbPlanta As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TbLotID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TbFin As TextBox
    Friend WithEvents TbInicio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
End Class
