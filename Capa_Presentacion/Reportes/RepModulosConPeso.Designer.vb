<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RepModulosConPeso
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
        Me.CRVReporteModulos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVReporteModulos
        '
        Me.CRVReporteModulos.ActiveViewIndex = -1
        Me.CRVReporteModulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVReporteModulos.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVReporteModulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVReporteModulos.Location = New System.Drawing.Point(0, 0)
        Me.CRVReporteModulos.Name = "CRVReporteModulos"
        Me.CRVReporteModulos.ShowCloseButton = False
        Me.CRVReporteModulos.ShowCopyButton = False
        Me.CRVReporteModulos.ShowGroupTreeButton = False
        Me.CRVReporteModulos.ShowLogo = False
        Me.CRVReporteModulos.ShowParameterPanelButton = False
        Me.CRVReporteModulos.ShowRefreshButton = False
        Me.CRVReporteModulos.Size = New System.Drawing.Size(874, 699)
        Me.CRVReporteModulos.TabIndex = 8
        Me.CRVReporteModulos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepModulosConPeso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 699)
        Me.Controls.Add(Me.CRVReporteModulos)
        Me.Name = "RepModulosConPeso"
        Me.Text = "Reporte de modulos "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVReporteModulos As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
