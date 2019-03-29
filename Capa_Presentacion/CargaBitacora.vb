Imports System.Net
Imports System.Net.NetworkInformation
Module CargaBitacora
    Private Sub InsertaBitacora(ByVal Modulo As String, ByVal Opcion As String, ByVal Operacion As String, ByVal Observaciones As String)
        Dim EntidadBitacora As New Capa_Entidad.Bitacora
        Dim NegocioBitacora As New Capa_Negocio.Bitacora
        Dim Computadora As String = Dns.GetHostName()
        Dim DireccionIP As String = Dns.Resolve(Computadora).AddressList(0).ToString()
        Dim Tabla As New DataTable
        EntidadBitacora.Fecha = Now
        EntidadBitacora.Computadora = Computadora
        EntidadBitacora.DireccionIP = DireccionIP
        EntidadBitacora.IdUsuario = IdUsuario
        EntidadBitacora.Usuario = Usuario
        EntidadBitacora.Modulo = Modulo
        EntidadBitacora.Opcion = Opcion
        EntidadBitacora.Operacion = Operacion
        EntidadBitacora.Observaciones = Observaciones
        NegocioBitacora.InsertaBitacora(EntidadBitacora)
    End Sub
    Public Sub GeneraRegistroBitacora(ByVal Modulo As String, ByVal Opcion As String)
        Try
            Select Case Opcion
                Case Opcion = "Guardar"

                Case Opcion = "Consultar"

                Case Opcion = "Actualizar"

                Case Opcion = "Abrir Produccion"

                Case Opcion = "Eliminar"

            End Select
        Catch ex As Exception

        End Try
    End Sub
End Module
