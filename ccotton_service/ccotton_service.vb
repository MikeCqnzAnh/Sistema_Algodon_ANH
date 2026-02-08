Imports System.Configuration
Imports System.IO
Imports System.Management
Imports System.Net.Http
Imports ccotton_service.LicenciaHelper

Public Class ccotton_service
    Shared parametros As Parametros
    Public t As New Timers.Timer
    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Agregue el código aquí para iniciar el servicio. Este método debería poner
        ' en movimiento los elementos para que el servicio pueda funcionar.
        t = New Timers.Timer
        AddHandler t.Elapsed, AddressOf ejecutaaccion
        t.Interval = 10000
        t.Start()
    End Sub

    Protected Overrides Sub OnStop()
        ' Agregue el código aquí para realizar cualquier anulación necesaria para detener el servicio.
    End Sub
    Public Async Sub ejecutaaccion()
        Try
            Dim tieneInternet As Boolean = Await conexioninternet()
            Dim serielencryp As String = obtieneserialencrypt()
            Dim licencia As LicenciaHelper.Licencia = Nothing
            If parametros.Servidor Then
                If tieneInternet Then
                    Dim resultado = Await LicenciaHelper.consultalic(serielencryp)

                    If resultado IsNot Nothing AndAlso resultado.estado = "encontrada" Then
                        licencia = resultado.licencia

                        'Select Case licencia.idestatusserial
                        '    Case 0
                        '    'MessageBox.Show("Licencia INACTIVA. Válida hasta: " & licencia.fechavencimientoserial?.ToString("dd/MM/yyyy"), "Licencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        '    Case 1
                        '        If licencia.fechavencimientoserial <= licencia.fechaservidor Then
                        '            licencia.idestatusserial = 2
                        '        End If
                        '    'MessageBox.Show("Licencia ACTIVA. Válida hasta: " & licencia.fechavencimientoserial?.ToString("dd/MM/yyyy"), "Licencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        '    'controleslicencia(True)

                        '    Case 2
                        '    'MessageBox.Show("Licencia VENCIDA desde: " & licencia.fechavencimientoserial?.ToString("dd/MM/yyyy"), "Licencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        '    'controleslicencia(False)
                        '    Case 3
                        '        'MessageBox.Show("Licencia SUSPENDIDA desde: " & licencia.fechavencimientoserial?.ToString("dd/MM/yyyy"), "Licencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        '        'controleslicencia(False)
                        'End Select

                        ' Guardar la licencia localmente
                        LicenciaHelper.GuardarLicenciaCifrada(licencia)
                    Else

                    End If
                Else
                    'MessageBox.Show("Sin conexión a internet. Se validará la licencia local.", "Sin conexión", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'validar(licencia)

                End If
            Else
                validarestacion(licencia)
            End If
        Catch ex As Exception
            EventLog.WriteEntry("ccotton_service", "Error en la tarea diaria: " & ex.Message, EventLogEntryType.Error)
        End Try
    End Sub
    Private Function obtieneserialencrypt() As String
        Try
            parametros = Parametros.Cargar

            'Dim rutaArchivo As String = Path.Combine(Application.StartupPath, "licencia_cifrada.dat")
            Dim rutaArchivo As String = parametros.RutaLc.ToString()

            If File.Exists(rutaArchivo) Then
                Dim licencia = LicenciaHelper.LeerLicenciaLocal()
                If Not String.IsNullOrEmpty(licencia?.serialencryp) Then
                    Return licencia.serialencryp
                Else
                    Return Nothing
                End If
            End If

            ' Si no hay archivo o cpuid, se obtiene directamente del sistema
            Return ""
        Catch
            Return ""
        End Try
    End Function
    Private Async Function conexioninternet() As Task(Of Boolean)
        Try
            Using client As New HttpClient()
                client.Timeout = TimeSpan.FromSeconds(3)
                Dim response As HttpResponseMessage = Await client.GetAsync("https://www.google.com")
                Return response.IsSuccessStatusCode
            End Using
        Catch
            Return False
        End Try
    End Function
    Private Function validarestacion(licencia As Licencia) As String
        Dim mensaje As String = ""
        ' Validar licencia local si no fue válida la online
        If licencia Is Nothing Then
            licencia = LicenciaHelper.leerlicenciaestacion()
        End If

        If Not LicenciaHelper.LicenciaEsValida(licencia) Then
            mensaje = "La licencia no es válida o ha expirado. Vencida desde la fecha " & licencia.fechavencimientoserial?.ToString("dd/MM/yyyy")
            'controleslicencia(False)
        Else
            mensaje = "Licencia válida hasta: " & licencia.fechavencimientoserial?.ToString("dd/MM/yyyy")
            'controleslicencia(True)
        End If
        Return mensaje
    End Function
End Class
