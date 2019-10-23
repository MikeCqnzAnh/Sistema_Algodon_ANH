<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepLotesPorModulo
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
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.CrLotesPorModulo = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TbIdOrdenTrabajo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtConsultar = New System.Windows.Forms.Button()
        Me.GbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.BtConsultar)
        Me.GbDatos.Controls.Add(Me.Label1)
        Me.GbDatos.Controls.Add(Me.TbIdOrdenTrabajo)
        Me.GbDatos.Dock = System.Windows.Forms.DockStyle.Left
        Me.GbDatos.Location = New System.Drawing.Point(0, 0)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(277, 738)
        Me.GbDatos.TabIndex = 0
        Me.GbDatos.TabStop = False
        '
        'CrLotesPorModulo
        '
        Me.CrLotesPorModulo.ActiveViewIndex = -1
        Me.CrLotesPorModulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrLotesPorModulo.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrLotesPorModulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrLotesPorModulo.Location = New System.Drawing.Point(277, 0)
        Me.CrLotesPorModulo.Name = "CrLotesPorModulo"
        Me.CrLotesPorModulo.ShowCloseButton = False
        Me.CrLotesPorModulo.ShowCopyButton = False
        Me.CrLotesPorModulo.ShowGroupTreeButton = False
        Me.CrLotesPorModulo.ShowLogo = False
        Me.CrLotesPorModulo.ShowParameterPanelButton = False
        Me.CrLotesPorModulo.ShowRefreshButton = False
        Me.CrLotesPorModulo.Size = New System.Drawing.Size(844, 738)
        Me.CrLotesPorModulo.TabIndex = 1
        Me.CrLotesPorModulo.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'TbIdOrdenTrabajo
        '
        Me.TbIdOrdenTrabajo.Location = New System.Drawing.Point(49, 55)
        Me.TbIdOrdenTrabajo.Name = "TbIdOrdenTrabajo"
        Me.TbIdOrdenTrabajo.Size = New System.Drawing.Size(100, 20)
        Me.TbIdOrdenTrabajo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Lote:"
        '
        'BtConsultar
        '
        Me.BtConsultar.Location = New System.Drawing.Point(49, 183)
        Me.BtConsultar.Name = "BtConsultar"
        Me.BtConsultar.Size = New System.Drawing.Size(121, 23)
        Me.BtConsultar.TabIndex = 2
        Me.BtConsultar.Text = "Consultar"
        Me.BtConsultar.UseVisualStyleBackColor = True
        '
        'RepLotesPorModulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 738)
        Me.Controls.Add(Me.CrLotesPorModulo)
        Me.Controls.Add(Me.GbDatos)
        Me.Name = "RepLotesPorModulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RepLotesPorModulo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents CrLotesPorModulo As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents TbIdOrdenTrabajo As TextBox
    Friend WithEvents BtConsultar As Button
End Class
