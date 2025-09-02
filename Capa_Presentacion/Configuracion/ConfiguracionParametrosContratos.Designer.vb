<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfiguracionParametrosContratos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfiguracionParametrosContratos))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tcparametros = New System.Windows.Forms.TabControl()
        Me.tpcompra = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.nupesomin = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nuprommax = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nuprommin = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbtemporadapv = New System.Windows.Forms.TextBox()
        Me.tbtemporada2compra = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbtemporada1compra = New System.Windows.Forms.TextBox()
        Me.cbmes3compra = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbidparametrocompra = New System.Windows.Forms.TextBox()
        Me.cbmes2compra = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbmes1compra = New System.Windows.Forms.ComboBox()
        Me.cbdia1compra = New System.Windows.Forms.ComboBox()
        Me.tpventa = New System.Windows.Forms.TabPage()
        Me.MenuStrip1.SuspendLayout()
        Me.tcparametros.SuspendLayout()
        Me.tpcompra.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nupesomin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuprommax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuprommin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarToolStripMenuItem, Me.GuardarActualizarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1223, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'GuardarActualizarToolStripMenuItem
        '
        Me.GuardarActualizarToolStripMenuItem.Name = "GuardarActualizarToolStripMenuItem"
        Me.GuardarActualizarToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.GuardarActualizarToolStripMenuItem.Text = "Guardar/Actualizar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'tcparametros
        '
        Me.tcparametros.Controls.Add(Me.tpcompra)
        Me.tcparametros.Controls.Add(Me.tpventa)
        Me.tcparametros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcparametros.Location = New System.Drawing.Point(0, 24)
        Me.tcparametros.Name = "tcparametros"
        Me.tcparametros.SelectedIndex = 0
        Me.tcparametros.Size = New System.Drawing.Size(1223, 680)
        Me.tcparametros.TabIndex = 1
        '
        'tpcompra
        '
        Me.tpcompra.Controls.Add(Me.GroupBox2)
        Me.tpcompra.Controls.Add(Me.GroupBox1)
        Me.tpcompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpcompra.Location = New System.Drawing.Point(4, 22)
        Me.tpcompra.Name = "tpcompra"
        Me.tpcompra.Padding = New System.Windows.Forms.Padding(3)
        Me.tpcompra.Size = New System.Drawing.Size(1215, 654)
        Me.tpcompra.TabIndex = 0
        Me.tpcompra.Text = "Parametros de Compra"
        Me.tpcompra.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.nupesomin)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.nuprommax)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.nuprommin)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1209, 453)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estipulaciones"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(598, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Cada una."
        '
        'nupesomin
        '
        Me.nupesomin.Location = New System.Drawing.Point(508, 79)
        Me.nupesomin.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nupesomin.Name = "nupesomin"
        Me.nupesomin.Size = New System.Drawing.Size(57, 20)
        Me.nupesomin.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(475, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Por paca y de ninguna manera quedara obligado el comprador a recibir pacas que pe" &
    "sen menos de"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(571, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Kgs."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(544, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Kgs."
        '
        'nuprommax
        '
        Me.nuprommax.Location = New System.Drawing.Point(481, 48)
        Me.nuprommax.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.nuprommax.Name = "nuprommax"
        Me.nuprommax.Size = New System.Drawing.Size(57, 20)
        Me.nuprommax.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(462, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "a"
        '
        'nuprommin
        '
        Me.nuprommin.Location = New System.Drawing.Point(399, 48)
        Me.nuprommin.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nuprommin.Name = "nuprommin"
        Me.nuprommin.Size = New System.Drawing.Size(57, 20)
        Me.nuprommin.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(384, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "A)   Las pacas de algodón objeto del presente contrato, tendrán un promedio de"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbtemporadapv)
        Me.GroupBox1.Controls.Add(Me.tbtemporada2compra)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.tbtemporada1compra)
        Me.GroupBox1.Controls.Add(Me.cbmes3compra)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbidparametrocompra)
        Me.GroupBox1.Controls.Add(Me.cbmes2compra)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbmes1compra)
        Me.GroupBox1.Controls.Add(Me.cbdia1compra)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1209, 195)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clausulas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(555, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "de"
        '
        'tbtemporadapv
        '
        Me.tbtemporadapv.Location = New System.Drawing.Point(96, 59)
        Me.tbtemporadapv.MaxLength = 4
        Me.tbtemporadapv.Name = "tbtemporadapv"
        Me.tbtemporadapv.Size = New System.Drawing.Size(55, 20)
        Me.tbtemporadapv.TabIndex = 0
        '
        'tbtemporada2compra
        '
        Me.tbtemporada2compra.Location = New System.Drawing.Point(580, 138)
        Me.tbtemporada2compra.MaxLength = 4
        Me.tbtemporada2compra.Name = "tbtemporada2compra"
        Me.tbtemporada2compra.Size = New System.Drawing.Size(41, 20)
        Me.tbtemporada2compra.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Temporada PV:"
        '
        'tbtemporada1compra
        '
        Me.tbtemporada1compra.Location = New System.Drawing.Point(606, 104)
        Me.tbtemporada1compra.MaxLength = 4
        Me.tbtemporada1compra.Name = "tbtemporada1compra"
        Me.tbtemporada1compra.Size = New System.Drawing.Size(41, 20)
        Me.tbtemporada1compra.TabIndex = 4
        '
        'cbmes3compra
        '
        Me.cbmes3compra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmes3compra.FormattingEnabled = True
        Me.cbmes3compra.Location = New System.Drawing.Point(428, 138)
        Me.cbmes3compra.Name = "cbmes3compra"
        Me.cbmes3compra.Size = New System.Drawing.Size(121, 21)
        Me.cbmes3compra.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 141)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(413, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "En caso de no cerrar se aceptan las condiciones de comercialización del mercado d" &
    "e "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ID"
        '
        'tbidparametrocompra
        '
        Me.tbidparametrocompra.Location = New System.Drawing.Point(30, 17)
        Me.tbidparametrocompra.Name = "tbidparametrocompra"
        Me.tbidparametrocompra.ReadOnly = True
        Me.tbidparametrocompra.Size = New System.Drawing.Size(100, 20)
        Me.tbidparametrocompra.TabIndex = 0
        '
        'cbmes2compra
        '
        Me.cbmes2compra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmes2compra.FormattingEnabled = True
        Me.cbmes2compra.Location = New System.Drawing.Point(479, 103)
        Me.cbmes2compra.Name = "cbmes2compra"
        Me.cbmes2compra.Size = New System.Drawing.Size(121, 21)
        Me.cbmes2compra.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "El precio deberá fijarse antes del"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(389, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "con mercado de"
        '
        'cbmes1compra
        '
        Me.cbmes1compra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbmes1compra.FormattingEnabled = True
        Me.cbmes1compra.Location = New System.Drawing.Point(248, 103)
        Me.cbmes1compra.Name = "cbmes1compra"
        Me.cbmes1compra.Size = New System.Drawing.Size(135, 21)
        Me.cbmes1compra.TabIndex = 2
        '
        'cbdia1compra
        '
        Me.cbdia1compra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbdia1compra.FormattingEnabled = True
        Me.cbdia1compra.Location = New System.Drawing.Point(175, 103)
        Me.cbdia1compra.Name = "cbdia1compra"
        Me.cbdia1compra.Size = New System.Drawing.Size(67, 21)
        Me.cbdia1compra.TabIndex = 1
        '
        'tpventa
        '
        Me.tpventa.Location = New System.Drawing.Point(4, 22)
        Me.tpventa.Name = "tpventa"
        Me.tpventa.Padding = New System.Windows.Forms.Padding(3)
        Me.tpventa.Size = New System.Drawing.Size(1215, 654)
        Me.tpventa.TabIndex = 1
        Me.tpventa.Text = "Parametros de Venta"
        Me.tpventa.UseVisualStyleBackColor = True
        '
        'ConfiguracionParametrosContratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 704)
        Me.Controls.Add(Me.tcparametros)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ConfiguracionParametrosContratos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "0,0"
        Me.Text = "Configuracion de Parametros para Contratos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tcparametros.ResumeLayout(False)
        Me.tpcompra.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nupesomin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuprommax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuprommin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tcparametros As TabControl
    Friend WithEvents tpcompra As TabPage
    Friend WithEvents tpventa As TabPage
    Friend WithEvents tbidparametrocompra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbmes1compra As ComboBox
    Friend WithEvents cbdia1compra As ComboBox
    Friend WithEvents cbmes2compra As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents nuprommin As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents nuprommax As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents nupesomin As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tbtemporadapv As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents tbtemporada2compra As TextBox
    Friend WithEvents tbtemporada1compra As TextBox
    Friend WithEvents cbmes3compra As ComboBox
    Friend WithEvents Label3 As Label
End Class
