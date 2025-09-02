<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaHVI
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
        Me.DgvPaquetes = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbidpaquete = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtConsultar = New System.Windows.Forms.Button()
        CType(Me.DgvPaquetes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvPaquetes
        '
        Me.DgvPaquetes.AllowUserToAddRows = False
        Me.DgvPaquetes.AllowUserToDeleteRows = False
        Me.DgvPaquetes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPaquetes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvPaquetes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvPaquetes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPaquetes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPaquetes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvPaquetes.Location = New System.Drawing.Point(0, 79)
        Me.DgvPaquetes.MultiSelect = False
        Me.DgvPaquetes.Name = "DgvPaquetes"
        Me.DgvPaquetes.ReadOnly = True
        Me.DgvPaquetes.RowHeadersVisible = False
        Me.DgvPaquetes.RowHeadersWidth = 40
        Me.DgvPaquetes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPaquetes.Size = New System.Drawing.Size(933, 449)
        Me.DgvPaquetes.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tbidpaquete)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtConsultar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(933, 79)
        Me.Panel1.TabIndex = 17
        '
        'tbidpaquete
        '
        Me.tbidpaquete.Location = New System.Drawing.Point(68, 27)
        Me.tbidpaquete.MaxLength = 10
        Me.tbidpaquete.Name = "tbidpaquete"
        Me.tbidpaquete.Size = New System.Drawing.Size(100, 20)
        Me.tbidpaquete.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Paquete:"
        '
        'BtConsultar
        '
        Me.BtConsultar.Location = New System.Drawing.Point(846, 25)
        Me.BtConsultar.Name = "BtConsultar"
        Me.BtConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtConsultar.TabIndex = 2
        Me.BtConsultar.Text = "Consultar"
        Me.BtConsultar.UseVisualStyleBackColor = True
        '
        'ConsultaHVI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 528)
        Me.Controls.Add(Me.DgvPaquetes)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ConsultaHVI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consulta"
        CType(Me.DgvPaquetes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvPaquetes As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbidpaquete As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtConsultar As Button
End Class
