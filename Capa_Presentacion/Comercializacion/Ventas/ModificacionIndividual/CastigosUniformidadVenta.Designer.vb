<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CastigosUniformidadVenta
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
        Me.DgvCastigosUniformidad = New System.Windows.Forms.DataGridView()
        CType(Me.DgvCastigosUniformidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvCastigosUniformidad
        '
        Me.DgvCastigosUniformidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCastigosUniformidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCastigosUniformidad.Location = New System.Drawing.Point(0, 0)
        Me.DgvCastigosUniformidad.Name = "DgvCastigosUniformidad"
        Me.DgvCastigosUniformidad.Size = New System.Drawing.Size(402, 484)
        Me.DgvCastigosUniformidad.TabIndex = 0
        '
        'CastigosUniformidadVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 484)
        Me.Controls.Add(Me.DgvCastigosUniformidad)
        Me.Name = "CastigosUniformidadVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Castigos por Uniformidad"
        CType(Me.DgvCastigosUniformidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvCastigosUniformidad As DataGridView
End Class
