﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CastigoLargoFibra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CastigoLargoFibra))
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbIdModoLargoFibraEncabezado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.DgvEncabezado = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvEquivalente = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.CargarExcelToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarSelecToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlantillaDeCargaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DgvLargoDetalle = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CargarExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarSelecToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlantillaDeCargaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbDescripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbTipoContrato = New System.Windows.Forms.ComboBox()
        Me.MSMenu.SuspendLayout()
        CType(Me.DgvEncabezado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvEquivalente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DgvLargoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(1291, 24)
        Me.MSMenu.TabIndex = 0
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
        'TbIdModoLargoFibraEncabezado
        '
        Me.TbIdModoLargoFibraEncabezado.Enabled = False
        Me.TbIdModoLargoFibraEncabezado.Location = New System.Drawing.Point(125, 19)
        Me.TbIdModoLargoFibraEncabezado.Name = "TbIdModoLargoFibraEncabezado"
        Me.TbIdModoLargoFibraEncabezado.Size = New System.Drawing.Size(100, 20)
        Me.TbIdModoLargoFibraEncabezado.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(252, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Estatus"
        '
        'CbEstatus
        '
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(300, 71)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.CbEstatus.TabIndex = 3
        '
        'DgvEncabezado
        '
        Me.DgvEncabezado.AllowUserToAddRows = False
        Me.DgvEncabezado.AllowUserToDeleteRows = False
        Me.DgvEncabezado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEncabezado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvEncabezado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEncabezado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvEncabezado.Location = New System.Drawing.Point(3, 16)
        Me.DgvEncabezado.Name = "DgvEncabezado"
        Me.DgvEncabezado.ReadOnly = True
        Me.DgvEncabezado.RowHeadersVisible = False
        Me.DgvEncabezado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEncabezado.Size = New System.Drawing.Size(1285, 201)
        Me.DgvEncabezado.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DgvEncabezado)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1291, 220)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modos de Castigo"
        '
        'DgvEquivalente
        '
        Me.DgvEquivalente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEquivalente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvEquivalente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEquivalente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvEquivalente.Location = New System.Drawing.Point(38, 40)
        Me.DgvEquivalente.Name = "DgvEquivalente"
        Me.DgvEquivalente.Size = New System.Drawing.Size(424, 375)
        Me.DgvEquivalente.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 351)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1291, 437)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DgvEquivalente)
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.Controls.Add(Me.MenuStrip2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(823, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(465, 418)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Equivalentes"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(3, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(35, 375)
        Me.Panel2.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.quit
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(3, 74)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(30, 30)
        Me.Button4.TabIndex = 1
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.add
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(3, 25)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 30)
        Me.Button3.TabIndex = 0
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarExcelToolStripMenuItem1, Me.EliminarSelecToolStripMenuItem1, Me.PlantillaDeCargaToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(459, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'CargarExcelToolStripMenuItem1
        '
        Me.CargarExcelToolStripMenuItem1.Image = Global.Capa_Presentacion.My.Resources.Resources.excel
        Me.CargarExcelToolStripMenuItem1.Name = "CargarExcelToolStripMenuItem1"
        Me.CargarExcelToolStripMenuItem1.Size = New System.Drawing.Size(100, 20)
        Me.CargarExcelToolStripMenuItem1.Text = "Cargar excel"
        '
        'EliminarSelecToolStripMenuItem1
        '
        Me.EliminarSelecToolStripMenuItem1.Image = Global.Capa_Presentacion.My.Resources.Resources.delete
        Me.EliminarSelecToolStripMenuItem1.Name = "EliminarSelecToolStripMenuItem1"
        Me.EliminarSelecToolStripMenuItem1.Size = New System.Drawing.Size(107, 20)
        Me.EliminarSelecToolStripMenuItem1.Text = "Eliminar selec"
        '
        'PlantillaDeCargaToolStripMenuItem1
        '
        Me.PlantillaDeCargaToolStripMenuItem1.Name = "PlantillaDeCargaToolStripMenuItem1"
        Me.PlantillaDeCargaToolStripMenuItem1.Size = New System.Drawing.Size(109, 20)
        Me.PlantillaDeCargaToolStripMenuItem1.Text = "Plantilla de carga"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DgvLargoDetalle)
        Me.GroupBox4.Controls.Add(Me.Panel1)
        Me.GroupBox4.Controls.Add(Me.MenuStrip1)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox4.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(820, 418)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Largos de Fibra"
        '
        'DgvLargoDetalle
        '
        Me.DgvLargoDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvLargoDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvLargoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLargoDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvLargoDetalle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvLargoDetalle.Location = New System.Drawing.Point(38, 40)
        Me.DgvLargoDetalle.MultiSelect = False
        Me.DgvLargoDetalle.Name = "DgvLargoDetalle"
        Me.DgvLargoDetalle.RowHeadersWidth = 40
        Me.DgvLargoDetalle.Size = New System.Drawing.Size(779, 375)
        Me.DgvLargoDetalle.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(3, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(35, 375)
        Me.Panel1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.quit
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(3, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 30)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Capa_Presentacion.My.Resources.Resources.add
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(3, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarExcelToolStripMenuItem, Me.EliminarSelecToolStripMenuItem, Me.PlantillaDeCargaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(814, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CargarExcelToolStripMenuItem
        '
        Me.CargarExcelToolStripMenuItem.Image = Global.Capa_Presentacion.My.Resources.Resources.excel
        Me.CargarExcelToolStripMenuItem.Name = "CargarExcelToolStripMenuItem"
        Me.CargarExcelToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.CargarExcelToolStripMenuItem.Text = "Cargar excel"
        '
        'EliminarSelecToolStripMenuItem
        '
        Me.EliminarSelecToolStripMenuItem.Image = Global.Capa_Presentacion.My.Resources.Resources.delete
        Me.EliminarSelecToolStripMenuItem.Name = "EliminarSelecToolStripMenuItem"
        Me.EliminarSelecToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.EliminarSelecToolStripMenuItem.Text = "Eliminar selec"
        '
        'PlantillaDeCargaToolStripMenuItem
        '
        Me.PlantillaDeCargaToolStripMenuItem.Name = "PlantillaDeCargaToolStripMenuItem"
        Me.PlantillaDeCargaToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.PlantillaDeCargaToolStripMenuItem.Text = "Plantilla de carga"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.TbDescripcion)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.CbTipoContrato)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.TbIdModoLargoFibraEncabezado)
        Me.GroupBox5.Controls.Add(Me.CbEstatus)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Location = New System.Drawing.Point(0, 24)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1291, 107)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Descripcion"
        '
        'TbDescripcion
        '
        Me.TbDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbDescripcion.Location = New System.Drawing.Point(125, 45)
        Me.TbDescripcion.Name = "TbDescripcion"
        Me.TbDescripcion.Size = New System.Drawing.Size(296, 20)
        Me.TbDescripcion.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Tipo Comercializacion"
        '
        'CbTipoContrato
        '
        Me.CbTipoContrato.FormattingEnabled = True
        Me.CbTipoContrato.Location = New System.Drawing.Point(125, 71)
        Me.CbTipoContrato.Name = "CbTipoContrato"
        Me.CbTipoContrato.Size = New System.Drawing.Size(121, 21)
        Me.CbTipoContrato.TabIndex = 2
        '
        'CastigoLargoFibra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1291, 788)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MSMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "CastigoLargoFibra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Castigo Por Largo de Fibra"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        CType(Me.DgvEncabezado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvEquivalente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DgvLargoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TbIdModoLargoFibraEncabezado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents DgvEncabezado As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgvEquivalente As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CbTipoContrato As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TbDescripcion As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CargarExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarSelecToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents CargarExcelToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EliminarSelecToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DgvLargoDetalle As DataGridView
    Friend WithEvents PlantillaDeCargaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PlantillaDeCargaToolStripMenuItem As ToolStripMenuItem
End Class
