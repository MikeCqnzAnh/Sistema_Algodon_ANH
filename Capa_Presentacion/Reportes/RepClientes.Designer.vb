<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepClientes
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
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.CbAsociaciones = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtConsultar = New System.Windows.Forms.Button()
        Me.CRVReporteClientes = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(278, 762)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'CbAsociaciones
        '
        Me.CbAsociaciones.FormattingEnabled = True
        Me.CbAsociaciones.Location = New System.Drawing.Point(77, 12)
        Me.CbAsociaciones.Name = "CbAsociaciones"
        Me.CbAsociaciones.Size = New System.Drawing.Size(195, 21)
        Me.CbAsociaciones.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Asociacion"
        '
        'BtConsultar
        '
        Me.BtConsultar.Location = New System.Drawing.Point(197, 39)
        Me.BtConsultar.Name = "BtConsultar"
        Me.BtConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtConsultar.TabIndex = 4
        Me.BtConsultar.Text = "Consultar"
        Me.BtConsultar.UseVisualStyleBackColor = True
        '
        'CRVReporteClientes
        '
        Me.CRVReporteClientes.ActiveViewIndex = -1
        Me.CRVReporteClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVReporteClientes.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVReporteClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVReporteClientes.Location = New System.Drawing.Point(278, 0)
        Me.CRVReporteClientes.Name = "CRVReporteClientes"
        Me.CRVReporteClientes.ShowCloseButton = False
        Me.CRVReporteClientes.ShowCopyButton = False
        Me.CRVReporteClientes.ShowGroupTreeButton = False
        Me.CRVReporteClientes.ShowLogo = False
        Me.CRVReporteClientes.ShowParameterPanelButton = False
        Me.CRVReporteClientes.ShowRefreshButton = False
        Me.CRVReporteClientes.Size = New System.Drawing.Size(962, 762)
        Me.CRVReporteClientes.TabIndex = 5
        Me.CRVReporteClientes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 762)
        Me.Controls.Add(Me.CRVReporteClientes)
        Me.Controls.Add(Me.BtConsultar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbAsociaciones)
        Me.Controls.Add(Me.Splitter1)
        Me.Name = "RepClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents CbAsociaciones As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtConsultar As Button
    Friend WithEvents CRVReporteClientes As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
