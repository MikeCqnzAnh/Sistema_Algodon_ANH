Imports System.Configuration
Imports System.IO
Imports Capa_Operacion
Module Conexion
    Private parametros As Parametros
    Public Function conexionPrincipal() As Data.SqlClient.SqlConnection
        'parametros = Parametros.Cargar()
        'Return ("Data Source = " & parametros.InstanciaBDD & ";Initial Catalog=" & parametros.BaseDeDatos & ";Persist Security Info=True;User ID=" & parametros.UsuarioBDD & ";Password=" & parametros.PasswordBDD & "")
        Return CrearConexion()
    End Function
    Public Function conexionPerfiles() As Data.SqlClient.SqlConnection
        'LeerArchivoPerfiles()
        'Return ("Data Source = " & parametros.InstanciaBDD & ";Initial Catalog=" & parametros.BaseDeDatosPerfiles & ";Persist Security Info=True;User ID=" & parametros.UsuarioBDD & ";Password=" & parametros.PasswordBDD & "")
        Return CrearConexionPerfiles()
    End Function
    Public Function conexionMaster() 
        Return ("Data Source = " & parametros.InstanciaBDD & ";Initial Catalog=master;Persist Security Info=True;User ID=" & parametros.UsuarioBDD & ";Password=" & parametros.PasswordBDD & "")
    End Function
    Public Function conexionMasterRestaurar()
        'LeerArchivo()
        Return ("Data Source = " & parametros.InstanciaBDD & ";Initial Catalog=master;Persist Security Info=True;User ID=" & parametros.UsuarioBDD & ";Password=" & parametros.PasswordBDD & "")
    End Function
    Public Function conexionMasterExportarEstructura(ByVal instancia As String, ByVal usuario As String, ByVal password As String)
        Return ("Data Source = " & instancia & ";Initial Catalog=master;Persist Security Info=True;User ID=" & usuario & ";Password=" & password & "")
    End Function
    Public Function conexionMasterExportarRegistros(ByVal instancia As String, ByVal BaseDeDatos As String, ByVal UsuarioDB As String, ByVal passwordDB As String)
        Return ("Data Source = " & instancia & ";Initial Catalog=" & BaseDeDatos & ";Persist Security Info=True;User ID=" & UsuarioDB & ";Password=" & passwordDB & "")
    End Function
    Public Function conlc() As String
        Dim conexion As String = ""
        'conexion = "Data Source=bo1zxlizydykyidditjf-mysql.services.clever-cloud.com; Port=3306; Database=bo1zxlizydykyidditjf; User Id=ua5unwkrkjqy5j1y; Password=3ZsbKVDCjpc3Smm5MwVR"
        conexion = "Data Source=localhost;Port=3306;Database=licenciassw;User Id=root;Password=root"
        Return conexion
    End Function
End Module
