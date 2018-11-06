Imports System.Data.SqlClient
Public Class CastigoLargoFibra
    Public Overridable Sub Upsert(ByRef EntidadCastigoLargoFibra As Capa_Entidad.CastigoLargoFibra)
        Dim EntidadCastigoLargoFibra1 As New Capa_Entidad.CastigoLargoFibra
        EntidadCastigoLargoFibra1 = EntidadCastigoLargoFibra
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarRangoFibra", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdLargoFibra", EntidadCastigoLargoFibra.IdCastigoLargoFibra))
            cmdGuardar.Parameters.Add(New SqlParameter("@Rango1", EntidadCastigoLargoFibra.Rango1))
            cmdGuardar.Parameters.Add(New SqlParameter("@Rango2", EntidadCastigoLargoFibra.Rango2))
            cmdGuardar.Parameters.Add(New SqlParameter("@ColorGrade", EntidadCastigoLargoFibra.ColorGrade))
            cmdGuardar.Parameters.Add(New SqlParameter("@Castigo", EntidadCastigoLargoFibra.Castigo))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadCastigoLargoFibra.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadCastigoLargoFibra.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadCastigoLargoFibra.FechaCreacion))
            cmdGuardar.Parameters("@IdLargoFibra").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadCastigoLargoFibra1.IdCastigoLargoFibra = 0 Then
                EntidadCastigoLargoFibra1.IdCastigoLargoFibra = cmdGuardar.Parameters("@IdLargoFibra").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCastigoLargoFibra = EntidadCastigoLargoFibra1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadCastigoLargoFibra As Capa_Entidad.CastigoLargoFibra)
        Dim EntidadCastigoLargoFibra1 = New Capa_Entidad.CastigoLargoFibra
        EntidadCastigoLargoFibra1 = EntidadCastigoLargoFibra
        EntidadCastigoLargoFibra1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadCastigoLargoFibra1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqldat1 = New SqlDataAdapter("sp_ConsultaLargoFibra", cnn)
                    sqldat1.Fill(EntidadCastigoLargoFibra1.TablaConsulta)
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
            EntidadCastigoLargoFibra = EntidadCastigoLargoFibra1
        End Try
    End Sub
End Class
