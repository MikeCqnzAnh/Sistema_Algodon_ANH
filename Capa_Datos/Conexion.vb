Module Conexion
    Public UserDB As String = "sa"
    Public Password As String = "Usuario01"
    Public ServerDB As String = "MSISTEMAS"
    Public DataBase As String
    Public ccnppl As String
    Public Function conexionPrincipal()
        Return ("Data Source = MSISTEMAS;Initial Catalog=" & DataBase & ";Persist Security Info=True;User ID=sa;Password=Usuario01")
    End Function
    Public Function conexionMaster()
        Return ("Data Source = MSISTEMAS;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=Usuario01")
    End Function
    Public Function conexionMasterExportarEstructura(ByVal instancia As String, ByVal usuario As String, ByVal password As String)
        Return ("Data Source = " & instancia & ";Initial Catalog=master;Persist Security Info=True;User ID=" & usuario & ";Password=" & password & "")
    End Function
    Public Function conexionMasterExportarRegistros(ByVal instancia As String, ByVal BaseDeDatos As String, ByVal usuario As String, ByVal password As String)
        Return ("Data Source = " & instancia & ";Initial Catalog=" & BaseDeDatos & ";Persist Security Info=True;User ID=" & usuario & ";Password=" & password & "")
    End Function
End Module
