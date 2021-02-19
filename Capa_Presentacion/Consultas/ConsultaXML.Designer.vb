<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaXML
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaXML))
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.BtSeleccionarCarpeta = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtMarcar = New System.Windows.Forms.Button()
        Me.BtDesmarcar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbUnidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbClaveProducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbFiltro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtSeleccionarXML = New System.Windows.Forms.Button()
        Me.TbRuta = New System.Windows.Forms.TextBox()
        Me.DgvFacturas = New System.Windows.Forms.DataGridView()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(12, 73)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(28, 13)
        Me.LblTotal.TabIndex = 1
        Me.LblTotal.Text = "       "
        '
        'BtSeleccionarCarpeta
        '
        Me.BtSeleccionarCarpeta.Location = New System.Drawing.Point(6, 47)
        Me.BtSeleccionarCarpeta.Name = "BtSeleccionarCarpeta"
        Me.BtSeleccionarCarpeta.Size = New System.Drawing.Size(114, 23)
        Me.BtSeleccionarCarpeta.TabIndex = 2
        Me.BtSeleccionarCarpeta.Text = "Seleccionar Carpeta"
        Me.BtSeleccionarCarpeta.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtMarcar)
        Me.GroupBox1.Controls.Add(Me.BtDesmarcar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TbUnidad)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TbClaveProducto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TbFiltro)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtSeleccionarXML)
        Me.GroupBox1.Controls.Add(Me.TbRuta)
        Me.GroupBox1.Controls.Add(Me.BtSeleccionarCarpeta)
        Me.GroupBox1.Controls.Add(Me.LblTotal)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(937, 144)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'BtMarcar
        '
        Me.BtMarcar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtMarcar.BackgroundImage = CType(resources.GetObject("BtMarcar.BackgroundImage"), System.Drawing.Image)
        Me.BtMarcar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtMarcar.Location = New System.Drawing.Point(861, 108)
        Me.BtMarcar.Name = "BtMarcar"
        Me.BtMarcar.Size = New System.Drawing.Size(32, 32)
        Me.BtMarcar.TabIndex = 13
        Me.BtMarcar.UseVisualStyleBackColor = True
        '
        'BtDesmarcar
        '
        Me.BtDesmarcar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtDesmarcar.BackgroundImage = CType(resources.GetObject("BtDesmarcar.BackgroundImage"), System.Drawing.Image)
        Me.BtDesmarcar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtDesmarcar.Location = New System.Drawing.Point(899, 108)
        Me.BtDesmarcar.Name = "BtDesmarcar"
        Me.BtDesmarcar.Size = New System.Drawing.Size(32, 32)
        Me.BtDesmarcar.TabIndex = 12
        Me.BtDesmarcar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(226, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Unidad"
        '
        'TbUnidad
        '
        Me.TbUnidad.Location = New System.Drawing.Point(273, 13)
        Me.TbUnidad.Name = "TbUnidad"
        Me.TbUnidad.Size = New System.Drawing.Size(100, 20)
        Me.TbUnidad.TabIndex = 10
        Me.TbUnidad.Text = "TNE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(547, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "      "
        '
        'TbClaveProducto
        '
        Me.TbClaveProducto.Location = New System.Drawing.Point(126, 13)
        Me.TbClaveProducto.MaxLength = 10
        Me.TbClaveProducto.Name = "TbClaveProducto"
        Me.TbClaveProducto.Size = New System.Drawing.Size(75, 20)
        Me.TbClaveProducto.TabIndex = 8
        Me.TbClaveProducto.Text = "11121802"
        Me.TbClaveProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Clave de producto:"
        '
        'TbFiltro
        '
        Me.TbFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TbFiltro.Location = New System.Drawing.Point(104, 105)
        Me.TbFiltro.Name = "TbFiltro"
        Me.TbFiltro.Size = New System.Drawing.Size(359, 20)
        Me.TbFiltro.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Filtrar por nombre:"
        '
        'BtSeleccionarXML
        '
        Me.BtSeleccionarXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSeleccionarXML.Location = New System.Drawing.Point(827, 47)
        Me.BtSeleccionarXML.Name = "BtSeleccionarXML"
        Me.BtSeleccionarXML.Size = New System.Drawing.Size(104, 23)
        Me.BtSeleccionarXML.TabIndex = 4
        Me.BtSeleccionarXML.Text = "Seleccionar XML"
        Me.BtSeleccionarXML.UseVisualStyleBackColor = True
        '
        'TbRuta
        '
        Me.TbRuta.Location = New System.Drawing.Point(126, 49)
        Me.TbRuta.Name = "TbRuta"
        Me.TbRuta.ReadOnly = True
        Me.TbRuta.Size = New System.Drawing.Size(337, 20)
        Me.TbRuta.TabIndex = 3
        Me.TbRuta.Text = "C:\XML"
        '
        'DgvFacturas
        '
        Me.DgvFacturas.AllowUserToAddRows = False
        Me.DgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvFacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvFacturas.Location = New System.Drawing.Point(0, 144)
        Me.DgvFacturas.MultiSelect = False
        Me.DgvFacturas.Name = "DgvFacturas"
        Me.DgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvFacturas.Size = New System.Drawing.Size(937, 300)
        Me.DgvFacturas.TabIndex = 5
        '
        'ProgressBar
        '
        Me.ProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar.Location = New System.Drawing.Point(0, 444)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(937, 23)
        Me.ProgressBar.Step = 1
        Me.ProgressBar.TabIndex = 6
        '
        'ConsultaXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 467)
        Me.Controls.Add(Me.DgvFacturas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ProgressBar)
        Me.Name = "ConsultaXML"
        Me.Text = "ConsultaXML"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblTotal As Label
    Friend WithEvents BtSeleccionarCarpeta As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DgvFacturas As DataGridView
    Friend WithEvents TbRuta As TextBox
    Friend WithEvents BtSeleccionarXML As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TbFiltro As TextBox
    Friend WithEvents TbClaveProducto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TbUnidad As TextBox
    Friend WithEvents BtMarcar As Button
    Friend WithEvents BtDesmarcar As Button
End Class
