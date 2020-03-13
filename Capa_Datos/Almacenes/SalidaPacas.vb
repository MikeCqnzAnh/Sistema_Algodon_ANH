Imports System.Data.SqlClient
Public Class SalidaPacas
    Public Overridable Sub Upsert(ByRef EntidadSalidaPacas As Capa_Entidad.SalidaPacas)
        Dim EntidadSalidaPacas1 As New Capa_Entidad.SalidaPacas
        EntidadSalidaPacas1 = EntidadSalidaPacas
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("Sp_InsertaSalidaPacas", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdSalidaEncabezado", CInt(EntidadSalidaPacas1.IdSalidaEncabezado)))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEmbarqueEncabezado", EntidadSalidaPacas1.IdEmbarqueEncabezado))
            cmdGuardar.Parameters.Add(New SqlParameter("@NoLote", EntidadSalidaPacas1.NoLote))
            cmdGuardar.Parameters.Add(New SqlParameter("@PesoBruto", EntidadSalidaPacas1.PesoBruto))
            cmdGuardar.Parameters.Add(New SqlParameter("@PesoTara", EntidadSalidaPacas1.PesoTara))
            cmdGuardar.Parameters.Add(New SqlParameter("@PesoNeto", EntidadSalidaPacas1.PesoNeto))
            cmdGuardar.Parameters.Add(New SqlParameter("@Destino", EntidadSalidaPacas1.Destino))
            cmdGuardar.Parameters.Add(New SqlParameter("@NoFactura", EntidadSalidaPacas1.NoFactura))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaEntrada", EntidadSalidaPacas1.FechaEntrada))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaSalida", EntidadSalidaPacas1.FechaSalida))
            cmdGuardar.Parameters.Add(New SqlParameter("@Observaciones", EntidadSalidaPacas1.Observaciones))
            cmdGuardar.Parameters.Add(New SqlParameter("@EstatusSalida", EntidadSalidaPacas1.EstatusSalida))
            cmdGuardar.Parameters("@IdSalidaEncabezado").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadSalidaPacas1.IdSalidaEncabezado = 0 Then
                EntidadSalidaPacas1.IdSalidaEncabezado = cmdGuardar.Parameters("@IdSalidaEncabezado").Value
            End If
        Catch ex As Exception
            cnn.Close()
            MsgBox(ex)
        Finally
            cnn.Close()
            EntidadSalidaPacas = EntidadSalidaPacas1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadSalidaPacas As Capa_Entidad.SalidaPacas)
        Dim EntidadSalidaPacas1 = New Capa_Entidad.SalidaPacas
        EntidadSalidaPacas1 = EntidadSalidaPacas
        EntidadSalidaPacas1.TablaConsulta = New DataTable
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadSalidaPacas1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaPacasEmbarcado
                    sqlcom1 = New SqlCommand("Sp_ConsultaPacasSalidas", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdEmbarqueEncabezado", EntidadSalidaPacas1.IdEmbarqueEncabezado))
                    sqlcom1.Parameters.Add(New SqlParameter("@NoLote", EntidadSalidaPacas1.NoLote))
                    sqldat1.Fill(EntidadSalidaPacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaSalidaPacas
                    sqlcom1 = New SqlCommand("Sp_ConsultaSalidaPacas", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdSalidaPacas", EntidadSalidaPacas1.IdSalidaEncabezado))
                    sqlcom1.Parameters.Add(New SqlParameter("@NombreComprador", EntidadSalidaPacas1.NombreComprador))
                    sqldat1.Fill(EntidadSalidaPacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaEmbarqueParaSalida
                    sqlcom1 = New SqlCommand("Sp_ConsultaEmbarqueParaSalida", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdEmbarqueEncabezado", EntidadSalidaPacas1.IdEmbarqueEncabezado))
                    sqlcom1.Parameters.Add(New SqlParameter("@NoLote", EntidadSalidaPacas1.NoLote))
                    sqldat1.Fill(EntidadSalidaPacas1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadSalidaPacas = EntidadSalidaPacas1
        End Try
    End Sub
End Class
