Imports System.Data.SqlClient
Public Class IntegraciondeCompras
    Public Overridable Sub Upsert(ByRef EntidadIntegraciondeCompras As Capa_Entidad.IntegraciondeCompras)
        Dim EntidadIntegraciondeCompras1 As New Capa_Entidad.IntegraciondeCompras
        EntidadIntegraciondeCompras1 = EntidadIntegraciondeCompras
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            Select Case EntidadIntegraciondeCompras1.Guarda
                Case Capa_Operacion.Configuracion.Guardar.GuardarEncabezado
                    cmdGuardar = New SqlCommand("Pa_InsertIntegracionCompra", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdIntegracionCompra", EntidadIntegraciondeCompras1.IdIntegracion))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdContrato", EntidadIntegraciondeCompras1.IdContrato))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdCompra", EntidadIntegraciondeCompras1.IdCompra))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdProductor", EntidadIntegraciondeCompras1.IdProductor))
                    cmdGuardar.Parameters.Add(New SqlParameter("@ImporteFacturas", EntidadIntegraciondeCompras1.ImporteFacturas))
                    cmdGuardar.Parameters.Add(New SqlParameter("@TotalToneladasFacturas", EntidadIntegraciondeCompras1.TotalToneladas))
                    cmdGuardar.Parameters.Add(New SqlParameter("@TotalPacasFacturas", EntidadIntegraciondeCompras1.TotalPacas))
                    cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadIntegraciondeCompras1.FechaCreacion))
                    cmdGuardar.Parameters.Add(New SqlParameter("@FechaActualizacion", EntidadIntegraciondeCompras1.FechaActualizacion))

                    cmdGuardar.Parameters("@IdIntegracionCompra").Direction = ParameterDirection.InputOutput
                    cmdGuardar.ExecuteNonQuery()
                    If EntidadIntegraciondeCompras1.IdIntegracion = 0 Then
                        EntidadIntegraciondeCompras1.IdIntegracion = cmdGuardar.Parameters("@IdIntegracionCompra").Value
                    End If
                Case Capa_Operacion.Configuracion.Guardar.GuardarFactura
                    cmdGuardar = New SqlCommand("Pa_InsertarFactura", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdIntegracionCompra", EntidadIntegraciondeCompras1.IdIntegracion))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdContrato", EntidadIntegraciondeCompras1.IdContrato))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdCompra", EntidadIntegraciondeCompras1.IdCompra))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdProductor", EntidadIntegraciondeCompras1.IdProductor))
                    cmdGuardar.Parameters.Add(New SqlParameter("@ImporteFacturas", EntidadIntegraciondeCompras1.ImporteFacturas))
                    cmdGuardar.Parameters.Add(New SqlParameter("@TotalToneladasFacturas", EntidadIntegraciondeCompras1.TotalToneladas))
                    cmdGuardar.Parameters.Add(New SqlParameter("@TotalPacasFacturas", EntidadIntegraciondeCompras1.TotalPacas))
                    cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadIntegraciondeCompras1.FechaCreacion))
                    cmdGuardar.Parameters.Add(New SqlParameter("@FechaActualizacion", EntidadIntegraciondeCompras1.FechaActualizacion))

                    cmdGuardar.Parameters("@IdIntegracionCompra").Direction = ParameterDirection.InputOutput
                    cmdGuardar.ExecuteNonQuery()
                    If EntidadIntegraciondeCompras1.IdIntegracion = 0 Then
                        EntidadIntegraciondeCompras1.IdIntegracion = cmdGuardar.Parameters("@IdIntegracionCompra").Value
                    End If
                Case Capa_Operacion.Configuracion.Guardar.GuardarDetalleFactura

            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            EntidadIntegraciondeCompras = EntidadIntegraciondeCompras1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadIntegraciondeCompras As Capa_Entidad.IntegraciondeCompras)
        Dim EntidadIntegraciondeCompras1 As New Capa_Entidad.IntegraciondeCompras
        EntidadIntegraciondeCompras1 = EntidadIntegraciondeCompras
        EntidadIntegraciondeCompras1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadIntegraciondeCompras1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    sqlcom1 = New SqlCommand("Pa_ConsultaFactura", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@UUID", EntidadIntegraciondeCompras1.UUID))
                    sqldat1.Fill(EntidadIntegraciondeCompras1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaCompraPorNombre
                    sqlcom1 = New SqlCommand("Pa_ConsultaCompras", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdCompra", EntidadIntegraciondeCompras1.IdCompra))
                    sqlcom1.Parameters.Add(New SqlParameter("@Nombre", EntidadIntegraciondeCompras1.NombreProductor))
                    sqldat1.Fill(EntidadIntegraciondeCompras1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadIntegraciondeCompras = EntidadIntegraciondeCompras1
        End Try
    End Sub
End Class
