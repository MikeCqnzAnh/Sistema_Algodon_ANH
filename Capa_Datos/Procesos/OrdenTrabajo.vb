Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.SqlClient
Public Class OrdenTrabajo
    Public Overridable Sub Upsert(ByRef EntidadOrdenTrabajo As Capa_Entidad.OrdenTrabajo)
        Dim EntidadOrdenTrabajo1 As New Capa_Entidad.OrdenTrabajo
        EntidadOrdenTrabajo1 = EntidadOrdenTrabajo
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            Select Case EntidadOrdenTrabajo1.Guarda
                Case Configuracion.Guardar.GuardarEncabezado
                    cmdGuardar = New SqlCommand("sp_InsertarOrdenTrabajo", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadOrdenTrabajo1.IdOrdenTrabajo))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdPlanta", EntidadOrdenTrabajo1.IdPlanta))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdProductor", EntidadOrdenTrabajo1.IdProductor))
                    cmdGuardar.Parameters.Add(New SqlParameter("@RangoInicio", EntidadOrdenTrabajo1.RangoInicio))
                    cmdGuardar.Parameters.Add(New SqlParameter("@RangoFin", EntidadOrdenTrabajo1.RangoFin))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdVariedadAlgodon", EntidadOrdenTrabajo1.IdVariedadAlgodon))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdColonia", EntidadOrdenTrabajo1.IdColonia))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Predio", EntidadOrdenTrabajo1.Predio))
                    cmdGuardar.Parameters.Add(New SqlParameter("@NumeroModulos", EntidadOrdenTrabajo1.NoModulos))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadOrdenTrabajo1.IdEstatus))
                    cmdGuardar.Parameters.Add(New SqlParameter("@checkpepena", EntidadOrdenTrabajo1.checkpepena))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadOrdenTrabajo1.IdUsuarioCreacion))
                    cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadOrdenTrabajo1.FechaCreacion))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioActualizacion", EntidadOrdenTrabajo1.IdUsuarioActualizacion))
                    cmdGuardar.Parameters.Add(New SqlParameter("@FechaActualizacion", EntidadOrdenTrabajo1.FechaActualizacion))
                    cmdGuardar.Parameters("@IdOrdenTrabajo").Direction = ParameterDirection.InputOutput
                    cmdGuardar.ExecuteNonQuery()
                    If EntidadOrdenTrabajo1.IdOrdenTrabajo = 0 Then
                        EntidadOrdenTrabajo1.IdOrdenTrabajo = cmdGuardar.Parameters("@IdOrdenTrabajo").Value
                    End If
                Case Configuracion.Guardar.GuardarDetalle
                    cmdGuardar = New SqlCommand("sp_InsertarBoletasPorOrden", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Clear()
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdBoleta", EntidadOrdenTrabajo1.IdBoleta))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadOrdenTrabajo1.IdOrdenTrabajo))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdPlanta", EntidadOrdenTrabajo1.IdPlanta))
                    cmdGuardar.Parameters.Add(New SqlParameter("@FechaOrden", EntidadOrdenTrabajo1.FechaCreacion))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Bruto", EntidadOrdenTrabajo1.PesoBruto))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Tara", EntidadOrdenTrabajo1.PesoTara))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Total", EntidadOrdenTrabajo1.PesoNeto))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdProductor", EntidadOrdenTrabajo1.IdProductor))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdBodega", 0))
                    cmdGuardar.Parameters.Add(New SqlParameter("@NoTransporte", EntidadOrdenTrabajo1.NoTransporte))
                    cmdGuardar.Parameters.Add(New SqlParameter("@FlagCancelada", EntidadOrdenTrabajo1.FlagCancelada))
                    cmdGuardar.Parameters.Add(New SqlParameter("@FlagRevisada", EntidadOrdenTrabajo1.FlagRevisada))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadOrdenTrabajo1.IdEstatus))
                    cmdGuardar.Parameters.Add(New SqlParameter("@checkpepena", EntidadOrdenTrabajo1.checkpepena))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdUSuarioCreacion", EntidadOrdenTrabajo1.IdUsuarioCreacion))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioActualizacion", EntidadOrdenTrabajo1.IdUsuarioActualizacion))
                    cmdGuardar.ExecuteNonQuery()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            EntidadOrdenTrabajo = EntidadOrdenTrabajo1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadOrdenTrabajo As Capa_Entidad.OrdenTrabajo)
        Dim EntidadOrdenTrabajo1 As New Capa_Entidad.OrdenTrabajo
        EntidadOrdenTrabajo1 = EntidadOrdenTrabajo
        EntidadOrdenTrabajo1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadOrdenTrabajo1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaExterna
                    sqldat1 = New SqlDataAdapter("sp_ConsultaPlantas", cnn)
                    sqldat1.Fill(EntidadOrdenTrabajo1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaVariedadesAlgodon
                    sqldat1 = New SqlDataAdapter("sp_ConsultaVariedadesAlgodon", cnn)
                    sqldat1.Fill(EntidadOrdenTrabajo1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaColonias
                    sqldat1 = New SqlDataAdapter("sp_ConsultaColonias", cnn)
                    sqldat1.Fill(EntidadOrdenTrabajo1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaProductorId
                    sqlcom1 = New SqlCommand("sp_ConsultaProductorId", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdProductor", EntidadOrdenTrabajo1.IdProductor))
                    sqldat1.Fill(EntidadOrdenTrabajo1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaRango
                    sqldat1 = New SqlDataAdapter("sp_ConsultaUltimoRango", cnn)
                    sqldat1.Fill(EntidadOrdenTrabajo1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    sqldat1 = New SqlDataAdapter("sp_ConsultaBasicaOrdenes", cnn)
                    sqldat1.Fill(EntidadOrdenTrabajo1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqlcom1 = New SqlCommand("Pa_ConsultaDetalleOrdenes", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadOrdenTrabajo1.IdOrdenTrabajo))
                    sqldat1.Fill(EntidadOrdenTrabajo1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaOrdenesDeTrabajo
                    sqlcom1 = New SqlCommand("Sp_LlenaComboOrdenTrabajo", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdProductor", EntidadOrdenTrabajo1.IdProductor))
                    sqldat1.Fill(EntidadOrdenTrabajo1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaOrdenEmbarqueEncabezado
                    sqlcom1 = New SqlCommand("Sp_ConsultaOrdentrabajoEnc", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadOrdenTrabajo1.IdOrdenTrabajo))
                    sqldat1.Fill(EntidadOrdenTrabajo1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaOrden
                    sqlcom1 = New SqlCommand("Sp_SeleccionOrdentrabajoEnc", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadOrdenTrabajo1.IdOrdenTrabajo))
                    sqldat1.Fill(EntidadOrdenTrabajo1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaOrdenRevision
                    sqlcom1 = New SqlCommand("Sp_ConsultarOrdenRevision", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadOrdenTrabajo1.IdOrdenTrabajo))
                    sqldat1.Fill(EntidadOrdenTrabajo1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadOrdenTrabajo = EntidadOrdenTrabajo1
        End Try
    End Sub
End Class
