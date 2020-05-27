Imports System.Data.SqlClient
Public Class Almacenes
    Public Overridable Sub Upsert(ByRef EntidadAlmacenes As Capa_Entidad.Almacenes)
        Dim EntidadAlmacenes1 As New Capa_Entidad.Almacenes
        EntidadAlmacenes1 = EntidadAlmacenes
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            Select Case EntidadAlmacenes1.Actualiza
                Case Capa_Operacion.Configuracion.Actualiza.ActualizaAlmacenEnc
                    cmdGuardar = New SqlCommand("Sp_InsertaAlmacenEncabezado", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdAlmacenEncabezado", EntidadAlmacenes1.IdAlmacenEncabezado))
                    cmdGuardar.Parameters.Add(New SqlParameter("@TipoAlmacen", EntidadAlmacenes1.IdTipoAlmacen))
                    cmdGuardar.Parameters.Add(New SqlParameter("@CantidadLotes", EntidadAlmacenes1.CantidadLotes))
                    cmdGuardar.Parameters.Add(New SqlParameter("@CantidadNiveles", EntidadAlmacenes1.CantidadNiveles))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Columnas", EntidadAlmacenes1.Columnas))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Filas", EntidadAlmacenes1.filas))
                    cmdGuardar.Parameters.Add(New SqlParameter("@FechaAlta", EntidadAlmacenes1.FechaAlta))
                    cmdGuardar.Parameters("@IdAlmacenEncabezado").Direction = ParameterDirection.InputOutput
                    cmdGuardar.ExecuteNonQuery()
                    If EntidadAlmacenes1.IdAlmacenEncabezado = 0 Then
                        EntidadAlmacenes1.IdAlmacenEncabezado = cmdGuardar.Parameters("@IdAlmacenEncabezado").Value
                    End If
                Case Capa_Operacion.Configuracion.Actualiza.ActualizaAlmacenDet
                    cmdGuardar = New SqlCommand("Sp_InsertaAlmacenDetalle", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdAlmacenDetalle", 0))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdAlmacenEncabezado", EntidadAlmacenes1.IdAlmacenEncabezado))
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdLote", EntidadAlmacenes1.IdLote))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Nivel", DBNull.Value))
                    cmdGuardar.Parameters.Add(New SqlParameter("@PosicionColumna", DBNull.Value))
                    cmdGuardar.Parameters.Add(New SqlParameter("@PosicionFila", DBNull.Value))
                    cmdGuardar.Parameters.Add(New SqlParameter("@BaleID", DBNull.Value))
                    cmdGuardar.ExecuteNonQuery()
                Case Capa_Operacion.Configuracion.Actualiza.ActualizaTipoAlmacen
                    cmdGuardar = New SqlCommand("Sp_InsertarTipoAlmacen", cnn)
                    cmdGuardar.CommandType = CommandType.StoredProcedure
                    cmdGuardar.Parameters.Add(New SqlParameter("@IdTipoAlmacen", 0))
                    cmdGuardar.Parameters.Add(New SqlParameter("@Descripcion", EntidadAlmacenes1.Descripcion))
                    cmdGuardar.Parameters("@IdAlmacenEncabezado").Direction = ParameterDirection.InputOutput
                    cmdGuardar.ExecuteNonQuery()
                    If EntidadAlmacenes1.IdTipoAlmacen = 0 Then
                        EntidadAlmacenes1.IdTipoAlmacen = cmdGuardar.Parameters("@IdTipoAlmacen").Value
                    End If
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadAlmacenes = EntidadAlmacenes1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadAlmacenes As Capa_Entidad.Almacenes)
        Dim EntidadAlmacenes1 = New Capa_Entidad.Almacenes
        EntidadAlmacenes1 = EntidadAlmacenes
        EntidadAlmacenes1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            'cnn.Open()
            'Select Case EntidadAlmacenes1.Consulta
            '    Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
            '        Dim sqldat1 As New SqlDataAdapter("Sp_ConsultaTipoAlmacen", cnn)
            '        sqldat1.Fill(EntidadAlmacenes1.TablaConsulta)
            '    Case Capa_Operacion.Configuracion.Consulta.ConsultaAlmacen
            '        Dim sqldat1 As New SqlDataAdapter("Sp_ConsultaAlmacen", cnn)
            '        sqldat1.Fill(EntidadAlmacenes1.TablaConsulta)
            '    Case Capa_Operacion.Configuracion.Consulta.ConsultaAlmacen
            '        Dim sqldat1 As New SqlDataAdapter("Sp_ConsultaAlmacenEncabezado", cnn)

            '        sqlcom1 = New SqlCommand("sp_EliminarAsociacion", cnn)
            '        sqldat1 = New SqlDataAdapter(sqlcom1)
            '        sqlcom1.CommandType = CommandType.StoredProcedure
            '        sqlcom1.Parameters.Clear()
            '        sqlcom1.Parameters.Add(New SqlParameter("@IdAsociacion", EntidadAsociaciones1.IdAsociacion))
            '        sqldat1.Fill(EntidadAsociaciones1.TablaConsulta)
            'End Select
            cnn.Open()
            Select Case EntidadAlmacenes1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaAlmacen
                    sqlcom1 = New SqlCommand("Sp_ConsultaAlmacenEncabezado", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdAlmacenEncabezado", EntidadAlmacenes1.IdAlmacenEncabezado))
                    sqldat1.Fill(EntidadAlmacenes1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    sqlcom1 = New SqlCommand("Sp_ConsultaTipoAlmacen", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqldat1.Fill(EntidadAlmacenes1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadAlmacenes = EntidadAlmacenes1
        End Try
    End Sub
End Class
