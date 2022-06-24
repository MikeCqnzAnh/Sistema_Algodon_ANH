<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigMic
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DgvMicrosEncabezado = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtCargaExcel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbTipoContrato = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbDescripcion = New System.Windows.Forms.TextBox()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.TbIdMicroEncabezado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MsMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlantillaExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DgvMicrosDetalle = New System.Windows.Forms.DataGridView()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DgvMicrosEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MsMenu.SuspendLayout()
        CType(Me.DgvMicrosDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DgvMicrosEncabezado)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 128)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1038, 218)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Modos de Castigo"
        '
        'DgvMicrosEncabezado
        '
        Me.DgvMicrosEncabezado.AllowUserToAddRows = False
        Me.DgvMicrosEncabezado.AllowUserToDeleteRows = False
        Me.DgvMicrosEncabezado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvMicrosEncabezado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvMicrosEncabezado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvMicrosEncabezado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvMicrosEncabezado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMicrosEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvMicrosEncabezado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvMicrosEncabezado.Location = New System.Drawing.Point(3, 16)
        Me.DgvMicrosEncabezado.MultiSelect = False
        Me.DgvMicrosEncabezado.Name = "DgvMicrosEncabezado"
        Me.DgvMicrosEncabezado.ReadOnly = True
        Me.DgvMicrosEncabezado.RowHeadersVisible = False
        Me.DgvMicrosEncabezado.RowHeadersWidth = 40
        Me.DgvMicrosEncabezado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMicrosEncabezado.Size = New System.Drawing.Size(1032, 199)
        Me.DgvMicrosEncabezado.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvMicrosDetalle)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 346)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1038, 465)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtCargaExcel)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1032, 67)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'BtCargaExcel
        '
        Me.BtCargaExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtCargaExcel.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.excel
        Me.BtCargaExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtCargaExcel.Location = New System.Drawing.Point(9, 16)
        Me.BtCargaExcel.Name = "BtCargaExcel"
        Me.BtCargaExcel.Size = New System.Drawing.Size(45, 45)
        Me.BtCargaExcel.TabIndex = 3
        Me.BtCargaExcel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CbTipoContrato)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TbDescripcion)
        Me.GroupBox1.Controls.Add(Me.CbEstatus)
        Me.GroupBox1.Controls.Add(Me.TbIdMicroEncabezado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1038, 104)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'CbTipoContrato
        '
        Me.CbTipoContrato.FormattingEnabled = True
        Me.CbTipoContrato.Location = New System.Drawing.Point(117, 70)
        Me.CbTipoContrato.Name = "CbTipoContrato"
        Me.CbTipoContrato.Size = New System.Drawing.Size(121, 21)
        Me.CbTipoContrato.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Tipo de Contrato"
        '
        'TbDescripcion
        '
        Me.TbDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbDescripcion.Location = New System.Drawing.Point(117, 44)
        Me.TbDescripcion.Name = "TbDescripcion"
        Me.TbDescripcion.Size = New System.Drawing.Size(309, 20)
        Me.TbDescripcion.TabIndex = 1
        '
        'CbEstatus
        '
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(305, 70)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.CbEstatus.TabIndex = 3
        '
        'TbIdMicroEncabezado
        '
        Me.TbIdMicroEncabezado.Enabled = False
        Me.TbIdMicroEncabezado.Location = New System.Drawing.Point(117, 18)
        Me.TbIdMicroEncabezado.Name = "TbIdMicroEncabezado"
        Me.TbIdMicroEncabezado.Size = New System.Drawing.Size(121, 20)
        Me.TbIdMicroEncabezado.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(257, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Estatus"
        '
        'MsMenu
        '
        Me.MsMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.PlantillaExcelToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MsMenu.Location = New System.Drawing.Point(0, 0)
        Me.MsMenu.Name = "MsMenu"
        Me.MsMenu.Size = New System.Drawing.Size(1038, 24)
        Me.MsMenu.TabIndex = 26
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
        'PlantillaExcelToolStripMenuItem
        '
        Me.PlantillaExcelToolStripMenuItem.Name = "PlantillaExcelToolStripMenuItem"
        Me.PlantillaExcelToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.PlantillaExcelToolStripMenuItem.Text = "Plantilla Excel"
        '
        'DgvMicrosDetalle
        '
        Me.DgvMicrosDetalle.AllowUserToAddRows = False
        Me.DgvMicrosDetalle.AllowUserToDeleteRows = False
        Me.DgvMicrosDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvMicrosDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvMicrosDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvMicrosDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvMicrosDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMicrosDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvMicrosDetalle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvMicrosDetalle.Location = New System.Drawing.Point(3, 83)
        Me.DgvMicrosDetalle.MultiSelect = False
        Me.DgvMicrosDetalle.Name = "DgvMicrosDetalle"
        Me.DgvMicrosDetalle.ReadOnly = True
        Me.DgvMicrosDetalle.RowHeadersVisible = False
        Me.DgvMicrosDetalle.RowHeadersWidth = 40
        Me.DgvMicrosDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMicrosDetalle.Size = New System.Drawing.Size(1032, 379)
        Me.DgvMicrosDetalle.TabIndex = 1
        '
        'ConfigMic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 811)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MsMenu)
        Me.Name = "ConfigMic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuracion de Micros"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DgvMicrosEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MsMenu.ResumeLayout(False)
        Me.MsMenu.PerformLayout()
        CType(Me.DgvMicrosDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DgvMicrosEncabezado As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtCargaExcel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CbTipoContrato As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbDescripcion As TextBox
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents TbIdMicroEncabezado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MsMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlantillaExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DgvMicrosDetalle As DataGridView
End Class
