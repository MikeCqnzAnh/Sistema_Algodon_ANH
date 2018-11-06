Imports System.Data.SqlClient
Public Class Etiquetas
    Public Overridable Sub Consultar(ByRef EntidadEtiquetas As Capa_Entidad.Etiquetas)
        Dim EntidadEtiquetas1 As New Capa_Entidad.Etiquetas
        EntidadEtiquetas1 = EntidadEtiquetas
        EntidadEtiquetas1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadEtiquetas1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaExterna
                    sqldat1 = New SqlDataAdapter("sp_ConsultaPlantas", cnn)
                    sqldat1.Fill(EntidadEtiquetas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPorId
                    sqlcom1 = New SqlCommand("sp_ConsultaUltimaEtiquetaPorPlanta", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdPlantaOrigen", EntidadEtiquetas1.IdPlanta))
                    sqldat1.Fill(EntidadEtiquetas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaOrden
                    sqlcom1 = New SqlCommand("sp_ConsultaOrdenProduccion", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdProduccion", EntidadEtiquetas1.IdProduccion))
                    sqldat1.Fill(EntidadEtiquetas1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadEtiquetas = EntidadEtiquetas1
        End Try
    End Sub

    Public Overridable Sub Actualizar(ByRef EntidadEtiquetas As Capa_Entidad.Etiquetas)
        Dim EntidadEtiquetas1 As New Capa_Entidad.Etiquetas
        EntidadEtiquetas1 = EntidadEtiquetas
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_ActualizarEtiqueta", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdPlantaOrigen", EntidadEtiquetas1.IdPlanta))
            cmdGuardar.Parameters.Add(New SqlParameter("@EtiquetaActual", EntidadEtiquetas1.Etiqueta))
            cmdGuardar.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadEtiquetas = EntidadEtiquetas1
        End Try
    End Sub
End Class
