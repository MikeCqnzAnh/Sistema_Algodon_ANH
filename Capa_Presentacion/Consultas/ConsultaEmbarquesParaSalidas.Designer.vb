<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaEmbarquesParaSalidas
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
        Me.DgvConsultaEmbarque = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbNoLote = New System.Windows.Forms.TextBox()
        Me.BtConsulta = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbNombreComprador = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbIdEmbarque = New System.Windows.Forms.TextBox()
        CType(Me.DgvConsultaEmbarque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvConsultaEmbarque
        '
        Me.DgvConsultaEmbarque.AllowUserToAddRows = False
        Me.DgvConsultaEmbarque.AllowUserToDeleteRows = False
        Me.DgvConsultaEmbarque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvConsultaEmbarque.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvConsultaEmbarque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvConsultaEmbarque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvConsultaEmbarque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConsultaEmbarque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvConsultaEmbarque.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvConsultaEmbarque.Location = New System.Drawing.Point(0, 91)
        Me.DgvConsultaEmbarque.MultiSelect = False
        Me.DgvConsultaEmbarque.Name = "DgvConsultaEmbarque"
        Me.DgvConsultaEmbarque.ReadOnly = True
        Me.DgvConsultaEmbarque.RowHeadersVisible = False
        Me.DgvConsultaEmbarque.RowHeadersWidth = 40
        Me.DgvConsultaEmbarque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvConsultaEmbarque.Size = New System.Drawing.Size(1327, 346)
        Me.DgvConsultaEmbarque.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TbNoLote)
        Me.GroupBox1.Controls.Add(Me.BtConsulta)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TbNombreComprador)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TbIdEmbarque)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1327, 91)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(789, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "No Lote"
        '
        'TbNoLote
        '
        Me.TbNoLote.Location = New System.Drawing.Point(840, 26)
        Me.TbNoLote.MaxLength = 30
        Me.TbNoLote.Name = "TbNoLote"
        Me.TbNoLote.Size = New System.Drawing.Size(149, 20)
        Me.TbNoLote.TabIndex = 3
        '
        'BtConsulta
        '
        Me.BtConsulta.Location = New System.Drawing.Point(1219, 23)
        Me.BtConsulta.Name = "BtConsulta"
        Me.BtConsulta.Size = New System.Drawing.Size(102, 23)
        Me.BtConsulta.TabIndex = 2
        Me.BtConsulta.Text = "Consultar"
        Me.BtConsulta.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id Embarque"
        '
        'TbNombreComprador
        '
        Me.TbNombreComprador.Location = New System.Drawing.Point(321, 25)
        Me.TbNombreComprador.Name = "TbNombreComprador"
        Me.TbNombreComprador.Size = New System.Drawing.Size(382, 20)
        Me.TbNombreComprador.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre Comprador"
        '
        'TbIdEmbarque
        '
        Me.TbIdEmbarque.Location = New System.Drawing.Point(76, 25)
        Me.TbIdEmbarque.Name = "TbIdEmbarque"
        Me.TbIdEmbarque.Size = New System.Drawing.Size(104, 20)
        Me.TbIdEmbarque.TabIndex = 0
        '
        'ConsultaEmbarquesParaSalidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1327, 437)
        Me.Controls.Add(Me.DgvConsultaEmbarque)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ConsultaEmbarquesParaSalidas"
        Me.Text = "Consulta de Ordenes de Embarque"
        CType(Me.DgvConsultaEmbarque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvConsultaEmbarque As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbNoLote As TextBox
    Friend WithEvents BtConsulta As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TbNombreComprador As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbIdEmbarque As TextBox
End Class
