<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModalidadCompra
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
        Me.DgvModalidadCompra = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbModalidadCompra = New System.Windows.Forms.ComboBox()
        Me.BtSalir = New System.Windows.Forms.Button()
        CType(Me.DgvModalidadCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtAceptar
        '
        Me.BtAceptar.Location = New System.Drawing.Point(12, 382)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtAceptar.TabIndex = 20
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'DgvModalidadCompra
        '
        Me.DgvModalidadCompra.AllowUserToAddRows = False
        Me.DgvModalidadCompra.AllowUserToDeleteRows = False
        Me.DgvModalidadCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvModalidadCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvModalidadCompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvModalidadCompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvModalidadCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvModalidadCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvModalidadCompra.Location = New System.Drawing.Point(12, 33)
        Me.DgvModalidadCompra.MultiSelect = False
        Me.DgvModalidadCompra.Name = "DgvModalidadCompra"
        Me.DgvModalidadCompra.RowHeadersVisible = False
        Me.DgvModalidadCompra.RowHeadersWidth = 40
        Me.DgvModalidadCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvModalidadCompra.Size = New System.Drawing.Size(260, 343)
        Me.DgvModalidadCompra.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Modalidad"
        '
        'CbModalidadCompra
        '
        Me.CbModalidadCompra.FormattingEnabled = True
        Me.CbModalidadCompra.Location = New System.Drawing.Point(74, 6)
        Me.CbModalidadCompra.Name = "CbModalidadCompra"
        Me.CbModalidadCompra.Size = New System.Drawing.Size(198, 21)
        Me.CbModalidadCompra.TabIndex = 22
        '
        'BtSalir
        '
        Me.BtSalir.Location = New System.Drawing.Point(197, 384)
        Me.BtSalir.Name = "BtSalir"
        Me.BtSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtSalir.TabIndex = 23
        Me.BtSalir.Text = "Salir"
        Me.BtSalir.UseVisualStyleBackColor = True
        '
        'ModalidadCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 419)
        Me.Controls.Add(Me.BtSalir)
        Me.Controls.Add(Me.CbModalidadCompra)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtAceptar)
        Me.Controls.Add(Me.DgvModalidadCompra)
        Me.Name = "ModalidadCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModalidadCompra"
        CType(Me.DgvModalidadCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtAceptar As Button
    Friend WithEvents DgvModalidadCompra As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents CbModalidadCompra As ComboBox
    Friend WithEvents BtSalir As Button
End Class
