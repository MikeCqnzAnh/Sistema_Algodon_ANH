Imports System.Data.SqlClient
Public Class CastigoResistenciaFibra
    Public Overridable Sub Upsert(ByRef EntidadCastigoResistenciaFibra As Capa_Entidad.CastigoResistenciaFibra)
        Dim EntidadCastigoResistenciaFibra1 As New Capa_Entidad.CastigoResistenciaFibra
        EntidadCastigoResistenciaFibra1 = EntidadCastigoResistenciaFibra
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarRangoFibra", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdLargoFibra", EntidadCastigoResistenciaFibra.IdCastigoResistenciaFibra))
            cmdGuardar.Parameters.Add(New SqlParameter("@Rango1", EntidadCastigoResistenciaFibra.Rango1))
            cmdGuardar.Parameters.Add(New SqlParameter("@Rango2", EntidadCastigoResistenciaFibra.Rango2))
            cmdGuardar.Parameters.Add(New SqlParameter("@Castigo", EntidadCastigoResistenciaFibra.Castigo))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadCastigoResistenciaFibra.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadCastigoResistenciaFibra.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadCastigoResistenciaFibra.FechaCreacion))
            cmdGuardar.Parameters("@IdLargoFibra").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadCastigoResistenciaFibra1.IdCastigoResistenciaFibra = 0 Then
                EntidadCastigoResistenciaFibra1.IdCastigoResistenciaFibra = cmdGuardar.Parameters("@IdLargoFibra").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCastigoResistenciaFibra = EntidadCastigoResistenciaFibra1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadCastigoResistenciaFibra As Capa_Entidad.CastigoResistenciaFibra)
        Dim EntidadCastigoResistenciaFibra1 = New Capa_Entidad.CastigoResistenciaFibra
        EntidadCastigoResistenciaFibra1 = EntidadCastigoResistenciaFibra
        EntidadCastigoResistenciaFibra1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadCastigoResistenciaFibra1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqldat1 = New SqlDataAdapter("sp_ConsultaLargoFibra", cnn)
                    sqldat1.Fill(EntidadCastigoResistenciaFibra1.TablaConsulta)
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
            EntidadCastigoResistenciaFibra = EntidadCastigoResistenciaFibra1
        End Try
    End Sub
End Class
