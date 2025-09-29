<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acercade
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
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbversion = New System.Windows.Forms.Label()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.Capa_Presentacion.My.Resources.Resources.ICONO_CALCULA_COTTON_29
        Me.pictureBox1.Location = New System.Drawing.Point(25, 30)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(134, 129)
        Me.pictureBox1.TabIndex = 1
        Me.pictureBox1.TabStop = False
        '
        'lbversion
        '
        Me.lbversion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbversion.AutoSize = True
        Me.lbversion.BackColor = System.Drawing.Color.Transparent
        Me.lbversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbversion.ForeColor = System.Drawing.Color.Black
        Me.lbversion.Location = New System.Drawing.Point(42, 197)
        Me.lbversion.Name = "lbversion"
        Me.lbversion.Size = New System.Drawing.Size(0, 24)
        Me.lbversion.TabIndex = 3
        Me.lbversion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Acercade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 398)
        Me.Controls.Add(Me.lbversion)
        Me.Controls.Add(Me.pictureBox1)
        Me.Name = "Acercade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Acercade"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents lbversion As Label
End Class
