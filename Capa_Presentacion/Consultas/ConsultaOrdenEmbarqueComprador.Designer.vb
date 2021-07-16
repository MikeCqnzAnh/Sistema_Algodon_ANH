<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaOrdenEmbarqueComprador
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtConsultar = New System.Windows.Forms.Button()
        Me.TbComprador = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgvCompradores = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvCompradores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtConsultar)
        Me.GroupBox1.Controls.Add(Me.TbComprador)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(833, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'BtConsultar
        '
        Me.BtConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtConsultar.Location = New System.Drawing.Point(746, 23)
        Me.BtConsultar.Name = "BtConsultar"
        Me.BtConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtConsultar.TabIndex = 3
        Me.BtConsultar.Text = "Consultar"
        Me.BtConsultar.UseVisualStyleBackColor = True
        '
        'TbComprador
        '
        Me.TbComprador.Location = New System.Drawing.Point(76, 25)
        Me.TbComprador.Name = "TbComprador"
        Me.TbComprador.Size = New System.Drawing.Size(422, 20)
        Me.TbComprador.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Comprador"
        '
        'DgvCompradores
        '
        Me.DgvCompradores.AllowUserToAddRows = False
        Me.DgvCompradores.AllowUserToDeleteRows = False
        Me.DgvCompradores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCompradores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvCompradores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvCompradores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvCompradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCompradores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCompradores.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvCompradores.Location = New System.Drawing.Point(0, 88)
        Me.DgvCompradores.MultiSelect = False
        Me.DgvCompradores.Name = "DgvCompradores"
        Me.DgvCompradores.ReadOnly = True
        Me.DgvCompradores.RowHeadersVisible = False
        Me.DgvCompradores.RowHeadersWidth = 40
        Me.DgvCompradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCompradores.Size = New System.Drawing.Size(833, 406)
        Me.DgvCompradores.TabIndex = 17
        '
        'ConsultaOrdenEmbarqueComprador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 494)
        Me.Controls.Add(Me.DgvCompradores)
        Me.Controls.Add(Me.GroupBox1)
        Me.MinimumSize = New System.Drawing.Size(849, 533)
        Me.Name = "ConsultaOrdenEmbarqueComprador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consulta de Comprador"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvCompradores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TbComprador As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtConsultar As Button
    Friend WithEvents DgvCompradores As DataGridView
End Class
