﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepResumenLiqVisPrev
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepResumenLiqVisPrev))
        Me.CRVResumenLiquidacion = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRVResumenLiquidacion
        '
        Me.CRVResumenLiquidacion.ActiveViewIndex = -1
        Me.CRVResumenLiquidacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVResumenLiquidacion.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVResumenLiquidacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVResumenLiquidacion.Location = New System.Drawing.Point(0, 0)
        Me.CRVResumenLiquidacion.Name = "CRVResumenLiquidacion"
        Me.CRVResumenLiquidacion.ShowCloseButton = False
        Me.CRVResumenLiquidacion.ShowCopyButton = False
        Me.CRVResumenLiquidacion.ShowGroupTreeButton = False
        Me.CRVResumenLiquidacion.ShowLogo = False
        Me.CRVResumenLiquidacion.ShowParameterPanelButton = False
        Me.CRVResumenLiquidacion.ShowRefreshButton = False
        Me.CRVResumenLiquidacion.Size = New System.Drawing.Size(1086, 619)
        Me.CRVResumenLiquidacion.TabIndex = 3
        Me.CRVResumenLiquidacion.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepResumenLiqVisPrev
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1086, 619)
        Me.Controls.Add(Me.CRVResumenLiquidacion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RepResumenLiqVisPrev"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resumen de liquidacion "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVResumenLiquidacion As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
