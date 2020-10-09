Imports System.Data.SqlClient
Public Class OrdenTrabajo
    Public Overridable Sub Upsert(ByRef EntidadOrdenTrabajo As Capa_Entidad.OrdenTrabajo)
        Dim EntidadOrdenTrabajo1 As New Capa_Entidad.OrdenTrabajo
        EntidadOrdenTrabajo1 = EntidadOrdenTrabajo
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
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
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadOrdenTrabajo1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadOrdenTrabajo1.FechaCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioActualizacion", EntidadOrdenTrabajo1.IdUsuarioActualizacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaActualizacion", EntidadOrdenTrabajo1.FechaActualizacion))
            cmdGuardar.Parameters("@IdOrdenTrabajo").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadOrdenTrabajo1.IdOrdenTrabajo = 0 Then
                EntidadOrdenTrabajo1.IdOrdenTrabajo = cmdGuardar.Parameters("@IdOrdenTrabajo").Value
                Dim index As Integer = EntidadOrdenTrabajo1.RangoInicio
                Do
                    cmdGuardar.CommandText = "sp_InsertarBoletasPorOrden"
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Clear()
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdBoleta", 0))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadOrdenTrabajo1.IdOrdenTrabajo))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdPlanta", EntidadOrdenTrabajo1.IdPlanta))
                    cmdGuardar.Parameters.Add(New SqlParameter("@FechaOrden", EntidadOrdenTrabajo1.FechaCreacion))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Bruto", 0))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Tara", 0))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Total", 0))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdProductor", EntidadOrdenTrabajo1.IdProductor))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdBodega", 0))
                    cmdGuardar.Parameters.Add(New SqlParameter("@NoTransporte", 0))
                    cmdGuardar.Parameters.Add(New SqlParameter("@FlagCancelada", False))
                    cmdGuardar.Parameters.Add(New SqlParameter("@FlagRevisada", False))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", 1))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdUSuarioCreacion", 1))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioActualizacion", 1))
                    cmdGuardar.ExecuteNonQuery()
                    index += 1
                Loop Until index = EntidadOrdenTrabajo1.RangoFin + 1
            End If
        Catch ex As Exception
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
                Case Capa_Operacion.Configuracion.Consulta.ConsultaOrdenesDeTrabajo
                    sqlcom1 = New SqlCommand("Sp_LlenaComboOrdenTrabajo", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdProductor", EntidadOrdenTrabajo1.IdProductor))
                    sqldat1.Fill(EntidadOrdenTrabajo1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadOrdenTrabajo = EntidadOrdenTrabajo1
        End Try
    End Sub
End Class
