<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CastigosMicro
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
        Me.BtAceptar = New System.Windows.Forms.Button()
        Me.DgvCastigoMicros = New System.Windows.Forms.DataGridView()
        Me.BtSalir = New System.Windows.Forms.Button()
        CType(Me.DgvCastigoMicros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtAceptar
        '
        Me.BtAceptar.Location = New System.Drawing.Point(12, 326)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtAceptar.TabIndex = 18
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'DgvCastigoMicros
        '
        Me.DgvCastigoMicros.AllowUserToAddRows = False
        Me.DgvCastigoMicros.AllowUserToDeleteRows = False
        Me.DgvCastigoMicros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCastigoMicros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvCastigoMicros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvCastigoMicros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvCastigoMicros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCastigoMicros.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvCastigoMicros.Location = New System.Drawing.Point(12, 12)
        Me.DgvCastigoMicros.MultiSelect = False
        Me.DgvCastigoMicros.Name = "DgvCastigoMicros"
        Me.DgvCastigoMicros.RowHeadersVisible = False
        Me.DgvCastigoMicros.RowHeadersWidth = 40
        Me.DgvCastigoMicros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCastigoMicros.Size = New System.Drawing.Size(260, 308)
        Me.DgvCastigoMicros.TabIndex = 17
        '
        'BtSalir
        '
        Me.BtSalir.Location = New System.Drawing.Point(197, 326)
        Me.BtSalir.Name = "BtSalir"
        Me.BtSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtSalir.TabIndex = 19
        Me.BtSalir.Text = "Salir"
        Me.BtSalir.UseVisualStyleBackColor = True
        '
        'CastigosMicro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 408)
        Me.Controls.Add(Me.BtSalir)
        Me.Controls.Add(Me.BtAceptar)
        Me.Controls.Add(Me.DgvCastigoMicros)
        Me.Name = "CastigosMicro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CastigosMicro"
        CType(Me.DgvCastigoMicros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtAceptar As Button
    Friend WithEvents DgvCastigoMicros As DataGridView
    Friend WithEvents BtSalir As Button
End Class
