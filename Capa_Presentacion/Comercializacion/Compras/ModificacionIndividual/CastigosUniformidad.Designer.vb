<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CastigosUniformidad
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
        Me.DgvCastigoUniformidad = New System.Windows.Forms.DataGridView()
        CType(Me.DgvCastigoUniformidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvCastigoUniformidad
        '
        Me.DgvCastigoUniformidad.AllowUserToAddRows = False
        Me.DgvCastigoUniformidad.AllowUserToDeleteRows = False
        Me.DgvCastigoUniformidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCastigoUniformidad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvCastigoUniformidad.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvCastigoUniformidad.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvCastigoUniformidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCastigoUniformidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCastigoUniformidad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvCastigoUniformidad.Location = New System.Drawing.Point(0, 0)
        Me.DgvCastigoUniformidad.MultiSelect = False
        Me.DgvCastigoUniformidad.Name = "DgvCastigoUniformidad"
        Me.DgvCastigoUniformidad.RowHeadersVisible = False
        Me.DgvCastigoUniformidad.RowHeadersWidth = 40
        Me.DgvCastigoUniformidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCastigoUniformidad.Size = New System.Drawing.Size(397, 505)
        Me.DgvCastigoUniformidad.TabIndex = 14
        '
        'CastigosUniformidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 505)
        Me.Controls.Add(Me.DgvCastigoUniformidad)
        Me.Name = "CastigosUniformidad"
        Me.Text = "CastigosUniformidad"
        CType(Me.DgvCastigoUniformidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvCastigoUniformidad As DataGridView
End Class
