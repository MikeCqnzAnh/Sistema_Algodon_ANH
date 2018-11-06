<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CastigosLargoFibra
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
        Me.DgvCastigoLargoFibra = New System.Windows.Forms.DataGridView()
        Me.BtSalir = New System.Windows.Forms.Button()
        CType(Me.DgvCastigoLargoFibra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtAceptar
        '
        Me.BtAceptar.Location = New System.Drawing.Point(12, 326)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtAceptar.TabIndex = 16
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'DgvCastigoLargoFibra
        '
        Me.DgvCastigoLargoFibra.AllowUserToAddRows = False
        Me.DgvCastigoLargoFibra.AllowUserToDeleteRows = False
        Me.DgvCastigoLargoFibra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCastigoLargoFibra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvCastigoLargoFibra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvCastigoLargoFibra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvCastigoLargoFibra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCastigoLargoFibra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvCastigoLargoFibra.Location = New System.Drawing.Point(12, 12)
        Me.DgvCastigoLargoFibra.MultiSelect = False
        Me.DgvCastigoLargoFibra.Name = "DgvCastigoLargoFibra"
        Me.DgvCastigoLargoFibra.RowHeadersVisible = False
        Me.DgvCastigoLargoFibra.RowHeadersWidth = 40
        Me.DgvCastigoLargoFibra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCastigoLargoFibra.Size = New System.Drawing.Size(260, 308)
        Me.DgvCastigoLargoFibra.TabIndex = 15
        '
        'BtSalir
        '
        Me.BtSalir.Location = New System.Drawing.Point(197, 326)
        Me.BtSalir.Name = "BtSalir"
        Me.BtSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtSalir.TabIndex = 17
        Me.BtSalir.Text = "Salir"
        Me.BtSalir.UseVisualStyleBackColor = True
        '
        'CastigosLargoFibra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 361)
        Me.Controls.Add(Me.BtSalir)
        Me.Controls.Add(Me.BtAceptar)
        Me.Controls.Add(Me.DgvCastigoLargoFibra)
        Me.Name = "CastigosLargoFibra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CastigosLargoFibra"
        CType(Me.DgvCastigoLargoFibra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtAceptar As Button
    Friend WithEvents DgvCastigoLargoFibra As DataGridView
    Friend WithEvents BtSalir As Button
End Class
