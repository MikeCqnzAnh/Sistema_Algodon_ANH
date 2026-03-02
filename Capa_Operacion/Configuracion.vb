Imports System.Configuration
Imports NLog.Internal
Namespace Configuracion
    Public Enum Reporte
        ReporteClientes = 1
        ReporteContratoCompra = 2
        ReporteDatosEmpresa = 3
        ReporteLiquidacionRomaneaje = 4
        ReporteLiquidacionRomaneajeDet = 5
        ReporteHviDetalle = 6
        ReporteLotesPorModulo = 7
        ReportePacasPorLote = 8
        ReportePacasDetalleAgrupadoPorClase = 9
        ReportePacasFaltantes = 10
        ReportePacasDetallado = 11
        ReporteCompraPacasResumen = 12
        ReporteCompraPacasDetallado = 13
        ReportePaquetesVenta = 14
        ReporteClasesVenta = 15
        ReporteVentaPacasResumen = 16
        ReporteVentaPacasDetallado = 17
        ReporteVentaHVI = 18
        ReporteOrdenEmbarque = 19
        ReporteDisponibilidadPacasProductor = 20
        ReportePesosSalidaPacas = 21
        ReportePacasSinVender = 22
        ReporteResumenLiquidacion = 23
        ReporteResumenLiqGeneral = 24
        ReporteVentaDetalleCastigo = 25
        ReporteVentaPacasExcel = 26
        ReporteResumenProduccion = 27
        ReportePaquetePorVenta = 28
        ReportePacasSinComprar = 29
        ReporteVentas = 30
        ReporteCompras = 31
        ReportePacaDetalleCompra = 32
        ReportePacaDetalleVenta = 33
        ReporteExistenciasResumen = 34
        ReporteExistenciasDetalle = 35
        ReporteModulosDetallePeso = 36
        ReporteRangoCastigomic = 37
        ReporteRangoCastigolar = 38
        ReporteRangoCastigores = 39
        ReporteRangoCastigouni = 40
        ReporteRangoCastigomiccompra = 41
        ReporteRangoCastigolarcompra = 42
        ReporteRangoCastigorescompra = 43
        ReporteRangoCastigounicompra = 44
    End Enum
    Public Enum Eliminar
        EliminarRegistro = 1
        EliminaPacaSeleccionada = 2
        EliminarPreliquidacioncompra = 3
    End Enum
    Public Enum Guardar
        GuardarCompraPacasEnc = 1
        GuardarCompraPacasDet = 2
        GuardarVentaPacasDet = 3
        GuardarVentaPacasEnc = 4
        GuardarEmbarqueEncabezado = 5
        GuardarEmbarqueDetalle = 6
        GuardarSalidaPacas = 7
        GuardarEncabezado = 8
        GuardarDetalle = 9
        GuardarIntegracion = 10
        GuardarFactura = 11
        GuardarDetalleFactura = 12
        GuardaPacas = 13
        GuardarEmbarqueDetalleLotes = 14
        GuardarVentaRecalculo = 15
        GuardaCompraenc = 16
        Guardacompradet = 17
        GuardaVentaenc = 18
        GuardaVentadet = 19
        GuardarCompraPreliqDet = 20
        GuardarVentaPreliqdet = 21
        GuardarPqtclaenc = 22
        GuardarPqtcladet = 23

    End Enum
    Public Enum Consulta
        ConsultaEstado = 1
        ConsultaMunicipio = 2
        ConsultaTipoPersona = 3
        ConsultaMunicipioMovilizacion = 4
        ConsultaEstadoMoral = 5
        ConsultaEstadoApoderado = 6
        ConsultaMunicipioApoderado = 7
        ConsultaDetallada = 8
        ConsultaAsociaciones = 9
        ConsultaBasica = 10
        ConsultaExterna = 11
        ConsultaClases = 12
        ConsultaClasesDetalle = 13
        ConsultaTierras = 14
        ConsultaDiferenciales = 15
        ConsultaVariedadesAlgodon = 16
        ConsultaProductores = 17
        ConsultaCompradores = 18
        ConsultaColonias = 19
        ConsultaProductorId = 20
        ConsultaRango = 21
        ConsultaOperadores = 22
        ConsultaPorId = 23
        ConsultaOrden = 24
        ConsultaModulosLiquidacion = 25
        ConsultaPaca = 26
        ConsultaModoCompra = 27
        ConsultaPacaExistente = 28
        ConsultaSecuencia = 29
        ConsultaModulosEntradas = 30
        ConsultaModulosIncidencias = 31
        ConsultaEncabezado = 32
        ConsultaBaseDatos = 33
        ConsultaInstancia = 34
        ConsultaLiquidaciones = 35
        'Para consulta de castigos
        ConsultaResistenciaFibra = 36
        ConsultaLargoFibra = 37
        ConsultaMicros = 38
        ConsultaModalidadCompra = 39
        ConsultaModalidadVenta = 40
        ConsultaModoVenta = 41
        'Consulta existencias
        ConsultaPacaExisteProduccion = 42
        ConsultaPacaExisteHVI = 43
        ConsultaPacaPlanta = 44
        ConsultaPacaExistePaquete = 45
        ConsultaPacasCantidadDisponible = 46
        ConsultaPacaFiltro = 47
        ConsultaPacaComprada = 48
        ConsultaLiquidacionesCompras = 49
        ConsultaBaseDatosReciente = 50
        ConsultaTablas = 51
        ConsultaProcedimientos = 52
        ConsultaCreateTable = 53
        ConsultaCreateProcedure = 54
        ConsultaUsuario = 55
        ConsultaFechaTipoCambio = 56
        ConsultaTipoDeCambio = 57
        ConsultaAlmacen = 58
        ConsultaTipoUsuario = 59
        ConsultaOpciones = 60
        ConsultaPerfilUsuario = 61
        ConsultaCompra = 62
        ConsultaCompraPorNombre = 63
        ConsultaCastigoLargoFibra = 64
        ConsultaCastigoResistenciaFibra = 65
        ConsultaCastigoMicros = 66
        ConsultaLiquidacionesVentas = 67
        ConsultaPacaVendida = 68
        ConsultaVentaPorNombre = 69
        ConsultaEstatusLeerEtiqueta = 70
        ConsultaPaqueteExisteHVI = 71
        ConsultaPaqueteExisteClasificacion = 72
        ConsultaClaveAutorizacion = 73
        ConsultaOrdenesDeTrabajo = 74
        ConsultaCastigoUniformidad = 75
        ConsultaIdCompraPaca = 76
        ConsultaCastigoMatExtCompra = 77
        ConsultaUnidadPeso = 78
        ConsultaIdVentaPaca = 79
        ConsultaEncabezadoMatExt = 80
        ConsultaPacaMatExt = 81
        ConsultaPacaMatExtDet = 82
        ConsultaLotIDPorPaca = 83
        ConsultaEquivalente = 84
        ConsultaMicrosVentaCmb = 85
        ConsultaLargoFibraVentaCmb = 86
        ConsultaResistenciaVentaCmb = 87
        ConsultaUniformidadVentaCmb = 88
        ConsultaCastigoMatExtVenta = 89
        ConsultaParametrosContratoVenta = 90
        ConsultaEmbarqueEncabezado = 91
        ConsultaPaqueteEmbarcado = 92
        ConsultaPacasEmbarcado = 93
        ConsultaSalidaPacas = 94
        ConsultaEmbarqueParaSalida = 95
        ConsultaOrdenEmbarqueEncabezado = 96
        ConsultaPacasRangos = 97
        ConsultaEmbarqueParaSalidaSinSelecionar = 98
        ConsultaMicrosCompraCmb = 99
        ConsultaLargoFibraCompraCmb = 100
        ConsultaResistenciaCompraCmb = 101
        ConsultaUniformidadCompraCmb = 102
        ConsultaParametrosContratoCompra = 103
        ConsultaUniformidad = 104
        ConsultaAlmacenLote = 105
        ConsultaPasasSinClase = 106
        ConsultaOrdenRevision = 107
        ConsultaProduccionRevision = 108
        ConsultaProduccionPesos = 109
        ConsultaIntegracion = 110
        ConsultaDetallesCastigoPacas = 111
        ConsultaComboLotes = 112
        ConsultaLotes = 113
        ConsultaComboLotesPacas = 114
        ConsultaPaquetesembarques = 115
        ConsultaPacasEmbarques = 116
        ConsultaComboEmbarqueLotes = 117
        ConsultaPaqueteDisponibleSalida = 118
        ConsultaPacasDisponibleSalida = 119
        ConsultaPacasSalidas = 120
        ConsultaPaquetesSalida = 121
        ConsultaComboCompradoresAcuenta = 122
        ConsultaSalidaEncabezado = 123
        ConsultaPaqueteSalidaSeleccionado = 124
        ConsultaPacaSalidaSeleccionado = 125
        ConsultaPacasSalidasFiltro = 126
        ConsultaExisteNoLote = 127
        ConsultaEstatusRevision = 128
        ConsultaMicRango = 129
        ConsultaResRango = 130
        ConsultaLarRango = 131
        ConsultaUniRango = 132
        ConsultaPreioProm = 133
        ConsultaContratovta = 134
        ConsultaPaqueteHviEnc = 135
        ConsultaPaqueteVtaEnc = 136
        consultapacasincompra = 137
        consultapacacompra = 138
        consultaperfilmicros = 139
        consultaperfiluhml = 140
        consultaperfilres = 141
        consultaperfilui = 142
        consultapacasinVenta = 143
        ConsultaVenta = 144
        consultaproductor = 145
        consultapreliqcompra = 146
        ConsultaDatosEmpresa = 147
        ConsultaCompraenc = 148
        ConsultaCompradet = 149
        ConsultaComprador = 150
        Consultaventaenc = 151
        Consultaventadet = 152
        Consultapacaslotedet = 153
        Consultapacasloteseldet = 154
        Consultapacasembdet = 155
        consultapacasembseldet = 156
        consultacolorgrade = 157
        consultalicencia = 158

    End Enum
    Public Enum LlenaCombo
        LlenaComboCliente = 1
        LlenaComboColonia = 2
        LlenaComboRegimen = 3
        LlenaComboBaseDatos = 4
    End Enum
    Public Enum Actualiza
        ActualizaIdPaca = 1
        ActualizaSeleccion = 2
        ActualizaTipoAlmacen = 3
        ActualizaAlmacenEnc = 4
        ActualizaTipoUsuario = 5
        ActualizaUsuario = 6
        ActualizaEstatus = 7
        ActualizaClaveAutorizacion = 8
        ActualizaPacasDisponibles = 9
        ActualizaAlmacenDet = 10
        ActualizarPacaMic = 11
        ActualizarPacaRes = 12
        ActualizarPacaLar = 13
        ActualizarPacaUni = 14
        ActualizarPacaSCI = 15
        ActualizarPacaMicbajar = 16
        ActualizarPacaResbajar = 17
        ActualizarPacaLarbajar = 18
        ActualizarPacaUnibajar = 19
        ActualizarParametros = 20
        ActualizaContratoCompra = 21
        ActualizaContratoVenta = 22
    End Enum
    Public Enum Importa
        ImportaTabla = 1
        ImportaProcedimiento = 2
        ImportaRegistros = 3
    End Enum
    Public Enum Conexion
        ConexionDataBase = 1
    End Enum
    Public Enum Agrega
        AgregOpcion = 1
        AgregaRol = 2
        AgregaRolPredefinido = 3
    End Enum
    ' ─── Enumeraciones del sistema ───────────────────────────────────────────
    Public Enum EstatusSerial
        Inactivo = 0
        Activo = 1
        Vencido = 2
        Inhabilitado = 3
    End Enum

    Public Enum PeriodoLicencia
        Prueba = 0
        Mensual = 1
        Anual = 2
        Personalizado = 3
    End Enum

    Public Enum TipoEquipo
        Servidor = 0
        Estacion = 1
    End Enum

    Public Enum EstatusLogin
        Exitoso = 0
        CredencialesErroneas = 1
        UsuarioBloqueado = 2
        UsuarioInactivo = 3
        ErrorSistema = 4
    End Enum

    ' ─── Constantes del sistema ──────────────────────────────────────────────
    Public Module Constantes
        Public Const NOMBRE_SISTEMA As String = "Calcula Cotton"
        Public Const CARPETA_DATOS As String = "Calcula Cotton"
        Public Const PUERTO_DISCOVERY As Integer = 45679
        Public Const MSG_BUSQUEDA As String = "ALGODONANH_DISCOVER"
        Public Const PREFIJO_RESPUESTA As String = "ALGODONANH_SERVER|"
        Public Const DIAS_GRACIA As Integer = 3
        Public Const MAX_INTENTOS_LOGIN As Integer = 5
        Public Const MINUTOS_BLOQUEO As Integer = 5
        Public Const TIMEOUT_API_SEG As Integer = 10
        Public Const TIMEOUT_DISCOVERY_MS As Integer = 3000
    End Module

    ' ─── Configuración de App.config ─────────────────────────────────────────
    Public Module AppConfig
        Public ReadOnly Property Version As String
            Get
                Return ObtenerValor("AppVersion", "1.0.0")
            End Get
        End Property

        Public ReadOnly Property ApiBaseUrl As String
            Get
                'Return ObtenerValor("ApiBaseUrl", "http://192.168.100.15:5000/api/v1/")
                'Return ObtenerValor("ApiBaseUrl", "http://100.112.236.15:5000/api/v1/")
                Return ObtenerValor("ApiBaseUrl", "http://localhost:5000/api/v1/")
            End Get
        End Property

        Public ReadOnly Property LicenciaApiKey As String
            Get
                Return ObtenerValor("LicenciaApiKey", "ccotton-api-2026")
            End Get
        End Property

        Public ReadOnly Property LicenciaApiSecret As String
            Get
                Return ObtenerValor("LicenciaApiSecret", "CCotton$ApiSecret#2026!MuyLargo")
            End Get
        End Property

        Public ReadOnly Property SmtpHost As String
            Get
                Return ObtenerValor("SmtpHost", "smtp.gmail.com")
            End Get
        End Property

        Public ReadOnly Property SmtpPort As Integer
            Get
                Return Integer.Parse(ObtenerValor("SmtpPort", "587"))
            End Get
        End Property

        Public ReadOnly Property SmtpUser As String
            Get
                Return ObtenerValor("SmtpUser", "tu-correo@gmail.com")
            End Get
        End Property

        Public ReadOnly Property SmtpPassword As String
            Get
                Return ObtenerValor("SmtpPassword", "tu-password")
            End Get
        End Property

        Public ReadOnly Property SmtpUsarSsl As Boolean
            Get
                Return Boolean.Parse(ObtenerValor("SmtpUsarSsl", "True"))
            End Get
        End Property

        Private Function ObtenerValor(clave As String, valorDefecto As String) As String
            Dim valor As String = ConfigurationManager.AppSettings(clave)
            Return If(String.IsNullOrEmpty(valor), valorDefecto, valor)
        End Function
    End Module
End Namespace

