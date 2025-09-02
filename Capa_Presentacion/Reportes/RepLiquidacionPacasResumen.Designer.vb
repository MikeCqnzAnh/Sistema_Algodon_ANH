<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepLiquidacionPacasResumen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepLiquidacionPacasResumen))
        Me.CRVLiquidacionRomanea = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVLiquidacionRomanea
        '
        Me.CRVLiquidacionRomanea.ActiveViewIndex = -1
        Me.CRVLiquidacionRomanea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVLiquidacionRomanea.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVLiquidacionRomanea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVLiquidacionRomanea.Location = New System.Drawing.Point(0, 0)
        Me.CRVLiquidacionRomanea.Name = "CRVLiquidacionRomanea"
        Me.CRVLiquidacionRomanea.ShowCloseButton = False
        Me.CRVLiquidacionRomanea.ShowCopyButton = False
        Me.CRVLiquidacionRomanea.ShowGroupTreeButton = False
        Me.CRVLiquidacionRomanea.ShowLogo = False
        Me.CRVLiquidacionRomanea.ShowParameterPanelButton = False
        Me.CRVLiquidacionRomanea.ShowRefreshButton = False
        Me.CRVLiquidacionRomanea.Size = New System.Drawing.Size(944, 514)
        Me.CRVLiquidacionRomanea.TabIndex = 1
        Me.CRVLiquidacionRomanea.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepLiquidacionPacasResumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 514)
        Me.Controls.Add(Me.CRVLiquidacionRomanea)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RepLiquidacionPacasResumen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Resumen de liquidaciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVLiquidacionRomanea As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
