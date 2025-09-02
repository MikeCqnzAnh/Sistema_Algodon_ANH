<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaCompradores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaCompradores))
        Me.BtSalir = New System.Windows.Forms.Button()
        Me.BtAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.DgvConsultaCompradores = New System.Windows.Forms.DataGridView()
        CType(Me.DgvConsultaCompradores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtSalir
        '
        Me.BtSalir.Location = New System.Drawing.Point(490, 14)
        Me.BtSalir.Name = "BtSalir"
        Me.BtSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtSalir.TabIndex = 20
        Me.BtSalir.Text = "Salir"
        Me.BtSalir.UseVisualStyleBackColor = True
        '
        'BtAceptar
        '
        Me.BtAceptar.Location = New System.Drawing.Point(409, 14)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtAceptar.TabIndex = 19
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Buscar"
        '
        'TbNombre
        '
        Me.TbNombre.Location = New System.Drawing.Point(65, 16)
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(338, 20)
        Me.TbNombre.TabIndex = 17
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
        Me.DgvConsultaCompradores.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvConsultaCompradores.Location = New System.Drawing.Point(10, 42)
        Me.DgvConsultaCompradores.MultiSelect = False
        Me.DgvConsultaCompradores.Name = "DgvConsultaCompradores"
        Me.DgvConsultaCompradores.ReadOnly = True
        Me.DgvConsultaCompradores.RowHeadersVisible = False
        Me.DgvConsultaCompradores.RowHeadersWidth = 40
        Me.DgvConsultaCompradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvConsultaCompradores.Size = New System.Drawing.Size(660, 301)
        Me.DgvConsultaCompradores.TabIndex = 16
        '
        'ConsultaCompradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 355)
        Me.Controls.Add(Me.BtSalir)
        Me.Controls.Add(Me.BtAceptar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbNombre)
        Me.Controls.Add(Me.DgvConsultaCompradores)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConsultaCompradores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Compradores"
        CType(Me.DgvConsultaCompradores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtSalir As Button
    Friend WithEvents BtAceptar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TbNombre As TextBox
    Friend WithEvents DgvConsultaCompradores As DataGridView
End Class
