<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RepClasificacion
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
        Me.CRVHviDetalle = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVHviDetalle
        '
        Me.CRVHviDetalle.ActiveViewIndex = -1
        Me.CRVHviDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVHviDetalle.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVHviDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVHviDetalle.Location = New System.Drawing.Point(0, 0)
        Me.CRVHviDetalle.Name = "CRVHviDetalle"
        Me.CRVHviDetalle.ShowCloseButton = False
        Me.CRVHviDetalle.ShowGroupTreeButton = False
        Me.CRVHviDetalle.ShowLogo = False
        Me.CRVHviDetalle.ShowParameterPanelButton = False
        Me.CRVHviDetalle.ShowRefreshButton = False
        Me.CRVHviDetalle.Size = New System.Drawing.Size(1305, 684)
        Me.CRVHviDetalle.TabIndex = 1
        Me.CRVHviDetalle.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepClasificacion
        '
        Me.ClientSize = New System.Drawing.Size(1305, 684)
        Me.Controls.Add(Me.CRVHviDetalle)
        Me.Name = "RepClasificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtImportaExcel As Button
    Friend WithEvents CRVContratoProductor As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CRVHviDetalle As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
