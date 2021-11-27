Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.SqlClient
Public Class RegimenHidrico
    Public Overridable Sub Upsert(ByRef EntidadRegimenHidrico As Capa_Entidad.RegimenHidrico)
        Dim EntidadRegimenHidrico1 As New Capa_Entidad.RegimenHidrico
        EntidadRegimenHidrico1 = EntidadRegimenHidrico
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarRegimenHidrico", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdRegimen", EntidadRegimenHidrico.IdRegimen))
            cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadRegimenHidrico.Descripcion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadRegimenHidrico.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadRegimenHidrico.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadRegimenHidrico.FechaCreacion))
            cmdGuardar.Parameters("@IdRegimen").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadRegimenHidrico1.IdRegimen = 0 Then
                EntidadRegimenHidrico1.IdRegimen = cmdGuardar.Parameters("@IdRegimen").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadRegimenHidrico = EntidadRegimenHidrico1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadRegimenHidrico As Capa_Entidad.RegimenHidrico)
        Dim EntidadRegimenHidrico1 = New Capa_Entidad.RegimenHidrico
        EntidadRegimenHidrico1 = EntidadRegimenHidrico
        EntidadRegimenHidrico1.TablaConsulta = New DataTable
        'Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadRegimenHidrico1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqldat1 = New SqlDataAdapter("sp_ConsultaRegimenHidrico", cnn)
                    sqldat1.Fill(EntidadRegimenHidrico1.TablaConsulta)
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
            EntidadRegimenHidrico = EntidadRegimenHidrico1
        End Try
    End Sub
End Class
