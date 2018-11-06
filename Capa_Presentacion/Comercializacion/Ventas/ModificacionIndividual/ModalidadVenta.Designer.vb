<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModalidadVenta
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
        Me.BtSalir = New System.Windows.Forms.Button()
        Me.CbModalidadVenta = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtAceptar = New System.Windows.Forms.Button()
        Me.DgvModalidadVenta = New System.Windows.Forms.DataGridView()
        CType(Me.DgvModalidadVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtSalir
        '
        Me.BtSalir.Location = New System.Drawing.Point(197, 384)
        Me.BtSalir.Name = "BtSalir"
        Me.BtSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtSalir.TabIndex = 28
        Me.BtSalir.Text = "Salir"
        Me.BtSalir.UseVisualStyleBackColor = True
        '
        'CbModalidadVenta
        '
        Me.CbModalidadVenta.FormattingEnabled = True
        Me.CbModalidadVenta.Location = New System.Drawing.Point(74, 6)
        Me.CbModalidadVenta.Name = "CbModalidadVenta"
        Me.CbModalidadVenta.Size = New System.Drawing.Size(198, 21)
        Me.CbModalidadVenta.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Modalidad"
        '
        'BtAceptar
        '
        Me.BtAceptar.Location = New System.Drawing.Point(12, 382)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtAceptar.TabIndex = 25
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'DgvModalidadVenta
        '
        Me.DgvModalidadVenta.AllowUserToAddRows = False
        Me.DgvModalidadVenta.AllowUserToDeleteRows = False
        Me.DgvModalidadVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvModalidadVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvModalidadVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvModalidadVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvModalidadVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvModalidadVenta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvModalidadVenta.Location = New System.Drawing.Point(12, 33)
        Me.DgvModalidadVenta.MultiSelect = False
        Me.DgvModalidadVenta.Name = "DgvModalidadVenta"
        Me.DgvModalidadVenta.RowHeadersVisible = False
        Me.DgvModalidadVenta.RowHeadersWidth = 40
        Me.DgvModalidadVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvModalidadVenta.Size = New System.Drawing.Size(260, 343)
        Me.DgvModalidadVenta.TabIndex = 24
        '
        'ModalidadVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 415)
        Me.Controls.Add(Me.BtSalir)
        Me.Controls.Add(Me.CbModalidadVenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtAceptar)
        Me.Controls.Add(Me.DgvModalidadVenta)
        Me.Name = "ModalidadVenta"
        Me.Text = "ModalidadVenta"
        CType(Me.DgvModalidadVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtSalir As Button
    Friend WithEvents CbModalidadVenta As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtAceptar As Button
    Friend WithEvents DgvModalidadVenta As DataGridView
End Class
