<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Turnos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbrespprensa = New System.Windows.Forms.ComboBox()
        Me.cbrespturno = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dthorasalida = New System.Windows.Forms.DateTimePicker()
        Me.dthoraentrada = New System.Windows.Forms.DateTimePicker()
        Me.tbdescripcion = New System.Windows.Forms.TextBox()
        Me.tbidturnoenc = New System.Windows.Forms.TextBox()
        Me.dgvturnos = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbplanta = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvturnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbplanta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbrespprensa)
        Me.GroupBox1.Controls.Add(Me.cbrespturno)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dthorasalida)
        Me.GroupBox1.Controls.Add(Me.dthoraentrada)
        Me.GroupBox1.Controls.Add(Me.tbdescripcion)
        Me.GroupBox1.Controls.Add(Me.tbidturnoenc)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1054, 118)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Responsable de Prensa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Responsable de Turno"
        '
        'cbrespprensa
        '
        Me.cbrespprensa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbrespprensa.FormattingEnabled = True
        Me.cbrespprensa.Location = New System.Drawing.Point(138, 91)
        Me.cbrespprensa.Name = "cbrespprensa"
        Me.cbrespprensa.Size = New System.Drawing.Size(254, 21)
        Me.cbrespprensa.TabIndex = 4
        '
        'cbrespturno
        '
        Me.cbrespturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbrespturno.FormattingEnabled = True
        Me.cbrespturno.Location = New System.Drawing.Point(138, 64)
        Me.cbrespturno.Name = "cbrespturno"
        Me.cbrespturno.Size = New System.Drawing.Size(254, 21)
        Me.cbrespturno.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(398, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Hora de Salida"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(398, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Hora de Entrada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID"
        '
        'dthorasalida
        '
        Me.dthorasalida.CustomFormat = "HH:mm:ss tt"
        Me.dthorasalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dthorasalida.Location = New System.Drawing.Point(489, 92)
        Me.dthorasalida.Name = "dthorasalida"
        Me.dthorasalida.Size = New System.Drawing.Size(94, 20)
        Me.dthorasalida.TabIndex = 6
        '
        'dthoraentrada
        '
        Me.dthoraentrada.CustomFormat = "HH:mm:ss tt"
        Me.dthoraentrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dthoraentrada.Location = New System.Drawing.Point(489, 65)
        Me.dthoraentrada.Name = "dthoraentrada"
        Me.dthoraentrada.Size = New System.Drawing.Size(94, 20)
        Me.dthoraentrada.TabIndex = 5
        '
        'tbdescripcion
        '
        Me.tbdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbdescripcion.Location = New System.Drawing.Point(138, 38)
        Me.tbdescripcion.Name = "tbdescripcion"
        Me.tbdescripcion.Size = New System.Drawing.Size(100, 20)
        Me.tbdescripcion.TabIndex = 1
        '
        'tbidturnoenc
        '
        Me.tbidturnoenc.Enabled = False
        Me.tbidturnoenc.Location = New System.Drawing.Point(138, 12)
        Me.tbidturnoenc.Name = "tbidturnoenc"
        Me.tbidturnoenc.Size = New System.Drawing.Size(100, 20)
        Me.tbidturnoenc.TabIndex = 0
        '
        'dgvturnos
        '
        Me.dgvturnos.AllowUserToAddRows = False
        Me.dgvturnos.AllowUserToDeleteRows = False
        Me.dgvturnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvturnos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvturnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgvturnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvturnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvturnos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvturnos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvturnos.Location = New System.Drawing.Point(0, 142)
        Me.dgvturnos.MultiSelect = False
        Me.dgvturnos.Name = "dgvturnos"
        Me.dgvturnos.ReadOnly = True
        Me.dgvturnos.RowHeadersVisible = False
        Me.dgvturnos.RowHeadersWidth = 40
        Me.dgvturnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvturnos.Size = New System.Drawing.Size(1054, 527)
        Me.dgvturnos.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1054, 24)
        Me.MenuStrip1.TabIndex = 0
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
        'cbplanta
        '
        Me.cbplanta.FormattingEnabled = True
        Me.cbplanta.Location = New System.Drawing.Point(422, 37)
        Me.cbplanta.Name = "cbplanta"
        Me.cbplanta.Size = New System.Drawing.Size(161, 21)
        Me.cbplanta.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(379, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Planta"
        '
        'Turnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 669)
        Me.Controls.Add(Me.dgvturnos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Turnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Turnos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvturnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvturnos As DataGridView
    Friend WithEvents tbdescripcion As TextBox
    Friend WithEvents tbidturnoenc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dthorasalida As DateTimePicker
    Friend WithEvents dthoraentrada As DateTimePicker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbrespprensa As ComboBox
    Friend WithEvents cbrespturno As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbplanta As ComboBox
End Class
