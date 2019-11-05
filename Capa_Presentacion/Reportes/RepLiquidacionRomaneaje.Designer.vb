<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RepLiquidacionRomaneaje
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
        Me.CRVLiquidacionRomanea.Size = New System.Drawing.Size(912, 471)
        Me.CRVLiquidacionRomanea.TabIndex = 0
        Me.CRVLiquidacionRomanea.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepLiquidacionRomaneaje
        '
        Me.ClientSize = New System.Drawing.Size(912, 471)
        Me.Controls.Add(Me.CRVLiquidacionRomanea)
        Me.Name = "RepLiquidacionRomaneaje"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CRVLiquidacionRomaneaje As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CRVLiquidacionRomanea As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
