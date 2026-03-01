Imports System.Management
Imports System.Text
Imports Capa_Operacion
Public Module HardwareHelper

    Public Function ObtenerHardwareId() As String
        Try
            Dim cpu As String = ObtenerCpu()
            Dim disc As String = ObtenerDisco()
            Dim mac As String = ObtenerMac()
            Dim raw As String = String.Format("{0}|{1}|{2}",
                cpu, disc, mac)
            Return SeguridadHelper.ComputeSHA256(raw).Substring(0, 32)
        Catch
            Return SeguridadHelper.ComputeSHA256(Environment.MachineName).Substring(0, 32)
        End Try
    End Function

    Private Function ObtenerCpu() As String
        Using searcher = New ManagementObjectSearcher(
        "SELECT ProcessorId FROM Win32_Processor")
            For Each obj In searcher.Get()
                Dim valor As Object = obj("ProcessorId")
                Return If(valor IsNot Nothing, valor.ToString(), String.Empty)
            Next
        End Using
        Return String.Empty
    End Function

    Private Function ObtenerDisco() As String
        Using searcher = New ManagementObjectSearcher(
        "SELECT SerialNumber FROM Win32_DiskDrive")
            For Each obj In searcher.Get()
                Dim valor As Object = obj("SerialNumber")
                Return If(valor IsNot Nothing, valor.ToString(), String.Empty)
            Next
        End Using
        Return String.Empty
    End Function

    Private Function ObtenerMac() As String
        Using searcher = New ManagementObjectSearcher(
        "SELECT MACAddress FROM Win32_NetworkAdapter " &
        "WHERE PhysicalAdapter = True AND MACAddress IS NOT NULL")
            For Each obj In searcher.Get()
                Dim valor As Object = obj("MACAddress")
                Return If(valor IsNot Nothing, valor.ToString(), String.Empty)
            Next
        End Using
        Return String.Empty
    End Function

End Module