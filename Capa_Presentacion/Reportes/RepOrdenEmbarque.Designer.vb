<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RepOrdenEmbarque
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
        Me.GbDatosEmbarque = New System.Windows.Forms.GroupBox()
        Me.CbNoLote = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbIdEmbarque = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CRVOrdenEmbarque = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ChKilos = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbDatosEmbarque.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbDatosEmbarque
        '
        Me.GbDatosEmbarque.Controls.Add(Me.ChKilos)
        Me.GbDatosEmbarque.Controls.Add(Me.CbNoLote)
        Me.GbDatosEmbarque.Controls.Add(Me.Label2)
        Me.GbDatosEmbarque.Controls.Add(Me.TbIdEmbarque)
        Me.GbDatosEmbarque.Controls.Add(Me.Label1)
        Me.GbDatosEmbarque.Dock = System.Windows.Forms.DockStyle.Left
        Me.GbDatosEmbarque.Location = New System.Drawing.Point(0, 24)
        Me.GbDatosEmbarque.Name = "GbDatosEmbarque"
        Me.GbDatosEmbarque.Size = New System.Drawing.Size(252, 620)
        Me.GbDatosEmbarque.TabIndex = 0
        Me.GbDatosEmbarque.TabStop = False
        Me.GbDatosEmbarque.Text = "Datos de Embarque"
        '
        'CbNoLote
        '
        Me.CbNoLote.FormattingEnabled = True
        Me.CbNoLote.Location = New System.Drawing.Point(81, 79)
        Me.CbNoLote.Name = "CbNoLote"
        Me.CbNoLote.Size = New System.Drawing.Size(121, 21)
        Me.CbNoLote.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "No Lote"
        '
        'TbIdEmbarque
        '
        Me.TbIdEmbarque.Enabled = False
        Me.TbIdEmbarque.Location = New System.Drawing.Point(81, 35)
        Me.TbIdEmbarque.Name = "TbIdEmbarque"
        Me.TbIdEmbarque.Size = New System.Drawing.Size(100, 20)
        Me.TbIdEmbarque.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Embarque"
        '
        'CRVOrdenEmbarque
        '
        Me.CRVOrdenEmbarque.ActiveViewIndex = -1
        Me.CRVOrdenEmbarque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVOrdenEmbarque.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVOrdenEmbarque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVOrdenEmbarque.Location = New System.Drawing.Point(252, 24)
        Me.CRVOrdenEmbarque.Name = "CRVOrdenEmbarque"
        Me.CRVOrdenEmbarque.ShowCloseButton = False
        Me.CRVOrdenEmbarque.ShowGroupTreeButton = False
        Me.CRVOrdenEmbarque.ShowLogo = False
        Me.CRVOrdenEmbarque.ShowParameterPanelButton = False
        Me.CRVOrdenEmbarque.ShowRefreshButton = False
        Me.CRVOrdenEmbarque.Size = New System.Drawing.Size(844, 620)
        Me.CRVOrdenEmbarque.TabIndex = 3
        Me.CRVOrdenEmbarque.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ChKilos
        '
        Me.ChKilos.AutoSize = True
        Me.ChKilos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChKilos.Location = New System.Drawing.Point(9, 126)
        Me.ChKilos.Name = "ChKilos"
        Me.ChKilos.Size = New System.Drawing.Size(95, 17)
        Me.ChKilos.TabIndex = 4
        Me.ChKilos.Text = "Visualizar Kilos"
        Me.ChKilos.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1096, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'RepOrdenEmbarque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 644)
        Me.Controls.Add(Me.CRVOrdenEmbarque)
        Me.Controls.Add(Me.GbDatosEmbarque)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RepOrdenEmbarque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reporte Orden de Embarque"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbDatosEmbarque.ResumeLayout(False)
        Me.GbDatosEmbarque.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbDatosEmbarque As GroupBox
    Friend WithEvents CRVOrdenEmbarque As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TbIdEmbarque As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CbNoLote As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ChKilos As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
End Class
