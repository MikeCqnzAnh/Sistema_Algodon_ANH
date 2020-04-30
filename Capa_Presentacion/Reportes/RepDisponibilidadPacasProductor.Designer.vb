<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepDisponibilidadPacasProductor
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
        Me.CRVDisponibilidadPacas = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVDisponibilidadPacas
        '
        Me.CRVDisponibilidadPacas.ActiveViewIndex = -1
        Me.CRVDisponibilidadPacas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVDisponibilidadPacas.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVDisponibilidadPacas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVDisponibilidadPacas.Location = New System.Drawing.Point(0, 0)
        Me.CRVDisponibilidadPacas.Name = "CRVDisponibilidadPacas"
        Me.CRVDisponibilidadPacas.ShowCloseButton = False
        Me.CRVDisponibilidadPacas.ShowCopyButton = False
        Me.CRVDisponibilidadPacas.ShowGroupTreeButton = False
        Me.CRVDisponibilidadPacas.ShowLogo = False
        Me.CRVDisponibilidadPacas.ShowParameterPanelButton = False
        Me.CRVDisponibilidadPacas.ShowRefreshButton = False
        Me.CRVDisponibilidadPacas.Size = New System.Drawing.Size(1012, 695)
        Me.CRVDisponibilidadPacas.TabIndex = 2
        Me.CRVDisponibilidadPacas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepDisponibilidadPacasProductor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 695)
        Me.Controls.Add(Me.CRVDisponibilidadPacas)
        Me.Name = "RepDisponibilidadPacasProductor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Disponibilidad de pacas por productor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVDisponibilidadPacas As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
