<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaClientePreliquidacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaClientePreliquidacion))
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbProductor = New System.Windows.Forms.TextBox()
        Me.DgvProductores = New System.Windows.Forms.DataGridView()
        Me.BtBuscar = New System.Windows.Forms.Button()
        Me.GbDatos.SuspendLayout()
        CType(Me.DgvProductores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.BtBuscar)
        Me.GbDatos.Controls.Add(Me.Label1)
        Me.GbDatos.Controls.Add(Me.TbProductor)
        Me.GbDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatos.Location = New System.Drawing.Point(0, 0)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(723, 81)
        Me.GbDatos.TabIndex = 17
        Me.GbDatos.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Productor:"
        '
        'TbProductor
        '
        Me.TbProductor.Location = New System.Drawing.Point(74, 31)
        Me.TbProductor.Name = "TbProductor"
        Me.TbProductor.Size = New System.Drawing.Size(236, 20)
        Me.TbProductor.TabIndex = 0
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
        Me.DgvProductores.Location = New System.Drawing.Point(0, 81)
        Me.DgvProductores.MultiSelect = False
        Me.DgvProductores.Name = "DgvProductores"
        Me.DgvProductores.ReadOnly = True
        Me.DgvProductores.RowHeadersVisible = False
        Me.DgvProductores.RowHeadersWidth = 40
        Me.DgvProductores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvProductores.Size = New System.Drawing.Size(723, 331)
        Me.DgvProductores.TabIndex = 18
        '
        'BtBuscar
        '
        Me.BtBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtBuscar.Location = New System.Drawing.Point(636, 31)
        Me.BtBuscar.Name = "BtBuscar"
        Me.BtBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtBuscar.TabIndex = 2
        Me.BtBuscar.Text = "Buscar"
        Me.BtBuscar.UseVisualStyleBackColor = True
        '
        'ConsultaClientePreliquidacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 412)
        Me.Controls.Add(Me.DgvProductores)
        Me.Controls.Add(Me.GbDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConsultaClientePreliquidacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consulta Productor"
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        CType(Me.DgvProductores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TbProductor As TextBox
    Friend WithEvents DgvProductores As DataGridView
    Friend WithEvents BtBuscar As Button
End Class
