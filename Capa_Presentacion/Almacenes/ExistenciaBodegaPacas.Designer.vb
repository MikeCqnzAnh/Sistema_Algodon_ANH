<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExistenciaBodegaPacas
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GbGeneral = New System.Windows.Forms.GroupBox()
        Me.BtInsertar = New System.Windows.Forms.Button()
        Me.TbEtiqueta = New System.Windows.Forms.TextBox()
        Me.TbCantidadNiveles = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbCantidadRack = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbNivel = New System.Windows.Forms.ComboBox()
        Me.BtAceptar = New System.Windows.Forms.Button()
        Me.TbFilas = New System.Windows.Forms.TextBox()
        Me.TbColumnas = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DgvMatriz = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbGeneral.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvMatriz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbGeneral
        '
        Me.GbGeneral.Controls.Add(Me.BtInsertar)
        Me.GbGeneral.Controls.Add(Me.TbEtiqueta)
        Me.GbGeneral.Controls.Add(Me.TbCantidadNiveles)
        Me.GbGeneral.Controls.Add(Me.Label6)
        Me.GbGeneral.Controls.Add(Me.TbCantidadRack)
        Me.GbGeneral.Controls.Add(Me.Label4)
        Me.GbGeneral.Controls.Add(Me.Label3)
        Me.GbGeneral.Controls.Add(Me.Label2)
        Me.GbGeneral.Controls.Add(Me.Label1)
        Me.GbGeneral.Controls.Add(Me.CbNivel)
        Me.GbGeneral.Controls.Add(Me.BtAceptar)
        Me.GbGeneral.Controls.Add(Me.TbFilas)
        Me.GbGeneral.Controls.Add(Me.TbColumnas)
        Me.GbGeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbGeneral.Location = New System.Drawing.Point(0, 24)
        Me.GbGeneral.Name = "GbGeneral"
        Me.GbGeneral.Size = New System.Drawing.Size(1317, 215)
        Me.GbGeneral.TabIndex = 1
        Me.GbGeneral.TabStop = False
        '
        'BtInsertar
        '
        Me.BtInsertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtInsertar.Location = New System.Drawing.Point(893, 104)
        Me.BtInsertar.Name = "BtInsertar"
        Me.BtInsertar.Size = New System.Drawing.Size(197, 73)
        Me.BtInsertar.TabIndex = 6
        Me.BtInsertar.Text = "Insertar"
        Me.BtInsertar.UseVisualStyleBackColor = True
        '
        'TbEtiqueta
        '
        Me.TbEtiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbEtiqueta.Location = New System.Drawing.Point(575, 97)
        Me.TbEtiqueta.Name = "TbEtiqueta"
        Me.TbEtiqueta.Size = New System.Drawing.Size(312, 80)
        Me.TbEtiqueta.TabIndex = 5
        '
        'TbCantidadNiveles
        '
        Me.TbCantidadNiveles.Location = New System.Drawing.Point(112, 75)
        Me.TbCantidadNiveles.Name = "TbCantidadNiveles"
        Me.TbCantidadNiveles.Size = New System.Drawing.Size(100, 20)
        Me.TbCantidadNiveles.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Cantidad de Niveles"
        '
        'TbCantidadRack
        '
        Me.TbCantidadRack.Location = New System.Drawing.Point(112, 49)
        Me.TbCantidadRack.Name = "TbCantidadRack"
        Me.TbCantidadRack.Size = New System.Drawing.Size(100, 20)
        Me.TbCantidadRack.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Cantidad Racks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Filas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Columnas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nivel"
        '
        'CbNivel
        '
        Me.CbNivel.FormattingEnabled = True
        Me.CbNivel.Location = New System.Drawing.Point(112, 154)
        Me.CbNivel.Name = "CbNivel"
        Me.CbNivel.Size = New System.Drawing.Size(100, 21)
        Me.CbNivel.TabIndex = 4
        '
        'BtAceptar
        '
        Me.BtAceptar.Location = New System.Drawing.Point(245, 154)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtAceptar.TabIndex = 4
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'TbFilas
        '
        Me.TbFilas.Location = New System.Drawing.Point(112, 127)
        Me.TbFilas.Name = "TbFilas"
        Me.TbFilas.Size = New System.Drawing.Size(100, 20)
        Me.TbFilas.TabIndex = 3
        '
        'TbColumnas
        '
        Me.TbColumnas.Location = New System.Drawing.Point(112, 101)
        Me.TbColumnas.Name = "TbColumnas"
        Me.TbColumnas.Size = New System.Drawing.Size(100, 20)
        Me.TbColumnas.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 587)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1317, 209)
        Me.Panel2.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DgvMatriz)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 239)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1317, 348)
        Me.Panel1.TabIndex = 3
        '
        'DgvMatriz
        '
        Me.DgvMatriz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvMatriz.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvMatriz.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvMatriz.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvMatriz.Dock = System.Windows.Forms.DockStyle.Left
        Me.DgvMatriz.Location = New System.Drawing.Point(0, 0)
        Me.DgvMatriz.Name = "DgvMatriz"
        Me.DgvMatriz.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvMatriz.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvMatriz.Size = New System.Drawing.Size(1090, 348)
        Me.DgvMatriz.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1317, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'ExistenciaBodegaPacas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 796)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GbGeneral)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ExistenciaBodegaPacas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Existencia en Bodega"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbGeneral.ResumeLayout(False)
        Me.GbGeneral.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DgvMatriz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbGeneral As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtAceptar As Button
    Friend WithEvents TbFilas As TextBox
    Friend WithEvents TbColumnas As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DgvMatriz As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CbNivel As ComboBox
    Friend WithEvents TbCantidadRack As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbCantidadNiveles As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbEtiqueta As TextBox
    Friend WithEvents BtInsertar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
End Class
