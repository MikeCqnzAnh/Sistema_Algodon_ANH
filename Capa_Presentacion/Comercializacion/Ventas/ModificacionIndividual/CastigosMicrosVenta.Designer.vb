<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CastigosMicrosVenta
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
        Me.DgvCastigoMicros = New System.Windows.Forms.DataGridView()
        CType(Me.DgvCastigoMicros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.DgvCastigoMicros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCastigoMicros.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvCastigoMicros.Location = New System.Drawing.Point(0, 0)
        Me.DgvCastigoMicros.MultiSelect = False
        Me.DgvCastigoMicros.Name = "DgvCastigoMicros"
        Me.DgvCastigoMicros.ReadOnly = True
        Me.DgvCastigoMicros.RowHeadersVisible = False
        Me.DgvCastigoMicros.RowHeadersWidth = 40
        Me.DgvCastigoMicros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCastigoMicros.Size = New System.Drawing.Size(447, 522)
        Me.DgvCastigoMicros.TabIndex = 20
        '
        'CastigosMicrosVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 522)
        Me.Controls.Add(Me.DgvCastigoMicros)
        Me.Name = "CastigosMicrosVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CastigosMicrosVenta"
        CType(Me.DgvCastigoMicros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvCastigoMicros As DataGridView
End Class
