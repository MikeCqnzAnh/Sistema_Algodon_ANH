<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RepContratoProductor
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
        Me.CRVContratoProductor = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVContratoProductor
        '
        Me.CRVContratoProductor.ActiveViewIndex = -1
        Me.CRVContratoProductor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVContratoProductor.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVContratoProductor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVContratoProductor.Location = New System.Drawing.Point(0, 0)
        Me.CRVContratoProductor.Name = "CRVContratoProductor"
        Me.CRVContratoProductor.ShowCloseButton = False
        Me.CRVContratoProductor.ShowGroupTreeButton = False
        Me.CRVContratoProductor.ShowLogo = False
        Me.CRVContratoProductor.ShowParameterPanelButton = False
        Me.CRVContratoProductor.ShowRefreshButton = False
        Me.CRVContratoProductor.Size = New System.Drawing.Size(1100, 598)
        Me.CRVContratoProductor.TabIndex = 0
        Me.CRVContratoProductor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepContratoProductor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 598)
        Me.Controls.Add(Me.CRVContratoProductor)
        Me.Name = "RepContratoProductor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RepContratoProductor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVContratoProductor As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
