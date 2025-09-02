<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RepDiarioOperacionPlanta
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
        Me.CRVOperacionPlanta = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVOperacionPlanta
        '
        Me.CRVOperacionPlanta.ActiveViewIndex = -1
        Me.CRVOperacionPlanta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVOperacionPlanta.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVOperacionPlanta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVOperacionPlanta.Location = New System.Drawing.Point(0, 0)
        Me.CRVOperacionPlanta.Name = "CRVOperacionPlanta"
        Me.CRVOperacionPlanta.ShowCloseButton = False
        Me.CRVOperacionPlanta.ShowGroupTreeButton = False
        Me.CRVOperacionPlanta.ShowLogo = False
        Me.CRVOperacionPlanta.ShowParameterPanelButton = False
        Me.CRVOperacionPlanta.ShowRefreshButton = False
        Me.CRVOperacionPlanta.Size = New System.Drawing.Size(1289, 781)
        Me.CRVOperacionPlanta.TabIndex = 67
        Me.CRVOperacionPlanta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepDiarioOperacionPlanta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 781)
        Me.Controls.Add(Me.CRVOperacionPlanta)
        Me.Name = "RepDiarioOperacionPlanta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "RepDiarioOperacionPlanta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVOperacionPlanta As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
