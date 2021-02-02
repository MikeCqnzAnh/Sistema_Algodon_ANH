<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IntegraciondeCompras
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TbEmisorNombre = New System.Windows.Forms.TextBox()
        Me.TbUUID = New System.Windows.Forms.TextBox()
        Me.TbTotal = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.TbConceptos = New System.Windows.Forms.TextBox()
        Me.TbRfcEmisor = New System.Windows.Forms.TextBox()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.TbImporteDls = New System.Windows.Forms.TextBox()
        Me.TbCastigoDls = New System.Windows.Forms.TextBox()
        Me.TbSubTotalDls = New System.Windows.Forms.TextBox()
        Me.DtFechaActualizacion = New System.Windows.Forms.DateTimePicker()
        Me.DtFechaCreacion = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PanelCenter = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GbDetalleFactura = New System.Windows.Forms.GroupBox()
        Me.DgvData = New System.Windows.Forms.DataGridView()
        Me.GbFacturas = New System.Windows.Forms.GroupBox()
        Me.DgvFacturas = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Gb1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TbTotalFacturas = New System.Windows.Forms.TextBox()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.BtQuitarXML = New System.Windows.Forms.Button()
        Me.BtAgregaXML = New System.Windows.Forms.Button()
        Me.GuardarIntegracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.PanelCenter.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GbDetalleFactura.SuspendLayout()
        CType(Me.DgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbFacturas.SuspendLayout()
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Gb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.GuardarIntegracionToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1495, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.BuscarToolStripMenuItem.Text = "Consultar Compra"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'TbEmisorNombre
        '
        Me.TbEmisorNombre.Location = New System.Drawing.Point(1118, 107)
        Me.TbEmisorNombre.Name = "TbEmisorNombre"
        Me.TbEmisorNombre.Size = New System.Drawing.Size(365, 20)
        Me.TbEmisorNombre.TabIndex = 1
        '
        'TbUUID
        '
        Me.TbUUID.Location = New System.Drawing.Point(1118, 81)
        Me.TbUUID.Name = "TbUUID"
        Me.TbUUID.Size = New System.Drawing.Size(365, 20)
        Me.TbUUID.TabIndex = 2
        '
        'TbTotal
        '
        Me.TbTotal.Location = New System.Drawing.Point(1118, 55)
        Me.TbTotal.Name = "TbTotal"
        Me.TbTotal.Size = New System.Drawing.Size(365, 20)
        Me.TbTotal.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1037, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'TbConceptos
        '
        Me.TbConceptos.Location = New System.Drawing.Point(1118, 29)
        Me.TbConceptos.Name = "TbConceptos"
        Me.TbConceptos.Size = New System.Drawing.Size(365, 20)
        Me.TbConceptos.TabIndex = 5
        '
        'TbRfcEmisor
        '
        Me.TbRfcEmisor.Location = New System.Drawing.Point(1118, 3)
        Me.TbRfcEmisor.Name = "TbRfcEmisor"
        Me.TbRfcEmisor.Size = New System.Drawing.Size(365, 20)
        Me.TbRfcEmisor.TabIndex = 7
        '
        'PanelTop
        '
        Me.PanelTop.Controls.Add(Me.TbImporteDls)
        Me.PanelTop.Controls.Add(Me.TbCastigoDls)
        Me.PanelTop.Controls.Add(Me.TbSubTotalDls)
        Me.PanelTop.Controls.Add(Me.DtFechaActualizacion)
        Me.PanelTop.Controls.Add(Me.DtFechaCreacion)
        Me.PanelTop.Controls.Add(Me.Label7)
        Me.PanelTop.Controls.Add(Me.Label6)
        Me.PanelTop.Controls.Add(Me.Label10)
        Me.PanelTop.Controls.Add(Me.Label9)
        Me.PanelTop.Controls.Add(Me.Label5)
        Me.PanelTop.Controls.Add(Me.Label8)
        Me.PanelTop.Controls.Add(Me.Label4)
        Me.PanelTop.Controls.Add(Me.Label3)
        Me.PanelTop.Controls.Add(Me.Label2)
        Me.PanelTop.Controls.Add(Me.Label1)
        Me.PanelTop.Controls.Add(Me.TextBox6)
        Me.PanelTop.Controls.Add(Me.TextBox5)
        Me.PanelTop.Controls.Add(Me.TextBox4)
        Me.PanelTop.Controls.Add(Me.TextBox3)
        Me.PanelTop.Controls.Add(Me.TextBox2)
        Me.PanelTop.Controls.Add(Me.TextBox1)
        Me.PanelTop.Controls.Add(Me.TbRfcEmisor)
        Me.PanelTop.Controls.Add(Me.TbConceptos)
        Me.PanelTop.Controls.Add(Me.Button1)
        Me.PanelTop.Controls.Add(Me.TbTotal)
        Me.PanelTop.Controls.Add(Me.TbUUID)
        Me.PanelTop.Controls.Add(Me.TbEmisorNombre)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 24)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1495, 164)
        Me.PanelTop.TabIndex = 8
        '
        'TbImporteDls
        '
        Me.TbImporteDls.Location = New System.Drawing.Point(543, 107)
        Me.TbImporteDls.Name = "TbImporteDls"
        Me.TbImporteDls.Size = New System.Drawing.Size(100, 20)
        Me.TbImporteDls.TabIndex = 19
        '
        'TbCastigoDls
        '
        Me.TbCastigoDls.Location = New System.Drawing.Point(543, 81)
        Me.TbCastigoDls.Name = "TbCastigoDls"
        Me.TbCastigoDls.Size = New System.Drawing.Size(100, 20)
        Me.TbCastigoDls.TabIndex = 18
        '
        'TbSubTotalDls
        '
        Me.TbSubTotalDls.Location = New System.Drawing.Point(543, 55)
        Me.TbSubTotalDls.Name = "TbSubTotalDls"
        Me.TbSubTotalDls.Size = New System.Drawing.Size(100, 20)
        Me.TbSubTotalDls.TabIndex = 17
        '
        'DtFechaActualizacion
        '
        Me.DtFechaActualizacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaActualizacion.Location = New System.Drawing.Point(302, 107)
        Me.DtFechaActualizacion.Name = "DtFechaActualizacion"
        Me.DtFechaActualizacion.Size = New System.Drawing.Size(101, 20)
        Me.DtFechaActualizacion.TabIndex = 16
        '
        'DtFechaCreacion
        '
        Me.DtFechaCreacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaCreacion.Location = New System.Drawing.Point(302, 78)
        Me.DtFechaCreacion.Name = "DtFechaCreacion"
        Me.DtFechaCreacion.Size = New System.Drawing.Size(101, 20)
        Me.DtFechaCreacion.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(199, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Actualizacion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(199, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Fecha de Creacion"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(476, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Subtotal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(476, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Castigo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "No. Pacas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(476, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Importe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Precio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "ID Contrato"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Productor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "ID Compra"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(75, 107)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 13
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(75, 81)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 12
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(75, 55)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(181, 29)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(280, 20)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(75, 29)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(75, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 8
        '
        'PanelCenter
        '
        Me.PanelCenter.Controls.Add(Me.Panel3)
        Me.PanelCenter.Controls.Add(Me.Gb1)
        Me.PanelCenter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCenter.Location = New System.Drawing.Point(0, 188)
        Me.PanelCenter.Name = "PanelCenter"
        Me.PanelCenter.Size = New System.Drawing.Size(1495, 358)
        Me.PanelCenter.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GbDetalleFactura)
        Me.Panel3.Controls.Add(Me.GbFacturas)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 175)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1495, 183)
        Me.Panel3.TabIndex = 0
        '
        'GbDetalleFactura
        '
        Me.GbDetalleFactura.Controls.Add(Me.DgvData)
        Me.GbDetalleFactura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbDetalleFactura.Location = New System.Drawing.Point(912, 0)
        Me.GbDetalleFactura.Name = "GbDetalleFactura"
        Me.GbDetalleFactura.Size = New System.Drawing.Size(583, 183)
        Me.GbDetalleFactura.TabIndex = 1
        Me.GbDetalleFactura.TabStop = False
        Me.GbDetalleFactura.Text = "Detalles de facturas"
        '
        'DgvData
        '
        Me.DgvData.AllowUserToAddRows = False
        Me.DgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvData.Location = New System.Drawing.Point(3, 16)
        Me.DgvData.Name = "DgvData"
        Me.DgvData.ReadOnly = True
        Me.DgvData.Size = New System.Drawing.Size(577, 164)
        Me.DgvData.TabIndex = 7
        '
        'GbFacturas
        '
        Me.GbFacturas.Controls.Add(Me.DgvFacturas)
        Me.GbFacturas.Controls.Add(Me.Panel1)
        Me.GbFacturas.Dock = System.Windows.Forms.DockStyle.Left
        Me.GbFacturas.Location = New System.Drawing.Point(0, 0)
        Me.GbFacturas.Name = "GbFacturas"
        Me.GbFacturas.Size = New System.Drawing.Size(912, 183)
        Me.GbFacturas.TabIndex = 0
        Me.GbFacturas.TabStop = False
        Me.GbFacturas.Text = "Facturas"
        '
        'DgvFacturas
        '
        Me.DgvFacturas.AllowUserToAddRows = False
        Me.DgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvFacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvFacturas.Location = New System.Drawing.Point(3, 16)
        Me.DgvFacturas.MultiSelect = False
        Me.DgvFacturas.Name = "DgvFacturas"
        Me.DgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvFacturas.Size = New System.Drawing.Size(869, 164)
        Me.DgvFacturas.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtQuitarXML)
        Me.Panel1.Controls.Add(Me.BtAgregaXML)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(872, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(37, 164)
        Me.Panel1.TabIndex = 2
        '
        'Gb1
        '
        Me.Gb1.Controls.Add(Me.Label11)
        Me.Gb1.Controls.Add(Me.TbTotalFacturas)
        Me.Gb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Gb1.Location = New System.Drawing.Point(0, 0)
        Me.Gb1.Name = "Gb1"
        Me.Gb1.Size = New System.Drawing.Size(1495, 175)
        Me.Gb1.TabIndex = 1
        Me.Gb1.TabStop = False
        Me.Gb1.Text = "Compra"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(108, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Total de facturas"
        '
        'TbTotalFacturas
        '
        Me.TbTotalFacturas.Location = New System.Drawing.Point(201, 47)
        Me.TbTotalFacturas.Name = "TbTotalFacturas"
        Me.TbTotalFacturas.Size = New System.Drawing.Size(100, 20)
        Me.TbTotalFacturas.TabIndex = 0
        '
        'PanelBottom
        '
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 546)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(1495, 190)
        Me.PanelBottom.TabIndex = 0
        '
        'BtQuitarXML
        '
        Me.BtQuitarXML.Image = Global.Capa_Presentacion.My.Resources.Resources.quit
        Me.BtQuitarXML.Location = New System.Drawing.Point(2, 43)
        Me.BtQuitarXML.Name = "BtQuitarXML"
        Me.BtQuitarXML.Size = New System.Drawing.Size(32, 33)
        Me.BtQuitarXML.TabIndex = 2
        Me.BtQuitarXML.UseVisualStyleBackColor = True
        '
        'BtAgregaXML
        '
        Me.BtAgregaXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtAgregaXML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtAgregaXML.Image = Global.Capa_Presentacion.My.Resources.Resources.add
        Me.BtAgregaXML.Location = New System.Drawing.Point(2, 3)
        Me.BtAgregaXML.Name = "BtAgregaXML"
        Me.BtAgregaXML.Size = New System.Drawing.Size(32, 33)
        Me.BtAgregaXML.TabIndex = 1
        Me.BtAgregaXML.UseVisualStyleBackColor = True
        '
        'GuardarIntegracionToolStripMenuItem
        '
        Me.GuardarIntegracionToolStripMenuItem.Name = "GuardarIntegracionToolStripMenuItem"
        Me.GuardarIntegracionToolStripMenuItem.Size = New System.Drawing.Size(124, 20)
        Me.GuardarIntegracionToolStripMenuItem.Text = "Guardar Integracion"
        '
        'IntegraciondeCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1495, 736)
        Me.Controls.Add(Me.PanelCenter)
        Me.Controls.Add(Me.PanelBottom)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "IntegraciondeCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Integracion de Compras"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.PanelCenter.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GbDetalleFactura.ResumeLayout(False)
        CType(Me.DgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbFacturas.ResumeLayout(False)
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Gb1.ResumeLayout(False)
        Me.Gb1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TbEmisorNombre As TextBox
    Friend WithEvents TbUUID As TextBox
    Friend WithEvents TbTotal As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents TbConceptos As TextBox
    Friend WithEvents TbRfcEmisor As TextBox
    Friend WithEvents PanelTop As Panel
    Friend WithEvents PanelCenter As Panel
    Friend WithEvents Gb1 As GroupBox
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GbDetalleFactura As GroupBox
    Friend WithEvents GbFacturas As GroupBox
    Friend WithEvents DgvData As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtAgregaXML As Button
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DtFechaActualizacion As DateTimePicker
    Friend WithEvents DtFechaCreacion As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TbImporteDls As TextBox
    Friend WithEvents TbCastigoDls As TextBox
    Friend WithEvents TbSubTotalDls As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DgvFacturas As DataGridView
    Friend WithEvents TbTotalFacturas As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents BtQuitarXML As Button
    Friend WithEvents GuardarIntegracionToolStripMenuItem As ToolStripMenuItem
End Class
