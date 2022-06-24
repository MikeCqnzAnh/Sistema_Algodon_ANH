Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.SqlClient
Public Class ConfiguracionParametrosContratos
    Public Overridable Sub Upsert(ByRef EntidadConfiguracionParametrosContratos As Capa_Entidad.ConfiguracionParametrosContratos)
        Dim EntidadConfiguracionParametrosContratos1 As New Capa_Entidad.ConfiguracionParametrosContratos
        EntidadConfiguracionParametrosContratos1 = EntidadConfiguracionParametrosContratos
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("Pa_Insertarparamcontcompra", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdConfiguracion", EntidadConfiguracionParametrosContratos1.IdConfiguracion))
            cmdGuardar.Parameters.Add(New SqlParameter("@ParamDia1", EntidadConfiguracionParametrosContratos1.Paramdia1))
            cmdGuardar.Parameters.Add(New SqlParameter("@ParamMes1", EntidadConfiguracionParametrosContratos1.parammes1))
            cmdGuardar.Parameters.Add(New SqlParameter("@ParamTemp1", EntidadConfiguracionParametrosContratos1.ParamTemp1))
            cmdGuardar.Parameters.Add(New SqlParameter("@ParamMes2", EntidadConfiguracionParametrosContratos1.ParamMes2))
            cmdGuardar.Parameters.Add(New SqlParameter("@ParamTemp2", EntidadConfiguracionParametrosContratos1.ParamTemp2))
            cmdGuardar.Parameters.Add(New SqlParameter("@ParamMes3", EntidadConfiguracionParametrosContratos1.ParamMes3))
            cmdGuardar.Parameters.Add(New SqlParameter("@ParamPrompesomin", EntidadConfiguracionParametrosContratos1.paramprompesomin))
            cmdGuardar.Parameters.Add(New SqlParameter("@ParamPrompesomax", EntidadConfiguracionParametrosContratos1.paramprompesomax))
            cmdGuardar.Parameters.Add(New SqlParameter("@ParamPesomin", EntidadConfiguracionParametrosContratos1.parampesomin))
            cmdGuardar.Parameters.Add(New SqlParameter("@TemporadaAnual", EntidadConfiguracionParametrosContratos1.temporadaanual))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadConfiguracionParametrosContratos1.FechaCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaActualizacion", EntidadConfiguracionParametrosContratos1.FechaActualizacion))

            cmdGuardar.Parameters("@IdConfiguracion").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadConfiguracionParametrosContratos1.IdConfiguracion = 0 Then
                EntidadConfiguracionParametrosContratos1.IdConfiguracion = cmdGuardar.Parameters("@IdConfiguracion").Value
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            EntidadConfiguracionParametrosContratos = EntidadConfiguracionParametrosContratos1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadConfiguracionParametrosContratos As Capa_Entidad.ConfiguracionParametrosContratos)
        Dim EntidadConfiguracionParametrosContratos1 As New Capa_Entidad.ConfiguracionParametrosContratos()
        EntidadConfiguracionParametrosContratos1 = EntidadConfiguracionParametrosContratos
        Dim cnn As New SqlConnection(conexionPrincipal)
        EntidadConfiguracionParametrosContratos1.TablaConsulta = New DataTable()
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadConfiguracionParametrosContratos1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    sqlcom1 = New SqlCommand("Pa_Consultaparamcontcompra", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    'sqlcom1.Parameters.Add(New SqlParameter("@IdConfiguracion", EntidadConfiguracionParametrosContratos1.IdConfiguracion))
                    sqldat1.Fill(EntidadConfiguracionParametrosContratos1.TablaConsulta)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            EntidadConfiguracionParametrosContratos = EntidadConfiguracionParametrosContratos1
        End Try
    End Sub
End Class
