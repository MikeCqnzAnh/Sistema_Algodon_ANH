<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaIntegracion
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
        Me.DgvIntegracion = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TbIdIntegracion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbIdCompra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtConsultar = New System.Windows.Forms.Button()
        CType(Me.DgvIntegracion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvIntegracion
        '
        Me.DgvIntegracion.AllowUserToAddRows = False
        Me.DgvIntegracion.AllowUserToDeleteRows = False
        Me.DgvIntegracion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvIntegracion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvIntegracion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvIntegracion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvIntegracion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvIntegracion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvIntegracion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvIntegracion.Location = New System.Drawing.Point(0, 146)
        Me.DgvIntegracion.MultiSelect = False
        Me.DgvIntegracion.Name = "DgvIntegracion"
        Me.DgvIntegracion.ReadOnly = True
        Me.DgvIntegracion.RowHeadersVisible = False
        Me.DgvIntegracion.RowHeadersWidth = 40
        Me.DgvIntegracion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvIntegracion.Size = New System.Drawing.Size(1009, 373)
        Me.DgvIntegracion.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TbIdIntegracion)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TbNombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TbIdCompra)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtConsultar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1009, 146)
        Me.Panel1.TabIndex = 17
        '
        'TbIdIntegracion
        '
        Me.TbIdIntegracion.Location = New System.Drawing.Point(84, 32)
        Me.TbIdIntegracion.Name = "TbIdIntegracion"
        Me.TbIdIntegracion.Size = New System.Drawing.Size(100, 20)
        Me.TbIdIntegracion.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Id Integracion:"
        '
        'TbNombre
        '
        Me.TbNombre.Location = New System.Drawing.Point(422, 32)
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(379, 20)
        Me.TbNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(360, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Productor:"
        '
        'TbIdCompra
        '
        Me.TbIdCompra.Location = New System.Drawing.Point(254, 32)
        Me.TbIdCompra.Name = "TbIdCompra"
        Me.TbIdCompra.Size = New System.Drawing.Size(100, 20)
        Me.TbIdCompra.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(190, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id Compra:"
        '
        'BtConsultar
        '
        Me.BtConsultar.Location = New System.Drawing.Point(807, 30)
        Me.BtConsultar.Name = "BtConsultar"
        Me.BtConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtConsultar.TabIndex = 2
        Me.BtConsultar.Text = "Consultar"
        Me.BtConsultar.UseVisualStyleBackColor = True
        '
        'ConsultaIntegracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 519)
        Me.Controls.Add(Me.DgvIntegracion)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ConsultaIntegracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consulta de Integracion de Compra"
        CType(Me.DgvIntegracion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvIntegracion As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TbIdIntegracion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbIdCompra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtConsultar As Button
End Class
