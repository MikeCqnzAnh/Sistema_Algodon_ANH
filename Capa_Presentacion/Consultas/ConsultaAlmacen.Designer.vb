<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaAlmacen
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
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.BtBuscar = New System.Windows.Forms.Button()
        Me.TbAlmacen = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbIdAlmacen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvAlmacenes = New System.Windows.Forms.DataGridView()
        Me.GbDatosGenerales.SuspendLayout()
        CType(Me.DgvAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.Controls.Add(Me.BtBuscar)
        Me.GbDatosGenerales.Controls.Add(Me.TbAlmacen)
        Me.GbDatosGenerales.Controls.Add(Me.Label2)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdAlmacen)
        Me.GbDatosGenerales.Controls.Add(Me.Label1)
        Me.GbDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatosGenerales.Location = New System.Drawing.Point(0, 0)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(818, 138)
        Me.GbDatosGenerales.TabIndex = 0
        Me.GbDatosGenerales.TabStop = False
        '
        'BtBuscar
        '
        Me.BtBuscar.Location = New System.Drawing.Point(737, 25)
        Me.BtBuscar.Name = "BtBuscar"
        Me.BtBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtBuscar.TabIndex = 4
        Me.BtBuscar.Text = "Buscar"
        Me.BtBuscar.UseVisualStyleBackColor = True
        '
        'TbAlmacen
        '
        Me.TbAlmacen.Location = New System.Drawing.Point(296, 27)
        Me.TbAlmacen.Name = "TbAlmacen"
        Me.TbAlmacen.Size = New System.Drawing.Size(290, 20)
        Me.TbAlmacen.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Almacen:"
        '
        'TbIdAlmacen
        '
        Me.TbIdAlmacen.Location = New System.Drawing.Point(83, 27)
        Me.TbIdAlmacen.Name = "TbIdAlmacen"
        Me.TbIdAlmacen.Size = New System.Drawing.Size(100, 20)
        Me.TbIdAlmacen.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Almacen:"
        '
        'DgvAlmacenes
        '
        Me.DgvAlmacenes.AllowUserToAddRows = False
        Me.DgvAlmacenes.AllowUserToDeleteRows = False
        Me.DgvAlmacenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvAlmacenes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvAlmacenes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvAlmacenes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvAlmacenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAlmacenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvAlmacenes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvAlmacenes.Location = New System.Drawing.Point(0, 138)
        Me.DgvAlmacenes.MultiSelect = False
        Me.DgvAlmacenes.Name = "DgvAlmacenes"
        Me.DgvAlmacenes.ReadOnly = True
        Me.DgvAlmacenes.RowHeadersVisible = False
        Me.DgvAlmacenes.RowHeadersWidth = 40
        Me.DgvAlmacenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvAlmacenes.Size = New System.Drawing.Size(818, 292)
        Me.DgvAlmacenes.TabIndex = 15
        '
        'ConsultaAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 430)
        Me.Controls.Add(Me.DgvAlmacenes)
        Me.Controls.Add(Me.GbDatosGenerales)
        Me.MinimumSize = New System.Drawing.Size(834, 469)
        Me.Name = "ConsultaAlmacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consulta Almacen"
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        CType(Me.DgvAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbDatosGenerales As GroupBox
    Friend WithEvents BtBuscar As Button
    Friend WithEvents TbAlmacen As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbIdAlmacen As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvAlmacenes As DataGridView
End Class
