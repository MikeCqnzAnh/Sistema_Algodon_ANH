<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarSalidasPacas
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
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbIdSalida = New System.Windows.Forms.TextBox()
        Me.TbComprador = New System.Windows.Forms.TextBox()
        Me.BtConsultar = New System.Windows.Forms.Button()
        Me.DgvSalidas = New System.Windows.Forms.DataGridView()
        Me.GbDatos.SuspendLayout()
        CType(Me.DgvSalidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.BtConsultar)
        Me.GbDatos.Controls.Add(Me.TbComprador)
        Me.GbDatos.Controls.Add(Me.TbIdSalida)
        Me.GbDatos.Controls.Add(Me.Label2)
        Me.GbDatos.Controls.Add(Me.Label1)
        Me.GbDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatos.Location = New System.Drawing.Point(0, 0)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(767, 129)
        Me.GbDatos.TabIndex = 0
        Me.GbDatos.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Salida"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Comprador"
        '
        'TbIdSalida
        '
        Me.TbIdSalida.Location = New System.Drawing.Point(68, 39)
        Me.TbIdSalida.Name = "TbIdSalida"
        Me.TbIdSalida.Size = New System.Drawing.Size(100, 20)
        Me.TbIdSalida.TabIndex = 2
        '
        'TbComprador
        '
        Me.TbComprador.Location = New System.Drawing.Point(238, 39)
        Me.TbComprador.Name = "TbComprador"
        Me.TbComprador.Size = New System.Drawing.Size(316, 20)
        Me.TbComprador.TabIndex = 3
        '
        'BtConsultar
        '
        Me.BtConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtConsultar.Location = New System.Drawing.Point(680, 83)
        Me.BtConsultar.Name = "BtConsultar"
        Me.BtConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtConsultar.TabIndex = 4
        Me.BtConsultar.Text = "Consultar"
        Me.BtConsultar.UseVisualStyleBackColor = True
        '
        'DgvSalidas
        '
        Me.DgvSalidas.AllowUserToAddRows = False
        Me.DgvSalidas.AllowUserToDeleteRows = False
        Me.DgvSalidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvSalidas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvSalidas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvSalidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSalidas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvSalidas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvSalidas.Location = New System.Drawing.Point(0, 129)
        Me.DgvSalidas.MultiSelect = False
        Me.DgvSalidas.Name = "DgvSalidas"
        Me.DgvSalidas.ReadOnly = True
        Me.DgvSalidas.RowHeadersVisible = False
        Me.DgvSalidas.RowHeadersWidth = 40
        Me.DgvSalidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSalidas.Size = New System.Drawing.Size(767, 319)
        Me.DgvSalidas.TabIndex = 19
        '
        'ConsultarSalidasPacas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 448)
        Me.Controls.Add(Me.DgvSalidas)
        Me.Controls.Add(Me.GbDatos)
        Me.Name = "ConsultarSalidasPacas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Salidas"
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        CType(Me.DgvSalidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents BtConsultar As Button
    Friend WithEvents TbComprador As TextBox
    Friend WithEvents TbIdSalida As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvSalidas As DataGridView
End Class
