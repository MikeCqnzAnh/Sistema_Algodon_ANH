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
    Private Sub PropiedadesDgv()
        DgvResumenPagoPacas.Columns(4).Visible = False
        DgvResumenPagoPacas.Columns(5).Visible = False
        DgvResumenPagoPacas.Columns(6).Visible = False
        DgvResumenPagoPacas.Columns(7).Visible = False
        DgvResumenPagoPacas.Columns(8).Visible = False
    End Sub
    Private Sub CompraPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarControles()
        TbIdProductor.Text = VarGlob2.IdProductor
        TbNombreProductor.Text = VarGlob2.NombreProductor
        TbPrecioQuintal.Text = VarGlob2.PrecioQuintal
        TbIdCompra.Text = VarGlob2.IdCompra
        TbIdContrato.Text = VarGlob2.IdContrato
        DgvResumenPagoPacas.Columns.Clear()
        DgvResumenPagoPacas.DataSource = _Tabla
        PropiedadesDgv()
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
        TbTotalMxn.Text = 0
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
        Dim SumaDescuento As Double = CDbl(TbCastigoxlargo.Text) + CDbl(TbCastigoxmicro.Text) + CDbl(TbCastigoxresistencia.Text)
        Dim Descuento As Double = (SumaDescuento * TipoCambio)
        Dim Total As Double
        TbDescuento.Text = Math.Round(Descuento, 2)
        SubTotal = (Dolares * TipoCambio) - Descuento
        TbSubtotal.Text = Math.Round(SubTotal, 4)
        Total = SubTotal - Descuento
        TbTotalMxn.Text = Math.Round(Total, 4)
    End Sub
    Private Sub SumasTotales()
        Dim Word As String = "Total"
        For Each row As DataGridViewRow In DgvResumenPagoPacas.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If (row.Cells("Grade").Value).ToString.Contains(Word) Then
                row.DefaultCellStyle.BackColor = Color.Gray
                Dim font = DgvResumenPagoPacas.DefaultCellStyle.Font
                row.DefaultCellStyle.Font = New Font(font, font.Style Or FontStyle.Bold)
                TbTotalPacas.Text = Val(CInt(TbTotalPacas.Text) + CDbl(row.Cells("Cantidad").Value))
                TbTotalKilos.Text = Val(TbTotalKilos.Text + CDbl(row.Cells("Kilos").Value))
                TbDolares.Text = Val(TbDolares.Text + Math.Round(CDbl(row.Cells("TotalDlls").Value), 4))
                TbCastigoxlargo.Text = Val(TbCastigoxlargo.Text) + CDbl(row.Cells("CastigoLargoFibra").Value)
                TbCastigoxmicro.Text = Val(TbCastigoxmicro.Text) + CDbl(row.Cells("CastigoMicros").Value)
                TbCastigoxresistencia.Text = Val(TbCastigoxresistencia.Text) + CDbl(row.Cells("CastigoResistenciaFibra").Value)
            End If
        Next
    End Sub
    Private Sub FormatoGrid()
        Dim Word As String = "Total"
        For Each row As DataGridViewRow In DgvResumenPagoPacas.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If (row.Cells("Grade").Value).ToString.Contains(Word) Then
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
        TbTotalMxn.Text = FormatCurrency(TbTotalMxn.Text)
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
            GuardarCompraEnc()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub GuardarCompraEnc()
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        EntidadCompraPacasContrato.Guarda = Capa_Operacion.Configuracion.Guardar.GuardarCompraPacasEnc
        EntidadCompraPacasContrato.IdCompra = IIf(TbIdCompra.Text = "", 0, TbIdCompra.Text)
        EntidadCompraPacasContrato.IdContrato = tbidcontrato.Text
        EntidadCompraPacasContrato.IdProductor = TbIdProductor.Text
        EntidadCompraPacasContrato.IdPlanta = VarGlob2.IdPlanta
        EntidadCompraPacasContrato.IdModalidadCompra = VarGlob2.IdModalidadCompra
        EntidadCompraPacasContrato.FechaCompra = Now
        EntidadCompraPacasContrato.TotalPacas = TbTotalPacas.Text
        EntidadCompraPacasContrato.Observaciones = ""
        EntidadCompraPacasContrato.CastigoMicros = TbCastigoxmicro.Text
        EntidadCompraPacasContrato.CastigoLargoFibra = TbCastigoxlargo.Text
        EntidadCompraPacasContrato.CastigoResistenciaFibra = TbCastigoxresistencia.Text
        EntidadCompraPacasContrato.TotalPesosMx = TbSubtotal.Text
        EntidadCompraPacasContrato.TotalDlls = TbDolares.Text
        EntidadCompraPacasContrato.InteresPesosMx = 0
        EntidadCompraPacasContrato.InteresDlls = 0
        EntidadCompraPacasContrato.PrecioQuintal = TbPrecioQuintal.Text
        EntidadCompraPacasContrato.PrecioQuintalBorregos = 0
        EntidadCompraPacasContrato.PrecioDolar = TbTipoCambio.Text
        EntidadCompraPacasContrato.Descuento = TbDescuento.Text
        EntidadCompraPacasContrato.Total = TbTotalMxn.Text
        EntidadCompraPacasContrato.IdEstatusCompra = 1
        NegocioCompraPacasContrato.Guardar(EntidadCompraPacasContrato)
        TbIdCompra.Text = EntidadCompraPacasContrato.IdCompra
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        _Tabla.Clear()
        Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormatoGrid()
    End Sub
End Class