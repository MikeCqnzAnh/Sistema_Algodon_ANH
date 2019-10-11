<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CapturaBoletasPorLotes
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
        Me.components = New System.ComponentModel.Container()
        Me.MSMenu = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncidenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GbGenerales = New System.Windows.Forms.GroupBox()
        Me.LbStatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbPuertosSeriales = New System.Windows.Forms.ComboBox()
        Me.BtAutomatico = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvModulos = New Capa_Presentacion.CapturaBoletasPorLotes.DgvPlusCapturaBoletas()
        Me.TiActualizaDgvModulos = New System.Windows.Forms.Timer(Me.components)
        Me.SpCapturaAuto = New System.IO.Ports.SerialPort(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MSMenu.SuspendLayout()
        Me.GbGenerales.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvModulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MSMenu
        '
        Me.MSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.IncidenciasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MSMenu.Location = New System.Drawing.Point(0, 0)
        Me.MSMenu.Name = "MSMenu"
        Me.MSMenu.Size = New System.Drawing.Size(1205, 24)
        Me.MSMenu.TabIndex = 0
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'IncidenciasToolStripMenuItem
        '
        Me.IncidenciasToolStripMenuItem.Name = "IncidenciasToolStripMenuItem"
        Me.IncidenciasToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.IncidenciasToolStripMenuItem.Text = "Incidencias"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GbGenerales
        '
        Me.GbGenerales.Controls.Add(Me.Label2)
        Me.GbGenerales.Controls.Add(Me.LbStatus)
        Me.GbGenerales.Controls.Add(Me.Label1)
        Me.GbGenerales.Controls.Add(Me.CbPuertosSeriales)
        Me.GbGenerales.Controls.Add(Me.BtAutomatico)
        Me.GbGenerales.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbGenerales.Location = New System.Drawing.Point(0, 24)
        Me.GbGenerales.Name = "GbGenerales"
        Me.GbGenerales.Size = New System.Drawing.Size(1205, 102)
        Me.GbGenerales.TabIndex = 30
        Me.GbGenerales.TabStop = False
        Me.GbGenerales.Text = "Datos Generales"
        '
        'LbStatus
        '
        Me.LbStatus.AutoSize = True
        Me.LbStatus.Dock = System.Windows.Forms.DockStyle.Right
        Me.LbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbStatus.Location = New System.Drawing.Point(1117, 16)
        Me.LbStatus.Name = "LbStatus"
        Me.LbStatus.Size = New System.Drawing.Size(85, 29)
        Me.LbStatus.TabIndex = 64
        Me.LbStatus.Text = "Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 63
        '
        'CbPuertosSeriales
        '
        Me.CbPuertosSeriales.FormattingEnabled = True
        Me.CbPuertosSeriales.Location = New System.Drawing.Point(6, 37)
        Me.CbPuertosSeriales.Name = "CbPuertosSeriales"
        Me.CbPuertosSeriales.Size = New System.Drawing.Size(157, 21)
        Me.CbPuertosSeriales.TabIndex = 62
        '
        'BtAutomatico
        '
        Me.BtAutomatico.Location = New System.Drawing.Point(169, 37)
        Me.BtAutomatico.Name = "BtAutomatico"
        Me.BtAutomatico.Size = New System.Drawing.Size(147, 50)
        Me.BtAutomatico.TabIndex = 61
        Me.BtAutomatico.Text = "Captura Automatica de Datos"
        Me.BtAutomatico.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DgvModulos)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1205, 592)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion"
        '
        'DgvModulos
        '
        Me.DgvModulos.AllowUserToAddRows = False
        Me.DgvModulos.AllowUserToDeleteRows = False
        Me.DgvModulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvModulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvModulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvModulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvModulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvModulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvModulos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvModulos.Location = New System.Drawing.Point(3, 16)
        Me.DgvModulos.MultiSelect = False
        Me.DgvModulos.Name = "DgvModulos"
        Me.DgvModulos.RowHeadersVisible = False
        Me.DgvModulos.RowHeadersWidth = 40
        Me.DgvModulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvModulos.Size = New System.Drawing.Size(1199, 573)
        Me.DgvModulos.TabIndex = 30
        '
        'TiActualizaDgvModulos
        '
        Me.TiActualizaDgvModulos.Interval = 2000
        '
        'SpCapturaAuto
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Puerto Serial"
        '
        'CapturaBoletasPorLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 718)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GbGenerales)
        Me.Controls.Add(Me.MSMenu)
        Me.MainMenuStrip = Me.MSMenu
        Me.Name = "CapturaBoletasPorLotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Captura de Boletas Por Lotes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MSMenu.ResumeLayout(False)
        Me.MSMenu.PerformLayout()
        Me.GbGenerales.ResumeLayout(False)
        Me.GbGenerales.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgvModulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MSMenu As MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GbGenerales As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DgvModulos As DgvPlusCapturaBoletas
    Friend WithEvents TiActualizaDgvModulos As Timer
    Friend WithEvents CbPuertosSeriales As ComboBox
    Friend WithEvents BtAutomatico As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LbStatus As Label
    Friend WithEvents SpCapturaAuto As IO.Ports.SerialPort
    Friend WithEvents IncidenciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label

    Public Class DgvPlusCapturaBoletas
        Inherits DataGridView
        Protected Overrides Function ProcessDialogKey(keyData As Keys) As Boolean
            If keyData = Keys.Enter Then
                'If Me.CurrentCell.ColumnIndex = Me.ColumnCount - 1 Then
                CapturaBoletasPorLotes.EditaFila()
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
