Imports System.Net
Imports System.Net.NetworkInformation
Imports Capa_Operacion.Configuracion
Imports System.IO.Ports
Public Class ConfiguracionParametros
    Private Sub ConfiguracionParametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiaCampos()
        GetSerialPortNames()
        GetNameHost()
        ConsultaParametrosBanxico()
        ConsultaParametros()
    End Sub
    Private Sub GetSerialPortNames()
        Dim l As Integer
        Dim ncom As String
        Try
            CbPuertosSeriales.Items.Clear()
            For Each sp As String In My.Computer.Ports.SerialPortNames
                l = sp.Length
                If ((sp(l - 1) >= "0") And (sp(l - 1) <= "9")) Then
                    CbPuertosSeriales.Items.Add(sp)
                Else
                    ncom = sp.Substring(0, l - 1)
                    CbPuertosSeriales.Items.Add(ncom)
                End If
            Next
            If CbPuertosSeriales.Items.Count >= 1 Then
                CbPuertosSeriales.Text = CbPuertosSeriales.Items(0)
            Else
                CbPuertosSeriales.Text = ""
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub LimpiaCampos()
        TsIdConfiguracion.Text = ""
        TsIpComputadora.Text = ""
        TsNombrePc.Text = ""
        CbPuertosSeriales.Text = ""
        TbIndicadorID.Text = ""
        TbIndicadorEntrada.Text = ""
        TbIndicadorSalida.Text = ""
        TbIndicadorBruto.Text = ""
        TbIndicadorTara.Text = ""
        TbIndicadorNeto.Text = ""
        TbPacasIndicadorBruto.Text = ""
        TbPacasIndicadorTara.Text = ""
        TbPacasIndicadorNeto.Text = ""
        NuPosicionID.Value = 0
        NuPosicionEntrada.Value = 0
        NuPosicionSalida.Value = 0
        NuPosicionBruto.Value = 0
        NuPosicionTara.Value = 0
        NuPosicionNeto.Value = 0
        NuPacasPosicionBruto.Value = 0
        NuPacasPosicionTara.Value = 0
        NuPacasPosicionNeto.Value = 0
        NuCaracterId.Value = 0
        NuCaracterEntrada.Value = 0
        NuCaracterSalida.Value = 0
        NuCaracterBruto.Value = 0
        NuCaracterTara.Value = 0
        NuCaracterNeto.Value = 0
        NuPacasCaracterBruto.Value = 0
        NuPacasCaracterTara.Value = 0
        NuPacasCaracterNeto.Value = 0
        TbIdSerieBanxico.Text = ""
        TbPalabraPosicion.Text = ""
        NuPosicion.Value = 0
        NuLongitud.Value = 0
        NuPesoMinimoPaca.Value = 0
    End Sub
    Private Sub GetNameHost()
        Dim strHostName As String
        Dim strIPAddress As String
        strHostName = Dns.GetHostName()
        strIPAddress = Dns.Resolve(strHostName).AddressList(0).ToString()
        TsIpComputadora.Text = strIPAddress
        TsNombrePc.Text = strHostName
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        GuardarConfiguracionParametrosBanxico()
        GuardaConfiguracionParametros()
    End Sub
    Private Sub GuardaConfiguracionParametros()
        Dim EntidadConfiguracionParametros As New Capa_Entidad.ConfiguracionParametros
        Dim NegocioConfiguracionParametros As New Capa_Negocio.ConfiguracionParametros
        EntidadConfiguracionParametros.IdConfiguracion = IIf(TsIdConfiguracion.Text = "", 0, TsIdConfiguracion.Text)
        EntidadConfiguracionParametros.NombrePC = TsNombrePc.Text
        EntidadConfiguracionParametros.DireccionIP = TsIpComputadora.Text
        EntidadConfiguracionParametros.NombrePuerto = CbPuertosSeriales.Text
        EntidadConfiguracionParametros.IndicadorID = TbIndicadorID.Text
        EntidadConfiguracionParametros.IndicadorModulo = TbIndicadorModulo.Text
        EntidadConfiguracionParametros.IndicadorEntrada = TbIndicadorEntrada.Text
        EntidadConfiguracionParametros.IndicadorSalida = TbIndicadorSalida.Text
        EntidadConfiguracionParametros.IndicadorPesoBruto = TbIndicadorBruto.Text
        EntidadConfiguracionParametros.IndicadorTara = TbIndicadorTara.Text
        EntidadConfiguracionParametros.IndicadorNeto = TbIndicadorNeto.Text
        EntidadConfiguracionParametros.IndicadorPacasBruto = TbPacasIndicadorBruto.Text
        EntidadConfiguracionParametros.IndicadorPacasTara = TbPacasIndicadorTara.Text
        EntidadConfiguracionParametros.IndicadorPacasNeto = TbPacasIndicadorNeto.Text
        EntidadConfiguracionParametros.PosicionID = NuPosicionID.Value
        EntidadConfiguracionParametros.PosicionModulo = NuPosicionModulo.Value
        EntidadConfiguracionParametros.PosicionEntradas = NuPosicionEntrada.Value
        EntidadConfiguracionParametros.PosicionSalida = NuPosicionSalida.Value
        EntidadConfiguracionParametros.PosicionBruto = NuPosicionBruto.Value
        EntidadConfiguracionParametros.PosicionTara = NuPosicionTara.Value
        EntidadConfiguracionParametros.PosicionNeto = NuPosicionNeto.Value
        EntidadConfiguracionParametros.PosicionPacasBruto = NuPacasPosicionBruto.Value
        EntidadConfiguracionParametros.PosicionPacasTara = NuPacasPosicionTara.Value
        EntidadConfiguracionParametros.PosicionPacasNeto = NuPacasPosicionNeto.Value
        EntidadConfiguracionParametros.NoCaracterID = NuCaracterId.Value
        EntidadConfiguracionParametros.NoCaracterModulo = NuCaracterModulo.Value
        EntidadConfiguracionParametros.NoCaracterEntrada = NuCaracterEntrada.Value
        EntidadConfiguracionParametros.NoCaracterSalida = NuCaracterSalida.Value
        EntidadConfiguracionParametros.NoCaracterBruto = NuCaracterBruto.Value
        EntidadConfiguracionParametros.NoCaracterTara = NuCaracterTara.Value
        EntidadConfiguracionParametros.NoCaracterNeto = NuCaracterNeto.Value
        EntidadConfiguracionParametros.NoCaracterPacasBruto = NuPacasCaracterBruto.Value
        EntidadConfiguracionParametros.NoCaracterPacasTara = NuPacasCaracterTara.Value
        EntidadConfiguracionParametros.NoCaracterPacasNeto = NuPacasCaracterNeto.Value
        EntidadConfiguracionParametros.PesoMinimoPaca = NuPesoMinimoPaca.Value
        'EntidadConfiguracionParametros.TextoCadenaPesoPacas = NuCaracterBoletaTara.Value
        'EntidadConfiguracionParametros.IdSerieBanxico = TbIdSerieBanxico.Text
        'EntidadConfiguracionParametros.CampoValorBanxico = TbPalabraPosicion.Text
        'EntidadConfiguracionParametros.PosicionValorBanxico = NuPosicion.Value
        'EntidadConfiguracionParametros.LongitudValorBanxico = NuLongitud.Value
        'EntidadConfiguracionParametros.SitioBanxico = TbSitioBanxico.Text
        NegocioConfiguracionParametros.Guardar(EntidadConfiguracionParametros)
        TsIdConfiguracion.Text = EntidadConfiguracionParametros.IdConfiguracion
        MsgBox("Realizado Correctamente")
        ConsultaParametros()
    End Sub
    Private Sub GuardarConfiguracionParametrosBanxico()
        Dim EntidadConfiguracionParametros As New Capa_Entidad.ConfiguracionParametros
        Dim NegocioConfiguracionParametros As New Capa_Negocio.ConfiguracionParametros
        EntidadConfiguracionParametros.IdConfiguracion = IIf(TbIdConfiguracionBanxico.Text = "", 0, TbIdConfiguracionBanxico.Text)
        EntidadConfiguracionParametros.IdSerieBanxico = TbIdSerieBanxico.Text
        EntidadConfiguracionParametros.CampoValorBanxico = TbPalabraPosicion.Text
        EntidadConfiguracionParametros.PosicionValorBanxico = NuPosicion.Value
        EntidadConfiguracionParametros.LongitudValorBanxico = NuLongitud.Value
        EntidadConfiguracionParametros.SitioBanxico = TbSitioBanxico.Text
        NegocioConfiguracionParametros.GuardarBanxico(EntidadConfiguracionParametros)
        TsIdConfiguracion.Text = EntidadConfiguracionParametros.IdConfiguracion
        MsgBox("Realizado Correctamente")
        ConsultaParametrosBanxico()
    End Sub
    Private Sub ConsultaParametrosBanxico()
        Dim EntidadConfiguracionParametros As New Capa_Entidad.ConfiguracionParametros
        Dim NegocioConfiguracionParametros As New Capa_Negocio.ConfiguracionParametros
        Dim Tabla As New DataTable
        EntidadConfiguracionParametros.Consulta = Consulta.ConsultaExterna
        NegocioConfiguracionParametros.Consultar(EntidadConfiguracionParametros)
        Tabla = EntidadConfiguracionParametros.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            Exit Sub
        End If
        TbIdConfiguracionBanxico.Text = Tabla.Rows(0).Item("IdConfiguracionBanxico")
        TbIdSerieBanxico.Text = Tabla.Rows(0).Item("IdSerieBanxico")
        TbPalabraPosicion.Text = Tabla.Rows(0).Item("CampoValorBanxico")
        NuPosicion.Value = Tabla.Rows(0).Item("PosicionValorBanxico")
        NuLongitud.Value = Tabla.Rows(0).Item("LongitudValorBanxico")
        TbSitioBanxico.Text = Tabla.Rows(0).Item("SitioBanxico")
    End Sub
    Private Sub ConsultaParametros()
        Dim EntidadConfiguracionParametros As New Capa_Entidad.ConfiguracionParametros
        Dim NegocioConfiguracionParametros As New Capa_Negocio.ConfiguracionParametros
        Dim Tabla As New DataTable
        Try
            EntidadConfiguracionParametros.IdConfiguracion = IIf(TsIdConfiguracion.Text = "", 0, TsIdConfiguracion.Text)
            EntidadConfiguracionParametros.DireccionIP = TsIpComputadora.Text
            EntidadConfiguracionParametros.Consulta = Consulta.ConsultaBasica
            NegocioConfiguracionParametros.Consultar(EntidadConfiguracionParametros)
            Tabla = EntidadConfiguracionParametros.TablaConsulta
            If Tabla.Rows.Count = 0 Then
                Exit Sub
            End If
            TsIdConfiguracion.Text = Tabla.Rows(0).Item("IdConfiguracion")
            TsNombrePc.Text = Tabla.Rows(0).Item("NombrePC")
            TsIpComputadora.Text = Tabla.Rows(0).Item("DireccionIP")
            CbPuertosSeriales.Text = Tabla.Rows(0).Item("NombrePuerto")
            TbIndicadorID.Text = Tabla.Rows(0).Item("IndicadorID")
            TbIndicadorModulo.Text = Tabla.Rows(0).Item("IndicadorModulo")
            TbIndicadorEntrada.Text = Tabla.Rows(0).Item("IndicadorEntrada")
            TbIndicadorSalida.Text = Tabla.Rows(0).Item("IndicadorSalida")
            TbIndicadorBruto.Text = Tabla.Rows(0).Item("IndicadorBruto")
            TbIndicadorTara.Text = Tabla.Rows(0).Item("IndicadorTara")
            TbIndicadorNeto.Text = Tabla.Rows(0).Item("IndicadorNeto")
            TbPacasIndicadorBruto.Text = Tabla.Rows(0).Item("IndicadorPacasBruto")
            TbPacasIndicadorTara.Text = Tabla.Rows(0).Item("IndicadorPacasTara")
            TbPacasIndicadorNeto.Text = Tabla.Rows(0).Item("IndicadorPacasNeto")
            NuPosicionID.Value = Tabla.Rows(0).Item("PosicionID")
            NuPosicionModulo.Value = Tabla.Rows(0).Item("PosicionModulo")
            NuPosicionEntrada.Value = Tabla.Rows(0).Item("PosicionEntrada")
            NuPosicionSalida.Value = Tabla.Rows(0).Item("PosicionSalida")
            NuPosicionBruto.Value = Tabla.Rows(0).Item("PosicionBruto")
            NuPosicionTara.Value = Tabla.Rows(0).Item("PosicionTara")
            NuPosicionNeto.Value = Tabla.Rows(0).Item("PosicionNeto")
            NuPacasPosicionBruto.Value = Tabla.Rows(0).Item("PacasPosicionBruto")
            NuPacasPosicionTara.Value = Tabla.Rows(0).Item("PacasPosicionTara")
            NuPacasPosicionNeto.Value = Tabla.Rows(0).Item("PacasPosicionNeto")
            NuCaracterId.Value = Tabla.Rows(0).Item("CaracterID")
            NuCaracterModulo.Value = Tabla.Rows(0).Item("CaracterModulo")
            NuCaracterEntrada.Value = Tabla.Rows(0).Item("CaracterEntrada")
            NuCaracterSalida.Value = Tabla.Rows(0).Item("CaracterSalida")
            NuCaracterBruto.Value = Tabla.Rows(0).Item("CaracterBruto")
            NuCaracterTara.Value = Tabla.Rows(0).Item("CaracterTara")
            NuCaracterNeto.Value = Tabla.Rows(0).Item("CaracterNeto")
            NuPacasCaracterBruto.Value = Tabla.Rows(0).Item("PacasCaracterBruto")
            NuPacasCaracterTara.Value = Tabla.Rows(0).Item("PacasCaracterTara")
            NuPacasCaracterNeto.Value = Tabla.Rows(0).Item("PacasCaracterNeto")
            NuPesoMinimoPaca.Value = Tabla.Rows(0).Item("PesoMinimoPaca")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            PanelParametrosBascula.Enabled = False
        End Try
    End Sub
    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        Dim opc As DialogResult = MsgBox("¿Desea modificar campos al registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

        If opc = DialogResult.Yes Then

            PanelParametrosBascula.Enabled = True

        ElseIf opc = DialogResult.No Then

            PanelParametrosBascula.Enabled = False

        End If

    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class