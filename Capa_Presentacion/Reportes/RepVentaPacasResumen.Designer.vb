<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepVentaPacasResumen
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
        Me.CRVReporteVentaResumen = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVReporteVentaResumen
        '
        Me.CRVReporteVentaResumen.ActiveViewIndex = -1
        Me.CRVReporteVentaResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVReporteVentaResumen.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVReporteVentaResumen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVReporteVentaResumen.Location = New System.Drawing.Point(0, 0)
        Me.CRVReporteVentaResumen.Name = "CRVReporteVentaResumen"
        Me.CRVReporteVentaResumen.ShowCloseButton = False
        Me.CRVReporteVentaResumen.ShowCopyButton = False
        Me.CRVReporteVentaResumen.ShowGroupTreeButton = False
        Me.CRVReporteVentaResumen.ShowLogo = False
        Me.CRVReporteVentaResumen.ShowParameterPanelButton = False
        Me.CRVReporteVentaResumen.Size = New System.Drawing.Size(830, 558)
        Me.CRVReporteVentaResumen.TabIndex = 1
        Me.CRVReporteVentaResumen.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepVentaPacasResumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 558)
        Me.Controls.Add(Me.CRVReporteVentaResumen)
        Me.Name = "RepVentaPacasResumen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RepVentaPacasResumen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVReporteVentaResumen As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
