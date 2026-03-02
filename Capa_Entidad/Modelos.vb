' Capa_Entidad/Modelos.vb
Imports System
Imports System.IO
Imports Capa_Operacion.Configuracion

' ─── Usuario ──────────────────────────────────────────────────────────────
Public Class Usuario
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Usuario As String
    Public Property Email As String
    Public Property PasswordHash As String
    Public Property Salt As String
    Public Property TokenRecuperacion As String
    Public Property TokenExpiracion As DateTime?
    Public Property Activo As Boolean
    Public Property FechaCreacion As DateTime
End Class

' ─── RegistroSerialSW ─────────────────────────────────────────────────────
Public Class RegistroSerialSW
    Public Property IdSW As Integer
    Public Property Descripcion As String
    Public Property NombreCliente As String
    Public Property EmailCliente As String
    Public Property NombreContacto As String
    Public Property TelefonoContacto As String
    Public Property CpuId As String
    Public Property SerialOrig As String
    Public Property SerialEncryp As String
    Public Property IdPeriodo As Integer
    Public Property Periodo As String
    Public Property Cantidad As Integer
    Public Property FechaCreacionLicencia As DateTime?
    Public Property FechaActivacionSerial As DateTime?
    Public Property FechaVencimientoSerial As DateTime?
    Public Property FechaActualizacionSerial As DateTime?
    Public Property IdEstatusSerial As Integer

    Public ReadOnly Property Estatus As EstatusSerial
        Get
            Return CType(IdEstatusSerial, EstatusSerial)
        End Get
    End Property

    Public ReadOnly Property DiasRestantes As Integer
        Get
            If Not FechaVencimientoSerial.HasValue Then Return 9999
            Return CInt((FechaVencimientoSerial.Value - DateTime.UtcNow).TotalDays)
        End Get
    End Property
End Class

' ─── LicenciaInfo ─────────────────────────────────────────────────────────
Public Class LicenciaInfo
    Public Property Serial As String
    Public Property CpuId As String
    Public Property Estatus As EstatusSerial
    Public Property Cantidad As Integer
    Public Property IdPeriodo As Integer
    Public Property Periodo As String
    Public Property FechaVencimiento As DateTime?
    Public Property DiasRestantes As Integer
    Public Property EnPeriodoGracia As Boolean
    Public Property Mensaje As String
    Public Property NombreCliente As String
    Public Property EmailCliente As String      ' ✅ nuevo
    Public Property NombreContacto As String      ' ✅ nuevo
    Public Property TelefonoContacto As String      ' ✅ nuevo
End Class

' ─── LicenciaLocal ────────────────────────────────────────────────────────
Public Class LicenciaLocal
    Public Property SerialEncriptado As String
    Public Property UltimaVerificacion As DateTime
    Public Property UltimoEstatus As EstatusSerial
    Public Property DiasGraciaOffline As Integer
    Public Property DiasOfflineConsumidos As Integer
    Public Property UltimaFechaRegistrada As DateTime
    Public Property ContadorApertura As Integer
    Public Property Checksum As String
End Class

' ─── ConfiguracionApp ─────────────────────────────────────────────────────
Public Class ConfiguracionApp
    Public Property RutaLc As String
    Public Property InstanciaBDD As String
    Public Property BaseDeDatosPerfiles As String
    Public Property BaseDeDatos As String
    Public Property UsuarioBDD As String
    Public Property PasswordBDD As String
    Public Property Servidor As Boolean
    Public Property Estacion As Boolean
    Public Property IpServidor As String

    Public Shared ReadOnly Property RutaConfig As String
        Get
            Return Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.CommonApplicationData),
                Constantes.CARPETA_DATOS, "config.json")
        End Get
    End Property

    Public Shared ReadOnly Property RutaLicencia As String
        Get
            Return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), Constantes.CARPETA_DATOS, "licencia_cifrada.dat")
        End Get
    End Property

    Public Function ObtenerRutaLicenciaRed() As String
        If Not Estacion OrElse String.IsNullOrEmpty(IpServidor) Then
            Return RutaLicencia
        End If
        Return String.Format("\\{0}\{1}\licencia_cifrada.dat", IpServidor, Constantes.CARPETA_DATOS)
    End Function

    Public Shared Function PorDefecto() As ConfiguracionApp
        Return New ConfiguracionApp With {
            .InstanciaBDD = String.Empty,
            .BaseDeDatos = String.Empty,
            .UsuarioBDD = String.Empty,
            .PasswordBDD = String.Empty,
            .Servidor = True,
            .Estacion = False,
            .IpServidor = String.Empty
        }
    End Function
End Class

' ─── ResultadoGraciaOffline ───────────────────────────────────────────────
Public Class ResultadoGraciaOffline
    Public Property Permitido As Boolean
    Public Property DiasRestantes As Integer
    Public Property Mensaje As String
    Public Property SinDatosLocales As Boolean

    Public Shared Function EnGracia(dias As Integer) As ResultadoGraciaOffline
        Return New ResultadoGraciaOffline With {
            .Permitido = True,
            .DiasRestantes = dias,
            .Mensaje = String.Format(
                "Sin conexión. Puede usar el sistema {0} día(s) más.", dias)
        }
    End Function

    Public Shared Function Agotada() As ResultadoGraciaOffline
        Return New ResultadoGraciaOffline With {
            .Permitido = False,
            .DiasRestantes = 0,
            .Mensaje = "Período de gracia agotado." &
                             " Conecte a internet para reactivar."
        }
    End Function

    Public Shared Function SinDatos() As ResultadoGraciaOffline
        Return New ResultadoGraciaOffline With {
            .Permitido = False,
            .DiasRestantes = 0,
            .SinDatosLocales = True,
            .Mensaje = "Sin datos locales de licencia." &
                               " Conecte a internet para verificar."
        }
    End Function
End Class

' ─── DTOs ─────────────────────────────────────────────────────────────────
Public Class LoginDTO
    'Public Property Email As String
    Public Property Usuario As String
    Public Property Password As String
    Public Property Recordar As Boolean
End Class

Public Class ResultadoLogin
    Public Property Exitoso As Boolean
    Public Property Estatus As EstatusLogin
    Public Property Usuario As Usuario
    Public Property Mensaje As String
    Public Property MinutosBloqueo As Integer
    Public Shared Function CrearExitoso(
    usuario As Usuario) As ResultadoLogin
        Return New ResultadoLogin With {
            .Exitoso = True,
            .Estatus = EstatusLogin.Exitoso,
            .Usuario = usuario,
            .Mensaje = String.Empty
        }
    End Function

    Public Shared Function CrearFallido(
        mensaje As String) As ResultadoLogin
        Return New ResultadoLogin With {
            .Exitoso = False,
            .Estatus = EstatusLogin.CredencialesErroneas,
            .Mensaje = mensaje
        }
    End Function

    Public Shared Function CrearBloqueado(
        minutos As Integer) As ResultadoLogin
        Return New ResultadoLogin With {
            .Exitoso = False,
            .Estatus = EstatusLogin.UsuarioBloqueado,
            .Mensaje = String.Format(
                "Usuario bloqueado. Intente en {0} minuto(s).", minutos),
            .MinutosBloqueo = minutos
        }
    End Function
End Class
Public Class PeriodoItem
    Public Property Id As Integer
    Public Property Texto As String

    Public Sub New(id As Integer, texto As String)
        Me.Id = id
        Me.Texto = texto
    End Sub

    Public Overrides Function ToString() As String
        Return Texto
    End Function
End Class
Public Class ConsultaLicenciaResult
    Public Property Encontrado As Boolean
    Public Property Mensaje As String
    Public Property EstatusInt As Integer
    Public Property Estatus As String
    Public Property IdPeriodo As Integer
    Public Property Periodo As String
    Public Property Cantidad As Integer
    Public Property FechaVencimiento As DateTime?
    Public Property NombreCliente As String
    Public Property EmailCliente As String
    Public Property NombreContacto As String
    Public Property TelefonoContacto As String
End Class
Public Class ResultadoDiscovery
    Public Property Encontrado As Boolean
    Public Property IpServidor As String
    Public Property Mensaje As String
End Class
