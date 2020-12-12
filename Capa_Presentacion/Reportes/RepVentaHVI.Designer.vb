<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepVentaHVI
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
        Me.CRVVentaHVI = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExportarAExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CRVVentaHVI
        '
        Me.CRVVentaHVI.ActiveViewIndex = -1
        Me.CRVVentaHVI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVVentaHVI.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVVentaHVI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVVentaHVI.Location = New System.Drawing.Point(0, 24)
        Me.CRVVentaHVI.Name = "CRVVentaHVI"
        Me.CRVVentaHVI.ShowCloseButton = False
        Me.CRVVentaHVI.ShowCopyButton = False
        Me.CRVVentaHVI.ShowGroupTreeButton = False
        Me.CRVVentaHVI.ShowLogo = False
        Me.CRVVentaHVI.ShowParameterPanelButton = False
        Me.CRVVentaHVI.ShowRefreshButton = False
        Me.CRVVentaHVI.Size = New System.Drawing.Size(942, 527)
        Me.CRVVentaHVI.TabIndex = 1
        Me.CRVVentaHVI.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportarAExcelToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(942, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExportarAExcelToolStripMenuItem
        '
        Me.ExportarAExcelToolStripMenuItem.Name = "ExportarAExcelToolStripMenuItem"
        Me.ExportarAExcelToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.ExportarAExcelToolStripMenuItem.Text = "Exportar a Excel"
        '
        'RepVentaHVI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 551)
        Me.Controls.Add(Me.CRVVentaHVI)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RepVentaHVI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reporte Venta de HVI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CRVVentaHVI As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExportarAExcelToolStripMenuItem As ToolStripMenuItem
End Class
