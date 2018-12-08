Module VarGlob
    Public Property _Id As Integer
    Public Property _Nombre As String
    Public Property _Dato As String
    Public Property _Tabla As New DataTable
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
End Module
