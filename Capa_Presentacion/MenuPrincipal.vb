Imports Capa_Operacion.Configuracion
Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports Capa_Presentacion.WebServiceBanxico
Imports System.Net
Imports System.Text.RegularExpressions
Public Class MenuPrincipal
    Dim IdSerieBanxico, CampoValorBanxico, SitioBanxico As String
    Dim PosicionValorBanxico, LongitudValorBanxico As Integer
    Dim TablaEnc As New DataTable
    Dim valor As String = ""
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultaItems(MSMenu)
        ConsultaParametros()
        TipoUsuario()
    End Sub
    Private Sub consultaItems(ByVal MsItem As MenuStrip)
        llenaTablaMenuRoles()
        For Each miitem As ToolStripMenuItem In MsItem.Items
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
        EntidadRoles.IdUsuario = IdUsuario
        EntidadRoles.IdTipoUsuario = IdTipoUsuario
        EntidadRoles.Consulta = Consulta.ConsultaPerfilUsuario
        NegocioRoles.Consultar(EntidadRoles)
        TablaEnc = EntidadRoles.TablaConsulta
    End Sub
    Private Sub RolesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RolesToolStripMenuItem.Click
        Roles.ShowDialog()
    End Sub
    Private Sub ObtenerPrecioDolarBanxico()
        Try
            'Dim myProxy As New WebProxy("Proxy", 80)
            'Dim UrlBanxico As String = "8.8.8.8"
            'myProxy.Credentials = New NetworkCredential("Usuario", "contraseña")
            'If VerificarConexionURL(UrlBanxico) = True Then
            '    Dim httpBanxico As HttpWebRequest = CType(WebRequest.Create(RTrim(SitioBanxico)), HttpWebRequest)
            '    WebRequest.DefaultWebProxy = httpBanxico.Proxy
            '    Dim TipoCambio As New WebServiceBanxico.DgieWS
            '    Dim strTipoCambio As String = TipoCambio.tiposDeCambioBanxico

            '    strTipoCambio = strTipoCambio.Substring(strTipoCambio.IndexOf(RTrim(IdSerieBanxico)) + 1, strTipoCambio.Length - strTipoCambio.IndexOf(RTrim(IdSerieBanxico)) - 1)
            '    strTipoCambio = strTipoCambio.Substring(strTipoCambio.IndexOf(RTrim(CampoValorBanxico)) + 1, strTipoCambio.Length - strTipoCambio.IndexOf(RTrim(CampoValorBanxico)) - 1)
            '    TsPrecioDolar.Text = Replace(strTipoCambio.Substring(PosicionValorBanxico, LongitudValorBanxico), Chr(34), "")
            '    TsPrecioDolar.Text = Regex.Replace(TsPrecioDolar.Text, "[^0-9.]", "", RegexOptions.None)
            '    ActualizaPrecioDolar(Val(TsPrecioDolar.Text))
            'Else
            If _IdTipoUsuario = 1 Or _IdTipoUsuario = 10 Or _IdTipoUsuario = 4 Then
                Monedas.ShowDialog()
                ConsultaTipoCambio()
            Else
                TsPrecioDolar.Text = 0
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

        EntidadMenuPrincipal.FechaHoy = Now.Date
        EntidadMenuPrincipal.Abreviacion = "USD"
        EntidadMenuPrincipal.Consulta = Consulta.ConsultaFechaTipoCambio
        NegocioMenuPrincipal.Consultar(EntidadMenuPrincipal)
        tabla = EntidadMenuPrincipal.TablaConsulta
        Resultado = tabla.Rows(0).Item("Respuesta")
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
        IdSerieBanxico = Tabla.Rows(0).Item("IdSerieBanxico")
        CampoValorBanxico = Tabla.Rows(0).Item("CampoValorBanxico")
        PosicionValorBanxico = Tabla.Rows(0).Item("PosicionValorBanxico")
        LongitudValorBanxico = Tabla.Rows(0).Item("LongitudValorBanxico")
        SitioBanxico = Tabla.Rows(0).Item("Sitiobanxico")
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
            End
        ElseIf opc = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
    Private Sub AsociacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsociacionesToolStripMenuItem.Click
        Asociaciones.ShowDialog()
    End Sub
    Private Sub CompradoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompradoresToolStripMenuItem.Click
        Compradores.ShowDialog()
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
        OrdenTrabajo.ShowDialog()
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
        Tierras.ShowDialog()
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
        CastigoLargoFibra.ShowDialog()
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
        LiquidacionesPorRomaneaje.ShowDialog()
    End Sub
    Private Sub CompraDePacasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraDePacasToolStripMenuItem.Click
        CompraPacas.ShowDialog()
    End Sub
    Private Sub CompraDePacasAProductoresPorContratoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraDePacasAProductoresPorContratoToolStripMenuItem.Click
        CompraPacasContrato.ShowDialog()
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
        RepClientes.ShowDialog()
    End Sub
    Private Sub ChequearEtiquetaDePacaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChequearEtiquetaDePacaToolStripMenuItem.Click
        Etiquetas.Show()
    End Sub
    Private Sub SalidaDePacasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaDePacasToolStripMenuItem.Click
        SalidaPacas.ShowDialog()
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
        VentaPacasContrato.ShowDialog()
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
        ContratosAlgodon.ShowDialog()
    End Sub
    Private Sub ContratosDeAlgodónConCompradoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ContratosDeAlgodónConCompradoresToolStripMenuItem1.Click
        ContratosAlgodonCompradores.ShowDialog()
    End Sub
    Private Sub LiquidacionFinalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiquidacionFinalToolStripMenuItem.Click
        LiquidacionFinal.ShowDialog()
    End Sub
    Private Sub MonedasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonedasToolStripMenuItem.Click
        Monedas.ShowDialog()
    End Sub
    Private Sub BitacoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BitacoraToolStripMenuItem.Click
        Bitacora.ShowDialog()
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
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        RestaurarRespaldo.ShowDialog()
    End Sub
    Private Sub RealizarRespaldoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RealizarRespaldoToolStripMenuItem.Click
        Respaldos.ShowDialog()
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
        ConfiguracionParametros.ShowDialog()
    End Sub
    Private Sub SeleccionaConexionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SeleccionaConexionToolStripMenuItem1.Click
        SeleccionaConexion.ShowDialog()
        SbBdd.Text = _BaseDeDatos
    End Sub
    Private Sub CrearEstructuraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearEstructuraToolStripMenuItem.Click
        CrearEstructura.ShowDialog()
    End Sub
    Private Sub ImportarCatalogosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ImportarCatalogosToolStripMenuItem1.Click
        ImportarCatalogos.ShowDialog()
    End Sub
    Private Sub ConexionInicialToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConexionInicialToolStripMenuItem1.Click
        ConfiguraConexionInicial.ShowDialog()
    End Sub
    Private Sub LotesDetalleConMódulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LotesDetalleConMódulosToolStripMenuItem.Click
        RepLotesPorModulo.ShowDialog()
    End Sub
    Private Sub PacasPorLotesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacasPorLotesToolStripMenuItem.Click
        RepPacasPorLotes.ShowDialog()
    End Sub
    Private Sub PacasDetalleYAgrupadoPorClaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacasDetalleYAgrupadoPorClaseToolStripMenuItem.Click
        RepPacasDetalleAgrupadoPorClase.ShowDialog()
    End Sub
    Private Sub ToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        ClaveAutorizacion.ShowDialog()
    End Sub
    Private Sub PaquetesParaVentaPorRangosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaquetesParaVentaPorRangosToolStripMenuItem.Click
        VentaClasificacion.ShowDialog()
    End Sub
    Private Sub PacasFaltantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacasFaltantesToolStripMenuItem.Click
        RepPacasFaltantes.ShowDialog()
    End Sub
    Private Sub ModalidadDeCompraToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ModalidadDeCompraToolStripMenuItem.Click
        ModalidadesCompra.ShowDialog()
    End Sub
    Private Sub ModalidadDeVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModalidadDeVentaToolStripMenuItem.Click
        ModalidadesVenta.ShowDialog()
    End Sub
    Private Sub UnidadesDeComercializacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadesDeComercializacionToolStripMenuItem.Click
        UnidadesComercializacion.ShowDialog()
    End Sub
    Private Sub ReporteDeComprasYVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDeComprasYVentasToolStripMenuItem.Click

    End Sub

    Private Sub CastigosPorMicrosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CastigosPorMicrosToolStripMenuItem1.Click
        CastigoMicros.ShowDialog()
    End Sub

    Private Sub CastigosPorUniformidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CastigosPorUniformidadToolStripMenuItem.Click
        CastigoUniformidad.ShowDialog()
    End Sub
    Private Sub OrdenDeEmbarquePacasToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles OrdenDeEmbarquePacasToolStripMenuItem.Click
        OrdenEmbarquePacas.ShowDialog()
    End Sub
    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Usuarios.ShowDialog()
    End Sub
    Private Sub RutaDeDocumentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RutaDeDocumentosToolStripMenuItem.Click
        RutaDocumentos.ShowDialog()
    End Sub
    Private Sub ConfiguracionConexionInicialToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ConfiguraConexionInicial.ShowDialog()
    End Sub
End Class
