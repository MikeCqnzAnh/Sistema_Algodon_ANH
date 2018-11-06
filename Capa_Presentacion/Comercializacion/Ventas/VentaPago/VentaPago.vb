Imports Capa_Operacion.Configuracion
Public Class VentaPago
    Private Sub ChkBEfectivo_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBEfectivo.CheckedChanged
        If ChkBEfectivo.Checked = True Then
            TbEfectivo.Enabled = True
        Else
            TbEfectivo.Enabled = False
        End If
    End Sub

    Private Sub ChkBDolares_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBDolares.CheckedChanged
        If ChkBDolares.Checked = True Then
            TbDolares.Enabled = True
            TbTipoCambio.Enabled = True
            TbAnticipoDlls.Enabled = True
        Else
            TbDolares.Enabled = False
            TbTipoCambio.Enabled = False
            TbAnticipoDlls.Enabled = False
        End If
    End Sub

    Private Sub CompraPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbIdProductor.Text = VarGlob2.IdProductor
        TbNombreProductor.Text = VarGlob2.NombreProductor
        TbPrecioQuintal.Text = VarGlob2.PrecioQuintal
        DgvResumenPagoPacas.Columns.Clear()
        DgvResumenPagoPacas.DataSource = _Tabla
        SumasTotales()
        Formatos()
    End Sub

    Private Sub SumasTotales()
        Dim Word As String = "Total"
        For Each row As DataGridViewRow In DgvResumenPagoPacas.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If (row.Cells("Clase").Value).ToString.Contains(Word) Then
                TbTotalPacas.Text = Val(CInt(TbTotalPacas.Text) + CDbl(row.Cells("Cantidad").Value))
                TbTotalKilos.Text = Val(TbTotalKilos.Text + CDbl(row.Cells("Kilos").Value))
                row.DefaultCellStyle.BackColor = Color.Gray
                Dim font = DgvResumenPagoPacas.DefaultCellStyle.Font
                row.DefaultCellStyle.Font = New Font(font, font.Style Or FontStyle.Bold)
            End If
        Next
    End Sub

    Private Sub Formatos()
        Dim TotalKilos As Double
        TotalKilos = TbTotalKilos.Text
        TbTotalKilos.Text = String.Format("{0:N0}", TotalKilos)
        TbEfectivo.Text = FormatCurrency(TbEfectivo.Text)
        TbSubtotal.Text = FormatCurrency(TbSubtotal.Text)
        TbDescuento.Text = FormatCurrency(TbDescuento.Text)
        TbTotal.Text = FormatCurrency(TbTotal.Text)
        TbTipoCambio.Text = FormatCurrency(TbTipoCambio.Text)
        DgvResumenPagoPacas.Columns("Clase").ReadOnly = True
    End Sub

    Private Sub PagarItem_Click(sender As Object, e As EventArgs) Handles PagarItem.Click
        Dim opc = MessageBox.Show("¿Estas seguro de cerrar esta compra?", "", MessageBoxButtons.YesNo)
        If opc = DialogResult.Yes Then

        Else
            Exit Sub
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class