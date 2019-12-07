Imports System.Data.SqlClient
Public Class ContratosAlgodonCompradores
    Public Overridable Sub Upsert(ByRef EntidadContratosAlgodonCompradores As Capa_Entidad.ContratosAlgodonCompradores)
        Dim EntidadContratosAlgodonCompradores1 As New Capa_Entidad.ContratosAlgodonCompradores
        EntidadContratosAlgodonCompradores1 = EntidadContratosAlgodonCompradores
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarContratoVenta", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdContratoAlgodon", EntidadContratosAlgodonCompradores1.IdContratoAlgodon))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdComprador", EntidadContratosAlgodonCompradores1.IdComprador))
            cmdGuardar.Parameters.Add(New SqlParameter("@Pacas", EntidadContratosAlgodonCompradores1.Pacas))
            cmdGuardar.Parameters.Add(New SqlParameter("@PacasCompradas", 0))
            cmdGuardar.Parameters.Add(New SqlParameter("@PacasDisponibles", EntidadContratosAlgodonCompradores1.Pacas))
            cmdGuardar.Parameters.Add(New SqlParameter("@PrecioQuintal", EntidadContratosAlgodonCompradores1.PrecioQuintal))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUnidadPeso", EntidadContratosAlgodonCompradores1.IdUnidadPeso))
            cmdGuardar.Parameters.Add(New SqlParameter("@ValorConversion", EntidadContratosAlgodonCompradores1.ValorConversion))
            cmdGuardar.Parameters.Add(New SqlParameter("@Puntos", EntidadContratosAlgodonCompradores1.Puntos))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaLiquidacion", EntidadContratosAlgodonCompradores1.FechaLiquidacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@Presidente", EntidadContratosAlgodonCompradores1.Presidente))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdModalidadVenta", EntidadContratosAlgodonCompradores1.IdModalidadVenta))
            cmdGuardar.Parameters.Add(New SqlParameter("@Temporada", EntidadContratosAlgodonCompradores1.Temporada))
            cmdGuardar.Parameters.Add(New SqlParameter("@PrecioSM", EntidadContratosAlgodonCompradores1.PrecioSM))
            cmdGuardar.Parameters.Add(New SqlParameter("@PrecioMP", EntidadContratosAlgodonCompradores1.PrecioMP))
            cmdGuardar.Parameters.Add(New SqlParameter("@PrecioM", EntidadContratosAlgodonCompradores1.PrecioM))
            cmdGuardar.Parameters.Add(New SqlParameter("@PrecioSLMP", EntidadContratosAlgodonCompradores1.PrecioSLMP))
            cmdGuardar.Parameters.Add(New SqlParameter("@PrecioSLM", EntidadContratosAlgodonCompradores1.PrecioSLM))
            cmdGuardar.Parameters.Add(New SqlParameter("@PrecioLMP", EntidadContratosAlgodonCompradores1.PrecioLMP))
            cmdGuardar.Parameters.Add(New SqlParameter("@PrecioLM", EntidadContratosAlgodonCompradores1.PrecioLM))
            cmdGuardar.Parameters.Add(New SqlParameter("@PrecioSGO", EntidadContratosAlgodonCompradores1.PrecioSGO))
            cmdGuardar.Parameters.Add(New SqlParameter("@PrecioGO", EntidadContratosAlgodonCompradores1.PrecioGO))
            cmdGuardar.Parameters.Add(New SqlParameter("@PrecioO", EntidadContratosAlgodonCompradores1.PrecioO))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadContratosAlgodonCompradores1.IdEstatus))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadContratosAlgodonCompradores1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadContratosAlgodonCompradores1.FechaCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioActualizacion", EntidadContratosAlgodonCompradores1.IdUsuarioActualizacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaActualizacion", EntidadContratosAlgodonCompradores1.FechaActualizacion))
            cmdGuardar.Parameters("@IdContratoAlgodon").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadContratosAlgodonCompradores1.IdContratoAlgodon = 0 Then
                EntidadContratosAlgodonCompradores1.IdContratoAlgodon = cmdGuardar.Parameters("@IdContratoAlgodon").Value
                'For Each MiTableRow As DataRow In EntidadContratosAlgodonCompradores1.TablaConsulta.Rows
                '    cmdGuardar.CommandText = "sp_InsertarContratoVentaDet"
                '    cmdGuardar.CommandType = CommandType.StoredProcedure
                '    cmdGuardar.Parameters.Clear()
                '    cmdGuardar.Parameters.Add(New SqlParameter("@IdContratoAlgodonDetalle", 0))
                '    cmdGuardar.Parameters.Add(New SqlParameter("@IdContratoAlgodon", EntidadContratosAlgodonCompradores1.IdContratoAlgodon))
                '    cmdGuardar.Parameters.Add(New SqlParameter("@IdLote", MiTableRow("IdTierra")))
                '    cmdGuardar.Parameters.Add(New SqlParameter("@SuperficieContratada", MiTableRow("SuperficieContratada")))
                '    cmdGuardar.ExecuteNonQuery()
                'Next
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadContratosAlgodonCompradores = EntidadContratosAlgodonCompradores1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadContratosAlgodonCompradores As Capa_Entidad.ContratosAlgodonCompradores)
        Dim EntidadContratosAlgodonCompradores1 As New Capa_Entidad.ContratosAlgodonCompradores
        EntidadContratosAlgodonCompradores1 = EntidadContratosAlgodonCompradores
        EntidadContratosAlgodonCompradores1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadContratosAlgodonCompradores1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    sqldat1 = New SqlDataAdapter("sp_ConsultaContratosVentaBasico", cnn)
                    sqldat1.Fill(EntidadContratosAlgodonCompradores1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaCompradores
                    sqlcom1 = New SqlCommand("sp_ConsultaCompradores", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@Nombre", EntidadContratosAlgodonCompradores1.DescripcionConsulta))
                    sqldat1.Fill(EntidadContratosAlgodonCompradores1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDiferenciales
                    sqlcom1 = New SqlCommand("sp_ConsultaDiferenciales", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdModo", EntidadContratosAlgodonCompradores1.IdExterno))
                    sqldat1.Fill(EntidadContratosAlgodonCompradores1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqlcom1 = New SqlCommand("sp_ConsultaContratosVentaDetalle", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdContratoAlgodon", EntidadContratosAlgodonCompradores1.IdContratoAlgodon))
                    sqldat1.Fill(EntidadContratosAlgodonCompradores1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaExterna
                    sqldat1 = New SqlDataAdapter("sp_ConsultaModosVenta", cnn)
                    sqldat1.Fill(EntidadContratosAlgodonCompradores1.TablaConsulta)
            End Select
        Catch ex As Exception
            MsgBox(ex)
            cnn.Close()
        Finally
            cnn.Close()
            EntidadContratosAlgodonCompradores = EntidadContratosAlgodonCompradores1
        End Try
    End Sub
End Class
