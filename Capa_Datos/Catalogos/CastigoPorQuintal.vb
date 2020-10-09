Imports System.Data.SqlClient
Public Class CastigoPorQuintal
    Public Overridable Sub Upsert(ByRef EntidadCastigoPorQuintal As Capa_Entidad.CastigoPorQuintal)
        Dim EntidadCastigoPorQuintal1 As New Capa_Entidad.CastigoPorQuintal
        EntidadCastigoPorQuintal1 = EntidadCastigoPorQuintal
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarCastigoPorQuintal", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdMicro", EntidadCastigoPorQuintal.IdMicro))
            cmdGuardar.Parameters.Add(New SqlParameter("@Rango1", EntidadCastigoPorQuintal.Rango1))
            cmdGuardar.Parameters.Add(New SqlParameter("@Rango2", EntidadCastigoPorQuintal.Rango2))
            cmdGuardar.Parameters.Add(New SqlParameter("@Castigo", EntidadCastigoPorQuintal.Castigo))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadCastigoPorQuintal.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadCastigoPorQuintal.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadCastigoPorQuintal.FechaCreacion))
            cmdGuardar.Parameters("@IdMicro").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadCastigoPorQuintal1.IdMicro = 0 Then
                EntidadCastigoPorQuintal1.IdMicro = cmdGuardar.Parameters("@IdMicro").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCastigoPorQuintal = EntidadCastigoPorQuintal1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadCastigoPorQuintal As Capa_Entidad.CastigoPorQuintal)
        Dim EntidadCastigoPorQuintal1 = New Capa_Entidad.CastigoPorQuintal
        EntidadCastigoPorQuintal1 = EntidadCastigoPorQuintal
        EntidadCastigoPorQuintal1.TablaConsulta = New DataTable
        'Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadCastigoPorQuintal1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqldat1 = New SqlDataAdapter("sp_ConsultaCastigoPorQuintal", cnn)
                    sqldat1.Fill(EntidadCastigoPorQuintal1.TablaConsulta)
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
            EntidadCastigoPorQuintal = EntidadCastigoPorQuintal1
        End Try
    End Sub
End Class
