Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.SqlClient
Public Class Colonias
    Public Overridable Sub Upsert(ByRef EntidadColonias As Capa_Entidad.Colonias)
        Dim EntidadColonias1 As New Capa_Entidad.Colonias
        EntidadColonias1 = EntidadColonias
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarColonias", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdColonia", EntidadColonias1.IdColonia))
            cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadColonias1.Descripcion))
            cmdGuardar.Parameters.Add(New SqlParameter("@NoPacas", EntidadColonias1.NumeroPacas))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadColonias1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadColonias1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadColonias1.FechaCreacion))
            cmdGuardar.Parameters("@IdColonia").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadColonias1.IdColonia = 0 Then
                EntidadColonias1.IdColonia = cmdGuardar.Parameters("@IdColonia").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadColonias = EntidadColonias1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadColonias As Capa_Entidad.Colonias)
        Dim EntidadColonias1 = New Capa_Entidad.Colonias
        EntidadColonias1 = EntidadColonias
        EntidadColonias1.TablaConsulta = New DataTable
        'Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadColonias1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqldat1 = New SqlDataAdapter("sp_ConsultaDetalleColonias", cnn)
                    sqldat1.Fill(EntidadColonias1.TablaConsulta)
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
            EntidadColonias = EntidadColonias1
        End Try
    End Sub
End Class
