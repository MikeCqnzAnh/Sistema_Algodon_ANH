Imports System.Data.SqlClient
Public Class ConsultaCastigos
    Public Overridable Sub Consultar(ByRef EntidadConsultaCastigos As Capa_Entidad.ConsultaCastigos)
        Dim EntidadConsultaCastigos1 As New Capa_Entidad.ConsultaCastigos
        EntidadConsultaCastigos1 = EntidadConsultaCastigos
        EntidadConsultaCastigos1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadConsultaCastigos1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaResistenciaFibra
                    sqldat1 = New SqlDataAdapter("sp_ConCasResFib", cnn)
                    sqldat1.Fill(EntidadConsultaCastigos1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaLargoFibra
                    sqldat1 = New SqlDataAdapter("sp_ConCasLarFib", cnn)
                    sqldat1.Fill(EntidadConsultaCastigos1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaMicros
                    sqldat1 = New SqlDataAdapter("sp_ConCasMicros", cnn)
                    sqldat1.Fill(EntidadConsultaCastigos1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaUniformidad
                    sqldat1 = New SqlDataAdapter("sp_ConCasMicros", cnn)
                    sqldat1.Fill(EntidadConsultaCastigos1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaModalidadCompra
                    sqlcom1 = New SqlCommand("sp_ConModComId", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdModalidadCompra", EntidadConsultaCastigos1.IdModalidadCompra))
                    sqldat1.Fill(EntidadConsultaCastigos1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadConsultaCastigos = EntidadConsultaCastigos1
        End Try
    End Sub
End Class
