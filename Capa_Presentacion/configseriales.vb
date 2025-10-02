Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Security.Cryptography
Imports System.Xml
Imports System.IO
Imports System.Management
Imports Microsoft.Win32
Imports System.Data

Public Class configseriales

    Public Shared Function verificaxml(serialprod As String) As Boolean
        If File.Exists("app.xml") = False Then
            Dim settings As New XmlWriterSettings()
            settings.Indent = True

            Dim writer As XmlWriter = XmlWriter.Create("app.xml", settings)
            Using writer
                writer.WriteStartDocument()
                writer.WriteStartElement("verificadorseial")
                writer.WriteStartElement("serialinfo")
                writer.WriteElementString("serial", serialprod)
                writer.WriteEndElement()
                writer.WriteEndElement()
                writer.WriteEndDocument()
            End Using
        End If
        Return True
    End Function

    Public Shared Function encriptaserial(serialprod As String) As String
        Dim serialencrypt As String = ""
        Dim ByteSourceText() As Byte
        Dim Md5 As New MD5CryptoServiceProvider()
        Dim Ue As New UnicodeEncoding()

        ByteSourceText = Ue.GetBytes(serialprod)
        Dim ByteHash() As Byte = Md5.ComputeHash(ByteSourceText)
        serialencrypt = Convert.ToBase64String(ByteHash)

        Return serialencrypt
    End Function

    Public Shared Function CpuId() As String
        Dim cpu_ids As String = ""
        Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Processor")
        For Each cpu As ManagementObject In searcher.Get()
            cpu_ids = cpu_ids & ", " & cpu("ProcessorId").ToString()
        Next
        If cpu_ids.Length > 0 Then cpu_ids = cpu_ids.Substring(2)
        Return cpu_ids
    End Function

    Public Sub crearegistro(serial As Object)
        Registry.CurrentUser.CreateSubKey("Calculacotton")
        Registry.SetValue("HKEY_CURRENT_USER\Software\Calculacotton", "", Environment.UserName, RegistryValueKind.String)
        Registry.SetValue("HKEY_CURRENT_USER\Software\Calculacotton", "LastRun", DateTime.Now.ToString(), RegistryValueKind.String)
        Registry.SetValue("HKEY_CURRENT_USER\Software\Calculacotton", "Serial", serial, RegistryValueKind.String)
    End Sub

    Public Shared Function verificaonline(serialencryp As String, cpuid As String) As Boolean
        Dim existe As Boolean = False
        Dim eregistrolicencia As New Capa_Entidad.RegistroLicencia()
        Dim nregistrolicencia As New Capa_Negocio.RegistroLicencia()
        Dim tabla As New DataTable()

        eregistrolicencia.Consulta = Consulta.ConsultaBasica
        eregistrolicencia.serialencryp = serialencryp
        eregistrolicencia.cpuid = cpuid
        nregistrolicencia.Consultar(eregistrolicencia)
        tabla = eregistrolicencia.TablaConsulta

        If tabla.Rows.Count > 0 Then
            For Each fila As DataRow In tabla.Rows
                If fila("cpu_cliente").ToString() = cpuid Then
                    existe = True
                Else
                    existe = False
                End If
            Next
        End If
        Return existe
    End Function

End Class

