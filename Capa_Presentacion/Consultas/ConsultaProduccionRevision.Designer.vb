<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaProduccionRevision
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaProduccionRevision))
        Me.DgvProducciones = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbProductor = New System.Windows.Forms.TextBox()
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.TbIdProduccion = New System.Windows.Forms.TextBox()
        Me.TbIdOrdenTrabajo = New System.Windows.Forms.TextBox()
        Me.BtConsultar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DgvProducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvProducciones
        '
        Me.DgvProducciones.AllowUserToAddRows = False
        Me.DgvProducciones.AllowUserToDeleteRows = False
        Me.DgvProducciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvProducciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvProducciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvProducciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvProducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProducciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvProducciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvProducciones.Location = New System.Drawing.Point(0, 81)
        Me.DgvProducciones.MultiSelect = False
        Me.DgvProducciones.Name = "DgvProducciones"
        Me.DgvProducciones.ReadOnly = True
        Me.DgvProducciones.RowHeadersVisible = False
        Me.DgvProducciones.RowHeadersWidth = 40
        Me.DgvProducciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvProducciones.Size = New System.Drawing.Size(1102, 426)
        Me.DgvProducciones.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(523, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Productor:"
        '
        'TbProductor
        '
        Me.TbProductor.Location = New System.Drawing.Point(585, 19)
        Me.TbProductor.Name = "TbProductor"
        Me.TbProductor.Size = New System.Drawing.Size(330, 20)
        Me.TbProductor.TabIndex = 2
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.TbIdProduccion)
        Me.GbDatos.Controls.Add(Me.TbIdOrdenTrabajo)
        Me.GbDatos.Controls.Add(Me.BtConsultar)
        Me.GbDatos.Controls.Add(Me.Label3)
        Me.GbDatos.Controls.Add(Me.Label2)
        Me.GbDatos.Controls.Add(Me.Label1)
        Me.GbDatos.Controls.Add(Me.TbProductor)
        Me.GbDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatos.Location = New System.Drawing.Point(0, 0)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(1102, 81)
        Me.GbDatos.TabIndex = 0
        Me.GbDatos.TabStop = False
        '
        'TbIdProduccion
        '
        Me.TbIdProduccion.Location = New System.Drawing.Point(387, 19)
        Me.TbIdProduccion.Name = "TbIdProduccion"
        Me.TbIdProduccion.Size = New System.Drawing.Size(100, 20)
        Me.TbIdProduccion.TabIndex = 1
        '
        'TbIdOrdenTrabajo
        '
        Me.TbIdOrdenTrabajo.Location = New System.Drawing.Point(121, 19)
        Me.TbIdOrdenTrabajo.Name = "TbIdOrdenTrabajo"
        Me.TbIdOrdenTrabajo.Size = New System.Drawing.Size(100, 20)
        Me.TbIdOrdenTrabajo.TabIndex = 0
        '
        'BtConsultar
        '
        Me.BtConsultar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtConsultar.Location = New System.Drawing.Point(1021, 17)
        Me.BtConsultar.Name = "BtConsultar"
        Me.BtConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtConsultar.TabIndex = 3
        Me.BtConsultar.Text = "Consultar"
        Me.BtConsultar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(257, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ID Orden de produccion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID Orden de trabajo:"
        '
        'ConsultaProduccionRevision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 507)
        Me.Controls.Add(Me.DgvProducciones)
        Me.Controls.Add(Me.GbDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConsultaProduccionRevision"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Produccion"
        CType(Me.DgvProducciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvProducciones As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TbProductor As TextBox
    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtConsultar As Button
    Friend WithEvents TbIdProduccion As TextBox
    Friend WithEvents TbIdOrdenTrabajo As TextBox
End Class
