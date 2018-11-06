<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContratosAlgodon
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
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.BtGenerar = New System.Windows.Forms.Button()
        Me.BtConsultaLotes = New System.Windows.Forms.Button()
        Me.GbPrecioQuintal = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TbO = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TbGO = New System.Windows.Forms.TextBox()
        Me.TbSGO = New System.Windows.Forms.TextBox()
        Me.TbLM = New System.Windows.Forms.TextBox()
        Me.TbLMP = New System.Windows.Forms.TextBox()
        Me.TbSLM = New System.Windows.Forms.TextBox()
        Me.TbSLMP = New System.Windows.Forms.TextBox()
        Me.TbM = New System.Windows.Forms.TextBox()
        Me.TbMP = New System.Windows.Forms.TextBox()
        Me.TbSM = New System.Windows.Forms.TextBox()
        Me.BtnBuscarProductor = New System.Windows.Forms.Button()
        Me.TbProductor = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CbEstatus = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TbTemporada = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CbModalidad = New System.Windows.Forms.ComboBox()
        Me.TbPresidente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DtpFechaLiquidacion = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbPuntos = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TbPrecioQuintal = New System.Windows.Forms.TextBox()
        Me.TbLotes = New System.Windows.Forms.TextBox()
        Me.TbSuperficie = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbPacas = New System.Windows.Forms.TextBox()
        Me.TbAsociacion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbIdContratoAlgodon = New System.Windows.Forms.TextBox()
        Me.DgvContratoAlgodon = New System.Windows.Forms.DataGridView()
        Me.MSMenu.SuspendLayout()
        Me.GbDatosGenerales.SuspendLayout()
        Me.GbPrecioQuintal.SuspendLayout()
        CType(Me.DgvContratoAlgodon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(1194, 24)
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
        'GbDatosGenerales
        '
        Me.GbDatosGenerales.Controls.Add(Me.BtGenerar)
        Me.GbDatosGenerales.Controls.Add(Me.BtConsultaLotes)
        Me.GbDatosGenerales.Controls.Add(Me.GbPrecioQuintal)
        Me.GbDatosGenerales.Controls.Add(Me.BtnBuscarProductor)
        Me.GbDatosGenerales.Controls.Add(Me.TbProductor)
        Me.GbDatosGenerales.Controls.Add(Me.Label13)
        Me.GbDatosGenerales.Controls.Add(Me.CbEstatus)
        Me.GbDatosGenerales.Controls.Add(Me.Label12)
        Me.GbDatosGenerales.Controls.Add(Me.TbTemporada)
        Me.GbDatosGenerales.Controls.Add(Me.Label11)
        Me.GbDatosGenerales.Controls.Add(Me.Label10)
        Me.GbDatosGenerales.Controls.Add(Me.CbModalidad)
        Me.GbDatosGenerales.Controls.Add(Me.TbPresidente)
        Me.GbDatosGenerales.Controls.Add(Me.Label9)
        Me.GbDatosGenerales.Controls.Add(Me.DtpFechaLiquidacion)
        Me.GbDatosGenerales.Controls.Add(Me.Label8)
        Me.GbDatosGenerales.Controls.Add(Me.TbPuntos)
        Me.GbDatosGenerales.Controls.Add(Me.Label7)
        Me.GbDatosGenerales.Controls.Add(Me.Label6)
        Me.GbDatosGenerales.Controls.Add(Me.Label5)
        Me.GbDatosGenerales.Controls.Add(Me.TbPrecioQuintal)
        Me.GbDatosGenerales.Controls.Add(Me.TbLotes)
        Me.GbDatosGenerales.Controls.Add(Me.TbSuperficie)
        Me.GbDatosGenerales.Controls.Add(Me.Label4)
        Me.GbDatosGenerales.Controls.Add(Me.Label3)
        Me.GbDatosGenerales.Controls.Add(Me.TbPacas)
        Me.GbDatosGenerales.Controls.Add(Me.TbAsociacion)
        Me.GbDatosGenerales.Controls.Add(Me.Label2)
        Me.GbDatosGenerales.Controls.Add(Me.Label1)
        Me.GbDatosGenerales.Controls.Add(Me.TbIdContratoAlgodon)
        Me.GbDatosGenerales.Location = New System.Drawing.Point(12, 27)
        Me.GbDatosGenerales.Name = "GbDatosGenerales"
        Me.GbDatosGenerales.Size = New System.Drawing.Size(1170, 208)
        Me.GbDatosGenerales.TabIndex = 1
        Me.GbDatosGenerales.TabStop = False
        Me.GbDatosGenerales.Text = "Datos Generales"
        '
        'BtGenerar
        '
        Me.BtGenerar.Location = New System.Drawing.Point(679, 118)
        Me.BtGenerar.Name = "BtGenerar"
        Me.BtGenerar.Size = New System.Drawing.Size(94, 23)
        Me.BtGenerar.TabIndex = 30
        Me.BtGenerar.Text = "Generar"
        Me.BtGenerar.UseVisualStyleBackColor = True
        '
        'BtConsultaLotes
        '
        Me.BtConsultaLotes.Location = New System.Drawing.Point(349, 148)
        Me.BtConsultaLotes.Name = "BtConsultaLotes"
        Me.BtConsultaLotes.Size = New System.Drawing.Size(42, 23)
        Me.BtConsultaLotes.TabIndex = 29
        Me.BtConsultaLotes.Text = "..."
        Me.BtConsultaLotes.UseVisualStyleBackColor = True
        '
        'GbPrecioQuintal
        '
        Me.GbPrecioQuintal.Controls.Add(Me.Label23)
        Me.GbPrecioQuintal.Controls.Add(Me.TbO)
        Me.GbPrecioQuintal.Controls.Add(Me.Label22)
        Me.GbPrecioQuintal.Controls.Add(Me.Label21)
        Me.GbPrecioQuintal.Controls.Add(Me.Label20)
        Me.GbPrecioQuintal.Controls.Add(Me.Label19)
        Me.GbPrecioQuintal.Controls.Add(Me.Label18)
        Me.GbPrecioQuintal.Controls.Add(Me.Label17)
        Me.GbPrecioQuintal.Controls.Add(Me.Label16)
        Me.GbPrecioQuintal.Controls.Add(Me.Label15)
        Me.GbPrecioQuintal.Controls.Add(Me.Label14)
        Me.GbPrecioQuintal.Controls.Add(Me.TbGO)
        Me.GbPrecioQuintal.Controls.Add(Me.TbSGO)
        Me.GbPrecioQuintal.Controls.Add(Me.TbLM)
        Me.GbPrecioQuintal.Controls.Add(Me.TbLMP)
        Me.GbPrecioQuintal.Controls.Add(Me.TbSLM)
        Me.GbPrecioQuintal.Controls.Add(Me.TbSLMP)
        Me.GbPrecioQuintal.Controls.Add(Me.TbM)
        Me.GbPrecioQuintal.Controls.Add(Me.TbMP)
        Me.GbPrecioQuintal.Controls.Add(Me.TbSM)
        Me.GbPrecioQuintal.Location = New System.Drawing.Point(779, 19)
        Me.GbPrecioQuintal.Name = "GbPrecioQuintal"
        Me.GbPrecioQuintal.Size = New System.Drawing.Size(385, 178)
        Me.GbPrecioQuintal.TabIndex = 28
        Me.GbPrecioQuintal.TabStop = False
        Me.GbPrecioQuintal.Text = "Precio de Quintal Por Clase"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(202, 100)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(36, 13)
        Me.Label23.TabIndex = 33
        Me.Label23.Text = "10.- O"
        '
        'TbO
        '
        Me.TbO.Enabled = False
        Me.TbO.Location = New System.Drawing.Point(279, 97)
        Me.TbO.Name = "TbO"
        Me.TbO.Size = New System.Drawing.Size(100, 20)
        Me.TbO.TabIndex = 32
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(202, 74)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(38, 13)
        Me.Label22.TabIndex = 29
        Me.Label22.Text = "9.- GO"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(202, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 13)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "8.- SGO"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(202, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(37, 13)
        Me.Label20.TabIndex = 29
        Me.Label20.Text = "7.- LM"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 152)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 13)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "6.- LMP"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 126)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 13)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "5.- SLM"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 100)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 13)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "4.- SLMP"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "3.- M"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "2.- MP"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "1.- SM"
        '
        'TbGO
        '
        Me.TbGO.Enabled = False
        Me.TbGO.Location = New System.Drawing.Point(279, 71)
        Me.TbGO.Name = "TbGO"
        Me.TbGO.Size = New System.Drawing.Size(100, 20)
        Me.TbGO.TabIndex = 29
        '
        'TbSGO
        '
        Me.TbSGO.Enabled = False
        Me.TbSGO.Location = New System.Drawing.Point(279, 45)
        Me.TbSGO.Name = "TbSGO"
        Me.TbSGO.Size = New System.Drawing.Size(100, 20)
        Me.TbSGO.TabIndex = 29
        '
        'TbLM
        '
        Me.TbLM.Enabled = False
        Me.TbLM.Location = New System.Drawing.Point(279, 19)
        Me.TbLM.Name = "TbLM"
        Me.TbLM.Size = New System.Drawing.Size(100, 20)
        Me.TbLM.TabIndex = 29
        '
        'TbLMP
        '
        Me.TbLMP.Enabled = False
        Me.TbLMP.Location = New System.Drawing.Point(96, 149)
        Me.TbLMP.Name = "TbLMP"
        Me.TbLMP.Size = New System.Drawing.Size(100, 20)
        Me.TbLMP.TabIndex = 29
        '
        'TbSLM
        '
        Me.TbSLM.Enabled = False
        Me.TbSLM.Location = New System.Drawing.Point(96, 123)
        Me.TbSLM.Name = "TbSLM"
        Me.TbSLM.Size = New System.Drawing.Size(100, 20)
        Me.TbSLM.TabIndex = 4
        '
        'TbSLMP
        '
        Me.TbSLMP.Enabled = False
        Me.TbSLMP.Location = New System.Drawing.Point(96, 97)
        Me.TbSLMP.Name = "TbSLMP"
        Me.TbSLMP.Size = New System.Drawing.Size(100, 20)
        Me.TbSLMP.TabIndex = 3
        '
        'TbM
        '
        Me.TbM.Enabled = False
        Me.TbM.Location = New System.Drawing.Point(96, 71)
        Me.TbM.Name = "TbM"
        Me.TbM.Size = New System.Drawing.Size(100, 20)
        Me.TbM.TabIndex = 2
        '
        'TbMP
        '
        Me.TbMP.Enabled = False
        Me.TbMP.Location = New System.Drawing.Point(96, 45)
        Me.TbMP.Name = "TbMP"
        Me.TbMP.Size = New System.Drawing.Size(100, 20)
        Me.TbMP.TabIndex = 1
        '
        'TbSM
        '
        Me.TbSM.Enabled = False
        Me.TbSM.Location = New System.Drawing.Point(96, 19)
        Me.TbSM.Name = "TbSM"
        Me.TbSM.Size = New System.Drawing.Size(100, 20)
        Me.TbSM.TabIndex = 0
        '
        'BtnBuscarProductor
        '
        Me.BtnBuscarProductor.Image = Global.Capa_Presentacion.My.Resources.Resources.BusquedaUsuario2
        Me.BtnBuscarProductor.Location = New System.Drawing.Point(349, 42)
        Me.BtnBuscarProductor.Name = "BtnBuscarProductor"
        Me.BtnBuscarProductor.Size = New System.Drawing.Size(42, 50)
        Me.BtnBuscarProductor.TabIndex = 27
        Me.BtnBuscarProductor.UseVisualStyleBackColor = True
        '
        'TbProductor
        '
        Me.TbProductor.Enabled = False
        Me.TbProductor.Location = New System.Drawing.Point(117, 45)
        Me.TbProductor.Name = "TbProductor"
        Me.TbProductor.Size = New System.Drawing.Size(226, 20)
        Me.TbProductor.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 179)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Estatus"
        '
        'CbEstatus
        '
        Me.CbEstatus.FormattingEnabled = True
        Me.CbEstatus.Location = New System.Drawing.Point(117, 176)
        Me.CbEstatus.Name = "CbEstatus"
        Me.CbEstatus.Size = New System.Drawing.Size(121, 21)
        Me.CbEstatus.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(397, 150)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Para Temporada"
        '
        'TbTemporada
        '
        Me.TbTemporada.Location = New System.Drawing.Point(510, 147)
        Me.TbTemporada.Name = "TbTemporada"
        Me.TbTemporada.Size = New System.Drawing.Size(100, 20)
        Me.TbTemporada.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(397, 123)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Mod. Compra"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(397, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Presidente"
        '
        'CbModalidad
        '
        Me.CbModalidad.FormattingEnabled = True
        Me.CbModalidad.Location = New System.Drawing.Point(510, 120)
        Me.CbModalidad.Name = "CbModalidad"
        Me.CbModalidad.Size = New System.Drawing.Size(163, 21)
        Me.CbModalidad.TabIndex = 19
        '
        'TbPresidente
        '
        Me.TbPresidente.Location = New System.Drawing.Point(510, 94)
        Me.TbPresidente.Name = "TbPresidente"
        Me.TbPresidente.Size = New System.Drawing.Size(263, 20)
        Me.TbPresidente.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(397, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Fecha Liquidacion"
        '
        'DtpFechaLiquidacion
        '
        Me.DtpFechaLiquidacion.Location = New System.Drawing.Point(510, 68)
        Me.DtpFechaLiquidacion.Name = "DtpFechaLiquidacion"
        Me.DtpFechaLiquidacion.Size = New System.Drawing.Size(200, 20)
        Me.DtpFechaLiquidacion.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(397, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Puntos"
        '
        'TbPuntos
        '
        Me.TbPuntos.Location = New System.Drawing.Point(510, 42)
        Me.TbPuntos.Name = "TbPuntos"
        Me.TbPuntos.Size = New System.Drawing.Size(100, 20)
        Me.TbPuntos.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(397, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Precio Quintal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Lotes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Sup. Comprometida"
        '
        'TbPrecioQuintal
        '
        Me.TbPrecioQuintal.Location = New System.Drawing.Point(510, 16)
        Me.TbPrecioQuintal.Name = "TbPrecioQuintal"
        Me.TbPrecioQuintal.Size = New System.Drawing.Size(100, 20)
        Me.TbPrecioQuintal.TabIndex = 10
        '
        'TbLotes
        '
        Me.TbLotes.Enabled = False
        Me.TbLotes.Location = New System.Drawing.Point(117, 150)
        Me.TbLotes.Name = "TbLotes"
        Me.TbLotes.Size = New System.Drawing.Size(226, 20)
        Me.TbLotes.TabIndex = 9
        '
        'TbSuperficie
        '
        Me.TbSuperficie.Location = New System.Drawing.Point(117, 124)
        Me.TbSuperficie.Name = "TbSuperficie"
        Me.TbSuperficie.Size = New System.Drawing.Size(121, 20)
        Me.TbSuperficie.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Pacas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Asociacion"
        '
        'TbPacas
        '
        Me.TbPacas.Location = New System.Drawing.Point(117, 98)
        Me.TbPacas.Name = "TbPacas"
        Me.TbPacas.Size = New System.Drawing.Size(121, 20)
        Me.TbPacas.TabIndex = 5
        '
        'TbAsociacion
        '
        Me.TbAsociacion.Enabled = False
        Me.TbAsociacion.Location = New System.Drawing.Point(117, 72)
        Me.TbAsociacion.Name = "TbAsociacion"
        Me.TbAsociacion.Size = New System.Drawing.Size(226, 20)
        Me.TbAsociacion.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Productor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'TbIdContratoAlgodon
        '
        Me.TbIdContratoAlgodon.Enabled = False
        Me.TbIdContratoAlgodon.Location = New System.Drawing.Point(117, 19)
        Me.TbIdContratoAlgodon.Name = "TbIdContratoAlgodon"
        Me.TbIdContratoAlgodon.Size = New System.Drawing.Size(100, 20)
        Me.TbIdContratoAlgodon.TabIndex = 0
        '
        'DgvContratoAlgodon
        '
        Me.DgvContratoAlgodon.AllowUserToAddRows = False
        Me.DgvContratoAlgodon.AllowUserToDeleteRows = False
        Me.DgvContratoAlgodon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvContratoAlgodon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvContratoAlgodon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvContratoAlgodon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvContratoAlgodon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvContratoAlgodon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvContratoAlgodon.Location = New System.Drawing.Point(12, 241)
        Me.DgvContratoAlgodon.MultiSelect = False
        Me.DgvContratoAlgodon.Name = "DgvContratoAlgodon"
        Me.DgvContratoAlgodon.ReadOnly = True
        Me.DgvContratoAlgodon.RowHeadersVisible = False
        Me.DgvContratoAlgodon.RowHeadersWidth = 40
        Me.DgvContratoAlgodon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvContratoAlgodon.Size = New System.Drawing.Size(1170, 340)
        Me.DgvContratoAlgodon.TabIndex = 13
        '
        'ContratosAlgodon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1194, 600)
        Me.Controls.Add(Me.DgvContratoAlgodon)
        Me.Controls.Add(Me.GbDatosGenerales)
        Me.Controls.Add(Me.MSMenu)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "ContratosAlgodon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contratos de Algodon (Compras)"
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GbDatosGenerales.ResumeLayout(False)
        Me.GbDatosGenerales.PerformLayout()
        Me.GbPrecioQuintal.ResumeLayout(False)
        Me.GbPrecioQuintal.PerformLayout()
        CType(Me.DgvContratoAlgodon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GbDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CbModalidad As System.Windows.Forms.ComboBox
    Friend WithEvents TbPresidente As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaLiquidacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TbPuntos As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TbPrecioQuintal As System.Windows.Forms.TextBox
    Friend WithEvents TbLotes As System.Windows.Forms.TextBox
    Friend WithEvents TbSuperficie As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TbPacas As System.Windows.Forms.TextBox
    Friend WithEvents TbAsociacion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbIdContratoAlgodon As System.Windows.Forms.TextBox
    Friend WithEvents DgvContratoAlgodon As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents TbTemporada As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents CbEstatus As ComboBox
    Friend WithEvents TbProductor As TextBox
    Friend WithEvents BtnBuscarProductor As Button
    Friend WithEvents GbPrecioQuintal As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TbGO As TextBox
    Friend WithEvents TbSGO As TextBox
    Friend WithEvents TbLM As TextBox
    Friend WithEvents TbLMP As TextBox
    Friend WithEvents TbSLM As TextBox
    Friend WithEvents TbSLMP As TextBox
    Friend WithEvents TbM As TextBox
    Friend WithEvents TbMP As TextBox
    Friend WithEvents TbSM As TextBox
    Friend WithEvents BtConsultaLotes As Button
    Friend WithEvents BtGenerar As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents TbO As TextBox
End Class
