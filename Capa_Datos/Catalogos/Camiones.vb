Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.SqlClient
Public Class Camiones
    Public Overridable Sub Upsert(ByRef EntidadCamiones As Capa_Entidad.Camiones)
        Dim EntidadCamiones1 As New Capa_Entidad.Camiones
        EntidadCamiones1 = EntidadCamiones
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarCamion", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdCamion", EntidadCamiones1.IdCamion))
            cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadCamiones1.Descripcion))
            cmdGuardar.Parameters.Add(New SqlParameter("@Placas", EntidadCamiones1.Placas))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadCamiones1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadCamiones1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadCamiones1.FechaCreacion))
            cmdGuardar.Parameters("@IdCamion").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadCamiones1.IdCamion = 0 Then
                EntidadCamiones1.IdCamion = cmdGuardar.Parameters("@IdCamion").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCamiones = EntidadCamiones1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadCamiones As Capa_Entidad.Camiones)
        Dim EntidadCamiones1 = New Capa_Entidad.Camiones
        EntidadCamiones1 = EntidadCamiones
        EntidadCamiones1.TablaConsulta = New DataTable
        'Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadCamiones1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqldat1 = New SqlDataAdapter("sp_ConsultaDetalleCamiones", cnn)
                    sqldat1.Fill(EntidadCamiones1.TablaConsulta)
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
            EntidadCamiones = EntidadCamiones1
        End Try
    End Sub
End Class
