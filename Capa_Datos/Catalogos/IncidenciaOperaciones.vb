Imports System.Data.SqlClient
Public Class IncidenciaOperaciones
    Public Overridable Sub Upsert(ByRef EntidadIncidenciaOperaciones As Capa_Entidad.IncidenciaOperaciones)
        Dim EntidadIncidenciaOperaciones1 As New Capa_Entidad.IncidenciaOperaciones
        EntidadIncidenciaOperaciones1 = EntidadIncidenciaOperaciones
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarIncidencia", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdIncidencia", EntidadIncidenciaOperaciones1.IdIncidencia))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdTipo", EntidadIncidenciaOperaciones1.IdTipo))
            cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadIncidenciaOperaciones1.Descripcion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadIncidenciaOperaciones1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadIncidenciaOperaciones1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadIncidenciaOperaciones1.FechaCreacion))
            cmdGuardar.Parameters("@IdIncidencia").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadIncidenciaOperaciones1.IdIncidencia = 0 Then
                EntidadIncidenciaOperaciones1.IdIncidencia = cmdGuardar.Parameters("@IdIncidencia").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadIncidenciaOperaciones = EntidadIncidenciaOperaciones1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadIncidenciaOperaciones As Capa_Entidad.IncidenciaOperaciones)
        Dim EntidadIncidenciaOperaciones1 = New Capa_Entidad.IncidenciaOperaciones
        EntidadIncidenciaOperaciones1 = EntidadIncidenciaOperaciones
        EntidadIncidenciaOperaciones1.TablaConsulta = New DataTable
        'Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadIncidenciaOperaciones1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqldat1 = New SqlDataAdapter("sp_ConsultaDetalleIncidencia", cnn)
                    sqldat1.Fill(EntidadIncidenciaOperaciones1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaExterna
                    sqldat1 = New SqlDataAdapter("sp_ConsultaTipoIncidencias", cnn)
                    sqldat1.Fill(EntidadIncidenciaOperaciones1.TablaConsulta)
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
            EntidadIncidenciaOperaciones = EntidadIncidenciaOperaciones1
        End Try
    End Sub
End Class
