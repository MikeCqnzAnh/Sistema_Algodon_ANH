Imports System.Data.SqlClient
Public Class Plantas
    Public Overridable Sub Upsert(ByRef EntidadPlantas As Capa_Entidad.Plantas)
        Dim EntidadPlantas1 As New Capa_Entidad.Plantas
        EntidadPlantas1 = EntidadPlantas
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarPlanta", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdPlanta", EntidadPlantas1.IdPlanta))
            cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadPlantas1.Descripcion))
            cmdGuardar.Parameters.Add(New SqlParameter("@Registro", EntidadPlantas1.Registro))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadPlantas1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadPlantas1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadPlantas1.FechaCreacion))
            cmdGuardar.Parameters("@IdPlanta").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadPlantas1.IdPlanta = 0 Then
                EntidadPlantas1.IdPlanta = cmdGuardar.Parameters("@IdPlanta").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadPlantas = EntidadPlantas1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadPlanta As Capa_Entidad.Plantas)
        Dim EntidadPlanta1 = New Capa_Entidad.Plantas
        EntidadPlanta1 = EntidadPlanta
        EntidadPlanta1.TablaConsulta = New DataTable
        'Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadPlanta1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqldat1 = New SqlDataAdapter("sp_ConsultaDetallePlantas", cnn)
                    sqldat1.Fill(EntidadPlanta1.TablaConsulta)
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
            EntidadPlanta = EntidadPlanta1
        End Try
    End Sub
End Class
