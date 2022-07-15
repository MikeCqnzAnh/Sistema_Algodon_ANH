Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.Net
Imports System.Text.RegularExpressions
Imports System.IO

Public Class MenuPrincipal
    Dim Sitio, Serie, Token As String
    'Dim PosicionValorBanxico, LongitudValorBanxico As Integer
    Dim TablaEnc As New DataTable
    Dim valor As String = ""
    Dim Version As String
    Dim NombreArchivo As String = "\Version.txt"
    Dim CarpetaOrigen As String = "\\192.168.10.29\Scanner\Miguel\UPDATE"
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LeerArchivo()
        If Version > Application.ProductVersion Then
            BuscarActualizacion.ShowDialog()
        End If
        consultaItems()
        ConsultaParametros()
        TipoUsuario()
    End Sub
    Private Sub LeerArchivo()
        Dim leer As New StreamReader(CarpetaOrigen & NombreArchivo)

        Try
            While leer.Peek <> -1
                Dim linea As String = leer.ReadLine()
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                Dim ArregloCadena() As String = Split(linea, "|")
                Version = ArregloCadena(0)
            End While

            leer.Close()

        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, " ")
        End Try
    End Sub
    Private Sub consultaItems()
        llenaTablaMenuRoles()
        For Each miitem As ToolStripMenuItem In MSMenu.Items
            recorrer(miitem)
        Next
    End Sub
    Private Sub recorrer(ByVal Oneitem As ToolStripMenuItem)
        For Each otroItem As ToolStripMenuItem In Oneitem.DropDownItems
            Dim lineText As String = otroItem.Tag
            Dim ArrayText() As String
            ArrayText = lineText.Split(",")
            Try
                For Each TablaPerfiles As DataRow In TablaEnc.Rows
                    If TablaPerfiles("IdNodo") = ArrayText(0) And TablaPerfiles("IdPadre") = ArrayText(1) Then
                        otroItem.Enabled = TablaPerfiles("IdEstatus")
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            If otroItem.DropDownItems.Count > 0 Then recorrer(otroItem)
        Next
    End Sub
    Private Sub llenaTablaMenuRoles()
        Dim EntidadRoles As New Capa_Entidad.Roles
        Dim NegocioRoles As New Capa_Negocio.Roles
        Try
            EntidadRoles.IdUsuario = IdUsuario
            EntidadRoles.IdTipoUsuario = IdTipoUsuario
            EntidadRoles.Consulta = Consulta.ConsultaPerfilUsuario
            NegocioRoles.Consultar(EntidadRoles)
            TablaEnc = EntidadRoles.TablaConsulta
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub RolesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RolesToolStripMenuItem.Click
        Roles.ShowDialog()
    End Sub
    Private Sub ObtenerPrecioDolarBanxico()
        Try
            If Serie <> "" And Sitio <> "" And Token <> "" Then
                Dim TipoDeCambio As String = TipoDeCambioFIX(Serie, Now, Now, Token, Sitio)
                If TipoDeCambio <> "" Then
                    TsPrecioDolar.Text = TipoDeCambio
                    ActualizaPrecioDolar(Val(TsPrecioDolar.Text))
                ElseIf _IdTipoUsuario = 1 Or _IdTipoUsuario = 10 Or _IdTipoUsuario = 4 Then
                    Monedas.ShowDialog()
                    ConsultaTipoCambio()
                End If
            Else
                If _IdTipoUsuario = 1 Or _IdTipoUsuario = 10 Or _IdTipoUsuario = 4 Then
                    Monedas.ShowDialog()
                    ConsultaTipoCambio()
                Else
                    TsPrecioDolar.Text = 0
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Exclamation, "Aviso")
            ConsultaTipoCambio()
        End Try
    End Sub
    Private Sub ActualizaPrecioDolar(ByVal TipoDeCambio As Double)
        Dim tabla As New DataTable
        Dim EntidadMenuPrincipal As New Capa_Entidad.MenuPrincipal
        Dim NegocioMenuPrincipal As New Capa_Negocio.MenuPrincipal
        EntidadMenuPrincipal.TipoDeCambio = TipoDeCambio
        EntidadMenuPrincipal.Abreviacion = "USD"
        NegocioMenuPrincipal.Actualizar(EntidadMenuPrincipal)
    End Sub
    Private Function VerificarConexionURL(ByVal mURL As String) As Boolean
        Try
            If My.Computer.Network.Ping(mURL, 2000) Then
                Return True
            Else
                Return False
            End If
        Catch ex As System.Net.WebException
            If ex.Status = Net.WebExceptionStatus.NameResolutionFailure Then
                Return False
            End If
            Return False
        End Try
    End Function
    Private Function VerificaFechaTipoCambio()
        Dim Resultado As Boolean
        Dim tabla As New DataTable
        Dim EntidadMenuPrincipal As New Capa_Entidad.MenuPrincipal
        Dim NegocioMenuPrincipal As New Capa_Negocio.MenuPrincipal
        Try
            EntidadMenuPrincipal.FechaHoy = Now.Date
            EntidadMenuPrincipal.Abreviacion = "USD"
            EntidadMenuPrincipal.Consulta = Consulta.ConsultaFechaTipoCambio
            NegocioMenuPrincipal.Consultar(EntidadMenuPrincipal)
            tabla = EntidadMenuPrincipal.TablaConsulta
            Resultado = tabla.Rows(0).Item("Respuesta")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Resultado
    End Function
    Private Sub ConsultaTipoCambio()
        Dim tabla As New DataTable
        Dim EntidadMenuPrincipal As New Capa_Entidad.MenuPrincipal
        Dim NegocioMenuPrincipal As New Capa_Negocio.MenuPrincipal

        EntidadMenuPrincipal.IdMoneda = 2
        EntidadMenuPrincipal.Consulta = Consulta.ConsultaTipoDeCambio
        NegocioMenuPrincipal.Consultar(EntidadMenuPrincipal)
        tabla = EntidadMenuPrincipal.TablaConsulta
        TsPrecioDolar.Text = tabla.Rows(0).Item("TipoDeCambio")
    End Sub
    Private Sub TipoUsuario()
        SbNombreUsuario.Text = Trim(_Usuario)
        SbTipoUsuario.Text = Trim(_TipoUsuario)
        SbBdd.Text = Trim(_BaseDeDatos)
        If VerificaFechaTipoCambio() = True Then
            ObtenerPrecioDolarBanxico()
        Else
            ConsultaTipoCambio()
        End If
    End Sub
    Private Sub ConsultaParametros()
        Dim EntidadConfiguracionParametros As New Capa_Entidad.ConfiguracionParametros
        Dim NegocioConfiguracionParametros As New Capa_Negocio.ConfiguracionParametros
        Dim Tabla As New DataTable
        EntidadConfiguracionParametros.Consulta = Consulta.ConsultaExterna
        NegocioConfiguracionParametros.Consultar(EntidadConfiguracionParametros)
        Tabla = EntidadConfiguracionParametros.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            Exit Sub
        End If
        Sitio = Tabla.Rows(0).Item("Sitio")
        Serie = Tabla.Rows(0).Item("Serie")
        Token = Tabla.Rows(0).Item("Token")
    End Sub
    Private Function GetNameHost()
        Dim strHostName As String
        Dim strIPAddress As String
        strHostName = Dns.GetHostName()
        strIPAddress = Dns.Resolve(strHostName).AddressList(0).ToString()
        Return strIPAddress
    End Function
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Clientes.ShowDialog()
    End Sub
    Private Sub TsSalir_Click(sender As Object, e As EventArgs) Handles TsSalir.Click
        SqlConnection.ClearAllPools()
        Me.Close()
    End Sub
    Private Sub Salir(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim opc As DialogResult = MsgBox("¿Desea salir de esta aplicación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")
        If opc = DialogResult.Yes Then
            SqlConnection.ClearAllPools()
            Dispose()
            End
        ElseIf opc = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
    Private Sub AsociacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsociacionesToolStripMenuItem.Click
        Asociaciones.ShowDialog()
    End Sub
    Private Sub CompradoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompradoresToolStripMenuItem.Click
        Dim compradores As New Compradores
        compradores.ShowDialog()
    End Sub
    Private Sub ColoniasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColoniasToolStripMenuItem.Click
        Colonias.ShowDialog()
    End Sub
    Private Sub MunicipiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MunicipiosToolStripMenuItem.Click
        Municipios.ShowDialog()
    End Sub
    Private Sub PlantasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlantasToolStripMenuItem.Click
        Plantas.ShowDialog()
    End Sub
    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        Empleados.ShowDialog()
    End Sub
    Private Sub CamionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CamionesToolStripMenuItem.Click
        Camiones.ShowDialog()
    End Sub
    Private Sub CapturaDeLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapturaDeLToolStripMenuItem.Click
        Dim ordtrb As New OrdenTrabajo
        ordtrb.ShowDialog()
    End Sub
    Private Sub CapturaDeBoletasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapturaDeBoletasToolStripMenuItem.Click
        CapturaBoletas.ShowDialog()
    End Sub
    Private Sub TiposDeIncidenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeIncidenciasToolStripMenuItem.Click
        TiposIncidencias.ShowDialog()
    End Sub
    Private Sub IncidenciasDeParoDeOperacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncidenciasDeParoDeOperacionesToolStripMenuItem.Click
        IncidenciaOperaciones.ShowDialog()
    End Sub
    Private Sub PuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PuestosToolStripMenuItem.Click
        Puestos.ShowDialog()
    End Sub
    Private Sub MaquinariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaquinariaToolStripMenuItem.Click
        Maquinaria.ShowDialog()
    End Sub
    Private Sub RangosDeTemperaturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RangosDeTemperaturaToolStripMenuItem.Click
        RangosTemperatura.ShowDialog()
    End Sub
    Private Sub ContratosDeAlgodónConProductoresToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ContratosAlgodon.ShowDialog()
    End Sub
    Private Sub ProfesionalesFitosanitariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfesionalesFitosanitariosToolStripMenuItem.Click
        ProfesionalesFitosanitarios.ShowDialog()
    End Sub
    Private Sub ModalidadesDeCompraDePacasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ModalidadesCompra.ShowDialog()
    End Sub
    Private Sub TierrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TierrasToolStripMenuItem.Click
        Dim predios As New Tierras
        predios.ShowDialog()
    End Sub
    Private Sub VariedadesDeAlgodónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VariedadesDeAlgodónToolStripMenuItem.Click
        VariedadesAlgodon.ShowDialog()
    End Sub
    Private Sub LargosDeFibraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LargosDeFibraToolStripMenuItem.Click
        LargoFibra.ShowDialog()
    End Sub
    Private Sub RendimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RendimientosToolStripMenuItem.Click
        Rendimientos.ShowDialog()
    End Sub
    Private Sub CastigosPorMicrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CastigosPorMicrosToolStripMenuItem.Click
        CastigoPorQuintal.ShowDialog()
    End Sub
    Private Sub RegímenesHídricosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegímenesHídricosToolStripMenuItem.Click
        RegimenHidrico.ShowDialog()
    End Sub
    Private Sub ContratosDeAlgodónConCompradoresToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ContratosAlgodonCompradores.ShowDialog()
    End Sub
    Private Sub ContratosDeSemillaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ContratoSemillas.ShowDialog()
    End Sub
    Private Sub CastigosPorLargosDeFibraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CastigosPorLargosDeFibraToolStripMenuItem.Click
        Dim CastLargoFibra As New CastigoLargoFibra()
        CastLargoFibra.ShowDialog()
    End Sub
    Private Sub CastigosPorResistenciaDeFibraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CastigosPorResistenciaDeFibraToolStripMenuItem.Click
        CastigoResistenciaFibra.ShowDialog()
    End Sub
    Private Sub CapturaDeProducciónPacasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapturaDeProducciónPacasToolStripMenuItem.Click
        Produccion.Show()
    End Sub
    Private Sub CapturaDeBoletasPorLotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapturaDeBoletasPorLotesToolStripMenuItem.Click
        CapturaBoletasPorLotes.ShowDialog()
    End Sub
    Private Sub LiquidacionesPorRomaneajeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiquidacionesPorRomaneajeToolStripMenuItem.Click
        Dim liqrom As New LiquidacionesPorRomaneaje
        liqrom.ShowDialog()
    End Sub
    Private Sub CompraDePacasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraDePacasToolStripMenuItem.Click
        CompraPacas.ShowDialog()
    End Sub
    Private Sub CompraDePacasAProductoresPorContratoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraDePacasAProductoresPorContratoToolStripMenuItem.Click
        Dim compracont As New CompraPacasContrato
        compracont.ShowDialog()
    End Sub
    Private Sub AltaDePacasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaDePacasToolStripMenuItem.Click
        AltaPacas.ShowDialog()
    End Sub
    Private Sub ClasificaciónDePacasConCertificadoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ClasificacionPacasCertificado.ShowDialog()
    End Sub
    Private Sub PaquetesHVIToolStripMenuItem_Click(sender As Object, e As EventArgs)
        PaquetesHVI.ShowDialog()
    End Sub
    Private Sub PaquetesParaVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaquetesParaVentaToolStripMenuItem.Click
        VentaClasificacion.Show()
    End Sub
    Private Sub ClasificaciónDePacasConArchivoExcelToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ClasificacionPacasExcel.ShowDialog()
    End Sub
    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        Dim ReporteClientes As New RepClientes()
        ReporteClientes.ShowDialog()
    End Sub
    Private Sub ChequearEtiquetaDePacaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChequearEtiquetaDePacaToolStripMenuItem.Click
        Etiquetas.Show()
    End Sub
    Private Sub SalidaDePacasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaDePacasToolStripMenuItem.Click
        Dim SalidasPac As New SalidaPacas
        SalidasPac.ShowDialog()
    End Sub
    Private Sub SalidaDeSemillaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaDeSemillaToolStripMenuItem.Click
        SalidaSemilla.ShowDialog()
    End Sub
    Private Sub SalidaDePacasDeBorraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaDePacasDeBorraToolStripMenuItem.Click
        SalidaPacasBorra.ShowDialog()
    End Sub
    Private Sub SalidaDeBasuraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaDeBasuraToolStripMenuItem.Click
        SalidaBasura.ShowDialog()
    End Sub
    Private Sub VentaDePacasPorContratoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaDePacasPorContratoToolStripMenuItem.Click
        Dim ventapacascont As New VentaPacasContrato
        ventapacascont.ShowDialog()
    End Sub
    Private Sub PaquetesHVIToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PaquetesHVIToolStripMenuItem1.Click
        PaquetesHVI.ShowDialog()
    End Sub
    Private Sub ClasificaciónDePacasConCertificadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClasificaciónDePacasConCertificadoToolStripMenuItem1.Click
        ClasificacionPacasCertificado.ShowDialog()
    End Sub
    Private Sub ClasificaciónDePacasConArchivoExcelToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClasificaciónDePacasConArchivoExcelToolStripMenuItem1.Click
        ClasificacionPacasExcel.ShowDialog()
    End Sub
    Private Sub ContratosDeAlgodónConProductoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContratosDeAlgodónConProductoresToolStripMenuItem1.Click
        Dim ContAlgodon As New ContratosAlgodon
        ContAlgodon.ShowDialog()
    End Sub
    Private Sub ContratosDeAlgodónConCompradoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContratosDeAlgodónConCompradoresToolStripMenuItem1.Click
        ContratosAlgodonCompradores.ShowDialog()
    End Sub
    Private Sub LiquidacionFinalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiquidacionFinalToolStripMenuItem.Click
        LiquidacionFinal.ShowDialog()
    End Sub
    Private Sub MonedasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonedasToolStripMenuItem.Click
        Monedas.ShowDialog()
        ConsultaTipoCambio()
    End Sub
    Private Sub BitacoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BitacoraToolStripMenuItem.Click
        Dim bita As New Bitacora
        bita.ShowDialog()
    End Sub
    Private Sub ContratosDeSemillaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContratosDeSemillaToolStripMenuItem1.Click
        ContratoSemillas.ShowDialog()
    End Sub
    Private Sub ExistenciaEnBodegaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExistenciaEnBodegaToolStripMenuItem.Click
        ExistenciaBodegaPacas.ShowDialog()
    End Sub
    Private Sub AlmacenesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AlmacenesToolStripMenuItem1.Click
        Almacenes.ShowDialog()
    End Sub
    Private Sub RealizarRespaldoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RealizarRespaldoToolStripMenuItem.Click
        Dim Respaldospeticion As New Respaldos
        Respaldospeticion.ShowDialog()
    End Sub
    Private Sub RestaurarRespaldoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestaurarRespaldoToolStripMenuItem.Click
        RestaurarRespaldo.ShowDialog()
    End Sub
    Private Sub ProgramarRespaldoAutomaticoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramarRespaldoAutomaticoToolStripMenuItem.Click
        ProgramarRespaldos.ShowDialog()
    End Sub
    Private Sub DatosDeEmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosDeEmpresaToolStripMenuItem.Click
        DatosEmpresa.ShowDialog()
    End Sub
    Private Sub ConfiguracionDeParametrosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConfiguracionDeParametrosToolStripMenuItem1.Click
        Dim ConfigParam As New ConfiguracionParametros()
        ConfigParam.ShowDialog()
    End Sub
    Private Sub SeleccionaConexionToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        SeleccionaConexion.ShowDialog()
        SbBdd.Text = _BaseDeDatos
    End Sub
    Private Sub CrearEstructuraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearEstructuraToolStripMenuItem.Click
        Dim creaestr As New CrearEstructura()
        creaestr.ShowDialog()
    End Sub
    Private Sub ImportarCatalogosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ImportarCatalogosToolStripMenuItem1.Click
        Dim impocat As New ImportarCatalogos
        impocat.ShowDialog()
    End Sub
    Private Sub ConexionInicialToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConexionInicialToolStripMenuItem1.Click
        ConfiguraConexionInicial.ShowDialog()
    End Sub
    Private Sub LotesDetalleConMódulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LotesDetalleConMódulosToolStripMenuItem.Click
        Dim RepLotesPorModulo As New RepLotesPorModulo()
        RepLotesPorModulo.ShowDialog()
    End Sub
    Private Sub PacasPorLotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacasPorLotesToolStripMenuItem.Click
        Dim ReportePacasPorLotes As New RepPacasPorLotes()
        ReportePacasPorLotes.ShowDialog()
    End Sub
    Private Sub PacasDetalleYAgrupadoPorClaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacasDetalleYAgrupadoPorClaseToolStripMenuItem.Click
        Dim ReportePacasDetalleAgrupadoPorClase As New RepPacasDetalleAgrupadoPorClase()
        ReportePacasDetalleAgrupadoPorClase.ShowDialog()
    End Sub
    Private Sub ToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim cveaut As New ClaveAutorizacion
        cveaut.ShowDialog()
    End Sub
    Private Sub PaquetesParaVentaPorRangosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaquetesParaVentaPorRangosToolStripMenuItem.Click
        VentaClasificacion.ShowDialog()
    End Sub
    Private Sub PacasFaltantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacasFaltantesToolStripMenuItem.Click
        Dim RepPacasFalt As New RepPacasFaltantes
        RepPacasFalt.ShowDialog()
    End Sub
    Private Sub ModalidadDeCompraToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ModalidadDeCompraToolStripMenuItem.Click
        Dim modcompra As New ModalidadesCompra
        modcompra.ShowDialog()
    End Sub
    Private Sub ModalidadDeVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModalidadDeVentaToolStripMenuItem.Click
        Dim modventa As New ModalidadesVenta
        modventa.ShowDialog()
    End Sub
    Private Sub UnidadesDeComercializacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadesDeComercializacionToolStripMenuItem.Click
        Dim unicom As New UnidadesComercializacion
        unicom.ShowDialog()
    End Sub
    Private Sub CastigosPorMicrosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CastigosPorMicrosToolStripMenuItem1.Click
        Dim castmic As New CastigoMicros
        castmic.ShowDialog()
    End Sub
    Private Sub CastigosPorUniformidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CastigosPorUniformidadToolStripMenuItem.Click
        Dim castuni As New CastigoUniformidad
        castuni.ShowDialog()
    End Sub
    Private Sub OrdenDeEmbarquePacasToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles OrdenDeEmbarquePacasToolStripMenuItem.Click
        Dim ordembpac As New OrdenEmbarquePacas
        ordembpac.ShowDialog()
    End Sub
    Private Sub PacasPorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacasPorClienteToolStripMenuItem.Click
        Dim ReporteDisponibilidadPacasProductor As New RepDisponibilidadPacasProductor()
        ReporteDisponibilidadPacasProductor.ShowDialog()
    End Sub
    Private Sub ComparativaDePesosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComparativaDePesosToolStripMenuItem.Click
        Dim ReporteSalidasPacas As New RepSalidaPacas
        ReporteSalidasPacas.ShowDialog()
    End Sub
    Private Sub CargaPacasExternasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargaPacasExternasToolStripMenuItem.Click
        CargaPacasExternas.ShowDialog()
    End Sub
    Private Sub EnvioDeMensajesDeTextoYCorreosAProductoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnvioDeMensajesDeTextoYCorreosAProductoresToolStripMenuItem.Click
        ParametrosCorreo.ShowDialog()
    End Sub
    Private Sub BuscarActualizacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarActualizacionesToolStripMenuItem.Click
        BuscarActualizacion.ShowDialog()
    End Sub
    Private Sub ConfiguracionDeParametrosBanxicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguracionDeParametrosBanxicoToolStripMenuItem.Click
        ParametrosBanxico.ShowDialog()
    End Sub
    Private Sub PacasSinVenderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacasSinVenderToolStripMenuItem.Click
        Dim ReportePacasSinVender As New RepPacasSinVender
        ReportePacasSinVender.ShowDialog()
    End Sub
    Private Sub RolesTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RolesTestToolStripMenuItem.Click
        Dim Roltst As New Roltest()
        Roltst.ShowDialog()
    End Sub
    Private Sub ResumenDeLiquidacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumenDeLiquidacionesToolStripMenuItem.Click
        Dim RepLiquid As New RepResumenLiquidaciones
        RepLiquid.ShowDialog()
    End Sub
    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Usuarios.ShowDialog()
    End Sub
    Private Sub PreliquidacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreliquidacionToolStripMenuItem.Click
        Dim preliqcompra As New PreliquidacionCompra
        preliqcompra.ShowDialog()
    End Sub
    Private Sub PreliquidacionACompradorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreliquidacionACompradorToolStripMenuItem.Click
        Dim preliqventa As New PreliquidacionVenta
        preliqventa.ShowDialog()
    End Sub
    Private Sub RevisionDeProduccionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RevisionDeProduccionToolStripMenuItem.Click
        Dim RevProd As New RevisionProduccion
        RevProd.ShowDialog()
    End Sub
    Private Sub IntegracionDeCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntegracionDeCompraToolStripMenuItem.Click
        Dim IntCompra As New IntegraciondeCompras
        IntCompra.ShowDialog()
    End Sub
    Private Sub ResumenDeProduccionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumenDeProduccionToolStripMenuItem.Click
        Dim ResProd As New RepResumenProducciones
        ResProd.ShowDialog()
    End Sub
    Private Sub PacasSinComprarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacasSinComprarToolStripMenuItem.Click
        Dim pacasincomprar As New RepPacasSinComprar
        pacasincomprar.ShowDialog()
    End Sub
    Private Sub ResComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResComprasToolStripMenuItem.Click
        Dim consultacompra As New RepConsultaCompras
        consultacompra.ShowDialog()
    End Sub

    Private Sub ResVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResVentasToolStripMenuItem.Click
        Dim consultaventa As New RepConsultaVentas
        consultaventa.ShowDialog()
    End Sub
    Private Sub DetalleDePacasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetalleDePacasCompraMenuItem.Click
        Dim ConsultaPacaDetalle As New RepConsultaPacasDetalleCompra
        ConsultaPacaDetalle.ShowDialog()
    End Sub
    Private Sub PacasPorDetalleDeVentaMenuItem_Click(sender As Object, e As EventArgs) Handles PacasPorDetalleDeVentaMenuItem.Click
        Dim ConsultaPacaDetalle As New RepConsultaPacasDetalleVenta
        ConsultaPacaDetalle.ShowDialog()
    End Sub
    Private Sub ExistenciaDePacasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExistenciaDePacasToolStripMenuItem.Click
        Dim ConsultaExistencias As New RepPacasExistencias
        ConsultaExistencias.ShowDialog()
    End Sub
    Private Sub SalidaPacasOrdenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaPacasOrdenToolStripMenuItem.Click
        Dim ConsultaSalidaPacas As New SalidasPorOrden
        ConsultaSalidaPacas.ShowDialog()
    End Sub
    Private Sub OrdenDeEmbarquePToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenDeEmbarquePToolStripMenuItem.Click
        Dim OrdenEmbpa As New OrdenEmbarquePorPacas
        OrdenEmbpa.ShowDialog()
    End Sub
    Private Sub EntradaYSalidaDeEquipoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaYSalidaDeEquipoToolStripMenuItem.Click
        Dim entradasalidaequ As New EntradaSalidadeEquipo
        entradasalidaequ.ShowDialog()
    End Sub
    Private Sub ReporteDeHojasDeProduccionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeHojasDeProduccionToolStripMenuItem.Click
        Dim RepHojaProd As New RepHojaProduccion
        RepHojaProd.ShowDialog()
    End Sub
    Private Sub ActualizacionVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizacionVentaToolStripMenuItem.Click
        Dim actventa As New ActualizacionVenta
        actventa.ShowDialog()
    End Sub
    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        Dim inventarios As New InventarioPacas
        inventarios.ShowDialog()
    End Sub
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        Dim repinvpacas As New ReporteInventarioPatios
        repinvpacas.ShowDialog()
    End Sub
    Private Sub SeleccionaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionaToolStripMenuItem.Click
        Dim selcon As New SeleccionaConexion
        selcon.ShowDialog()
        SbBdd.Text = _BaseDeDatos
    End Sub
    Private Sub ConfiguracionDeParametrosParaContratosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguracionDeParametrosParaContratosToolStripMenuItem.Click
        Dim confparamcont As New ConfiguracionParametrosContratos
        confparamcont.ShowDialog()
    End Sub
    Private Sub TurnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TurnosToolStripMenuItem.Click
        Dim confturnos As New Turnos
        confturnos.ShowDialog()
    End Sub
    Private Sub RutaDeDocumentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RutaDeDocumentosToolStripMenuItem.Click
        RutaDocumentos.ShowDialog()
    End Sub
    Private Sub ConfiguracionConexionInicialToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ConfiguraConexionInicial.ShowDialog()
    End Sub
End Class
