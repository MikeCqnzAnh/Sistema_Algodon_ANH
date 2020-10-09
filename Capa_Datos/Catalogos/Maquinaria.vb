Imports System.Data.SqlClient
Public Class Maquinaria
    Public Overridable Sub Upsert(ByRef EntidadMaquinaria As Capa_Entidad.Maquinaria)
        Dim EntidadMaquinaria1 As New Capa_Entidad.Maquinaria
        EntidadMaquinaria1 = EntidadMaquinaria
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarMaquinaria", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdMaquinaria", EntidadMaquinaria1.IdMaquinaria))
            cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadMaquinaria1.Descripcion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadMaquinaria1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadMaquinaria1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadMaquinaria1.FechaCreacion))
            cmdGuardar.Parameters("@IdMaquinaria").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadMaquinaria1.IdMaquinaria = 0 Then
                EntidadMaquinaria1.IdMaquinaria = cmdGuardar.Parameters("@IdMaquinaria").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadMaquinaria = EntidadMaquinaria1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadMaquinaria As Capa_Entidad.Maquinaria)
        Dim EntidadMaquinaria1 = New Capa_Entidad.Maquinaria
        EntidadMaquinaria1 = EntidadMaquinaria
        EntidadMaquinaria1.TablaConsulta = New DataTable
        'Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadMaquinaria1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqldat1 = New SqlDataAdapter("sp_ConsultaDetalleMaquinaria", cnn)
                    sqldat1.Fill(EntidadMaquinaria1.TablaConsulta)
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
            EntidadMaquinaria = EntidadMaquinaria1
        End Try
    End Sub
End Class
