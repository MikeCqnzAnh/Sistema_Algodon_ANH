<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaProductores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaProductores))
        Me.DgvConsultaProductores = New System.Windows.Forms.DataGridView()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtAceptar = New System.Windows.Forms.Button()
        Me.BtSalir = New System.Windows.Forms.Button()
        CType(Me.DgvConsultaProductores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvConsultaProductores
        '
        Me.DgvConsultaProductores.AllowUserToAddRows = False
        Me.DgvConsultaProductores.AllowUserToDeleteRows = False
        Me.DgvConsultaProductores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvConsultaProductores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvConsultaProductores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvConsultaProductores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvConsultaProductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConsultaProductores.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvConsultaProductores.Location = New System.Drawing.Point(10, 42)
        Me.DgvConsultaProductores.MultiSelect = False
        Me.DgvConsultaProductores.Name = "DgvConsultaProductores"
        Me.DgvConsultaProductores.ReadOnly = True
        Me.DgvConsultaProductores.RowHeadersVisible = False
        Me.DgvConsultaProductores.RowHeadersWidth = 40
        Me.DgvConsultaProductores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvConsultaProductores.Size = New System.Drawing.Size(660, 301)
        Me.DgvConsultaProductores.TabIndex = 11
        '
        'TbNombre
        '
        Me.TbNombre.Location = New System.Drawing.Point(65, 16)
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(200, 20)
        Me.TbNombre.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Buscar"
        '
        'BtAceptar
        '
        Me.BtAceptar.Location = New System.Drawing.Point(271, 13)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtAceptar.TabIndex = 14
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'BtSalir
        '
        Me.BtSalir.Location = New System.Drawing.Point(352, 14)
        Me.BtSalir.Name = "BtSalir"
        Me.BtSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtSalir.TabIndex = 15
        Me.BtSalir.Text = "Salir"
        Me.BtSalir.UseVisualStyleBackColor = True
        '
        'ConsultaProductores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 355)
        Me.Controls.Add(Me.BtSalir)
        Me.Controls.Add(Me.BtAceptar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbNombre)
        Me.Controls.Add(Me.DgvConsultaProductores)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConsultaProductores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Productores"
        CType(Me.DgvConsultaProductores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvConsultaProductores As DataGridView
    Friend WithEvents TbNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtAceptar As Button
    Friend WithEvents BtSalir As Button
End Class
