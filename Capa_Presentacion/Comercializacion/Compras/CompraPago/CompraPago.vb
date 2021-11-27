﻿Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Imports System.IO
Public Class CompraPago
    Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\conf\"
    Dim archivo As String = "confemail.ini"
    Dim email, password, hostsmtp As String
    Dim puertosmtp As Integer
    Dim ConexionSSL As Boolean
    Dim rutadoc As String
    Private Sub CompraPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarControles()
        TbIdProductor.Text = VarGlob2.IdProductor
        TbNombreProductor.Text = VarGlob2.NombreProductor
        TbPrecioQuintal.Text = VarGlob2.PrecioQuintal
        TbIdCompra.Text = VarGlob2.IdCompra
        TbIdContrato.Text = VarGlob2.IdContrato
        DgvResumenPagoPacas.Columns.Clear()
        DgvResumenPagoPacas.DataSource = _Tabla
        'PropiedadesDgv()
        SumasTotales()
        ConsultaTipoCambio()
        TotalCompra()
        Formatos()
        ObtenerArchivoConfiguracion()
    End Sub
    Private Sub ObtenerArchivoConfiguracion()
        Dim leer As New StreamReader(Ruta & archivo)
        email = ""
        password = ""
        hostsmtp = ""
        puertosmtp = 0
        ConexionSSL = False
        Try
            While leer.Peek <> -1
                Dim linea As String = leer.ReadToEnd()
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                Dim arreglocadena() As String = Split(linea, vbCrLf)
                email = ObtenerValor(arreglocadena(0))
                password = ObtenerValor(arreglocadena(1))
                hostsmtp = ObtenerValor(arreglocadena(2))
                puertosmtp = ObtenerValor(arreglocadena(3))
                ConexionSSL = ObtenerValor(arreglocadena(4))
            End While
            leer.Close()
        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Function ObtenerValor(ByVal cadena As String)
        Dim Resultado As String
        Dim ArregloCadena() As String = Split(cadena, "=")
        Resultado = ArregloCadena(1)
        Return Resultado
    End Function
    Private Sub PropiedadesDgv()
        DgvResumenPagoPacas.Columns(4).Visible = False
        DgvResumenPagoPacas.Columns(5).Visible = False
        DgvResumenPagoPacas.Columns(6).Visible = False
        DgvResumenPagoPacas.Columns(7).Visible = False
        DgvResumenPagoPacas.Columns(8).Visible = False
    End Sub
    Private Sub LimpiarControles()
        TbPrecioQuintal.Text = 0
        TbIdProductor.Text = ""
        TbNombreProductor.Text = ""
        DgvResumenPagoPacas.DataSource = ""
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
    End Sub
    Private Sub TotalCompra()
        Dim SubTotal As Double = CDbl(TbSubtotal.Text)
        Dim TipoCambio As Double = CDbl(TbTipoCambio.Text)
        Dim CastigoDls As Double = CDbl(TbCastigoxlargo.Text) + CDbl(TbCastigoxmicro.Text) + CDbl(TbCastigoxresistencia.Text) + CDbl(TbCastigoxUI.Text)
        Dim TotalDls As Double
        Dim AnticipoDls As Double = CDbl(TbAnticipoDlls.Text)

        TbSumaCastigo.Text = CastigoDls
        TotalDls = SubTotal - CastigoDls - AnticipoDls
        TbTotalDls.Text = TotalDls
        TbTotalMxn.Text = Math.Round(TotalDls * TipoCambio, 4)
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
                TbSubtotal.Text = Val(TbSubtotal.Text + Math.Round(CDbl(row.Cells("TotalDlls").Value), 4))
                TbCastigoxUI.Text = Val(TbCastigoxUI.Text) + CDbl(row.Cells("CastigoUniformidad").Value)
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
    Private Sub PagarItem_Click(sender As Object, e As EventArgs) Handles PagarItem.Click
        Dim opc = MessageBox.Show("¿Estas seguro de cerrar esta compra?", "", MessageBoxButtons.YesNo)
        If opc = DialogResult.Yes Then
            GuardarCompraEnc()
            'ActualizaEstatusVenta()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub GuardarCompraEnc()
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        EntidadCompraPacasContrato.Guarda = Capa_Operacion.Configuracion.Guardar.GuardarCompraPacasEnc
        EntidadCompraPacasContrato.IdCompra = IIf(TbIdCompra.Text = "", 0, TbIdCompra.Text)
        EntidadCompraPacasContrato.IdContrato = TbIdContrato.Text
        EntidadCompraPacasContrato.IdProductor = TbIdProductor.Text
        EntidadCompraPacasContrato.IdPlanta = VarGlob2.IdPlanta
        EntidadCompraPacasContrato.IdModalidadCompra = VarGlob2.IdModalidadCompra
        EntidadCompraPacasContrato.FechaCompra = Now
        EntidadCompraPacasContrato.TotalPacas = TbTotalPacas.Text
        EntidadCompraPacasContrato.Observaciones = ""
        EntidadCompraPacasContrato.CastigoMicros = TbCastigoxmicro.Text
        EntidadCompraPacasContrato.CastigoLargoFibra = TbCastigoxlargo.Text
        EntidadCompraPacasContrato.CastigoResistenciaFibra = TbCastigoxresistencia.Text
        EntidadCompraPacasContrato.CastigoUniformidad = TbCastigoxUI.Text
        EntidadCompraPacasContrato.CastigoBarkLevel1 = 0
        EntidadCompraPacasContrato.CastigoBarkLevel2 = 0
        EntidadCompraPacasContrato.CastigoPrepLevel1 = 0
        EntidadCompraPacasContrato.CastigoPrepLevel2 = 0
        EntidadCompraPacasContrato.CastigoOtherLevel1 = 0
        EntidadCompraPacasContrato.CastigoOtherLevel2 = 0
        EntidadCompraPacasContrato.CastigoPlasticLevel1 = 0
        EntidadCompraPacasContrato.CastigoPlasticLevel2 = 0
        EntidadCompraPacasContrato.IdUnidadPeso = 0
        EntidadCompraPacasContrato.ValorConversacion = 0
        EntidadCompraPacasContrato.Unidad = 0
        EntidadCompraPacasContrato.InteresPesosMx = 0
        EntidadCompraPacasContrato.InteresDlls = 0
        EntidadCompraPacasContrato.PrecioQuintal = TbPrecioQuintal.Text
        EntidadCompraPacasContrato.PrecioQuintalBorregos = 0
        EntidadCompraPacasContrato.PrecioDolar = TbTipoCambio.Text
        EntidadCompraPacasContrato.Subtotal = TbSubtotal.Text
        EntidadCompraPacasContrato.CastigoDls = TbSumaCastigo.Text
        EntidadCompraPacasContrato.AnticipoDls = TbAnticipoDlls.Text
        EntidadCompraPacasContrato.TotalDlls = TbTotalDls.Text
        EntidadCompraPacasContrato.TotalPesosMx = TbTotalMxn.Text
        EntidadCompraPacasContrato.IdEstatusCompra = 1
        EntidadCompraPacasContrato.FechaCreacion = Now.Date
        EntidadCompraPacasContrato.FechaActualizacion = Now
        NegocioCompraPacasContrato.Guardar(EntidadCompraPacasContrato)
        TbIdCompra.Text = EntidadCompraPacasContrato.IdCompra
    End Sub
    Private Sub ActualizaEstatusVenta()
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        EntidadCompraPacasContrato.Actualiza = Actualiza.ActualizaEstatus
        EntidadCompraPacasContrato.TablaGeneral = DataGridADatatable(DgvResumenPagoPacas)
        NegocioCompraPacasContrato.Actualizar(EntidadCompraPacasContrato)
    End Sub
    Private Function DataGridADatatable(ByVal DataGridEnvia As DataGridView) As DataTable
        Dim dt As New DataTable
        Dim r As DataRow

        dt.Columns.Add("BaleID", Type.GetType("System.Int32"))
        dt.Columns.Add("IdCompraEnc", Type.GetType("System.Int32"))
        dt.Columns.Add("EstatusVenta", Type.GetType("System.Int32"))

        For i = 0 To DataGridEnvia.Rows.Count - 1
            r = dt.NewRow
            If DataGridEnvia.Item("BaleID", i).Value.ToString <> "" Then
                r("BaleID") = DataGridEnvia.Item("BaleID", i).Value.ToString
                r("IdCompraEnc") = TbIdCompra.Text
                r("EstatusVenta") = 1
                dt.Rows.Add(r)
            End If
        Next
        Return dt
    End Function
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
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
        If TbIdCompra.Text <> "" Then
            Dim ReporteCompraPacasResumen As New RepCompraPacasResumen(TbIdCompra.Text)
            ReporteCompraPacasResumen.ShowDialog()
        Else
            MessageBox.Show("El Id de compra no es valido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ImpResumenDeLiquidacionesItem_Click(sender As Object, e As EventArgs) Handles ImpResumenDeLiquidacionesItem.Click
        If TbIdCompra.Text <> "" Then
            Dim ReporteLiquidacionPacasResumen As New RepLiquidacionPacasResumen(TbIdCompra.Text, TbIdProductor.Text, TbNombreProductor.Text)
            ReporteLiquidacionPacasResumen.ShowDialog()
        Else
            MessageBox.Show("El Id de compra no es valido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ImpDetallesDeCompraItem_Click(sender As Object, e As EventArgs) Handles ImpDetallesDeCompraItem.Click
        If TbIdCompra.Text <> "" Then
            Dim ReporteCompraPacasDetallado As New RepCompraPacasDetallado(TbIdCompra.Text)
            ReporteCompraPacasDetallado.ShowDialog()
        Else
            MessageBox.Show("El Id de compra no es valido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub EnviarEmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarEmailToolStripMenuItem.Click
        Dim Destinatario As String = ""
        Dim asunto As String = ""
        Dim Mensaje As String = ""
        If TbIdCompra.Text <> "" Then
            asunto = "Compra de pacas con el ID " & TbIdContrato.Text & " a nombre de " & TbNombreProductor.Text & "."
            Mensaje = "Se realizo compra por un total de " & TbTotalPacas.Text & " Pacas con un precio de " & TbPrecioQuintal.Text & " Quintales." & vbCrLf & "Enviado desde SIA."
            Destinatario = InputBox("Para:", "Complete la direccion de correo del destinatario.")
            enviarCorreo(email, password, Mensaje, asunto, Destinatario, puertosmtp, hostsmtp, ConexionSSL)
        End If
    End Sub
End Class