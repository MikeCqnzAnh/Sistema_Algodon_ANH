Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.SqlClient
Public Class ExistenciaBodegaPacas
    Public Overridable Sub Upsert(ByRef EntidadExistenciaBodegaPacas As Capa_Entidad.ExistenciaBodegaPacas)
        Dim EntidadExistenciaBodegaPacas1 As New Capa_Entidad.ExistenciaBodegaPacas
        EntidadExistenciaBodegaPacas1 = EntidadExistenciaBodegaPacas
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            Select Case EntidadExistenciaBodegaPacas1.Guarda
                Case Capa_Operacion.Configuracion.Guardar.GuardarDetalle
                    cmdGuardar = New SqlCommand("Sp_ActualizaAlmacenDetalle", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdAlmacenEncabezado", CInt(EntidadExistenciaBodegaPacas1.IdAlmacenEncabezado)))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdLote", EntidadExistenciaBodegaPacas1.IdLote))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Nivel", EntidadExistenciaBodegaPacas1.Nivel))
                    cmdGuardar.Parameters.Add(New SqlParameter("@PosicionColumna", EntidadExistenciaBodegaPacas1.PosicionColumna))
                    cmdGuardar.Parameters.Add(New SqlParameter("@PosicionFila", EntidadExistenciaBodegaPacas1.posicionfila))
                    cmdGuardar.Parameters.Add(New SqlParameter("@BaleID", EntidadExistenciaBodegaPacas1.BaleID))
                    cmdGuardar.Parameters.Add(New SqlParameter("@EstatusAlmacen", EntidadExistenciaBodegaPacas1.EstatusAlmacen))
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
    Public Overridable Sub Consultar(ByRef EntidadExistenciaBodegaPacas As Capa_Entidad.ExistenciaBodegaPacas)
        Dim EntidadExistenciaBodegaPacas1 = New Capa_Entidad.ExistenciaBodegaPacas
        EntidadExistenciaBodegaPacas1 = EntidadExistenciaBodegaPacas
        EntidadExistenciaBodegaPacas1.TablaConsulta = New DataTable
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadExistenciaBodegaPacas1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaAlmacenLote
                    sqlcom1 = New SqlCommand("sp_ConsultaLoteAlmacen", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdAlmacenEncabezado", EntidadExistenciaBodegaPacas1.IdAlmacenEncabezado))
                    sqlcom1.Parameters.Add(New SqlParameter("@IdLote", EntidadExistenciaBodegaPacas1.IdLote))
                    sqlcom1.Parameters.Add(New SqlParameter("@Nivel", EntidadExistenciaBodegaPacas1.Nivel))
                    sqldat1.Fill(EntidadExistenciaBodegaPacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaAlmacen
                    sqlcom1 = New SqlCommand("Sp_ExistePacaBodega", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdAlmacenEncabezado", EntidadExistenciaBodegaPacas1.IdAlmacenEncabezado))
                    sqlcom1.Parameters.Add(New SqlParameter("@Baleid", EntidadExistenciaBodegaPacas1.BaleID))
                    sqldat1.Fill(EntidadExistenciaBodegaPacas1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaEmbarqueParaSalida
                    '    sqlcom1 = New SqlCommand("Sp_ConsultaEmbarqueParaSalida", cnn)
                    '    sqldat1 = New SqlDataAdapter(sqlcom1)
                    '    sqlcom1.CommandType = CommandType.StoredProcedure
                    '    sqlcom1.Parameters.Clear()
                    '    sqlcom1.Parameters.Add(New SqlParameter("@IdEmbarqueEncabezado", EntidadExistenciaBodegaPacas1.IdEmbarqueEncabezado))
                    '    sqlcom1.Parameters.Add(New SqlParameter("@NoLote", EntidadExistenciaBodegaPacas1.NoLote))
                    '    sqldat1.Fill(EntidadExistenciaBodegaPacas1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaCompradores
                    '    sqlcom1 = New SqlCommand("Sp_ConsultaCompradorSalidas", cnn)
                    '    sqldat1 = New SqlDataAdapter(sqlcom1)
                    '    sqlcom1.CommandType = CommandType.StoredProcedure
                    '    sqlcom1.Parameters.Clear()
                    '    sqlcom1.Parameters.Add(New SqlParameter("@Nombre", EntidadExistenciaBodegaPacas1.NombreComprador))
                    '    sqldat1.Fill(EntidadExistenciaBodegaPacas1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadExistenciaBodegaPacas = EntidadExistenciaBodegaPacas1
        End Try
    End Sub
    Public Overridable Sub Actualizar(ByRef EntidadExistenciaBodegaPacas As Capa_Entidad.ExistenciaBodegaPacas)
        Dim EntidadExistenciaBodegaPacas1 As New Capa_Entidad.ExistenciaBodegaPacas
        EntidadExistenciaBodegaPacas1 = EntidadExistenciaBodegaPacas
        Dim cnn As New SqlConnection(conexionPrincipal)
        'Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            'cmdGuardar = New SqlCommand("Sp_ActualizaExistenciaBodegaPacas", cnn)
            'cmdGuardar.CommandType = CommandType.StoredProcedure
            'cmdGuardar.Parameters.Add(New SqlParameter("@IdSalidaPaca", CInt(EntidadExistenciaBodegaPacas1.IdSalidaEncabezado)))
            'cmdGuardar.Parameters.Add(New SqlParameter("@IdEmbarqueEncabezado", EntidadExistenciaBodegaPacas1.IdEmbarqueEncabezado))
            'cmdGuardar.Parameters.Add(New SqlParameter("@NoLote", EntidadExistenciaBodegaPacas1.NoLote))
            'cmdGuardar.Parameters.Add(New SqlParameter("@EstatusSalida", EntidadExistenciaBodegaPacas1.EstatusSalida))
            'cmdGuardar.ExecuteNonQuery()
        Catch ex As Exception
            cnn.Close()
            MsgBox(ex)
        Finally
            cnn.Close()
            'EntidadExistenciaBodegaPacas = EntidadExistenciaBodegaPacas1
        End Try
    End Sub

End Class
