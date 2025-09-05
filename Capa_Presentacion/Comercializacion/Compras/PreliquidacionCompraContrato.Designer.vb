<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreliquidacionCompraContrato
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
        Me.CRVReportePreliquidacion = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVReportePreliquidacion
        '
        Me.CRVReportePreliquidacion.ActiveViewIndex = -1
        Me.CRVReportePreliquidacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVReportePreliquidacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVReportePreliquidacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVReportePreliquidacion.Location = New System.Drawing.Point(0, 0)
        Me.CRVReportePreliquidacion.Name = "CRVReportePreliquidacion"
        Me.CRVReportePreliquidacion.ShowCloseButton = False
        Me.CRVReportePreliquidacion.ShowCopyButton = False
        Me.CRVReportePreliquidacion.ShowGroupTreeButton = False
        Me.CRVReportePreliquidacion.ShowLogo = False
        Me.CRVReportePreliquidacion.ShowParameterPanelButton = False
        Me.CRVReportePreliquidacion.ShowRefreshButton = False
        Me.CRVReportePreliquidacion.Size = New System.Drawing.Size(1000, 724)
        Me.CRVReportePreliquidacion.TabIndex = 7
        Me.CRVReportePreliquidacion.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'PreliquidacionCompraContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 724)
        Me.Controls.Add(Me.CRVReportePreliquidacion)
        Me.Name = "PreliquidacionCompraContrato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PRELIQUIDACION DE COMPRA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVReportePreliquidacion As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
