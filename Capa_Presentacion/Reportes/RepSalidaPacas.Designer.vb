<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RepSalidaPacas
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
        Me.CRVReporteSalida = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NueviToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CkDiferencia = New System.Windows.Forms.CheckBox()
        Me.BtComprador = New System.Windows.Forms.Button()
        Me.BtIdSalida = New System.Windows.Forms.Button()
        Me.TbIdSalida = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbComprador = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ResumenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CRVReporteSalida
        '
        Me.CRVReporteSalida.ActiveViewIndex = -1
        Me.CRVReporteSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVReporteSalida.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVReporteSalida.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVReporteSalida.Location = New System.Drawing.Point(281, 24)
        Me.CRVReporteSalida.Name = "CRVReporteSalida"
        Me.CRVReporteSalida.ShowCloseButton = False
        Me.CRVReporteSalida.ShowCopyButton = False
        Me.CRVReporteSalida.ShowGroupTreeButton = False
        Me.CRVReporteSalida.ShowLogo = False
        Me.CRVReporteSalida.ShowParameterPanelButton = False
        Me.CRVReporteSalida.ShowRefreshButton = False
        Me.CRVReporteSalida.Size = New System.Drawing.Size(1003, 568)
        Me.CRVReporteSalida.TabIndex = 1
        Me.CRVReporteSalida.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NueviToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.ResumenToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1284, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NueviToolStripMenuItem
        '
        Me.NueviToolStripMenuItem.Name = "NueviToolStripMenuItem"
        Me.NueviToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NueviToolStripMenuItem.Text = "Nuevo"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ConsultarToolStripMenuItem.Text = "Detalle"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CkDiferencia)
        Me.Panel1.Controls.Add(Me.BtComprador)
        Me.Panel1.Controls.Add(Me.BtIdSalida)
        Me.Panel1.Controls.Add(Me.TbIdSalida)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TbComprador)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(281, 568)
        Me.Panel1.TabIndex = 3
        '
        'CkDiferencia
        '
        Me.CkDiferencia.AutoSize = True
        Me.CkDiferencia.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CkDiferencia.Location = New System.Drawing.Point(58, 136)
        Me.CkDiferencia.Name = "CkDiferencia"
        Me.CkDiferencia.Size = New System.Drawing.Size(74, 17)
        Me.CkDiferencia.TabIndex = 8
        Me.CkDiferencia.Text = "Diferencia"
        Me.CkDiferencia.UseVisualStyleBackColor = True
        '
        'BtComprador
        '
        Me.BtComprador.Location = New System.Drawing.Point(225, 80)
        Me.BtComprador.Name = "BtComprador"
        Me.BtComprador.Size = New System.Drawing.Size(27, 23)
        Me.BtComprador.TabIndex = 7
        Me.BtComprador.Text = "..."
        Me.BtComprador.UseVisualStyleBackColor = True
        '
        'BtIdSalida
        '
        Me.BtIdSalida.Location = New System.Drawing.Point(225, 17)
        Me.BtIdSalida.Name = "BtIdSalida"
        Me.BtIdSalida.Size = New System.Drawing.Size(27, 23)
        Me.BtIdSalida.TabIndex = 6
        Me.BtIdSalida.Text = "..."
        Me.BtIdSalida.UseVisualStyleBackColor = True
        '
        'TbIdSalida
        '
        Me.TbIdSalida.Location = New System.Drawing.Point(119, 19)
        Me.TbIdSalida.Name = "TbIdSalida"
        Me.TbIdSalida.ReadOnly = True
        Me.TbIdSalida.Size = New System.Drawing.Size(100, 20)
        Me.TbIdSalida.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ID Salida"
        '
        'TbComprador
        '
        Me.TbComprador.Location = New System.Drawing.Point(119, 82)
        Me.TbComprador.Name = "TbComprador"
        Me.TbComprador.ReadOnly = True
        Me.TbComprador.Size = New System.Drawing.Size(100, 20)
        Me.TbComprador.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Comprador"
        '
        'ResumenToolStripMenuItem
        '
        Me.ResumenToolStripMenuItem.Name = "ResumenToolStripMenuItem"
        Me.ResumenToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ResumenToolStripMenuItem.Text = "Resumen"
        '
        'RepSalidaPacas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 592)
        Me.Controls.Add(Me.CRVReporteSalida)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RepSalidaPacas"
        Me.Text = "Salida de Pacas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CRVReporteSalida As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NueviToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TbComprador As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TbIdSalida As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtComprador As Button
    Friend WithEvents BtIdSalida As Button
    Friend WithEvents CkDiferencia As CheckBox
    Friend WithEvents ResumenToolStripMenuItem As ToolStripMenuItem
End Class
