﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfiguraConexionInicial
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GbOrigen = New System.Windows.Forms.GroupBox()
        Me.BtCreaConexion = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbOrigenInstancia = New System.Windows.Forms.ComboBox()
        Me.TbOrigenUsuario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbOrigenPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbInstancia = New System.Windows.Forms.TextBox()
        Me.TbUsuario = New System.Windows.Forms.TextBox()
        Me.TbClave = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GbOrigen.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GbOrigen)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(337, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 403)
        Me.Panel1.TabIndex = 0
        '
        'GbOrigen
        '
        Me.GbOrigen.Controls.Add(Me.BtCreaConexion)
        Me.GbOrigen.Controls.Add(Me.Label4)
        Me.GbOrigen.Controls.Add(Me.CbOrigenInstancia)
        Me.GbOrigen.Controls.Add(Me.TbOrigenUsuario)
        Me.GbOrigen.Controls.Add(Me.Label6)
        Me.GbOrigen.Controls.Add(Me.TbOrigenPassword)
        Me.GbOrigen.Controls.Add(Me.Label5)
        Me.GbOrigen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbOrigen.Location = New System.Drawing.Point(0, 0)
        Me.GbOrigen.Name = "GbOrigen"
        Me.GbOrigen.Size = New System.Drawing.Size(360, 403)
        Me.GbOrigen.TabIndex = 4
        Me.GbOrigen.TabStop = False
        Me.GbOrigen.Text = "Instancia:"
        '
        'BtCreaConexion
        '
        Me.BtCreaConexion.Location = New System.Drawing.Point(188, 167)
        Me.BtCreaConexion.Name = "BtCreaConexion"
        Me.BtCreaConexion.Size = New System.Drawing.Size(108, 23)
        Me.BtCreaConexion.TabIndex = 3
        Me.BtCreaConexion.Text = "Crear Conexion"
        Me.BtCreaConexion.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Instancia:"
        '
        'CbOrigenInstancia
        '
        Me.CbOrigenInstancia.FormattingEnabled = True
        Me.CbOrigenInstancia.Location = New System.Drawing.Point(9, 83)
        Me.CbOrigenInstancia.Name = "CbOrigenInstancia"
        Me.CbOrigenInstancia.Size = New System.Drawing.Size(287, 21)
        Me.CbOrigenInstancia.TabIndex = 0
        '
        'TbOrigenUsuario
        '
        Me.TbOrigenUsuario.Location = New System.Drawing.Point(111, 110)
        Me.TbOrigenUsuario.Name = "TbOrigenUsuario"
        Me.TbOrigenUsuario.Size = New System.Drawing.Size(185, 20)
        Me.TbOrigenUsuario.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Contraseña:"
        '
        'TbOrigenPassword
        '
        Me.TbOrigenPassword.Location = New System.Drawing.Point(111, 136)
        Me.TbOrigenPassword.Name = "TbOrigenPassword"
        Me.TbOrigenPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbOrigenPassword.Size = New System.Drawing.Size(185, 20)
        Me.TbOrigenPassword.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nombre de usuario:"
        '
        'TbInstancia
        '
        Me.TbInstancia.Location = New System.Drawing.Point(124, 84)
        Me.TbInstancia.Name = "TbInstancia"
        Me.TbInstancia.Size = New System.Drawing.Size(185, 20)
        Me.TbInstancia.TabIndex = 1
        '
        'TbUsuario
        '
        Me.TbUsuario.Location = New System.Drawing.Point(124, 123)
        Me.TbUsuario.Name = "TbUsuario"
        Me.TbUsuario.Size = New System.Drawing.Size(185, 20)
        Me.TbUsuario.TabIndex = 1
        '
        'TbClave
        '
        Me.TbClave.Location = New System.Drawing.Point(124, 169)
        Me.TbClave.Name = "TbClave"
        Me.TbClave.Size = New System.Drawing.Size(185, 20)
        Me.TbClave.TabIndex = 1
        '
        'ConfiguraConexionInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 403)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TbClave)
        Me.Controls.Add(Me.TbUsuario)
        Me.Controls.Add(Me.TbInstancia)
        Me.Name = "ConfiguraConexionInicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configura la conexion inicial"
        Me.Panel1.ResumeLayout(False)
        Me.GbOrigen.ResumeLayout(False)
        Me.GbOrigen.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents TbInstancia As TextBox
    Friend WithEvents TbUsuario As TextBox
    Friend WithEvents TbClave As TextBox
End Class
