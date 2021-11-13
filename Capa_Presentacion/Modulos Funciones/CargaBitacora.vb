Imports System.Net
Imports System.Net.NetworkInformation
Module CargaBitacora
    Private Sub InsertaBitacora(ByVal Modulo As String, ByVal Opcion As String, ByVal Operacion As String, ByVal Observaciones As String, ByVal BaseDeDatos As String, Optional ByVal IdAdicional As Integer = 0, Optional ByVal ReferenciaAdicional As String = "")
        Dim EntidadBitacora As New Capa_Entidad.Bitacora
        Dim NegocioBitacora As New Capa_Negocio.Bitacora
        Dim Computadora As String = Dns.GetHostName()
        Dim DireccionIP As String = Dns.Resolve(Computadora).AddressList(0).ToString()
        Dim Tabla As New DataTable
        Try
            EntidadBitacora.Fecha = Now
            EntidadBitacora.Computadora = Computadora
            EntidadBitacora.DireccionIP = DireccionIP
            EntidadBitacora.IdUsuario = IdUsuario
            EntidadBitacora.Usuario = Usuario
            EntidadBitacora.Modulo = Modulo
            EntidadBitacora.Opcion = Opcion
            EntidadBitacora.Operacion = Operacion
            EntidadBitacora.Observaciones = Observaciones
            EntidadBitacora.BaseDeDatos = BaseDeDatos
            NegocioBitacora.InsertaBitacora(EntidadBitacora)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub GeneraRegistroBitacora(ByVal Modulo As String, ByVal Opcion As String, Optional ByVal IdAdicional As Long = 0, Optional ByVal ReferenciaAdicional As String = "")
        Dim operacion As String = String.Empty
        Dim observaciones As String = String.Empty
        Try
            Select Case Opcion
                Case "Guardar"
                    operacion = "GUARDAR REGISTRO."
                    observaciones = "EL USUARIO " & Usuario & " GUARDO EL REGISTRO " & ReferenciaAdicional & " CON EL ID " & IdAdicional & "."
                Case "Generar liquidacion"
                    operacion = "GENERAR LIQUIDACION."
                    observaciones = "EL USUARIO " & Usuario & " GENERO LA LIQUIDACION " & ReferenciaAdicional & " CON EL ID " & IdAdicional & "."
                Case "Consultar"
                    operacion = "CONSULTAR REGISTRO."
                    observaciones = "EL USUARIO " & Usuario & " CONSULTO EL REGISTRO " & ReferenciaAdicional & " CON EL ID " & IdAdicional & "."
                Case "Actualizar"
                    operacion = "ACTUALIZAR REGISTRO."
                    observaciones = "EL USUARIO " & Usuario & " ACTUALIZO EL REGISTRO " & ReferenciaAdicional & " CON EL ID " & IdAdicional & "."
                Case "Abrir Produccion"
                    operacion = "ABRIR PRODUCCION."
                    observaciones = "EL USUARIO " & Usuario & " ABRIO LA PRODUCCION CON EL No DE ORDEN " & IdAdicional & " A NOMBRE DEL PRODUCTOR " & ReferenciaAdicional & "."
                Case "Eliminar"
                    operacion = "ELIMINAR REGISTRO."
                    observaciones = "EL USUARIO " & Usuario & " ELIMINO EL REGISTRO " & ReferenciaAdicional & " CON EL ID " & IdAdicional & "."
                Case "Accesar"
                    operacion = "INICIAR SESION."
                    observaciones = "EL USUARIO " & Usuario & " HA INICIADO SESION CON ROL " & TipoUsuario & "."
                Case "Eliminar Pacas Seleccionadas"
                    operacion = "ELIMINAR PACA."
                    observaciones = "EL USUARIO " & Usuario & " ELIMINO LA PACA CON EL FOLIO " & IdAdicional & " CON PESO DE " & ReferenciaAdicional & "."
                Case "Eliminar Pacas Clasificacion"
                    operacion = "ELIMINAR PACA."
                    observaciones = "EL USUARIO " & Usuario & " ELIMINO LA PACA CON EL FOLIO " & IdAdicional & " CON LAS SIGUIENTES CARACTERISTICAS :  " & ReferenciaAdicional & "."
                Case "Modificar"
                    operacion = "MODIFICAR REGISTRO"
                    observaciones = "EL USUARIO " & Usuario & " MODIFICO EL PAQUETE " & IdAdicional & "."
                Case "Insertar"
                    operacion = "INSERTAR PACA A ALMACEN"
                    observaciones = "EL USUARIO " & Usuario & " INSERTO LA PACA " & ReferenciaAdicional & " EN EL ALMACEN CON EL ID " & IdAdicional & "."
                Case "Respaldando..."
                    operacion = "PROGRAMAR RESPALDOS AUTOMATICOS"
                    observaciones = "EL USUARIO " & Usuario & " CREO EL RESPALDO DE LA BASE DE DATOS ADJUNTO DETALLES: " & ReferenciaAdicional
                Case "Restaurando..."
                    operacion = "RESTAURAR RESPALDOS"
                    observaciones = "EL USUARIO " & Usuario & " RESTAURO LA BASE DE DATOS ADJUNTO DETALLES: " & ReferenciaAdicional
            End Select
            InsertaBitacora(Modulo, Opcion, operacion, observaciones, BaseDeDatos)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
