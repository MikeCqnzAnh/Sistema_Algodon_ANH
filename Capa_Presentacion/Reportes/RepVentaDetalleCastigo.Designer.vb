<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepVentaDetalleCastigo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepVentaDetalleCastigo))
        Me.CRVVentaDetalleCastigo = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExportarAExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CRVVentaDetalleCastigo
        '
        Me.CRVVentaDetalleCastigo.ActiveViewIndex = -1
        Me.CRVVentaDetalleCastigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVVentaDetalleCastigo.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVVentaDetalleCastigo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVVentaDetalleCastigo.Location = New System.Drawing.Point(0, 24)
        Me.CRVVentaDetalleCastigo.Name = "CRVVentaDetalleCastigo"
        Me.CRVVentaDetalleCastigo.ShowCloseButton = False
        Me.CRVVentaDetalleCastigo.ShowGroupTreeButton = False
        Me.CRVVentaDetalleCastigo.ShowLogo = False
        Me.CRVVentaDetalleCastigo.ShowParameterPanelButton = False
        Me.CRVVentaDetalleCastigo.ShowRefreshButton = False
        Me.CRVVentaDetalleCastigo.Size = New System.Drawing.Size(1261, 681)
        Me.CRVVentaDetalleCastigo.TabIndex = 3
        Me.CRVVentaDetalleCastigo.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportarAExcelToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1261, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExportarAExcelToolStripMenuItem
        '
        Me.ExportarAExcelToolStripMenuItem.Image = Global.Capa_Presentacion.My.Resources.Resources.excel
        Me.ExportarAExcelToolStripMenuItem.Name = "ExportarAExcelToolStripMenuItem"
        Me.ExportarAExcelToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.ExportarAExcelToolStripMenuItem.Text = "Exportar a excel"
        '
        'RepVentaDetalleCastigo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1261, 705)
        Me.Controls.Add(Me.CRVVentaDetalleCastigo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RepVentaDetalleCastigo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de castigos por paca"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CRVVentaDetalleCastigo As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExportarAExcelToolStripMenuItem As ToolStripMenuItem
End Class
