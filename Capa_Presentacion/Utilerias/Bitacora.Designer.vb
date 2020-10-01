<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bitacora
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PDatos = New System.Windows.Forms.Panel()
        Me.DgvBitacora = New System.Windows.Forms.DataGridView()
        Me.GbFiltros = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbOperacion = New System.Windows.Forms.ComboBox()
        Me.CbModulo = New System.Windows.Forms.ComboBox()
        Me.CbUsuario = New System.Windows.Forms.ComboBox()
        Me.DtFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.BtConsulta = New System.Windows.Forms.Button()
        Me.DtFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LimpiarCamposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarBitacoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PDatos.SuspendLayout()
        CType(Me.DgvBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbFiltros.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PDatos
        '
        Me.PDatos.Controls.Add(Me.DgvBitacora)
        Me.PDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PDatos.Location = New System.Drawing.Point(0, 176)
        Me.PDatos.Name = "PDatos"
        Me.PDatos.Size = New System.Drawing.Size(1154, 440)
        Me.PDatos.TabIndex = 0
        '
        'DgvBitacora
        '
        Me.DgvBitacora.AllowUserToAddRows = False
        Me.DgvBitacora.AllowUserToDeleteRows = False
        Me.DgvBitacora.AllowUserToOrderColumns = True
        Me.DgvBitacora.AllowUserToResizeRows = False
        Me.DgvBitacora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvBitacora.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBitacora.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvBitacora.Location = New System.Drawing.Point(0, 0)
        Me.DgvBitacora.MultiSelect = False
        Me.DgvBitacora.Name = "DgvBitacora"
        Me.DgvBitacora.RowHeadersVisible = False
        Me.DgvBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvBitacora.Size = New System.Drawing.Size(1154, 440)
        Me.DgvBitacora.TabIndex = 2
        '
        'GbFiltros
        '
        Me.GbFiltros.Controls.Add(Me.Panel1)
        Me.GbFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbFiltros.Location = New System.Drawing.Point(0, 24)
        Me.GbFiltros.Name = "GbFiltros"
        Me.GbFiltros.Size = New System.Drawing.Size(1154, 152)
        Me.GbFiltros.TabIndex = 1
        Me.GbFiltros.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CbOperacion)
        Me.Panel1.Controls.Add(Me.CbModulo)
        Me.Panel1.Controls.Add(Me.CbUsuario)
        Me.Panel1.Controls.Add(Me.DtFechaFin)
        Me.Panel1.Controls.Add(Me.BtConsulta)
        Me.Panel1.Controls.Add(Me.DtFechaInicio)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1148, 133)
        Me.Panel1.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(809, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Operacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(559, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Modulo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(348, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Usuario"
        '
        'CbOperacion
        '
        Me.CbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbOperacion.FormattingEnabled = True
        Me.CbOperacion.Location = New System.Drawing.Point(871, 25)
        Me.CbOperacion.Name = "CbOperacion"
        Me.CbOperacion.Size = New System.Drawing.Size(232, 21)
        Me.CbOperacion.TabIndex = 5
        '
        'CbModulo
        '
        Me.CbModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbModulo.FormattingEnabled = True
        Me.CbModulo.Location = New System.Drawing.Point(607, 25)
        Me.CbModulo.Name = "CbModulo"
        Me.CbModulo.Size = New System.Drawing.Size(196, 21)
        Me.CbModulo.TabIndex = 4
        '
        'CbUsuario
        '
        Me.CbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbUsuario.FormattingEnabled = True
        Me.CbUsuario.Location = New System.Drawing.Point(397, 26)
        Me.CbUsuario.Name = "CbUsuario"
        Me.CbUsuario.Size = New System.Drawing.Size(138, 21)
        Me.CbUsuario.TabIndex = 3
        '
        'DtFechaFin
        '
        Me.DtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaFin.Location = New System.Drawing.Point(222, 26)
        Me.DtFechaFin.Name = "DtFechaFin"
        Me.DtFechaFin.Size = New System.Drawing.Size(104, 20)
        Me.DtFechaFin.TabIndex = 0
        '
        'BtConsulta
        '
        Me.BtConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtConsulta.Location = New System.Drawing.Point(1064, 94)
        Me.BtConsulta.MaximumSize = New System.Drawing.Size(75, 23)
        Me.BtConsulta.MinimumSize = New System.Drawing.Size(75, 23)
        Me.BtConsulta.Name = "BtConsulta"
        Me.BtConsulta.Size = New System.Drawing.Size(75, 23)
        Me.BtConsulta.TabIndex = 2
        Me.BtConsulta.Text = "Consultar"
        Me.BtConsulta.UseVisualStyleBackColor = True
        '
        'DtFechaInicio
        '
        Me.DtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaInicio.Location = New System.Drawing.Point(47, 26)
        Me.DtFechaInicio.Name = "DtFechaInicio"
        Me.DtFechaInicio.Size = New System.Drawing.Size(104, 20)
        Me.DtFechaInicio.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Desde"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarCamposToolStripMenuItem, Me.ExportarBitacoraToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1154, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LimpiarCamposToolStripMenuItem
        '
        Me.LimpiarCamposToolStripMenuItem.Name = "LimpiarCamposToolStripMenuItem"
        Me.LimpiarCamposToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.LimpiarCamposToolStripMenuItem.Text = "Limpiar Campos"
        '
        'ExportarBitacoraToolStripMenuItem
        '
        Me.ExportarBitacoraToolStripMenuItem.Name = "ExportarBitacoraToolStripMenuItem"
        Me.ExportarBitacoraToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.ExportarBitacoraToolStripMenuItem.Text = "Exportar Bitacora"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Bitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 616)
        Me.Controls.Add(Me.PDatos)
        Me.Controls.Add(Me.GbFiltros)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Bitacora"
        Me.Text = "Bitacora"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PDatos.ResumeLayout(False)
        CType(Me.DgvBitacora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbFiltros.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PDatos As Panel
    Friend WithEvents DgvBitacora As DataGridView
    Friend WithEvents GbFiltros As GroupBox
    Friend WithEvents DtFechaFin As DateTimePicker
    Friend WithEvents DtFechaInicio As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtConsulta As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LimpiarCamposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportarBitacoraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CbOperacion As ComboBox
    Friend WithEvents CbModulo As ComboBox
    Friend WithEvents CbUsuario As ComboBox
End Class
