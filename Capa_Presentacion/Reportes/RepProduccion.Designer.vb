<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepProduccion
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
        Me.CRVReporteProduccion = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVReporteProduccion
        '
        Me.CRVReporteProduccion.ActiveViewIndex = -1
        Me.CRVReporteProduccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVReporteProduccion.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVReporteProduccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVReporteProduccion.Location = New System.Drawing.Point(0, 0)
        Me.CRVReporteProduccion.Name = "CRVReporteProduccion"
        Me.CRVReporteProduccion.ShowCloseButton = False
        Me.CRVReporteProduccion.ShowCopyButton = False
        Me.CRVReporteProduccion.ShowGroupTreeButton = False
        Me.CRVReporteProduccion.ShowLogo = False
        Me.CRVReporteProduccion.ShowParameterPanelButton = False
        Me.CRVReporteProduccion.ShowRefreshButton = False
        Me.CRVReporteProduccion.Size = New System.Drawing.Size(999, 630)
        Me.CRVReporteProduccion.TabIndex = 7
        Me.CRVReporteProduccion.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 630)
        Me.Controls.Add(Me.CRVReporteProduccion)
        Me.Name = "RepProduccion"
        Me.Text = "Reporte de Produccion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVReporteProduccion As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
