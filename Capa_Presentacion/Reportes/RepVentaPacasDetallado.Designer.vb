<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepVentaPacasDetallado
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
        Me.CRVReporteVentaDetalle = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVReporteVentaDetalle
        '
        Me.CRVReporteVentaDetalle.ActiveViewIndex = -1
        Me.CRVReporteVentaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVReporteVentaDetalle.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVReporteVentaDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVReporteVentaDetalle.Location = New System.Drawing.Point(0, 0)
        Me.CRVReporteVentaDetalle.Name = "CRVReporteVentaDetalle"
        Me.CRVReporteVentaDetalle.ShowCloseButton = False
        Me.CRVReporteVentaDetalle.ShowCopyButton = False
        Me.CRVReporteVentaDetalle.ShowGroupTreeButton = False
        Me.CRVReporteVentaDetalle.ShowLogo = False
        Me.CRVReporteVentaDetalle.ShowParameterPanelButton = False
        Me.CRVReporteVentaDetalle.Size = New System.Drawing.Size(929, 513)
        Me.CRVReporteVentaDetalle.TabIndex = 2
        Me.CRVReporteVentaDetalle.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepVentaPacasDetallado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 513)
        Me.Controls.Add(Me.CRVReporteVentaDetalle)
        Me.Name = "RepVentaPacasDetallado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RepVentaPacasDetallado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVReporteVentaDetalle As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
