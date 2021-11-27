Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class VentaPago
    Dim ValorConversion, PrecioQuintal, KilosNeto As Decimal
    Dim IdVenta, IdComprador, IdContrato, IdModalidadVenta, IdUnidadPeso, IdModoMicros, IdModoLargo, IdModoResistencia, IdModoUniformidad As Integer
    Dim Nombrecomprador As String
    Dim EstatusPesoNeto, CheckMic, CheckLargo, CheckResistencia, CheckUniformidad As Boolean
    Dim TablaResumen As New DataTable
    Public Sub New(ByVal IdVent As Integer, ByVal IdComp As Integer, ByVal IdCont As Integer, ByVal IdModVenta As Integer, ByVal IdUniPeso As Integer, ByVal Nombre As String, ByVal Quintal As Decimal, ByVal Conversion As Decimal, ByVal EstatusNeto As Boolean, ByVal KilosNet As Decimal, ByVal ckmic As Boolean, ByVal cklar As Boolean, ByVal ckres As Boolean, ByVal ckuni As Boolean, ByVal IdModoMic As Integer, ByVal IdModoLar As Integer, ByVal IdModoRes As Integer, ByVal IdModoUni As Integer)
        InitializeComponent()
        IdVenta = IdVent
        IdComprador = IdComp
        IdContrato = IdCont
        IdModalidadVenta = IdModVenta
        IdUnidadPeso = IdUniPeso
        Nombrecomprador = Nombre
        PrecioQuintal = Quintal
        ValorConversion = Conversion
        EstatusPesoNeto = EstatusNeto
        KilosNeto = KilosNet
        CheckMic = ckmic
        CheckLargo = cklar
        CheckResistencia = ckres
        CheckUniformidad = ckuni
        IdModoMicros = IdModoMic
        IdModoLargo = IdModoLar
        IdModoResistencia = IdModoRes
        IdModoUniformidad = IdModoUni
        'TablaResumen = TbResumen
    End Sub
    Private Sub VentaPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarControles()
        'TbIdComprador.Text = VarGlob2.IdComprador
        'TbNombreComprador.Text = VarGlob2.NombreComprador
        'TbPrecioQuintal.Text = VarGlob2.PrecioQuintal
        'TbIdContrato.Text = VarGlob2.IdContrato
        'TbIdVenta.Text = VarGlob2.IdVenta
        'IdModalidadVenta = VarGlob2.IdModalidadVenta
        'IdunidadPeso = VarGlob2.IdUnidadPeso
        'ValorConversion = VarGlob2.ValorConversion
        'DgvResumenPagoPacas.DataSource = TablaResumen
        TbIdComprador.Text = IdComprador
        TbNombreComprador.Text = Nombrecomprador
        TbPrecioQuintal.Text = PrecioQuintal
        TbIdContrato.Text = IdContrato
        TbIdVenta.Text = IdVenta
        CkTara.Checked = EstatusPesoNeto
        NuPesoTara.Value = KilosNeto
        ChMicros.Checked = CheckMic
        ChLargoFibra.Checked = CheckLargo
        ChResistenciaFibra.Checked = CheckResistencia
        ChUniformidad.Checked = CheckUniformidad
        'DgvResumenPagoPacas.DataSource = TablaResumen
        CargaDetalleVentaPacas()
        PropiedadesDgv()
        CargarCombos(IdUnidadPeso)
        CargaCombosParametros()
        SumasTotales()
        ConsultaTipoCambio()
        TotalVenta()
        Formatos()
    End Sub
    Private Sub CargaCombosParametros()
        Dim EntidadContratosAlgodonCompradores As New Capa_Entidad.ContratosAlgodonCompradores
        Dim NegocioContratosAlgodonCompradores As New Capa_Negocio.ContratosAlgodonCompradores
        '------------------------COMBO MICROS VENTA
        Dim Tabla2 As New DataTable
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaMicrosVentaCmb
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        Tabla2 = EntidadContratosAlgodonCompradores.TablaConsulta
        CbModoMicros.DataSource = Tabla2
        CbModoMicros.ValueMember = "IdModoEncabezado"
        CbModoMicros.DisplayMember = "Descripcion"
        CbModoMicros.SelectedValue = IdModoMicros
        '------------------------COMBO LARGO FIBRA VENTA
        Dim Tabla3 As New DataTable
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaLargoFibraVentaCmb
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        Tabla3 = EntidadContratosAlgodonCompradores.TablaConsulta
        CbModoLargoFibra.DataSource = Tabla3
        CbModoLargoFibra.ValueMember = "IdModoEncabezado"
        CbModoLargoFibra.DisplayMember = "Descripcion"
        CbModoLargoFibra.SelectedValue = IdModoLargo
        '------------------------COMBO RESISTENCIA VENTA
        Dim Tabla4 As New DataTable
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaResistenciaVentaCmb
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        Tabla4 = EntidadContratosAlgodonCompradores.TablaConsulta
        CbModoResistenciaFibra.DataSource = Tabla4
        CbModoResistenciaFibra.ValueMember = "IdModoEncabezado"
        CbModoResistenciaFibra.DisplayMember = "Descripcion"
        CbModoResistenciaFibra.SelectedValue = IdModoResistencia
        '------------------------COMBO UNIFORMIDAD VENTA
        Dim Tabla5 As New DataTable
        EntidadContratosAlgodonCompradores.Consulta = Consulta.ConsultaUniformidadVentaCmb
        NegocioContratosAlgodonCompradores.Consultar(EntidadContratosAlgodonCompradores)
        Tabla5 = EntidadContratosAlgodonCompradores.TablaConsulta
        CbModoUniformidad.DataSource = Tabla5
        CbModoUniformidad.ValueMember = "IdModoEncabezado"
        CbModoUniformidad.DisplayMember = "Descripcion"
        CbModoUniformidad.SelectedValue = IdModoUniformidad
    End Sub
    Private Sub PropiedadesDgv()
        'DgvResumenPagoPacas.Columns(5).Visible = False
        'DgvResumenPagoPacas.Columns(6).Visible = False
        'DgvResumenPagoPacas.Columns(20).Visible = False
        'DgvResumenPagoPacas.Columns(0).HeaderText = "Etiqueta"
        'DgvResumenPagoPacas.Columns(1).HeaderText = "Clase"
        'DgvResumenPagoPacas.Columns(2).HeaderText = "Castigo UI"
        'DgvResumenPagoPacas.Columns(3).HeaderText = "Castigo RF"
        'DgvResumenPagoPacas.Columns(4).HeaderText = "Castigo Mic"
        'DgvResumenPagoPacas.Columns(5).HeaderText = "Castigo LF"
        'DgvResumenPagoPacas.Columns(11).HeaderText = "Bark Level 1"
        'DgvResumenPagoPacas.Columns(12).HeaderText = "Bark Level 2"
        'DgvResumenPagoPacas.Columns(13).HeaderText = "Prep Level 1"
        'DgvResumenPagoPacas.Columns(14).HeaderText = "Prep Level 2"
        'DgvResumenPagoPacas.Columns(15).HeaderText = "Other Level 1"
        'DgvResumenPagoPacas.Columns(16).HeaderText = "Other Level 2"
        'DgvResumenPagoPacas.Columns(17).HeaderText = "Plastic Level 1"
        'DgvResumenPagoPacas.Columns(18).HeaderText = "Plastic Level 2"
        'DgvResumenPagoPacas.Columns(19).HeaderText = "Precio"
        'DgvResumenPagoPacas.Columns(21).HeaderText = "Importe Dls"
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
        CkTara.Checked = False
        NuPesoTara.Value = 0
    End Sub
    Private Sub TotalVenta()
        Dim SubTotal As Decimal = CDec(TbSubtotal.Text)
        Dim TipoCambio As Decimal = CDec(TbTipoCambio.Text)
        Dim CastigoDls As Decimal = CDec(TbCastigoxlargo.Text) + CDec(TbCastigoxmicro.Text) + CDec(TbCastigoxresistencia.Text) + CDec(TbCastigoxUI.Text) + CDec(TbBerkLevel1.Text) + CDec(TbBerkLevel2.Text) + CDec(TbPrepLevel1.Text) + CDec(TbPrepLevel2.Text) + CDec(TbOtherLevel1.Text) + CDec(TbOtherLevel2.Text) + CDec(TbPlasticLevel1.Text) + CDec(TbPlasticLevel2.Text)
        Dim TotalDls As Decimal
        Dim AnticipoDls As Decimal = CDec(TbAnticipoDlls.Text)
        TbSumaCastigo.Text = CastigoDls
        TotalDls = Math.Round(SubTotal, 2) - Math.Round(CastigoDls, 2) - Math.Round(AnticipoDls, 2)
        TbTotalDls.Text = TotalDls
        TbTotalMxn.Text = Math.Round(TotalDls * TipoCambio, 4)
    End Sub
    Private Sub SumasTotales()
        'Dim Word As String = "Total"
        Dim TotalPeso As Decimal = 0
        TbTotalPacas.Text = DgvResumenPagoPacas.RowCount
        For Each row As DataGridViewRow In DgvResumenPagoPacas.Rows
            'If row.Cells("Grade").Value.ToString.Contains(Word) Then
            Dim font = DgvResumenPagoPacas.DefaultCellStyle.Font
            'TbTotalPacas.Text = Val(CInt(TbTotalPacas.Text) + CDbl(row.Cells("Cantidad").Value))
            TotalPeso = TotalPeso + IIf(IdUnidadPeso = 1, row.Cells("Kilos").Value, row.Cells("Quintales").Value)
            TbSubtotal.Text += Math.Round(CDec(row.Cells("Importe Dls").Value), 4)
            TbCastigoxUI.Text = Val(TbCastigoxUI.Text) + Math.Round(CDec(row.Cells("Castigo UI").Value), 4)
            TbCastigoxlargo.Text = Val(TbCastigoxlargo.Text) + Math.Round(CDec(row.Cells("Castigo LF").Value), 4)
            TbCastigoxmicro.Text = Val(TbCastigoxmicro.Text) + Math.Round(CDec(row.Cells("Castigo Mic").Value), 4)
            TbCastigoxresistencia.Text = Val(TbCastigoxresistencia.Text) + Math.Round(CDec(row.Cells("Castigo RF").Value), 4)
            TbBerkLevel1.Text = Val(TbBerkLevel1.Text) + CDec(row.Cells("Bark Level 1").Value)
            TbBerkLevel2.Text = Val(TbBerkLevel2.Text) + CDec(row.Cells("Bark Level 2").Value)
            TbPrepLevel1.Text = Val(TbPrepLevel1.Text) + CDec(row.Cells("Prep Level 1").Value)
            TbPrepLevel2.Text = Val(TbPrepLevel2.Text) + CDec(row.Cells("Prep Level 2").Value)
            TbOtherLevel1.Text = Val(TbOtherLevel1.Text) + CDec(row.Cells("Other Level 1").Value)
            TbOtherLevel2.Text = Val(TbOtherLevel2.Text) + CDec(row.Cells("Other Level 2").Value)
            TbPlasticLevel1.Text = Val(TbPlasticLevel1.Text) + CDec(row.Cells("Plastic Level 1").Value)
            TbPlasticLevel2.Text = Val(TbPlasticLevel2.Text) + CDec(row.Cells("Plastic Level 2").Value)
            'row.DefaultCellStyle.BackColor = Color.Gray
            'row.DefaultCellStyle.Font = New Font(font, font.Style Or FontStyle.Bold)
            'End If
        Next
        TbTotalKilos.Text = TotalPeso
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
        Dim TotalKilos As Decimal
        TotalKilos = TbTotalKilos.Text
        TbTotalKilos.Text = String.Format("{0:N2}", TotalKilos)
        TbSubtotal.Text = FormatCurrency(TbSubtotal.Text)
        TbCastigoxUI.Text = FormatCurrency(TbCastigoxUI.Text)
        TbCastigoxlargo.Text = FormatCurrency(TbCastigoxlargo.Text)
        TbCastigoxmicro.Text = FormatCurrency(TbCastigoxmicro.Text)
        TbCastigoxresistencia.Text = FormatCurrency(TbCastigoxresistencia.Text)
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
        Try
            EntidadVentaPacasContrato.Guarda = Guardar.GuardarVentaPacasEnc
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub CargaDetalleVentaPacas()
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        Try
            EntidadVentaPacasContrato.Consulta = Consulta.ConsultaDetallada
            EntidadVentaPacasContrato.IdVenta = IIf(TbIdVenta.Text = "", 0, TbIdVenta.Text)
            NegocioVentaPacasContrato.Consultar(EntidadVentaPacasContrato)
            DgvResumenPagoPacas.DataSource = EntidadVentaPacasContrato.TablaConsulta
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ActualizaEstatusVenta()
        Dim EntidadVentaPacasContrato As New Capa_Entidad.VentaPacasContrato
        Dim NegocioVentaPacasContrato As New Capa_Negocio.VentaPacasContrato
        Try
            EntidadVentaPacasContrato.Actualiza = Actualiza.ActualizaEstatus
            EntidadVentaPacasContrato.TablaGeneral = DataGridADatatable(DgvResumenPagoPacas)
            NegocioVentaPacasContrato.Actualizar(EntidadVentaPacasContrato)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function DataGridADatatable(ByVal DataGridEnvia As DataGridView) As DataTable
        Dim dt As New DataTable
        Dim r As DataRow

        dt.Columns.Add("BaleID", Type.GetType("System.Int64"))
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

    Private Sub ImpCastigoPorRangosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpCastigoPorRangosToolStripMenuItem.Click
        If TbIdVenta.Text <> "" Then
            Dim RepCastPorRangos As New RepCastigoPorRangos(TbIdVenta.Text, CbModoMicros.SelectedValue, CbModoResistenciaFibra.SelectedValue, CbModoLargoFibra.SelectedValue, CbModoUniformidad.SelectedValue)
            RepCastPorRangos.ShowDialog()
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        _Tabla.Clear()
        Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FormatoGrid()
    End Sub
    Private Sub TbAnticipoDlls_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbAnticipoDlls.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            Dim SubTotaldls As Decimal = CDec(TbSubtotal.Text)
            Dim CastigoDls As Decimal = CDec(TbSumaCastigo.Text)
            Dim AnticipoDls As Decimal = CDec(TbAnticipoDlls.Text)
            Dim TotalDls As Decimal = CDec(TbTotalDls.Text)
            Dim TipoCambio As Decimal = CDec(TbTipoCambio.Text)
            Dim TotalMxn As Decimal = CDec(TbTotalMxn.Text)

            TotalDls = SubTotaldls - AnticipoDls - CastigoDls
            TotalMxn = TotalDls * TipoCambio
            TbTotalDls.Text = TotalDls
            TbTotalMxn.Text = TotalMxn
            Formatos()
        End If
    End Sub
    Private Sub ImpResumenDePacasItem_Click(sender As Object, e As EventArgs) Handles ImpResumenDePacasItem.Click
        If TbIdVenta.Text <> "" Then
            Dim ReporteVentaPacasResumen As New RepVentaPacasResumen(TbIdVenta.Text, EstatusPesoNeto, KilosNeto)
            ReporteVentaPacasResumen.ShowDialog()
        Else
            MessageBox.Show("El Id de compra no es valido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ImpDetalleDeCastigosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpDetalleDeCastigosToolStripMenuItem.Click
        If TbIdVenta.Text <> "" Then
            Dim ReporteVentaDetalleCastigo As New RepVentaDetalleCastigo(TbIdVenta.Text)
            ReporteVentaDetalleCastigo.ShowDialog()
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