<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaSalidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaSalidas))
        Me.GbGeneral = New System.Windows.Forms.GroupBox()
        Me.BtConsultar = New System.Windows.Forms.Button()
        Me.TbIdSalida = New System.Windows.Forms.TextBox()
        Me.TbNombreComprador = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvSalidas = New System.Windows.Forms.DataGridView()
        Me.GbGeneral.SuspendLayout()
        CType(Me.DgvSalidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbGeneral
        '
        Me.GbGeneral.Controls.Add(Me.BtConsultar)
        Me.GbGeneral.Controls.Add(Me.TbIdSalida)
        Me.GbGeneral.Controls.Add(Me.TbNombreComprador)
        Me.GbGeneral.Controls.Add(Me.Label2)
        Me.GbGeneral.Controls.Add(Me.Label1)
        Me.GbGeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbGeneral.Location = New System.Drawing.Point(0, 0)
        Me.GbGeneral.Name = "GbGeneral"
        Me.GbGeneral.Size = New System.Drawing.Size(735, 114)
        Me.GbGeneral.TabIndex = 0
        Me.GbGeneral.TabStop = False
        '
        'BtConsultar
        '
        Me.BtConsultar.Location = New System.Drawing.Point(617, 15)
        Me.BtConsultar.Name = "BtConsultar"
        Me.BtConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtConsultar.TabIndex = 4
        Me.BtConsultar.Text = "Consultar"
        Me.BtConsultar.UseVisualStyleBackColor = True
        '
        'TbIdSalida
        '
        Me.TbIdSalida.Location = New System.Drawing.Point(69, 17)
        Me.TbIdSalida.Name = "TbIdSalida"
        Me.TbIdSalida.Size = New System.Drawing.Size(88, 20)
        Me.TbIdSalida.TabIndex = 3
        '
        'TbNombreComprador
        '
        Me.TbNombreComprador.Location = New System.Drawing.Point(240, 17)
        Me.TbNombreComprador.Name = "TbNombreComprador"
        Me.TbNombreComprador.Size = New System.Drawing.Size(269, 20)
        Me.TbNombreComprador.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Comprador"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Salida"
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
        Me.DgvSalidas.Location = New System.Drawing.Point(0, 114)
        Me.DgvSalidas.MultiSelect = False
        Me.DgvSalidas.Name = "DgvSalidas"
        Me.DgvSalidas.ReadOnly = True
        Me.DgvSalidas.RowHeadersVisible = False
        Me.DgvSalidas.RowHeadersWidth = 40
        Me.DgvSalidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvSalidas.Size = New System.Drawing.Size(735, 326)
        Me.DgvSalidas.TabIndex = 3
        '
        'ConsultaSalidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 440)
        Me.Controls.Add(Me.DgvSalidas)
        Me.Controls.Add(Me.GbGeneral)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConsultaSalidas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consultar Salidas"
        Me.GbGeneral.ResumeLayout(False)
        Me.GbGeneral.PerformLayout()
        CType(Me.DgvSalidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GbGeneral As GroupBox
    Friend WithEvents BtConsultar As Button
    Friend WithEvents TbIdSalida As TextBox
    Friend WithEvents TbNombreComprador As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvSalidas As DataGridView
End Class
