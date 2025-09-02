<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaTierras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaTierras))
        Me.BtBuscar = New System.Windows.Forms.Button()
        Me.DgvConsultaTierras = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbNombreLote = New System.Windows.Forms.TextBox()
        CType(Me.DgvConsultaTierras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtBuscar
        '
        Me.BtBuscar.Location = New System.Drawing.Point(375, 4)
        Me.BtBuscar.Name = "BtBuscar"
        Me.BtBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtBuscar.TabIndex = 15
        Me.BtBuscar.Text = "Consultar"
        Me.BtBuscar.UseVisualStyleBackColor = True
        '
        'DgvConsultaTierras
        '
        Me.DgvConsultaTierras.AllowUserToAddRows = False
        Me.DgvConsultaTierras.AllowUserToDeleteRows = False
        Me.DgvConsultaTierras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvConsultaTierras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvConsultaTierras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvConsultaTierras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvConsultaTierras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConsultaTierras.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvConsultaTierras.Location = New System.Drawing.Point(12, 42)
        Me.DgvConsultaTierras.MultiSelect = False
        Me.DgvConsultaTierras.Name = "DgvConsultaTierras"
        Me.DgvConsultaTierras.ReadOnly = True
        Me.DgvConsultaTierras.RowHeadersVisible = False
        Me.DgvConsultaTierras.RowHeadersWidth = 40
        Me.DgvConsultaTierras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvConsultaTierras.Size = New System.Drawing.Size(660, 301)
        Me.DgvConsultaTierras.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nombre de Lote"
        '
        'TbNombreLote
        '
        Me.TbNombreLote.Location = New System.Drawing.Point(101, 6)
        Me.TbNombreLote.Name = "TbNombreLote"
        Me.TbNombreLote.Size = New System.Drawing.Size(268, 20)
        Me.TbNombreLote.TabIndex = 16
        '
        'ConsultaTierras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 361)
        Me.Controls.Add(Me.TbNombreLote)
        Me.Controls.Add(Me.BtBuscar)
        Me.Controls.Add(Me.DgvConsultaTierras)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConsultaTierras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consulta Tierras"
        CType(Me.DgvConsultaTierras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtBuscar As Button
    Friend WithEvents DgvConsultaTierras As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TbNombreLote As TextBox
End Class
