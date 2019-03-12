Imports Capa_Operacion.Configuracion
Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports Capa_Presentacion.WebServiceBanxico
Imports System.Net
Public Class MenuPrincipal
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TipoUsuario()
    End Sub
    Private Function ActualizaPrecioDolarBanxico() As Boolean
        Try
            Dim myProxy As New WebProxy("Proxy", 80)
            Dim UrlBanxico As String = "8.8.8.8"
            myProxy.Credentials = New NetworkCredential("Usuario", "contraseña")
            If VerificarConexionURL(UrlBanxico) = True Then
                Dim httpBanxico As HttpWebRequest = CType(WebRequest.Create("http://www.banxico.org.mx/DgieWSWeb/DgieWS?WSDL"), HttpWebRequest)
                WebRequest.DefaultWebProxy = httpBanxico.Proxy
                Dim TipoCambio As New WebServiceBanxico.DgieWS
                Dim strTipoCambio As String = TipoCambio.tiposDeCambioBanxico

                strTipoCambio = strTipoCambio.Substring(strTipoCambio.IndexOf("SF60653") + 1, strTipoCambio.Length - strTipoCambio.IndexOf("SF60653") - 1)
                strTipoCambio = strTipoCambio.Substring(strTipoCambio.IndexOf("OBS_VALUE=") + 1, strTipoCambio.Length - strTipoCambio.IndexOf("OBS_VALUE=") - 1)
                TsPrecioDolar.Text = Replace(strTipoCambio.Substring(10, 7), Chr(34), "")
                Return True
            Else
                TsPrecioDolar.Text = 0
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            TsPrecioDolar.Text = 0
            Return False
        End Try
    End Function
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
    Private Sub TipoUsuario()
        SbNombreUsuario.Text = _Usuario
        SbTipoUsuario.Text = _TipoUsuario
        SbBdd.Text = _BaseDeDatos
        ActualizaPrecioDolarBanxico()
    End Sub
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
    Private Sub ModalidadesDeCompraDePacasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModalidadesDeCompraDePacasToolStripMenuItem.Click
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
        ClasificacionVentaPaquetes.ShowDialog()
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
    Private Sub ConfiguracionDeParametrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguracionDeParametrosToolStripMenuItem.Click
        ConfiguracionParametros.ShowDialog()
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
    Private Sub SeleccionaBaseDeDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionaBaseDeDatosToolStripMenuItem.Click
        SeleccionaConexion.ShowDialog()
        SbBdd.Text = _BaseDeDatos
    End Sub
    Private Sub CrearEstructuraToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CrearEstructuraToolStripMenuItem1.Click
        CrearEstructura.ShowDialog()
    End Sub
    Private Sub ImportarCatalogosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarCatalogosToolStripMenuItem.Click
        ImportarCatalogos.ShowDialog()
    End Sub

    Private Sub MonedasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonedasToolStripMenuItem.Click
        Monedas.ShowDialog()
    End Sub
End Class
