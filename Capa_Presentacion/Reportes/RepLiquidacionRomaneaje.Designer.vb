<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepLiquidacionRomaneaje
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
        Me.CRVLiquidacionRomaneaje = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVLiquidacionRomaneaje
        '
        Me.CRVLiquidacionRomaneaje.ActiveViewIndex = -1
        Me.CRVLiquidacionRomaneaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVLiquidacionRomaneaje.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVLiquidacionRomaneaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVLiquidacionRomaneaje.Location = New System.Drawing.Point(0, 0)
        Me.CRVLiquidacionRomaneaje.Name = "CRVLiquidacionRomaneaje"
        Me.CRVLiquidacionRomaneaje.ShowCloseButton = False
        Me.CRVLiquidacionRomaneaje.ShowCopyButton = False
        Me.CRVLiquidacionRomaneaje.ShowExportButton = False
        Me.CRVLiquidacionRomaneaje.ShowGroupTreeButton = False
        Me.CRVLiquidacionRomaneaje.ShowLogo = False
        Me.CRVLiquidacionRomaneaje.ShowParameterPanelButton = False
        Me.CRVLiquidacionRomaneaje.Size = New System.Drawing.Size(1092, 663)
        Me.CRVLiquidacionRomaneaje.TabIndex = 1
        Me.CRVLiquidacionRomaneaje.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepLiquidacionRomaneaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 663)
        Me.Controls.Add(Me.CRVLiquidacionRomaneaje)
        Me.Name = "RepLiquidacionRomaneaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RepLiquidacionRomaneaje"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVLiquidacionRomaneaje As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
