<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FConsultaCompra
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FConsultaCompra))
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvconsulta = New System.Windows.Forms.DataGridView()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbbusqueda = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox2.SuspendLayout()
        CType(Me.dgvconsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.dgvconsulta)
        Me.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupBox2.Location = New System.Drawing.Point(0, 97)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(1234, 569)
        Me.groupBox2.TabIndex = 10
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
        Me.dgvconsulta.Size = New System.Drawing.Size(1228, 550)
        Me.dgvconsulta.TabIndex = 16
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.tbbusqueda)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.groupBox1.Location = New System.Drawing.Point(0, 0)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(1234, 97)
        Me.groupBox1.TabIndex = 9
        Me.groupBox1.TabStop = False
        '
        'tbbusqueda
        '
        Me.tbbusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbbusqueda.Location = New System.Drawing.Point(70, 36)
        Me.tbbusqueda.Name = "tbbusqueda"
        Me.tbbusqueda.Size = New System.Drawing.Size(379, 20)
        Me.tbbusqueda.TabIndex = 1
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
        'FConsultaCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 666)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1250, 630)
        Me.Name = "FConsultaCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CONSULTA COMPRA"
        Me.groupBox2.ResumeLayout(False)
        CType(Me.dgvconsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox2 As GroupBox
    Private WithEvents dgvconsulta As DataGridView
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents tbbusqueda As TextBox
    Private WithEvents label1 As Label
End Class
