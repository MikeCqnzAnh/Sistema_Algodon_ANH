<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepCompraPacasResumen
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
        Me.CRVReporteCompraResumen = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVReporteCompraResumen
        '
        Me.CRVReporteCompraResumen.ActiveViewIndex = -1
        Me.CRVReporteCompraResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVReporteCompraResumen.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVReporteCompraResumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVReporteCompraResumen.Location = New System.Drawing.Point(0, 0)
        Me.CRVReporteCompraResumen.Name = "CRVReporteCompraResumen"
        Me.CRVReporteCompraResumen.ShowCloseButton = False
        Me.CRVReporteCompraResumen.ShowCopyButton = False
        Me.CRVReporteCompraResumen.ShowGroupTreeButton = False
        Me.CRVReporteCompraResumen.ShowLogo = False
        Me.CRVReporteCompraResumen.ShowParameterPanelButton = False
        Me.CRVReporteCompraResumen.Size = New System.Drawing.Size(966, 660)
        Me.CRVReporteCompraResumen.TabIndex = 0
        Me.CRVReporteCompraResumen.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepCompraPacasResumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 660)
        Me.Controls.Add(Me.CRVReporteCompraResumen)
        Me.Name = "RepCompraPacasResumen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Resumen de Compra"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVReporteCompraResumen As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
