<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FConsultaProductorContratoCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FConsultaProductorContratoCompra))
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvconsulta = New System.Windows.Forms.DataGridView()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbnombre = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.ptop = New System.Windows.Forms.Panel()
        Me.label5 = New System.Windows.Forms.Label()
        Me.btcerrar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pictureBox9 = New System.Windows.Forms.PictureBox()
        Me.groupBox2.SuspendLayout()
        CType(Me.dgvconsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.ptop.SuspendLayout()
        CType(Me.btcerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.dgvconsulta)
        Me.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox2.Location = New System.Drawing.Point(0, 132)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(1234, 459)
        Me.groupBox2.TabIndex = 8
        Me.groupBox2.TabStop = False
        '
        'dgvconsulta
        '
        Me.dgvconsulta.AllowUserToAddRows = False
        Me.dgvconsulta.AllowUserToDeleteRows = False
        Me.dgvconsulta.AllowUserToOrderColumns = True
        Me.dgvconsulta.AllowUserToResizeRows = False
        Me.dgvconsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvconsulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvconsulta.BackgroundColor = System.Drawing.Color.White
        Me.dgvconsulta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvconsulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvconsulta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvconsulta.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvconsulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvconsulta.Location = New System.Drawing.Point(3, 16)
        Me.dgvconsulta.MultiSelect = False
        Me.dgvconsulta.Name = "dgvconsulta"
        Me.dgvconsulta.ReadOnly = True
        Me.dgvconsulta.RowHeadersVisible = False
        Me.dgvconsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvconsulta.Size = New System.Drawing.Size(1228, 440)
        Me.dgvconsulta.TabIndex = 16
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.tbnombre)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.groupBox1.Location = New System.Drawing.Point(0, 35)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(1234, 97)
        Me.groupBox1.TabIndex = 6
        Me.groupBox1.TabStop = False
        '
        'tbnombre
        '
        Me.tbnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbnombre.Location = New System.Drawing.Point(70, 36)
        Me.tbnombre.Name = "tbnombre"
        Me.tbnombre.Size = New System.Drawing.Size(379, 20)
        Me.tbnombre.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 39)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(58, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Busqueda:"
        '
        'ptop
        '
        Me.ptop.BackColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.ptop.Controls.Add(Me.btcerrar)
        Me.ptop.Controls.Add(Me.label5)
        Me.ptop.Controls.Add(Me.pictureBox9)
        Me.ptop.Dock = System.Windows.Forms.DockStyle.Top
        Me.ptop.Location = New System.Drawing.Point(0, 0)
        Me.ptop.Name = "ptop"
        Me.ptop.Size = New System.Drawing.Size(1234, 35)
        Me.ptop.TabIndex = 7
        Me.ptop.Visible = False
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(39, 4)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(89, 18)
        Me.label5.TabIndex = 0
        Me.label5.Text = "CONSULTA"
        '
        'btcerrar
        '
        Me.btcerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btcerrar.BackColor = System.Drawing.Color.Transparent
        Me.btcerrar.Image = CType(resources.GetObject("btcerrar.Image"), System.Drawing.Image)
        Me.btcerrar.ImageActive = Nothing
        Me.btcerrar.Location = New System.Drawing.Point(1201, 2)
        Me.btcerrar.MaximumSize = New System.Drawing.Size(30, 30)
        Me.btcerrar.MinimumSize = New System.Drawing.Size(30, 30)
        Me.btcerrar.Name = "btcerrar"
        Me.btcerrar.Size = New System.Drawing.Size(30, 30)
        Me.btcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btcerrar.TabIndex = 22
        Me.btcerrar.TabStop = False
        Me.btcerrar.Zoom = 15
        '
        'pictureBox9
        '
        Me.pictureBox9.Location = New System.Drawing.Point(3, 0)
        Me.pictureBox9.Name = "pictureBox9"
        Me.pictureBox9.Size = New System.Drawing.Size(30, 30)
        Me.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox9.TabIndex = 19
        Me.pictureBox9.TabStop = False
        '
        'FConsultaProductorContratoCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 591)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.ptop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1250, 630)
        Me.Name = "FConsultaProductorContratoCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CONSULTA PRODUCTOR"
        Me.groupBox2.ResumeLayout(False)
        CType(Me.dgvconsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ptop.ResumeLayout(False)
        Me.ptop.PerformLayout()
        CType(Me.btcerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox2 As GroupBox
    Private WithEvents dgvconsulta As DataGridView
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents tbnombre As TextBox
    Private WithEvents label1 As Label
    Private WithEvents ptop As Panel
    Private WithEvents btcerrar As Bunifu.Framework.UI.BunifuImageButton
    Private WithEvents label5 As Label
    Private WithEvents pictureBox9 As PictureBox
End Class
