<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepNotificacionfijacion
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
        Me.CRVNotificacionfijacion = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVNotificacionfijacion
        '
        Me.CRVNotificacionfijacion.ActiveViewIndex = -1
        Me.CRVNotificacionfijacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVNotificacionfijacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVNotificacionfijacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVNotificacionfijacion.Location = New System.Drawing.Point(0, 0)
        Me.CRVNotificacionfijacion.Name = "CRVNotificacionfijacion"
        Me.CRVNotificacionfijacion.ShowCloseButton = False
        Me.CRVNotificacionfijacion.ShowGroupTreeButton = False
        Me.CRVNotificacionfijacion.ShowLogo = False
        Me.CRVNotificacionfijacion.ShowParameterPanelButton = False
        Me.CRVNotificacionfijacion.ShowRefreshButton = False
        Me.CRVNotificacionfijacion.Size = New System.Drawing.Size(1174, 711)
        Me.CRVNotificacionfijacion.TabIndex = 4
        Me.CRVNotificacionfijacion.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepNotificacionfijacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1174, 711)
        Me.Controls.Add(Me.CRVNotificacionfijacion)
        Me.Name = "RepNotificacionfijacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Notificacion de Fijacion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVNotificacionfijacion As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
