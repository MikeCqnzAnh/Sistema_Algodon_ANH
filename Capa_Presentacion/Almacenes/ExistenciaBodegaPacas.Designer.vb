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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtInsertar = New System.Windows.Forms.Button()
        Me.TbEtiqueta = New System.Windows.Forms.TextBox()
        Me.CbNoLote = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtIdAlmacen = New System.Windows.Forms.Button()
        Me.TbIdAlmacen = New System.Windows.Forms.TextBox()
        Me.TbNombreAlmacen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RbEntrada = New System.Windows.Forms.RadioButton()
        Me.RbSalidas = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GbGeneral.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvMatriz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbGeneral
        '
        Me.GbGeneral.Controls.Add(Me.Panel3)
        Me.GbGeneral.Controls.Add(Me.CbNoLote)
        Me.GbGeneral.Controls.Add(Me.Label7)
        Me.GbGeneral.Controls.Add(Me.BtIdAlmacen)
        Me.GbGeneral.Controls.Add(Me.TbIdAlmacen)
        Me.GbGeneral.Controls.Add(Me.TbNombreAlmacen)
        Me.GbGeneral.Controls.Add(Me.Label5)
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
        Me.GbGeneral.Size = New System.Drawing.Size(1317, 264)
        Me.GbGeneral.TabIndex = 1
        Me.GbGeneral.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.RbSalidas)
        Me.Panel3.Controls.Add(Me.RbEntrada)
        Me.Panel3.Controls.Add(Me.BtInsertar)
        Me.Panel3.Controls.Add(Me.TbEtiqueta)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(674, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(640, 245)
        Me.Panel3.TabIndex = 20
        '
        'BtInsertar
        '
        Me.BtInsertar.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtInsertar.Location = New System.Drawing.Point(434, 155)
        Me.BtInsertar.Name = "BtInsertar"
        Me.BtInsertar.Size = New System.Drawing.Size(197, 80)
        Me.BtInsertar.TabIndex = 6
        Me.BtInsertar.Text = "Insertar"
        Me.BtInsertar.UseVisualStyleBackColor = True
        '
        'TbEtiqueta
        '
        Me.TbEtiqueta.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbEtiqueta.Location = New System.Drawing.Point(3, 155)
        Me.TbEtiqueta.Name = "TbEtiqueta"
        Me.TbEtiqueta.Size = New System.Drawing.Size(386, 80)
        Me.TbEtiqueta.TabIndex = 5
        '
        'CbNoLote
        '
        Me.CbNoLote.Enabled = False
        Me.CbNoLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbNoLote.FormattingEnabled = True
        Me.CbNoLote.IntegralHeight = False
        Me.CbNoLote.ItemHeight = 55
        Me.CbNoLote.Location = New System.Drawing.Point(218, 117)
        Me.CbNoLote.MaxDropDownItems = 5
        Me.CbNoLote.Name = "CbNoLote"
        Me.CbNoLote.Size = New System.Drawing.Size(133, 63)
        Me.CbNoLote.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(206, 55)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Lote No."
        '
        'BtIdAlmacen
        '
        Me.BtIdAlmacen.Location = New System.Drawing.Point(112, 21)
        Me.BtIdAlmacen.Name = "BtIdAlmacen"
        Me.BtIdAlmacen.Size = New System.Drawing.Size(42, 23)
        Me.BtIdAlmacen.TabIndex = 17
        Me.BtIdAlmacen.Text = "..."
        Me.BtIdAlmacen.UseVisualStyleBackColor = True
        '
        'TbIdAlmacen
        '
        Me.TbIdAlmacen.Location = New System.Drawing.Point(160, 23)
        Me.TbIdAlmacen.Name = "TbIdAlmacen"
        Me.TbIdAlmacen.ReadOnly = True
        Me.TbIdAlmacen.Size = New System.Drawing.Size(87, 20)
        Me.TbIdAlmacen.TabIndex = 16
        '
        'TbNombreAlmacen
        '
        Me.TbNombreAlmacen.Location = New System.Drawing.Point(253, 23)
        Me.TbNombreAlmacen.Name = "TbNombreAlmacen"
        Me.TbNombreAlmacen.ReadOnly = True
        Me.TbNombreAlmacen.Size = New System.Drawing.Size(216, 20)
        Me.TbNombreAlmacen.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "ID Almacen"
        '
        'TbCantidadNiveles
        '
        Me.TbCantidadNiveles.Location = New System.Drawing.Point(112, 75)
        Me.TbCantidadNiveles.Name = "TbCantidadNiveles"
        Me.TbCantidadNiveles.ReadOnly = True
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
        Me.TbCantidadRack.ReadOnly = True
        Me.TbCantidadRack.Size = New System.Drawing.Size(100, 20)
        Me.TbCantidadRack.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Cantidad Racks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(250, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Filas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(250, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Columnas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 55)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nivel"
        '
        'CbNivel
        '
        Me.CbNivel.Enabled = False
        Me.CbNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbNivel.FormattingEnabled = True
        Me.CbNivel.IntegralHeight = False
        Me.CbNivel.Location = New System.Drawing.Point(218, 186)
        Me.CbNivel.Name = "CbNivel"
        Me.CbNivel.Size = New System.Drawing.Size(133, 63)
        Me.CbNivel.TabIndex = 4
        '
        'BtAceptar
        '
        Me.BtAceptar.Enabled = False
        Me.BtAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtAceptar.Location = New System.Drawing.Point(369, 186)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(299, 65)
        Me.BtAceptar.TabIndex = 4
        Me.BtAceptar.Text = "Seleccionar"
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'TbFilas
        '
        Me.TbFilas.Location = New System.Drawing.Point(369, 75)
        Me.TbFilas.Name = "TbFilas"
        Me.TbFilas.ReadOnly = True
        Me.TbFilas.Size = New System.Drawing.Size(100, 20)
        Me.TbFilas.TabIndex = 3
        '
        'TbColumnas
        '
        Me.TbColumnas.Location = New System.Drawing.Point(369, 49)
        Me.TbColumnas.Name = "TbColumnas"
        Me.TbColumnas.ReadOnly = True
        Me.TbColumnas.Size = New System.Drawing.Size(100, 20)
        Me.TbColumnas.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 759)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1317, 37)
        Me.Panel2.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DgvMatriz)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 288)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1317, 471)
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
        Me.DgvMatriz.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.DgvMatriz.Size = New System.Drawing.Size(1317, 471)
        Me.DgvMatriz.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.SalirToolStripMenuItem})
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
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'RbEntrada
        '
        Me.RbEntrada.AutoSize = True
        Me.RbEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbEntrada.Location = New System.Drawing.Point(3, 36)
        Me.RbEntrada.Name = "RbEntrada"
        Me.RbEntrada.Size = New System.Drawing.Size(141, 35)
        Me.RbEntrada.TabIndex = 7
        Me.RbEntrada.TabStop = True
        Me.RbEntrada.Text = "Entradas"
        Me.RbEntrada.UseVisualStyleBackColor = True
        '
        'RbSalidas
        '
        Me.RbSalidas.AutoSize = True
        Me.RbSalidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSalidas.Location = New System.Drawing.Point(268, 36)
        Me.RbSalidas.Name = "RbSalidas"
        Me.RbSalidas.Size = New System.Drawing.Size(121, 35)
        Me.RbSalidas.TabIndex = 8
        Me.RbSalidas.TabStop = True
        Me.RbSalidas.Text = "Salidas"
        Me.RbSalidas.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Green
        Me.PictureBox1.Location = New System.Drawing.Point(150, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 31)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox2.Location = New System.Drawing.Point(395, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 31)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
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
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DgvMatriz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BtIdAlmacen As Button
    Friend WithEvents TbIdAlmacen As TextBox
    Friend WithEvents TbNombreAlmacen As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CbNoLote As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RbSalidas As RadioButton
    Friend WithEvents RbEntrada As RadioButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
