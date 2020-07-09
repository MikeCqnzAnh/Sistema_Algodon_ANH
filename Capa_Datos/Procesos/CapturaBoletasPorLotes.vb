Imports System.Data.SqlClient
Public Class CapturaBoletasPorLotes
    Public Overridable Sub Consultar(ByRef EntidadCapturaBoletasPorLotes As Capa_Entidad.CapturaBoletasPorLotes)
        Dim EntidadCapturaBoletasPorLotes1 As New Capa_Entidad.CapturaBoletasPorLotes
        EntidadCapturaBoletasPorLotes1 = EntidadCapturaBoletasPorLotes
        EntidadCapturaBoletasPorLotes1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadCapturaBoletasPorLotes1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqldat1 = New SqlDataAdapter("sp_ConsultaModulos", cnn)
                    sqldat1.Fill(EntidadCapturaBoletasPorLotes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaExterna
                    sqlcom1 = New SqlCommand("sp_ConsultaModulosExterno", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdOrdenTrabajo", EntidadCapturaBoletasPorLotes1.IdOrdenTrabajo))
                    sqldat1.Fill(EntidadCapturaBoletasPorLotes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaModulosEntradas
                    sqldat1 = New SqlDataAdapter("sp_ConsultaModulosSinTara", cnn)
                    sqldat1.Fill(EntidadCapturaBoletasPorLotes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaModulosIncidencias
                    sqldat1 = New SqlDataAdapter("Sp_ConsultaIncidenciasBoletasPorLotes", cnn)
                    sqldat1.Fill(EntidadCapturaBoletasPorLotes1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCapturaBoletasPorLotes = EntidadCapturaBoletasPorLotes1
        End Try
    End Sub
    Public Overridable Sub Upsert(ByRef EntidadCapturaBoletasPorLotes As Capa_Entidad.CapturaBoletasPorLotes)
        Dim EntidadCapturaBoletasPorLotes1 As New Capa_Entidad.CapturaBoletasPorLotes
        EntidadCapturaBoletasPorLotes1 = EntidadCapturaBoletasPorLotes
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_ActualizaBoletaPeso", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@Idboleta", EntidadCapturaBoletasPorLotes1.Idboleta))
            cmdGuardar.Parameters.Add(New SqlParameter("@Bruto", EntidadCapturaBoletasPorLotes1.Bruto))
            cmdGuardar.Parameters.Add(New SqlParameter("@Tara", EntidadCapturaBoletasPorLotes1.Tara))
            cmdGuardar.Parameters.Add(New SqlParameter("@Total", EntidadCapturaBoletasPorLotes1.Neto))
            cmdGuardar.Parameters.Add(New SqlParameter("@FlagRevisada", EntidadCapturaBoletasPorLotes1.FlagRevisada))
            cmdGuardar.Parameters.Add(New SqlParameter("@FlagCancelada", EntidadCapturaBoletasPorLotes1.FlagCancelada))
            cmdGuardar.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCapturaBoletasPorLotes = EntidadCapturaBoletasPorLotes1
        End Try
    End Sub
    Public Overridable Sub UpsertAuto(ByRef EntidadCapturaBoletasPorLotes As Capa_Entidad.CapturaBoletasPorLotes)
        Dim EntidadCapturaBoletasPorLotes1 As New Capa_Entidad.CapturaBoletasPorLotes
        EntidadCapturaBoletasPorLotes1 = EntidadCapturaBoletasPorLotes
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        EntidadCapturaBoletasPorLotes1.TablaConsulta = New DataTable()
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("Sp_ActualizaBoletaPesoAuto", cnn)
            sqldat1 = New SqlDataAdapter(cmdGuardar)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Clear()
            cmdGuardar.Parameters.Add(New SqlParameter("@IdBoleta", EntidadCapturaBoletasPorLotes1.Idboleta))
            cmdGuardar.Parameters.Add(New SqlParameter("@NoTransporte", EntidadCapturaBoletasPorLotes1.NoTransporte))
            cmdGuardar.Parameters.Add(New SqlParameter("@PesoBruto", EntidadCapturaBoletasPorLotes1.Bruto))
            cmdGuardar.Parameters.Add(New SqlParameter("@Tara", EntidadCapturaBoletasPorLotes1.Tara))
            cmdGuardar.Parameters.Add(New SqlParameter("@Neto", EntidadCapturaBoletasPorLotes1.Neto))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaActualizacion", EntidadCapturaBoletasPorLotes1.FechaActualizacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@TipoFlete", EntidadCapturaBoletasPorLotes1.TipoFlete))
            sqldat1.Fill(EntidadCapturaBoletasPorLotes1.TablaConsulta)
            cmdGuardar.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCapturaBoletasPorLotes = EntidadCapturaBoletasPorLotes1
        End Try
    End Sub
    Public Overridable Sub ActualizaPesoOrden(ByRef EntidadCapturaBoletasPorLotes As Capa_Entidad.CapturaBoletasPorLotes)
        Dim EntidadCapturaBoletasPorLotes1 As New Capa_Entidad.CapturaBoletasPorLotes
        EntidadCapturaBoletasPorLotes1 = EntidadCapturaBoletasPorLotes
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("Sp_ActualizaPesoModulosOrdenTrabajo", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@idordentrabajo", EntidadCapturaBoletasPorLotes1.IdOrdenTrabajo))
            cmdGuardar.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCapturaBoletasPorLotes = EntidadCapturaBoletasPorLotes1
        End Try
    End Sub
End Class
