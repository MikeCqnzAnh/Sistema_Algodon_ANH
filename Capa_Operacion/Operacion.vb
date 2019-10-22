
Namespace Configuracion

    'Namespace Constante
    '    'para uso en VENTA ==============================================================
    '    Public Enum TipoVenta
    '        Credito = 1
    '        Contado = 2
    '        Apartado = 3
    '        Ninguno = 4
    '    End Enum
    '    Public Enum DasboardOpcion
    '        Grafica1 = 1
    '        Grafica2 = 2
    '        Grafica3 = 3
    '        Grafica4 = 4
    '        Grafica5 = 5
    '        Grafica6 = 6
    '    End Enum
    '    Public Enum TipoEntrega
    '        DelCliente = 1
    '        EnMano = 2
    '        ClientePasa = 3
    '    End Enum
    '    Public Enum TipoVentaEstado
    '        AUTORIZADO = 1
    '        CANCELADO = 2
    '        RECHAZADO = 3
    '        ACTIVO = 4
    '        LIQUIDADO = 5
    '        PENDIENTE = 6
    '    End Enum
    '    Public Enum Cantidad
    '        Ninguno = 1
    '        Agregar = 2
    '        Quitar = 3
    '        Descuento = 4
    '        Cantidad = 5
    '    End Enum
    Public Enum Reporte
        ReporteClientes = 1
        ReporteContratoCompra = 2
        ReporteDatosEmpresa = 3
        ReporteLiquidacionRomaneaje = 4
        ReporteLiquidacionRomaneajeDet = 5
        ReporteHviDetalle = 6
    End Enum
    Public Enum Eliminar
        EliminarRegistro = 1
        EliminaPacaSeleccionada = 2
    End Enum
    Public Enum Guardar
        GuardarCompraPacasEnc = 1
        GuardarCompraPacasDet = 2
        GuardarVentaPacasDet = 3
        GuardarVentaPacasEnc = 4
    End Enum
    '    '==============================================================================
    '    Public Class Formato
    '        Public Shared Miles As String = "#,###,##0.00"
    '        Public Shared Porcentaje As String = "##0.##%"
    '        Public Shared FechaCorta As String = "{0:d}"
    '        Public Shared Moneda As String = "$#,###,##0.00"
    '    End Class
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
    End Enum
    Public Enum LlenaCombo
        LlenaComboCliente = 1
        LlenaComboColonia = 2
        LlenaComboRegimen = 3
        LlenaComboBaseDatos = 4
    End Enum
    Public Enum Actuliza
        ActualizaIdPaca = 1
        ActualizaSeleccion = 2
        ActualizaTipoAlmacen = 3
        ActualizaAlmacen = 4
        ActualizaTipoUsuario = 5
        ActualizaUsuario = 6
        ActualizaEstatus = 7
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
End Namespace

