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
        Me.CbTIpoPersona = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvConsultaClientes = New System.Windows.Forms.DataGridView()
        Me.BtBuscar = New System.Windows.Forms.Button()
        CType(Me.DgvConsultaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CbTIpoPersona
        '
        Me.CbTIpoPersona.FormattingEnabled = True
        Me.CbTIpoPersona.Location = New System.Drawing.Point(122, 12)
        Me.CbTIpoPersona.Name = "CbTIpoPersona"
        Me.CbTIpoPersona.Size = New System.Drawing.Size(121, 21)
        Me.CbTIpoPersona.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tipo Persona"
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
        Me.DgvConsultaClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvConsultaClientes.Location = New System.Drawing.Point(12, 48)
        Me.DgvConsultaClientes.MultiSelect = False
        Me.DgvConsultaClientes.Name = "DgvConsultaClientes"
        Me.DgvConsultaClientes.ReadOnly = True
        Me.DgvConsultaClientes.RowHeadersVisible = False
        Me.DgvConsultaClientes.RowHeadersWidth = 40
        Me.DgvConsultaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvConsultaClientes.Size = New System.Drawing.Size(660, 301)
        Me.DgvConsultaClientes.TabIndex = 10
        '
        'BtBuscar
        '
        Me.BtBuscar.Location = New System.Drawing.Point(249, 12)
        Me.BtBuscar.Name = "BtBuscar"
        Me.BtBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtBuscar.TabIndex = 11
        Me.BtBuscar.Text = "Consultar"
        Me.BtBuscar.UseVisualStyleBackColor = True
        '
        'ConsultaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 361)
        Me.Controls.Add(Me.BtBuscar)
        Me.Controls.Add(Me.DgvConsultaClientes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbTIpoPersona)
        Me.Name = "ConsultaClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Clientes"
        CType(Me.DgvConsultaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbTIpoPersona As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvConsultaClientes As DataGridView
    Friend WithEvents BtBuscar As Button
End Class
