<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CastigosResistenciaFibra
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
        Me.DgvCastigoResistenciaFibra = New System.Windows.Forms.DataGridView()
        Me.BtAceptar = New System.Windows.Forms.Button()
        Me.BtSalir = New System.Windows.Forms.Button()
        CType(Me.DgvCastigoResistenciaFibra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvCastigoResistenciaFibra
        '
        Me.DgvCastigoResistenciaFibra.AllowUserToAddRows = False
        Me.DgvCastigoResistenciaFibra.AllowUserToDeleteRows = False
        Me.DgvCastigoResistenciaFibra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCastigoResistenciaFibra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvCastigoResistenciaFibra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvCastigoResistenciaFibra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvCastigoResistenciaFibra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCastigoResistenciaFibra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvCastigoResistenciaFibra.Location = New System.Drawing.Point(12, 12)
        Me.DgvCastigoResistenciaFibra.MultiSelect = False
        Me.DgvCastigoResistenciaFibra.Name = "DgvCastigoResistenciaFibra"
        Me.DgvCastigoResistenciaFibra.RowHeadersVisible = False
        Me.DgvCastigoResistenciaFibra.RowHeadersWidth = 40
        Me.DgvCastigoResistenciaFibra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCastigoResistenciaFibra.Size = New System.Drawing.Size(260, 308)
        Me.DgvCastigoResistenciaFibra.TabIndex = 13
        '
        'BtAceptar
        '
        Me.BtAceptar.Location = New System.Drawing.Point(12, 326)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtAceptar.TabIndex = 14
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'BtSalir
        '
        Me.BtSalir.Location = New System.Drawing.Point(197, 326)
        Me.BtSalir.Name = "BtSalir"
        Me.BtSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtSalir.TabIndex = 18
        Me.BtSalir.Text = "Salir"
        Me.BtSalir.UseVisualStyleBackColor = True
        '
        'CastigosResistenciaFibra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 361)
        Me.Controls.Add(Me.BtSalir)
        Me.Controls.Add(Me.BtAceptar)
        Me.Controls.Add(Me.DgvCastigoResistenciaFibra)
        Me.Name = "CastigosResistenciaFibra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Castigos por resistencia de fibra"
        CType(Me.DgvCastigoResistenciaFibra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvCastigoResistenciaFibra As DataGridView
    Friend WithEvents BtAceptar As Button
    Friend WithEvents BtSalir As Button
End Class
