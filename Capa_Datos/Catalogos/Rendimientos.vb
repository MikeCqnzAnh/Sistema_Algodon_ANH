Imports System.Data.SqlClient
Public Class Rendimientos
    Public Overridable Sub Upsert(ByRef EntidadRendimientos As Capa_Entidad.Rendimientos)
        Dim EntidadRendimientos1 As New Capa_Entidad.Rendimientos
        EntidadRendimientos1 = EntidadRendimientos
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarRendimientos", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdRendimiento", EntidadRendimientos.IdRendimiento))
            cmdGuardar.Parameters.Add(New SqlParameter("@Pluma", EntidadRendimientos.Pluma))
            cmdGuardar.Parameters.Add(New SqlParameter("@Semilla", EntidadRendimientos.Semilla))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadRendimientos.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadRendimientos.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadRendimientos.FechaCreacion))
            cmdGuardar.Parameters("@IdRendimiento").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadRendimientos1.IdRendimiento = 0 Then
                EntidadRendimientos1.IdRendimiento = cmdGuardar.Parameters("@IdRendimiento").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadRendimientos = EntidadRendimientos1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadRendimientos As Capa_Entidad.Rendimientos)
        Dim EntidadRendimientos1 = New Capa_Entidad.Rendimientos
        EntidadRendimientos1 = EntidadRendimientos
        EntidadRendimientos1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadRendimientos1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqldat1 = New SqlDataAdapter("sp_ConsultaRendimientos", cnn)
                    sqldat1.Fill(EntidadRendimientos1.TablaConsulta)
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
            EntidadRendimientos = EntidadRendimientos1
        End Try
    End Sub
End Class
