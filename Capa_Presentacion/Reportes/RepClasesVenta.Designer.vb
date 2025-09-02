<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepClasesVenta
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
        Me.CRVClasesVenta = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVClasesVenta
        '
        Me.CRVClasesVenta.ActiveViewIndex = -1
        Me.CRVClasesVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVClasesVenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVClasesVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVClasesVenta.Location = New System.Drawing.Point(0, 0)
        Me.CRVClasesVenta.Name = "CRVClasesVenta"
        Me.CRVClasesVenta.ShowCloseButton = False
        Me.CRVClasesVenta.ShowGroupTreeButton = False
        Me.CRVClasesVenta.ShowLogo = False
        Me.CRVClasesVenta.ShowParameterPanelButton = False
        Me.CRVClasesVenta.ShowRefreshButton = False
        Me.CRVClasesVenta.Size = New System.Drawing.Size(1052, 658)
        Me.CRVClasesVenta.TabIndex = 2
        Me.CRVClasesVenta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepClasesVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 658)
        Me.Controls.Add(Me.CRVClasesVenta)
        Me.Name = "RepClasesVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RepClasesVenta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVClasesVenta As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
