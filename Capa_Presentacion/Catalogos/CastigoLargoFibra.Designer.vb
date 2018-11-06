<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CastigoLargoFibra
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
        Me.TbIdCastigoLargoFibra = New System.Windows.Forms.TextBox()
        Me.TbRango1 = New System.Windows.Forms.TextBox()
        Me.TbRango2 = New System.Windows.Forms.TextBox()
        Me.TbColorGrade = New System.Windows.Forms.TextBox()
        Me.TbCastigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.DgvCastigoLargoFibra = New System.Windows.Forms.DataGridView()
        Me.MSMenu.SuspendLayout()
        CType(Me.DgvCastigoLargoFibra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(701, 24)
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
        'TbIdCastigoLargoFibra
        '
        Me.TbIdCastigoLargoFibra.Enabled = False
        Me.TbIdCastigoLargoFibra.Location = New System.Drawing.Point(131, 27)
        Me.TbIdCastigoLargoFibra.Name = "TbIdCastigoLargoFibra"
        Me.TbIdCastigoLargoFibra.Size = New System.Drawing.Size(100, 20)
        Me.TbIdCastigoLargoFibra.TabIndex = 1
        '
        'TbRango1
        '
        Me.TbRango1.Location = New System.Drawing.Point(131, 53)
        Me.TbRango1.Name = "TbRango1"
        Me.TbRango1.Size = New System.Drawing.Size(100, 20)
        Me.TbRango1.TabIndex = 2
        '
        'TbRango2
        '
        Me.TbRango2.Location = New System.Drawing.Point(131, 79)
        Me.TbRango2.Name = "TbRango2"
        Me.TbRango2.Size = New System.Drawing.Size(100, 20)
        Me.TbRango2.TabIndex = 3
        '
        'TbColorGrade
        '
        Me.TbColorGrade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbColorGrade.Location = New System.Drawing.Point(131, 105)
        Me.TbColorGrade.Name = "TbColorGrade"
        Me.TbColorGrade.Size = New System.Drawing.Size(100, 20)
        Me.TbColorGrade.TabIndex = 4
        '
        'TbCastigo
        '
        Me.TbCastigo.Location = New System.Drawing.Point(131, 131)
        Me.TbCastigo.Name = "TbCastigo"
        Me.TbCastigo.Size = New System.Drawing.Size(100, 20)
        Me.TbCastigo.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Rango 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Rango 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Color Grade"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Castigo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Estatus"
        '
        'CbEstatus
        '
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(131, 157)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.CbEstatus.TabIndex = 6
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
        Me.DgvCastigoLargoFibra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DgvCastigoLargoFibra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvCastigoLargoFibra.Location = New System.Drawing.Point(0, 206)
        Me.DgvCastigoLargoFibra.MultiSelect = False
        Me.DgvCastigoLargoFibra.Name = "DgvCastigoLargoFibra"
        Me.DgvCastigoLargoFibra.ReadOnly = True
        Me.DgvCastigoLargoFibra.RowHeadersVisible = False
        Me.DgvCastigoLargoFibra.RowHeadersWidth = 40
        Me.DgvCastigoLargoFibra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCastigoLargoFibra.Size = New System.Drawing.Size(701, 322)
        Me.DgvCastigoLargoFibra.TabIndex = 19
        '
        'CastigoLargoFibra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 528)
        Me.Controls.Add(Me.DgvCastigoLargoFibra)
        Me.Controls.Add(Me.CbEstatus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TbCastigo)
        Me.Controls.Add(Me.TbColorGrade)
        Me.Controls.Add(Me.TbRango2)
        Me.Controls.Add(Me.TbRango1)
        Me.Controls.Add(Me.TbIdCastigoLargoFibra)
        Me.Controls.Add(Me.MSMenu)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "CastigoLargoFibra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Castigo Por Largo de Fibra"
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        CType(Me.DgvCastigoLargoFibra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TbIdCastigoLargoFibra As TextBox
    Friend WithEvents TbRango1 As TextBox
    Friend WithEvents TbRango2 As TextBox
    Friend WithEvents TbColorGrade As TextBox
    Friend WithEvents TbCastigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents DgvCastigoLargoFibra As DataGridView
End Class
