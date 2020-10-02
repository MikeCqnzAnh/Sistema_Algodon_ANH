<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaClientes))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvConsultaClientes = New System.Windows.Forms.DataGridView()
        Me.BtBuscar = New System.Windows.Forms.Button()
        Me.GbParametros = New System.Windows.Forms.GroupBox()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.TbIdCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DgvConsultaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbParametros.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Id Cliente :"
        '
        'DgvConsultaClientes
        '
        Me.DgvConsultaClientes.AllowUserToAddRows = False
        Me.DgvConsultaClientes.AllowUserToDeleteRows = False
        Me.DgvConsultaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvConsultaClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvConsultaClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvConsultaClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvConsultaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConsultaClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvConsultaClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvConsultaClientes.Location = New System.Drawing.Point(0, 100)
        Me.DgvConsultaClientes.MultiSelect = False
        Me.DgvConsultaClientes.Name = "DgvConsultaClientes"
        Me.DgvConsultaClientes.ReadOnly = True
        Me.DgvConsultaClientes.RowHeadersVisible = False
        Me.DgvConsultaClientes.RowHeadersWidth = 40
        Me.DgvConsultaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvConsultaClientes.Size = New System.Drawing.Size(1070, 510)
        Me.DgvConsultaClientes.TabIndex = 10
        '
        'BtBuscar
        '
        Me.BtBuscar.Location = New System.Drawing.Point(983, 28)
        Me.BtBuscar.Name = "BtBuscar"
        Me.BtBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtBuscar.TabIndex = 11
        Me.BtBuscar.Text = "Consultar"
        Me.BtBuscar.UseVisualStyleBackColor = True
        '
        'GbParametros
        '
        Me.GbParametros.Controls.Add(Me.TbNombre)
        Me.GbParametros.Controls.Add(Me.TbIdCliente)
        Me.GbParametros.Controls.Add(Me.BtBuscar)
        Me.GbParametros.Controls.Add(Me.Label2)
        Me.GbParametros.Controls.Add(Me.Label1)
        Me.GbParametros.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbParametros.Location = New System.Drawing.Point(0, 0)
        Me.GbParametros.Name = "GbParametros"
        Me.GbParametros.Size = New System.Drawing.Size(1070, 100)
        Me.GbParametros.TabIndex = 12
        Me.GbParametros.TabStop = False
        '
        'TbNombre
        '
        Me.TbNombre.Location = New System.Drawing.Point(286, 30)
        Me.TbNombre.MaxLength = 100
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(440, 20)
        Me.TbNombre.TabIndex = 12
        '
        'TbIdCliente
        '
        Me.TbIdCliente.Location = New System.Drawing.Point(75, 30)
        Me.TbIdCliente.MaxLength = 10
        Me.TbIdCliente.Name = "TbIdCliente"
        Me.TbIdCliente.Size = New System.Drawing.Size(100, 20)
        Me.TbIdCliente.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre :"
        '
        'ConsultaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 610)
        Me.Controls.Add(Me.DgvConsultaClientes)
        Me.Controls.Add(Me.GbParametros)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConsultaClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Clientes"
        CType(Me.DgvConsultaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbParametros.ResumeLayout(False)
        Me.GbParametros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvConsultaClientes As DataGridView
    Friend WithEvents BtBuscar As Button
    Friend WithEvents GbParametros As GroupBox
    Friend WithEvents TbIdCliente As TextBox
    Friend WithEvents TbNombre As TextBox
    Friend WithEvents Label2 As Label
End Class
