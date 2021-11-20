<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepCastigoPorRangos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepCastigoPorRangos))
        Me.CRVCastigoporrangos = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVCastigoporrangos
        '
        Me.CRVCastigoporrangos.ActiveViewIndex = -1
        Me.CRVCastigoporrangos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVCastigoporrangos.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVCastigoporrangos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVCastigoporrangos.Location = New System.Drawing.Point(0, 0)
        Me.CRVCastigoporrangos.Name = "CRVCastigoporrangos"
        Me.CRVCastigoporrangos.ShowCloseButton = False
        Me.CRVCastigoporrangos.ShowGroupTreeButton = False
        Me.CRVCastigoporrangos.ShowLogo = False
        Me.CRVCastigoporrangos.ShowParameterPanelButton = False
        Me.CRVCastigoporrangos.ShowRefreshButton = False
        Me.CRVCastigoporrangos.Size = New System.Drawing.Size(994, 671)
        Me.CRVCastigoporrangos.TabIndex = 3
        Me.CRVCastigoporrangos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepCastigoPorRangos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 671)
        Me.Controls.Add(Me.CRVCastigoporrangos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RepCastigoPorRangos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Castigos por Rangos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVCastigoporrangos As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
