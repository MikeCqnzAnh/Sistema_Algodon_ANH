Imports System.IO
Module Conexion
    Public IpServer As String
    Public UsuarioDB As String
    Public PasswordDB As String
    Public Instancia As String
    Public DataBase As String
    Public ccnppl As String
    Dim Ruta As String = My.Computer.FileSystem.CurrentDirectory & "\cnn\"
    Dim archivo As String = "cnn.ini"
    Sub LeerArchivo()
        Dim leer As New StreamReader(Ruta & archivo)

        Try
            While leer.Peek <> -1
                Dim linea As String = leer.ReadLine()
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                Dim ArregloCadena() As String = Split(linea, ",")
                IpServer = ArregloCadena(0)
                Instancia = ArregloCadena(1)
                UsuarioDB = ArregloCadena(2)
                PasswordDB = ArregloCadena(3)
            End While

            leer.Close()

        Catch ex As Exception
            MsgBox("Se presento un problema al leer el archivo: " & ex.Message, MsgBoxStyle.Critical, " ")
        End Try
    End Sub
    Public Function conexionPrincipal()
        LeerArchivo()
        Return ("Data Source = " & Instancia & ";Initial Catalog=" & DataBase & ";Persist Security Info=True;User ID=" & UsuarioDB & ";Password=" & PasswordDB & "")
    End Function
    Public Function conexionMaster()
        Return ("Data Source = MSISTEMAS;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=Usuario01")
    End Function
    Public Function conexionMasterRestaurar()
        LeerArchivo()
        Return ("Data Source = " & Instancia & ";Initial Catalog=master;Persist Security Info=True;User ID=" & UsuarioDB & ";Password=" & PasswordDB & "")
    End Function
    Public Function conexionMasterExportarEstructura(ByVal instancia As String, ByVal usuario As String, ByVal password As String)
        Return ("Data Source = " & instancia & ";Initial Catalog=master;Persist Security Info=True;User ID=" & usuario & ";Password=" & password & "")
    End Function
    Public Function conexionMasterExportarRegistros(ByVal instancia As String, ByVal BaseDeDatos As String, ByVal UsuarioDB As String, ByVal passwordDB As String)
        Return ("Data Source = " & instancia & ";Initial Catalog=" & BaseDeDatos & ";Persist Security Info=True;User ID=" & UsuarioDB & ";Password=" & passwordDB & "")
    End Function
End Module
