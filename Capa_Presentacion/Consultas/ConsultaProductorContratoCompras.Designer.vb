<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaProductorContratoCompras
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
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.DgvProductores = New System.Windows.Forms.DataGridView()
        CType(Me.DgvProductores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbDatos
        '
        Me.GbDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatos.Location = New System.Drawing.Point(0, 0)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(687, 100)
        Me.GbDatos.TabIndex = 0
        Me.GbDatos.TabStop = False
        '
        'DgvProductores
        '
        Me.DgvProductores.AllowUserToAddRows = False
        Me.DgvProductores.AllowUserToDeleteRows = False
        Me.DgvProductores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvProductores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvProductores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvProductores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvProductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProductores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvProductores.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvProductores.Location = New System.Drawing.Point(0, 100)
        Me.DgvProductores.MultiSelect = False
        Me.DgvProductores.Name = "DgvProductores"
        Me.DgvProductores.RowHeadersVisible = False
        Me.DgvProductores.RowHeadersWidth = 40
        Me.DgvProductores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvProductores.Size = New System.Drawing.Size(687, 266)
        Me.DgvProductores.TabIndex = 16
        '
        'ConsultaProductorContratoCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 366)
        Me.Controls.Add(Me.DgvProductores)
        Me.Controls.Add(Me.GbDatos)
        Me.Name = "ConsultaProductorContratoCompras"
        Me.Text = "ConsultaProductorContratoCompras"
        CType(Me.DgvProductores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents DgvProductores As DataGridView
End Class
