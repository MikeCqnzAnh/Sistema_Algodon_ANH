Imports System.IO
Imports Newtonsoft.Json

Public Class Parametros

    Private Shared ReadOnly ConfigPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Calcula Cotton\config.json")

    'Private Shared ReadOnly ConfigPath As String = Path.Combine(Path.GetPathRoot(Environment.SystemDirectory), "Calcula Cotton\config.json")
    Dim rutaraiz As String = Path.GetPathRoot(Environment.SystemDirectory)
    Public Property RutaLc As String = Path.Combine(rutaraiz, "Calcula Cotton\licencia_cifrada.dat")

    'Public Property RutaLc As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "Calcula Cotton\licencia_cifrada.dat")

    Public Property InstanciaBDD As String
    Public Property BaseDeDatos As String
    Public Property BaseDeDatosPerfiles As String
    Public Property ultimabdd As Integer
    Public Property UsuarioBDD As String
    Public Property PasswordBDD As String
    Public Property Servidor As Boolean
    Public Property Estacion As Boolean
    Public Property IpServidor As String
    Public Property CkRecuerda As Boolean
    Public Property Usuario As String
    Public Property Password As String
    Public Property PuertoCOM As String
    Public Property Baudios As String
    Public Property DataBits As String
    Public Property Parity As String
    Public Property StopBits As String
    Public Property KilosMinimo As Decimal
    Public Property KilosMaximo As Decimal
    Public Property LibrasMinimo As Decimal
    Public Property LibrasMaximo As Decimal
    Public Property KilosPred As Boolean
    Public Property LibrasPred As Boolean

    ' ==========================
    ' Cargar configuración
    ' ==========================
    Public Shared Function Cargar() As Parametros
        Try
            If File.Exists(ConfigPath) Then
                Dim json As String = File.ReadAllText(ConfigPath)
                Return JsonConvert.DeserializeObject(Of Parametros)(json)
            Else
                Return New Parametros()
            End If
        Catch ex As Exception
            Throw New Exception("Error al cargar configuración: " & ex.Message)
        End Try
    End Function

    ' ==========================
    ' Guardar configuración
    ' ==========================
    Public Sub Guardar()
        Try
            Dim dir As String = Path.GetDirectoryName(ConfigPath)
            If Not Directory.Exists(dir) Then
                Directory.CreateDirectory(dir)
            End If

            Dim json As String = JsonConvert.SerializeObject(Me, Formatting.Indented)
            File.WriteAllText(ConfigPath, json)
        Catch ex As Exception
            Throw New Exception("Error al guardar configuración: " & ex.Message)
        End Try
    End Sub
End Class
