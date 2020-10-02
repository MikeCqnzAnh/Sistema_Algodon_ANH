<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaCompradoresSalidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaCompradoresSalidas))
        Me.BtConsultar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.DgvConsultaCompradores = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DgvConsultaCompradores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtConsultar
        '
        Me.BtConsultar.Location = New System.Drawing.Point(595, 19)
        Me.BtConsultar.Name = "BtConsultar"
        Me.BtConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtConsultar.TabIndex = 24
        Me.BtConsultar.Text = "Consultar"
        Me.BtConsultar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Buscar"
        '
        'TbNombre
        '
        Me.TbNombre.Location = New System.Drawing.Point(77, 21)
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(416, 20)
        Me.TbNombre.TabIndex = 22
        '
        'DgvConsultaCompradores
        '
        Me.DgvConsultaCompradores.AllowUserToAddRows = False
        Me.DgvConsultaCompradores.AllowUserToDeleteRows = False
        Me.DgvConsultaCompradores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvConsultaCompradores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvConsultaCompradores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvConsultaCompradores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvConsultaCompradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConsultaCompradores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvConsultaCompradores.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvConsultaCompradores.Location = New System.Drawing.Point(0, 57)
        Me.DgvConsultaCompradores.MultiSelect = False
        Me.DgvConsultaCompradores.Name = "DgvConsultaCompradores"
        Me.DgvConsultaCompradores.ReadOnly = True
        Me.DgvConsultaCompradores.RowHeadersVisible = False
        Me.DgvConsultaCompradores.RowHeadersWidth = 40
        Me.DgvConsultaCompradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvConsultaCompradores.Size = New System.Drawing.Size(734, 335)
        Me.DgvConsultaCompradores.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TbNombre)
        Me.Panel1.Controls.Add(Me.BtConsultar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(734, 57)
        Me.Panel1.TabIndex = 26
        '
        'ConsultaCompradoresSalidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 392)
        Me.Controls.Add(Me.DgvConsultaCompradores)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConsultaCompradoresSalidas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consulta Compradores "
        CType(Me.DgvConsultaCompradores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtConsultar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TbNombre As TextBox
    Friend WithEvents DgvConsultaCompradores As DataGridView
    Friend WithEvents Panel1 As Panel
End Class
