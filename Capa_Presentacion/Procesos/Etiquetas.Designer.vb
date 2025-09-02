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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Etiquetas))
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbEtiquetaActual = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbPlantaOrigen = New System.Windows.Forms.ComboBox()
        Me.TbEtiquetaSiguiente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PControles = New System.Windows.Forms.Panel()
        Me.MSMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PControles.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ActualizarToolStripMenuItem, Me.SalirToolStripMenuItem})
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
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'TbEtiquetaActual
        '
        Me.TbEtiquetaActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbEtiquetaActual.Location = New System.Drawing.Point(3, 86)
        Me.TbEtiquetaActual.MaxLength = 10
        Me.TbEtiquetaActual.Multiline = True
        Me.TbEtiquetaActual.Name = "TbEtiquetaActual"
        Me.TbEtiquetaActual.Size = New System.Drawing.Size(618, 120)
        Me.TbEtiquetaActual.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(482, 76)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Etiqueta Actual"
        '
        'CbPlantaOrigen
        '
        Me.CbPlantaOrigen.Enabled = False
        Me.CbPlantaOrigen.FormattingEnabled = True
        Me.CbPlantaOrigen.Location = New System.Drawing.Point(69, 10)
        Me.CbPlantaOrigen.Name = "CbPlantaOrigen"
        Me.CbPlantaOrigen.Size = New System.Drawing.Size(174, 21)
        Me.CbPlantaOrigen.TabIndex = 15
        '
        'TbEtiquetaSiguiente
        '
        Me.TbEtiquetaSiguiente.Enabled = False
        Me.TbEtiquetaSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbEtiquetaSiguiente.Location = New System.Drawing.Point(3, 288)
        Me.TbEtiquetaSiguiente.MaxLength = 10
        Me.TbEtiquetaSiguiente.Multiline = True
        Me.TbEtiquetaSiguiente.Name = "TbEtiquetaSiguiente"
        Me.TbEtiquetaSiguiente.ReadOnly = True
        Me.TbEtiquetaSiguiente.Size = New System.Drawing.Size(618, 120)
        Me.TbEtiquetaSiguiente.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(573, 76)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Etiqueta Siguiente"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CbPlantaOrigen)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1109, 66)
        Me.Panel1.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "ID Planta"
        '
        'PControles
        '
        Me.PControles.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PControles.Controls.Add(Me.TbEtiquetaSiguiente)
        Me.PControles.Controls.Add(Me.TbEtiquetaActual)
        Me.PControles.Controls.Add(Me.Label6)
        Me.PControles.Controls.Add(Me.Label2)
        Me.PControles.Location = New System.Drawing.Point(249, 169)
        Me.PControles.Name = "PControles"
        Me.PControles.Size = New System.Drawing.Size(624, 424)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CbPlantaOrigen As ComboBox
    Friend WithEvents TbEtiquetaSiguiente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PControles As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
End Class
