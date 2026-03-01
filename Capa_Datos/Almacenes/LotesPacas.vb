Imports System.Data.SqlClient
Imports Capa_Entidad
Imports Capa_Operacion

Public Class LotesPacas
    Public Overridable Sub Upsert(ByRef EntidadLotesPacas As Capa_Entidad.LotesPacas)
        Dim EntidadLotesPacas1 As New Capa_Entidad.LotesPacas
        EntidadLotesPacas1 = EntidadLotesPacas
        Dim cnn As SqlConnection = conexionPrincipal()
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            Select Case EntidadLotesPacas1.Guarda
                Case Capa_Operacion.Configuracion.Guardar.GuardarEncabezado
                    cmdGuardar = New SqlCommand("Pa_Insertaloteenc", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Add(New SqlParameter("@idlote", CInt(EntidadLotesPacas1.idlote)))
                    cmdGuardar.Parameters.Add(New SqlParameter("@idcomprador", EntidadLotesPacas1.idcomprador))
                    cmdGuardar.Parameters.Add(New SqlParameter("@nolote", EntidadLotesPacas1.nolote))
                    cmdGuardar.Parameters.Add(New SqlParameter("@ubicacion", EntidadLotesPacas1.ubicacion))
                    cmdGuardar.Parameters.Add(New SqlParameter("@observaciones", EntidadLotesPacas1.observaciones))
                    cmdGuardar.Parameters.Add(New SqlParameter("@totalpacas", EntidadLotesPacas1.totalpacas))
                    cmdGuardar.Parameters.Add(New SqlParameter("@totalkilos", EntidadLotesPacas1.totalkilos))
                    cmdGuardar.Parameters.Add(New SqlParameter("@fechacreacion", EntidadLotesPacas1.FechaCreacion))
                    cmdGuardar.Parameters.Add(New SqlParameter("@fechaactualizacion", EntidadLotesPacas1.FechaActualizacion))
                    cmdGuardar.Parameters.Add(New SqlParameter("@idestatus", EntidadLotesPacas1.idestatus))
                    cmdGuardar.Parameters("@idlote").Direction = ParameterDirection.InputOutput
                    cmdGuardar.ExecuteNonQuery()
                    If EntidadLotesPacas1.idlote = 0 Then
                        EntidadLotesPacas1.idlote = cmdGuardar.Parameters("@idlote").Value
                    End If
                Case Capa_Operacion.Configuracion.Guardar.GuardarDetalle
                    cmdGuardar = New SqlCommand("pa_actualizapacalote", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Add(New SqlParameter("@idlote", CInt(EntidadLotesPacas1.idlote)))
                    cmdGuardar.Parameters.Add(New SqlParameter("@idproducciondetalle", EntidadLotesPacas1.idproducciondetalle))
                    cmdGuardar.ExecuteNonQuery()
            End Select
        Catch ex As Exception
            cnn.Close()
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            'EntidadExistenciaBodegaPacas = EntidadExistenciaBodegaPacas1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadLotesPacas As Capa_Entidad.LotesPacas)
        Dim EntidadLotesPacas1 = New Capa_Entidad.LotesPacas
        EntidadLotesPacas1 = EntidadLotesPacas
        EntidadLotesPacas1.TablaConsulta = New DataTable
        Dim cnn As SqlConnection = conexionPrincipal()
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadLotesPacas1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaLotes
                    sqlcom1 = New SqlCommand("pa_consultalotesenc", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.CommandTimeout = 0
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@busqueda", EntidadLotesPacas1.busqueda))
                    sqldat1.Fill(EntidadLotesPacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.Consultapacaslotedet
                    sqlcom1 = New SqlCommand("pa_consultapacaslotedisp", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.CommandTimeout = 0
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@idcomprador", EntidadLotesPacas1.idcomprador))
                    sqldat1.Fill(EntidadLotesPacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.Consultapacasloteseldet
                    sqlcom1 = New SqlCommand("pa_consultapacaslotesel", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.CommandTimeout = 0
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@idlote", EntidadLotesPacas1.idlote))
                    sqldat1.Fill(EntidadLotesPacas1.TablaConsulta)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            EntidadLotesPacas = EntidadLotesPacas1
        End Try
    End Sub
End Class
