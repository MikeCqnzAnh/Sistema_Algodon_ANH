Imports System.Net
Imports System.Net.NetworkInformation
Imports Capa_Operacion.Configuracion
Imports System.IO.Ports
Public Class ConfiguracionParametros
    Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\Conf\"
    Dim archivo As String = "config.ini"
    Dim EncabezadoModulos, EncabezadoPacas As String
    Dim IndicadorBoton As Integer
    Private Sub ConfiguracionParametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiaCampos()
        GetSerialPortNames()
        GetNameHost()
        ConsultaParametrosBanxico()
        'ConsultaParametros()
        LeerArchivoConfiguracion()
        CheckForIllegalCrossThreadCalls = False
        LbStatusPuerto.Text = "CAPTURA AUTOMATICA DESACTIVADA"
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
            CbPuertosSeriales.SelectedIndex = -1
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Setup_Puerto_Serie()
        Try
            With SpCapturaAuto
                If .IsOpen Then

                    .Close()

                End If
                .PortName = CbPuertosSeriales.Text

                .BaudRate = 9600 '// 9600 baud rate

                .DataBits = 8 '// 8 data bits

                .StopBits = IO.Ports.StopBits.One '// 1 Stop bit

                .Parity = IO.Ports.Parity.None '

                .DtrEnable = False

                .Handshake = IO.Ports.Handshake.None

                .ReadBufferSize = 4096

                .WriteBufferSize = 2048

                '.ReceivedBytesThreshold = 1

                .WriteTimeout = 500

                .Encoding = System.Text.Encoding.Default

                .Open() ' ABRE EL PUERTO SERIE
            End With
        Catch ex As Exception
            MsgBox("Error al abrir el puerto serial: " & ex.Message, MsgBoxStyle.Critical)
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
        If SpCapturaAuto.IsOpen = False Then
            GuardarConfiguracionParametrosBanxico()
            'GuardaConfiguracionParametros()
            CreaArchivoConfiguracion()
        Else
            MessageBox.Show("Desactivar captura automatica para guardar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
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
        PanelParametrosBascula.Enabled = False
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
        Me.Close()
    End Sub
    Private Sub Salir(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If SpCapturaAuto.IsOpen = True Then
            MessageBox.Show("La captura automatica esta activa, desactiva para salir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub
    Private Sub BtLimpiar_Click(sender As Object, e As EventArgs) Handles BtLimpiar.Click
        TbCadenaPuertoSerial.Text = ""
        TbNeto.Text = ""
        TbBruto.Text = ""
        TbTara.Text = ""
        TbIdCamion.Text = ""
        TbModulo.Text = ""
    End Sub

    Private Sub BtTestModulos_Click(sender As Object, e As EventArgs) Handles BtTestModulos.Click
        If LbStatusPuerto.Text = "CAPTURA AUTOMATICA DESACTIVADA" Then
            IndicadorBoton = 1
            CbPuertosSeriales.Enabled = False
            BtTestPacas.Enabled = False
            LbStatusPuerto.Text = "CAPTURA AUTOMATICA ACTIVADA"
            Setup_Puerto_Serie()
        Else
            BtTestPacas.Enabled = True
            CbPuertosSeriales.Enabled = True
            LbStatusPuerto.Text = "CAPTURA AUTOMATICA DESACTIVADA"
            SpCapturaAuto.Close()
        End If
    End Sub
    Private Sub BtTestPacas_Click(sender As Object, e As EventArgs) Handles BtTestPacas.Click
        If LbStatusPuerto.Text = "CAPTURA AUTOMATICA DESACTIVADA" Then
            IndicadorBoton = 2
            CbPuertosSeriales.Enabled = False
            BtTestModulos.Enabled = False
            LbStatusPuerto.Text = "CAPTURA AUTOMATICA ACTIVADA"
            Setup_Puerto_Serie()
        Else
            BtTestModulos.Enabled = True
            CbPuertosSeriales.Enabled = True
            LbStatusPuerto.Text = "CAPTURA AUTOMATICA DESACTIVADA"
            SpCapturaAuto.Close()
        End If
    End Sub
    Sub ReceiveSerialData_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SpCapturaAuto.DataReceived
        'While bandera = True
        Dim TipoFlete As String = ""
        Dim returnStr As String = ""
        Dim FechaActualizacion As DateTime
        Dim numeroRecorrido As Integer = 0
        Dim az As String     'utilizada para almacenar los datos que se reciben por el puerto
        Dim sib As Integer    ' sera utilizada como contador
        Dim msn(1000) As String
        Try
            If IndicadorBoton = 1 Then
                az = SpCapturaAuto.ReadExisting.Trim

                msn(sib) = az

                returnStr += msn(sib) + " "

                sib = sib + 1
            ElseIf IndicadorBoton = 2 Then
                az = SpCapturaAuto.ReadLine.Trim

                msn(sib) = az

                returnStr += msn(sib) + " "

                sib = sib + 1
            End If

        Catch ex As TimeoutException
            returnStr = "Error: Serial Port read timed out."
        Finally
        End Try
        If CbPuertosSeriales.Text <> "" Then
            TbCadenaPuertoSerial.Text += returnStr + vbCrLf
        Else
            MsgBox("No hay un puerto seleccionado.", MsgBoxStyle.OkOnly, "Aviso")
        End If
        returnStr = ""
    End Sub
    Private Sub CadenaModulosParametros(ByVal returnStr As String)
        Dim Resultado As String = ""
        If returnStr.Contains(TbIndicadorEntrada.Text) Then
            Resultado = returnStr.Substring(returnStr.IndexOf(RTrim(TbIndicadorID.Text)) + 1, returnStr.Length - returnStr.IndexOf(RTrim(TbIndicadorID.Text)) - 1)
            TbIdCamion.Text = Resultado.Substring(NuPosicionID.Value, NuCaracterId.Value)
            TbModulo.Text = RTrim(Resultado.Substring(NuPosicionModulo.Value, NuCaracterModulo.Value))

            Resultado = returnStr.Substring(returnStr.IndexOf(RTrim(TbIndicadorBruto.Text)) + 1, returnStr.Length - returnStr.IndexOf(RTrim(TbIndicadorBruto.Text)) - 1)
            TbBruto.Text = LTrim(Resultado.Substring(NuPosicionBruto.Value, NuCaracterBruto.Value))
            TbTara.Text = 0
            TbNeto.Text = 0
        ElseIf returnStr.Contains(TbIndicadorSalida.Text) Then
            Resultado = returnStr.Substring(returnStr.IndexOf(RTrim(TbIndicadorID.Text)) + 1, returnStr.Length - returnStr.IndexOf(RTrim(TbIndicadorID.Text)) - 1)
            TbIdCamion.Text = Resultado.Substring(NuPosicionID.Value, NuCaracterId.Value)
            TbModulo.Text = RTrim(Resultado.Substring(NuPosicionModulo.Value, NuCaracterModulo.Value))

            Resultado = returnStr.Substring(returnStr.IndexOf(RTrim(TbIndicadorBruto.Text)) + 1, returnStr.Length - returnStr.IndexOf(RTrim(TbIndicadorBruto.Text)) - 1)
            TbBruto.Text = LTrim(Resultado.Substring(NuPosicionBruto.Value, NuCaracterBruto.Value))

            Resultado = returnStr.Substring(returnStr.IndexOf(RTrim(TbIndicadorTara.Text)) + 1, returnStr.Length - returnStr.IndexOf(RTrim(TbIndicadorTara.Text)) - 1)
            TbTara.Text = LTrim(Resultado.Substring(NuPosicionTara.Value, NuCaracterTara.Value))

            Resultado = returnStr.Substring(returnStr.IndexOf(RTrim(TbIndicadorNeto.Text)) + 1, returnStr.Length - returnStr.IndexOf(RTrim(TbIndicadorNeto.Text)) - 1)
            TbNeto.Text = LTrim(Resultado.Substring(NuPosicionTara.Value, NuCaracterTara.Value))
        End If
    End Sub
    Private Sub CadenaPacasParametros(ByVal returnStr As String)
        Dim Resultado As String = ""
        If returnStr.Contains(TbPacasIndicadorBruto.Text) Then
            Resultado = returnStr.Substring(returnStr.IndexOf(RTrim(TbPacasIndicadorBruto.Text)), returnStr.Length - returnStr.IndexOf(RTrim(TbPacasIndicadorBruto.Text)))
            TbBruto.Text = LTrim(Resultado.Substring(NuPacasPosicionBruto.Value, NuPacasCaracterBruto.Value))
        End If
    End Sub

    Private Sub BtProbarConfiguracion_Click(sender As Object, e As EventArgs) Handles BtProbarConfiguracion.Click
        Select Case IndicadorBoton
            Case 1
                CadenaModulosParametros(TbCadenaPuertoSerial.Text)
            Case 2
                CadenaPacasParametros(TbCadenaPuertoSerial.Text)
        End Select
    End Sub
    Private Sub CreaArchivoConfiguracion()
        Dim fs As IO.FileStream
        ':::Validamos si la carpeta de ruta existe, si no existe la creamos
        Try
            If IO.File.Exists(Ruta & archivo) Then

                ':::Si la carpeta existe creamos o sobreescribios el archivo txt
                fs = IO.File.Create(Ruta & archivo)
                fs.Close()
                SobreEscribirConfiguracion()
            Else
                ':::Si la carpeta no existe la creamos
                IO.Directory.CreateDirectory(Ruta)

                ':::Una vez creada la carpeta creamos o sobreescribios el archivo txt
                fs = IO.File.Create(Ruta & archivo)
                fs.Close()
                SobreEscribirConfiguracion()
            End If

        Catch ex As Exception
            MsgBox("Se presento un problema al momento de crear el archivo: " & ex.Message, MsgBoxStyle.Critical, "")
        Finally
            PanelParametrosBascula.Enabled = False
        End Try
    End Sub
    Private Sub SobreEscribirConfiguracion()
        ':::Creamos un objeto de tipo StreamWriter que nos permite escribir en ficheros TXT
        Dim escribir As New IO.StreamWriter(Ruta & archivo)
        Dim DireccionIP As String = ""
        Try

            ':::Escribimos una linea en nuestro archivo TXT con el formato que este separado por coma (,)
            escribir.WriteLine("IndicadorID=" & TbIndicadorID.Text & vbCrLf & "PosicionID=" & NuPosicionID.Value & vbCrLf & "NoCaracteresID=" & NuCaracterId.Value & vbCrLf & "IndicadorModulo=" & TbIndicadorModulo.Text & vbCrLf & "PosicionModulo=" & NuPosicionModulo.Value & vbCrLf & "NoCaracteresModulo=" & NuCaracterModulo.Value & vbCrLf & "IndicadorEntrada=" & TbIndicadorEntrada.Text & vbCrLf & "PosicionEntrada=" & NuPosicionEntrada.Value & vbCrLf & "NoCaracteresEntrada=" & NuCaracterEntrada.Value & vbCrLf & "IndicadorSalida=" & TbIndicadorSalida.Text & vbCrLf & "PosicionSalida=" & NuPosicionSalida.Value & vbCrLf & "NoCaracteresSalida=" & NuCaracterSalida.Value & vbCrLf & "IndicadorBruto=" & TbIndicadorBruto.Text & vbCrLf & "PosicionBruto=" & NuPosicionBruto.Value & vbCrLf & "NoCaracteresBruto=" & NuCaracterBruto.Value & vbCrLf & "IndicadorTara=" & TbIndicadorTara.Text & vbCrLf & "PosicionTara=" & NuPosicionTara.Value & vbCrLf & "NoCaracteresTara=" & NuCaracterTara.Value & vbCrLf & "IndicadorNeto=" & TbIndicadorNeto.Text & vbCrLf & "PosicionNeto=" & NuPosicionNeto.Value & vbCrLf & "NoCaracteresNeto=" & NuCaracterNeto.Value & vbCrLf & "PesoMinPaca=" & NuPesoMinimoPaca.Value & vbCrLf & "IndicadorPacaBruto=" & TbPacasIndicadorBruto.Text & vbCrLf & "PosicionPacaBruto=" & NuPacasPosicionBruto.Value & vbCrLf & "NoCaracterPacaBruto=" & NuPacasCaracterBruto.Value & vbCrLf & "IndicadorPacaTara=" & TbPacasIndicadorTara.Text & vbCrLf & "PosicionPacaTara=" & NuPacasPosicionTara.Value & vbCrLf & "NoCaracteresPacaTara=" & NuPacasCaracterTara.Value & vbCrLf & "IndicadorPacaNeto=" & TbPacasIndicadorNeto.Text & vbCrLf & "PosicionPacaNeto=" & NuPacasPosicionNeto.Value & vbCrLf & "NoCaracteresPacaNeto=" & NuPacasCaracterNeto.Value & vbCrLf & "PuertoSerial=" & CbPuertosSeriales.Text)
            escribir.Close()
            ':::Limpiamos los TextBox
            ':::Llamamos nuestro procedimiento para leer el archivo TXT
            'LeerArchivo()
        Catch ex As Exception
            MsgBox("Se presento un problema al escribir en el archivo: " & ex.Message, MsgBoxStyle.Critical, " ")
        End Try
    End Sub
    Private Sub LeerArchivoConfiguracion()
        If IO.File.Exists(Ruta & archivo) Then
            ObtenerArchivoConfiguracion()
        Else
            CreaArchivoConfiguracion()
        End If
    End Sub
    Private Sub ObtenerArchivoConfiguracion()
        Dim leer As New IO.StreamReader(Ruta & archivo)

        Try
            While leer.Peek <> -1
                Dim linea As String = leer.ReadToEnd()
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                Dim ArregloCadena() As String = Split(linea, vbCrLf)
                TbIndicadorID.Text = ObtenerValor(ArregloCadena(0))
                NuPosicionID.Value = ObtenerValor(ArregloCadena(1))
                NuCaracterId.Value = ObtenerValor(ArregloCadena(2))
                TbIndicadorModulo.Text = ObtenerValor(ArregloCadena(3))
                NuPosicionModulo.Value = ObtenerValor(ArregloCadena(4))
                NuCaracterModulo.Value = ObtenerValor(ArregloCadena(5))
                TbIndicadorEntrada.Text = ObtenerValor(ArregloCadena(6))
                NuPosicionEntrada.Value = ObtenerValor(ArregloCadena(7))
                NuCaracterEntrada.Value = ObtenerValor(ArregloCadena(8))
                TbIndicadorSalida.Text = ObtenerValor(ArregloCadena(9))
                NuPosicionSalida.Value = ObtenerValor(ArregloCadena(10))
                NuCaracterSalida.Value = ObtenerValor(ArregloCadena(11))
                TbIndicadorBruto.Text = ObtenerValor(ArregloCadena(12))
                NuPosicionBruto.Value = ObtenerValor(ArregloCadena(13))
                NuCaracterBruto.Value = ObtenerValor(ArregloCadena(14))
                TbIndicadorTara.Text = ObtenerValor(ArregloCadena(15))
                NuPosicionTara.Value = ObtenerValor(ArregloCadena(16))
                NuCaracterTara.Value = ObtenerValor(ArregloCadena(17))
                TbIndicadorNeto.Text = ObtenerValor(ArregloCadena(18))
                NuPosicionNeto.Value = ObtenerValor(ArregloCadena(19))
                NuCaracterNeto.Value = ObtenerValor(ArregloCadena(20))
                NuPesoMinimoPaca.Value = ObtenerValor(ArregloCadena(21))
                TbPacasIndicadorBruto.Text = ObtenerValor(ArregloCadena(22))
                NuPacasPosicionBruto.Value = ObtenerValor(ArregloCadena(23))
                NuPacasCaracterBruto.Value = ObtenerValor(ArregloCadena(24))
                TbPacasIndicadorTara.Text = ObtenerValor(ArregloCadena(25))
                NuPacasPosicionTara.Value = ObtenerValor(ArregloCadena(26))
                NuPacasCaracterTara.Value = ObtenerValor(ArregloCadena(27))
                TbPacasIndicadorNeto.Text = ObtenerValor(ArregloCadena(28))
                NuPacasPosicionNeto.Value = ObtenerValor(ArregloCadena(29))
                NuPacasCaracterNeto.Value = ObtenerValor(ArregloCadena(30))
                CbPuertosSeriales.Text = ObtenerValor(ArregloCadena(31))
            End While

            leer.Close()

        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, " ")
        End Try
    End Sub
    Private Function ObtenerValor(ByVal cadena As String)
        Dim Resultado As String
        Dim ArregloCadena() As String = Split(cadena, "=")
        Resultado = ArregloCadena(1)
        Return Resultado
    End Function
End Class