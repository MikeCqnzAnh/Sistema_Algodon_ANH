<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LiquidacionCompraContrato
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
        Me.CRVReportePreliquidacion = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EnviarPorEmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CRVReportePreliquidacion
        '
        Me.CRVReportePreliquidacion.ActiveViewIndex = -1
        Me.CRVReportePreliquidacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVReportePreliquidacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVReportePreliquidacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVReportePreliquidacion.Location = New System.Drawing.Point(0, 24)
        Me.CRVReportePreliquidacion.Name = "CRVReportePreliquidacion"
        Me.CRVReportePreliquidacion.ShowCloseButton = False
        Me.CRVReportePreliquidacion.ShowCopyButton = False
        Me.CRVReportePreliquidacion.ShowGroupTreeButton = False
        Me.CRVReportePreliquidacion.ShowLogo = False
        Me.CRVReportePreliquidacion.ShowParameterPanelButton = False
        Me.CRVReportePreliquidacion.ShowRefreshButton = False
        Me.CRVReportePreliquidacion.Size = New System.Drawing.Size(1195, 757)
        Me.CRVReportePreliquidacion.TabIndex = 8
        Me.CRVReportePreliquidacion.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnviarPorEmailToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1195, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EnviarPorEmailToolStripMenuItem
        '
        Me.EnviarPorEmailToolStripMenuItem.Name = "EnviarPorEmailToolStripMenuItem"
        Me.EnviarPorEmailToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.EnviarPorEmailToolStripMenuItem.Text = "Enviar por Email"
        '
        'LiquidacionCompraContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 781)
        Me.Controls.Add(Me.CRVReportePreliquidacion)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "LiquidacionCompraContrato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LIQUIDACION A PRODUCTOR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CRVReportePreliquidacion As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EnviarPorEmailToolStripMenuItem As ToolStripMenuItem
End Class
