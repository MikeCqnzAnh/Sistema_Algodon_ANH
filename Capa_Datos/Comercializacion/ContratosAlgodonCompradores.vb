Imports Capa_Entidad
Imports Capa_Operacion
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
            cmdGuardar.Parameters.Add(New SqlParameter("@PacasVendidas", EntidadContratosAlgodonCompradores1.PacasVendidas))
            cmdGuardar.Parameters.Add(New SqlParameter("@PacasDisponibles", EntidadContratosAlgodonCompradores1.PacasDisponibles))
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
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", Now))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioActualizacion", EntidadContratosAlgodonCompradores1.IdUsuarioActualizacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaActualizacion", Now))
            cmdGuardar.Parameters("@IdContratoAlgodon").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadContratosAlgodonCompradores1.IdContratoAlgodon = 0 Then
                EntidadContratosAlgodonCompradores1.IdContratoAlgodon = cmdGuardar.Parameters("@IdContratoAlgodon").Value
            End If
            cmdGuardar = New SqlCommand("Sp_InsertaParametrosContratoVenta", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdParametroContrato", EntidadContratosAlgodonCompradores1.IdParametroContrato))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdContratoVenta", EntidadContratosAlgodonCompradores1.IdContratoAlgodon))
            cmdGuardar.Parameters.Add(New SqlParameter("@CheckMicros", EntidadContratosAlgodonCompradores1.CheckMicros))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdModoMicros", EntidadContratosAlgodonCompradores1.IdModoMicros))
            cmdGuardar.Parameters.Add(New SqlParameter("@CheckLargo", EntidadContratosAlgodonCompradores1.CheckLargo))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdModoLargoFibra", EntidadContratosAlgodonCompradores1.IdModoLargoFibra))
            cmdGuardar.Parameters.Add(New SqlParameter("@CheckResistencia", EntidadContratosAlgodonCompradores1.CheckResistencia))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdModoResistencia", EntidadContratosAlgodonCompradores1.IdModoResistencia))
            cmdGuardar.Parameters.Add(New SqlParameter("@CheckUniformidad", EntidadContratosAlgodonCompradores1.CheckUniformidad))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdModoUniformidad", EntidadContratosAlgodonCompradores1.IdModoUniformidad))
            cmdGuardar.Parameters.Add(New SqlParameter("@CheckBark", EntidadContratosAlgodonCompradores1.CheckBark))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdModoBark", EntidadContratosAlgodonCompradores1.IdModoBark))
            cmdGuardar.Parameters.Add(New SqlParameter("@CheckBarkLevel1", EntidadContratosAlgodonCompradores1.CheckBarkLevel1))
            cmdGuardar.Parameters.Add(New SqlParameter("@CheckBarkLevel2", EntidadContratosAlgodonCompradores1.CheckBarkLevel2))
            cmdGuardar.Parameters.Add(New SqlParameter("@CheckPrep", EntidadContratosAlgodonCompradores1.CheckPrep))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdModoPrep", EntidadContratosAlgodonCompradores1.IdModoPrep))
            cmdGuardar.Parameters.Add(New SqlParameter("@CheckPrepLevel1", EntidadContratosAlgodonCompradores1.CheckPrepLevel1))
            cmdGuardar.Parameters.Add(New SqlParameter("@CheckPrepLevel2", EntidadContratosAlgodonCompradores1.CheckPrepLevel2))
            cmdGuardar.Parameters.Add(New SqlParameter("@CheckOther", EntidadContratosAlgodonCompradores1.CheckOther))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdModoOther", EntidadContratosAlgodonCompradores1.IdModoOther))
            cmdGuardar.Parameters.Add(New SqlParameter("@CheckOtherLevel1", EntidadContratosAlgodonCompradores1.CheckOtherLevel1))
            cmdGuardar.Parameters.Add(New SqlParameter("@CheckOtherLevel2", EntidadContratosAlgodonCompradores1.CheckOtherLevel2))
            cmdGuardar.Parameters.Add(New SqlParameter("@CheckPlastic", EntidadContratosAlgodonCompradores1.CheckPlastic))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdModoPlastic", EntidadContratosAlgodonCompradores1.IdModoPlastic))
            cmdGuardar.Parameters.Add(New SqlParameter("@CheckPlasticLevel1", EntidadContratosAlgodonCompradores1.CheckPlasticLevel1))
            cmdGuardar.Parameters.Add(New SqlParameter("@CheckPlasticLevel2", EntidadContratosAlgodonCompradores1.CheckPlasticLevel2))
            cmdGuardar.Parameters.Add(New SqlParameter("@EstatusPesoNeto", EntidadContratosAlgodonCompradores1.EstatusPesoNeto))
            cmdGuardar.Parameters.Add(New SqlParameter("@KilosNeto", EntidadContratosAlgodonCompradores1.KilosNeto))
            cmdGuardar.ExecuteNonQuery()
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
                Case Capa_Operacion.Configuracion.Consulta.ConsultaExterna
                    sqldat1 = New SqlDataAdapter("sp_ConsultaModosVenta", cnn)
                    sqldat1.Fill(EntidadContratosAlgodonCompradores1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDiferenciales
                    sqlcom1 = New SqlCommand("sp_ConsultaDiferencialesVenta", cnn)
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
                Case Capa_Operacion.Configuracion.Consulta.ConsultaUnidadPeso
                    sqldat1 = New SqlDataAdapter("Sp_ConsultaUnidadPesoVenta", cnn)
                    sqldat1.Fill(EntidadContratosAlgodonCompradores1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaMicrosVentaCmb
                    sqldat1 = New SqlDataAdapter("Sp_LlenaComboMicrosVenta", cnn)
                    sqldat1.Fill(EntidadContratosAlgodonCompradores1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaLargoFibraVentaCmb
                    sqldat1 = New SqlDataAdapter("Sp_LlenaComboLargoFibraVenta", cnn)
                    sqldat1.Fill(EntidadContratosAlgodonCompradores1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaResistenciaVentaCmb
                    sqldat1 = New SqlDataAdapter("Sp_LlenaComboResistenciaVenta", cnn)
                    sqldat1.Fill(EntidadContratosAlgodonCompradores1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaUniformidadVentaCmb
                    sqldat1 = New SqlDataAdapter("Sp_LlenaComboUniformidadVenta", cnn)
                    sqldat1.Fill(EntidadContratosAlgodonCompradores1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaCastigoMatExtVenta
                    sqldat1 = New SqlDataAdapter("Sp_LLenaCombosExMatVenta", cnn)
                    sqldat1.Fill(EntidadContratosAlgodonCompradores1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaParametrosContratoVenta
                    sqlcom1 = New SqlCommand("Sp_ConsultaParametrosContratoVenta", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdContratoVenta", EntidadContratosAlgodonCompradores1.IdContratoAlgodon))
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
