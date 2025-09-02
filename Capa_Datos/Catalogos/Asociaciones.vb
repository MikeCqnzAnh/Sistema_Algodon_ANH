Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.SqlClient
Public Class Asociaciones
    Public Overridable Sub Upsert(ByRef EntidadAsociaciones As Capa_Entidad.Asociaciones)
        Dim EntidadAsociaciones1 As New Capa_Entidad.Asociaciones
        EntidadAsociaciones1 = EntidadAsociaciones
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarAsociacion", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdAsociacion", EntidadAsociaciones1.IdAsociacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadAsociaciones1.Descripcion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadAsociaciones1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadAsociaciones1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadAsociaciones1.FechaCreacion))
            cmdGuardar.Parameters("@IdAsociacion").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadAsociaciones1.IdAsociacion = 0 Then
                EntidadAsociaciones1.IdAsociacion = cmdGuardar.Parameters("@IdAsociacion").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadAsociaciones = EntidadAsociaciones1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadAsociaciones As Capa_Entidad.Asociaciones)
        Dim EntidadAsociaciones1 = New Capa_Entidad.Asociaciones
        EntidadAsociaciones1 = EntidadAsociaciones
        EntidadAsociaciones1.TablaConsulta = New DataTable
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadAsociaciones1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    Dim sqldat1 As New SqlDataAdapter("sp_ConsultarAsociaciones", cnn)
                    sqldat1.Fill(EntidadAsociaciones1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadAsociaciones = EntidadAsociaciones1
        End Try
    End Sub
    Public Overridable Sub Eliminar(ByRef EntidadAsociaciones As Capa_Entidad.Asociaciones)
        Dim EntidadAsociaciones1 = New Capa_Entidad.Asociaciones
        EntidadAsociaciones1 = EntidadAsociaciones
        EntidadAsociaciones1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadAsociaciones1.Eliminar
                Case Capa_Operacion.Configuracion.Eliminar.EliminarRegistro
                    sqlcom1 = New SqlCommand("sp_EliminarAsociacion", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdAsociacion", EntidadAsociaciones1.IdAsociacion))
                    sqldat1.Fill(EntidadAsociaciones1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadAsociaciones = EntidadAsociaciones1
        End Try
    End Sub
End Class
