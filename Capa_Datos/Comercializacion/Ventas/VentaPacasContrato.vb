Imports System.Data.SqlClient
Public Class VentaPacasContrato
    Public Overridable Sub Upsert(ByRef EntidadVentaPacasContrato As Capa_Entidad.VentaPacasContrato)
        Dim EntidadVentaPacasContrato1 As New Capa_Entidad.VentaPacasContrato
        EntidadVentaPacasContrato1 = EntidadVentaPacasContrato
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            Select Case EntidadVentaPacasContrato1.Guarda
                Case Capa_Operacion.Configuracion.Guardar.GuardarVentaPacasEnc
                    cmdGuardar = New SqlCommand("Sp_InsertaVentaPacas", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdVenta", EntidadVentaPacasContrato1.IdVenta))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdComprador", EntidadVentaPacasContrato1.IdComprador))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdContratoAlgodon", EntidadVentaPacasContrato1.IdContrato))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdPlanta", EntidadVentaPacasContrato1.IdPlanta))
                    'cmdGuardar.Parameters.Add(New SqlParameter("@IdModalidadVenta", EntidadVentaPacasContrato1.IdModalidadVenta))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Fecha", EntidadVentaPacasContrato1.FechaVenta))
                    cmdGuardar.Parameters.Add(New SqlParameter("@TotalPacas", EntidadVentaPacasContrato1.TotalPacas))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Observaciones", EntidadVentaPacasContrato1.Observaciones))
                    cmdGuardar.Parameters.Add(New SqlParameter("@CastigoMicros", EntidadVentaPacasContrato1.CastigoMicros))
                    cmdGuardar.Parameters.Add(New SqlParameter("@CastigoLargoFibra", EntidadVentaPacasContrato1.CastigoLargoFibra))
                    cmdGuardar.Parameters.Add(New SqlParameter("@CastigoResistenciaFibra", EntidadVentaPacasContrato1.CastigoResistenciaFibra))
                    cmdGuardar.Parameters.Add(New SqlParameter("@InteresPesosMx", EntidadVentaPacasContrato1.InteresPesosMx))
                    cmdGuardar.Parameters.Add(New SqlParameter("@InteresDlls", EntidadVentaPacasContrato1.InteresDlls))
                    cmdGuardar.Parameters.Add(New SqlParameter("@PrecioQuintal", EntidadVentaPacasContrato1.PrecioQuintal))
                    cmdGuardar.Parameters.Add(New SqlParameter("@PrecioQuintalBorregos", EntidadVentaPacasContrato1.PrecioQuintalBorregos))
                    cmdGuardar.Parameters.Add(New SqlParameter("@PrecioDolar", EntidadVentaPacasContrato1.PrecioDolar))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Subtotal", EntidadVentaPacasContrato1.SubTotal))
                    cmdGuardar.Parameters.Add(New SqlParameter("@CastigoDls", EntidadVentaPacasContrato1.CastigoDls))
                    cmdGuardar.Parameters.Add(New SqlParameter("@AnticipoDls", EntidadVentaPacasContrato1.AnticipoDls))
                    cmdGuardar.Parameters.Add(New SqlParameter("@TotalDlls", EntidadVentaPacasContrato1.TotalDlls))
                    cmdGuardar.Parameters.Add(New SqlParameter("@TotalPesosMx", EntidadVentaPacasContrato1.TotalPesosMx))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatusVenta", EntidadVentaPacasContrato1.IdEstatusVenta))
                    cmdGuardar.Parameters("@IdVenta").Direction = ParameterDirection.InputOutput
                    cmdGuardar.ExecuteNonQuery()
                    If EntidadVentaPacasContrato1.IdVenta = 0 Then
                        EntidadVentaPacasContrato1.IdVenta = cmdGuardar.Parameters("@IdVenta").Value
                    End If
                Case Capa_Operacion.Configuracion.Guardar.GuardarVentaPacasDet
                    For Each MiTableRow As DataRow In EntidadVentaPacasContrato1.TablaGeneral.Rows
                        cmdGuardar = New SqlCommand("sp_ActualizaEstatusVentaPaca", cnn)
                        cmdGuardar.CommandType = CommandType.StoredProcedure
                        cmdGuardar.Parameters.Clear()
                        cmdGuardar.Parameters.Add(New SqlParameter("@IdComprador", MiTableRow("IdComprador")))
                        cmdGuardar.Parameters.Add(New SqlParameter("@BaleID", MiTableRow("BaleID")))
                        cmdGuardar.Parameters.Add(New SqlParameter("@IdLiquidacion", MiTableRow("IdLiquidacion")))
                        cmdGuardar.Parameters.Add(New SqlParameter("@IdVentaEnc", MiTableRow("IdVentaEnc")))

                        cmdGuardar.Parameters.Add(New SqlParameter("@CastigoResistenciaFibra", MiTableRow("CastigoResistenciaFibra")))
                        cmdGuardar.Parameters.Add(New SqlParameter("@CastigoMicros", MiTableRow("CastigoMicros")))
                        cmdGuardar.Parameters.Add(New SqlParameter("@CastigoLargoFibra", MiTableRow("CastigoLargoFibra")))

                        cmdGuardar.Parameters.Add(New SqlParameter("@EstatusVentaUpdate", MiTableRow("EstatusVentaUpdate")))
                        cmdGuardar.Parameters.Add(New SqlParameter("@EstatusVentaBusqueda", MiTableRow("EstatusVentaBusqueda")))
                        cmdGuardar.Parameters.Add(New SqlParameter("@KgAd", MiTableRow("KgAd")))
                        cmdGuardar.ExecuteNonQuery()
                    Next
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadVentaPacasContrato = EntidadVentaPacasContrato1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadVentaPacasContrato As Capa_Entidad.VentaPacasContrato)
        Dim EntidadVentaPacasContrato1 As New Capa_Entidad.VentaPacasContrato
        EntidadVentaPacasContrato1 = EntidadVentaPacasContrato
        EntidadVentaPacasContrato1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadVentaPacasContrato1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPorId
                    sqlcom1 = New SqlCommand("sp_ConContComp", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdComprador", EntidadVentaPacasContrato1.IdComprador))
                    sqldat1.Fill(EntidadVentaPacasContrato1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaLiquidaciones
                    sqlcom1 = New SqlCommand("sp_ConsultaLiquidacionVenta", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    'sqlcom1.Parameters.Add(New SqlParameter("@IdComprador", EntidadVentaPacasContrato1.IdComprador))
                    sqldat1.Fill(EntidadVentaPacasContrato1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPaca
                    sqlcom1 = New SqlCommand("sp_ConPacVentDet", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    'sqlcom1.Parameters.Add(New SqlParameter("@IdComprador", EntidadVentaPacasContrato1.IdComprador))
                    sqldat1.Fill(EntidadVentaPacasContrato1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPacaFiltro
                    sqlcom1 = New SqlCommand("sp_ConsultaPacasVentasFiltro", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@PacaIni", EntidadVentaPacasContrato1.InicioPaca))
                    sqlcom1.Parameters.Add(New SqlParameter("@PacaFin", EntidadVentaPacasContrato1.FinPaca))
                    sqlcom1.Parameters.Add(New SqlParameter("@Clase", EntidadVentaPacasContrato1.Clase))
                    sqldat1.Fill(EntidadVentaPacasContrato1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPacaVendida
                    sqlcom1 = New SqlCommand("sp_ConPacaVendida", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdVentaEnc", EntidadVentaPacasContrato1.IdVenta))
                    sqldat1.Fill(EntidadVentaPacasContrato1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPacasCantidadDisponible
                    sqlcom1 = New SqlCommand("sp_ConsultaDisponibilidadPacasVentas", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqldat1.Fill(EntidadVentaPacasContrato1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaLiquidacionesVentas
                    sqlcom1 = New SqlCommand("sp_ConLiqProdVendida", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdVenta", EntidadVentaPacasContrato1.IdVenta))
                    sqldat1.Fill(EntidadVentaPacasContrato1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaVentaPorNombre
                    sqlcom1 = New SqlCommand("Sp_ConsultaVenta", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdVenta", EntidadVentaPacasContrato1.IdVenta))
                    sqlcom1.Parameters.Add(New SqlParameter("@Nombre", EntidadVentaPacasContrato1.NombreComprador))
                    sqldat1.Fill(EntidadVentaPacasContrato1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadVentaPacasContrato = EntidadVentaPacasContrato1
        End Try
    End Sub
End Class
