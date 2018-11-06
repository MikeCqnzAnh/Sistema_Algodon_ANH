Imports System.Data.SqlClient
Public Class VariedadesAlgodon
    Public Overridable Sub Upsert(ByRef EntidadVariedadesAlgodon As Capa_Entidad.VariedadesAlgodon)
        Dim EntidadVariedadesAlgodon1 As New Capa_Entidad.VariedadesAlgodon
        EntidadVariedadesAlgodon1 = EntidadVariedadesAlgodon
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarVariedadesAlgodon", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdVariedadAlgodon", EntidadVariedadesAlgodon1.IdVariedadAlgodon))
            cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadVariedadesAlgodon1.Descripcion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadVariedadesAlgodon1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadVariedadesAlgodon1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadVariedadesAlgodon1.FechaCreacion))
            cmdGuardar.Parameters("@IdVariedadAlgodon").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadVariedadesAlgodon1.IdVariedadAlgodon = 0 Then
                EntidadVariedadesAlgodon1.IdVariedadAlgodon = cmdGuardar.Parameters("@IdVariedadAlgodon").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadVariedadesAlgodon = EntidadVariedadesAlgodon1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadVariedadesAlgodon As Capa_Entidad.VariedadesAlgodon)
        Dim EntidadVariedadesAlgodon1 = New Capa_Entidad.VariedadesAlgodon
        EntidadVariedadesAlgodon1 = EntidadVariedadesAlgodon
        EntidadVariedadesAlgodon1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadVariedadesAlgodon1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqldat1 = New SqlDataAdapter("sp_ConsultaVariedadesAlgodon", cnn)
                    sqldat1.Fill(EntidadVariedadesAlgodon1.TablaConsulta)
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
            EntidadVariedadesAlgodon = EntidadVariedadesAlgodon1
        End Try
    End Sub
End Class
