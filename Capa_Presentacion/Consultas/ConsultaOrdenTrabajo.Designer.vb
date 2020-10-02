<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaOrdenTrabajo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaOrdenTrabajo))
        Me.BtSalir = New System.Windows.Forms.Button()
        Me.BtAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbOrden = New System.Windows.Forms.TextBox()
        Me.DgvConsultaOrden = New System.Windows.Forms.DataGridView()
        CType(Me.DgvConsultaOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtSalir
        '
        Me.BtSalir.Location = New System.Drawing.Point(354, 4)
        Me.BtSalir.Name = "BtSalir"
        Me.BtSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtSalir.TabIndex = 20
        Me.BtSalir.Text = "Salir"
        Me.BtSalir.UseVisualStyleBackColor = True
        '
        'BtAceptar
        '
        Me.BtAceptar.Location = New System.Drawing.Point(273, 3)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtAceptar.TabIndex = 19
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Buscar"
        '
        'TbOrden
        '
        Me.TbOrden.Location = New System.Drawing.Point(67, 6)
        Me.TbOrden.Name = "TbOrden"
        Me.TbOrden.Size = New System.Drawing.Size(200, 20)
        Me.TbOrden.TabIndex = 17
        Me.TbOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DgvConsultaOrden
        '
        Me.DgvConsultaOrden.AllowUserToAddRows = False
        Me.DgvConsultaOrden.AllowUserToDeleteRows = False
        Me.DgvConsultaOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvConsultaOrden.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvConsultaOrden.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvConsultaOrden.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvConsultaOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConsultaOrden.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvConsultaOrden.Location = New System.Drawing.Point(12, 32)
        Me.DgvConsultaOrden.MultiSelect = False
        Me.DgvConsultaOrden.Name = "DgvConsultaOrden"
        Me.DgvConsultaOrden.ReadOnly = True
        Me.DgvConsultaOrden.RowHeadersVisible = False
        Me.DgvConsultaOrden.RowHeadersWidth = 40
        Me.DgvConsultaOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvConsultaOrden.Size = New System.Drawing.Size(660, 301)
        Me.DgvConsultaOrden.TabIndex = 16
        '
        'ConsultaOrdenTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 361)
        Me.Controls.Add(Me.BtSalir)
        Me.Controls.Add(Me.BtAceptar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbOrden)
        Me.Controls.Add(Me.DgvConsultaOrden)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConsultaOrdenTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ConsultaOrdenTrabajo"
        CType(Me.DgvConsultaOrden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtSalir As Button
    Friend WithEvents BtAceptar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TbOrden As TextBox
    Friend WithEvents DgvConsultaOrden As DataGridView
End Class
