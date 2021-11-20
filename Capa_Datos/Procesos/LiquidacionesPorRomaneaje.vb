Imports System.Data.SqlClient
Public Class LiquidacionesPorRomaneaje
    Public Overridable Sub Consultar(ByRef EntidadLiquidacionesPorRomaneaje As Capa_Entidad.LiquidacionesPorRomaneaje)
        Dim EntidadLiquidacionesPorRomaneaje1 As New Capa_Entidad.LiquidacionesPorRomaneaje
        EntidadLiquidacionesPorRomaneaje1 = EntidadLiquidacionesPorRomaneaje
        EntidadLiquidacionesPorRomaneaje1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadLiquidacionesPorRomaneaje1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaModulosLiquidacion
                    sqldat1 = New SqlDataAdapter("sp_ConsultaModulos", cnn)
                    sqldat1.Fill(EntidadLiquidacionesPorRomaneaje1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaOrden
                    sqlcom1 = New SqlCommand("sp_ConsultaOrdenTrabajoLiquidacion", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadLiquidacionesPorRomaneaje1.IdOrdenTrabajo))
                    sqldat1.Fill(EntidadLiquidacionesPorRomaneaje1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPasasSinClase
                    sqlcom1 = New SqlCommand("Sp_ConsultaPacasSinClaseLiq", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadLiquidacionesPorRomaneaje1.IdOrdenTrabajo))
                    sqldat1.Fill(EntidadLiquidacionesPorRomaneaje1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqlcom1 = New SqlCommand("sp_ConsultaModulosLiquidacion", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadLiquidacionesPorRomaneaje1.IdOrdenTrabajo))
                    sqldat1.Fill(EntidadLiquidacionesPorRomaneaje1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaExterna
                    sqlcom1 = New SqlCommand("sp_ConsultaOrdenResumen", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadLiquidacionesPorRomaneaje1.IdOrdenTrabajo))
                    sqldat1.Fill(EntidadLiquidacionesPorRomaneaje1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPaca
                    sqlcom1 = New SqlCommand("Pa_ConsultaPacasSinClasificar", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadLiquidacionesPorRomaneaje1.IdOrdenTrabajo))
                    sqldat1.Fill(EntidadLiquidacionesPorRomaneaje1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPorId
                    sqlcom1 = New SqlCommand("sp_ConsultaCheckBoleta", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadLiquidacionesPorRomaneaje1.IdOrdenTrabajo))
                    sqldat1.Fill(EntidadLiquidacionesPorRomaneaje1.TablaConsulta)
                    For Each MiTableRow2 As DataRow In EntidadLiquidacionesPorRomaneaje1.TablaConsulta.Rows
                        If CStr(MiTableRow2.Item("FlagTerminado")) = False Then
                            EntidadLiquidacionesPorRomaneaje1.Bandera = False
                            Exit Select
                        Else
                            EntidadLiquidacionesPorRomaneaje1.Bandera = True
                        End If
                    Next
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadLiquidacionesPorRomaneaje = EntidadLiquidacionesPorRomaneaje1
        End Try
    End Sub
    Public Overridable Sub Upsert(ByRef EntidadLiquidacionesPorRomaneaje As Capa_Entidad.LiquidacionesPorRomaneaje)
        Dim EntidadLiquidacionesPorRomaneaje1 As New Capa_Entidad.LiquidacionesPorRomaneaje
        EntidadLiquidacionesPorRomaneaje1 = EntidadLiquidacionesPorRomaneaje
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarLiquidacionPorRomaneaje", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdLiquidacion", EntidadLiquidacionesPorRomaneaje1.IdLiquidacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadLiquidacionesPorRomaneaje1.IdOrdenTrabajo))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdCliente", EntidadLiquidacionesPorRomaneaje1.IdCliente))
            cmdGuardar.Parameters.Add(New SqlParameter("@Fecha", EntidadLiquidacionesPorRomaneaje1.Fecha))
            cmdGuardar.Parameters.Add(New SqlParameter("@Comentarios", EntidadLiquidacionesPorRomaneaje1.Comentarios))
            cmdGuardar.Parameters.Add(New SqlParameter("@TotalHueso", EntidadLiquidacionesPorRomaneaje1.TotalHueso))
            cmdGuardar.Parameters.Add(New SqlParameter("@TotalPluma", EntidadLiquidacionesPorRomaneaje1.TotalPluma))
            cmdGuardar.Parameters.Add(New SqlParameter("@PorcentajePluma", EntidadLiquidacionesPorRomaneaje1.PorcentajePluma))
            cmdGuardar.Parameters.Add(New SqlParameter("@PorcentajeSemilla", EntidadLiquidacionesPorRomaneaje1.PorcentajeSemilla))
            cmdGuardar.Parameters.Add(New SqlParameter("@TotalSemilla", EntidadLiquidacionesPorRomaneaje1.TotalSemilla))
            cmdGuardar.Parameters.Add(New SqlParameter("@PorcentajeMerma", EntidadLiquidacionesPorRomaneaje1.PorcentajeMerma))
            cmdGuardar.Parameters.Add(New SqlParameter("@TotalMerma", EntidadLiquidacionesPorRomaneaje1.TotalMerma))
            cmdGuardar.Parameters.Add(New SqlParameter("@TotalPacas", EntidadLiquidacionesPorRomaneaje1.TotalPacas))
            cmdGuardar.Parameters.Add(New SqlParameter("@TotalBoletas", EntidadLiquidacionesPorRomaneaje1.TotalBoletas))
            cmdGuardar.Parameters.Add(New SqlParameter("@TotalBorregos", EntidadLiquidacionesPorRomaneaje1.TotalBorregos))
            cmdGuardar.Parameters.Add(New SqlParameter("@TotalPlumaBorregos", EntidadLiquidacionesPorRomaneaje1.TotalPlumaBorregos))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadLiquidacionesPorRomaneaje1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadLiquidacionesPorRomaneaje1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadLiquidacionesPorRomaneaje1.FechaCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioActualizacion", EntidadLiquidacionesPorRomaneaje1.IdUsuarioActualizacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaActualizacion", EntidadLiquidacionesPorRomaneaje1.FechaActualizacion))
            cmdGuardar.Parameters("@IdLiquidacion").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadLiquidacionesPorRomaneaje1.IdLiquidacion = 0 Then
                EntidadLiquidacionesPorRomaneaje1.IdLiquidacion = cmdGuardar.Parameters("@IdLiquidacion").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadLiquidacionesPorRomaneaje = EntidadLiquidacionesPorRomaneaje1
        End Try
    End Sub
End Class
