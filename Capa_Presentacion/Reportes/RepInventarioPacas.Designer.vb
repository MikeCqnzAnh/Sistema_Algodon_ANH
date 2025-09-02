<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepInventarioPacas
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
        Me.CRVInventariopacas = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVInventariopacas
        '
        Me.CRVInventariopacas.ActiveViewIndex = -1
        Me.CRVInventariopacas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVInventariopacas.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVInventariopacas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVInventariopacas.Location = New System.Drawing.Point(0, 0)
        Me.CRVInventariopacas.Name = "CRVInventariopacas"
        Me.CRVInventariopacas.ShowCloseButton = False
        Me.CRVInventariopacas.ShowGroupTreeButton = False
        Me.CRVInventariopacas.ShowLogo = False
        Me.CRVInventariopacas.ShowParameterPanelButton = False
        Me.CRVInventariopacas.ShowRefreshButton = False
        Me.CRVInventariopacas.Size = New System.Drawing.Size(880, 684)
        Me.CRVInventariopacas.TabIndex = 4
        Me.CRVInventariopacas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepInventarioPacas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 684)
        Me.Controls.Add(Me.CRVInventariopacas)
        Me.Name = "RepInventarioPacas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RepInventarioPacas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVInventariopacas As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
