<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CastigoResistenciaFibra
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
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbIdResistenciaFibra = New System.Windows.Forms.TextBox()
        Me.TbRango1 = New System.Windows.Forms.TextBox()
        Me.TbRango2 = New System.Windows.Forms.TextBox()
        Me.TbCastigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DgvCastigoResistenciaFibra = New System.Windows.Forms.DataGridView()
        Me.MSMenu.SuspendLayout()
        CType(Me.DgvCastigoResistenciaFibra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(671, 24)
        Me.MSMenu.TabIndex = 0
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'TbIdResistenciaFibra
        '
        Me.TbIdResistenciaFibra.Enabled = False
        Me.TbIdResistenciaFibra.Location = New System.Drawing.Point(129, 27)
        Me.TbIdResistenciaFibra.Name = "TbIdResistenciaFibra"
        Me.TbIdResistenciaFibra.Size = New System.Drawing.Size(100, 20)
        Me.TbIdResistenciaFibra.TabIndex = 1
        '
        'TbRango1
        '
        Me.TbRango1.Location = New System.Drawing.Point(129, 53)
        Me.TbRango1.Name = "TbRango1"
        Me.TbRango1.Size = New System.Drawing.Size(100, 20)
        Me.TbRango1.TabIndex = 2
        '
        'TbRango2
        '
        Me.TbRango2.Location = New System.Drawing.Point(129, 79)
        Me.TbRango2.Name = "TbRango2"
        Me.TbRango2.Size = New System.Drawing.Size(100, 20)
        Me.TbRango2.TabIndex = 3
        '
        'TbCastigo
        '
        Me.TbCastigo.Location = New System.Drawing.Point(129, 105)
        Me.TbCastigo.Name = "TbCastigo"
        Me.TbCastigo.Size = New System.Drawing.Size(100, 20)
        Me.TbCastigo.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Rango 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Rango 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Castigo"
        '
        'CbEstatus
        '
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(129, 131)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.CbEstatus.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Estatus"
        '
        'DgvCastigoResistenciaFibra
        '
        Me.DgvCastigoResistenciaFibra.AllowUserToAddRows = False
        Me.DgvCastigoResistenciaFibra.AllowUserToDeleteRows = False
        Me.DgvCastigoResistenciaFibra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCastigoResistenciaFibra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvCastigoResistenciaFibra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvCastigoResistenciaFibra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvCastigoResistenciaFibra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCastigoResistenciaFibra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DgvCastigoResistenciaFibra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvCastigoResistenciaFibra.Location = New System.Drawing.Point(0, 165)
        Me.DgvCastigoResistenciaFibra.MultiSelect = False
        Me.DgvCastigoResistenciaFibra.Name = "DgvCastigoResistenciaFibra"
        Me.DgvCastigoResistenciaFibra.ReadOnly = True
        Me.DgvCastigoResistenciaFibra.RowHeadersVisible = False
        Me.DgvCastigoResistenciaFibra.RowHeadersWidth = 40
        Me.DgvCastigoResistenciaFibra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCastigoResistenciaFibra.Size = New System.Drawing.Size(671, 322)
        Me.DgvCastigoResistenciaFibra.TabIndex = 20
        '
        'CastigoResistenciaFibra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 487)
        Me.Controls.Add(Me.DgvCastigoResistenciaFibra)
        Me.Controls.Add(Me.CbEstatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbCastigo)
        Me.Controls.Add(Me.TbRango2)
        Me.Controls.Add(Me.TbRango1)
        Me.Controls.Add(Me.TbIdResistenciaFibra)
        Me.Controls.Add(Me.MSMenu)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "CastigoResistenciaFibra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Castigo Por Resistencia de Fibra"
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        CType(Me.DgvCastigoResistenciaFibra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TbIdResistenciaFibra As TextBox
    Friend WithEvents TbRango1 As TextBox
    Friend WithEvents TbRango2 As TextBox
    Friend WithEvents TbCastigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DgvCastigoResistenciaFibra As DataGridView
End Class
