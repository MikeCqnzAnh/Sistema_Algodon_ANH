Imports Capa_Operacion.Configuracion
Public Class CompraPago
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
        LimpiarControles()
        TbIdProductor.Text = VarGlob2.IdProductor
        TbNombreProductor.Text = VarGlob2.NombreProductor
        TbPrecioQuintal.Text = VarGlob2.PrecioQuintal
        DgvResumenPagoPacas.Columns.Clear()
        DgvResumenPagoPacas.DataSource = _Tabla
        SumasTotales()
        Formatos()
        ConsultaTipoCambio()
        TotalCompra()
    End Sub
    Private Sub LimpiarControles()
        TbPrecioQuintal.Text = 0
        TbIdProductor.Text = ""
        TbNombreProductor.Text = ""
        DgvResumenPagoPacas.DataSource = ""
        DgvResumenPagoPacas.Columns.Clear()
        TbEfectivo.Text = 0
        TbDolares.Text = 0
        TbTipoCambio.Text = 0
        TbSubtotal.Text = 0
        TbDescuento.Text = 0
        TbTotal.Text = 0
        TbTotalPacas.Text = 0
        TbTotalKilos.Text = 0
        TbCastigoxlargo.Text = 0
        TbCastigoxmicro.Text = 0
        TbCastigoxresistencia.Text = 0
    End Sub
    Private Sub TotalCompra()
        Dim Dolares As Double = TbDolares.Text
        Dim TipoCambio As Double = TbTipoCambio.Text
        Dim SubTotal As Double = TbSubtotal.Text
        Dim Descuento As Double = TbDescuento.Text

        SubTotal = (Dolares * TipoCambio) - Descuento
        TbSubtotal.Text = Math.Round(SubTotal, 4)
        TbTotal.Text = SubTotal - Descuento
    End Sub
    Private Sub SumasTotales()
        Dim Word As String = "Total"
        For Each row As DataGridViewRow In DgvResumenPagoPacas.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If (row.Cells("Grade").Value).ToString.Contains(Word) Then
                TbTotalPacas.Text = Val(CInt(TbTotalPacas.Text) + CDbl(row.Cells("Cantidad").Value))
                TbTotalKilos.Text = Val(TbTotalKilos.Text + CDbl(row.Cells("Kilos").Value))
                TbDolares.Text = Val(TbDolares.Text + Math.Round(CDbl(row.Cells("TotalDlls").Value), 4))
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
        DgvResumenPagoPacas.Columns("Grade").ReadOnly = True
    End Sub
    Private Sub ConsultaTipoCambio()
        Dim tabla As New DataTable
        Dim EntidadMenuPrincipal As New Capa_Entidad.MenuPrincipal
        Dim NegocioMenuPrincipal As New Capa_Negocio.MenuPrincipal

        EntidadMenuPrincipal.IdMoneda = 2
        EntidadMenuPrincipal.Consulta = Consulta.ConsultaTipoDeCambio
        NegocioMenuPrincipal.Consultar(EntidadMenuPrincipal)
        tabla = EntidadMenuPrincipal.TablaConsulta
        TbTipoCambio.Text = tabla.Rows(0).Item("TipoDeCambio")
    End Sub
    Private Sub PagarItem_Click(sender As Object, e As EventArgs) Handles PagarItem.Click
        Dim opc = MessageBox.Show("¿Estas seguro de cerrar esta compra?", "", MessageBoxButtons.YesNo)
        If opc = DialogResult.Yes Then

        Else
            Exit Sub
        End If
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        _Tabla.Clear()
        Close()
    End Sub
End Class