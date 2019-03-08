Module Conexion
    Public UserDB As String = "sa"
    Public Password As String = "Usuario01"
    Public ServerDB As String = "MSISTEMAS"
    Public DataBase As String
    Public ccnppl As String
    Public Function conexionPrincipal()
        'Return ("Data Source=OSCARMERINO\DESARROLLO;Initial Catalog=ALGODON_2V;Integrated Security=True")
        Return ("Data Source = MSISTEMAS;Initial Catalog=ALGODON_2V;Persist Security Info=True;User ID=sa;Password=Usuario01")
    End Function
    Public Function conexionMaster()
        'Return ("Data Source=OSCARMERINO\DESARROLLO;Initial Catalog=ALGODON_2V;Integrated Security=True")
        Return ("Data Source = MSISTEMAS;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=Usuario01")
    End Function
    Public Function conexionMasterExportarEstructura(ByVal instancia As String, ByVal usuario As String, ByVal password As String)
        'Return ("Data Source=OSCARMERINO\DESARROLLO;Initial Catalog=ALGODON_2V;Integrated Security=True")
        Return ("Data Source = " & instancia & ";Initial Catalog=master;Persist Security Info=True;User ID=" & usuario & ";Password=" & password & "")
    End Function
    Public Function conexionMasterExportarRegistros(ByVal instancia As String, ByVal BaseDeDatos As String, ByVal usuario As String, ByVal password As String)
        'Return ("Data Source=OSCARMERINO\DESARROLLO;Initial Catalog=ALGODON_2V;Integrated Security=True")
        Return ("Data Source = " & instancia & ";Initial Catalog=" & BaseDeDatos & ";Persist Security Info=True;User ID=" & usuario & ";Password=" & password & "")
    End Function
End Module
