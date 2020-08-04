<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParametrosCorreo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CkConexionCifrada = New System.Windows.Forms.CheckBox()
        Me.TbEmail = New System.Windows.Forms.TextBox()
        Me.TbPassword = New System.Windows.Forms.TextBox()
        Me.TbPuertosmtp = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbHostsmtp = New System.Windows.Forms.TextBox()
        Me.btenvia = New System.Windows.Forms.Button()
        Me.tbdestinatario = New System.Windows.Forms.TextBox()
        Me.tbasunto = New System.Windows.Forms.TextBox()
        Me.tbmensaje = New System.Windows.Forms.TextBox()
        Me.btadjuntar = New System.Windows.Forms.Button()
        Me.TbRuta = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "E-mail:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Servidor de salida (SMTP):"
        '
        'CkConexionCifrada
        '
        Me.CkConexionCifrada.AutoSize = True
        Me.CkConexionCifrada.Location = New System.Drawing.Point(151, 155)
        Me.CkConexionCifrada.Name = "CkConexionCifrada"
        Me.CkConexionCifrada.Size = New System.Drawing.Size(167, 17)
        Me.CkConexionCifrada.TabIndex = 4
        Me.CkConexionCifrada.Text = "Utilizar conexion cifrada (SSL)"
        Me.CkConexionCifrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CkConexionCifrada.UseVisualStyleBackColor = True
        '
        'TbEmail
        '
        Me.TbEmail.Location = New System.Drawing.Point(151, 51)
        Me.TbEmail.Name = "TbEmail"
        Me.TbEmail.Size = New System.Drawing.Size(201, 20)
        Me.TbEmail.TabIndex = 0
        '
        'TbPassword
        '
        Me.TbPassword.Location = New System.Drawing.Point(151, 77)
        Me.TbPassword.Name = "TbPassword"
        Me.TbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbPassword.Size = New System.Drawing.Size(201, 20)
        Me.TbPassword.TabIndex = 1
        '
        'TbPuertosmtp
        '
        Me.TbPuertosmtp.Location = New System.Drawing.Point(151, 129)
        Me.TbPuertosmtp.MaxLength = 4
        Me.TbPuertosmtp.Name = "TbPuertosmtp"
        Me.TbPuertosmtp.Size = New System.Drawing.Size(64, 20)
        Me.TbPuertosmtp.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(999, 24)
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
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Host SMTP:"
        '
        'TbHostsmtp
        '
        Me.TbHostsmtp.Location = New System.Drawing.Point(151, 103)
        Me.TbHostsmtp.Name = "TbHostsmtp"
        Me.TbHostsmtp.Size = New System.Drawing.Size(201, 20)
        Me.TbHostsmtp.TabIndex = 2
        '
        'btenvia
        '
        Me.btenvia.Location = New System.Drawing.Point(912, 273)
        Me.btenvia.Name = "btenvia"
        Me.btenvia.Size = New System.Drawing.Size(75, 23)
        Me.btenvia.TabIndex = 8
        Me.btenvia.Text = "Enviar"
        Me.btenvia.UseVisualStyleBackColor = True
        '
        'tbdestinatario
        '
        Me.tbdestinatario.Location = New System.Drawing.Point(714, 80)
        Me.tbdestinatario.Name = "tbdestinatario"
        Me.tbdestinatario.Size = New System.Drawing.Size(273, 20)
        Me.tbdestinatario.TabIndex = 5
        '
        'tbasunto
        '
        Me.tbasunto.Location = New System.Drawing.Point(714, 106)
        Me.tbasunto.Name = "tbasunto"
        Me.tbasunto.Size = New System.Drawing.Size(273, 20)
        Me.tbasunto.TabIndex = 6
        '
        'tbmensaje
        '
        Me.tbmensaje.Location = New System.Drawing.Point(714, 132)
        Me.tbmensaje.Multiline = True
        Me.tbmensaje.Name = "tbmensaje"
        Me.tbmensaje.Size = New System.Drawing.Size(273, 120)
        Me.tbmensaje.TabIndex = 7
        '
        'btadjuntar
        '
        Me.btadjuntar.Location = New System.Drawing.Point(542, 273)
        Me.btadjuntar.Name = "btadjuntar"
        Me.btadjuntar.Size = New System.Drawing.Size(104, 23)
        Me.btadjuntar.TabIndex = 9
        Me.btadjuntar.Text = "Adjuntar Archivo"
        Me.btadjuntar.UseVisualStyleBackColor = True
        '
        'TbRuta
        '
        Me.TbRuta.Location = New System.Drawing.Point(652, 275)
        Me.TbRuta.Name = "TbRuta"
        Me.TbRuta.ReadOnly = True
        Me.TbRuta.Size = New System.Drawing.Size(233, 20)
        Me.TbRuta.TabIndex = 10
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ParametrosCorreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 625)
        Me.Controls.Add(Me.TbRuta)
        Me.Controls.Add(Me.btadjuntar)
        Me.Controls.Add(Me.tbmensaje)
        Me.Controls.Add(Me.tbasunto)
        Me.Controls.Add(Me.tbdestinatario)
        Me.Controls.Add(Me.btenvia)
        Me.Controls.Add(Me.TbHostsmtp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TbPuertosmtp)
        Me.Controls.Add(Me.TbPassword)
        Me.Controls.Add(Me.TbEmail)
        Me.Controls.Add(Me.CkConexionCifrada)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ParametrosCorreo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Parametros para envio de correo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CkConexionCifrada As CheckBox
    Friend WithEvents TbEmail As TextBox
    Friend WithEvents TbPassword As TextBox
    Friend WithEvents TbPuertosmtp As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents TbHostsmtp As TextBox
    Friend WithEvents btenvia As Button
    Friend WithEvents tbdestinatario As TextBox
    Friend WithEvents tbasunto As TextBox
    Friend WithEvents tbmensaje As TextBox
    Friend WithEvents btadjuntar As Button
    Friend WithEvents TbRuta As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
