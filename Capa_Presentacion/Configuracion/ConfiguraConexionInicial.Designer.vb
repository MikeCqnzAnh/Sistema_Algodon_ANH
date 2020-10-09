<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConfiguraConexionInicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfiguraConexionInicial))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GbOrigen = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbDireccionIP1 = New System.Windows.Forms.MaskedTextBox()
        Me.TbDireccionIP2 = New System.Windows.Forms.MaskedTextBox()
        Me.TbDireccionIP3 = New System.Windows.Forms.MaskedTextBox()
        Me.TbDireccionIP4 = New System.Windows.Forms.MaskedTextBox()
        Me.BtCreaConexion = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbOrigenInstancia = New System.Windows.Forms.ComboBox()
        Me.TbOrigenUsuario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbOrigenPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GbOrigen.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GbOrigen)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(381, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 403)
        Me.Panel1.TabIndex = 0
        '
        'GbOrigen
        '
        Me.GbOrigen.Controls.Add(Me.Label8)
        Me.GbOrigen.Controls.Add(Me.Label3)
        Me.GbOrigen.Controls.Add(Me.Label2)
        Me.GbOrigen.Controls.Add(Me.TbDireccionIP1)
        Me.GbOrigen.Controls.Add(Me.TbDireccionIP2)
        Me.GbOrigen.Controls.Add(Me.TbDireccionIP3)
        Me.GbOrigen.Controls.Add(Me.TbDireccionIP4)
        Me.GbOrigen.Controls.Add(Me.BtCreaConexion)
        Me.GbOrigen.Controls.Add(Me.Label4)
        Me.GbOrigen.Controls.Add(Me.CbOrigenInstancia)
        Me.GbOrigen.Controls.Add(Me.TbOrigenUsuario)
        Me.GbOrigen.Controls.Add(Me.Label6)
        Me.GbOrigen.Controls.Add(Me.Label1)
        Me.GbOrigen.Controls.Add(Me.TbOrigenPassword)
        Me.GbOrigen.Controls.Add(Me.Label5)
        Me.GbOrigen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbOrigen.Location = New System.Drawing.Point(0, 0)
        Me.GbOrigen.Name = "GbOrigen"
        Me.GbOrigen.Size = New System.Drawing.Size(360, 403)
        Me.GbOrigen.TabIndex = 0
        Me.GbOrigen.TabStop = False
        Me.GbOrigen.Text = "Instancia:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(273, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(223, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(177, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "."
        '
        'TbDireccionIP1
        '
        Me.TbDireccionIP1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.TbDireccionIP1.Location = New System.Drawing.Point(144, 60)
        Me.TbDireccionIP1.Mask = "999"
        Me.TbDireccionIP1.Name = "TbDireccionIP1"
        Me.TbDireccionIP1.Size = New System.Drawing.Size(31, 20)
        Me.TbDireccionIP1.TabIndex = 5
        '
        'TbDireccionIP2
        '
        Me.TbDireccionIP2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.TbDireccionIP2.Location = New System.Drawing.Point(190, 60)
        Me.TbDireccionIP2.Mask = "999"
        Me.TbDireccionIP2.Name = "TbDireccionIP2"
        Me.TbDireccionIP2.Size = New System.Drawing.Size(31, 20)
        Me.TbDireccionIP2.TabIndex = 5
        '
        'TbDireccionIP3
        '
        Me.TbDireccionIP3.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.TbDireccionIP3.Location = New System.Drawing.Point(236, 60)
        Me.TbDireccionIP3.Mask = "999"
        Me.TbDireccionIP3.Name = "TbDireccionIP3"
        Me.TbDireccionIP3.Size = New System.Drawing.Size(31, 20)
        Me.TbDireccionIP3.TabIndex = 5
        '
        'TbDireccionIP4
        '
        Me.TbDireccionIP4.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.TbDireccionIP4.Location = New System.Drawing.Point(290, 60)
        Me.TbDireccionIP4.Mask = "999"
        Me.TbDireccionIP4.Name = "TbDireccionIP4"
        Me.TbDireccionIP4.Size = New System.Drawing.Size(31, 20)
        Me.TbDireccionIP4.TabIndex = 5
        '
        'BtCreaConexion
        '
        Me.BtCreaConexion.Location = New System.Drawing.Point(197, 202)
        Me.BtCreaConexion.Name = "BtCreaConexion"
        Me.BtCreaConexion.Size = New System.Drawing.Size(108, 23)
        Me.BtCreaConexion.TabIndex = 4
        Me.BtCreaConexion.Text = "Crear Conexion"
        Me.BtCreaConexion.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Instancia:"
        '
        'CbOrigenInstancia
        '
        Me.CbOrigenInstancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbOrigenInstancia.FormattingEnabled = True
        Me.CbOrigenInstancia.Location = New System.Drawing.Point(18, 118)
        Me.CbOrigenInstancia.Name = "CbOrigenInstancia"
        Me.CbOrigenInstancia.Size = New System.Drawing.Size(287, 21)
        Me.CbOrigenInstancia.TabIndex = 1
        '
        'TbOrigenUsuario
        '
        Me.TbOrigenUsuario.Location = New System.Drawing.Point(120, 145)
        Me.TbOrigenUsuario.Name = "TbOrigenUsuario"
        Me.TbOrigenUsuario.Size = New System.Drawing.Size(185, 20)
        Me.TbOrigenUsuario.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Direccion IP de servidor:"
        '
        'TbOrigenPassword
        '
        Me.TbOrigenPassword.Location = New System.Drawing.Point(120, 171)
        Me.TbOrigenPassword.Name = "TbOrigenPassword"
        Me.TbOrigenPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbOrigenPassword.Size = New System.Drawing.Size(185, 20)
        Me.TbOrigenPassword.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nombre de usuario:"
        '
        'ConfiguraConexionInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(741, 403)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ConfiguraConexionInicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configura la conexion inicial"
        Me.Panel1.ResumeLayout(False)
        Me.GbOrigen.ResumeLayout(False)
        Me.GbOrigen.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GbOrigen As GroupBox
    Friend WithEvents BtCreaConexion As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CbOrigenInstancia As ComboBox
    Friend WithEvents TbOrigenUsuario As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbOrigenPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TbDireccionIP1 As MaskedTextBox
    Friend WithEvents TbDireccionIP2 As MaskedTextBox
    Friend WithEvents TbDireccionIP3 As MaskedTextBox
    Friend WithEvents TbDireccionIP4 As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
