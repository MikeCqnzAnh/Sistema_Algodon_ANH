<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Etiquetas
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
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbEtiquetaActual = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbIdProduccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbOrdenTrabajoInfo = New System.Windows.Forms.TextBox()
        Me.TbIdProduccionInfo = New System.Windows.Forms.TextBox()
        Me.CbPlanta = New System.Windows.Forms.ComboBox()
        Me.TbEtiquetaSiguiente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PControles = New System.Windows.Forms.Panel()
        Me.MSMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PControles.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(1109, 24)
        Me.MSMenu.TabIndex = 0
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
        'TbEtiquetaActual
        '
        Me.TbEtiquetaActual.Enabled = False
        Me.TbEtiquetaActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 54.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbEtiquetaActual.Location = New System.Drawing.Point(20, 86)
        Me.TbEtiquetaActual.Multiline = True
        Me.TbEtiquetaActual.Name = "TbEtiquetaActual"
        Me.TbEtiquetaActual.Size = New System.Drawing.Size(467, 120)
        Me.TbEtiquetaActual.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(482, 76)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Etiqueta Actual"
        '
        'TbIdProduccion
        '
        Me.TbIdProduccion.Location = New System.Drawing.Point(82, 13)
        Me.TbIdProduccion.Name = "TbIdProduccion"
        Me.TbIdProduccion.Size = New System.Drawing.Size(121, 20)
        Me.TbIdProduccion.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Id Produccion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(630, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ID Produccion"
        Me.Label1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "ID Orden de Trabajo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(446, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "ID Planta"
        '
        'TbOrdenTrabajoInfo
        '
        Me.TbOrdenTrabajoInfo.Enabled = False
        Me.TbOrdenTrabajoInfo.Location = New System.Drawing.Point(319, 13)
        Me.TbOrdenTrabajoInfo.Name = "TbOrdenTrabajoInfo"
        Me.TbOrdenTrabajoInfo.Size = New System.Drawing.Size(121, 20)
        Me.TbOrdenTrabajoInfo.TabIndex = 13
        '
        'TbIdProduccionInfo
        '
        Me.TbIdProduccionInfo.Enabled = False
        Me.TbIdProduccionInfo.Location = New System.Drawing.Point(711, 13)
        Me.TbIdProduccionInfo.Name = "TbIdProduccionInfo"
        Me.TbIdProduccionInfo.Size = New System.Drawing.Size(121, 20)
        Me.TbIdProduccionInfo.TabIndex = 14
        Me.TbIdProduccionInfo.Visible = False
        '
        'CbPlanta
        '
        Me.CbPlanta.Enabled = False
        Me.CbPlanta.FormattingEnabled = True
        Me.CbPlanta.Location = New System.Drawing.Point(503, 12)
        Me.CbPlanta.Name = "CbPlanta"
        Me.CbPlanta.Size = New System.Drawing.Size(121, 21)
        Me.CbPlanta.TabIndex = 15
        '
        'TbEtiquetaSiguiente
        '
        Me.TbEtiquetaSiguiente.Enabled = False
        Me.TbEtiquetaSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 54.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbEtiquetaSiguiente.Location = New System.Drawing.Point(20, 288)
        Me.TbEtiquetaSiguiente.Multiline = True
        Me.TbEtiquetaSiguiente.Name = "TbEtiquetaSiguiente"
        Me.TbEtiquetaSiguiente.Size = New System.Drawing.Size(467, 120)
        Me.TbEtiquetaSiguiente.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(573, 76)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Etiqueta Siguiente"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TbIdProduccion)
        Me.Panel1.Controls.Add(Me.TbIdProduccionInfo)
        Me.Panel1.Controls.Add(Me.CbPlanta)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TbOrdenTrabajoInfo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1109, 66)
        Me.Panel1.TabIndex = 16
        '
        'PControles
        '
        Me.PControles.Controls.Add(Me.TbEtiquetaSiguiente)
        Me.PControles.Controls.Add(Me.TbEtiquetaActual)
        Me.PControles.Controls.Add(Me.Label6)
        Me.PControles.Controls.Add(Me.Label2)
        Me.PControles.Location = New System.Drawing.Point(38, 115)
        Me.PControles.Name = "PControles"
        Me.PControles.Size = New System.Drawing.Size(573, 424)
        Me.PControles.TabIndex = 17
        '
        'Etiquetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1109, 722)
        Me.Controls.Add(Me.PControles)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MSMenu)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "Etiquetas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Etiquetas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PControles.ResumeLayout(False)
        Me.PControles.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TbEtiquetaActual As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbIdProduccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TbOrdenTrabajoInfo As TextBox
    Friend WithEvents TbIdProduccionInfo As TextBox
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CbPlanta As ComboBox
    Friend WithEvents TbEtiquetaSiguiente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PControles As Panel
End Class
