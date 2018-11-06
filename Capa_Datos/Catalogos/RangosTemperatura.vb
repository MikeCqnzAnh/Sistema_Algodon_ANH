Imports System.Data.SqlClient
Public Class RangosTemperatura
    Public Overridable Sub Upsert(ByRef EntidadRangosTemperatura As Capa_Entidad.RangosTemperatura)
        Dim EntidadRangosTemperatura1 As New Capa_Entidad.RangosTemperatura
        EntidadRangosTemperatura1 = EntidadRangosTemperatura
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarRango", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdRango", EntidadRangosTemperatura1.IdRango))
            cmdGuardar.Parameters.Add(New SqlParameter("@RangoInicial", EntidadRangosTemperatura1.RangoInicial))
            cmdGuardar.Parameters.Add(New SqlParameter("@RangoFinal", EntidadRangosTemperatura1.RangoFinal))
            cmdGuardar.Parameters.Add(New SqlParameter("@DentroLimite", EntidadRangosTemperatura1.DentroLimite))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadRangosTemperatura1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadRangosTemperatura1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadRangosTemperatura1.FechaCreacion))
            cmdGuardar.Parameters("@IdRango").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadRangosTemperatura1.IdRango = 0 Then
                EntidadRangosTemperatura1.IdRango = cmdGuardar.Parameters("@IdRango").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadRangosTemperatura = EntidadRangosTemperatura1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadRangosTemperatura As Capa_Entidad.RangosTemperatura)
        Dim EntidadRangosTemperatura1 = New Capa_Entidad.RangosTemperatura
        EntidadRangosTemperatura1 = EntidadRangosTemperatura
        EntidadRangosTemperatura1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadRangosTemperatura1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqldat1 = New SqlDataAdapter("sp_ConsultaDetalleRangos", cnn)
                    sqldat1.Fill(EntidadRangosTemperatura1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaEstado
                    '    sqldat1 = New SqlDataAdapter("sp_ConsultaEstados", cnn)
                    '    sqldat1.Fill(EntidadCompradores1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaMunicipio
                    '    sqlcom1 = New SqlCommand("sp_ConsultaMunicipios", cnn)
                    '    sqldat1 = New SqlDataAdapter(sqlcom1)
                    '    sqlcom1.CommandType = CommandType.StoredProcedure
                    '    sqlcom1.Parameters.Clear()
                    '    sqlcom1.Parameters.Add(New SqlParameter("@IdEstadoFisica", EntidadCompradores1.IdEstado))
                    '    sqldat1.Fill(EntidadCompradores1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadRangosTemperatura = EntidadRangosTemperatura1
        End Try
    End Sub
End Class
