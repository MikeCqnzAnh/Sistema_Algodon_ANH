Public Class Parametros

    ' =============================
    ' Configuración de Licencia
    ' =============================
    Public Shared Property RutaLc As String
        Get
            Return My.Settings.RutaLc
        End Get
        Set(value As String)
            My.Settings.RutaLc = value
            My.Settings.Save()
        End Set
    End Property

    ' =============================
    ' Configuración de Base de Datos
    ' =============================
    Public Shared Property InstanciaBDD As String
        Get
            Return My.Settings.instanciabdd
        End Get
        Set(value As String)
            My.Settings.instanciabdd = value
            My.Settings.Save()
        End Set
    End Property

    Public Shared Property BaseDeDatos As String
        Get
            Return My.Settings.basededatos
        End Get
        Set(value As String)
            My.Settings.basededatos = value
            My.Settings.Save()
        End Set
    End Property

    Public Shared Property BaseDeDatosPerfiles As String
        Get
            Return My.Settings.basededatosPerfiles
        End Get
        Set(value As String)
            My.Settings.basededatosPerfiles = value
            My.Settings.Save()
        End Set
    End Property

    Public Shared Property UsuarioBDD As String
        Get
            Return My.Settings.usuariobdd
        End Get
        Set(value As String)
            My.Settings.usuariobdd = value
            My.Settings.Save()
        End Set
    End Property

    Public Shared Property PasswordBDD As String
        Get
            Return My.Settings.passwordbdd
        End Get
        Set(value As String)
            My.Settings.passwordbdd = value
            My.Settings.Save()
        End Set
    End Property

    ' =============================
    ' Configuración de Red
    ' =============================
    Public Shared Property Servidor As Boolean
        Get
            Return My.Settings.servidor
        End Get
        Set(value As Boolean)
            My.Settings.servidor = value
            My.Settings.Save()
        End Set
    End Property

    Public Shared Property Estacion As Boolean
        Get
            Return My.Settings.estacion
        End Get
        Set(value As Boolean)
            My.Settings.estacion = value
            My.Settings.Save()
        End Set
    End Property

    Public Shared Property IpServidor As String
        Get
            Return My.Settings.ipservidor
        End Get
        Set(value As String)
            My.Settings.ipservidor = value
            My.Settings.Save()
        End Set
    End Property

    ' =============================
    ' Configuración de Usuario
    ' =============================
    Public Shared Property CkRecuerda As Boolean
        Get
            Return My.Settings.ckrecuerda
        End Get
        Set(value As Boolean)
            My.Settings.ckrecuerda = value
            My.Settings.Save()
        End Set
    End Property

    Public Shared Property Usuario As String
        Get
            Return My.Settings.usuario
        End Get
        Set(value As String)
            My.Settings.usuario = value
            My.Settings.Save()
        End Set
    End Property

    Public Shared Property Password As String
        Get
            Return My.Settings.password
        End Get
        Set(value As String)
            My.Settings.password = value
            My.Settings.Save()
        End Set
    End Property

    ' =============================
    ' Configuración de Puerto Serial
    ' =============================
    Public Shared Property PuertoCOM As String
        Get
            Return My.Settings.puertocom
        End Get
        Set(value As String)
            My.Settings.puertocom = value
            My.Settings.Save()
        End Set
    End Property

    Public Shared Property Baudios As String
        Get
            Return My.Settings.baudios
        End Get
        Set(value As String)
            My.Settings.baudios = value
            My.Settings.Save()
        End Set
    End Property

    Public Shared Property DataBits As String
        Get
            Return My.Settings.databits
        End Get
        Set(value As String)
            My.Settings.databits = value
            My.Settings.Save()
        End Set
    End Property

    Public Shared Property Parity As String
        Get
            Return My.Settings.parity
        End Get
        Set(value As String)
            My.Settings.parity = value
            My.Settings.Save()
        End Set
    End Property

    Public Shared Property StopBits As String
        Get
            Return My.Settings.stopbits
        End Get
        Set(value As String)
            My.Settings.stopbits = value
            My.Settings.Save()
        End Set
    End Property

    ' =============================
    ' Configuración de Validación (Pesos)
    ' =============================
    Public Shared Property KilosMinimo As Decimal
        Get
            Return My.Settings.kilosminimo
        End Get
        Set(value As Decimal)
            My.Settings.kilosminimo = value
            My.Settings.Save()
        End Set
    End Property

    Public Shared Property KilosMaximo As Decimal
        Get
            Return My.Settings.kilosmaximo
        End Get
        Set(value As Decimal)
            My.Settings.kilosmaximo = value
            My.Settings.Save()
        End Set
    End Property

    Public Shared Property LibrasMinimo As Decimal
        Get
            Return My.Settings.librasminimo
        End Get
        Set(value As Decimal)
            My.Settings.librasminimo = value
            My.Settings.Save()
        End Set
    End Property

    Public Shared Property LibrasMaximo As Decimal
        Get
            Return My.Settings.librasmaximo
        End Get
        Set(value As Decimal)
            My.Settings.librasmaximo = value
            My.Settings.Save()
        End Set
    End Property

    ' =============================
    ' Configuración Predeterminada
    ' =============================
    Public Shared Property KilosPred As Boolean
        Get
            Return My.Settings.kilospred
        End Get
        Set(value As Boolean)
            My.Settings.kilospred = value
            My.Settings.Save()
        End Set
    End Property

    Public Shared Property LibrasPred As Boolean
        Get
            Return My.Settings.libraspred
        End Get
        Set(value As Boolean)
            My.Settings.libraspred = value
            My.Settings.Save()
        End Set
    End Property

End Class

