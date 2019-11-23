<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepCompraPacasDetallado
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
        Me.CRVReporteCompraDetalle = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVReporteCompraDetalle
        '
        Me.CRVReporteCompraDetalle.ActiveViewIndex = -1
        Me.CRVReporteCompraDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVReporteCompraDetalle.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVReporteCompraDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVReporteCompraDetalle.Location = New System.Drawing.Point(0, 0)
        Me.CRVReporteCompraDetalle.Name = "CRVReporteCompraDetalle"
        Me.CRVReporteCompraDetalle.ShowCloseButton = False
        Me.CRVReporteCompraDetalle.ShowCopyButton = False
        Me.CRVReporteCompraDetalle.ShowGroupTreeButton = False
        Me.CRVReporteCompraDetalle.ShowLogo = False
        Me.CRVReporteCompraDetalle.ShowParameterPanelButton = False
        Me.CRVReporteCompraDetalle.Size = New System.Drawing.Size(995, 591)
        Me.CRVReporteCompraDetalle.TabIndex = 1
        Me.CRVReporteCompraDetalle.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepCompraPacasDetallado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 591)
        Me.Controls.Add(Me.CRVReporteCompraDetalle)
        Me.Name = "RepCompraPacasDetallado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RepCompraPacasDetallado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVReporteCompraDetalle As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
