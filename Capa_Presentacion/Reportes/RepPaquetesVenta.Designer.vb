<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepPaquetesVenta
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
        Me.GbFiltros = New System.Windows.Forms.GroupBox()
        Me.BtConsultar = New System.Windows.Forms.Button()
        Me.GbFiltrado = New System.Windows.Forms.GroupBox()
        Me.CbPlanta = New System.Windows.Forms.ComboBox()
        Me.CbClase = New System.Windows.Forms.ComboBox()
        Me.CkMenor = New System.Windows.Forms.CheckBox()
        Me.CkMayor = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbCantidadPacas = New System.Windows.Forms.TextBox()
        Me.TbIdPaquete = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CRVPaquetesVenta = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbFiltros.SuspendLayout()
        Me.GbFiltrado.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbFiltros
        '
        Me.GbFiltros.Controls.Add(Me.BtConsultar)
        Me.GbFiltros.Controls.Add(Me.GbFiltrado)
        Me.GbFiltros.Controls.Add(Me.TbIdPaquete)
        Me.GbFiltros.Controls.Add(Me.Label1)
        Me.GbFiltros.Dock = System.Windows.Forms.DockStyle.Left
        Me.GbFiltros.Location = New System.Drawing.Point(0, 24)
        Me.GbFiltros.Name = "GbFiltros"
        Me.GbFiltros.Size = New System.Drawing.Size(318, 605)
        Me.GbFiltros.TabIndex = 0
        Me.GbFiltros.TabStop = False
        '
        'BtConsultar
        '
        Me.BtConsultar.Location = New System.Drawing.Point(237, 335)
        Me.BtConsultar.Name = "BtConsultar"
        Me.BtConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtConsultar.TabIndex = 2
        Me.BtConsultar.Text = "Consultar"
        Me.BtConsultar.UseVisualStyleBackColor = True
        '
        'GbFiltrado
        '
        Me.GbFiltrado.Controls.Add(Me.CbPlanta)
        Me.GbFiltrado.Controls.Add(Me.CbClase)
        Me.GbFiltrado.Controls.Add(Me.CkMenor)
        Me.GbFiltrado.Controls.Add(Me.CkMayor)
        Me.GbFiltrado.Controls.Add(Me.Label3)
        Me.GbFiltrado.Controls.Add(Me.Label2)
        Me.GbFiltrado.Controls.Add(Me.Label4)
        Me.GbFiltrado.Controls.Add(Me.TbCantidadPacas)
        Me.GbFiltrado.Location = New System.Drawing.Point(6, 127)
        Me.GbFiltrado.Name = "GbFiltrado"
        Me.GbFiltrado.Size = New System.Drawing.Size(306, 180)
        Me.GbFiltrado.TabIndex = 1
        Me.GbFiltrado.TabStop = False
        Me.GbFiltrado.Text = "Parametros de filtrado"
        '
        'CbPlanta
        '
        Me.CbPlanta.FormattingEnabled = True
        Me.CbPlanta.Location = New System.Drawing.Point(97, 126)
        Me.CbPlanta.Name = "CbPlanta"
        Me.CbPlanta.Size = New System.Drawing.Size(121, 21)
        Me.CbPlanta.TabIndex = 4
        '
        'CbClase
        '
        Me.CbClase.FormattingEnabled = True
        Me.CbClase.Location = New System.Drawing.Point(97, 99)
        Me.CbClase.Name = "CbClase"
        Me.CbClase.Size = New System.Drawing.Size(121, 21)
        Me.CbClase.TabIndex = 3
        '
        'CkMenor
        '
        Me.CkMenor.AutoSize = True
        Me.CkMenor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CkMenor.Location = New System.Drawing.Point(97, 63)
        Me.CkMenor.Name = "CkMenor"
        Me.CkMenor.Size = New System.Drawing.Size(77, 17)
        Me.CkMenor.TabIndex = 1
        Me.CkMenor.Text = "Menor que"
        Me.CkMenor.UseVisualStyleBackColor = True
        '
        'CkMayor
        '
        Me.CkMayor.AutoSize = True
        Me.CkMayor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CkMayor.Location = New System.Drawing.Point(191, 63)
        Me.CkMayor.Name = "CkMayor"
        Me.CkMayor.Size = New System.Drawing.Size(76, 17)
        Me.CkMayor.TabIndex = 2
        Me.CkMayor.Text = "Mayor que"
        Me.CkMayor.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Planta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Clase:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Cantidad Pacas:"
        '
        'TbCantidadPacas
        '
        Me.TbCantidadPacas.Location = New System.Drawing.Point(97, 37)
        Me.TbCantidadPacas.Name = "TbCantidadPacas"
        Me.TbCantidadPacas.Size = New System.Drawing.Size(60, 20)
        Me.TbCantidadPacas.TabIndex = 0
        '
        'TbIdPaquete
        '
        Me.TbIdPaquete.Location = New System.Drawing.Point(85, 28)
        Me.TbIdPaquete.Name = "TbIdPaquete"
        Me.TbIdPaquete.Size = New System.Drawing.Size(94, 20)
        Me.TbIdPaquete.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Paquete No."
        '
        'CRVPaquetesVenta
        '
        Me.CRVPaquetesVenta.ActiveViewIndex = -1
        Me.CRVPaquetesVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVPaquetesVenta.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVPaquetesVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVPaquetesVenta.Location = New System.Drawing.Point(318, 24)
        Me.CRVPaquetesVenta.Name = "CRVPaquetesVenta"
        Me.CRVPaquetesVenta.ShowCloseButton = False
        Me.CRVPaquetesVenta.ShowCopyButton = False
        Me.CRVPaquetesVenta.ShowGroupTreeButton = False
        Me.CRVPaquetesVenta.ShowLogo = False
        Me.CRVPaquetesVenta.ShowParameterPanelButton = False
        Me.CRVPaquetesVenta.ShowRefreshButton = False
        Me.CRVPaquetesVenta.Size = New System.Drawing.Size(797, 605)
        Me.CRVPaquetesVenta.TabIndex = 2
        Me.CRVPaquetesVenta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1115, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.LimpiarToolStripMenuItem.Text = "Nuevo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'RepPaquetesVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 629)
        Me.Controls.Add(Me.CRVPaquetesVenta)
        Me.Controls.Add(Me.GbFiltros)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RepPaquetesVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Paquetes de Venta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbFiltros.ResumeLayout(False)
        Me.GbFiltros.PerformLayout()
        Me.GbFiltrado.ResumeLayout(False)
        Me.GbFiltrado.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbFiltros As GroupBox
    Friend WithEvents CRVPaquetesVenta As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TbCantidadPacas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TbIdPaquete As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GbFiltrado As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CkMenor As CheckBox
    Friend WithEvents CkMayor As CheckBox
    Friend WithEvents BtConsultar As Button
    Friend WithEvents CbClase As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CbPlanta As ComboBox
    Friend WithEvents Label3 As Label
End Class
