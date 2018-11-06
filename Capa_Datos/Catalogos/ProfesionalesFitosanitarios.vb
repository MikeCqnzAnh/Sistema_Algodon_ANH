Imports System.Data.SqlClient
Public Class ProfesionalesFitosanitarios
    Public Overridable Sub Upsert(ByRef EntidadProfesionalesFitosanitarios As Capa_Entidad.ProfesionalesFitosanitarios)
        Dim EntidadProfesionalesFitosanitarios1 As New Capa_Entidad.ProfesionalesFitosanitarios
        EntidadProfesionalesFitosanitarios1 = EntidadProfesionalesFitosanitarios
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarProfesionalesFitosanitarios", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdProfesionales", EntidadProfesionalesFitosanitarios1.IdProfesionales))
            cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadProfesionalesFitosanitarios1.Descripcion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadProfesionalesFitosanitarios1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadProfesionalesFitosanitarios1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadProfesionalesFitosanitarios1.FechaCreacion))
            cmdGuardar.Parameters("@IdProfesionales").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadProfesionalesFitosanitarios1.IdProfesionales = 0 Then
                EntidadProfesionalesFitosanitarios1.IdProfesionales = cmdGuardar.Parameters("@IdProfesionales").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadProfesionalesFitosanitarios = EntidadProfesionalesFitosanitarios1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadProfesionalesFitosanitarios As Capa_Entidad.ProfesionalesFitosanitarios)
        Dim EntidadProfesionalesFitosanitarios1 = New Capa_Entidad.ProfesionalesFitosanitarios
        EntidadProfesionalesFitosanitarios1 = EntidadProfesionalesFitosanitarios
        EntidadProfesionalesFitosanitarios1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadProfesionalesFitosanitarios1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqldat1 = New SqlDataAdapter("sp_ConsultaProfesionalesFitosanitarios", cnn)
                    sqldat1.Fill(EntidadProfesionalesFitosanitarios1.TablaConsulta)
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
            EntidadProfesionalesFitosanitarios = EntidadProfesionalesFitosanitarios1
        End Try
    End Sub
End Class
