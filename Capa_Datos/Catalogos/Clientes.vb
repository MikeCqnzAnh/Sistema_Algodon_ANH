Imports System.Data.SqlClient
Public Class Clientes
    Public Overridable Sub Upsert(ByRef EntidadClientes As Capa_Entidad.Clientes)
        Dim EntidadClientes1 As New Capa_Entidad.Clientes()
        EntidadClientes1 = EntidadClientes
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarCliente", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdCliente", EntidadClientes1.IdCliente))
            cmdGuardar.Parameters.Add(New SqlParameter("@Socio", EntidadClientes1.Socio))
            cmdGuardar.Parameters.Add(New SqlParameter("@Nombre", EntidadClientes1.Nombre))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdTipoPersona", EntidadClientes1.IdTipoPersona))
            cmdGuardar.Parameters.Add(New SqlParameter("Rfc", EntidadClientes1.Rfc))
            cmdGuardar.Parameters.Add(New SqlParameter("@CurpFisica", EntidadClientes1.CurpFisica))
            cmdGuardar.Parameters.Add(New SqlParameter("@CalleFisica", EntidadClientes1.CalleFisica))
            cmdGuardar.Parameters.Add(New SqlParameter("@NumeroFisica", EntidadClientes1.NumeroFisica))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstadoFisica", EntidadClientes1.IdEstadoFisica))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdMunicipioFisica", EntidadClientes1.IdMunicipioFisica))
            cmdGuardar.Parameters.Add(New SqlParameter("@ColoniaFisica", EntidadClientes1.ColoniaFisica))
            cmdGuardar.Parameters.Add(New SqlParameter("@CelularFisica", EntidadClientes1.CelularFisica))
            cmdGuardar.Parameters.Add(New SqlParameter("@TelefonoFisica", EntidadClientes1.TelefonoFisica))
            cmdGuardar.Parameters.Add(New SqlParameter("@CorreoFisica", EntidadClientes1.CorreoFisica))
            cmdGuardar.Parameters.Add(New SqlParameter("@ApoderadoFisica", EntidadClientes1.ApoderadoFisica))
            cmdGuardar.Parameters.Add(New SqlParameter("@FolioActa", EntidadClientes1.FolioActa))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaActa", EntidadClientes1.FechaActa))
            cmdGuardar.Parameters.Add(New SqlParameter("@NotarioActa", EntidadClientes1.NotarioActa))
            cmdGuardar.Parameters.Add(New SqlParameter("@RegistroPublicoActa", EntidadClientes1.RegistroPublicoActa))
            cmdGuardar.Parameters.Add(New SqlParameter("@NumeroActa", EntidadClientes1.NumeroActa))
            cmdGuardar.Parameters.Add(New SqlParameter("@LibroActa", EntidadClientes1.LibroActa))
            cmdGuardar.Parameters.Add(New SqlParameter("@FolioMercantil", EntidadClientes1.FolioMercantial))
            cmdGuardar.Parameters.Add(New SqlParameter("@RfcApoderado", EntidadClientes1.RfcApoderado))
            cmdGuardar.Parameters.Add(New SqlParameter("@CurpApoderado", EntidadClientes1.CurpApoderado))
            cmdGuardar.Parameters.Add(New SqlParameter("@IneApoderado", EntidadClientes1.IneApoderado))
            cmdGuardar.Parameters.Add(New SqlParameter("@NumeroMoral", EntidadClientes1.NumeroMoral))
            cmdGuardar.Parameters.Add(New SqlParameter("@CalleMoral", EntidadClientes1.CalleMoral))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstadoMoral", EntidadClientes1.IdEstadoMoral))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdMunicipioMoral", EntidadClientes1.IdMunicipioMoral))
            cmdGuardar.Parameters.Add(New SqlParameter("@ColoniaMoral", EntidadClientes1.ColoniaMoral))
            cmdGuardar.Parameters.Add(New SqlParameter("@TelefonoMoral", EntidadClientes1.TelefonoMoral))
            cmdGuardar.Parameters.Add(New SqlParameter("@CelularMoral", EntidadClientes1.CelularMoral))
            cmdGuardar.Parameters.Add(New SqlParameter("@TelefonoApoderado", EntidadClientes1.TelefonoApoderado))
            cmdGuardar.Parameters.Add(New SqlParameter("@CelularApoderado", EntidadClientes1.CelularApoderado))
            cmdGuardar.Parameters.Add(New SqlParameter("@CorreoApoderado", EntidadClientes1.CorreoApoderado))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstadoMovilizacion", EntidadClientes1.IdEstadoMovilizacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdMunicipioMovilizacion", EntidadClientes1.IdMunicipioMovilizacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@Certificado", EntidadClientes1.Certificado))
            cmdGuardar.Parameters.Add(New SqlParameter("@Superficie", EntidadClientes1.Superficie))
            cmdGuardar.Parameters.Add(New SqlParameter("@Predio", EntidadClientes1.Predio))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdCuentaDe", EntidadClientes1.IdCuentaDe))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadClientes1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadClientes1.FechaCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadClientes1.IdEstatus))
            cmdGuardar.Parameters("@IdCliente").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadClientes1.IdCliente = 0 Then
                EntidadClientes1.IdCliente = cmdGuardar.Parameters("@IdCliente").Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            EntidadClientes = EntidadClientes1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadClientes As Capa_Entidad.Clientes)
        Dim EntidadClientes1 As New Capa_Entidad.Clientes()
        EntidadClientes1 = EntidadClientes
        Dim cnn As New SqlConnection(conexionPrincipal)
        EntidadClientes1.TablaConsulta = New DataTable()
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadClientes1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaEstado
                    sqldat1 = New SqlDataAdapter("sp_ConsultaEstados", cnn)
                    sqldat1.Fill(EntidadClientes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaMunicipio
                    sqlcom1 = New SqlCommand("sp_ConsultaMunicipios", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdEstadoFisica", EntidadClientes1.IdEstadoFisica))
                    sqldat1.Fill(EntidadClientes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaTipoPersona
                    sqldat1 = New SqlDataAdapter("sp_ConsultaTipoPersona", cnn)
                    sqldat1.Fill(EntidadClientes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaMunicipioMovilizacion
                    sqlcom1 = New SqlCommand("sp_ConsultaMunicipiosMov", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdEstadoMovilizacion", EntidadClientes1.IdEstadoMovilizacion))
                    sqldat1.Fill(EntidadClientes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaEstadoMoral
                    sqldat1 = New SqlDataAdapter("sp_ConsultaEstados", cnn)
                    sqldat1.Fill(EntidadClientes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaEstadoApoderado
                    sqldat1 = New SqlDataAdapter("sp_ConsultaEstados", cnn)
                    sqldat1.Fill(EntidadClientes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaMunicipioApoderado
                    sqlcom1 = New SqlCommand("sp_ConsultaMunicipiosApod", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdEstadoApoderado", EntidadClientes1.IdEstadoMoral))
                    sqldat1.Fill(EntidadClientes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaAsociaciones
                    sqldat1 = New SqlDataAdapter("sp_ConsultaAsociaciones", cnn)
                    sqldat1.Fill(EntidadClientes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    sqlcom1 = New SqlCommand("sp_ConsultaBasicaClientes", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@Nombre", EntidadClientes1.Nombre))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdCliente", EntidadClientes1.IdCliente))
                    sqldat1.Fill(EntidadClientes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqlcom1 = New SqlCommand("sp_ConsultaDetalladaClientes", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdCliente", EntidadClientes1.IdCliente))
                    sqldat1.Fill(EntidadClientes1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadClientes = EntidadClientes1
        End Try
    End Sub
End Class
