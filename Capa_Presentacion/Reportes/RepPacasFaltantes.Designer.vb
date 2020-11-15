<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepPacasFaltantes
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
        Me.GbParametros = New System.Windows.Forms.GroupBox()
        Me.BtConsultar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbFolioFinal = New System.Windows.Forms.TextBox()
        Me.TbFolioInicial = New System.Windows.Forms.TextBox()
        Me.CbPlanta = New System.Windows.Forms.ComboBox()
        Me.CRVPacasFaltantes = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbParametros.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbParametros
        '
        Me.GbParametros.Controls.Add(Me.BtConsultar)
        Me.GbParametros.Controls.Add(Me.Label3)
        Me.GbParametros.Controls.Add(Me.Label2)
        Me.GbParametros.Controls.Add(Me.Label1)
        Me.GbParametros.Controls.Add(Me.TbFolioFinal)
        Me.GbParametros.Controls.Add(Me.TbFolioInicial)
        Me.GbParametros.Controls.Add(Me.CbPlanta)
        Me.GbParametros.Dock = System.Windows.Forms.DockStyle.Left
        Me.GbParametros.Location = New System.Drawing.Point(0, 24)
        Me.GbParametros.Name = "GbParametros"
        Me.GbParametros.Size = New System.Drawing.Size(349, 705)
        Me.GbParametros.TabIndex = 1
        Me.GbParametros.TabStop = False
        '
        'BtConsultar
        '
        Me.BtConsultar.Location = New System.Drawing.Point(95, 277)
        Me.BtConsultar.Name = "BtConsultar"
        Me.BtConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtConsultar.TabIndex = 3
        Me.BtConsultar.Text = "Consultar"
        Me.BtConsultar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(206, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "a"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "De No Paca"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Planta Origen :"
        '
        'TbFolioFinal
        '
        Me.TbFolioFinal.Location = New System.Drawing.Point(229, 169)
        Me.TbFolioFinal.Name = "TbFolioFinal"
        Me.TbFolioFinal.Size = New System.Drawing.Size(100, 20)
        Me.TbFolioFinal.TabIndex = 2
        '
        'TbFolioInicial
        '
        Me.TbFolioInicial.Location = New System.Drawing.Point(95, 169)
        Me.TbFolioInicial.Name = "TbFolioInicial"
        Me.TbFolioInicial.Size = New System.Drawing.Size(100, 20)
        Me.TbFolioInicial.TabIndex = 1
        '
        'CbPlanta
        '
        Me.CbPlanta.FormattingEnabled = True
        Me.CbPlanta.Location = New System.Drawing.Point(95, 40)
        Me.CbPlanta.Name = "CbPlanta"
        Me.CbPlanta.Size = New System.Drawing.Size(234, 21)
        Me.CbPlanta.TabIndex = 0
        '
        'CRVPacasFaltantes
        '
        Me.CRVPacasFaltantes.ActiveViewIndex = -1
        Me.CRVPacasFaltantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVPacasFaltantes.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVPacasFaltantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVPacasFaltantes.Location = New System.Drawing.Point(349, 24)
        Me.CRVPacasFaltantes.Name = "CRVPacasFaltantes"
        Me.CRVPacasFaltantes.ShowCloseButton = False
        Me.CRVPacasFaltantes.ShowCopyButton = False
        Me.CRVPacasFaltantes.ShowGroupTreeButton = False
        Me.CRVPacasFaltantes.ShowLogo = False
        Me.CRVPacasFaltantes.ShowParameterPanelButton = False
        Me.CRVPacasFaltantes.ShowRefreshButton = False
        Me.CRVPacasFaltantes.Size = New System.Drawing.Size(865, 705)
        Me.CRVPacasFaltantes.TabIndex = 6
        Me.CRVPacasFaltantes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1214, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'RepPacasFaltantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 729)
        Me.Controls.Add(Me.CRVPacasFaltantes)
        Me.Controls.Add(Me.GbParametros)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RepPacasFaltantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pacas Faltantes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbParametros.ResumeLayout(False)
        Me.GbParametros.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbParametros As GroupBox
    Friend WithEvents CRVPacasFaltantes As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BtConsultar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TbFolioFinal As TextBox
    Friend WithEvents TbFolioInicial As TextBox
    Friend WithEvents CbPlanta As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
