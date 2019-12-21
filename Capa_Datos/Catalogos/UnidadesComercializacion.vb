Imports System.Data.SqlClient
Public Class UnidadesComercializacion
    Public Overridable Sub Upsert(ByRef EntidadUnidadesComercializacion As Capa_Entidad.UnidadesComercializacion)
        Dim EntidadUnidadesComercializacion1 As New Capa_Entidad.UnidadesComercializacion
        EntidadUnidadesComercializacion1 = EntidadUnidadesComercializacion
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarUnidadComercializacion", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUnidadPeso", EntidadUnidadesComercializacion1.IdUnidadPeso))
            cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadUnidadesComercializacion1.Descripcion))
            cmdGuardar.Parameters.Add(New SqlParameter("@ValorConversion", EntidadUnidadesComercializacion1.ValorConversion))
            cmdGuardar.Parameters("@IdUnidadPeso").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadUnidadesComercializacion1.IdUnidadPeso = 0 Then
                EntidadUnidadesComercializacion1.IdUnidadPeso = cmdGuardar.Parameters("@IdUnidadPeso").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadUnidadesComercializacion = EntidadUnidadesComercializacion1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadUnidadesComercializacion As Capa_Entidad.UnidadesComercializacion)
        Dim EntidadUnidadesComercializacion1 = New Capa_Entidad.UnidadesComercializacion
        EntidadUnidadesComercializacion1 = EntidadUnidadesComercializacion
        EntidadUnidadesComercializacion1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadUnidadesComercializacion1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    sqldat1 = New SqlDataAdapter("Sp_ConsultaUnidadesComercializacion", cnn)
                    sqldat1.Fill(EntidadUnidadesComercializacion1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadUnidadesComercializacion = EntidadUnidadesComercializacion1
        End Try
    End Sub
End Class
