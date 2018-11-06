<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaTierrasChecks
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
        Me.BtBuscar = New System.Windows.Forms.Button()
        Me.DgvConsultaTierrasChecks = New System.Windows.Forms.DataGridView()
        Me.BtAceptar = New System.Windows.Forms.Button()
        CType(Me.DgvConsultaTierrasChecks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtBuscar
        '
        Me.BtBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtBuscar.Location = New System.Drawing.Point(12, 326)
        Me.BtBuscar.Name = "BtBuscar"
        Me.BtBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtBuscar.TabIndex = 18
        Me.BtBuscar.Text = "Consultar"
        Me.BtBuscar.UseVisualStyleBackColor = True
        '
        'DgvConsultaTierrasChecks
        '
        Me.DgvConsultaTierrasChecks.AllowUserToAddRows = False
        Me.DgvConsultaTierrasChecks.AllowUserToDeleteRows = False
        Me.DgvConsultaTierrasChecks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvConsultaTierrasChecks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvConsultaTierrasChecks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvConsultaTierrasChecks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvConsultaTierrasChecks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConsultaTierrasChecks.Location = New System.Drawing.Point(12, 12)
        Me.DgvConsultaTierrasChecks.Name = "DgvConsultaTierrasChecks"
        Me.DgvConsultaTierrasChecks.RowHeadersVisible = False
        Me.DgvConsultaTierrasChecks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvConsultaTierrasChecks.ShowEditingIcon = False
        Me.DgvConsultaTierrasChecks.Size = New System.Drawing.Size(660, 308)
        Me.DgvConsultaTierrasChecks.TabIndex = 19
        '
        'BtAceptar
        '
        Me.BtAceptar.Location = New System.Drawing.Point(597, 326)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtAceptar.TabIndex = 20
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.UseVisualStyleBackColor = True
        '
        'ConsultaTierrasChecks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 361)
        Me.Controls.Add(Me.BtAceptar)
        Me.Controls.Add(Me.DgvConsultaTierrasChecks)
        Me.Controls.Add(Me.BtBuscar)
        Me.Name = "ConsultaTierrasChecks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Tierras"
        CType(Me.DgvConsultaTierrasChecks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtBuscar As Button
    Friend WithEvents DgvConsultaTierrasChecks As DataGridView
    Friend WithEvents BtAceptar As Button
End Class
