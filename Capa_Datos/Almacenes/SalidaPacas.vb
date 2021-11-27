Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.SqlClient
Public Class SalidaPacas
    Public Overridable Sub Upsert(ByRef EntidadSalidaPacas As Capa_Entidad.SalidaPacas)
        Dim EntidadSalidaPacas1 As New Capa_Entidad.SalidaPacas
        EntidadSalidaPacas1 = EntidadSalidaPacas
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("Sp_InsertaSalidaPacas", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdSalidaEncabezado", CInt(EntidadSalidaPacas1.IdSalidaEncabezado)))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEmbarqueEncabezado", EntidadSalidaPacas1.IdEmbarqueEncabezado))
            cmdGuardar.Parameters.Add(New SqlParameter("@NoLote", EntidadSalidaPacas1.NoLote))
            cmdGuardar.Parameters.Add(New SqlParameter("@PesoBruto", EntidadSalidaPacas1.PesoBruto))
            cmdGuardar.Parameters.Add(New SqlParameter("@PesoTara", EntidadSalidaPacas1.PesoTara))
            cmdGuardar.Parameters.Add(New SqlParameter("@PesoNeto", EntidadSalidaPacas1.PesoNeto))
            cmdGuardar.Parameters.Add(New SqlParameter("@Destino", EntidadSalidaPacas1.Destino))
            cmdGuardar.Parameters.Add(New SqlParameter("@NoFactura", EntidadSalidaPacas1.NoFactura))
            cmdGuardar.Parameters.Add(New SqlParameter("@FolioSalida", EntidadSalidaPacas1.FolioSalida))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaEntrada", EntidadSalidaPacas1.FechaEntrada))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaSalida", EntidadSalidaPacas1.FechaSalida))
            cmdGuardar.Parameters.Add(New SqlParameter("@Observaciones", EntidadSalidaPacas1.Observaciones))
            cmdGuardar.Parameters.Add(New SqlParameter("@EstatusSalida", EntidadSalidaPacas1.EstatusSalida))
            cmdGuardar.Parameters("@IdSalidaEncabezado").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadSalidaPacas1.IdSalidaEncabezado = 0 Then
                EntidadSalidaPacas1.IdSalidaEncabezado = cmdGuardar.Parameters("@IdSalidaEncabezado").Value
            End If
        Catch ex As Exception
            cnn.Close()
            MsgBox(ex)
        Finally
            cnn.Close()
            EntidadSalidaPacas = EntidadSalidaPacas1
        End Try
    End Sub
    Public Overridable Sub UpsertSalidas(ByRef EntidadSalidaPacas As Capa_Entidad.SalidaPacas)
        Dim EntidadSalidaPacas1 As New Capa_Entidad.SalidaPacas
        EntidadSalidaPacas1 = EntidadSalidaPacas
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            Select Case EntidadSalidaPacas1.Guarda
                Case Capa_Operacion.Configuracion.Guardar.GuardarEncabezado
                    cmdGuardar = New SqlCommand("Pa_InsertaSalidaEncabezado", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdSalidaEncabezado", CInt(EntidadSalidaPacas1.IdSalidaEncabezado)))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdEmbarqueEncabezado", EntidadSalidaPacas1.IdEmbarqueEncabezado))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdCompradorPorCuentaDe", EntidadSalidaPacas1.IdCompradoAcuentade))
                    cmdGuardar.Parameters.Add(New SqlParameter("@NombreChofer", EntidadSalidaPacas1.NombreChofer))
                    cmdGuardar.Parameters.Add(New SqlParameter("@PlacaTractoCamion", EntidadSalidaPacas1.PlacaTractoCamion))
                    cmdGuardar.Parameters.Add(New SqlParameter("@NoLicencia", EntidadSalidaPacas1.NoLicencia))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Telefono", EntidadSalidaPacas1.Telefono))
                    cmdGuardar.Parameters.Add(New SqlParameter("@PesoBruto", EntidadSalidaPacas1.PesoBruto))
                    cmdGuardar.Parameters.Add(New SqlParameter("@PesoTara", EntidadSalidaPacas1.PesoTara))
                    cmdGuardar.Parameters.Add(New SqlParameter("@PesoNeto", EntidadSalidaPacas1.PesoNeto))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Destino", EntidadSalidaPacas1.Destino))
                    cmdGuardar.Parameters.Add(New SqlParameter("@NoFactura", EntidadSalidaPacas1.NoFactura))
                    cmdGuardar.Parameters.Add(New SqlParameter("@FolioSalida", EntidadSalidaPacas1.FolioSalida))
                    cmdGuardar.Parameters.Add(New SqlParameter("@FechaEntrada", EntidadSalidaPacas1.FechaEntrada))
                    cmdGuardar.Parameters.Add(New SqlParameter("@FechaSalida", EntidadSalidaPacas1.FechaSalida))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Observaciones", EntidadSalidaPacas1.Observaciones))
                    cmdGuardar.Parameters.Add(New SqlParameter("@EstatusSalida", EntidadSalidaPacas1.EstatusSalida))
                    cmdGuardar.Parameters("@IdSalidaEncabezado").Direction = ParameterDirection.InputOutput
                    cmdGuardar.ExecuteNonQuery()
                    If EntidadSalidaPacas1.IdSalidaEncabezado = 0 Then
                        EntidadSalidaPacas1.IdSalidaEncabezado = cmdGuardar.Parameters("@IdSalidaEncabezado").Value
                    End If

                Case Capa_Operacion.Configuracion.Guardar.GuardaPacas
                    cmdGuardar = New SqlCommand("Pa_ActualizaPacasSalidas", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdSalidaEncabezado", CInt(EntidadSalidaPacas1.IdSalidaEncabezado)))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdEmbarqueEncabezado", EntidadSalidaPacas1.IdEmbarqueEncabezado))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdComprador", EntidadSalidaPacas1.IdComprador))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdPlanta", EntidadSalidaPacas1.IdPlanta))
                    cmdGuardar.Parameters.Add(New SqlParameter("@BaleID", EntidadSalidaPacas1.BaleID))
                    cmdGuardar.Parameters.Add(New SqlParameter("@NoLote", EntidadSalidaPacas1.NoLote))
                    cmdGuardar.Parameters.Add(New SqlParameter("@NoContenedor", EntidadSalidaPacas1.NoContenedor))
                    cmdGuardar.Parameters.Add(New SqlParameter("@EstatusSalida", EntidadSalidaPacas1.EstatusSalida))
                    'cmdGuardar.Parameters("@IdSalidaEncabezado").Direction = ParameterDirection.InputOutput
                    cmdGuardar.ExecuteNonQuery()
                    'If EntidadSalidaPacas1.IdSalidaEncabezado = 0 Then
                    '    EntidadSalidaPacas1.IdSalidaEncabezado = cmdGuardar.Parameters("@IdSalidaEncabezado").Value
                    'End If
            End Select
        Catch ex As Exception
            cnn.Close()
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            EntidadSalidaPacas = EntidadSalidaPacas1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadSalidaPacas As Capa_Entidad.SalidaPacas)
        Dim EntidadSalidaPacas1 = New Capa_Entidad.SalidaPacas
        EntidadSalidaPacas1 = EntidadSalidaPacas
        EntidadSalidaPacas1.TablaConsulta = New DataTable
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadSalidaPacas1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPacasEmbarcado
                    sqlcom1 = New SqlCommand("Sp_ConsultaPacasSalidas", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdEmbarqueEncabezado", EntidadSalidaPacas1.IdEmbarqueEncabezado))
                    sqlcom1.Parameters.Add(New SqlParameter("@NoLote", EntidadSalidaPacas1.NoLote))
                    sqldat1.Fill(EntidadSalidaPacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaSalidaPacas
                    sqlcom1 = New SqlCommand("Sp_ConsultaSalidaPacas", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdSalidaPacas", EntidadSalidaPacas1.IdSalidaEncabezado))
                    sqlcom1.Parameters.Add(New SqlParameter("@NombreComprador", EntidadSalidaPacas1.NombreComprador))
                    sqldat1.Fill(EntidadSalidaPacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaEmbarqueParaSalida
                    sqlcom1 = New SqlCommand("Sp_ConsultaEmbarqueParaSalida", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdEmbarqueEncabezado", EntidadSalidaPacas1.IdEmbarqueEncabezado))
                    sqlcom1.Parameters.Add(New SqlParameter("@NoLote", EntidadSalidaPacas1.NoLote))
                    sqldat1.Fill(EntidadSalidaPacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaCompradores
                    sqlcom1 = New SqlCommand("Sp_ConsultaCompradorSalidas", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@Nombre", EntidadSalidaPacas1.NombreComprador))
                    sqldat1.Fill(EntidadSalidaPacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPaqueteDisponibleSalida
                    sqlcom1 = New SqlCommand("Sp_ConsultaPaquetesDisponiblesSalidas", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdEmbarqueEncabezado", EntidadSalidaPacas1.IdEmbarqueEncabezado))
                    sqldat1.Fill(EntidadSalidaPacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPacasDisponibleSalida
                    sqlcom1 = New SqlCommand("Pa_ConsultaPacasDisponiblesSalidas", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdEmbarqueEncabezado", EntidadSalidaPacas1.IdEmbarqueEncabezado))
                    sqldat1.Fill(EntidadSalidaPacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaEmbarqueParaSalidaSinSelecionar
                    sqlcom1 = New SqlCommand("Pa_ConsultaEmbarqueSinSalida", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdEmbarqueEncabezado", EntidadSalidaPacas1.IdEmbarqueEncabezado))
                    sqlcom1.Parameters.Add(New SqlParameter("@NombreComprador", EntidadSalidaPacas1.NombreComprador))
                    sqlcom1.Parameters.Add(New SqlParameter("@NoLote", EntidadSalidaPacas1.NoLoteInd))
                    sqldat1.Fill(EntidadSalidaPacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPaquetesSalida
                    sqlcom1 = New SqlCommand("Pa_ConsultaSalidaEncabezado", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdSalidaEncabezado", EntidadSalidaPacas1.IdSalidaEncabezado))
                    sqldat1.Fill(EntidadSalidaPacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPacasSalidas
                    sqlcom1 = New SqlCommand("Pa_ConsultaPacasSalidas", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdSalidaEncabezado", EntidadSalidaPacas1.IdSalidaEncabezado))
                    sqldat1.Fill(EntidadSalidaPacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaSalidaEncabezado
                    sqlcom1 = New SqlCommand("Pa_ConsultaSalidasPacas", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdSalidaEncabezado", EntidadSalidaPacas1.IdSalidaEncabezado))
                    sqlcom1.Parameters.Add(New SqlParameter("@NombreComprador", EntidadSalidaPacas1.NombreComprador))
                    sqldat1.Fill(EntidadSalidaPacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPacaSalidaSeleccionado
                    sqlcom1 = New SqlCommand("Pa_ConsultaPacasSeleccionadasSalidas", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdSalidaEncabezado", EntidadSalidaPacas1.IdSalidaEncabezado))
                    sqldat1.Fill(EntidadSalidaPacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPaqueteSalidaSeleccionado
                    sqlcom1 = New SqlCommand("Sp_ConsultaPaquetesSeleccionadoSalidas", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdSalidaEncabezado", EntidadSalidaPacas1.IdSalidaEncabezado))
                    sqldat1.Fill(EntidadSalidaPacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPacasSalidasFiltro
                    sqlcom1 = New SqlCommand("Sp_ConsultaPacasDisponiblesSalidas", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdEmbarqueEncabezado", EntidadSalidaPacas1.IdEmbarqueEncabezado))
                    sqlcom1.Parameters.Add(New SqlParameter("@NoLote", EntidadSalidaPacas1.NoLote))
                    sqldat1.Fill(EntidadSalidaPacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaComboLotes
                    sqlcom1 = New SqlCommand("Pa_LlenaComboLotes", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.CommandTimeout = 0
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@EstatusSalida", EntidadSalidaPacas1.EstatusSalida))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdEmbarqueEnc", EntidadSalidaPacas1.IdEmbarqueEncabezado))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdSalidaEnc", EntidadSalidaPacas1.IdSalida))
                    sqldat1.Fill(EntidadSalidaPacas1.TablaConsulta)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            EntidadSalidaPacas = EntidadSalidaPacas1
        End Try
    End Sub
    Public Overridable Sub Actualizar(ByRef EntidadSalidaPacas As Capa_Entidad.SalidaPacas)
        Dim EntidadSalidaPacas1 As New Capa_Entidad.SalidaPacas
        EntidadSalidaPacas1 = EntidadSalidaPacas
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("Sp_ActualizaSalidaPacas", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdSalidaPaca", CInt(EntidadSalidaPacas1.IdSalidaEncabezado)))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEmbarqueEncabezado", EntidadSalidaPacas1.IdEmbarqueEncabezado))
            cmdGuardar.Parameters.Add(New SqlParameter("@NoLote", EntidadSalidaPacas1.NoLote))
            cmdGuardar.Parameters.Add(New SqlParameter("@EstatusSalida", EntidadSalidaPacas1.EstatusSalida))
            cmdGuardar.ExecuteNonQuery()
        Catch ex As Exception
            cnn.Close()
            MsgBox(ex)
        Finally
            cnn.Close()
            'EntidadSalidaPacas = EntidadSalidaPacas1
        End Try
    End Sub
End Class
