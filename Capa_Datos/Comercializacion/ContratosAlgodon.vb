Imports System.Data.SqlClient
Public Class ContratosAlgodon
    Public Overridable Sub Upsert(ByRef EntidadContratosAlgodon As Capa_Entidad.ContratosAlgodon)
        Dim EntidadContratosAlgodon1 As New Capa_Entidad.ContratosAlgodon
        EntidadContratosAlgodon1 = EntidadContratosAlgodon
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarContratoCompra", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdContratoAlgodon", EntidadContratosAlgodon1.IdContratoAlgodon))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdProductor", EntidadContratosAlgodon1.IdProductor))
            cmdGuardar.Parameters.Add(New SqlParameter("@Pacas", EntidadContratosAlgodon1.Pacas))
            cmdGuardar.Parameters.Add(New SqlParameter("@SuperficieComprometida", EntidadContratosAlgodon1.SuperficieComprometida))
            cmdGuardar.Parameters.Add(New SqlParameter("@PrecioQuintal", EntidadContratosAlgodon1.PrecioQuintal))
            cmdGuardar.Parameters.Add(New SqlParameter("@Puntos", EntidadContratosAlgodon1.Puntos))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaLiquidacion", EntidadContratosAlgodon1.FechaLiquidacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@Presidente", EntidadContratosAlgodon1.Presidente))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdModalidadCompra", EntidadContratosAlgodon1.IdModalidadCompra))
            cmdGuardar.Parameters.Add(New SqlParameter("@Temporada", EntidadContratosAlgodon1.Temporada))
            cmdGuardar.Parameters.Add(New SqlParameter("@PrecioSM", EntidadContratosAlgodon1.PrecioSM))
            cmdGuardar.Parameters.Add(New SqlParameter("@PrecioMP", EntidadContratosAlgodon1.PrecioMP))
            cmdGuardar.Parameters.Add(New SqlParameter("@PrecioM", EntidadContratosAlgodon1.PrecioM))
            cmdGuardar.Parameters.Add(New SqlParameter("@PrecioSLMP", EntidadContratosAlgodon1.PrecioSLMP))
            cmdGuardar.Parameters.Add(New SqlParameter("@PrecioSLM", EntidadContratosAlgodon1.PrecioSLM))
            cmdGuardar.Parameters.Add(New SqlParameter("@PrecioLMP", EntidadContratosAlgodon1.PrecioLMP))
            cmdGuardar.Parameters.Add(New SqlParameter("@PrecioLM", EntidadContratosAlgodon1.PrecioLM))
            cmdGuardar.Parameters.Add(New SqlParameter("@PrecioSGO", EntidadContratosAlgodon1.PrecioSGO))
            cmdGuardar.Parameters.Add(New SqlParameter("@PrecioGO", EntidadContratosAlgodon1.PrecioGO))
            cmdGuardar.Parameters.Add(New SqlParameter("@PrecioO", EntidadContratosAlgodon1.PrecioO))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadContratosAlgodon1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadContratosAlgodon1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadContratosAlgodon1.FechaCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioActualizacion", EntidadContratosAlgodon1.IdUsuarioActualizacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaActualizacion", EntidadContratosAlgodon1.FechaActualizacion))
            cmdGuardar.Parameters("@IdContratoAlgodon").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadContratosAlgodon1.IdContratoAlgodon = 0 Then
                EntidadContratosAlgodon1.IdContratoAlgodon = cmdGuardar.Parameters("@IdContratoAlgodon").Value
                For Each MiTableRow As DataRow In EntidadContratosAlgodon1.TablaConsulta.Rows
                    cmdGuardar.CommandText = "sp_InsertarContratoCompraDet"
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Clear()
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdContratoAlgodonDetalle", 0))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdContratoAlgodon", EntidadContratosAlgodon1.IdContratoAlgodon))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdLote", MiTableRow("IdTierra")))
                    cmdGuardar.Parameters.Add(New SqlParameter("@SuperficieContratada", MiTableRow("SuperficieContratada")))
                    cmdGuardar.ExecuteNonQuery()
                Next
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadContratosAlgodon = EntidadContratosAlgodon1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadContratosAlgodon As Capa_Entidad.ContratosAlgodon)
        Dim EntidadContratosAlgodon1 As New Capa_Entidad.ContratosAlgodon
        EntidadContratosAlgodon1 = EntidadContratosAlgodon
        EntidadContratosAlgodon1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadContratosAlgodon1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaTierras
                    sqldat1 = New SqlDataAdapter("sp_ConsultaLotes", cnn)
                    sqldat1.Fill(EntidadContratosAlgodon1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    sqldat1 = New SqlDataAdapter("sp_ConsultaContratosBasica", cnn)
                    sqldat1.Fill(EntidadContratosAlgodon1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaExterna
                    sqldat1 = New SqlDataAdapter("sp_ConsultaModosCompra", cnn)
                    sqldat1.Fill(EntidadContratosAlgodon1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaProductores
                    sqlcom1 = New SqlCommand("sp_ConsultaProductores", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@Nombre", EntidadContratosAlgodon1.DescripcionConsulta))
                    sqldat1.Fill(EntidadContratosAlgodon1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDiferenciales
                    sqlcom1 = New SqlCommand("sp_ConsultaDiferenciales", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdModo", EntidadContratosAlgodon1.IdExterno))
                    sqldat1.Fill(EntidadContratosAlgodon1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqlcom1 = New SqlCommand("sp_ConsultaContratosDetalle", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdContratoAlgodon", EntidadContratosAlgodon1.IdContratoAlgodon))
                    sqldat1.Fill(EntidadContratosAlgodon1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadContratosAlgodon = EntidadContratosAlgodon1
        End Try
    End Sub
End Class
