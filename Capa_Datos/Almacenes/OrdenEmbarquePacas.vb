Imports System.Data.SqlClient
Public Class OrdenEmbarquePacas
    Public Overridable Sub Upsert(ByRef EntidadOrdenEmbarquePacas As Capa_Entidad.OrdenEmbarquePacas)
        Dim EntidadOrdenEmbarquePacas1 As New Capa_Entidad.OrdenEmbarquePacas
        EntidadOrdenEmbarquePacas1 = EntidadOrdenEmbarquePacas
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            Select Case EntidadOrdenEmbarquePacas1.Guarda
                Case Capa_Operacion.Configuracion.Guardar.GuardarEmbarqueEncabezado
                    cmdGuardar = New SqlCommand("Sp_InsertarEmbarqueEncabezado", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdEmbarqueEncabezado", CInt(EntidadOrdenEmbarquePacas1.IdEmbarqueEncabezado)))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdComprador", EntidadOrdenEmbarquePacas1.IdComprador))
                    cmdGuardar.Parameters.Add(New SqlParameter("@NombreChofer", EntidadOrdenEmbarquePacas1.NombreChofer))
                    cmdGuardar.Parameters.Add(New SqlParameter("@PlacaTractoCamion", EntidadOrdenEmbarquePacas1.PlacaTractoCamion))
                    cmdGuardar.Parameters.Add(New SqlParameter("@NoLicencia", EntidadOrdenEmbarquePacas1.NoLicencia))
                    cmdGuardar.Parameters.Add(New SqlParameter("@NoLote1", EntidadOrdenEmbarquePacas1.NoLote1))
                    cmdGuardar.Parameters.Add(New SqlParameter("@NoLote2", EntidadOrdenEmbarquePacas1.NoLote2))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Telefono", EntidadOrdenEmbarquePacas1.Telefono))
                    cmdGuardar.Parameters.Add(New SqlParameter("@CantidadCajas", EntidadOrdenEmbarquePacas1.CantidadCajas))
                    cmdGuardar.Parameters.Add(New SqlParameter("@NoContenedorCaja1", EntidadOrdenEmbarquePacas1.NoContenedorCaja1))
                    cmdGuardar.Parameters.Add(New SqlParameter("@PlacaCaja1", EntidadOrdenEmbarquePacas1.PlacaCaja1))
                    cmdGuardar.Parameters.Add(New SqlParameter("@NoContenedorCaja2", EntidadOrdenEmbarquePacas1.NoContenedorCaja2))
                    cmdGuardar.Parameters.Add(New SqlParameter("@PlacaCaja2", EntidadOrdenEmbarquePacas1.PlacaCaja2))
                    cmdGuardar.Parameters.Add(New SqlParameter("@CantidadPacas", EntidadOrdenEmbarquePacas1.NoPacas))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Fecha", EntidadOrdenEmbarquePacas1.Fecha))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Observaciones", EntidadOrdenEmbarquePacas1.Observaciones))
                    cmdGuardar.Parameters("@IdEmbarqueEncabezado").Direction = ParameterDirection.InputOutput
                    cmdGuardar.ExecuteNonQuery()
                    If EntidadOrdenEmbarquePacas1.IdEmbarqueEncabezado = 0 Then
                        EntidadOrdenEmbarquePacas1.IdEmbarqueEncabezado = cmdGuardar.Parameters("@IdEmbarqueEncabezado").Value
                    End If
                Case Capa_Operacion.Configuracion.Guardar.GuardarEmbarqueDetalle
                    '    For Each MiTableRow As DataRow In EntidadVentaPacasContrato1.TablaGeneral.Rows
                    cmdGuardar = New SqlCommand("Sp_InsertaEmbarqueDetalle", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Clear()
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdEmbarqueDetalle", EntidadOrdenEmbarquePacas1.IdEmbarqueDetalle))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdEmbarqueEncabezado", EntidadOrdenEmbarquePacas1.IdEmbarqueEncabezado))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdComprador", EntidadOrdenEmbarquePacas1.IdComprador))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdVentaEnc", EntidadOrdenEmbarquePacas1.IdVentaEnc))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdPlanta", EntidadOrdenEmbarquePacas1.IdPlanta))
                    cmdGuardar.Parameters.Add(New SqlParameter("@BaleID", EntidadOrdenEmbarquePacas1.BaleID))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Kilos", EntidadOrdenEmbarquePacas1.Kilos))
                    cmdGuardar.Parameters.Add(New SqlParameter("@NoContenedor", EntidadOrdenEmbarquePacas1.NoContenedorInd))
                    cmdGuardar.Parameters.Add(New SqlParameter("@NoLote", EntidadOrdenEmbarquePacas1.NoLoteInd))
                    cmdGuardar.Parameters.Add(New SqlParameter("@PlacaCaja", EntidadOrdenEmbarquePacas1.PlacaCaja))
                    cmdGuardar.Parameters.Add(New SqlParameter("@EstatusEmbarque", EntidadOrdenEmbarquePacas1.EstatusEmbarque))
                    cmdGuardar.Parameters.Add(New SqlParameter("@EstatusSalida", EntidadOrdenEmbarquePacas1.EstatusSalida))
                    cmdGuardar.ExecuteNonQuery()
                    '    Next
            End Select
        Catch ex As Exception
            cnn.Close()
            MsgBox(ex)
        Finally
            cnn.Close()
            EntidadOrdenEmbarquePacas = EntidadOrdenEmbarquePacas1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadOrdenEmbarquePacas As Capa_Entidad.OrdenEmbarquePacas)
        Dim EntidadOrdenEmbarquePacas1 = New Capa_Entidad.OrdenEmbarquePacas
        EntidadOrdenEmbarquePacas1 = EntidadOrdenEmbarquePacas
        EntidadOrdenEmbarquePacas1.TablaConsulta = New DataTable
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadOrdenEmbarquePacas1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    sqlcom1 = New SqlCommand("Sp_ConsultaPaquetesDisponiblesEmbarques", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdComprador", EntidadOrdenEmbarquePacas1.IdComprador))
                    sqldat1.Fill(EntidadOrdenEmbarquePacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaAlmacen
                    sqlcom1 = New SqlCommand("Sp_ConsultaPacasDisponiblesEmbarques", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdComprador", EntidadOrdenEmbarquePacas1.IdComprador))
                    sqldat1.Fill(EntidadOrdenEmbarquePacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaEmbarqueEncabezado
                    sqlcom1 = New SqlCommand("Sp_ConsultaEmbarqueEncabezado", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdEmbarqueEncabezado", EntidadOrdenEmbarquePacas1.IdEmbarqueEncabezado))
                    sqlcom1.Parameters.Add(New SqlParameter("@NombreComprador", EntidadOrdenEmbarquePacas1.NombreComprador))
                    sqldat1.Fill(EntidadOrdenEmbarquePacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaEmbarqueParaSalida
                    sqlcom1 = New SqlCommand("Sp_ConsultaEmbarqueSalida", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdEmbarqueEncabezado", EntidadOrdenEmbarquePacas1.IdEmbarqueEncabezado))
                    sqlcom1.Parameters.Add(New SqlParameter("@NombreComprador", EntidadOrdenEmbarquePacas1.NombreComprador))
                    sqldat1.Fill(EntidadOrdenEmbarquePacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPacasEmbarcado
                    sqlcom1 = New SqlCommand("Sp_ConsultaEmbarqueDetallePacas", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdEmbarqueEncabezado", EntidadOrdenEmbarquePacas1.IdEmbarqueEncabezado))
                    sqldat1.Fill(EntidadOrdenEmbarquePacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPaqueteEmbarcado
                    sqlcom1 = New SqlCommand("Sp_ConsultaPaqueteEmbarcado", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdEmbarqueEncabezado", EntidadOrdenEmbarquePacas1.IdEmbarqueEncabezado))
                    sqldat1.Fill(EntidadOrdenEmbarquePacas1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadOrdenEmbarquePacas = EntidadOrdenEmbarquePacas1
        End Try
    End Sub
    Public Overridable Sub EliminarPacas(ByRef EntidadOrdenEmbarquePacas As Capa_Entidad.OrdenEmbarquePacas)
        Dim EntidadOrdenEmbarquePacas1 = New Capa_Entidad.OrdenEmbarquePacas
        EntidadOrdenEmbarquePacas1 = EntidadOrdenEmbarquePacas
        EntidadOrdenEmbarquePacas1.TablaConsulta = New DataTable
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadOrdenEmbarquePacas1.Eliminar
                Case Capa_Operacion.Configuracion.Eliminar.EliminaPacaSeleccionada
                    sqlcom1 = New SqlCommand("Sp_EliminaPacaEmbarque", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdEmbarqueDetalle", EntidadOrdenEmbarquePacas1.IdEmbarqueDetalle))
                    sqldat1.Fill(EntidadOrdenEmbarquePacas1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadOrdenEmbarquePacas = EntidadOrdenEmbarquePacas1
        End Try
    End Sub
End Class
