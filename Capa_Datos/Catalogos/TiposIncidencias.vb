Imports System.Data.SqlClient
Public Class TiposIncidencias
    Public Overridable Sub Upsert(ByRef EntidadTiposIncidencias As Capa_Entidad.TiposIncidencias)
        Dim EntidadTiposIncidencias1 As New Capa_Entidad.TiposIncidencias
        EntidadTiposIncidencias1 = EntidadTiposIncidencias
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarTipoIncidencia", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdTipoIncidencia", EntidadTiposIncidencias1.IdTipoIncidencia))
            cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadTiposIncidencias1.Descripcion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadTiposIncidencias1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadTiposIncidencias1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadTiposIncidencias1.FechaCreacion))
            cmdGuardar.Parameters("@IdTipoIncidencia").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadTiposIncidencias1.IdTipoIncidencia = 0 Then
                EntidadTiposIncidencias1.IdTipoIncidencia = cmdGuardar.Parameters("@IdTipoIncidencia").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadTiposIncidencias = EntidadTiposIncidencias1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadTiposIncidencias As Capa_Entidad.TiposIncidencias)
        Dim EntidadTiposIncidencias1 As New Capa_Entidad.TiposIncidencias
        EntidadTiposIncidencias1 = EntidadTiposIncidencias
        EntidadTiposIncidencias1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadTiposIncidencias1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqldat1 = New SqlDataAdapter("sp_ConsultaDetalleTipInc", cnn)
                    sqldat1.Fill(EntidadTiposIncidencias1.TablaConsulta)
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
            EntidadTiposIncidencias = EntidadTiposIncidencias1
        End Try
    End Sub
End Class
