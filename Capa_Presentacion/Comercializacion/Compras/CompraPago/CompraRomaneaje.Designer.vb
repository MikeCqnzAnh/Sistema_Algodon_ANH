<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompraRomaneaje
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
        Me.CRVReporteCompraRomaneaje = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ckdetalles = New System.Windows.Forms.CheckBox()
        Me.btconsultar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CRVReporteCompraRomaneaje
        '
        Me.CRVReporteCompraRomaneaje.ActiveViewIndex = -1
        Me.CRVReporteCompraRomaneaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVReporteCompraRomaneaje.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVReporteCompraRomaneaje.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVReporteCompraRomaneaje.Location = New System.Drawing.Point(121, 0)
        Me.CRVReporteCompraRomaneaje.Name = "CRVReporteCompraRomaneaje"
        Me.CRVReporteCompraRomaneaje.ShowCloseButton = False
        Me.CRVReporteCompraRomaneaje.ShowCopyButton = False
        Me.CRVReporteCompraRomaneaje.ShowGroupTreeButton = False
        Me.CRVReporteCompraRomaneaje.ShowLogo = False
        Me.CRVReporteCompraRomaneaje.ShowParameterPanelButton = False
        Me.CRVReporteCompraRomaneaje.Size = New System.Drawing.Size(1041, 737)
        Me.CRVReporteCompraRomaneaje.TabIndex = 1
        Me.CRVReporteCompraRomaneaje.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ckdetalles)
        Me.Panel1.Controls.Add(Me.btconsultar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(121, 737)
        Me.Panel1.TabIndex = 2
        '
        'ckdetalles
        '
        Me.ckdetalles.AutoSize = True
        Me.ckdetalles.Location = New System.Drawing.Point(12, 58)
        Me.ckdetalles.Name = "ckdetalles"
        Me.ckdetalles.Size = New System.Drawing.Size(105, 17)
        Me.ckdetalles.TabIndex = 1
        Me.ckdetalles.Text = "Muestra Detalles"
        Me.ckdetalles.UseVisualStyleBackColor = True
        '
        'btconsultar
        '
        Me.btconsultar.Location = New System.Drawing.Point(12, 124)
        Me.btconsultar.Name = "btconsultar"
        Me.btconsultar.Size = New System.Drawing.Size(75, 23)
        Me.btconsultar.TabIndex = 0
        Me.btconsultar.Text = "Consultar"
        Me.btconsultar.UseVisualStyleBackColor = True
        '
        'CompraRomaneaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1162, 737)
        Me.Controls.Add(Me.CRVReporteCompraRomaneaje)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CompraRomaneaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Romaneaje de Compra"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVReporteCompraRomaneaje As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ckdetalles As CheckBox
    Friend WithEvents btconsultar As Button
End Class
