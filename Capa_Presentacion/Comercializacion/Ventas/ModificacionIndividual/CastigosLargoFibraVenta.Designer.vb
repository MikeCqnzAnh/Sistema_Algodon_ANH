<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CastigosLargoFibraVenta
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
        Me.DgvCastigoLargoFibra = New System.Windows.Forms.DataGridView()
        Me.DgvLargoFibraEquivalente = New System.Windows.Forms.DataGridView()
        Me.GbLargoFibra = New System.Windows.Forms.GroupBox()
        Me.GbLargoFibraEquivalente = New System.Windows.Forms.GroupBox()
        CType(Me.DgvCastigoLargoFibra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvLargoFibraEquivalente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbLargoFibra.SuspendLayout()
        Me.GbLargoFibraEquivalente.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvCastigoLargoFibra
        '
        Me.DgvCastigoLargoFibra.AllowUserToAddRows = False
        Me.DgvCastigoLargoFibra.AllowUserToDeleteRows = False
        Me.DgvCastigoLargoFibra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCastigoLargoFibra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvCastigoLargoFibra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvCastigoLargoFibra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvCastigoLargoFibra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCastigoLargoFibra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCastigoLargoFibra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvCastigoLargoFibra.Location = New System.Drawing.Point(3, 16)
        Me.DgvCastigoLargoFibra.MultiSelect = False
        Me.DgvCastigoLargoFibra.Name = "DgvCastigoLargoFibra"
        Me.DgvCastigoLargoFibra.RowHeadersVisible = False
        Me.DgvCastigoLargoFibra.RowHeadersWidth = 40
        Me.DgvCastigoLargoFibra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCastigoLargoFibra.Size = New System.Drawing.Size(396, 523)
        Me.DgvCastigoLargoFibra.TabIndex = 16
        '
        'DgvLargoFibraEquivalente
        '
        Me.DgvLargoFibraEquivalente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLargoFibraEquivalente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvLargoFibraEquivalente.Location = New System.Drawing.Point(3, 16)
        Me.DgvLargoFibraEquivalente.Name = "DgvLargoFibraEquivalente"
        Me.DgvLargoFibraEquivalente.Size = New System.Drawing.Size(403, 523)
        Me.DgvLargoFibraEquivalente.TabIndex = 17
        '
        'GbLargoFibra
        '
        Me.GbLargoFibra.Controls.Add(Me.DgvCastigoLargoFibra)
        Me.GbLargoFibra.Dock = System.Windows.Forms.DockStyle.Left
        Me.GbLargoFibra.Location = New System.Drawing.Point(0, 0)
        Me.GbLargoFibra.Name = "GbLargoFibra"
        Me.GbLargoFibra.Size = New System.Drawing.Size(402, 542)
        Me.GbLargoFibra.TabIndex = 18
        Me.GbLargoFibra.TabStop = False
        Me.GbLargoFibra.Text = "Castigo Largo Fibra"
        '
        'GbLargoFibraEquivalente
        '
        Me.GbLargoFibraEquivalente.Controls.Add(Me.DgvLargoFibraEquivalente)
        Me.GbLargoFibraEquivalente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbLargoFibraEquivalente.Location = New System.Drawing.Point(402, 0)
        Me.GbLargoFibraEquivalente.Name = "GbLargoFibraEquivalente"
        Me.GbLargoFibraEquivalente.Size = New System.Drawing.Size(409, 542)
        Me.GbLargoFibraEquivalente.TabIndex = 19
        Me.GbLargoFibraEquivalente.TabStop = False
        Me.GbLargoFibraEquivalente.Text = "Equivalente"
        '
        'CastigosLargoFibraVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 542)
        Me.Controls.Add(Me.GbLargoFibraEquivalente)
        Me.Controls.Add(Me.GbLargoFibra)
        Me.Name = "CastigosLargoFibraVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CastigosLargoFibraVenta"
        CType(Me.DgvCastigoLargoFibra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvLargoFibraEquivalente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbLargoFibra.ResumeLayout(False)
        Me.GbLargoFibraEquivalente.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvCastigoLargoFibra As DataGridView
    Friend WithEvents DgvLargoFibraEquivalente As DataGridView
    Friend WithEvents GbLargoFibra As GroupBox
    Friend WithEvents GbLargoFibraEquivalente As GroupBox
End Class
