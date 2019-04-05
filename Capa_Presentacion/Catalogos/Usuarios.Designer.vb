<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.TbUsuario = New System.Windows.Forms.TextBox()
        Me.CbTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.TbPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbIdUsuario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        Me.GbDatos.SuspendLayout()
        CType(Me.DgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbNombre
        '
        Me.TbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNombre.Location = New System.Drawing.Point(95, 51)
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(158, 20)
        Me.TbNombre.TabIndex = 0
        '
        'TbUsuario
        '
        Me.TbUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbUsuario.Location = New System.Drawing.Point(366, 51)
        Me.TbUsuario.Name = "TbUsuario"
        Me.TbUsuario.Size = New System.Drawing.Size(158, 20)
        Me.TbUsuario.TabIndex = 0
        '
        'CbTipoUsuario
        '
        Me.CbTipoUsuario.FormattingEnabled = True
        Me.CbTipoUsuario.Location = New System.Drawing.Point(366, 93)
        Me.CbTipoUsuario.Name = "CbTipoUsuario"
        Me.CbTipoUsuario.Size = New System.Drawing.Size(158, 21)
        Me.CbTipoUsuario.TabIndex = 1
        '
        'TbPassword
        '
        Me.TbPassword.Location = New System.Drawing.Point(95, 93)
        Me.TbPassword.Name = "TbPassword"
        Me.TbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbPassword.Size = New System.Drawing.Size(158, 20)
        Me.TbPassword.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(277, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(277, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tipo de usuario:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(790, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.CbEstatus)
        Me.GbDatos.Controls.Add(Me.Label5)
        Me.GbDatos.Controls.Add(Me.Label1)
        Me.GbDatos.Controls.Add(Me.Label4)
        Me.GbDatos.Controls.Add(Me.TbIdUsuario)
        Me.GbDatos.Controls.Add(Me.TbNombre)
        Me.GbDatos.Controls.Add(Me.Label3)
        Me.GbDatos.Controls.Add(Me.TbUsuario)
        Me.GbDatos.Controls.Add(Me.Label6)
        Me.GbDatos.Controls.Add(Me.Label2)
        Me.GbDatos.Controls.Add(Me.TbPassword)
        Me.GbDatos.Controls.Add(Me.CbTipoUsuario)
        Me.GbDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbDatos.Location = New System.Drawing.Point(0, 24)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(790, 130)
        Me.GbDatos.TabIndex = 4
        Me.GbDatos.TabStop = False
        '
        'CbEstatus
        '
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(631, 51)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.CbEstatus.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "ID:"
        '
        'TbIdUsuario
        '
        Me.TbIdUsuario.Enabled = False
        Me.TbIdUsuario.Location = New System.Drawing.Point(95, 19)
        Me.TbIdUsuario.Name = "TbIdUsuario"
        Me.TbIdUsuario.Size = New System.Drawing.Size(98, 20)
        Me.TbIdUsuario.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(548, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Estatus:"
        '
        'DgvUsuarios
        '
        Me.DgvUsuarios.AllowUserToAddRows = False
        Me.DgvUsuarios.AllowUserToDeleteRows = False
        Me.DgvUsuarios.AllowUserToOrderColumns = True
        Me.DgvUsuarios.AllowUserToResizeRows = False
        Me.DgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvUsuarios.Location = New System.Drawing.Point(0, 154)
        Me.DgvUsuarios.MultiSelect = False
        Me.DgvUsuarios.Name = "DgvUsuarios"
        Me.DgvUsuarios.ReadOnly = True
        Me.DgvUsuarios.RowHeadersVisible = False
        Me.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvUsuarios.Size = New System.Drawing.Size(790, 318)
        Me.DgvUsuarios.TabIndex = 5
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 472)
        Me.Controls.Add(Me.DgvUsuarios)
        Me.Controls.Add(Me.GbDatos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        CType(Me.DgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbNombre As TextBox
    Friend WithEvents TbUsuario As TextBox
    Friend WithEvents CbTipoUsuario As ComboBox
    Friend WithEvents TbPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbIdUsuario As TextBox
    Friend WithEvents DgvUsuarios As DataGridView
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents Label6 As Label
End Class
