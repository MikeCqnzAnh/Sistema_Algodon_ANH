<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CrearEstructura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.GbCreaBdd = New System.Windows.Forms.GroupBox()
        Me.BtCrearDB = New System.Windows.Forms.Button()
        Me.TbAlgodon = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbReciente = New System.Windows.Forms.TextBox()
        Me.TbYear = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtCrearTablas = New System.Windows.Forms.Button()
        Me.BtCrearProcedimientos = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GbTablas = New System.Windows.Forms.GroupBox()
        Me.DgvTablas = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GbProcedimientos = New System.Windows.Forms.GroupBox()
        Me.DgvProcedimientos = New System.Windows.Forms.DataGridView()
        Me.MsMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.GbEstableceDatos.SuspendLayout()
        Me.GbDestino.SuspendLayout()
        Me.GbOrigen.SuspendLayout()
        Me.GbCreaBdd.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GbTablas.SuspendLayout()
        CType(Me.DgvTablas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GbProcedimientos.SuspendLayout()
        CType(Me.DgvProcedimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GbEstableceDatos)
        Me.Panel1.Controls.Add(Me.GbCreaBdd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1376, 274)
        Me.Panel1.TabIndex = 0
        '
        'GbEstableceDatos
        '
        Me.GbEstableceDatos.Controls.Add(Me.GbDestino)
        Me.GbEstableceDatos.Controls.Add(Me.GbOrigen)
        Me.GbEstableceDatos.Dock = System.Windows.Forms.DockStyle.Right
        Me.GbEstableceDatos.Location = New System.Drawing.Point(442, 0)
        Me.GbEstableceDatos.Name = "GbEstableceDatos"
        Me.GbEstableceDatos.Size = New System.Drawing.Size(934, 274)
        Me.GbEstableceDatos.TabIndex = 3
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
        Me.GbDestino.Size = New System.Drawing.Size(459, 255)
        Me.GbDestino.TabIndex = 4
        Me.GbDestino.TabStop = False
        Me.GbDestino.Text = "Instancia destino:"
        '
        'BtDestinoLogin
        '
        Me.BtDestinoLogin.Location = New System.Drawing.Point(223, 100)
        Me.BtDestinoLogin.Name = "BtDestinoLogin"
        Me.BtDestinoLogin.Size = New System.Drawing.Size(75, 23)
        Me.BtDestinoLogin.TabIndex = 3
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
        Me.CbDestinoInstancia.TabIndex = 0
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
        Me.CbDestinoDB.TabIndex = 0
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
        Me.TbDestinoUsuario.TabIndex = 1
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
        Me.GbOrigen.Size = New System.Drawing.Size(445, 255)
        Me.GbOrigen.TabIndex = 3
        Me.GbOrigen.TabStop = False
        Me.GbOrigen.Text = "Instancia origen:"
        '
        'BtOrigenLogin
        '
        Me.BtOrigenLogin.Location = New System.Drawing.Point(223, 99)
        Me.BtOrigenLogin.Name = "BtOrigenLogin"
        Me.BtOrigenLogin.Size = New System.Drawing.Size(75, 23)
        Me.BtOrigenLogin.TabIndex = 3
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
        Me.CbOrigenInstancia.TabIndex = 0
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
        Me.CbOrigenDB.TabIndex = 0
        '
        'TbOrigenUsuario
        '
        Me.TbOrigenUsuario.Location = New System.Drawing.Point(113, 42)
        Me.TbOrigenUsuario.Name = "TbOrigenUsuario"
        Me.TbOrigenUsuario.Size = New System.Drawing.Size(185, 20)
        Me.TbOrigenUsuario.TabIndex = 1
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
        'GbCreaBdd
        '
        Me.GbCreaBdd.Controls.Add(Me.BtCrearDB)
        Me.GbCreaBdd.Controls.Add(Me.TbAlgodon)
        Me.GbCreaBdd.Controls.Add(Me.Label3)
        Me.GbCreaBdd.Controls.Add(Me.Label2)
        Me.GbCreaBdd.Controls.Add(Me.TbReciente)
        Me.GbCreaBdd.Controls.Add(Me.TbYear)
        Me.GbCreaBdd.Controls.Add(Me.Label1)
        Me.GbCreaBdd.Dock = System.Windows.Forms.DockStyle.Left
        Me.GbCreaBdd.Location = New System.Drawing.Point(0, 0)
        Me.GbCreaBdd.Name = "GbCreaBdd"
        Me.GbCreaBdd.Size = New System.Drawing.Size(442, 274)
        Me.GbCreaBdd.TabIndex = 4
        Me.GbCreaBdd.TabStop = False
        '
        'BtCrearDB
        '
        Me.BtCrearDB.Location = New System.Drawing.Point(168, 150)
        Me.BtCrearDB.Name = "BtCrearDB"
        Me.BtCrearDB.Size = New System.Drawing.Size(122, 23)
        Me.BtCrearDB.TabIndex = 0
        Me.BtCrearDB.Text = "Crear Base De Datos"
        Me.BtCrearDB.UseVisualStyleBackColor = True
        '
        'TbAlgodon
        '
        Me.TbAlgodon.Location = New System.Drawing.Point(155, 81)
        Me.TbAlgodon.Name = "TbAlgodon"
        Me.TbAlgodon.Size = New System.Drawing.Size(151, 20)
        Me.TbAlgodon.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Base de datos mas reciente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Año:"
        '
        'TbReciente
        '
        Me.TbReciente.Enabled = False
        Me.TbReciente.Location = New System.Drawing.Point(168, 23)
        Me.TbReciente.Name = "TbReciente"
        Me.TbReciente.Size = New System.Drawing.Size(151, 20)
        Me.TbReciente.TabIndex = 1
        '
        'TbYear
        '
        Me.TbYear.Location = New System.Drawing.Point(155, 116)
        Me.TbYear.Name = "TbYear"
        Me.TbYear.Size = New System.Drawing.Size(151, 20)
        Me.TbYear.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre:"
        '
        'BtCrearTablas
        '
        Me.BtCrearTablas.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtCrearTablas.Location = New System.Drawing.Point(1301, 0)
        Me.BtCrearTablas.MaximumSize = New System.Drawing.Size(75, 23)
        Me.BtCrearTablas.MinimumSize = New System.Drawing.Size(75, 23)
        Me.BtCrearTablas.Name = "BtCrearTablas"
        Me.BtCrearTablas.Size = New System.Drawing.Size(75, 23)
        Me.BtCrearTablas.TabIndex = 0
        Me.BtCrearTablas.Text = "Crear Tablas"
        Me.BtCrearTablas.UseVisualStyleBackColor = True
        '
        'BtCrearProcedimientos
        '
        Me.BtCrearProcedimientos.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtCrearProcedimientos.Location = New System.Drawing.Point(1239, 0)
        Me.BtCrearProcedimientos.MaximumSize = New System.Drawing.Size(137, 23)
        Me.BtCrearProcedimientos.MinimumSize = New System.Drawing.Size(137, 23)
        Me.BtCrearProcedimientos.Name = "BtCrearProcedimientos"
        Me.BtCrearProcedimientos.Size = New System.Drawing.Size(137, 23)
        Me.BtCrearProcedimientos.TabIndex = 0
        Me.BtCrearProcedimientos.Text = "Crear Procedimientos almacenados"
        Me.BtCrearProcedimientos.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GbTablas)
        Me.Panel2.Controls.Add(Me.BtCrearTablas)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 298)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1376, 286)
        Me.Panel2.TabIndex = 1
        '
        'GbTablas
        '
        Me.GbTablas.Controls.Add(Me.DgvTablas)
        Me.GbTablas.Dock = System.Windows.Forms.DockStyle.Left
        Me.GbTablas.Location = New System.Drawing.Point(0, 0)
        Me.GbTablas.Name = "GbTablas"
        Me.GbTablas.Size = New System.Drawing.Size(1176, 286)
        Me.GbTablas.TabIndex = 12
        Me.GbTablas.TabStop = False
        Me.GbTablas.Text = "Tablas a exportar"
        '
        'DgvTablas
        '
        Me.DgvTablas.AllowUserToAddRows = False
        Me.DgvTablas.AllowUserToDeleteRows = False
        Me.DgvTablas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvTablas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvTablas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvTablas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTablas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvTablas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvTablas.Location = New System.Drawing.Point(3, 16)
        Me.DgvTablas.MultiSelect = False
        Me.DgvTablas.Name = "DgvTablas"
        Me.DgvTablas.ReadOnly = True
        Me.DgvTablas.RowHeadersVisible = False
        Me.DgvTablas.RowHeadersWidth = 40
        Me.DgvTablas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvTablas.Size = New System.Drawing.Size(1170, 267)
        Me.DgvTablas.TabIndex = 11
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GbProcedimientos)
        Me.Panel3.Controls.Add(Me.BtCrearProcedimientos)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 584)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1376, 238)
        Me.Panel3.TabIndex = 1
        '
        'GbProcedimientos
        '
        Me.GbProcedimientos.Controls.Add(Me.DgvProcedimientos)
        Me.GbProcedimientos.Dock = System.Windows.Forms.DockStyle.Left
        Me.GbProcedimientos.Location = New System.Drawing.Point(0, 0)
        Me.GbProcedimientos.Name = "GbProcedimientos"
        Me.GbProcedimientos.Size = New System.Drawing.Size(1176, 238)
        Me.GbProcedimientos.TabIndex = 12
        Me.GbProcedimientos.TabStop = False
        Me.GbProcedimientos.Text = "Procedimientos a exportar"
        '
        'DgvProcedimientos
        '
        Me.DgvProcedimientos.AllowUserToAddRows = False
        Me.DgvProcedimientos.AllowUserToDeleteRows = False
        Me.DgvProcedimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvProcedimientos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvProcedimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvProcedimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvProcedimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProcedimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvProcedimientos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvProcedimientos.Location = New System.Drawing.Point(3, 16)
        Me.DgvProcedimientos.MultiSelect = False
        Me.DgvProcedimientos.Name = "DgvProcedimientos"
        Me.DgvProcedimientos.ReadOnly = True
        Me.DgvProcedimientos.RowHeadersVisible = False
        Me.DgvProcedimientos.RowHeadersWidth = 40
        Me.DgvProcedimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvProcedimientos.Size = New System.Drawing.Size(1170, 219)
        Me.DgvProcedimientos.TabIndex = 12
        '
        'MsMenu
        '
        Me.MsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MsMenu.Location = New System.Drawing.Point(0, 0)
        Me.MsMenu.Name = "MsMenu"
        Me.MsMenu.Size = New System.Drawing.Size(1376, 24)
        Me.MsMenu.TabIndex = 4
        Me.MsMenu.Text = "MenuStrip1"
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
        'CrearEstructura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1376, 822)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.MsMenu)
        Me.MainMenuStrip = Me.MsMenu
        Me.Name = "CrearEstructura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Crear Estructura"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GbEstableceDatos.ResumeLayout(False)
        Me.GbDestino.ResumeLayout(False)
        Me.GbDestino.PerformLayout()
        Me.GbOrigen.ResumeLayout(False)
        Me.GbOrigen.PerformLayout()
        Me.GbCreaBdd.ResumeLayout(False)
        Me.GbCreaBdd.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GbTablas.ResumeLayout(False)
        CType(Me.DgvTablas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GbProcedimientos.ResumeLayout(False)
        CType(Me.DgvProcedimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MsMenu.ResumeLayout(False)
        Me.MsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtCrearDB As Button
    Friend WithEvents TbAlgodon As TextBox
    Friend WithEvents TbYear As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtCrearTablas As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TbReciente As TextBox
    Friend WithEvents BtCrearProcedimientos As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GbTablas As GroupBox
    Friend WithEvents DgvTablas As DataGridView
    Friend WithEvents GbProcedimientos As GroupBox
    Friend WithEvents DgvProcedimientos As DataGridView
    Friend WithEvents GbEstableceDatos As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TbDestinoPassword As TextBox
    Friend WithEvents TbDestinoUsuario As TextBox
    Friend WithEvents TbOrigenPassword As TextBox
    Friend WithEvents TbOrigenUsuario As TextBox
    Friend WithEvents CbDestinoDB As ComboBox
    Friend WithEvents CbDestinoInstancia As ComboBox
    Friend WithEvents CbOrigenDB As ComboBox
    Friend WithEvents CbOrigenInstancia As ComboBox
    Friend WithEvents GbDestino As GroupBox
    Friend WithEvents GbOrigen As GroupBox
    Friend WithEvents MsMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtDestinoLogin As Button
    Friend WithEvents BtOrigenLogin As Button
    Friend WithEvents GbCreaBdd As GroupBox
End Class
