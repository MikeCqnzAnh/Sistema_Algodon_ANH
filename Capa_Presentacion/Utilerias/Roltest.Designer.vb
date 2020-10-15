<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Roltest
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Roltest))
        Me.IconsImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.StateImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.TvRoles = New System.Windows.Forms.TreeView()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'IconsImageList
        '
        Me.IconsImageList.ImageStream = CType(resources.GetObject("IconsImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IconsImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.IconsImageList.Images.SetKeyName(0, "ImageComputer.ico")
        Me.IconsImageList.Images.SetKeyName(1, "ImageFile.ico")
        Me.IconsImageList.Images.SetKeyName(2, "ImageFolder.ico")
        '
        'StateImageList
        '
        Me.StateImageList.ImageStream = CType(resources.GetObject("StateImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.StateImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.StateImageList.Images.SetKeyName(0, "ImageStateNone.bmp")
        Me.StateImageList.Images.SetKeyName(1, "ImageStateUnchecked.bmp")
        Me.StateImageList.Images.SetKeyName(2, "ImageStateChecked.bmp")
        Me.StateImageList.Images.SetKeyName(3, "ImageStateIndeterminate.bmp")
        Me.StateImageList.Images.SetKeyName(4, "ImageStatePath.bmp")
        '
        'TvRoles
        '
        Me.TvRoles.CheckBoxes = True
        Me.TvRoles.Location = New System.Drawing.Point(344, 12)
        Me.TvRoles.Name = "TvRoles"
        Me.TvRoles.Size = New System.Drawing.Size(390, 688)
        Me.TvRoles.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.CheckBoxes = True
        Me.TreeView1.Location = New System.Drawing.Point(748, 12)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(390, 688)
        Me.TreeView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(253, 677)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Roltest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 712)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.TvRoles)
        Me.Name = "Roltest"
        Me.Tag = "0,0"
        Me.Text = "Roltest"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents IconsImageList As ImageList
    Friend WithEvents StateImageList As ImageList
    Friend WithEvents TvRoles As TreeView
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Button1 As Button
End Class
