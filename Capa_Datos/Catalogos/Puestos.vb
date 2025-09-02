Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.SqlClient
Public Class Puestos
    Public Overridable Sub Upsert(ByRef EntidadPuestos As Capa_Entidad.Puestos)
        Dim EntidadPuestos1 As New Capa_Entidad.Puestos
        EntidadPuestos1 = EntidadPuestos
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarPuesto", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdPuesto", EntidadPuestos1.IdPuesto))
            cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadPuestos1.Descripcion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadPuestos1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadPuestos1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadPuestos1.FechaCreacion))
            cmdGuardar.Parameters("@IdPuesto").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadPuestos1.IdPuesto = 0 Then
                EntidadPuestos1.IdPuesto = cmdGuardar.Parameters("@IdPuesto").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadPuestos = EntidadPuestos1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadPuestos As Capa_Entidad.Puestos)
        Dim EntidadPuestos1 As New Capa_Entidad.Puestos
        EntidadPuestos1 = EntidadPuestos
        EntidadPuestos1.TablaConsulta = New DataTable
        'Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadPuestos1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqldat1 = New SqlDataAdapter("sp_ConsultaDetallePuestos", cnn)
                    sqldat1.Fill(EntidadPuestos1.TablaConsulta)
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
            EntidadPuestos = EntidadPuestos1
        End Try
    End Sub
End Class
