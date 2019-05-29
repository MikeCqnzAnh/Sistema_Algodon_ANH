
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
            cmdGuardar.Parameters.Add(New SqlParameter("@FolioCIA", EntidadProduccion1.FolioCIA))
            cmdGuardar.Parameters.Add(New SqlParameter("@Tipo", EntidadProduccion1.Tipo))
            cmdGuardar.Parameters.Add(New SqlParameter("@Kilos", EntidadProduccion1.Kilos))
            cmdGuardar.Parameters.Add(New SqlParameter("@BandExiste", EntidadProduccion1.BandExiste))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdTurno", EntidadProduccion1.IdTurno))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadProduccion1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@Fecha", EntidadProduccion1.Fecha))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdBaja", EntidadProduccion1.IdBaja))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaBaja", EntidadProduccion1.FechaBaja))
            cmdGuardar.Parameters.Add(New SqlParameter("@ClaveClasificacion", EntidadProduccion1.ClaveClasificacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@Micros", EntidadProduccion1.Micros))
            cmdGuardar.Parameters.Add(New SqlParameter("@Castigo", EntidadProduccion1.Castigo))
            cmdGuardar.Parameters.Add(New SqlParameter("@CastigoMicCpa", EntidadProduccion1.CastigoMicCpa))
            cmdGuardar.Parameters.Add(New SqlParameter("@CastigoMicVta", EntidadProduccion1.CastigoMicVta))
            cmdGuardar.Parameters.Add(New SqlParameter("@CastigoLargoFibra", EntidadProduccion1.CastigoLargoFibra))
            cmdGuardar.Parameters.Add(New SqlParameter("@CastigoLargoFibraCpa", EntidadProduccion1.CastigoLargoFibraCpa))
            cmdGuardar.Parameters.Add(New SqlParameter("@CastigoLargoFibraVta", EntidadProduccion1.CastigoLargoFibraVta))
            cmdGuardar.Parameters.Add(New SqlParameter("@CastigoResistenciaFibra", EntidadProduccion1.CastigoResistenciaFibra))
            cmdGuardar.Parameters.Add(New SqlParameter("@CastigoResistenciaFibraCpa", EntidadProduccion1.CastigoResistenciaFibraCpa))
            cmdGuardar.Parameters.Add(New SqlParameter("@CastigoResistenciaFibraVta", EntidadProduccion1.CastigoResistenciaFibraVta))
            cmdGuardar.Parameters.Add(New SqlParameter("@ClaveClasificacionCpa", EntidadProduccion1.ClaveClasificacionCpa))
            cmdGuardar.Parameters.Add(New SqlParameter("@ClaveClasificacionVta", EntidadProduccion1.ClaveClasificacionVta))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaClasificacion", EntidadProduccion1.FechaClasificacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@Libras", EntidadProduccion1.Libras))
            cmdGuardar.Parameters.Add(New SqlParameter("@ClaveCertificado", EntidadProduccion1.ClaveCertificado))
            cmdGuardar.Parameters.Add(New SqlParameter("@ClaveContratoAlgodon", EntidadProduccion1.ClaveContratoAlgodon))
            cmdGuardar.Parameters.Add(New SqlParameter("@ClaveContratoAlgodon2", EntidadProduccion1.ClaveContratoAlgodon2))
            cmdGuardar.Parameters.Add(New SqlParameter("@ClavePaqueteHVI", EntidadProduccion1.ClavePaqueteHVI))
            cmdGuardar.Parameters.Add(New SqlParameter("@LargoFibra", EntidadProduccion1.CastigoLargoFibra))
            cmdGuardar.Parameters.Add(New SqlParameter("@ResistenciaFibra", EntidadProduccion1.ResistenciaFibra))
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
                    sqlcom1.Parameters.Add(New SqlParameter("@FolioCIA", EntidadProduccion.FolioCIA))
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
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadProduccion = EntidadProduccion1
        End Try
    End Sub
End Class