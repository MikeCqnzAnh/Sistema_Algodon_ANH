<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportarCatalogos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportarCatalogos))
        Me.BtIniciar = New System.Windows.Forms.Button()
        Me.GbEstableceDatos = New System.Windows.Forms.GroupBox()
        Me.GbDestino = New System.Windows.Forms.GroupBox()
        Me.BtDestinoLogin = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CbDestinoInstancia = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CbDestinoDB = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TbDestinoUsuario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbDestinoPassword = New System.Windows.Forms.TextBox()
        Me.GbOrigen = New System.Windows.Forms.GroupBox()
        Me.BtOrigenLogin = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbOrigenInstancia = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbOrigenDB = New System.Windows.Forms.ComboBox()
        Me.TbOrigenUsuario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbOrigenPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GbTablas = New System.Windows.Forms.GroupBox()
        Me.DgvTablas = New System.Windows.Forms.DataGridView()
        Me.PanelBoton = New System.Windows.Forms.Panel()
        Me.BtDesmarcar = New System.Windows.Forms.Button()
        Me.BtMarcarCheck = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbEstableceDatos.SuspendLayout()
        Me.GbDestino.SuspendLayout()
        Me.GbOrigen.SuspendLayout()
        Me.GbTablas.SuspendLayout()
        CType(Me.DgvTablas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBoton.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtIniciar
        '
        Me.BtIniciar.Location = New System.Drawing.Point(637, 692)
        Me.BtIniciar.Name = "BtIniciar"
        Me.BtIniciar.Size = New System.Drawing.Size(121, 21)
        Me.BtIniciar.TabIndex = 2
        Me.BtIniciar.Text = "Iniciar Importacion"
        Me.BtIniciar.UseVisualStyleBackColor = True
        '
        'GbEstableceDatos
        '
        Me.GbEstableceDatos.Controls.Add(Me.GbDestino)
        Me.GbEstableceDatos.Controls.Add(Me.GbOrigen)
        Me.GbEstableceDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbEstableceDatos.Location = New System.Drawing.Point(0, 24)
        Me.GbEstableceDatos.Name = "GbEstableceDatos"
        Me.GbEstableceDatos.Size = New System.Drawing.Size(1249, 243)
        Me.GbEstableceDatos.TabIndex = 0
        Me.GbEstableceDatos.TabStop = False
        Me.GbEstableceDatos.Text = "Establece datos de creacion"
        '
        'GbDestino
        '
        Me.GbDestino.Controls.Add(Me.BtDestinoLogin)
        Me.GbDestino.Controls.Add(Me.Label8)
        Me.GbDestino.Controls.Add(Me.CbDestinoInstancia)
        Me.GbDestino.Controls.Add(Me.Label11)
        Me.GbDestino.Controls.Add(Me.CbDestinoDB)
        Me.GbDestino.Controls.Add(Me.Label10)
        Me.GbDestino.Controls.Add(Me.TbDestinoUsuario)
        Me.GbDestino.Controls.Add(Me.Label9)
        Me.GbDestino.Controls.Add(Me.TbDestinoPassword)
        Me.GbDestino.Dock = System.Windows.Forms.DockStyle.Left
        Me.GbDestino.Location = New System.Drawing.Point(448, 16)
        Me.GbDestino.Name = "GbDestino"
        Me.GbDestino.Size = New System.Drawing.Size(394, 224)
        Me.GbDestino.TabIndex = 1
        Me.GbDestino.TabStop = False
        Me.GbDestino.Text = "Instancia destino:"
        '
        'BtDestinoLogin
        '
        Me.BtDestinoLogin.Location = New System.Drawing.Point(223, 100)
        Me.BtDestinoLogin.Name = "BtDestinoLogin"
        Me.BtDestinoLogin.Size = New System.Drawing.Size(75, 23)
        Me.BtDestinoLogin.TabIndex = 2
        Me.BtDestinoLogin.Text = "Login"
        Me.BtDestinoLogin.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Instancia:"
        '
        'CbDestinoInstancia
        '
        Me.CbDestinoInstancia.FormattingEnabled = True
        Me.CbDestinoInstancia.Location = New System.Drawing.Point(11, 165)
        Me.CbDestinoInstancia.Name = "CbDestinoInstancia"
        Me.CbDestinoInstancia.Size = New System.Drawing.Size(287, 21)
        Me.CbDestinoInstancia.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 195)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Base de datos:"
        '
        'CbDestinoDB
        '
        Me.CbDestinoDB.FormattingEnabled = True
        Me.CbDestinoDB.Location = New System.Drawing.Point(113, 192)
        Me.CbDestinoDB.Name = "CbDestinoDB"
        Me.CbDestinoDB.Size = New System.Drawing.Size(185, 21)
        Me.CbDestinoDB.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Contraseña:"
        '
        'TbDestinoUsuario
        '
        Me.TbDestinoUsuario.Location = New System.Drawing.Point(113, 42)
        Me.TbDestinoUsuario.Name = "TbDestinoUsuario"
        Me.TbDestinoUsuario.Size = New System.Drawing.Size(185, 20)
        Me.TbDestinoUsuario.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Nombre de usuario:"
        '
        'TbDestinoPassword
        '
        Me.TbDestinoPassword.Location = New System.Drawing.Point(113, 68)
        Me.TbDestinoPassword.Name = "TbDestinoPassword"
        Me.TbDestinoPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbDestinoPassword.Size = New System.Drawing.Size(185, 20)
        Me.TbDestinoPassword.TabIndex = 1
        '
        'GbOrigen
        '
        Me.GbOrigen.Controls.Add(Me.BtOrigenLogin)
        Me.GbOrigen.Controls.Add(Me.Label4)
        Me.GbOrigen.Controls.Add(Me.CbOrigenInstancia)
        Me.GbOrigen.Controls.Add(Me.Label7)
        Me.GbOrigen.Controls.Add(Me.CbOrigenDB)
        Me.GbOrigen.Controls.Add(Me.TbOrigenUsuario)
        Me.GbOrigen.Controls.Add(Me.Label6)
        Me.GbOrigen.Controls.Add(Me.TbOrigenPassword)
        Me.GbOrigen.Controls.Add(Me.Label5)
        Me.GbOrigen.Dock = System.Windows.Forms.DockStyle.Left
        Me.GbOrigen.Location = New System.Drawing.Point(3, 16)
        Me.GbOrigen.Name = "GbOrigen"
        Me.GbOrigen.Size = New System.Drawing.Size(445, 224)
        Me.GbOrigen.TabIndex = 0
        Me.GbOrigen.TabStop = False
        Me.GbOrigen.Text = "Instancia origen:"
        '
        'BtOrigenLogin
        '
        Me.BtOrigenLogin.Location = New System.Drawing.Point(223, 99)
        Me.BtOrigenLogin.Name = "BtOrigenLogin"
        Me.BtOrigenLogin.Size = New System.Drawing.Size(75, 23)
        Me.BtOrigenLogin.TabIndex = 2
        Me.BtOrigenLogin.Text = "Login"
        Me.BtOrigenLogin.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Instancia:"
        '
        'CbOrigenInstancia
        '
        Me.CbOrigenInstancia.FormattingEnabled = True
        Me.CbOrigenInstancia.Location = New System.Drawing.Point(11, 165)
        Me.CbOrigenInstancia.Name = "CbOrigenInstancia"
        Me.CbOrigenInstancia.Size = New System.Drawing.Size(287, 21)
        Me.CbOrigenInstancia.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Base de datos:"
        '
        'CbOrigenDB
        '
        Me.CbOrigenDB.FormattingEnabled = True
        Me.CbOrigenDB.Location = New System.Drawing.Point(113, 192)
        Me.CbOrigenDB.Name = "CbOrigenDB"
        Me.CbOrigenDB.Size = New System.Drawing.Size(185, 21)
        Me.CbOrigenDB.TabIndex = 4
        '
        'TbOrigenUsuario
        '
        Me.TbOrigenUsuario.Location = New System.Drawing.Point(113, 42)
        Me.TbOrigenUsuario.Name = "TbOrigenUsuario"
        Me.TbOrigenUsuario.Size = New System.Drawing.Size(185, 20)
        Me.TbOrigenUsuario.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Contraseña:"
        '
        'TbOrigenPassword
        '
        Me.TbOrigenPassword.Location = New System.Drawing.Point(113, 68)
        Me.TbOrigenPassword.Name = "TbOrigenPassword"
        Me.TbOrigenPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbOrigenPassword.Size = New System.Drawing.Size(185, 20)
        Me.TbOrigenPassword.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nombre de usuario:"
        '
        'GbTablas
        '
        Me.GbTablas.Controls.Add(Me.DgvTablas)
        Me.GbTablas.Controls.Add(Me.PanelBoton)
        Me.GbTablas.Dock = System.Windows.Forms.DockStyle.Left
        Me.GbTablas.Location = New System.Drawing.Point(0, 267)
        Me.GbTablas.Name = "GbTablas"
        Me.GbTablas.Size = New System.Drawing.Size(534, 458)
        Me.GbTablas.TabIndex = 1
        Me.GbTablas.TabStop = False
        Me.GbTablas.Text = "Tablas a importar"
        '
        'DgvTablas
        '
        Me.DgvTablas.AllowUserToAddRows = False
        Me.DgvTablas.AllowUserToDeleteRows = False
        Me.DgvTablas.AllowUserToOrderColumns = True
        Me.DgvTablas.AllowUserToResizeColumns = False
        Me.DgvTablas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTablas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTablas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvTablas.Location = New System.Drawing.Point(3, 16)
        Me.DgvTablas.MultiSelect = False
        Me.DgvTablas.Name = "DgvTablas"
        Me.DgvTablas.RowHeadersVisible = False
        Me.DgvTablas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvTablas.Size = New System.Drawing.Size(445, 439)
        Me.DgvTablas.TabIndex = 0
        '
        'PanelBoton
        '
        Me.PanelBoton.Controls.Add(Me.BtDesmarcar)
        Me.PanelBoton.Controls.Add(Me.BtMarcarCheck)
        Me.PanelBoton.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelBoton.Location = New System.Drawing.Point(448, 16)
        Me.PanelBoton.Name = "PanelBoton"
        Me.PanelBoton.Size = New System.Drawing.Size(83, 439)
        Me.PanelBoton.TabIndex = 4
        '
        'BtDesmarcar
        '
        Me.BtDesmarcar.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtDesmarcar.Location = New System.Drawing.Point(0, 23)
        Me.BtDesmarcar.Name = "BtDesmarcar"
        Me.BtDesmarcar.Size = New System.Drawing.Size(83, 39)
        Me.BtDesmarcar.TabIndex = 4
        Me.BtDesmarcar.Text = "Desmarcar Todo"
        Me.BtDesmarcar.UseVisualStyleBackColor = True
        '
        'BtMarcarCheck
        '
        Me.BtMarcarCheck.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtMarcarCheck.Location = New System.Drawing.Point(0, 0)
        Me.BtMarcarCheck.Name = "BtMarcarCheck"
        Me.BtMarcarCheck.Size = New System.Drawing.Size(83, 23)
        Me.BtMarcarCheck.TabIndex = 3
        Me.BtMarcarCheck.Text = "Marcar Todo"
        Me.BtMarcarCheck.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1249, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ImportarCatalogos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1249, 725)
        Me.Controls.Add(Me.GbTablas)
        Me.Controls.Add(Me.GbEstableceDatos)
        Me.Controls.Add(Me.BtIniciar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ImportarCatalogos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar Catalogos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbEstableceDatos.ResumeLayout(False)
        Me.GbDestino.ResumeLayout(False)
        Me.GbDestino.PerformLayout()
        Me.GbOrigen.ResumeLayout(False)
        Me.GbOrigen.PerformLayout()
        Me.GbTablas.ResumeLayout(False)
        CType(Me.DgvTablas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBoton.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtIniciar As Button
    Friend WithEvents GbEstableceDatos As GroupBox
    Friend WithEvents GbDestino As GroupBox
    Friend WithEvents BtDestinoLogin As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents CbDestinoInstancia As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CbDestinoDB As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TbDestinoUsuario As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TbDestinoPassword As TextBox
    Friend WithEvents GbOrigen As GroupBox
    Friend WithEvents BtOrigenLogin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CbOrigenInstancia As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CbOrigenDB As ComboBox
    Friend WithEvents TbOrigenUsuario As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbOrigenPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GbTablas As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DgvTablas As DataGridView
    Friend WithEvents BtMarcarCheck As Button
    Friend WithEvents PanelBoton As Panel
    Friend WithEvents BtDesmarcar As Button
End Class
