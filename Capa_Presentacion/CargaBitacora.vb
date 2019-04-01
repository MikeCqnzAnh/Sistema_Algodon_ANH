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
        Dim operacion, observaciones As String
        Try
            Select Case Opcion
                Case "Guardar"
                    operacion = "GUARDAR REGISTRO."
                    observaciones = "EL USUARIO " & Usuario & " GUARDO EL REGISTRO " & "TEST" & "."
                Case "Consultar"
                    operacion = "CONSULTAR REGISTRO."
                    observaciones = "EL USUARIO " & Usuario & " CONSULTO EL REGISTRO " & "TEST" & "."
                Case "Actualizar"
                    operacion = "ACTUALIZAR REGISTRO."
                    observaciones = "EL USUARIO " & Usuario & " ACTUALIZO EL REGISTRO " & "TEST" & "."
                Case "Abrir Produccion"
                    operacion = "ABRIR PRODUCCION."
                    observaciones = "EL USUARIO " & Usuario & " ABRIO LA PRODUCCION CON EL ID " & "TEST" & "."
                Case "Eliminar"
                    operacion = "ELIMINAR REGISTRO."
                    observaciones = "EL USUARIO " & Usuario & " ELIMINO EL REGISTRO " & "TEST" & "."
                Case "Accesar"
                    operacion = "INICIAR SESION."
                    observaciones = "EL USUARIO " & Usuario & " HA INICIADO SESION CON ROL " & TipoUsuario & "."
            End Select
            InsertaBitacora(Modulo, Opcion, operacion, observaciones)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
