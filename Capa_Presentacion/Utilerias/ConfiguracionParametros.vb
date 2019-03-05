Imports System.Net
Imports System.Net.NetworkInformation
Imports Capa_Operacion.Configuracion
Imports System.IO.Ports
Public Class ConfiguracionParametros
    Private Sub ConfiguracionParametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiaCampos()
        GetSerialPortNames()
        GetNameHost()
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
        NuInicialModulo.Value = 0
        NuInicialTransporte.Value = 0
        NuInicialBoletaBruto.Value = 0
        NuInicialBoletaNeto.Value = 0
        NuInicialBoletaTara.Value = 0
        NuInicialPacas.Value = 0
        NuCaracterModulo.Value = 0
        NuCaracterTransporte.Value = 0
        NuCaracterBoletaBruto.Value = 0
        NuCaracterBoletaTara.Value = 0
        NuCaracterBoletaNeto.Value = 0
        NuCaracterPacas.Value = 0
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
        Dim EntidadConfiguracionParametros As New Capa_Entidad.ConfiguracionParametros
        Dim NegocioConfiguracionParametros As New Capa_Negocio.ConfiguracionParametros
        EntidadConfiguracionParametros.IdConfiguracion = IIf(TsIdConfiguracion.Text = "", 0, TsIdConfiguracion.Text)
        EntidadConfiguracionParametros.NombrePC = TsNombrePc.Text
        EntidadConfiguracionParametros.DireccionIP = TsIpComputadora.Text
        EntidadConfiguracionParametros.NombrePuerto = CbPuertosSeriales.Text
        EntidadConfiguracionParametros.InicialModulo = NuInicialModulo.Value
        EntidadConfiguracionParametros.NoCaracterModulo = NuCaracterModulo.Value
        EntidadConfiguracionParametros.InicialTransporte = NuInicialTransporte.Value
        EntidadConfiguracionParametros.NoCaracterTransporte = NuCaracterTransporte.Value
        EntidadConfiguracionParametros.InicialBoletasBruto = NuInicialBoletaBruto.Value
        EntidadConfiguracionParametros.NoCaracterBoletasBruto = NuCaracterBoletaBruto.Value
        EntidadConfiguracionParametros.InicialBoletasTara = NuInicialBoletaTara.Value
        EntidadConfiguracionParametros.NoCaracterBoletasTara = NuCaracterBoletaTara.Value
        EntidadConfiguracionParametros.InicialBoletasNeto = NuInicialBoletaNeto.Value
        EntidadConfiguracionParametros.NoCaracterBoletasNeto = NuCaracterBoletaNeto.Value
        EntidadConfiguracionParametros.InicialPacas = NuInicialPacas.Value
        EntidadConfiguracionParametros.NoCaracteresPacas = NuCaracterPacas.Value
        NegocioConfiguracionParametros.Guardar(EntidadConfiguracionParametros)
        TsIdConfiguracion.Text = EntidadConfiguracionParametros.IdConfiguracion
        MsgBox("Realizado Correctamente")
        ConsultaParametros()
    End Sub
    Private Sub ConsultaParametros()
        Dim EntidadConfiguracionParametros As New Capa_Entidad.ConfiguracionParametros
        Dim NegocioConfiguracionParametros As New Capa_Negocio.ConfiguracionParametros
        Dim Tabla As New DataTable
        EntidadConfiguracionParametros.IdConfiguracion = IIf(TsIdConfiguracion.Text = "", 0, TsIdConfiguracion.Text)
        EntidadConfiguracionParametros.DireccionIP = TsIpComputadora.Text
        EntidadConfiguracionParametros.Consulta = Consulta.ConsultaBasica
        NegocioConfiguracionParametros.Consultar(EntidadConfiguracionParametros)
        Tabla = EntidadConfiguracionParametros.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            Exit Sub
        End If
        TsIdConfiguracion.Text = Tabla.Rows(0).Item("IdConfiguracion")
        CbPuertosSeriales.Text = Tabla.Rows(0).Item("NombrePuerto")
        NuInicialModulo.Value = Tabla.Rows(0).Item("InicialModulo")
        NuCaracterModulo.Value = Tabla.Rows(0).Item("NoCaracterModulo")
        NuInicialTransporte.Value = Tabla.Rows(0).Item("InicialTransporte")
        NuCaracterTransporte.Value = Tabla.Rows(0).Item("NoCaracterTransporte")
        NuInicialBoletaBruto.Value = Tabla.Rows(0).Item("InicialBoletasBruto")
        NuCaracterBoletaBruto.Value = Tabla.Rows(0).Item("NoCaracterBoletasBruto")
        NuInicialBoletaTara.Value = Tabla.Rows(0).Item("InicialBoletasTara")
        NuCaracterBoletaTara.Value = Tabla.Rows(0).Item("NoCaracterBoletasTara")
        NuInicialBoletaNeto.Value = Tabla.Rows(0).Item("InicialBoletasNeto")
        NuCaracterBoletaNeto.Value = Tabla.Rows(0).Item("NoCaracterBoletasNeto")
        NuInicialPacas.Value = Tabla.Rows(0).Item("InicialPacas")
        NuCaracterPacas.Value = Tabla.Rows(0).Item("NoCaracteresPacas")
    End Sub
End Class