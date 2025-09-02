Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.SqlClient
Public Class Produccion
    Public Overridable Sub Upsert(ByRef EntidadProduccion As Capa_Entidad.Produccion)
        Dim EntidadProduccion1 As New Capa_Entidad.Produccion
        EntidadProduccion1 = EntidadProduccion
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarProduccion", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdProduccion", EntidadProduccion1.IdProduccion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadProduccion1.IdOrdenTrabajo))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdPlantaOrigen", EntidadProduccion1.IdPlantaOrigen))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdPlantaDestino", EntidadProduccion1.IdPlantaDestino))
            cmdGuardar.Parameters.Add(New SqlParameter("@Fecha", EntidadProduccion1.Fecha))
            cmdGuardar.Parameters.Add(New SqlParameter("@Tipo", EntidadProduccion1.Tipo))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdCliente", EntidadProduccion1.IdCliente))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", 1))
            cmdGuardar.Parameters.Add(New SqlParameter("@TotalHueso", EntidadProduccion1.TotalHueso))
            cmdGuardar.Parameters.Add(New SqlParameter("@Pacas", EntidadProduccion1.Pacas))
            cmdGuardar.Parameters.Add(New SqlParameter("@PlumaPacas", EntidadProduccion1.PlumaPacas))
            cmdGuardar.Parameters.Add(New SqlParameter("@PlumaBorregos", EntidadProduccion1.PlumaBorregos))
            cmdGuardar.Parameters.Add(New SqlParameter("@Pluma", EntidadProduccion1.Pluma))
            cmdGuardar.Parameters.Add(New SqlParameter("@Semilla", EntidadProduccion1.Semilla))
            cmdGuardar.Parameters.Add(New SqlParameter("@Merma", EntidadProduccion1.Merma))
            cmdGuardar.Parameters.Add(New SqlParameter("@Borra", EntidadProduccion1.Borra))
            cmdGuardar.Parameters.Add(New SqlParameter("@PorcentajePluma", EntidadProduccion1.PorcentajePluma))
            cmdGuardar.Parameters.Add(New SqlParameter("@PorcentajeSemilla", EntidadProduccion1.PorcentajeSemilla))
            cmdGuardar.Parameters.Add(New SqlParameter("@PorcentajeMerma", EntidadProduccion1.PorcentajeMerma))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadProduccion1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadProduccion1.FechaCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioActualizacion", EntidadProduccion1.IdUsuarioActualizacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaActualizacion", EntidadProduccion1.FechaActualizacion))
            cmdGuardar.Parameters("@IdProduccion").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadProduccion1.IdProduccion = 0 Then
                EntidadProduccion1.IdProduccion = cmdGuardar.Parameters("@IdProduccion").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadProduccion = EntidadProduccion1
        End Try
    End Sub
    Public Overridable Sub UpsertDetalle(ByRef EntidadProduccion As Capa_Entidad.Produccion)
        Dim EntidadProduccion1 As New Capa_Entidad.Produccion
        EntidadProduccion1 = EntidadProduccion
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarProduccionDetalle", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdProduccionDetalle", EntidadProduccion1.IdProduccionDetalle))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdProduccion", EntidadProduccion1.IdProduccion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadProduccion1.IdOrdenTrabajo))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdPlantaOrigen", EntidadProduccion1.IdPlantaOrigen))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdPlantaDestino", EntidadProduccion1.IdPlantaDestino))
            cmdGuardar.Parameters.Add(New SqlParameter("@BaleID", EntidadProduccion1.BaleID))
            cmdGuardar.Parameters.Add(New SqlParameter("@Tipo", EntidadProduccion1.Tipo))
            cmdGuardar.Parameters.Add(New SqlParameter("@Kilos", EntidadProduccion1.Kilos))
            cmdGuardar.Parameters.Add(New SqlParameter("@Libras", EntidadProduccion1.Libras))
            cmdGuardar.Parameters.Add(New SqlParameter("@Quintales", EntidadProduccion1.Quintales))
            cmdGuardar.Parameters.Add(New SqlParameter("@BandExiste", EntidadProduccion1.BandExiste))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdTurno", EntidadProduccion1.IdTurno))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadProduccion1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@Fecha", EntidadProduccion1.Fecha))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdBaja", EntidadProduccion1.IdBaja))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaBaja", EntidadProduccion1.FechaBaja))
            cmdGuardar.ExecuteNonQuery()
            'If EntidadProduccion1.IdProduccion = 0 Then
            '    EntidadProduccion1.IdProduccion = cmdGuardar.Parameters("@IdProduccion").Value
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            EntidadProduccion = EntidadProduccion1
        End Try
    End Sub

    Public Overridable Sub UpsertEtiqueta(ByRef EntidadProduccion As Capa_Entidad.Produccion)
        Dim EntidadProduccion1 As New Capa_Entidad.Produccion
        EntidadProduccion1 = EntidadProduccion
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_ConsultaUltimaEtiqueta", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdPlantaOrigen", EntidadProduccion1.IdPlantaOrigen))
            cmdGuardar.Parameters.Add(New SqlParameter("@Etiqueta", EntidadProduccion1.BaleID))
            cmdGuardar.ExecuteNonQuery()
            'If EntidadProduccion1.IdProduccion = 0 Then
            '    EntidadProduccion1.IdProduccion = cmdGuardar.Parameters("@IdProduccion").Value
            'End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadProduccion = EntidadProduccion1
        End Try
    End Sub
    Public Overridable Sub UpsertActualizaEtiqueta(ByRef EntidadProduccion As Capa_Entidad.Produccion)
        Dim EntidadProduccion1 As New Capa_Entidad.Produccion
        EntidadProduccion1 = EntidadProduccion
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_ConsultaUltimaEtiqueta", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdPlantaOrigen", EntidadProduccion1.IdPlantaOrigen))
            cmdGuardar.Parameters.Add(New SqlParameter("@Etiqueta", EntidadProduccion1.FolioCIA))
            cmdGuardar.ExecuteNonQuery()
            'If EntidadProduccion1.IdProduccion = 0 Then
            '    EntidadProduccion1.IdProduccion = cmdGuardar.Parameters("@IdProduccion").Value
            'End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadProduccion = EntidadProduccion1
        End Try
    End Sub
    Public Overridable Sub UpsertEstatusRevisado(ByRef EntidadProduccion As Capa_Entidad.Produccion)
        Dim EntidadProduccion1 As New Capa_Entidad.Produccion
        EntidadProduccion1 = EntidadProduccion
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("Pa_ActualizaEstatusRevision", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdProduccion", EntidadProduccion1.IdProduccion))
            cmdGuardar.Parameters.Add(New SqlParameter("@EstatusRevision", EntidadProduccion1.IdEstatus))
            cmdGuardar.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            EntidadProduccion = EntidadProduccion1
        End Try
    End Sub
    Public Overridable Sub UpsertFolioInicial(ByRef EntidadProduccion As Capa_Entidad.Produccion)
        Dim EntidadProduccion1 As New Capa_Entidad.Produccion
        EntidadProduccion1 = EntidadProduccion
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_UpsertFolioInicial", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdPlantaOrigen", EntidadProduccion1.IdPlantaOrigen))
            cmdGuardar.Parameters.Add(New SqlParameter("@FolioInicial", EntidadProduccion1.FolioInicial))
            cmdGuardar.ExecuteNonQuery()
            'If EntidadProduccion1.IdProduccion = 0 Then
            '    EntidadProduccion1.IdProduccion = cmdGuardar.Parameters("@IdProduccion").Value
            'End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadProduccion = EntidadProduccion1
        End Try
    End Sub
    Public Overridable Sub UpsertLeerEtiqueta(ByRef EntidadProduccion As Capa_Entidad.Produccion)
        Dim EntidadProduccion1 As New Capa_Entidad.Produccion
        EntidadProduccion1 = EntidadProduccion
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("Sp_ActualizaEstadoLeerEtiqueta", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdPlantaOrigen", EntidadProduccion1.IdPlantaOrigen))
            cmdGuardar.Parameters.Add(New SqlParameter("@LeerEtiqueta", EntidadProduccion1.LeerEtiqueta))
            cmdGuardar.ExecuteNonQuery()
            'If EntidadProduccion1.IdProduccion = 0 Then
            '    EntidadProduccion1.IdProduccion = cmdGuardar.Parameters("@IdProduccion").Value
            'End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadProduccion = EntidadProduccion1
        End Try
    End Sub
    Public Overridable Sub Eliminar(ByRef EntidadProduccion As Capa_Entidad.Produccion)
        Dim EntidadProduccion1 As New Capa_Entidad.Produccion
        EntidadProduccion1 = EntidadProduccion
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            Select Case EntidadProduccion1.Eliminar
                Case Capa_Operacion.Configuracion.Eliminar.EliminaPacaSeleccionada
                    cmdGuardar = New SqlCommand("Sp_EliminaPacasSeleccionadas", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Add(New SqlParameter("@idproducciondetalle", EntidadProduccion1.IdProduccionDetalle))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadProduccion1.IdOrdenTrabajo))
                    cmdGuardar.ExecuteNonQuery()
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadProduccion = EntidadProduccion1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadProduccion As Capa_Entidad.Produccion)
        Dim EntidadProduccion1 As New Capa_Entidad.Produccion
        EntidadProduccion1 = EntidadProduccion
        EntidadProduccion1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadProduccion1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaExterna
                    sqldat1 = New SqlDataAdapter("sp_ConsultaPlantas", cnn)
                    sqldat1.Fill(EntidadProduccion1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqlcom1 = New SqlCommand("sp_ConsultaOrdenTrabajo", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadProduccion.IdOrdenTrabajo))
                    sqldat1.Fill(EntidadProduccion1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaOperadores
                    sqldat1 = New SqlDataAdapter("sp_ConsultaEmpleados", cnn)
                    sqldat1.Fill(EntidadProduccion1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaModoCompra
                    sqldat1 = New SqlDataAdapter("sp_LlenaComboModalidadesCompra", cnn)
                    sqldat1.Fill(EntidadProduccion1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    sqlcom1 = New SqlCommand("sp_ConsultaBasProdDet", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdProduccion", EntidadProduccion.IdProduccion))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPlantaOrigen", EntidadProduccion.IdPlantaOrigen))
                    sqldat1.Fill(EntidadProduccion1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPorId
                    sqlcom1 = New SqlCommand("sp_ConsultaProdPorPorOrden", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadProduccion.IdOrdenTrabajo))
                    sqldat1.Fill(EntidadProduccion1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPaca
                    sqlcom1 = New SqlCommand("sp_ConsultaProdPorPorOrden", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadProduccion.IdOrdenTrabajo))
                    sqldat1.Fill(EntidadProduccion1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPacaExistente
                    sqlcom1 = New SqlCommand("sp_ConsultaPacaExistente", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@baleid", EntidadProduccion.BaleID))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPlantaOrigen", EntidadProduccion.IdPlantaOrigen))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdProduccion", EntidadProduccion.IdProduccion))
                    sqldat1.Fill(EntidadProduccion1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaSecuencia
                    sqlcom1 = New SqlCommand("sp_ConsultaSecuencia", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPlantaOrigen", EntidadProduccion.IdPlantaOrigen))
                    sqldat1.Fill(EntidadProduccion1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaProduccionRevision
                    sqlcom1 = New SqlCommand("Sp_ConsultaProduccionRevision", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdProduccion", EntidadProduccion.IdProduccion))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadProduccion.IdOrdenTrabajo))
                    sqlcom1.Parameters.Add(New SqlParameter("@Nombre", EntidadProduccion.NombreProductor))
                    sqldat1.Fill(EntidadProduccion1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaEstatusRevision
                    sqlcom1 = New SqlCommand("Pa_ConsultaRevisionProduccion", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdProduccion", EntidadProduccion.IdProduccion))
                    sqldat1.Fill(EntidadProduccion1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaProduccionPesos
                    sqlcom1 = New SqlCommand("Sp_ConsultaProduccionPesos", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdentrabajo", EntidadProduccion.IdOrdenTrabajo))
                    sqlcom1.Parameters.Add(New SqlParameter("@KilosElegir", EntidadProduccion.Kilos))
                    sqlcom1.Parameters.Add(New SqlParameter("@NumRegistros", EntidadProduccion.NumeroRegistro))
                    sqlcom1.Parameters.Add(New SqlParameter("@PesoElegir", EntidadProduccion.PesoElegir))
                    sqldat1.Fill(EntidadProduccion1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadProduccion = EntidadProduccion1
        End Try
    End Sub
End Class