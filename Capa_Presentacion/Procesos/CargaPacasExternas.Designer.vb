<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CargaPacasExternas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CargaPacasExternas))
        Me.BtProductor = New System.Windows.Forms.Button()
        Me.TbIdProductor = New System.Windows.Forms.TextBox()
        Me.TbNombreProductor = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcelParaImportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbPlantaOrigen = New System.Windows.Forms.ComboBox()
        Me.BtCargaExcel = New System.Windows.Forms.Button()
        Me.GbEncabezado = New System.Windows.Forms.GroupBox()
        Me.GbCentro = New System.Windows.Forms.GroupBox()
        Me.DgvPacas = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.GbEncabezado.SuspendLayout()
        Me.GbCentro.SuspendLayout()
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtProductor
        '
        Me.BtProductor.Location = New System.Drawing.Point(12, 19)
        Me.BtProductor.Name = "BtProductor"
        Me.BtProductor.Size = New System.Drawing.Size(68, 23)
        Me.BtProductor.TabIndex = 0
        Me.BtProductor.Text = "Productor"
        Me.BtProductor.UseVisualStyleBackColor = True
        '
        'TbIdProductor
        '
        Me.TbIdProductor.Location = New System.Drawing.Point(89, 21)
        Me.TbIdProductor.Name = "TbIdProductor"
        Me.TbIdProductor.ReadOnly = True
        Me.TbIdProductor.Size = New System.Drawing.Size(66, 20)
        Me.TbIdProductor.TabIndex = 1
        '
        'TbNombreProductor
        '
        Me.TbNombreProductor.Location = New System.Drawing.Point(161, 21)
        Me.TbNombreProductor.Name = "TbNombreProductor"
        Me.TbNombreProductor.ReadOnly = True
        Me.TbNombreProductor.Size = New System.Drawing.Size(421, 20)
        Me.TbNombreProductor.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ExcelParaImportarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1380, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevaToolStripMenuItem
        '
        Me.NuevaToolStripMenuItem.Name = "NuevaToolStripMenuItem"
        Me.NuevaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.NuevaToolStripMenuItem.Text = "Nueva"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'ExcelParaImportarToolStripMenuItem
        '
        Me.ExcelParaImportarToolStripMenuItem.Name = "ExcelParaImportarToolStripMenuItem"
        Me.ExcelParaImportarToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.ExcelParaImportarToolStripMenuItem.Text = "Excel para importar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Planta Origen"
        '
        'CbPlantaOrigen
        '
        Me.CbPlantaOrigen.FormattingEnabled = True
        Me.CbPlantaOrigen.Location = New System.Drawing.Point(89, 68)
        Me.CbPlantaOrigen.Name = "CbPlantaOrigen"
        Me.CbPlantaOrigen.Size = New System.Drawing.Size(229, 21)
        Me.CbPlantaOrigen.TabIndex = 5
        '
        'BtCargaExcel
        '
        Me.BtCargaExcel.BackgroundImage = CType(resources.GetObject("BtCargaExcel.BackgroundImage"), System.Drawing.Image)
        Me.BtCargaExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtCargaExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtCargaExcel.Location = New System.Drawing.Point(3, 3)
        Me.BtCargaExcel.Name = "BtCargaExcel"
        Me.BtCargaExcel.Size = New System.Drawing.Size(37, 35)
        Me.BtCargaExcel.TabIndex = 6
        Me.BtCargaExcel.UseVisualStyleBackColor = True
        '
        'GbEncabezado
        '
        Me.GbEncabezado.Controls.Add(Me.BtProductor)
        Me.GbEncabezado.Controls.Add(Me.TbIdProductor)
        Me.GbEncabezado.Controls.Add(Me.TbNombreProductor)
        Me.GbEncabezado.Controls.Add(Me.CbPlantaOrigen)
        Me.GbEncabezado.Controls.Add(Me.Label1)
        Me.GbEncabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbEncabezado.Location = New System.Drawing.Point(0, 24)
        Me.GbEncabezado.Name = "GbEncabezado"
        Me.GbEncabezado.Size = New System.Drawing.Size(1380, 109)
        Me.GbEncabezado.TabIndex = 8
        Me.GbEncabezado.TabStop = False
        '
        'GbCentro
        '
        Me.GbCentro.Controls.Add(Me.DgvPacas)
        Me.GbCentro.Controls.Add(Me.Panel1)
        Me.GbCentro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbCentro.Location = New System.Drawing.Point(0, 133)
        Me.GbCentro.Name = "GbCentro"
        Me.GbCentro.Size = New System.Drawing.Size(1380, 570)
        Me.GbCentro.TabIndex = 9
        Me.GbCentro.TabStop = False
        '
        'DgvPacas
        '
        Me.DgvPacas.AllowUserToAddRows = False
        Me.DgvPacas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvPacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacas.Location = New System.Drawing.Point(3, 66)
        Me.DgvPacas.Name = "DgvPacas"
        Me.DgvPacas.Size = New System.Drawing.Size(1374, 501)
        Me.DgvPacas.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtCargaExcel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1374, 50)
        Me.Panel1.TabIndex = 0
        '
        'CargaPacasExternas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1380, 703)
        Me.Controls.Add(Me.GbCentro)
        Me.Controls.Add(Me.GbEncabezado)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CargaPacasExternas"
        Me.Text = "Carga Pacas Externas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GbEncabezado.ResumeLayout(False)
        Me.GbEncabezado.PerformLayout()
        Me.GbCentro.ResumeLayout(False)
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtProductor As Button
    Friend WithEvents TbIdProductor As TextBox
    Friend WithEvents TbNombreProductor As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents CbPlantaOrigen As ComboBox
    Friend WithEvents BtCargaExcel As Button
    Friend WithEvents GbEncabezado As GroupBox
    Friend WithEvents GbCentro As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ExcelParaImportarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DgvPacas As DataGridView
End Class
