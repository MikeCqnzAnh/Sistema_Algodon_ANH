<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepPacasPorLotes
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
        Me.CRVPacasPorLotes = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.BtConsultar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbIdOrdenTrabajo = New System.Windows.Forms.TextBox()
        Me.GbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'CRVPacasPorLotes
        '
        Me.CRVPacasPorLotes.ActiveViewIndex = -1
        Me.CRVPacasPorLotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVPacasPorLotes.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVPacasPorLotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVPacasPorLotes.Location = New System.Drawing.Point(277, 0)
        Me.CRVPacasPorLotes.Name = "CRVPacasPorLotes"
        Me.CRVPacasPorLotes.ShowCloseButton = False
        Me.CRVPacasPorLotes.ShowCopyButton = False
        Me.CRVPacasPorLotes.ShowGroupTreeButton = False
        Me.CRVPacasPorLotes.ShowLogo = False
        Me.CRVPacasPorLotes.ShowParameterPanelButton = False
        Me.CRVPacasPorLotes.ShowRefreshButton = False
        Me.CRVPacasPorLotes.Size = New System.Drawing.Size(880, 622)
        Me.CRVPacasPorLotes.TabIndex = 0
        Me.CRVPacasPorLotes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.BtConsultar)
        Me.GbDatos.Controls.Add(Me.Label1)
        Me.GbDatos.Controls.Add(Me.TbIdOrdenTrabajo)
        Me.GbDatos.Dock = System.Windows.Forms.DockStyle.Left
        Me.GbDatos.Location = New System.Drawing.Point(0, 0)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(277, 622)
        Me.GbDatos.TabIndex = 1
        Me.GbDatos.TabStop = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Lote:"
        '
        'TbIdOrdenTrabajo
        '
        Me.TbIdOrdenTrabajo.Location = New System.Drawing.Point(49, 55)
        Me.TbIdOrdenTrabajo.MaxLength = 10
        Me.TbIdOrdenTrabajo.Name = "TbIdOrdenTrabajo"
        Me.TbIdOrdenTrabajo.Size = New System.Drawing.Size(100, 20)
        Me.TbIdOrdenTrabajo.TabIndex = 0
        '
        'RepPacasPorLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1157, 622)
        Me.Controls.Add(Me.CRVPacasPorLotes)
        Me.Controls.Add(Me.GbDatos)
        Me.Name = "RepPacasPorLotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pacas Por Lotes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CRVPacasPorLotes As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents BtConsultar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TbIdOrdenTrabajo As TextBox
End Class
