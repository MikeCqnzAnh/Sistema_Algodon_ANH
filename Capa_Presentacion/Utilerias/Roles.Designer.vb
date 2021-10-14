<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Roles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Roles))
        Me.TVRoles = New System.Windows.Forms.TreeView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtAgregar = New System.Windows.Forms.Button()
        Me.TbIdNodo = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbIdPadre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbNombreNodo = New System.Windows.Forms.TextBox()
        Me.CkEstatus = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtDespliega = New System.Windows.Forms.Button()
        Me.BtContraer = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TVRoles
        '
        Me.TVRoles.CheckBoxes = True
        Me.TVRoles.Dock = System.Windows.Forms.DockStyle.Right
        Me.TVRoles.Location = New System.Drawing.Point(887, 24)
        Me.TVRoles.Name = "TVRoles"
        Me.TVRoles.Size = New System.Drawing.Size(412, 671)
        Me.TVRoles.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1299, 24)
        Me.MenuStrip1.TabIndex = 4
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
        'BtAgregar
        '
        Me.BtAgregar.Location = New System.Drawing.Point(589, 209)
        Me.BtAgregar.Name = "BtAgregar"
        Me.BtAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtAgregar.TabIndex = 4
        Me.BtAgregar.Text = "Agregar"
        Me.BtAgregar.UseVisualStyleBackColor = True
        '
        'TbIdNodo
        '
        Me.TbIdNodo.Enabled = False
        Me.TbIdNodo.Location = New System.Drawing.Point(100, 56)
        Me.TbIdNodo.Name = "TbIdNodo"
        Me.TbIdNodo.Size = New System.Drawing.Size(100, 20)
        Me.TbIdNodo.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(100, 101)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID nodo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre de nodo"
        '
        'TbIdPadre
        '
        Me.TbIdPadre.Location = New System.Drawing.Point(100, 144)
        Me.TbIdPadre.Name = "TbIdPadre"
        Me.TbIdPadre.Size = New System.Drawing.Size(100, 20)
        Me.TbIdPadre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID padre"
        '
        'TbNombreNodo
        '
        Me.TbNombreNodo.Location = New System.Drawing.Point(100, 101)
        Me.TbNombreNodo.Name = "TbNombreNodo"
        Me.TbNombreNodo.Size = New System.Drawing.Size(564, 20)
        Me.TbNombreNodo.TabIndex = 1
        '
        'CkEstatus
        '
        Me.CkEstatus.AutoSize = True
        Me.CkEstatus.Location = New System.Drawing.Point(206, 146)
        Me.CkEstatus.Name = "CkEstatus"
        Me.CkEstatus.Size = New System.Drawing.Size(61, 17)
        Me.CkEstatus.TabIndex = 3
        Me.CkEstatus.Text = "Estatus"
        Me.CkEstatus.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtDespliega)
        Me.Panel1.Controls.Add(Me.BtContraer)
        Me.Panel1.Controls.Add(Me.TbNombreNodo)
        Me.Panel1.Controls.Add(Me.BtAgregar)
        Me.Panel1.Controls.Add(Me.TbIdNodo)
        Me.Panel1.Controls.Add(Me.CkEstatus)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TbIdPadre)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(887, 253)
        Me.Panel1.TabIndex = 7
        '
        'BtDespliega
        '
        Me.BtDespliega.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtDespliega.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtDespliega.Location = New System.Drawing.Point(857, 3)
        Me.BtDespliega.MaximumSize = New System.Drawing.Size(30, 30)
        Me.BtDespliega.MinimumSize = New System.Drawing.Size(30, 30)
        Me.BtDespliega.Name = "BtDespliega"
        Me.BtDespliega.Size = New System.Drawing.Size(30, 30)
        Me.BtDespliega.TabIndex = 7
        Me.BtDespliega.Text = "+"
        Me.BtDespliega.UseVisualStyleBackColor = True
        '
        'BtContraer
        '
        Me.BtContraer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtContraer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtContraer.Location = New System.Drawing.Point(857, 39)
        Me.BtContraer.MaximumSize = New System.Drawing.Size(30, 30)
        Me.BtContraer.MinimumSize = New System.Drawing.Size(30, 30)
        Me.BtContraer.Name = "BtContraer"
        Me.BtContraer.Size = New System.Drawing.Size(30, 30)
        Me.BtContraer.TabIndex = 7
        Me.BtContraer.Text = "-"
        Me.BtContraer.UseVisualStyleBackColor = True
        '
        'Roles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 695)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TVRoles)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Roles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Roles"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TVRoles As TreeView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtAgregar As Button
    Friend WithEvents TbIdNodo As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TbIdPadre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbNombreNodo As TextBox
    Friend WithEvents CkEstatus As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtContraer As Button
    Friend WithEvents BtDespliega As Button
End Class
