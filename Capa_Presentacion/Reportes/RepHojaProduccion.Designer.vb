<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepHojaProduccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RepHojaProduccion))
        Me.gbreporte = New System.Windows.Forms.GroupBox()
        Me.cbpaquetes = New System.Windows.Forms.ComboBox()
        Me.rbcantidadpacas = New System.Windows.Forms.RadioButton()
        Me.rbpaquetes = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbcantidad = New System.Windows.Forms.TextBox()
        Me.tbfoliofinal = New System.Windows.Forms.TextBox()
        Me.tbfolioinicial = New System.Windows.Forms.TextBox()
        Me.tbidreporte = New System.Windows.Forms.TextBox()
        Me.cbplanta = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CRVHojaProduccion = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.gbreporte.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbreporte
        '
        Me.gbreporte.Controls.Add(Me.cbpaquetes)
        Me.gbreporte.Controls.Add(Me.rbcantidadpacas)
        Me.gbreporte.Controls.Add(Me.rbpaquetes)
        Me.gbreporte.Controls.Add(Me.Label6)
        Me.gbreporte.Controls.Add(Me.Label5)
        Me.gbreporte.Controls.Add(Me.Label4)
        Me.gbreporte.Controls.Add(Me.dtfecha)
        Me.gbreporte.Controls.Add(Me.Label2)
        Me.gbreporte.Controls.Add(Me.Label1)
        Me.gbreporte.Controls.Add(Me.tbcantidad)
        Me.gbreporte.Controls.Add(Me.tbfoliofinal)
        Me.gbreporte.Controls.Add(Me.tbfolioinicial)
        Me.gbreporte.Controls.Add(Me.tbidreporte)
        Me.gbreporte.Controls.Add(Me.cbplanta)
        Me.gbreporte.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbreporte.Location = New System.Drawing.Point(0, 24)
        Me.gbreporte.Name = "gbreporte"
        Me.gbreporte.Size = New System.Drawing.Size(1188, 83)
        Me.gbreporte.TabIndex = 0
        Me.gbreporte.TabStop = False
        Me.gbreporte.Text = "Datos de Reporte"
        '
        'cbpaquetes
        '
        Me.cbpaquetes.FormattingEnabled = True
        Me.cbpaquetes.Location = New System.Drawing.Point(130, 51)
        Me.cbpaquetes.MaxLength = 3
        Me.cbpaquetes.Name = "cbpaquetes"
        Me.cbpaquetes.Size = New System.Drawing.Size(73, 21)
        Me.cbpaquetes.TabIndex = 14
        '
        'rbcantidadpacas
        '
        Me.rbcantidadpacas.AutoSize = True
        Me.rbcantidadpacas.Location = New System.Drawing.Point(228, 52)
        Me.rbcantidadpacas.Name = "rbcantidadpacas"
        Me.rbcantidadpacas.Size = New System.Drawing.Size(115, 17)
        Me.rbcantidadpacas.TabIndex = 13
        Me.rbcantidadpacas.Text = "Cantidad de Pacas"
        Me.rbcantidadpacas.UseVisualStyleBackColor = True
        '
        'rbpaquetes
        '
        Me.rbpaquetes.AutoSize = True
        Me.rbpaquetes.Checked = True
        Me.rbpaquetes.Location = New System.Drawing.Point(9, 52)
        Me.rbpaquetes.Name = "rbpaquetes"
        Me.rbpaquetes.Size = New System.Drawing.Size(87, 17)
        Me.rbpaquetes.TabIndex = 12
        Me.rbpaquetes.TabStop = True
        Me.rbpaquetes.Text = "No Paquetes"
        Me.rbpaquetes.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Etiqueta inicial"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(209, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "a"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(778, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fecha"
        Me.Label4.Visible = False
        '
        'dtfecha
        '
        Me.dtfecha.CustomFormat = "MM/dd/yyyy hh:mm tt"
        Me.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtfecha.Location = New System.Drawing.Point(821, 44)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(171, 20)
        Me.dtfecha.TabIndex = 8
        Me.dtfecha.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(998, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Planta"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(998, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID"
        Me.Label1.Visible = False
        '
        'tbcantidad
        '
        Me.tbcantidad.Enabled = False
        Me.tbcantidad.Location = New System.Drawing.Point(349, 52)
        Me.tbcantidad.MaxLength = 4
        Me.tbcantidad.Name = "tbcantidad"
        Me.tbcantidad.Size = New System.Drawing.Size(49, 20)
        Me.tbcantidad.TabIndex = 4
        Me.tbcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbfoliofinal
        '
        Me.tbfoliofinal.Enabled = False
        Me.tbfoliofinal.Location = New System.Drawing.Point(228, 26)
        Me.tbfoliofinal.MaxLength = 10
        Me.tbfoliofinal.Name = "tbfoliofinal"
        Me.tbfoliofinal.Size = New System.Drawing.Size(73, 20)
        Me.tbfoliofinal.TabIndex = 3
        Me.tbfoliofinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbfolioinicial
        '
        Me.tbfolioinicial.Location = New System.Drawing.Point(130, 26)
        Me.tbfolioinicial.MaxLength = 10
        Me.tbfolioinicial.Name = "tbfolioinicial"
        Me.tbfolioinicial.Size = New System.Drawing.Size(73, 20)
        Me.tbfolioinicial.TabIndex = 2
        Me.tbfolioinicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbidreporte
        '
        Me.tbidreporte.Location = New System.Drawing.Point(1041, 17)
        Me.tbidreporte.Name = "tbidreporte"
        Me.tbidreporte.ReadOnly = True
        Me.tbidreporte.Size = New System.Drawing.Size(100, 20)
        Me.tbidreporte.TabIndex = 1
        Me.tbidreporte.Visible = False
        '
        'cbplanta
        '
        Me.cbplanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbplanta.FormattingEnabled = True
        Me.cbplanta.Location = New System.Drawing.Point(1041, 44)
        Me.cbplanta.Name = "cbplanta"
        Me.cbplanta.Size = New System.Drawing.Size(141, 21)
        Me.cbplanta.TabIndex = 0
        Me.cbplanta.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GenerarReporteToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1188, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'GenerarReporteToolStripMenuItem
        '
        Me.GenerarReporteToolStripMenuItem.Name = "GenerarReporteToolStripMenuItem"
        Me.GenerarReporteToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.GenerarReporteToolStripMenuItem.Text = "Generar reporte"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'CRVHojaProduccion
        '
        Me.CRVHojaProduccion.ActiveViewIndex = -1
        Me.CRVHojaProduccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRVHojaProduccion.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRVHojaProduccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRVHojaProduccion.Location = New System.Drawing.Point(0, 107)
        Me.CRVHojaProduccion.Name = "CRVHojaProduccion"
        Me.CRVHojaProduccion.ShowCloseButton = False
        Me.CRVHojaProduccion.ShowGroupTreeButton = False
        Me.CRVHojaProduccion.ShowLogo = False
        Me.CRVHojaProduccion.ShowParameterPanelButton = False
        Me.CRVHojaProduccion.ShowRefreshButton = False
        Me.CRVHojaProduccion.Size = New System.Drawing.Size(1188, 641)
        Me.CRVHojaProduccion.TabIndex = 66
        Me.CRVHojaProduccion.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'RepHojaProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1188, 748)
        Me.Controls.Add(Me.CRVHojaProduccion)
        Me.Controls.Add(Me.gbreporte)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RepHojaProduccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reporte de Produccion"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbreporte.ResumeLayout(False)
        Me.gbreporte.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbreporte As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tbidreporte As TextBox
    Friend WithEvents cbplanta As ComboBox
    Friend WithEvents tbfoliofinal As TextBox
    Friend WithEvents tbfolioinicial As TextBox
    Friend WithEvents tbcantidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtfecha As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CRVHojaProduccion As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rbcantidadpacas As RadioButton
    Friend WithEvents rbpaquetes As RadioButton
    Friend WithEvents cbpaquetes As ComboBox
End Class
