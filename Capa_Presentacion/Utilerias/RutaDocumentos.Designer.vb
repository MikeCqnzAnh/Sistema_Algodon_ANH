<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RutaDocumentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RutaDocumentos))
        Me.GbUbicacionDocumentos = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GbPrincipalDocumentos = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TbDocumentacionProductores = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TBLotes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBPersonas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbTemporadas = New System.Windows.Forms.TextBox()
        Me.GbPrincipalTemporadas = New System.Windows.Forms.GroupBox()
        Me.GbTemporadas = New System.Windows.Forms.GroupBox()
        Me.TbActaParticipacion = New System.Windows.Forms.TextBox()
        Me.TbPreregistro = New System.Windows.Forms.TextBox()
        Me.TbAnexo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TbContratosCompradores = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TbContratosProductores = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtCarpetaTemporada = New System.Windows.Forms.Button()
        Me.TbNombreAnual = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBNombreRaiz = New System.Windows.Forms.TextBox()
        Me.TBRuta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBIdUbicacion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTUbicacion = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GuardarActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GbUbicacionDocumentos.SuspendLayout()
        Me.GbPrincipalDocumentos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GbPrincipalTemporadas.SuspendLayout()
        Me.GbTemporadas.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbUbicacionDocumentos
        '
        Me.GbUbicacionDocumentos.Controls.Add(Me.Button1)
        Me.GbUbicacionDocumentos.Controls.Add(Me.Label11)
        Me.GbUbicacionDocumentos.Controls.Add(Me.GbPrincipalDocumentos)
        Me.GbUbicacionDocumentos.Controls.Add(Me.TbTemporadas)
        Me.GbUbicacionDocumentos.Controls.Add(Me.GbPrincipalTemporadas)
        Me.GbUbicacionDocumentos.Controls.Add(Me.Label5)
        Me.GbUbicacionDocumentos.Controls.Add(Me.TBNombreRaiz)
        Me.GbUbicacionDocumentos.Controls.Add(Me.TBRuta)
        Me.GbUbicacionDocumentos.Controls.Add(Me.Label4)
        Me.GbUbicacionDocumentos.Controls.Add(Me.TBIdUbicacion)
        Me.GbUbicacionDocumentos.Controls.Add(Me.Label1)
        Me.GbUbicacionDocumentos.Controls.Add(Me.BTUbicacion)
        Me.GbUbicacionDocumentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbUbicacionDocumentos.Location = New System.Drawing.Point(0, 24)
        Me.GbUbicacionDocumentos.Name = "GbUbicacionDocumentos"
        Me.GbUbicacionDocumentos.Size = New System.Drawing.Size(1366, 774)
        Me.GbUbicacionDocumentos.TabIndex = 15
        Me.GbUbicacionDocumentos.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1030, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Temporadas:"
        '
        'GbPrincipalDocumentos
        '
        Me.GbPrincipalDocumentos.Controls.Add(Me.GroupBox1)
        Me.GbPrincipalDocumentos.Controls.Add(Me.TBPersonas)
        Me.GbPrincipalDocumentos.Controls.Add(Me.Label2)
        Me.GbPrincipalDocumentos.Location = New System.Drawing.Point(6, 123)
        Me.GbPrincipalDocumentos.Name = "GbPrincipalDocumentos"
        Me.GbPrincipalDocumentos.Size = New System.Drawing.Size(955, 155)
        Me.GbPrincipalDocumentos.TabIndex = 5
        Me.GbPrincipalDocumentos.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.TbDocumentacionProductores)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TBLotes)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(938, 93)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Documentacion Personal"
        '
        'TbDocumentacionProductores
        '
        Me.TbDocumentacionProductores.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbDocumentacionProductores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbDocumentacionProductores.Location = New System.Drawing.Point(264, 29)
        Me.TbDocumentacionProductores.MaxLength = 50
        Me.TbDocumentacionProductores.Name = "TbDocumentacionProductores"
        Me.TbDocumentacionProductores.Size = New System.Drawing.Size(281, 20)
        Me.TbDocumentacionProductores.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(21, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(213, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Carpeta de Documentos Personales:"
        '
        'TBLotes
        '
        Me.TBLotes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBLotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBLotes.Location = New System.Drawing.Point(264, 55)
        Me.TBLotes.MaxLength = 50
        Me.TBLotes.Name = "TBLotes"
        Me.TBLotes.Size = New System.Drawing.Size(281, 20)
        Me.TBLotes.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Carpeta de Documentos de Lotes:"
        '
        'TBPersonas
        '
        Me.TBPersonas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBPersonas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPersonas.Location = New System.Drawing.Point(270, 13)
        Me.TBPersonas.MaxLength = 50
        Me.TBPersonas.Name = "TBPersonas"
        Me.TBPersonas.Size = New System.Drawing.Size(281, 20)
        Me.TBPersonas.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Carpeta de Documentos de Productores:"
        '
        'TbTemporadas
        '
        Me.TbTemporadas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbTemporadas.Location = New System.Drawing.Point(130, 91)
        Me.TbTemporadas.MaxLength = 50
        Me.TbTemporadas.Name = "TbTemporadas"
        Me.TbTemporadas.Size = New System.Drawing.Size(183, 20)
        Me.TbTemporadas.TabIndex = 4
        '
        'GbPrincipalTemporadas
        '
        Me.GbPrincipalTemporadas.Controls.Add(Me.GbTemporadas)
        Me.GbPrincipalTemporadas.Controls.Add(Me.Label12)
        Me.GbPrincipalTemporadas.Controls.Add(Me.BtCarpetaTemporada)
        Me.GbPrincipalTemporadas.Controls.Add(Me.TbNombreAnual)
        Me.GbPrincipalTemporadas.Location = New System.Drawing.Point(6, 284)
        Me.GbPrincipalTemporadas.Name = "GbPrincipalTemporadas"
        Me.GbPrincipalTemporadas.Size = New System.Drawing.Size(955, 226)
        Me.GbPrincipalTemporadas.TabIndex = 6
        Me.GbPrincipalTemporadas.TabStop = False
        '
        'GbTemporadas
        '
        Me.GbTemporadas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GbTemporadas.Controls.Add(Me.TbActaParticipacion)
        Me.GbTemporadas.Controls.Add(Me.TbPreregistro)
        Me.GbTemporadas.Controls.Add(Me.TbAnexo)
        Me.GbTemporadas.Controls.Add(Me.Label10)
        Me.GbTemporadas.Controls.Add(Me.TbContratosCompradores)
        Me.GbTemporadas.Controls.Add(Me.Label9)
        Me.GbTemporadas.Controls.Add(Me.TbContratosProductores)
        Me.GbTemporadas.Controls.Add(Me.Label8)
        Me.GbTemporadas.Controls.Add(Me.Label7)
        Me.GbTemporadas.Controls.Add(Me.Label6)
        Me.GbTemporadas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbTemporadas.Location = New System.Drawing.Point(6, 39)
        Me.GbTemporadas.Name = "GbTemporadas"
        Me.GbTemporadas.Size = New System.Drawing.Size(938, 177)
        Me.GbTemporadas.TabIndex = 2
        Me.GbTemporadas.TabStop = False
        Me.GbTemporadas.Text = "Documentacion de Temporadas"
        '
        'TbActaParticipacion
        '
        Me.TbActaParticipacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbActaParticipacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbActaParticipacion.Location = New System.Drawing.Point(264, 134)
        Me.TbActaParticipacion.MaxLength = 50
        Me.TbActaParticipacion.Name = "TbActaParticipacion"
        Me.TbActaParticipacion.Size = New System.Drawing.Size(281, 20)
        Me.TbActaParticipacion.TabIndex = 4
        '
        'TbPreregistro
        '
        Me.TbPreregistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbPreregistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbPreregistro.Location = New System.Drawing.Point(264, 108)
        Me.TbPreregistro.MaxLength = 50
        Me.TbPreregistro.Name = "TbPreregistro"
        Me.TbPreregistro.Size = New System.Drawing.Size(281, 20)
        Me.TbPreregistro.TabIndex = 3
        '
        'TbAnexo
        '
        Me.TbAnexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbAnexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbAnexo.Location = New System.Drawing.Point(264, 82)
        Me.TbAnexo.MaxLength = 50
        Me.TbAnexo.Name = "TbAnexo"
        Me.TbAnexo.Size = New System.Drawing.Size(281, 20)
        Me.TbAnexo.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(37, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Acta Participacion:"
        '
        'TbContratosCompradores
        '
        Me.TbContratosCompradores.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbContratosCompradores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbContratosCompradores.Location = New System.Drawing.Point(264, 56)
        Me.TbContratosCompradores.MaxLength = 50
        Me.TbContratosCompradores.Name = "TbContratosCompradores"
        Me.TbContratosCompradores.Size = New System.Drawing.Size(281, 20)
        Me.TbContratosCompradores.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(37, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "PreRegistro Aserca:"
        '
        'TbContratosProductores
        '
        Me.TbContratosProductores.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbContratosProductores.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbContratosProductores.Location = New System.Drawing.Point(264, 30)
        Me.TbContratosProductores.MaxLength = 50
        Me.TbContratosProductores.Name = "TbContratosProductores"
        Me.TbContratosProductores.Size = New System.Drawing.Size(281, 20)
        Me.TbContratosProductores.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(37, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Anexo 1:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Contratos de Compradores:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Contratos de Productores:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Año de Temporada:"
        '
        'BtCarpetaTemporada
        '
        Me.BtCarpetaTemporada.BackgroundImage = CType(resources.GetObject("BtCarpetaTemporada.BackgroundImage"), System.Drawing.Image)
        Me.BtCarpetaTemporada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtCarpetaTemporada.Location = New System.Drawing.Point(411, 13)
        Me.BtCarpetaTemporada.Name = "BtCarpetaTemporada"
        Me.BtCarpetaTemporada.Size = New System.Drawing.Size(46, 20)
        Me.BtCarpetaTemporada.TabIndex = 1
        Me.BtCarpetaTemporada.UseVisualStyleBackColor = True
        '
        'TbNombreAnual
        '
        Me.TbNombreAnual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbNombreAnual.Location = New System.Drawing.Point(270, 13)
        Me.TbNombreAnual.MaxLength = 7
        Me.TbNombreAnual.Name = "TbNombreAnual"
        Me.TbNombreAnual.Size = New System.Drawing.Size(135, 20)
        Me.TbNombreAnual.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ID:"
        Me.Label5.Visible = False
        '
        'TBNombreRaiz
        '
        Me.TBNombreRaiz.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBNombreRaiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNombreRaiz.Location = New System.Drawing.Point(130, 65)
        Me.TBNombreRaiz.MaxLength = 50
        Me.TBNombreRaiz.Name = "TBNombreRaiz"
        Me.TBNombreRaiz.Size = New System.Drawing.Size(281, 20)
        Me.TBNombreRaiz.TabIndex = 3
        '
        'TBRuta
        '
        Me.TBRuta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBRuta.Location = New System.Drawing.Point(130, 39)
        Me.TBRuta.Name = "TBRuta"
        Me.TBRuta.Size = New System.Drawing.Size(570, 20)
        Me.TBRuta.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Carpeta Raiz:"
        '
        'TBIdUbicacion
        '
        Me.TBIdUbicacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBIdUbicacion.Location = New System.Drawing.Point(130, 13)
        Me.TBIdUbicacion.Name = "TBIdUbicacion"
        Me.TBIdUbicacion.Size = New System.Drawing.Size(104, 20)
        Me.TBIdUbicacion.TabIndex = 0
        Me.TBIdUbicacion.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Ruta Principal:"
        '
        'BTUbicacion
        '
        Me.BTUbicacion.BackgroundImage = CType(resources.GetObject("BTUbicacion.BackgroundImage"), System.Drawing.Image)
        Me.BTUbicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTUbicacion.Location = New System.Drawing.Point(706, 39)
        Me.BTUbicacion.Name = "BTUbicacion"
        Me.BTUbicacion.Size = New System.Drawing.Size(46, 20)
        Me.BTUbicacion.TabIndex = 2
        Me.BTUbicacion.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarActualizarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1366, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GuardarActualizarToolStripMenuItem
        '
        Me.GuardarActualizarToolStripMenuItem.Name = "GuardarActualizarToolStripMenuItem"
        Me.GuardarActualizarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.GuardarActualizarToolStripMenuItem.Text = "Guardar"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
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
        'RutaDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 798)
        Me.Controls.Add(Me.GbUbicacionDocumentos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "RutaDocumentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ruta de Documentos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbUbicacionDocumentos.ResumeLayout(False)
        Me.GbUbicacionDocumentos.PerformLayout()
        Me.GbPrincipalDocumentos.ResumeLayout(False)
        Me.GbPrincipalDocumentos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GbPrincipalTemporadas.ResumeLayout(False)
        Me.GbPrincipalTemporadas.PerformLayout()
        Me.GbTemporadas.ResumeLayout(False)
        Me.GbTemporadas.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbUbicacionDocumentos As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GbPrincipalDocumentos As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TbDocumentacionProductores As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TBLotes As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBPersonas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbTemporadas As TextBox
    Friend WithEvents GbPrincipalTemporadas As GroupBox
    Friend WithEvents GbTemporadas As GroupBox
    Friend WithEvents TbActaParticipacion As TextBox
    Friend WithEvents TbPreregistro As TextBox
    Friend WithEvents TbAnexo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TbContratosCompradores As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TbContratosProductores As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BtCarpetaTemporada As Button
    Friend WithEvents TbNombreAnual As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBNombreRaiz As TextBox
    Friend WithEvents TBRuta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBIdUbicacion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTUbicacion As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GuardarActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog2 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
End Class
