﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CastigosResistenciaFibraVenta
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
        Me.DgvCastigoResistenciaFibra = New System.Windows.Forms.DataGridView()
        CType(Me.DgvCastigoResistenciaFibra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvCastigoResistenciaFibra
        '
        Me.DgvCastigoResistenciaFibra.AllowUserToAddRows = False
        Me.DgvCastigoResistenciaFibra.AllowUserToDeleteRows = False
        Me.DgvCastigoResistenciaFibra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCastigoResistenciaFibra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvCastigoResistenciaFibra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.DgvCastigoResistenciaFibra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvCastigoResistenciaFibra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCastigoResistenciaFibra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvCastigoResistenciaFibra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DgvCastigoResistenciaFibra.Location = New System.Drawing.Point(0, 0)
        Me.DgvCastigoResistenciaFibra.MultiSelect = False
        Me.DgvCastigoResistenciaFibra.Name = "DgvCastigoResistenciaFibra"
        Me.DgvCastigoResistenciaFibra.RowHeadersVisible = False
        Me.DgvCastigoResistenciaFibra.RowHeadersWidth = 40
        Me.DgvCastigoResistenciaFibra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCastigoResistenciaFibra.Size = New System.Drawing.Size(444, 500)
        Me.DgvCastigoResistenciaFibra.TabIndex = 14
        '
        'CastigosResistenciaFibraVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 500)
        Me.Controls.Add(Me.DgvCastigoResistenciaFibra)
        Me.Name = "CastigosResistenciaFibraVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CastigosResistenciaFibraVenta"
        CType(Me.DgvCastigoResistenciaFibra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvCastigoResistenciaFibra As DataGridView
End Class