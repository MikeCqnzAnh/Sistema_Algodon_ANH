<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepPaquetesPorVenta
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
        Me.CRVPaqVenta = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVPaqVenta
        '
        Me.CRVPaqVenta.ActiveViewIndex = -1
        Me.CRVPaqVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVPaqVenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVPaqVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVPaqVenta.Location = New System.Drawing.Point(0, 0)
        Me.CRVPaqVenta.Name = "CRVPaqVenta"
        Me.CRVPaqVenta.ShowCloseButton = False
        Me.CRVPaqVenta.ShowCopyButton = False
        Me.CRVPaqVenta.ShowGroupTreeButton = False
        Me.CRVPaqVenta.ShowLogo = False
        Me.CRVPaqVenta.ShowParameterPanelButton = False
        Me.CRVPaqVenta.ShowRefreshButton = False
        Me.CRVPaqVenta.Size = New System.Drawing.Size(1012, 639)
        Me.CRVPaqVenta.TabIndex = 2
        Me.CRVPaqVenta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepPaquetesPorVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 639)
        Me.Controls.Add(Me.CRVPaqVenta)
        Me.Name = "RepPaquetesPorVenta"
        Me.Text = "Paquetes de venta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVPaqVenta As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
