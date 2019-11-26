Imports System.Data.SqlClient
Public Class CompraPacasContrato
    Public Overridable Sub Upsert(ByRef EntidadCompraPacasContrato As Capa_Entidad.CompraPacasContrato)
        Dim EntidadCompraPacasContrato1 As New Capa_Entidad.CompraPacasContrato
        EntidadCompraPacasContrato1 = EntidadCompraPacasContrato
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            Select Case EntidadCompraPacasContrato1.Guarda
                Case Capa_Operacion.Configuracion.Guardar.GuardarCompraPacasEnc
                    cmdGuardar = New SqlCommand("Sp_InsertaCompraPacas", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdCompra", EntidadCompraPacasContrato1.IdCompra))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdProductor", EntidadCompraPacasContrato1.IdProductor))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdContratoAlgodon", EntidadCompraPacasContrato1.IdContrato))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdPlanta", EntidadCompraPacasContrato1.IdPlanta))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdModalidadCompra", EntidadCompraPacasContrato1.IdModalidadCompra))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Fecha", EntidadCompraPacasContrato1.FechaCompra))
                    cmdGuardar.Parameters.Add(New SqlParameter("@TotalPacas", EntidadCompraPacasContrato1.TotalPacas))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Observaciones", EntidadCompraPacasContrato1.Observaciones))
                    cmdGuardar.Parameters.Add(New SqlParameter("@CastigoMicros", EntidadCompraPacasContrato1.CastigoMicros))
                    cmdGuardar.Parameters.Add(New SqlParameter("@CastigoLargoFibra", EntidadCompraPacasContrato1.CastigoLargoFibra))
                    cmdGuardar.Parameters.Add(New SqlParameter("@CastigoResistenciaFibra", EntidadCompraPacasContrato1.CastigoResistenciaFibra))
                    cmdGuardar.Parameters.Add(New SqlParameter("@InteresPesosMx", EntidadCompraPacasContrato1.InteresPesosMx))
                    cmdGuardar.Parameters.Add(New SqlParameter("@InteresDlls", EntidadCompraPacasContrato1.InteresDlls))
                    cmdGuardar.Parameters.Add(New SqlParameter("@PrecioQuintal", EntidadCompraPacasContrato1.PrecioQuintal))
                    cmdGuardar.Parameters.Add(New SqlParameter("@PrecioQuintalBorregos", EntidadCompraPacasContrato1.PrecioQuintalBorregos))
                    cmdGuardar.Parameters.Add(New SqlParameter("@PrecioDolar", EntidadCompraPacasContrato1.PrecioDolar))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Subtotal", EntidadCompraPacasContrato1.Subtotal))
                    cmdGuardar.Parameters.Add(New SqlParameter("@CastigoDls", EntidadCompraPacasContrato1.CastigoDls))
                    cmdGuardar.Parameters.Add(New SqlParameter("@AnticipoDls", EntidadCompraPacasContrato1.AnticipoDls))
                    cmdGuardar.Parameters.Add(New SqlParameter("@TotalDlls", EntidadCompraPacasContrato1.TotalDlls))
                    cmdGuardar.Parameters.Add(New SqlParameter("@TotalPesosMx", EntidadCompraPacasContrato1.TotalPesosMx))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatusCompra", EntidadCompraPacasContrato1.IdEstatusCompra))
                    cmdGuardar.Parameters("@IdCompra").Direction = ParameterDirection.InputOutput
                    cmdGuardar.ExecuteNonQuery()
                    If EntidadCompraPacasContrato1.IdCompra = 0 Then
                        EntidadCompraPacasContrato1.IdCompra = cmdGuardar.Parameters("@IdCompra").Value
                    End If
                Case Capa_Operacion.Configuracion.Guardar.GuardarCompraPacasDet
                    For Each MiTableRow As DataRow In EntidadCompraPacasContrato1.TablaGeneral.Rows
                        cmdGuardar = New SqlCommand("sp_ActualizaEstatusCompraPaca", cnn)
                        cmdGuardar.CommandType = CommandType.StoredProcedure
                        cmdGuardar.Parameters.Clear()
                        cmdGuardar.Parameters.Add(New SqlParameter("@IdProductor", MiTableRow("IdProductor")))
                        cmdGuardar.Parameters.Add(New SqlParameter("@IdPlanta", MiTableRow("IdPlantaOrigen")))
                        cmdGuardar.Parameters.Add(New SqlParameter("@BaleID", MiTableRow("BaleID")))
                        cmdGuardar.Parameters.Add(New SqlParameter("@IdLiquidacion", MiTableRow("IdLiquidacion")))
                        cmdGuardar.Parameters.Add(New SqlParameter("@IdCompraEnc", MiTableRow("IdCompraEnc")))
                        cmdGuardar.Parameters.Add(New SqlParameter("@PrecioDls", MiTableRow("PrecioDls")))
                        cmdGuardar.Parameters.Add(New SqlParameter("@PrecioClase", MiTableRow("PrecioClase")))
                        cmdGuardar.Parameters.Add(New SqlParameter("@TipoCambio", MiTableRow("TipoCambio")))
                        cmdGuardar.Parameters.Add(New SqlParameter("@PrecioMxn", MiTableRow("PrecioMxn")))
                        cmdGuardar.Parameters.Add(New SqlParameter("@CastigoUniformidad", MiTableRow("CastigoUniformidad")))
                        cmdGuardar.Parameters.Add(New SqlParameter("@CastigoResistenciaFibra", MiTableRow("CastigoResistenciaFibra")))
                        cmdGuardar.Parameters.Add(New SqlParameter("@CastigoMicros", MiTableRow("CastigoMicros")))
                        cmdGuardar.Parameters.Add(New SqlParameter("@CastigoLargoFibra", MiTableRow("CastigoLargoFibra")))
                        cmdGuardar.Parameters.Add(New SqlParameter("@EstatusCompraUpdate", MiTableRow("EstatusCompraUpdate")))
                        cmdGuardar.Parameters.Add(New SqlParameter("@EstatusCompraBusqueda", MiTableRow("EstatusCompraBusqueda")))
                        cmdGuardar.ExecuteNonQuery()
                    Next
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCompraPacasContrato = EntidadCompraPacasContrato1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadCompraPacasContrato As Capa_Entidad.CompraPacasContrato)
        Dim EntidadCompraPacasContrato1 As New Capa_Entidad.CompraPacasContrato
        EntidadCompraPacasContrato1 = EntidadCompraPacasContrato
        EntidadCompraPacasContrato1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadCompraPacasContrato1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaProductores
                    sqlcom1 = New SqlCommand("Sp_ConsultaProductorContratoCompra", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqldat1.Fill(EntidadCompraPacasContrato1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPorId
                    sqlcom1 = New SqlCommand("sp_ConContProd", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdProductor", EntidadCompraPacasContrato1.IdProductor))
                    sqldat1.Fill(EntidadCompraPacasContrato1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaLiquidaciones
                    sqlcom1 = New SqlCommand("sp_ConLiqProd", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdProductor", EntidadCompraPacasContrato1.IdProductor))
                    sqldat1.Fill(EntidadCompraPacasContrato1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaLiquidacionesCompras
                    sqlcom1 = New SqlCommand("sp_ConLiqProdComprada", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdProductor", EntidadCompraPacasContrato1.IdProductor))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdCompra", EntidadCompraPacasContrato1.IdCompra))
                    sqldat1.Fill(EntidadCompraPacasContrato1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPaca
                    sqlcom1 = New SqlCommand("sp_ConPacProdDetCla", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdProductor", EntidadCompraPacasContrato1.IdProductor))
                    sqldat1.Fill(EntidadCompraPacasContrato1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPacaComprada
                    sqlcom1 = New SqlCommand("sp_ConPacaComprada", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdProductor", EntidadCompraPacasContrato1.IdProductor))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdCompraEnc", EntidadCompraPacasContrato1.IdCompra))
                    sqldat1.Fill(EntidadCompraPacasContrato1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPacasCantidadDisponible
                    sqlcom1 = New SqlCommand("sp_ConsultaDisponibilidadPacas", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdProductor", EntidadCompraPacasContrato1.IdProductor))
                    sqldat1.Fill(EntidadCompraPacasContrato1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPacaFiltro
                    sqlcom1 = New SqlCommand("sp_ConsultaPacasComprasFiltro", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdProductor", EntidadCompraPacasContrato1.IdProductor))
                    sqlcom1.Parameters.Add(New SqlParameter("@PacaIni", EntidadCompraPacasContrato1.InicioPaca))
                    sqlcom1.Parameters.Add(New SqlParameter("@PacaFin", EntidadCompraPacasContrato1.FinPaca))
                    sqlcom1.Parameters.Add(New SqlParameter("@Clase", EntidadCompraPacasContrato1.Clase))
                    sqldat1.Fill(EntidadCompraPacasContrato1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaCompra
                    sqlcom1 = New SqlCommand("Sp_ConsultaCompraPorProductor", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdProductor", EntidadCompraPacasContrato1.IdProductor))
                    sqldat1.Fill(EntidadCompraPacasContrato1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaCompraPorNombre
                    sqlcom1 = New SqlCommand("Sp_ConsultaCompra", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdCompra", EntidadCompraPacasContrato1.IdCompra))
                    sqlcom1.Parameters.Add(New SqlParameter("@Nombre", EntidadCompraPacasContrato1.NombreProductor))
                    sqldat1.Fill(EntidadCompraPacasContrato1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaCastigoLargoFibra
                    sqlcom1 = New SqlCommand("Sp_CastigoLargoFibra", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@LargoFibra", EntidadCompraPacasContrato1.CastigoLargoFibra))
                    sqldat1.Fill(EntidadCompraPacasContrato1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaCastigoMicros
                    sqlcom1 = New SqlCommand("Sp_CastigoMicros", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@Micros", EntidadCompraPacasContrato1.CastigoMicros))
                    sqldat1.Fill(EntidadCompraPacasContrato1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaCastigoResistenciaFibra
                    sqlcom1 = New SqlCommand("Sp_CastigoResistenciaFibra", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@ResistenciaFibra", EntidadCompraPacasContrato1.CastigoResistenciaFibra))
                    sqldat1.Fill(EntidadCompraPacasContrato1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaCastigoUniformidad
                    sqlcom1 = New SqlCommand("Sp_CastigoUnidormidadCompras", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@Uniformidad", EntidadCompraPacasContrato1.CastigoUniformidad))
                    sqldat1.Fill(EntidadCompraPacasContrato1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaIdCompraPaca
                    sqlcom1 = New SqlCommand("Sp_ConsultaCompraPacas", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdCompra", EntidadCompraPacasContrato1.IdCompra))
                    sqldat1.Fill(EntidadCompraPacasContrato1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaCastigoMatExtCompra
                    sqlcom1 = New SqlCommand("Sp_ConsultaCastigoMatExtCompra", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqldat1.Fill(EntidadCompraPacasContrato1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCompraPacasContrato = EntidadCompraPacasContrato1
        End Try
    End Sub
    Public Overridable Sub Actualizar(ByRef EntidadCompraPacasContrato As Capa_Entidad.CompraPacasContrato)
        Dim EntidadCompraPacasContrato1 As New Capa_Entidad.CompraPacasContrato
        EntidadCompraPacasContrato1 = EntidadCompraPacasContrato
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdActualizar As SqlCommand
        Try
            cnn.Open()
            Select Case EntidadCompraPacasContrato1.Actualiza
                Case Capa_Operacion.Configuracion.Actuliza.ActualizaEstatus
                    For Each MiTableRow As DataRow In EntidadCompraPacasContrato1.TablaGeneral.Rows
                        cmdActualizar = New SqlCommand("Sp_ActualizaEstatusPaca", cnn)
                        cmdActualizar.CommandType = CommandType.StoredProcedure
                        cmdActualizar.Parameters.Clear()
                        cmdActualizar.Parameters.Add(New SqlParameter("@BaleID", MiTableRow("BaleID")))
                        cmdActualizar.Parameters.Add(New SqlParameter("@IdCompraEnc", MiTableRow("IdCompraEnc")))
                        cmdActualizar.Parameters.Add(New SqlParameter("@EstatusVentaUpdate", MiTableRow("EstatusVenta")))
                        cmdActualizar.ExecuteNonQuery()
                    Next
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCompraPacasContrato = EntidadCompraPacasContrato1
        End Try

    End Sub

End Class
