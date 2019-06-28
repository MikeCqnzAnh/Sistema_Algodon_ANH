<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClasificacionVentaPaquetes
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
        Me.GbProductos = New System.Windows.Forms.GroupBox()
        Me.NuPromedioUI = New System.Windows.Forms.NumericUpDown()
        Me.chkfinalizado = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.TbIdPaquete = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbCantidadPacas = New System.Windows.Forms.TextBox()
        Me.TbDescripcion = New System.Windows.Forms.TextBox()
        Me.CbClases = New System.Windows.Forms.ComboBox()
        Me.TbNoPaca = New System.Windows.Forms.TextBox()
        Me.CbPlanta = New System.Windows.Forms.ComboBox()
        Me.BtIgualarClasificacion = New System.Windows.Forms.Button()
        Me.BtRevisarClases = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPacasSeleccionadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GbDgv = New System.Windows.Forms.GroupBox()
        Me.DgvPacasClasificacion1 = New Capa_Presentacion.ClasificacionVentaPaquetes.DgvPlus()
        Me.Sel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GbProductos.SuspendLayout()
        CType(Me.NuPromedioUI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GbDgv.SuspendLayout()
        CType(Me.DgvPacasClasificacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbProductos
        '
        Me.GbProductos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GbProductos.Controls.Add(Me.NuPromedioUI)
        Me.GbProductos.Controls.Add(Me.chkfinalizado)
        Me.GbProductos.Controls.Add(Me.Label8)
        Me.GbProductos.Controls.Add(Me.CbEstatus)
        Me.GbProductos.Controls.Add(Me.TbIdPaquete)
        Me.GbProductos.Controls.Add(Me.Label6)
        Me.GbProductos.Controls.Add(Me.TbCantidadPacas)
        Me.GbProductos.Controls.Add(Me.TbDescripcion)
        Me.GbProductos.Controls.Add(Me.CbClases)
        Me.GbProductos.Controls.Add(Me.TbNoPaca)
        Me.GbProductos.Controls.Add(Me.CbPlanta)
        Me.GbProductos.Controls.Add(Me.BtIgualarClasificacion)
        Me.GbProductos.Controls.Add(Me.BtRevisarClases)
        Me.GbProductos.Controls.Add(Me.Label3)
        Me.GbProductos.Controls.Add(Me.Label7)
        Me.GbProductos.Controls.Add(Me.Label5)
        Me.GbProductos.Controls.Add(Me.Label4)
        Me.GbProductos.Controls.Add(Me.Label2)
        Me.GbProductos.Controls.Add(Me.Label1)
        Me.GbProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbProductos.Location = New System.Drawing.Point(0, 24)
        Me.GbProductos.Name = "GbProductos"
        Me.GbProductos.Size = New System.Drawing.Size(1561, 109)
        Me.GbProductos.TabIndex = 0
        Me.GbProductos.TabStop = False
        '
        'NuPromedioUI
        '
        Me.NuPromedioUI.DecimalPlaces = 2
        Me.NuPromedioUI.Enabled = False
        Me.NuPromedioUI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuPromedioUI.Location = New System.Drawing.Point(561, 79)
        Me.NuPromedioUI.Name = "NuPromedioUI"
        Me.NuPromedioUI.Size = New System.Drawing.Size(91, 20)
        Me.NuPromedioUI.TabIndex = 11
        Me.NuPromedioUI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkfinalizado
        '
        Me.chkfinalizado.AutoSize = True
        Me.chkfinalizado.Location = New System.Drawing.Point(320, 82)
        Me.chkfinalizado.Name = "chkfinalizado"
        Me.chkfinalizado.Size = New System.Drawing.Size(118, 17)
        Me.chkfinalizado.TabIndex = 10
        Me.chkfinalizado.Text = "Paquete terminado."
        Me.chkfinalizado.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(250, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Estatus"
        '
        'CbEstatus
        '
        Me.CbEstatus.Enabled = False
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(320, 41)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.CbEstatus.TabIndex = 8
        '
        'TbIdPaquete
        '
        Me.TbIdPaquete.Location = New System.Drawing.Point(63, 13)
        Me.TbIdPaquete.Name = "TbIdPaquete"
        Me.TbIdPaquete.Size = New System.Drawing.Size(100, 20)
        Me.TbIdPaquete.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "ID"
        '
        'TbCantidadPacas
        '
        Me.TbCantidadPacas.Enabled = False
        Me.TbCantidadPacas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCantidadPacas.Location = New System.Drawing.Point(561, 41)
        Me.TbCantidadPacas.Name = "TbCantidadPacas"
        Me.TbCantidadPacas.Size = New System.Drawing.Size(91, 20)
        Me.TbCantidadPacas.TabIndex = 5
        Me.TbCantidadPacas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbDescripcion
        '
        Me.TbDescripcion.Enabled = False
        Me.TbDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbDescripcion.Location = New System.Drawing.Point(561, 13)
        Me.TbDescripcion.Multiline = True
        Me.TbDescripcion.Name = "TbDescripcion"
        Me.TbDescripcion.Size = New System.Drawing.Size(91, 20)
        Me.TbDescripcion.TabIndex = 5
        Me.TbDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CbClases
        '
        Me.CbClases.FormattingEnabled = True
        Me.CbClases.Location = New System.Drawing.Point(320, 13)
        Me.CbClases.Name = "CbClases"
        Me.CbClases.Size = New System.Drawing.Size(121, 21)
        Me.CbClases.TabIndex = 4
        '
        'TbNoPaca
        '
        Me.TbNoPaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNoPaca.Location = New System.Drawing.Point(63, 68)
        Me.TbNoPaca.Name = "TbNoPaca"
        Me.TbNoPaca.Size = New System.Drawing.Size(181, 35)
        Me.TbNoPaca.TabIndex = 3
        '
        'CbPlanta
        '
        Me.CbPlanta.FormattingEnabled = True
        Me.CbPlanta.Location = New System.Drawing.Point(63, 41)
        Me.CbPlanta.Name = "CbPlanta"
        Me.CbPlanta.Size = New System.Drawing.Size(181, 21)
        Me.CbPlanta.TabIndex = 2
        '
        'BtIgualarClasificacion
        '
        Me.BtIgualarClasificacion.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtIgualarClasificacion.Location = New System.Drawing.Point(1313, 16)
        Me.BtIgualarClasificacion.Name = "BtIgualarClasificacion"
        Me.BtIgualarClasificacion.Size = New System.Drawing.Size(126, 90)
        Me.BtIgualarClasificacion.TabIndex = 1
        Me.BtIgualarClasificacion.Text = "Igualar Clasificacion"
        Me.BtIgualarClasificacion.UseVisualStyleBackColor = True
        '
        'BtRevisarClases
        '
        Me.BtRevisarClases.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtRevisarClases.Location = New System.Drawing.Point(1439, 16)
        Me.BtRevisarClases.Name = "BtRevisarClases"
        Me.BtRevisarClases.Size = New System.Drawing.Size(119, 90)
        Me.BtRevisarClases.TabIndex = 1
        Me.BtRevisarClases.Text = "Revisar Clases De  Paquete"
        Me.BtRevisarClases.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(447, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Cantidad De Pacas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(447, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Descripcion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(250, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Clase"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "No. Paca"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Planta"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.ImprimirToolStripMenuItem, Me.EliminarPacasSeleccionadasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1561, 24)
        Me.MenuStrip1.TabIndex = 1
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
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.BuscarToolStripMenuItem.Text = "Consultar"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'EliminarPacasSeleccionadasToolStripMenuItem
        '
        Me.EliminarPacasSeleccionadasToolStripMenuItem.Name = "EliminarPacasSeleccionadasToolStripMenuItem"
        Me.EliminarPacasSeleccionadasToolStripMenuItem.Size = New System.Drawing.Size(172, 20)
        Me.EliminarPacasSeleccionadasToolStripMenuItem.Text = "Eliminar Pacas Seleccionadas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GbDgv
        '
        Me.GbDgv.Controls.Add(Me.DgvPacasClasificacion1)
        Me.GbDgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbDgv.Location = New System.Drawing.Point(0, 133)
        Me.GbDgv.Name = "GbDgv"
        Me.GbDgv.Size = New System.Drawing.Size(1561, 605)
        Me.GbDgv.TabIndex = 66
        Me.GbDgv.TabStop = False
        '
        'DgvPacasClasificacion1
        '
        Me.DgvPacasClasificacion1.AllowUserToAddRows = False
        Me.DgvPacasClasificacion1.AllowUserToDeleteRows = False
        Me.DgvPacasClasificacion1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvPacasClasificacion1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvPacasClasificacion1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvPacasClasificacion1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvPacasClasificacion1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPacasClasificacion1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvPacasClasificacion1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvPacasClasificacion1.Location = New System.Drawing.Point(3, 16)
        Me.DgvPacasClasificacion1.MultiSelect = False
        Me.DgvPacasClasificacion1.Name = "DgvPacasClasificacion1"
        Me.DgvPacasClasificacion1.RowHeadersVisible = False
        Me.DgvPacasClasificacion1.RowHeadersWidth = 40
        Me.DgvPacasClasificacion1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvPacasClasificacion1.Size = New System.Drawing.Size(1555, 586)
        Me.DgvPacasClasificacion1.TabIndex = 15
        '
        'Sel
        '
        Me.Sel.HeaderText = "Seleccion"
        Me.Sel.Name = "Sel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(447, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Promedio UI"
        '
        'ClasificacionVentaPaquetes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1561, 738)
        Me.Controls.Add(Me.GbDgv)
        Me.Controls.Add(Me.GbProductos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1090, 550)
        Me.Name = "ClasificacionVentaPaquetes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clasificacion de Venta "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbProductos.ResumeLayout(False)
        Me.GbProductos.PerformLayout()
        CType(Me.NuPromedioUI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GbDgv.ResumeLayout(False)
        CType(Me.DgvPacasClasificacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbProductos As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtIgualarClasificacion As Button
    Friend WithEvents BtRevisarClases As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TbNoPaca As TextBox
    Friend WithEvents CbPlanta As ComboBox
    Friend WithEvents CbClases As ComboBox
    Friend WithEvents TbCantidadPacas As TextBox
    Friend WithEvents TbDescripcion As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GbDgv As GroupBox
    Friend WithEvents EliminarPacasSeleccionadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Sel As DataGridViewCheckBoxColumn
    Friend WithEvents DgvPacasClasificacion1 As DgvPlus
    Friend WithEvents TbIdPaquete As TextBox

    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label

    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents chkfinalizado As CheckBox
    Friend WithEvents NuPromedioUI As NumericUpDown
    Friend WithEvents Label3 As Label

    Public Class DgvPlus
        Inherits DataGridView
        Protected Overrides Function ProcessDialogKey(keyData As Keys) As Boolean
            If keyData = Keys.Enter Then
                'If Me.CurrentCell.ColumnIndex = Me.ColumnCount - 1 Then
                ClasificacionVentaPaquetes.EditaFila()
                SendKeys.Send(Chr(Keys.Tab))
                ' ClasificacionVentaPaquetes.TextBox_PreviewKeyDown()
                Return True
                'End If
            Else
                Return MyBase.ProcessDialogKey(keyData)
            End If
        End Function

        Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
            If e.KeyData = Keys.Enter Then
                SendKeys.Send(Chr(Keys.Tab))
            Else
                MyBase.OnKeyDown(e)
            End If
        End Sub
    End Class
End Class
