<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepLiqRomEnc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepLiqRomEnc))
        Me.CRVLiqRomaneajeCompra = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVLiqRomaneajeCompra
        '
        Me.CRVLiqRomaneajeCompra.ActiveViewIndex = -1
        Me.CRVLiqRomaneajeCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVLiqRomaneajeCompra.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVLiqRomaneajeCompra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVLiqRomaneajeCompra.Location = New System.Drawing.Point(0, 0)
        Me.CRVLiqRomaneajeCompra.Name = "CRVLiqRomaneajeCompra"
        Me.CRVLiqRomaneajeCompra.ShowCloseButton = False
        Me.CRVLiqRomaneajeCompra.ShowCopyButton = False
        Me.CRVLiqRomaneajeCompra.ShowGroupTreeButton = False
        Me.CRVLiqRomaneajeCompra.ShowLogo = False
        Me.CRVLiqRomaneajeCompra.ShowParameterPanelButton = False
        Me.CRVLiqRomaneajeCompra.ShowRefreshButton = False
        Me.CRVLiqRomaneajeCompra.Size = New System.Drawing.Size(1195, 749)
        Me.CRVLiqRomaneajeCompra.TabIndex = 1
        Me.CRVLiqRomaneajeCompra.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepLiqRomEnc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 749)
        Me.Controls.Add(Me.CRVLiqRomaneajeCompra)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RepLiqRomEnc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Liquidacion Por Romaneaje de Compra"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVLiqRomaneajeCompra As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
