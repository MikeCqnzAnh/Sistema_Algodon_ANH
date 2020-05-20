Imports Capa_Operacion.Configuracion
Public Class VentaPago
    Dim IdModalidadVenta, IdunidadPeso As Integer
    Dim ValorConversion As Double
    Private Sub VentaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarControles()
        TbIdComprador.Text = VarGlob2.IdComprador
        TbNombreComprador.Text = VarGlob2.NombreComprador
        TbPrecioQuintal.Text = VarGlob2.PrecioQuintal
        TbIdContrato.Text = VarGlob2.IdContrato
        TbIdVenta.Text = VarGlob2.IdVenta
        IdModalidadVenta = VarGlob2.IdModalidadVenta
        IdunidadPeso = VarGlob2.IdUnidadPeso
        ValorConversion = VarGlob2.ValorConversion
        DgvResumenPagoPacas.DataSource = _Tabla
        PropiedadesDgv()
        CargarCombos(IdunidadPeso)
        SumasTotales()
        ConsultaTipoCambio()
        TotalVenta()
        Formatos()
    End Sub
    Private Sub PropiedadesDgv()
        DgvResumenPagoPacas.Columns(5).Visible = False
        DgvResumenPagoPacas.Columns(6).Visible = False
        DgvResumenPagoPacas.Columns(20).Visible = False
        DgvResumenPagoPacas.Columns(0).HeaderText = "Etiqueta"
        DgvResumenPagoPacas.Columns(1).HeaderText = "Clase"
        DgvResumenPagoPacas.Columns(7).HeaderText = "Castigo UI"
        DgvResumenPagoPacas.Columns(8).HeaderText = "Castigo RF"
        DgvResumenPagoPacas.Columns(9).HeaderText = "Castigo Mic"
        DgvResumenPagoPacas.Columns(10).HeaderText = "Castigo LF"
        DgvResumenPagoPacas.Columns(11).HeaderText = "Bark Level 1"
        DgvResumenPagoPacas.Columns(12).HeaderText = "Bark Level 2"
        DgvResumenPagoPacas.Columns(13).HeaderText = "Prep Level 1"
        DgvResumenPagoPacas.Columns(14).HeaderText = "Prep Level 2"
        DgvResumenPagoPacas.Columns(15).HeaderText = "Other Level 1"
        DgvResumenPagoPacas.Columns(16).HeaderText = "Other Level 2"
        DgvResumenPagoPacas.Columns(17).HeaderText = "Plastic Level 1"
        DgvResumenPagoPacas.Columns(18).HeaderText = "Plastic Level 2"
        DgvResumenPagoPacas.Columns(19).HeaderText = "Precio"
        DgvResumenPagoPacas.Columns(21).HeaderText = "Importe Dls"
    End Sub
    Private Sub CargarCombos(ByVal IdUnidadPeso As Integer)
        '-------------------------COMBO UNIDAD PESO
        Dim Tabla1 As New DataTable
        Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
        Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
        EntidadContratosAlgodon.Consulta = Consulta.ConsultaUnidadPeso
        NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
        Tabla1 = EntidadContratosAlgodon.TablaConsulta
        CbUnidadPeso.DataSource = Tabla1
        CbUnidadPeso.ValueMember = "IdUnidadPeso"
        CbUnidadPeso.DisplayMember = "Descripcion"
        CbUnidadPeso.SelectedValue = IdUnidadPeso
    End Sub
    Private Sub LimpiarControles()
        TbPrecioQuintal.Text = 0
        TbIdComprador.Text = ""
        TbNombreComprador.Text = ""
        DgvResumenPagoPacas.Columns.Clear()
        TbTipoCambio.Text = 0
        TbSubtotal.Text = 0
        TbTotalMxn.Text = 0
        TbTotalPacas.Text = 0
        TbTotalKilos.Text = 0
        TbCastigoxlargo.Text = 0
        TbCastigoxmicro.Text = 0
        TbCastigoxresistencia.Text = 0
        TbCastigoxUI.Text = 0
        TbBerkLevel1.Text = 0
        TbBerkLevel2.Text = 0
        TbPrepLevel1.Text = 0
        TbPrepLevel2.Text = 0
        TbOtherLevel1.Text = 0
        TbOtherLevel2.Text = 0
        TbPlasticLevel1.Text = 0
        TbPlasticLevel2.Text = 0
    End Sub
    Private Sub TotalVenta()
        Dim SubTotal As Double = CDbl(TbSubtotal.Text)
        Dim TipoCambio As Double = CDbl(TbTipoCambio.Text)
        Dim CastigoDls As Double = CDbl(TbCastigoxlargo.Text) + CDbl(TbCastigoxmicro.Text) + CDbl(TbCastigoxresistencia.Text) + CDbl(TbCastigoxUI.Text) + CDbl(TbBerkLevel1.Text) + CDbl(TbBerkLevel2.Text) + CDbl(TbPrepLevel1.Text) + CDbl(TbPrepLevel2.Text) + CDbl(TbOtherLevel1.Text) + CDbl(TbOtherLevel2.Text) + CDbl(TbPlasticLevel1.Text) + CDbl(TbPlasticLevel2.Text)
        Dim TotalDls As Double
        Dim AnticipoDls As Double = CDbl(TbAnticipoDlls.Text)
        TbSumaCastigo.Text = CastigoDls
        TotalDls = SubTotal - CastigoDls - AnticipoDls
        TbTotalDls.Text = TotalDls
        TbTotalMxn.Text = Math.Round(TotalDls * TipoCambio, 4)
    End Sub
    Private Sub SumasTotales()
        Dim Word As String = "Total"
        Dim TotalPeso As Double = 0
        For Each row As DataGridViewRow In DgvResumenPagoPacas.Rows
            If row.Cells("Grade").Value.ToString.Contains(Word) Then
                Dim font = DgvResumenPagoPacas.DefaultCellStyle.Font
                TbTotalPacas.Text = Val(CInt(TbTotalPacas.Text) + CDbl(row.Cells("Cantidad").Value))
                TotalPeso = Val(TotalPeso + CDbl(row.Cells("Kilos").Value))
                TbSubtotal.Text = Val(TbSubtotal.Text + Math.Round(CDbl(row.Cells("TotalDlls").Value), 4))
                TbCastigoxUI.Text = Val(TbCastigoxUI.Text) + CDbl(row.Cells("CastigoUI").Value)
                TbCastigoxlargo.Text = Val(TbCastigoxlargo.Text) + CDbl(row.Cells("CastigoLargoFibra").Value)
                TbCastigoxmicro.Text = Val(TbCastigoxmicro.Text) + CDbl(row.Cells("CastigoMicros").Value)
                TbCastigoxresistencia.Text = Val(TbCastigoxresistencia.Text) + CDbl(row.Cells("CastigoResistenciaFibra").Value)
                TbBerkLevel1.Text = Val(TbBerkLevel1.Text) + CDbl(row.Cells("CastigoBarkLevel1").Value)
                TbBerkLevel2.Text = Val(TbBerkLevel2.Text) + CDbl(row.Cells("CastigoBarkLevel2").Value)
                TbPrepLevel1.Text = Val(TbPrepLevel1.Text) + CDbl(row.Cells("CastigoPrepLevel1").Value)
                TbPrepLevel2.Text = Val(TbPrepLevel2.Text) + CDbl(row.Cells("CastigoPrepLevel2").Value)
                TbOtherLevel1.Text = Val(TbOtherLevel1.Text) + CDbl(row.Cells("CastigoOtherLevel1").Value)
                TbOtherLevel2.Text = Val(TbOtherLevel2.Text) + CDbl(row.Cells("CastigoOtherLevel2").Value)
                TbPlasticLevel1.Text = Val(TbPlasticLevel1.Text) + CDbl(row.Cells("CastigoPlasticLevel1").Value)
                TbPlasticLevel2.Text = Val(TbPlasticLevel2.Text) + CDbl(row.Cells("CastigoPlasticLevel2").Value)
                row.DefaultCellStyle.BackColor = Color.Gray
                row.DefaultCellStyle.Font = New Font(font, font.Style Or FontStyle.Bold)
            End If
        Next
        TbTotalKilos.Text = TotalPeso * ValorConversion
    End Sub
    Private Sub FormatoGrid()
        Dim Word As String = "Total"
        For Each row As DataGridViewRow In DgvResumenPagoPacas.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If (row.Cells("Grade").Value).ToString.Contains(Word) Then
                Dim font = DgvResumenPagoPacas.DefaultCellStyle.Font
                row.DefaultCellStyle.BackColor = Color.Gray
                row.DefaultCellStyle.Font = New Font(font, font.Style Or FontStyle.Bold)
            End If
        Next
    End Sub
    Private Sub Formatos()
        Dim TotalKilos As Double
        TotalKilos = TbTotalKilos.Text
        TbTotalKilos.Text = String.Format("{0:N2}", TotalKilos)
        TbSubtotal.Text = FormatCurrency(TbSubtotal.Text)
        TbSumaCastigo.Text = FormatCurrency(TbSumaCastigo.Text)
        TbAnticipoDlls.Text = FormatCurrency(TbAnticipoDlls.Text)
        TbTipoCambio.Text = FormatCurrency(TbTipoCambio.Text)
        TbTotalDls.Text = FormatCurrency(TbTotalDls.Text)
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
    Private Sub PagarItem_Click_1(sender As Object, e As EventArgs) Handles PagarItem.Click
        Dim opc = MessageBox.Show("¿Estas seguro de cerrar esta compra?", "", MessageBoxButtons.YesNo)
        If opc = DialogResult.Yes Then
            GuardarVentaEnc()
            ActualizaEstatusVenta()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub GuardarVentaEnc()
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        EntidadVentaPacasContrato.Guarda = Capa_Operacion.Configuracion.Guardar.GuardarVentaPacasEnc
        EntidadVentaPacasContrato.IdVenta = IIf(TbIdVenta.Text = "", 0, TbIdVenta.Text)
        EntidadVentaPacasContrato.IdContrato = TbIdContrato.Text
        EntidadVentaPacasContrato.IdComprador = TbIdComprador.Text
        EntidadVentaPacasContrato.IdPlanta = VarGlob2.IdPlanta
        EntidadVentaPacasContrato.IdModalidadVenta = VarGlob2.IdModalidadVenta
        EntidadVentaPacasContrato.FechaVenta = Now
        EntidadVentaPacasContrato.TotalPacas = TbTotalPacas.Text
        EntidadVentaPacasContrato.Observaciones = ""
        EntidadVentaPacasContrato.CastigoMicros = TbCastigoxmicro.Text
        EntidadVentaPacasContrato.CastigoLargoFibra = TbCastigoxlargo.Text
        EntidadVentaPacasContrato.CastigoResistenciaFibra = TbCastigoxresistencia.Text
        EntidadVentaPacasContrato.InteresPesosMx = 0
        EntidadVentaPacasContrato.InteresDlls = 0
        EntidadVentaPacasContrato.PrecioQuintal = TbPrecioQuintal.Text
        EntidadVentaPacasContrato.PrecioQuintalBorregos = 0
        EntidadVentaPacasContrato.PrecioDolar = TbTipoCambio.Text
        EntidadVentaPacasContrato.SubTotal = TbSubtotal.Text
        EntidadVentaPacasContrato.CastigoDls = TbSumaCastigo.Text
        EntidadVentaPacasContrato.AnticipoDls = TbAnticipoDlls.Text
        EntidadVentaPacasContrato.TotalDlls = TbTotalDls.Text
        EntidadVentaPacasContrato.TotalPesosMx = TbTotalMxn.Text
        EntidadVentaPacasContrato.IdEstatusVenta = 1
        NegocioVentaPacasContrato.Guardar(EntidadVentaPacasContrato)
        TbIdVenta.Text = EntidadVentaPacasContrato.IdVenta
    End Sub
    Private Sub ActualizaEstatusVenta()
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        EntidadVentaPacasContrato.Actualiza = Actualiza.ActualizaEstatus
        EntidadVentaPacasContrato.TablaGeneral = DataGridADatatable(DgvResumenPagoPacas)
        NegocioVentaPacasContrato.Actualizar(EntidadVentaPacasContrato)
    End Sub
    Private Function DataGridADatatable(ByVal DataGridEnvia As DataGridView) As DataTable
        Dim dt As New DataTable
        Dim r As DataRow

        dt.Columns.Add("BaleID", Type.GetType("System.Int32"))
        dt.Columns.Add("IdVentaEnc", Type.GetType("System.Int32"))
        dt.Columns.Add("EstatusVenta", Type.GetType("System.Int32"))

        For i = 0 To DataGridEnvia.Rows.Count - 1
            r = dt.NewRow
            If DataGridEnvia.Item("BaleID", i).Value.ToString <> "" Then
                r("BaleID") = DataGridEnvia.Item("BaleID", i).Value.ToString
                r("IdVentaEnc") = TbIdVenta.Text
                r("EstatusVenta") = 2
                dt.Rows.Add(r)
            End If
        Next
        Return dt
    End Function
    Private Sub SalirToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        _Tabla.Clear()
        Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FormatoGrid()
    End Sub
    Private Sub TbAnticipoDlls_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbAnticipoDlls.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            Dim SubTotaldls As Double = CDbl(TbSubtotal.Text)
            Dim CastigoDls As Double = CDbl(TbSumaCastigo.Text)
            Dim AnticipoDls As Double = CDbl(TbAnticipoDlls.Text)
            Dim TotalDls As Double = CDbl(TbTotalDls.Text)
            Dim TipoCambio As Double = CDbl(TbTipoCambio.Text)
            Dim TotalMxn As Double = CDbl(TbTotalMxn.Text)

            TotalDls = SubTotaldls - AnticipoDls - CastigoDls
            TotalMxn = TotalDls * TipoCambio
            TbTotalDls.Text = TotalDls
            TbTotalMxn.Text = TotalMxn
            Formatos()
        End If
    End Sub
    Private Sub ImpResumenDePacasItem_Click(sender As Object, e As EventArgs) Handles ImpResumenDePacasItem.Click
        If TbIdVenta.Text <> "" Then
            Dim ReporteVentaPacasResumen As New RepVentaPacasResumen(TbIdVenta.Text)
            ReporteVentaPacasResumen.ShowDialog()
        Else
            MessageBox.Show("El Id de compra no es valido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ImpDetallesDeVentaItem_Click(sender As Object, e As EventArgs) Handles ImpDetallesDeVentaItem.Click
        If TbIdVenta.Text <> "" Then
            Dim ReporteVentaPacasDetallado As New RepVentaPacasDetallado(TbIdVenta.Text)
            ReporteVentaPacasDetallado.ShowDialog()
        Else
            MessageBox.Show("El Id de compra no es valido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class