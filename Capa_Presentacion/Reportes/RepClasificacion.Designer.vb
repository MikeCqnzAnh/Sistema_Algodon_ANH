<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RepClasificacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CRVHviDetalle = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExportaExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CRVHviDetalle
        '
        Me.CRVHviDetalle.ActiveViewIndex = -1
        Me.CRVHviDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVHviDetalle.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVHviDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVHviDetalle.Location = New System.Drawing.Point(0, 24)
        Me.CRVHviDetalle.Name = "CRVHviDetalle"
        Me.CRVHviDetalle.ShowCloseButton = False
        Me.CRVHviDetalle.ShowGroupTreeButton = False
        Me.CRVHviDetalle.ShowLogo = False
        Me.CRVHviDetalle.ShowParameterPanelButton = False
        Me.CRVHviDetalle.ShowRefreshButton = False
        Me.CRVHviDetalle.Size = New System.Drawing.Size(1305, 660)
        Me.CRVHviDetalle.TabIndex = 1
        Me.CRVHviDetalle.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportaExcelToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1305, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExportaExcelToolStripMenuItem
        '
        Me.ExportaExcelToolStripMenuItem.Name = "ExportaExcelToolStripMenuItem"
        Me.ExportaExcelToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.ExportaExcelToolStripMenuItem.Text = "Exporta Excel"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'RepClasificacion
        '
        Me.ClientSize = New System.Drawing.Size(1305, 684)
        Me.Controls.Add(Me.CRVHviDetalle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RepClasificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtImportaExcel As Button
    Friend WithEvents CRVContratoProductor As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CRVHviDetalle As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExportaExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
