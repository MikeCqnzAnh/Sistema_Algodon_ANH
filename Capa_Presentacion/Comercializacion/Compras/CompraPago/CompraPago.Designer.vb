<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CompraPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompraPago))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbTipoCambio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbPrecioQuintal = New System.Windows.Forms.TextBox()
        Me.TbIdProductor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbNombreProductor = New System.Windows.Forms.TextBox()
        Me.DgvResumenPagoPacas = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbTotalPacas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbTotalKilos = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbSubtotal = New System.Windows.Forms.TextBox()
        Me.TbTotalMxn = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GbPagoFinal = New System.Windows.Forms.GroupBox()
        Me.TbAnticipoDlls = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TbTotalDls = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TbSumaCastigo = New System.Windows.Forms.TextBox()
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.PagarItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnviarEmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpResumenDePacasItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpDetallesDeCompraItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpResumenDeLiquidacionesItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbCastigos = New System.Windows.Forms.GroupBox()
        Me.TbCastigoxresistencia = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TbCastigoxlargo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TbCastigoxUI = New System.Windows.Forms.TextBox()
        Me.TbCastigoxmicro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.TbIdCompra = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TbIdContrato = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.DgvResumenPagoPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbPagoFinal.SuspendLayout()
        Me.MSMenu.SuspendLayout()
        Me.GbCastigos.SuspendLayout()
        Me.GbDatosGenerales.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(695, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de cambio"
        '
        'TbTipoCambio
        '
        Me.TbTipoCambio.Location = New System.Drawing.Point(827, 103)
        Me.TbTipoCambio.Name = "TbTipoCambio"
        Me.TbTipoCambio.ReadOnly = True
        Me.TbTipoCambio.Size = New System.Drawing.Size(145, 29)
        Me.TbTipoCambio.TabIndex = 1
        Me.TbTipoCambio.Text = "0"
        Me.TbTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(652, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Precio quintal"
        '
        'TbPrecioQuintal
        '
        Me.TbPrecioQuintal.Enabled = False
        Me.TbPrecioQuintal.Location = New System.Drawing.Point(744, 57)
        Me.TbPrecioQuintal.Name = "TbPrecioQuintal"
        Me.TbPrecioQuintal.Size = New System.Drawing.Size(100, 20)
        Me.TbPrecioQuintal.TabIndex = 3
        '
        'TbIdProductor
        '
        Me.TbIdProductor.Enabled = False
        Me.TbIdProductor.Location = New System.Drawing.Point(99, 57)
        Me.TbIdProductor.Name = "TbIdProductor"
        Me.TbIdProductor.Size = New System.Drawing.Size(100, 20)
        Me.TbIdProductor.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Id Productor"
        '
        'TbNombreProductor
        '
        Me.TbNombreProductor.Enabled = False
        Me.TbNombreProductor.Location = New System.Drawing.Point(205, 57)
        Me.TbNombreProductor.Name = "TbNombreProductor"
        Me.TbNombreProductor.Size = New System.Drawing.Size(441, 20)
        Me.TbNombreProductor.TabIndex = 6
        '
        'DgvResumenPagoPacas
        '
        Me.DgvResumenPagoPacas.AllowUserToAddRows = False
        Me.DgvResumenPagoPacas.AllowUserToDeleteRows = False
        Me.DgvResumenPagoPacas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvResumenPagoPacas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvResumenPagoPacas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvResumenPagoPacas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvResumenPagoPacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvResumenPagoPacas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvResumenPagoPacas.Location = New System.Drawing.Point(7, 83)
        Me.DgvResumenPagoPacas.MultiSelect = False
        Me.DgvResumenPagoPacas.Name = "DgvResumenPagoPacas"
        Me.DgvResumenPagoPacas.ReadOnly = True
        Me.DgvResumenPagoPacas.RowHeadersVisible = False
        Me.DgvResumenPagoPacas.RowHeadersWidth = 40
        Me.DgvResumenPagoPacas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvResumenPagoPacas.Size = New System.Drawing.Size(1100, 326)
        Me.DgvResumenPagoPacas.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 18)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Total de pacas"
        '
        'TbTotalPacas
        '
        Me.TbTotalPacas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTotalPacas.Location = New System.Drawing.Point(9, 55)
        Me.TbTotalPacas.Name = "TbTotalPacas"
        Me.TbTotalPacas.ReadOnly = True
        Me.TbTotalPacas.Size = New System.Drawing.Size(212, 26)
        Me.TbTotalPacas.TabIndex = 15
        Me.TbTotalPacas.Text = "0"
        Me.TbTotalPacas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 18)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Total de kilos"
        '
        'TbTotalKilos
        '
        Me.TbTotalKilos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTotalKilos.Location = New System.Drawing.Point(9, 110)
        Me.TbTotalKilos.Name = "TbTotalKilos"
        Me.TbTotalKilos.ReadOnly = True
        Me.TbTotalKilos.Size = New System.Drawing.Size(212, 26)
        Me.TbTotalKilos.TabIndex = 17
        Me.TbTotalKilos.Text = "0"
        Me.TbTotalKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(104, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 18)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Subtotal Dls"
        '
        'TbSubtotal
        '
        Me.TbSubtotal.Location = New System.Drawing.Point(198, 25)
        Me.TbSubtotal.Name = "TbSubtotal"
        Me.TbSubtotal.ReadOnly = True
        Me.TbSubtotal.Size = New System.Drawing.Size(227, 29)
        Me.TbSubtotal.TabIndex = 23
        Me.TbSubtotal.Text = "0"
        Me.TbSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbTotalMxn
        '
        Me.TbTotalMxn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTotalMxn.Location = New System.Drawing.Point(737, 142)
        Me.TbTotalMxn.Multiline = True
        Me.TbTotalMxn.Name = "TbTotalMxn"
        Me.TbTotalMxn.ReadOnly = True
        Me.TbTotalMxn.Size = New System.Drawing.Size(235, 34)
        Me.TbTotalMxn.TabIndex = 25
        Me.TbTotalMxn.Text = "0"
        Me.TbTotalMxn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(599, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 31)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Total Mxn"
        '
        'GbPagoFinal
        '
        Me.GbPagoFinal.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GbPagoFinal.Controls.Add(Me.TbAnticipoDlls)
        Me.GbPagoFinal.Controls.Add(Me.Label11)
        Me.GbPagoFinal.Controls.Add(Me.TbSubtotal)
        Me.GbPagoFinal.Controls.Add(Me.Label18)
        Me.GbPagoFinal.Controls.Add(Me.Label10)
        Me.GbPagoFinal.Controls.Add(Me.Label1)
        Me.GbPagoFinal.Controls.Add(Me.TbTipoCambio)
        Me.GbPagoFinal.Controls.Add(Me.TbTotalDls)
        Me.GbPagoFinal.Controls.Add(Me.TbTotalMxn)
        Me.GbPagoFinal.Controls.Add(Me.Label17)
        Me.GbPagoFinal.Controls.Add(Me.Label8)
        Me.GbPagoFinal.Controls.Add(Me.TbSumaCastigo)
        Me.GbPagoFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbPagoFinal.Location = New System.Drawing.Point(7, 415)
        Me.GbPagoFinal.Name = "GbPagoFinal"
        Me.GbPagoFinal.Size = New System.Drawing.Size(1100, 195)
        Me.GbPagoFinal.TabIndex = 28
        Me.GbPagoFinal.TabStop = False
        Me.GbPagoFinal.Text = "Resumen de la compra"
        '
        'TbAnticipoDlls
        '
        Me.TbAnticipoDlls.Location = New System.Drawing.Point(198, 95)
        Me.TbAnticipoDlls.Name = "TbAnticipoDlls"
        Me.TbAnticipoDlls.Size = New System.Drawing.Size(228, 29)
        Me.TbAnticipoDlls.TabIndex = 31
        Me.TbAnticipoDlls.Text = "0"
        Me.TbAnticipoDlls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(103, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 18)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Ant. Dolares"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(53, 137)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(122, 31)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "Total Dls"
        '
        'TbTotalDls
        '
        Me.TbTotalDls.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTotalDls.Location = New System.Drawing.Point(191, 137)
        Me.TbTotalDls.Multiline = True
        Me.TbTotalDls.Name = "TbTotalDls"
        Me.TbTotalDls.ReadOnly = True
        Me.TbTotalDls.Size = New System.Drawing.Size(235, 34)
        Me.TbTotalDls.TabIndex = 25
        Me.TbTotalDls.Text = "0"
        Me.TbTotalDls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(67, 67)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(125, 18)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Castigo (Dolares)"
        '
        'TbSumaCastigo
        '
        Me.TbSumaCastigo.Location = New System.Drawing.Point(198, 60)
        Me.TbSumaCastigo.Name = "TbSumaCastigo"
        Me.TbSumaCastigo.ReadOnly = True
        Me.TbSumaCastigo.Size = New System.Drawing.Size(227, 29)
        Me.TbSumaCastigo.TabIndex = 21
        Me.TbSumaCastigo.Text = "0"
        Me.TbSumaCastigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MSMenu
        '
        Me.MSMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PagarItem, Me.EnviarEmailToolStripMenuItem, Me.ImpResumenDePacasItem, Me.ImpDetallesDeCompraItem, Me.ImpResumenDeLiquidacionesItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(1344, 24)
        Me.MSMenu.TabIndex = 29
        Me.MSMenu.Text = "MenuStrip1"
        '
        'PagarItem
        '
        Me.PagarItem.Name = "PagarItem"
        Me.PagarItem.Size = New System.Drawing.Size(49, 20)
        Me.PagarItem.Text = "Pagar"
        '
        'EnviarEmailToolStripMenuItem
        '
        Me.EnviarEmailToolStripMenuItem.Image = Global.Capa_Presentacion.My.Resources.Resources.attachment
        Me.EnviarEmailToolStripMenuItem.Name = "EnviarEmailToolStripMenuItem"
        Me.EnviarEmailToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.EnviarEmailToolStripMenuItem.Text = "Enviar Email"
        '
        'ImpResumenDePacasItem
        '
        Me.ImpResumenDePacasItem.Name = "ImpResumenDePacasItem"
        Me.ImpResumenDePacasItem.Size = New System.Drawing.Size(141, 20)
        Me.ImpResumenDePacasItem.Text = "Imp.Resumen de Pacas"
        '
        'ImpDetallesDeCompraItem
        '
        Me.ImpDetallesDeCompraItem.Name = "ImpDetallesDeCompraItem"
        Me.ImpDetallesDeCompraItem.Size = New System.Drawing.Size(146, 20)
        Me.ImpDetallesDeCompraItem.Text = "Imp.Detalles de Compra"
        '
        'ImpResumenDeLiquidacionesItem
        '
        Me.ImpResumenDeLiquidacionesItem.Name = "ImpResumenDeLiquidacionesItem"
        Me.ImpResumenDeLiquidacionesItem.Size = New System.Drawing.Size(184, 20)
        Me.ImpResumenDeLiquidacionesItem.Text = "Imp.Resumen de Liquidaciones"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GbCastigos
        '
        Me.GbCastigos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GbCastigos.Controls.Add(Me.TbCastigoxresistencia)
        Me.GbCastigos.Controls.Add(Me.Label14)
        Me.GbCastigos.Controls.Add(Me.TbCastigoxlargo)
        Me.GbCastigos.Controls.Add(Me.Label13)
        Me.GbCastigos.Controls.Add(Me.TbCastigoxUI)
        Me.GbCastigos.Controls.Add(Me.TbCastigoxmicro)
        Me.GbCastigos.Controls.Add(Me.Label6)
        Me.GbCastigos.Controls.Add(Me.Label12)
        Me.GbCastigos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbCastigos.Location = New System.Drawing.Point(1113, 415)
        Me.GbCastigos.Name = "GbCastigos"
        Me.GbCastigos.Size = New System.Drawing.Size(227, 195)
        Me.GbCastigos.TabIndex = 30
        Me.GbCastigos.TabStop = False
        Me.GbCastigos.Text = "Castigos"
        '
        'TbCastigoxresistencia
        '
        Me.TbCastigoxresistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCastigoxresistencia.Location = New System.Drawing.Point(9, 166)
        Me.TbCastigoxresistencia.Name = "TbCastigoxresistencia"
        Me.TbCastigoxresistencia.ReadOnly = True
        Me.TbCastigoxresistencia.Size = New System.Drawing.Size(212, 22)
        Me.TbCastigoxresistencia.TabIndex = 5
        Me.TbCastigoxresistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 150)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(151, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Castigo por resistencia de fibra"
        '
        'TbCastigoxlargo
        '
        Me.TbCastigoxlargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCastigoxlargo.Location = New System.Drawing.Point(9, 121)
        Me.TbCastigoxlargo.Name = "TbCastigoxlargo"
        Me.TbCastigoxlargo.ReadOnly = True
        Me.TbCastigoxlargo.Size = New System.Drawing.Size(212, 22)
        Me.TbCastigoxlargo.TabIndex = 3
        Me.TbCastigoxlargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 105)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Castigo por largo de fibra"
        '
        'TbCastigoxUI
        '
        Me.TbCastigoxUI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCastigoxUI.Location = New System.Drawing.Point(9, 38)
        Me.TbCastigoxUI.Name = "TbCastigoxUI"
        Me.TbCastigoxUI.ReadOnly = True
        Me.TbCastigoxUI.Size = New System.Drawing.Size(212, 22)
        Me.TbCastigoxUI.TabIndex = 1
        Me.TbCastigoxUI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbCastigoxmicro
        '
        Me.TbCastigoxmicro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCastigoxmicro.Location = New System.Drawing.Point(9, 76)
        Me.TbCastigoxmicro.Name = "TbCastigoxmicro"
        Me.TbCastigoxmicro.ReadOnly = True
        Me.TbCastigoxmicro.Size = New System.Drawing.Size(212, 22)
        Me.TbCastigoxmicro.TabIndex = 1
        Me.TbCastigoxmicro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Castigo por uniformidad"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Castigo por micros"
        '
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.BackColor = System.Drawing.Color.Gainsboro
        Me.GbDatosGenerales.Controls.Add(Me.Label4)
        Me.GbDatosGenerales.Controls.Add(Me.TbTotalPacas)
        Me.GbDatosGenerales.Controls.Add(Me.TbTotalKilos)
        Me.GbDatosGenerales.Controls.Add(Me.Label5)
        Me.GbDatosGenerales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbDatosGenerales.Location = New System.Drawing.Point(1113, 83)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(227, 326)
        Me.GbDatosGenerales.TabIndex = 6
        Me.GbDatosGenerales.TabStop = False
        Me.GbDatosGenerales.Text = "Datos Generales"
        '
        'TbIdCompra
        '
        Me.TbIdCompra.Enabled = False
        Me.TbIdCompra.Location = New System.Drawing.Point(99, 31)
        Me.TbIdCompra.Name = "TbIdCompra"
        Me.TbIdCompra.Size = New System.Drawing.Size(100, 20)
        Me.TbIdCompra.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(7, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 16)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Id Compra"
        '
        'TbIdContrato
        '
        Me.TbIdContrato.Enabled = False
        Me.TbIdContrato.Location = New System.Drawing.Point(744, 28)
        Me.TbIdContrato.Name = "TbIdContrato"
        Me.TbIdContrato.Size = New System.Drawing.Size(100, 20)
        Me.TbIdContrato.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(666, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 16)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Id Contrato"
        '
        'CompraPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1344, 615)
        Me.Controls.Add(Me.GbDatosGenerales)
        Me.Controls.Add(Me.GbPagoFinal)
        Me.Controls.Add(Me.GbCastigos)
        Me.Controls.Add(Me.DgvResumenPagoPacas)
        Me.Controls.Add(Me.TbNombreProductor)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbIdContrato)
        Me.Controls.Add(Me.TbIdCompra)
        Me.Controls.Add(Me.TbIdProductor)
        Me.Controls.Add(Me.TbPrecioQuintal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MSMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MSMenu
        Me.MaximizeBox = False
        Me.Name = "CompraPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Metodo de pago"
        CType(Me.DgvResumenPagoPacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbPagoFinal.ResumeLayout(False)
        Me.GbPagoFinal.PerformLayout()
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GbCastigos.ResumeLayout(False)
        Me.GbCastigos.PerformLayout()
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TbTipoCambio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbPrecioQuintal As TextBox
    Friend WithEvents TbIdProductor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TbNombreProductor As TextBox
    Friend WithEvents DgvResumenPagoPacas As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents TbTotalPacas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TbTotalKilos As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TbSubtotal As TextBox
    Friend WithEvents TbTotalMxn As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GbPagoFinal As GroupBox
    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents PagarItem As ToolStripMenuItem
    Friend WithEvents ImpResumenDePacasItem As ToolStripMenuItem
    Friend WithEvents ImpDetallesDeCompraItem As ToolStripMenuItem
    Friend WithEvents ImpResumenDeLiquidacionesItem As ToolStripMenuItem
    Friend WithEvents TbAnticipoDlls As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GbCastigos As GroupBox
    Friend WithEvents TbCastigoxresistencia As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TbCastigoxlargo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TbCastigoxmicro As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GbDatosGenerales As GroupBox
    Friend WithEvents TbIdCompra As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TbIdContrato As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TbSumaCastigo As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TbTotalDls As TextBox
    Friend WithEvents TbCastigoxUI As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents EnviarEmailToolStripMenuItem As ToolStripMenuItem
End Class
