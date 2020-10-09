<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentaPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentaPago))
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbUnidadPeso = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbTotalPacas = New System.Windows.Forms.TextBox()
        Me.TbTotalKilos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GbPagoFinal = New System.Windows.Forms.GroupBox()
        Me.TbAnticipoDlls = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TbSubtotal = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbTipoCambio = New System.Windows.Forms.TextBox()
        Me.TbTotalDls = New System.Windows.Forms.TextBox()
        Me.TbTotalMxn = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbSumaCastigo = New System.Windows.Forms.TextBox()
        Me.GbCastigos = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TbBerkLevel1 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TbPrepLevel1 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TbOtherLevel1 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TbPlasticLevel1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TbCastigoxresistencia = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbCastigoxmicro = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TbCastigoxUI = New System.Windows.Forms.TextBox()
        Me.TbCastigoxlargo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TbBerkLevel2 = New System.Windows.Forms.TextBox()
        Me.TbPrepLevel2 = New System.Windows.Forms.TextBox()
        Me.TbOtherLevel2 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TbPlasticLevel2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DgvResumenPagoPacas = New System.Windows.Forms.DataGridView()
        Me.TbNombreComprador = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbIdContrato = New System.Windows.Forms.TextBox()
        Me.TbIdVenta = New System.Windows.Forms.TextBox()
        Me.TbIdComprador = New System.Windows.Forms.TextBox()
        Me.TbPrecioQuintal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.PagarItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpResumenDePacasItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpDetallesDeVentaItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImpResumenDeLiquidacionesItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GbDatosGenerales.SuspendLayout()
        Me.GbPagoFinal.SuspendLayout()
        Me.GbCastigos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvResumenPagoPacas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MSMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.BackColor = System.Drawing.Color.Gainsboro
        Me.GbDatosGenerales.Controls.Add(Me.Label7)
        Me.GbDatosGenerales.Controls.Add(Me.CbUnidadPeso)
        Me.GbDatosGenerales.Controls.Add(Me.Label4)
        Me.GbDatosGenerales.Controls.Add(Me.TbTotalPacas)
        Me.GbDatosGenerales.Controls.Add(Me.TbTotalKilos)
        Me.GbDatosGenerales.Controls.Add(Me.Label5)
        Me.GbDatosGenerales.Dock = System.Windows.Forms.DockStyle.Right
        Me.GbDatosGenerales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbDatosGenerales.Location = New System.Drawing.Point(1258, 0)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(244, 402)
        Me.GbDatosGenerales.TabIndex = 39
        Me.GbDatosGenerales.TabStop = False
        Me.GbDatosGenerales.Text = "Datos Generales"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 18)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Unidad de Peso"
        '
        'CbUnidadPeso
        '
        Me.CbUnidadPeso.Enabled = False
        Me.CbUnidadPeso.FormattingEnabled = True
        Me.CbUnidadPeso.Location = New System.Drawing.Point(9, 105)
        Me.CbUnidadPeso.Name = "CbUnidadPeso"
        Me.CbUnidadPeso.Size = New System.Drawing.Size(212, 28)
        Me.CbUnidadPeso.TabIndex = 59
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
        'TbTotalKilos
        '
        Me.TbTotalKilos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTotalKilos.Location = New System.Drawing.Point(9, 157)
        Me.TbTotalKilos.Name = "TbTotalKilos"
        Me.TbTotalKilos.ReadOnly = True
        Me.TbTotalKilos.Size = New System.Drawing.Size(212, 26)
        Me.TbTotalKilos.TabIndex = 17
        Me.TbTotalKilos.Text = "0"
        Me.TbTotalKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 18)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Total de Peso"
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
        Me.GbPagoFinal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbPagoFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbPagoFinal.Location = New System.Drawing.Point(0, 0)
        Me.GbPagoFinal.Name = "GbPagoFinal"
        Me.GbPagoFinal.Size = New System.Drawing.Size(1118, 227)
        Me.GbPagoFinal.TabIndex = 42
        Me.GbPagoFinal.TabStop = False
        Me.GbPagoFinal.Text = "Resumen de la compra"
        '
        'TbAnticipoDlls
        '
        Me.TbAnticipoDlls.Location = New System.Drawing.Point(151, 114)
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
        Me.Label11.Location = New System.Drawing.Point(56, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 18)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Ant. Dolares"
        '
        'TbSubtotal
        '
        Me.TbSubtotal.Location = New System.Drawing.Point(151, 44)
        Me.TbSubtotal.Name = "TbSubtotal"
        Me.TbSubtotal.ReadOnly = True
        Me.TbSubtotal.Size = New System.Drawing.Size(227, 29)
        Me.TbSubtotal.TabIndex = 23
        Me.TbSubtotal.Text = "0"
        Me.TbSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 156)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(122, 31)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "Total Dls"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(405, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 31)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Total Mxn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(501, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de cambio"
        '
        'TbTipoCambio
        '
        Me.TbTipoCambio.Location = New System.Drawing.Point(633, 117)
        Me.TbTipoCambio.Name = "TbTipoCambio"
        Me.TbTipoCambio.ReadOnly = True
        Me.TbTipoCambio.Size = New System.Drawing.Size(145, 29)
        Me.TbTipoCambio.TabIndex = 1
        Me.TbTipoCambio.Text = "0"
        Me.TbTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbTotalDls
        '
        Me.TbTotalDls.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTotalDls.Location = New System.Drawing.Point(144, 156)
        Me.TbTotalDls.Multiline = True
        Me.TbTotalDls.Name = "TbTotalDls"
        Me.TbTotalDls.ReadOnly = True
        Me.TbTotalDls.Size = New System.Drawing.Size(235, 34)
        Me.TbTotalDls.TabIndex = 25
        Me.TbTotalDls.Text = "0"
        Me.TbTotalDls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbTotalMxn
        '
        Me.TbTotalMxn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTotalMxn.Location = New System.Drawing.Point(543, 156)
        Me.TbTotalMxn.Multiline = True
        Me.TbTotalMxn.Name = "TbTotalMxn"
        Me.TbTotalMxn.ReadOnly = True
        Me.TbTotalMxn.Size = New System.Drawing.Size(235, 34)
        Me.TbTotalMxn.TabIndex = 25
        Me.TbTotalMxn.Text = "0"
        Me.TbTotalMxn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(20, 86)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(125, 18)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Castigo (Dolares)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(57, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 18)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Subtotal Dls"
        '
        'TbSumaCastigo
        '
        Me.TbSumaCastigo.Location = New System.Drawing.Point(151, 79)
        Me.TbSumaCastigo.Name = "TbSumaCastigo"
        Me.TbSumaCastigo.ReadOnly = True
        Me.TbSumaCastigo.Size = New System.Drawing.Size(227, 29)
        Me.TbSumaCastigo.TabIndex = 21
        Me.TbSumaCastigo.Text = "0"
        Me.TbSumaCastigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GbCastigos
        '
        Me.GbCastigos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GbCastigos.Controls.Add(Me.GroupBox2)
        Me.GbCastigos.Controls.Add(Me.GroupBox3)
        Me.GbCastigos.Controls.Add(Me.GroupBox1)
        Me.GbCastigos.Dock = System.Windows.Forms.DockStyle.Right
        Me.GbCastigos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbCastigos.Location = New System.Drawing.Point(1118, 0)
        Me.GbCastigos.Name = "GbCastigos"
        Me.GbCastigos.Size = New System.Drawing.Size(384, 227)
        Me.GbCastigos.TabIndex = 44
        Me.GbCastigos.TabStop = False
        Me.GbCastigos.Text = "Castigos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.TbBerkLevel1)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.TbPrepLevel1)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.TbOtherLevel1)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.TbPlasticLevel1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(110, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(136, 202)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mat. Ext. Nivel 1"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label22.Location = New System.Drawing.Point(6, 23)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(32, 15)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "Bark"
        '
        'TbBerkLevel1
        '
        Me.TbBerkLevel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbBerkLevel1.Location = New System.Drawing.Point(9, 41)
        Me.TbBerkLevel1.Name = "TbBerkLevel1"
        Me.TbBerkLevel1.ReadOnly = True
        Me.TbBerkLevel1.Size = New System.Drawing.Size(84, 22)
        Me.TbBerkLevel1.TabIndex = 10
        Me.TbBerkLevel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label25.Location = New System.Drawing.Point(6, 151)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(43, 15)
        Me.Label25.TabIndex = 15
        Me.Label25.Text = "Plastic"
        '
        'TbPrepLevel1
        '
        Me.TbPrepLevel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbPrepLevel1.Location = New System.Drawing.Point(9, 79)
        Me.TbPrepLevel1.Name = "TbPrepLevel1"
        Me.TbPrepLevel1.ReadOnly = True
        Me.TbPrepLevel1.Size = New System.Drawing.Size(84, 22)
        Me.TbPrepLevel1.TabIndex = 11
        Me.TbPrepLevel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label24.Location = New System.Drawing.Point(6, 106)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(37, 15)
        Me.Label24.TabIndex = 15
        Me.Label24.Text = "Other"
        '
        'TbOtherLevel1
        '
        Me.TbOtherLevel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbOtherLevel1.Location = New System.Drawing.Point(9, 124)
        Me.TbOtherLevel1.Name = "TbOtherLevel1"
        Me.TbOtherLevel1.ReadOnly = True
        Me.TbOtherLevel1.Size = New System.Drawing.Size(84, 22)
        Me.TbOtherLevel1.TabIndex = 12
        Me.TbOtherLevel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label23.Location = New System.Drawing.Point(6, 63)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(33, 15)
        Me.Label23.TabIndex = 15
        Me.Label23.Text = "Prep"
        '
        'TbPlasticLevel1
        '
        Me.TbPlasticLevel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbPlasticLevel1.Location = New System.Drawing.Point(9, 169)
        Me.TbPlasticLevel1.Name = "TbPlasticLevel1"
        Me.TbPlasticLevel1.ReadOnly = True
        Me.TbPlasticLevel1.Size = New System.Drawing.Size(84, 22)
        Me.TbPlasticLevel1.TabIndex = 13
        Me.TbPlasticLevel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TbCastigoxresistencia)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TbCastigoxmicro)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.TbCastigoxUI)
        Me.GroupBox3.Controls.Add(Me.TbCastigoxlargo)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox3.Location = New System.Drawing.Point(3, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(107, 202)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        '
        'TbCastigoxresistencia
        '
        Me.TbCastigoxresistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCastigoxresistencia.Location = New System.Drawing.Point(6, 169)
        Me.TbCastigoxresistencia.Name = "TbCastigoxresistencia"
        Me.TbCastigoxresistencia.ReadOnly = True
        Me.TbCastigoxresistencia.Size = New System.Drawing.Size(84, 22)
        Me.TbCastigoxresistencia.TabIndex = 5
        Me.TbCastigoxresistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Micros"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Uniformidad"
        '
        'TbCastigoxmicro
        '
        Me.TbCastigoxmicro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCastigoxmicro.Location = New System.Drawing.Point(6, 79)
        Me.TbCastigoxmicro.Name = "TbCastigoxmicro"
        Me.TbCastigoxmicro.ReadOnly = True
        Me.TbCastigoxmicro.Size = New System.Drawing.Size(84, 22)
        Me.TbCastigoxmicro.TabIndex = 1
        Me.TbCastigoxmicro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 153)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Resistencia de fibra"
        '
        'TbCastigoxUI
        '
        Me.TbCastigoxUI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCastigoxUI.Location = New System.Drawing.Point(6, 41)
        Me.TbCastigoxUI.Name = "TbCastigoxUI"
        Me.TbCastigoxUI.ReadOnly = True
        Me.TbCastigoxUI.Size = New System.Drawing.Size(84, 22)
        Me.TbCastigoxUI.TabIndex = 1
        Me.TbCastigoxUI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbCastigoxlargo
        '
        Me.TbCastigoxlargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbCastigoxlargo.Location = New System.Drawing.Point(6, 124)
        Me.TbCastigoxlargo.Name = "TbCastigoxlargo"
        Me.TbCastigoxlargo.ReadOnly = True
        Me.TbCastigoxlargo.Size = New System.Drawing.Size(84, 22)
        Me.TbCastigoxlargo.TabIndex = 3
        Me.TbCastigoxlargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Largo de fibra"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TbBerkLevel2)
        Me.GroupBox1.Controls.Add(Me.TbPrepLevel2)
        Me.GroupBox1.Controls.Add(Me.TbOtherLevel2)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.TbPlasticLevel2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Location = New System.Drawing.Point(246, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(135, 202)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mat. Ext. Nivel 2"
        '
        'TbBerkLevel2
        '
        Me.TbBerkLevel2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbBerkLevel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbBerkLevel2.Location = New System.Drawing.Point(9, 40)
        Me.TbBerkLevel2.Name = "TbBerkLevel2"
        Me.TbBerkLevel2.ReadOnly = True
        Me.TbBerkLevel2.Size = New System.Drawing.Size(84, 22)
        Me.TbBerkLevel2.TabIndex = 6
        Me.TbBerkLevel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbPrepLevel2
        '
        Me.TbPrepLevel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbPrepLevel2.Location = New System.Drawing.Point(9, 78)
        Me.TbPrepLevel2.Name = "TbPrepLevel2"
        Me.TbPrepLevel2.ReadOnly = True
        Me.TbPrepLevel2.Size = New System.Drawing.Size(84, 22)
        Me.TbPrepLevel2.TabIndex = 7
        Me.TbPrepLevel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TbOtherLevel2
        '
        Me.TbOtherLevel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbOtherLevel2.Location = New System.Drawing.Point(9, 123)
        Me.TbOtherLevel2.Name = "TbOtherLevel2"
        Me.TbOtherLevel2.ReadOnly = True
        Me.TbOtherLevel2.Size = New System.Drawing.Size(84, 22)
        Me.TbOtherLevel2.TabIndex = 8
        Me.TbOtherLevel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label21.Location = New System.Drawing.Point(6, 150)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 15)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "Plastic"
        '
        'TbPlasticLevel2
        '
        Me.TbPlasticLevel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TbPlasticLevel2.Location = New System.Drawing.Point(9, 168)
        Me.TbPlasticLevel2.Name = "TbPlasticLevel2"
        Me.TbPlasticLevel2.ReadOnly = True
        Me.TbPlasticLevel2.Size = New System.Drawing.Size(84, 22)
        Me.TbPlasticLevel2.TabIndex = 9
        Me.TbPlasticLevel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(6, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Bark"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label20.Location = New System.Drawing.Point(6, 105)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(37, 15)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "Other"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label19.Location = New System.Drawing.Point(6, 62)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(33, 15)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "Prep"
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
        Me.DgvResumenPagoPacas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvResumenPagoPacas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvResumenPagoPacas.Location = New System.Drawing.Point(0, 0)
        Me.DgvResumenPagoPacas.MultiSelect = False
        Me.DgvResumenPagoPacas.Name = "DgvResumenPagoPacas"
        Me.DgvResumenPagoPacas.ReadOnly = True
        Me.DgvResumenPagoPacas.RowHeadersVisible = False
        Me.DgvResumenPagoPacas.RowHeadersWidth = 40
        Me.DgvResumenPagoPacas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvResumenPagoPacas.Size = New System.Drawing.Size(1258, 402)
        Me.DgvResumenPagoPacas.TabIndex = 41
        '
        'TbNombreComprador
        '
        Me.TbNombreComprador.Enabled = False
        Me.TbNombreComprador.Location = New System.Drawing.Point(207, 38)
        Me.TbNombreComprador.Name = "TbNombreComprador"
        Me.TbNombreComprador.Size = New System.Drawing.Size(441, 20)
        Me.TbNombreComprador.TabIndex = 40
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(668, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 16)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Id Contrato"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 16)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Id Venta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Id Comprador"
        '
        'TbIdContrato
        '
        Me.TbIdContrato.Enabled = False
        Me.TbIdContrato.Location = New System.Drawing.Point(746, 9)
        Me.TbIdContrato.Name = "TbIdContrato"
        Me.TbIdContrato.Size = New System.Drawing.Size(100, 20)
        Me.TbIdContrato.TabIndex = 33
        '
        'TbIdVenta
        '
        Me.TbIdVenta.Enabled = False
        Me.TbIdVenta.Location = New System.Drawing.Point(101, 12)
        Me.TbIdVenta.Name = "TbIdVenta"
        Me.TbIdVenta.Size = New System.Drawing.Size(100, 20)
        Me.TbIdVenta.TabIndex = 34
        '
        'TbIdComprador
        '
        Me.TbIdComprador.Enabled = False
        Me.TbIdComprador.Location = New System.Drawing.Point(101, 38)
        Me.TbIdComprador.Name = "TbIdComprador"
        Me.TbIdComprador.Size = New System.Drawing.Size(100, 20)
        Me.TbIdComprador.TabIndex = 35
        '
        'TbPrecioQuintal
        '
        Me.TbPrecioQuintal.Enabled = False
        Me.TbPrecioQuintal.Location = New System.Drawing.Point(746, 38)
        Me.TbPrecioQuintal.Name = "TbPrecioQuintal"
        Me.TbPrecioQuintal.Size = New System.Drawing.Size(100, 20)
        Me.TbPrecioQuintal.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(654, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Precio quintal"
        '
        'MSMenu
        '
        Me.MSMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PagarItem, Me.ImpResumenDePacasItem, Me.ImpDetallesDeVentaItem, Me.ImpResumenDeLiquidacionesItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(1502, 24)
        Me.MSMenu.TabIndex = 43
        Me.MSMenu.Text = "MenuStrip1"
        '
        'PagarItem
        '
        Me.PagarItem.Name = "PagarItem"
        Me.PagarItem.Size = New System.Drawing.Size(49, 20)
        Me.PagarItem.Text = "Pagar"
        '
        'ImpResumenDePacasItem
        '
        Me.ImpResumenDePacasItem.Name = "ImpResumenDePacasItem"
        Me.ImpResumenDePacasItem.Size = New System.Drawing.Size(141, 20)
        Me.ImpResumenDePacasItem.Text = "Imp.Resumen de Pacas"
        '
        'ImpDetallesDeVentaItem
        '
        Me.ImpDetallesDeVentaItem.Name = "ImpDetallesDeVentaItem"
        Me.ImpDetallesDeVentaItem.Size = New System.Drawing.Size(132, 20)
        Me.ImpDetallesDeVentaItem.Text = "Imp.Detalles de Venta"
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GbPagoFinal)
        Me.Panel1.Controls.Add(Me.GbCastigos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 498)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1502, 227)
        Me.Panel1.TabIndex = 45
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DgvResumenPagoPacas)
        Me.Panel2.Controls.Add(Me.GbDatosGenerales)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1502, 402)
        Me.Panel2.TabIndex = 46
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.TbNombreComprador)
        Me.Panel3.Controls.Add(Me.TbPrecioQuintal)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.TbIdComprador)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.TbIdVenta)
        Me.Panel3.Controls.Add(Me.TbIdContrato)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 24)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1502, 72)
        Me.Panel3.TabIndex = 47
        '
        'VentaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1502, 725)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.MSMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1518, 764)
        Me.Name = "VentaPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Venta de Pacas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        Me.GbPagoFinal.ResumeLayout(False)
        Me.GbPagoFinal.PerformLayout()
        Me.GbCastigos.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvResumenPagoPacas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbDatosGenerales As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbTotalPacas As TextBox
    Friend WithEvents TbTotalKilos As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GbPagoFinal As GroupBox
    Friend WithEvents TbAnticipoDlls As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TbSubtotal As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TbTipoCambio As TextBox
    Friend WithEvents TbTotalDls As TextBox
    Friend WithEvents TbTotalMxn As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TbSumaCastigo As TextBox
    Friend WithEvents GbCastigos As GroupBox
    Friend WithEvents TbCastigoxresistencia As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TbCastigoxlargo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TbCastigoxUI As TextBox
    Friend WithEvents TbCastigoxmicro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DgvResumenPagoPacas As DataGridView
    Friend WithEvents TbNombreComprador As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TbIdContrato As TextBox
    Friend WithEvents TbIdVenta As TextBox
    Friend WithEvents TbIdComprador As TextBox
    Friend WithEvents TbPrecioQuintal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents PagarItem As ToolStripMenuItem
    Friend WithEvents ImpResumenDePacasItem As ToolStripMenuItem
    Friend WithEvents ImpDetallesDeVentaItem As ToolStripMenuItem
    Friend WithEvents ImpResumenDeLiquidacionesItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CbUnidadPeso As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TbPrepLevel1 As TextBox
    Friend WithEvents TbBerkLevel1 As TextBox
    Friend WithEvents TbPlasticLevel2 As TextBox
    Friend WithEvents TbOtherLevel2 As TextBox
    Friend WithEvents TbPrepLevel2 As TextBox
    Friend WithEvents TbBerkLevel2 As TextBox
    Friend WithEvents TbPlasticLevel1 As TextBox
    Friend WithEvents TbOtherLevel1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
End Class
