Module VarGlob
    Public Property _Id As Integer
    Public Property _Nombre As String
    Public Property _Dato As String
    Public Property _Tabla As New DataTable
    Public Property _NoLote As String
    Public Property _NoContenedor As String
    Public Property _NombreComprador As String
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Public Property Dato() As String
        Get
            Return _Dato
        End Get
        Set(ByVal value As String)
            _Dato = value
        End Set
    End Property

    Public Property Tabla() As DataTable
        Get
            Return _Tabla
        End Get
        Set(ByVal value As DataTable)
            _Tabla = value
        End Set
    End Property
    Public _IdTipoUsuario As Integer
    Public Property IdTipoUsuario As Integer
        Get
            Return _IdTipoUsuario
        End Get
        Set(value As Integer)
            _IdTipoUsuario = value
        End Set
    End Property
    Public _TipoUsuario As String
    Public Property TipoUsuario As String
        Get
            Return _TipoUsuario
        End Get
        Set(value As String)
            _TipoUsuario = value
        End Set
    End Property
    Public _Usuario As String
    Public Property Usuario As String
        Get
            Return _Usuario
        End Get
        Set(value As String)
            _Usuario = value
        End Set
    End Property
    Public _IdUsuario As Integer
    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(value As Integer)
            _IdUsuario = value
        End Set
    End Property
    Public _BaseDeDatos As String
    Public Property BaseDeDatos As String
        Get
            Return _BaseDeDatos
        End Get
        Set(value As String)
            _BaseDeDatos = value
        End Set
    End Property
    Public _Instancia As String
    Public Property Instancia As String
        Get
            Return _Instancia
        End Get
        Set(value As String)
            _Instancia = value
        End Set
    End Property
    Public _UsuarioDB As String
    Public Property UsuarioDB As String
        Get
            Return _UsuarioDB
        End Get
        Set(value As String)
            _UsuarioDB = value
        End Set
    End Property
    Public _PasswordDB As String
    Public Property PasswordDB As String
        Get
            Return _PasswordDB
        End Get
        Set(value As String)
            _PasswordDB = value
        End Set
    End Property
    Public _IpServer As String
    Public Property IpServer As String
        Get
            Return _IpServer
        End Get
        Set(value As String)
            _IpServer = value
        End Set
    End Property
End Module
