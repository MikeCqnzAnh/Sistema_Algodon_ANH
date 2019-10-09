<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaVentas
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
        Me.DgvVentas = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbIdVenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtConsultar = New System.Windows.Forms.Button()
        CType(Me.DgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvVentas
        '
        Me.DgvVentas.AllowUserToAddRows = False
        Me.DgvVentas.AllowUserToDeleteRows = False
        Me.DgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvVentas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvVentas.Location = New System.Drawing.Point(0, 146)
        Me.DgvVentas.MultiSelect = False
        Me.DgvVentas.Name = "DgvVentas"
        Me.DgvVentas.ReadOnly = True
        Me.DgvVentas.RowHeadersVisible = False
        Me.DgvVentas.RowHeadersWidth = 40
        Me.DgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvVentas.Size = New System.Drawing.Size(926, 372)
        Me.DgvVentas.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TbNombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TbIdVenta)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtConsultar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(926, 146)
        Me.Panel1.TabIndex = 15
        '
        'TbNombre
        '
        Me.TbNombre.Location = New System.Drawing.Point(241, 27)
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(379, 20)
        Me.TbNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Comprador:"
        '
        'TbIdVenta
        '
        Me.TbIdVenta.Location = New System.Drawing.Point(68, 27)
        Me.TbIdVenta.Name = "TbIdVenta"
        Me.TbIdVenta.Size = New System.Drawing.Size(100, 20)
        Me.TbIdVenta.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id Venta:"
        '
        'BtConsultar
        '
        Me.BtConsultar.Location = New System.Drawing.Point(636, 25)
        Me.BtConsultar.Name = "BtConsultar"
        Me.BtConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtConsultar.TabIndex = 2
        Me.BtConsultar.Text = "Consultar"
        Me.BtConsultar.UseVisualStyleBackColor = True
        '
        'ConsultaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 518)
        Me.Controls.Add(Me.DgvVentas)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ConsultaVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConsultaVentas"
        CType(Me.DgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvVentas As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TbNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbIdVenta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtConsultar As Button
End Class
