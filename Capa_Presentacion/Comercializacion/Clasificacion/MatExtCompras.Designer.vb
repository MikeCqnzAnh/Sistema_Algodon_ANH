<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MatExtCompras
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbNoPaca = New System.Windows.Forms.TextBox()
        Me.GbParametros = New System.Windows.Forms.GroupBox()
        Me.GbLevel2 = New System.Windows.Forms.GroupBox()
        Me.RbSinCastigoLevel2 = New System.Windows.Forms.RadioButton()
        Me.NuPlasticLevel2 = New System.Windows.Forms.NumericUpDown()
        Me.NuOtherLevel2 = New System.Windows.Forms.NumericUpDown()
        Me.NuPrepLevel2 = New System.Windows.Forms.NumericUpDown()
        Me.NuBarkLevel2 = New System.Windows.Forms.NumericUpDown()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.GbLevel1 = New System.Windows.Forms.GroupBox()
        Me.RbSinCastigoLevel1 = New System.Windows.Forms.RadioButton()
        Me.NuPlasticLevel1 = New System.Windows.Forms.NumericUpDown()
        Me.NuOtherLevel1 = New System.Windows.Forms.NumericUpDown()
        Me.NuPrepLevel1 = New System.Windows.Forms.NumericUpDown()
        Me.NuBarkLevel1 = New System.Windows.Forms.NumericUpDown()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbDatagrid = New System.Windows.Forms.GroupBox()
        Me.DgvPacas = New System.Windows.Forms.DataGridView()
        Me.GbDatos.SuspendLayout()
        Me.GbParametros.SuspendLayout()
        Me.GbLevel2.SuspendLayout()
        CType(Me.NuPlasticLevel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuOtherLevel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuPrepLevel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuBarkLevel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbLevel1.SuspendLayout()
        CType(Me.NuPlasticLevel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuOtherLevel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuPrepLevel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuBarkLevel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GbDatagrid.SuspendLayout()
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.Label2)
        Me.GbDatos.Controls.Add(Me.TbNoPaca)
        Me.GbDatos.Controls.Add(Me.GbParametros)
        Me.GbDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatos.Location = New System.Drawing.Point(0, 24)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(1028, 187)
        Me.GbDatos.TabIndex = 0
        Me.GbDatos.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(583, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 37)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "No. Paca"
        '
        'TbNoPaca
        '
        Me.TbNoPaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNoPaca.Location = New System.Drawing.Point(747, 131)
        Me.TbNoPaca.Name = "TbNoPaca"
        Me.TbNoPaca.Size = New System.Drawing.Size(275, 44)
        Me.TbNoPaca.TabIndex = 0
        '
        'GbParametros
        '
        Me.GbParametros.Controls.Add(Me.GbLevel2)
        Me.GbParametros.Controls.Add(Me.GbLevel1)
        Me.GbParametros.Dock = System.Windows.Forms.DockStyle.Left
        Me.GbParametros.Location = New System.Drawing.Point(3, 16)
        Me.GbParametros.Name = "GbParametros"
        Me.GbParametros.Size = New System.Drawing.Size(560, 168)
        Me.GbParametros.TabIndex = 20
        Me.GbParametros.TabStop = False
        Me.GbParametros.Text = "Parametros"
        '
        'GbLevel2
        '
        Me.GbLevel2.Controls.Add(Me.RbSinCastigoLevel2)
        Me.GbLevel2.Controls.Add(Me.NuPlasticLevel2)
        Me.GbLevel2.Controls.Add(Me.NuOtherLevel2)
        Me.GbLevel2.Controls.Add(Me.NuPrepLevel2)
        Me.GbLevel2.Controls.Add(Me.NuBarkLevel2)
        Me.GbLevel2.Controls.Add(Me.RadioButton8)
        Me.GbLevel2.Controls.Add(Me.RadioButton7)
        Me.GbLevel2.Controls.Add(Me.RadioButton6)
        Me.GbLevel2.Controls.Add(Me.RadioButton5)
        Me.GbLevel2.Location = New System.Drawing.Point(220, 19)
        Me.GbLevel2.Name = "GbLevel2"
        Me.GbLevel2.Size = New System.Drawing.Size(217, 175)
        Me.GbLevel2.TabIndex = 25
        Me.GbLevel2.TabStop = False
        Me.GbLevel2.Text = "Nivel 2"
        '
        'RbSinCastigoLevel2
        '
        Me.RbSinCastigoLevel2.AutoSize = True
        Me.RbSinCastigoLevel2.Location = New System.Drawing.Point(6, 19)
        Me.RbSinCastigoLevel2.Name = "RbSinCastigoLevel2"
        Me.RbSinCastigoLevel2.Size = New System.Drawing.Size(45, 17)
        Me.RbSinCastigoLevel2.TabIndex = 28
        Me.RbSinCastigoLevel2.TabStop = True
        Me.RbSinCastigoLevel2.Text = "N/A"
        Me.RbSinCastigoLevel2.UseVisualStyleBackColor = True
        '
        'NuPlasticLevel2
        '
        Me.NuPlasticLevel2.DecimalPlaces = 2
        Me.NuPlasticLevel2.Enabled = False
        Me.NuPlasticLevel2.Location = New System.Drawing.Point(68, 119)
        Me.NuPlasticLevel2.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.NuPlasticLevel2.Name = "NuPlasticLevel2"
        Me.NuPlasticLevel2.Size = New System.Drawing.Size(120, 20)
        Me.NuPlasticLevel2.TabIndex = 27
        Me.NuPlasticLevel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuPlasticLevel2.ThousandsSeparator = True
        '
        'NuOtherLevel2
        '
        Me.NuOtherLevel2.DecimalPlaces = 2
        Me.NuOtherLevel2.Enabled = False
        Me.NuOtherLevel2.Location = New System.Drawing.Point(68, 93)
        Me.NuOtherLevel2.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.NuOtherLevel2.Name = "NuOtherLevel2"
        Me.NuOtherLevel2.Size = New System.Drawing.Size(120, 20)
        Me.NuOtherLevel2.TabIndex = 26
        Me.NuOtherLevel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuOtherLevel2.ThousandsSeparator = True
        '
        'NuPrepLevel2
        '
        Me.NuPrepLevel2.DecimalPlaces = 2
        Me.NuPrepLevel2.Enabled = False
        Me.NuPrepLevel2.Location = New System.Drawing.Point(68, 67)
        Me.NuPrepLevel2.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.NuPrepLevel2.Name = "NuPrepLevel2"
        Me.NuPrepLevel2.Size = New System.Drawing.Size(120, 20)
        Me.NuPrepLevel2.TabIndex = 25
        Me.NuPrepLevel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuPrepLevel2.ThousandsSeparator = True
        '
        'NuBarkLevel2
        '
        Me.NuBarkLevel2.DecimalPlaces = 2
        Me.NuBarkLevel2.Enabled = False
        Me.NuBarkLevel2.Location = New System.Drawing.Point(68, 41)
        Me.NuBarkLevel2.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.NuBarkLevel2.Name = "NuBarkLevel2"
        Me.NuBarkLevel2.Size = New System.Drawing.Size(120, 20)
        Me.NuBarkLevel2.TabIndex = 24
        Me.NuBarkLevel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuBarkLevel2.ThousandsSeparator = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(6, 120)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(56, 17)
        Me.RadioButton8.TabIndex = 23
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "Plastic"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Location = New System.Drawing.Point(6, 94)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(51, 17)
        Me.RadioButton7.TabIndex = 22
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "Other"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(6, 68)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(47, 17)
        Me.RadioButton6.TabIndex = 21
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Prep"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(47, 17)
        Me.RadioButton5.TabIndex = 20
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Bark"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'GbLevel1
        '
        Me.GbLevel1.Controls.Add(Me.RbSinCastigoLevel1)
        Me.GbLevel1.Controls.Add(Me.NuPlasticLevel1)
        Me.GbLevel1.Controls.Add(Me.NuOtherLevel1)
        Me.GbLevel1.Controls.Add(Me.NuPrepLevel1)
        Me.GbLevel1.Controls.Add(Me.NuBarkLevel1)
        Me.GbLevel1.Controls.Add(Me.RadioButton1)
        Me.GbLevel1.Controls.Add(Me.RadioButton4)
        Me.GbLevel1.Controls.Add(Me.RadioButton2)
        Me.GbLevel1.Controls.Add(Me.RadioButton3)
        Me.GbLevel1.Location = New System.Drawing.Point(9, 19)
        Me.GbLevel1.Name = "GbLevel1"
        Me.GbLevel1.Size = New System.Drawing.Size(196, 175)
        Me.GbLevel1.TabIndex = 24
        Me.GbLevel1.TabStop = False
        Me.GbLevel1.Text = "Nivel 1"
        '
        'RbSinCastigoLevel1
        '
        Me.RbSinCastigoLevel1.AutoSize = True
        Me.RbSinCastigoLevel1.Location = New System.Drawing.Point(6, 19)
        Me.RbSinCastigoLevel1.Name = "RbSinCastigoLevel1"
        Me.RbSinCastigoLevel1.Size = New System.Drawing.Size(45, 17)
        Me.RbSinCastigoLevel1.TabIndex = 24
        Me.RbSinCastigoLevel1.TabStop = True
        Me.RbSinCastigoLevel1.Text = "N/A"
        Me.RbSinCastigoLevel1.UseVisualStyleBackColor = True
        '
        'NuPlasticLevel1
        '
        Me.NuPlasticLevel1.DecimalPlaces = 2
        Me.NuPlasticLevel1.Enabled = False
        Me.NuPlasticLevel1.Location = New System.Drawing.Point(68, 119)
        Me.NuPlasticLevel1.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.NuPlasticLevel1.Name = "NuPlasticLevel1"
        Me.NuPlasticLevel1.Size = New System.Drawing.Size(111, 20)
        Me.NuPlasticLevel1.TabIndex = 23
        Me.NuPlasticLevel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuPlasticLevel1.ThousandsSeparator = True
        '
        'NuOtherLevel1
        '
        Me.NuOtherLevel1.DecimalPlaces = 2
        Me.NuOtherLevel1.Enabled = False
        Me.NuOtherLevel1.Location = New System.Drawing.Point(68, 93)
        Me.NuOtherLevel1.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.NuOtherLevel1.Name = "NuOtherLevel1"
        Me.NuOtherLevel1.Size = New System.Drawing.Size(111, 20)
        Me.NuOtherLevel1.TabIndex = 22
        Me.NuOtherLevel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuOtherLevel1.ThousandsSeparator = True
        '
        'NuPrepLevel1
        '
        Me.NuPrepLevel1.DecimalPlaces = 2
        Me.NuPrepLevel1.Enabled = False
        Me.NuPrepLevel1.Location = New System.Drawing.Point(68, 67)
        Me.NuPrepLevel1.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.NuPrepLevel1.Name = "NuPrepLevel1"
        Me.NuPrepLevel1.Size = New System.Drawing.Size(111, 20)
        Me.NuPrepLevel1.TabIndex = 21
        Me.NuPrepLevel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuPrepLevel1.ThousandsSeparator = True
        '
        'NuBarkLevel1
        '
        Me.NuBarkLevel1.DecimalPlaces = 2
        Me.NuBarkLevel1.Enabled = False
        Me.NuBarkLevel1.Location = New System.Drawing.Point(68, 41)
        Me.NuBarkLevel1.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.NuBarkLevel1.Name = "NuBarkLevel1"
        Me.NuBarkLevel1.Size = New System.Drawing.Size(111, 20)
        Me.NuBarkLevel1.TabIndex = 20
        Me.NuBarkLevel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NuBarkLevel1.ThousandsSeparator = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(47, 17)
        Me.RadioButton1.TabIndex = 16
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Bark"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 120)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(56, 17)
        Me.RadioButton4.TabIndex = 19
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Plastic"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 68)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(47, 17)
        Me.RadioButton2.TabIndex = 17
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Prep"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 94)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(51, 17)
        Me.RadioButton3.TabIndex = 18
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Other"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GbDatagrid
        '
        Me.GbDatagrid.Controls.Add(Me.DgvPacas)
        Me.GbDatagrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbDatagrid.Location = New System.Drawing.Point(0, 211)
        Me.GbDatagrid.Name = "GbDatagrid"
        Me.GbDatagrid.Size = New System.Drawing.Size(1028, 390)
        Me.GbDatagrid.TabIndex = 2
        Me.GbDatagrid.TabStop = False
        '
        'DgvPacas
        '
        Me.DgvPacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacas.Location = New System.Drawing.Point(3, 16)
        Me.DgvPacas.Name = "DgvPacas"
        Me.DgvPacas.Size = New System.Drawing.Size(1022, 371)
        Me.DgvPacas.TabIndex = 0
        '
        'MatExtCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 601)
        Me.Controls.Add(Me.GbDatagrid)
        Me.Controls.Add(Me.GbDatos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MatExtCompras"
        Me.Text = "Materias Extrañas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        Me.GbParametros.ResumeLayout(False)
        Me.GbLevel2.ResumeLayout(False)
        Me.GbLevel2.PerformLayout()
        CType(Me.NuPlasticLevel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuOtherLevel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuPrepLevel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuBarkLevel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbLevel1.ResumeLayout(False)
        Me.GbLevel1.PerformLayout()
        CType(Me.NuPlasticLevel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuOtherLevel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuPrepLevel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuBarkLevel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GbDatagrid.ResumeLayout(False)
        CType(Me.DgvPacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents TbNoPaca As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents GbDatagrid As GroupBox
    Friend WithEvents DgvPacas As DataGridView
    Friend WithEvents GbParametros As GroupBox
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GbLevel2 As GroupBox
    Friend WithEvents NuPlasticLevel2 As NumericUpDown
    Friend WithEvents NuOtherLevel2 As NumericUpDown
    Friend WithEvents NuPrepLevel2 As NumericUpDown
    Friend WithEvents NuBarkLevel2 As NumericUpDown
    Friend WithEvents GbLevel1 As GroupBox
    Friend WithEvents NuPlasticLevel1 As NumericUpDown
    Friend WithEvents NuOtherLevel1 As NumericUpDown
    Friend WithEvents NuPrepLevel1 As NumericUpDown
    Friend WithEvents NuBarkLevel1 As NumericUpDown
    Friend WithEvents RbSinCastigoLevel2 As RadioButton
    Friend WithEvents RbSinCastigoLevel1 As RadioButton
End Class
